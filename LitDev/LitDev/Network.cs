﻿//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2020> litdev@hotmail.co.uk
//This file is part of the LitDev Extension for Small Basic.

//LitDev Extension is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//LitDev Extension is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with menu.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace LitDev
{
    /// <summary>
    /// Network or web methods.
    /// </summary>
    [SmallBasicType]
    public static class LDNetwork
    {
        private static string ConvertToPrimitive(string input)
        {
            int pos = input.IndexOf("<br>");
            if (pos >= 0) input = input.Substring(0, pos);
            input = input.Replace("\\\\", "\\"); //fix for multi-dimensional array escape characters
            if (Microsoft.SmallBasic.Library.Array.GetItemCount(input) > 0) input = Utilities.CreateArrayMap(input);
            return input;
        }

        /// <summary>
        /// Upload a potential high score to the web.
        /// All values are case sensitive and the score should be an integer number.
        /// </summary>
        /// <param name="game">The game name (a unique name for each game or version is required).</param>
        /// <param name="user">The user name.</param>
        /// <param name="score">The score.</param>
        /// <returns>An array with the current high score user name and their score.</returns>
        public static Primitive HighScore(Primitive game, Primitive user, Primitive score)
        {
            string url = Utilities.URL + "/highscore/server.php?program=" + game + "&user=" + user + "&score=" + score;
            StreamReader streamReader = null;
            WebResponse webResponse = null;
            string result = "";
            try
            {
                WebRequest webRequest = WebRequest.Create(url);
                webResponse = webRequest.GetResponse();
                streamReader = new StreamReader(webResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (webResponse != null) webResponse.Close();
            }
            string[] stringSeparators = new string[] { "=", ";" };
            string[] lines = result.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length < 4) return "";
            return Utilities.CreateArrayMap("1=" + lines[1] + ";2=" + lines[3] + ";");
        }

        /// <summary>
        /// Upload some data for a game.
        /// </summary>
        /// <param name="game">The game name (a unique case sensitive name for each game or version is required).</param>
        /// <param name="data">The data to store, may be an array.</param>
        /// <returns>The stored data on success.</returns>
        public static Primitive SetGameData(Primitive game, Primitive data)
        {
            string url = Utilities.URL + "/gamedata/server.php?program=" + game + "&action=1" + "&info=" + data;
            StreamReader streamReader = null;
            WebResponse webResponse = null;
            string result = "";
            try
            {
                WebRequest webRequest = WebRequest.Create(url);
                webResponse = webRequest.GetResponse();
                streamReader = new StreamReader(webResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (webResponse != null) webResponse.Close();
            }
            return ConvertToPrimitive(result);
        }

        /// <summary>
        /// Download some data (previously saved) for a game.
        /// </summary>
        /// <param name="game">The game name (a unique case sensitive name for each game or version is required).</param>
        /// <returns>The stored data on success.</returns>
        public static Primitive GetGameData(Primitive game)
        {
            string url = Utilities.URL + "/gamedata/server.php?program=" + game + "&action=0" + "&info=";
            StreamReader streamReader = null;
            WebResponse webResponse = null;
            string result = "";
            try
            {
                WebRequest webRequest = WebRequest.Create(url);
                webResponse = webRequest.GetResponse();
                streamReader = new StreamReader(webResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
            }
            finally
            {
                if (streamReader != null) streamReader.Close();
                if (webResponse != null) webResponse.Close();
            }
            return ConvertToPrimitive(result);
        }

        private static Dictionary<PingReply, string> pings = new Dictionary<PingReply, string>();
        private static int pingCount = 0;
        private static object lockPing = new object();
        private static void DoPingAsync(object obj)
        {
            object[] args = (object[])obj;
            string ip = (string)args[0];
            int timeout = (int)args[1];
            PingReply reply = DoPing(ip, timeout);
            lock (lockPing)
            {
                if (null != reply && reply.Status == IPStatus.Success) pings[reply] = Dns.GetHostEntry(ip).HostName;
                pingCount--;
            }
        }
        private static PingReply DoPing(string ip, int timeout)
        {
            Ping ping = new Ping();
            return ping.Send(ip, timeout);
        }

        /// <summary>
        /// Get a list of the devices and their addresses connected to your local area network (LAN, home network, 192.168.1.xx).
        /// </summary>
        /// <param name="timeout">A timeout in ms, e.g. 1000.</param>
        /// <returns>An array of IP address and device names with ping time, indexed by IP address.</returns>
        public static Primitive LAN(Primitive timeout)
        {
            try
            {
                lockPing = 0;
                pings.Clear();
                for (int i = 1; i < 256; i++)
                {
                    Thread thread = new Thread(new ParameterizedThreadStart(DoPingAsync));
                    thread.Start(new object[] {"192.168.1." + i.ToString(), (int)timeout});
                    lock (lockPing) pingCount++;
                }
                DateTime start = DateTime.Now;
                while (pingCount > 0 && (DateTime.Now - start) < TimeSpan.FromMilliseconds(timeout)) Thread.Sleep(1);
                string result = "";
                foreach (KeyValuePair<PingReply, string> pair in pings)
                {
                    result += Utilities.ArrayParse(pair.Key.Address.ToString()) + "=" + Utilities.ArrayParse(pair.Value + " (" + pair.Key.RoundtripTime.ToString() + "ms)") + ";";
                }
                return Utilities.CreateArrayMap(result);
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "";
            }
        }

        /// <summary>
        /// Ping an IP address and return the roundtrip time.
        /// </summary>
        /// <param name="IP">The IP address (or url) to ping.</param>
        /// <param name="timeout">A timeout in ms, e.g. 1000.</param>
        /// <returns>The roundtrip time on success (ms) or -1 on failure</returns>
        public static Primitive Ping(Primitive IP, Primitive timeout)
        {
            try
            {
                PingReply reply = DoPing(IP, timeout);
                return reply.Status == IPStatus.Success ? (int)reply.RoundtripTime : -1;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return -1;
            }
        }

        /// <summary>
        /// Similar To Network.DownloadFile, except the download file is input and handles larger files better.
        /// </summary>
        /// <param name="localFile">The local file name to save the downloaded file.</param>
        /// <param name="remoteFile">The remote network file.</param>
        /// <returns>The size of the file in bytes or -1 for failue.</returns>
        public static Primitive DownloadFile(Primitive localFile, Primitive remoteFile)
        {
            try
            {
                FileInfo fileInf = new FileInfo(localFile);
                Uri uri = new Uri(remoteFile);
                WebRequest webRequest = WebRequest.Create(uri);

                int bufferSize = 2048;
                byte[] buffer = new byte[bufferSize];

                FileStream fs = fileInf.OpenWrite();
                WebResponse webResponse = webRequest.GetResponse();
                Stream stream = webResponse.GetResponseStream();

                int readCount = stream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    fs.Write(buffer, 0, readCount);
                    readCount = stream.Read(buffer, 0, bufferSize);
                }

                stream.Close();
                fs.Close();
                webResponse.Close();
                return (decimal)fileInf.Length;
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return -1;
            }
        }
    }
}
