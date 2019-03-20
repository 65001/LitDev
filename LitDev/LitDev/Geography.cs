﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using LitDev;
using Microsoft.SmallBasic.Library;
using Newtonsoft.Json;

namespace LitDev
{
    /// <summary>
    /// This is an abstraction layer around the API.
    /// If we change the API's source or change API
    /// providers LD Geography should not have to change.
    /// </summary>
    [HideFromIntellisense]
    public static class Geography
    {
        private const string baseURL = "https://restcountries.eu/rest/v2";
        public static string query;
        public static string json;

        public static List<Country> GetAllCountries()
        {
            query = $"{baseURL}/all";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query)); ;
        }

        public static List<Country> GetCountriesByName(string name)
        {
            query = $"{baseURL}/name/{name}";

            if (FullTextSearch || Fields?.Length > 0)
            {
                query += "?";

                if (FullTextSearch)
                {
                   query += "fullText=true";
                }

                if (Fields?.Length > 0)
                {
                    if (FullTextSearch)
                    {
                        query += "&";
                    }

                    query += $"fields={ ArrayToURL(Fields)}";
                }
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query)); 
        }

        public static List<Country> GetCountriesByCode(string[] codes)
        {
            try
            {
                query = $"{baseURL}/alpha";
                query += $"?codes={ArrayToURL(codes)}";


                if (Fields?.Length > 0)
                {
                    if (codes.Length == 1)
                    {
                        query += "?";
                    }

                    query += $"fields={ArrayToURL(Fields)}";
                }

                return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
            }
            catch (Exception ex)
            {
                throw new Exception(query + "\n" + ex.ToString());
            }
        }

        public static List<Country> GetCountriesByCurrency(string currency)
        {
            query = $"{baseURL}/currency/{currency}";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCapital(string capital)
        {
            query = $"{baseURL}/capital/{capital}";

            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByCallingCode(string callingCode)
        {
            query = $"{baseURL}/callingcode/{callingCode}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByRegion(string region)
        {
            query = $"{baseURL}/region/{region}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        public static List<Country> GetCountriesByRegionalBloc(string bloc)
        {
            query = $"{baseURL}/regionalbloc/{bloc}";
            if (Fields?.Length > 0)
            {
                query += $"?fields={ArrayToURL(Fields)}";
            }

            return JsonConvert.DeserializeObject<List<Country>>(JSON(query));
        }

        private static string JSON(string URL)
        {
            json = Response(Request(URL));
            return json;
        }

        private static WebRequest Request(string URL)
        {
            WebRequest WR = WebRequest.Create(URL);
            WR.ContentType = "application/x-www-form-urlencoded";
            WR.Method = "GET";
            return WR;
        }

        private static string Response(WebRequest WR)
        {
            WebResponse response = WR.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader translatedStream = new StreamReader(stream, Encoding.UTF8);
            return translatedStream.ReadToEnd();
        }

        private static string ArrayToURL(string[] fields)
        {
            string temp = string.Empty;
            for (int i = 0; i < fields.Count(); i++)
            {
                temp += fields[i];

                if (i < fields.Length)
                {
                    temp += ";";
                }
            }

            return temp;
        }

        public static string[] Fields;
        public static bool FullTextSearch;
    }

    public struct Country
    {
        public string Name;
        public string[] TopLevelDomain;
        public string Alpha2Code;
        public string Alpha3Code;
        public string[] CallingCodes;
        public string[] AltSpellings;
        public string Region;
        public decimal[] Latlng;
        public string Demonym;
        public decimal? Area;
        public string GINI;
        public string[] Timezones;
        public string[] Borders;
        public string NativeName;
        public int? NumericCode;

        public string CIOC;
        public string Flag;

        public Currency[] Currencies;
        public Language[] Languages;
        public RegionalBloc[] RegionalBlocs;

        //TODO Replace Primitive methods with stringbuilder
        public override string ToString()
        {
            Primitive results = new Primitive();
            if (!string.IsNullOrWhiteSpace(Name))
            {
                results["name"] = Name;
            }

            if (TopLevelDomain?.Length > 0)
            {
                results["TLD"] = TopLevelDomain.ToPrimitiveArrayNative();
            }

            if (!string.IsNullOrWhiteSpace(Alpha2Code)) { 
                results["alpha2Code"] = Alpha2Code;
            }

            if (!string.IsNullOrWhiteSpace(Alpha3Code))
            {
                results["alpha3Code"] = Alpha3Code;
            }

            if (CallingCodes?.Length > 0)
            {
                results["callingCodes"] = CallingCodes.ToList().ToPrimitiveArrayNative();
            }

            if (AltSpellings?.Length > 0)
            {
                results["altSpellings"] = AltSpellings.ToPrimitiveArrayNative();
            }

            if (!string.IsNullOrEmpty(Region))
            {
                results["region"] = Region;
            }

            if (!string.IsNullOrWhiteSpace(Demonym))
            {
                results["demonym"] = Demonym;
            }

            if (Latlng?.Length >= 1)
            {
                results["latitude"] = Latlng[0];
                results["longitude"] = Latlng[1];
            }

            if (Area != null)
            {
                results["area"] = (decimal) Area;
            }

            if (NumericCode != null)
            {
                results["numericCode"] = (int)NumericCode;
            }

            if (!string.IsNullOrWhiteSpace(GINI))
            {
                results["GINI"] = GINI;
            }

            if (Timezones?.Length > 0)
            {
                results["timezones"] = Timezones.ToPrimitiveArrayNative();
            }

            if (Borders?.Length > 0)
            {
                results["borders"] = Borders.ToPrimitiveArrayNative();
            }

            if (!string.IsNullOrWhiteSpace(CIOC))
            {
                results["CIOC"] = CIOC;
            }

            if (!string.IsNullOrWhiteSpace(Flag))
            {
                results["flag"] = Flag;
            }

            if (Currencies?.Length > 0)
            {
                results["currencies"] = Currencies.ToPrimitiveArrayNative();
            }

            if (Languages?.Length > 0)
            {
                results["languages"] = Languages.ToPrimitiveArrayNative();
            }

            if (RegionalBlocs?.Length > 0)
            {
                results["regionalBlocs"] = RegionalBlocs.ToPrimitiveArrayNative();
            }

            return results;
        }
    }

    public struct Currency
    {
        public string Code;
        public string Name;
        public string Symbol;

        public override string ToString()
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(Code))
            {
                result += $"code={Code};";
            }

            if (!string.IsNullOrEmpty(Name))
            {
                result += $"name={Name};";
            }

            if (!string.IsNullOrEmpty(Symbol))
            {
                result += $"symbol={Symbol};";
            }

            return result;
        }
    }

    public struct Language
    {
        public string ISO639_1;
        public string ISO639_2;
        public string Name;
        public string NativeName;

        public override string ToString()
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(ISO639_1))
            {
                result += $"ISO639_1={ISO639_1};";
            }

            if (!string.IsNullOrWhiteSpace(ISO639_2))
            {
                result += $"ISO639_2={ISO639_2};";
            }

            if (!string.IsNullOrWhiteSpace(Name))
            {
                result += $"name={Name};";
            }

            if (!string.IsNullOrWhiteSpace(NativeName))
            {
                result += $"nativeName={NativeName};";
            }

            return result;
        }
    }

    public class Translation
    {
        public string DE;
        public string ES;
        public string FR;
        public string JA;
        public string IT;
        public string BR;
        public string PT;

        public override string ToString()
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(DE))
            {
                result += $"de={DE};";
            }

            if (!string.IsNullOrWhiteSpace(ES))
            {
                result += $"es={ES};";
            }

            if (!string.IsNullOrWhiteSpace(FR))
            {
                result += $"fr={FR};";
            }

            if (!string.IsNullOrWhiteSpace(JA))
            {
                result += $"ja={JA};";
            }

            if (!string.IsNullOrWhiteSpace(IT))
            {
                result += $"it={IT};";
            }

            if (!string.IsNullOrWhiteSpace(BR))
            {
                result += $"br={BR};";
            }

            if (!string.IsNullOrWhiteSpace(PT))
            {
                result += $"pt={PT};";
            }

            return result;
        }
    }

    public class RegionalBloc
    {
        public string Acronym;
        public string Name;
        public string[] OtherAcronyms;
        public string[] OtherNames;

        public override string ToString()
        {
            Primitive result = string.Empty;
            result["otherAcronyms"] = OtherAcronyms.ToPrimitiveArrayNative();
            result["otherNames"] = OtherNames.ToPrimitiveArrayNative();
            result["name"] = Name;
            result["acronym"] = Acronym;

            return result;
        }
    }

    /// <summary>
    /// Gets geographic information about countries and
    /// regional blocks.
    /// API provided by https://restcountries.eu
    /// Data provided by https://github.com/mledoze/countries
    /// Coded by Abhishek Sathiabalan
    /// </summary>
    [SmallBasicType]
    [HideFromIntellisense]
    public static class LDGeography
    {
        /// <summary>
        /// Whenever possible make the search require an exact match
        /// between the query and the results.
        /// </summary>
        public static Primitive StrictSearch
        {
            get { return Geography.FullTextSearch.ToString(); }

            set
            {
                bool result;
                if (bool.TryParse(value, out result))
                {
                    Geography.FullTextSearch = result;
                }
            }
        } 

        /// <summary>
        /// An array of fields that the results will
        /// contain. Fields not specified will not be
        /// returned.
        /// </summary>
        public static Primitive Fields
        {
            get { return Geography.Fields.ToPrimitiveArray(); }
            set { Geography.Fields = LimitFields(value); }
        }

        private static string[] LimitFields(Primitive fields)
        {
            string[] data = new string[fields.GetItemCount()];
            for (int i = 1; i <= fields.GetItemCount(); i++)
            {
                data[i - 1] = fields[i];
            }

            return data;
        }

        public static Primitive GetAllCountries()
        {
            try
            {
                return Geography.GetAllCountries().ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        public static Primitive GetCountriesByName(Primitive name)
        {
            try
            {
                return Geography.GetCountriesByName(name).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        public static Primitive GetCountriesByCode(Primitive code)
        {
            try
            {
                return Geography.GetCountriesByCode(LimitFields(code)).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        public static Primitive GetCountriesByCurrency(Primitive currency)
        {
            try
            {
                return Geography.GetCountriesByCurrency(currency).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        public static Primitive GetCountriesByCapital(Primitive capital)
        {
            try
            {
                return Geography.GetCountriesByCapital(capital).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        public static Primitive GetCountriesByCallingCode(Primitive callingCode)
        {
            try
            {
                return Geography.GetCountriesByCallingCode(callingCode).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }        }

        public static Primitive GetCountriesByRegion(Primitive region)
        {
            try
            {
                return Geography.GetCountriesByRegion(region).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }

        public static Primitive GetCountriesByRegionalBloc(Primitive regionalBloc)
        {
            try
            {
                return Geography.GetCountriesByRegionalBloc(regionalBloc).ToPrimitiveArrayNative();
            }
            catch (Exception ex)
            {
                return "FAILED";
            }
        }
    }
}
