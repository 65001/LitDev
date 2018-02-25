﻿//The following Copyright applies to the LitDev Extension for Small Basic and files in the namespace LitDev.
//Copyright (C) <2011 - 2015> litdev@hotmail.co.uk
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
//along with LitDev Extension.  If not, see <http://www.gnu.org/licenses/>.

using LitDev.Engines;
using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace LitDev
{
    /// <summary>
    /// Create an icon (*.ico) file from an image.
    /// </summary>
    [SmallBasicType]
    public static class LDIcon
    {
        /// <summary>
        /// Create an icon file with 16*16, 24*24, 32*32, 64*64, 128*128 and 256*256 embedded images.
        /// </summary>
        /// <param name="imageName">The file path or ImageList image to create icon from.  Best results will be obtained from a square image.</param>
        /// <param name="iconPath">The full path to save the icon file (using extension *.ico).</param>
        /// <returns>"SUCCESS" or "FAILED"</returns>
        public static Primitive CreateIcon(Primitive imageName, Primitive iconPath)
        {
            try
            {
                Type ImageListType = typeof(ImageList);
                Dictionary<string, BitmapSource> _savedImages;
                BitmapSource img;

                _savedImages = (Dictionary<string, BitmapSource>)ImageListType.GetField("_savedImages", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.IgnoreCase).GetValue(null);
                if (!_savedImages.TryGetValue((string)imageName, out img))
                {
                    imageName = ImageList.LoadImage(imageName);
                    if (!_savedImages.TryGetValue((string)imageName, out img))
                    {
                        return "FAILED";
                    }
                }
                Bitmap bmp = FastPixel.GetBitmap(img);

                using (FileStream outStream = new FileStream(iconPath, FileMode.Create))
                {
                    int[] size = { 16, 24, 32, 64, 128, 256 };

                    BinaryWriter bw = new BinaryWriter(outStream);
                    bw.Write((byte)0);                  // 0-1 reserved (0)
                    bw.Write((byte)0);
                    bw.Write((short)1);                 // 2-3 image type, 1=Icon, 2=Cursor	// bw.Write(icoType);
                    bw.Write((short)size.Length);                 // 4-5 number of images

                    List<byte[]> data = new List<byte[]>();
                    for (int i = 0; i < size.Length; i++)
                    {
                        Bitmap bmpIcon = new Bitmap(bmp, new Size(size[i], size[i]));
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmpIcon.Save(ms, ImageFormat.Png);
                            data.Add(ms.ToArray());
                        }
                    }

                    int offset = 6 + 16 * size.Length;
                    for (int i = 0; i < size.Length; i++)
                    {
                        bw.Write((byte)size[i]);                  //	0 image width	(entry Image#1)
                        bw.Write((byte)size[i]);                  //	1 image height
                        bw.Write((byte)0);                  //	2 number of colors (0 if the image does not use a color palette)
                        bw.Write((byte)0);                  //	3 reserved (0)
                        bw.Write((short)0);                 //	4-5 color planes (Ico: 0 or 1; Cur: horiz. coord. of xHotspot, # of pxl from left)
                        bw.Write((short)32);                //	6-7 bits per pixel (Ico: bpPxl; Cur: vert. coord. of yHotspot, # of pxl from top)
                        bw.Write((int)data[i].Length);    //	8-11 size [Bytes] of image data
                        bw.Write((int)offset);                //	12-15 offset [Bytes] of Bmp/Png image data from beginning (6 + 16)
                        offset += data[i].Length;
                    }

                    for (int i = 0; i < size.Length; i++)
                    {
                        bw.Write(data[i]);      // write image data (must contain the whole png data file)
                    }

                    bw.Flush();
                }
                return "SUCCESS";
            }
            catch (Exception ex)
            {
                Utilities.OnError(Utilities.GetCurrentMethod(), ex);
                return "FAILED";
            }
        }
    }
}
