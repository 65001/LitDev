﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LitDev
{
    enum eLeafType { NONE, COMPOUND, VALUE, PREFIX, NUMBER, UNIT, DERIVEDUNIT, POWER }
    enum eOperatorType { NONE, MULTIPLY, DIVIDE, ADD, SUBTRACT }

    public class BaseUnit
    {
        public string dimension;
        public string name = "";

        public BaseUnit(string dimension, string name)
        {
            this.dimension = dimension;
            this.name = name;
        }
    }

    public class DerivedUnit
    {
        public string name = "";
        public string baseUnits = "";
        public double add = 0;

        public DerivedUnit(string name, string baseUnits, double add = 0)
        {
            this.name = name;
            this.baseUnits = baseUnits;
            this.add = add;
        }
    }

    public class UnitSystem
    {
        public static List<BaseUnit> BaseUnits = new List<BaseUnit>();
        public static List<DerivedUnit> DerivedUnits = new List<DerivedUnit>();
        public static Dictionary<string, double> Prefixes = new Dictionary<string, double>();
        public static Dictionary<string, double> Constants = new Dictionary<string, double>();
        public static List<string> Dimensions = new List<string>();
        public static List<string> Errors = new List<string>();
        private static bool bInitialised = false;

        public UnitSystem()
        {
            if (!bInitialised) Initialise();
            Validate();
        }

        private void Initialise()
        {
            BaseUnits.Clear();
            DerivedUnits.Clear();
            Prefixes.Clear();
            Constants.Clear();
            Dimensions.Clear();

            //PREFIXES
            Prefixes["Y"] = 1.0e24;
            Prefixes["Yotta"] = 1.0e24;
            Prefixes["Z"] = 1.0e21;
            Prefixes["Zetta"] = 1.0e21;
            Prefixes["E"] = 1.0e18;
            Prefixes["Exa"] = 1.0e18;
            Prefixes["P"] = 1.0e15;
            Prefixes["Peta"] = 1.0e15;
            Prefixes["T"] = 1.0e12;
            Prefixes["Tera"] = 1.0e12;
            Prefixes["G"] = 1.0e9;
            Prefixes["Giga"] = 1.0e9;
            Prefixes["M"] = 1.0e6;
            Prefixes["Mega"] = 1.0e6;
            Prefixes["K"] = 1000;
            Prefixes["Kilo"] = 1000;
            Prefixes["H"] = 100;
            Prefixes["Hecto"] = 100;
            Prefixes["D"] = 10;
            Prefixes["Deka"] = 10;
            Prefixes["d"] = 0.1;
            Prefixes["deci"] = 0.1;
            Prefixes["c"] = 0.01;
            Prefixes["centi"] = 0.01;
            Prefixes["m"] = 0.001;
            Prefixes["milli"] = 0.001;
            Prefixes["µ"] = 1.0e-6;
            Prefixes["micro"] = 1.0e-6;
            Prefixes["n"] = 1.0e-9;
            Prefixes["nano"] = 1.0e-9;
            Prefixes["p"] = 1.0e-12;
            Prefixes["pico"] = 1.0e-12;
            Prefixes["f"] = 1.0e-15;
            Prefixes["femto"] = 1.0e-15;
            Prefixes["a"] = 1.0e-18;
            Prefixes["atto"] = 1.0e-18;
            Prefixes["z"] = 1.0e-21;
            Prefixes["zepto"] = 1.0e-21;
            Prefixes["y"] = 1.0e-24;
            Prefixes["yocto"] = 1.0e-24;

            //TIME
            BaseUnits.Add(new BaseUnit("TIME", "s"));

            //LENGTH
            BaseUnits.Add(new BaseUnit("LENGTH",  "m"));

            //MASS
            BaseUnits.Add(new BaseUnit("MASS", "g"));

            //TEMPERATURE
            BaseUnits.Add(new BaseUnit("TEMPERATURE", "K"));

            //Charge
            BaseUnits.Add(new BaseUnit("CHARGE", "Q"));

            //CONSTANTS
            Constants.Add("pi", Math.PI);
            Constants.Add("e", Math.E);

            //Derived Units

            //TIME
            DerivedUnits.Add(new DerivedUnit("min", "(60)s"));
            DerivedUnits.Add(new DerivedUnit("hr", "(60)min"));
            DerivedUnits.Add(new DerivedUnit("day", "(24)hr"));
            DerivedUnits.Add(new DerivedUnit("week", "(7)day"));
            DerivedUnits.Add(new DerivedUnit("year", "(365.25)day"));

            //LENGTH
            DerivedUnits.Add(new DerivedUnit("ft", "(0.3048)m"));
            DerivedUnits.Add(new DerivedUnit("yard", "(3)ft"));
            DerivedUnits.Add(new DerivedUnit("in", "(2.54)cm"));
            DerivedUnits.Add(new DerivedUnit("mile", "(1760)yd"));

            //MASS
            DerivedUnits.Add(new DerivedUnit("lb", "(453.59237)g"));
            DerivedUnits.Add(new DerivedUnit("oz", "(1/16)lb"));
            DerivedUnits.Add(new DerivedUnit("st", "(14)lb"));
            DerivedUnits.Add(new DerivedUnit("ton", "(160)st"));
            DerivedUnits.Add(new DerivedUnit("tonne", "(1000)Kg"));

            //TEMPERATURE
            DerivedUnits.Add(new DerivedUnit("R", "(5/9)K", 0));
            DerivedUnits.Add(new DerivedUnit("C", "K", 273.15));
            DerivedUnits.Add(new DerivedUnit("F", "R", 459.67));

            //FORCE
            DerivedUnits.Add(new DerivedUnit("N", "Kg.m/s2"));
            DerivedUnits.Add(new DerivedUnit("lbf", "(4.4482216152605)N"));

            //ENERGY
            DerivedUnits.Add(new DerivedUnit("J", "N.m"));
            DerivedUnits.Add(new DerivedUnit("BTU", "(1055.06)J"));
            DerivedUnits.Add(new DerivedUnit("erg", "(1.0e-7)J"));
            DerivedUnits.Add(new DerivedUnit("kcal", "(4.184e3)J"));
            DerivedUnits.Add(new DerivedUnit("cal", "(4.184)J"));

            //POWER
            DerivedUnits.Add(new DerivedUnit("W", "J/s"));
            DerivedUnits.Add(new DerivedUnit("hp", "(745.7)W"));

            //AREA
            DerivedUnits.Add(new DerivedUnit("acre", "(4840)yd2"));
            DerivedUnits.Add(new DerivedUnit("hectare", "(10000)m2"));

            //VOLUME
            DerivedUnits.Add(new DerivedUnit("cc", "(1.0e-6)m3"));
            DerivedUnits.Add(new DerivedUnit("bbl", "(5.615)ft3"));
            DerivedUnits.Add(new DerivedUnit("l", "(1.0e-3)m3"));
            DerivedUnits.Add(new DerivedUnit("pintUK", "(568)l"));
            DerivedUnits.Add(new DerivedUnit("pintUS", "(473)l"));
            DerivedUnits.Add(new DerivedUnit("galUK", "(4.54609)l"));
            DerivedUnits.Add(new DerivedUnit("galUS", "(0.8327)galUK"));

            //PRESSURE
            DerivedUnits.Add(new DerivedUnit("Pa", "N/m2"));
            DerivedUnits.Add(new DerivedUnit("Bar", "(1.0e5)Pa"));
            DerivedUnits.Add(new DerivedUnit("Atm", "(1.013)Bar"));
            DerivedUnits.Add(new DerivedUnit("psi", "(6894.75729)Pa"));
            DerivedUnits.Add(new DerivedUnit("psig", "psi", 14.69));

            //Current
            DerivedUnits.Add(new DerivedUnit( "Amp", "Q/s"));

            //Voltage
            DerivedUnits.Add(new DerivedUnit( "Volt", "J/Q"));

            //Resistance
            DerivedUnits.Add(new DerivedUnit("Ohm", "V/I"));

            SetCurrency();

            bInitialised = true;
        }

        private void SetCurrency()
        {
            try
            {
                WebRequest webRequest = WebRequest.Create("http://api.fixer.io/latest");
                WebResponse webResponse = webRequest.GetResponse();
                StreamReader stream = new StreamReader(webResponse.GetResponseStream());
                string[] data = stream.ReadLine().Split(new char[] { '"', ',', ':', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

                bool bRates = false;
                string baseCurrency = "";
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] == "base")
                    {
                        baseCurrency = data[++i];
                        BaseUnits.Add(new BaseUnit("CURRENCY", baseCurrency));
                    }
                    else if (data[i] == "rates")
                    {
                        bRates = true;
                    }
                    else if (bRates)
                    {
                        DerivedUnits.Add(new DerivedUnit(data[i], "(" + (1 / double.Parse(data[++i])) + ")" + baseCurrency));
                    }
                }
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        private void Validate()
        {
            Errors.Clear();

            for (int i = 0; i < BaseUnits.Count; i++)
            {
                for (int j = i + 1; j < BaseUnits.Count; j++)
                {
                    if (BaseUnits[i].name == BaseUnits[j].name)
                    {
                        Errors.Add("Repeated base unit " + BaseUnits[i].name);
                    }
                }
                for (int j = 0; j < DerivedUnits.Count; j++)
                {
                    if (BaseUnits[i].name == DerivedUnits[j].name)
                    {
                        Errors.Add("Base and derived unit conflict " + BaseUnits[i].name);
                    }
                }
            }

            for (int i = 0; i < DerivedUnits.Count; i++)
            {
                for (int j = i + 1; j < DerivedUnits.Count; j++)
                {
                    if (DerivedUnits[i].name == DerivedUnits[j].name)
                    {
                        Errors.Add("Repeated derived unit " + DerivedUnits[i].name);
                    }
                }
            }

            for (int i = 0; i < Prefixes.Count; i++)
            {
                for (int j = i + 1; j < Prefixes.Count; j++)
                {
                    if (Prefixes.ElementAt(i).Key == Prefixes.ElementAt(j).Key)
                    {
                        Errors.Add("Repeated prefix " + Prefixes.ElementAt(i).Key);
                    }
                }
                for (int j = 0; j < Constants.Count; j++)
                {
                    if (Prefixes.ElementAt(i).Key == Constants.ElementAt(j).Key)
                    {
                        Errors.Add("Prefix and constant conflict " + Prefixes.ElementAt(i).Key);
                    }
                }
            }

            for (int i = 0; i < Constants.Count; i++)
            {
                for (int j = i + 1; j < Constants.Count; j++)
                {
                    if (Constants.ElementAt(i).Key == Constants.ElementAt(j).Key)
                    {
                        Errors.Add("Repeated constant " + Constants.ElementAt(i).Key);
                    }
                }
            }

            foreach (KeyValuePair<string, double>kvp in Prefixes)
            {
                if (kvp.Key.Length > 1)
                {
                    foreach (BaseUnit check in BaseUnits)
                    {
                        if (kvp.Key == check.name)
                        {
                            Errors.Add("Prefix and base unit conflict " + kvp.Key);
                        }
                    }
                    foreach (DerivedUnit check in DerivedUnits)
                    {
                        if (kvp.Key == check.name)
                        {
                            Errors.Add("Prefix and base derived unit conflict " + kvp.Key);
                        }
                    }
                    foreach (KeyValuePair<string, double> check in Constants)
                    {
                        if (kvp.Key == check.Key)
                        {
                            Errors.Add("Prefix and constant conflict " + kvp.Key);
                        }
                    }
                }
            }

            if (Errors.Count > 0)
            {
                foreach (string error in Errors)
                {
                    Microsoft.SmallBasic.Library.TextWindow.WriteLine(error);
                }
            }
            SetDimensions();
        }

        private void SetDimensions()
        {
            foreach (BaseUnit unit in BaseUnits)
            {
                if (!Dimensions.Contains(unit.dimension)) Dimensions.Add(unit.dimension);
            }
        }

        public double Convert(double value, string fromUnit, string toUnit)
        {
            try
            {
                //Parse units
                Errors.Clear();
                Leaf fromLeaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, fromUnit);
                if (Errors.Count > 0) return double.NaN;
                Errors.Clear();
                Leaf toLeaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, toUnit);
                if (Errors.Count > 0) return double.NaN;

                //Check dimensionality is correct
                LeafResult resultFrom = fromLeaf.leafResult;
                LeafResult resultTo = toLeaf.leafResult;
                foreach (KeyValuePair<string, double> kvp in resultFrom.dimensions)
                {
                    if (kvp.Value != resultTo.dimensions[kvp.Key])
                    {
                        Errors.Add("Inconsistent Diemsnions");
                        return double.NaN;
                    }
                }

                //Derived units with multipliers and additive for pure units
                double result = (value * fromLeaf.Prefix + fromLeaf.Additive) * fromLeaf.Multiplier;
                result = (result / toLeaf.Multiplier - toLeaf.Additive) / toLeaf.Prefix;
                return result;
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                return double.NaN;
            }
        }

        public Dictionary<string, double> GetDimensions(string unit)
        {
            Errors.Clear();
            try
            {
                //Parse units
                Leaf leaf = new Leaf(eOperatorType.MULTIPLY, eLeafType.COMPOUND, unit);

                //Check dimensionality is correct
                return leaf.leafResult.dimensions;
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                return null;
            }
        }

        public List<string> GetErrors()
        {
            return Errors;
        }

        public Dictionary<string, string> GetBaseUnits()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (BaseUnit unit in BaseUnits)
            {
                units[unit.name] = unit.dimension.ToString();
            }

            return units;
        }

        public Dictionary<string, string> GetDerivedUnits()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (DerivedUnit unit in DerivedUnits)
            {
                units[unit.name] = unit.baseUnits;
                if (unit.add > 0) units[unit.name] += " + " + unit.add;
                else if (unit.add < 0) units[unit.name] += " - " + unit.add;
            }

            return units;
        }

        public Dictionary<string, string> GetConstants()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();

            foreach (KeyValuePair<string, double> kvp in Constants)
            {
                units[kvp.Key] = kvp.Value.ToString();
            }

            return units;
        }

        public Dictionary<string, double> GetPrefixes()
        {
            Dictionary<string, double> units = new Dictionary<string, double>();

            foreach (KeyValuePair<string, double> kvp in Prefixes)
            {
                units[kvp.Key] = kvp.Value;
            }

            return units;
        }

        public void AddBaseUnit(string name, string dimension)
        {
            Errors.Clear();
            try
            {
                BaseUnits.Add(new BaseUnit(dimension, name));
                Validate();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        public void AddDerivedUnit(string name, string units, double add)
        {
            Errors.Clear();
            try
            {
                DerivedUnits.Add(new DerivedUnit(name, units, add));
                Validate();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        public void AddConstant(string name, double value)
        {
            Errors.Clear();
            try
            {
                Constants.Add(name, value);
                Validate();
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }
        }

        public void Serialise(string fileName, bool write)
        {
            Errors.Clear();
            try
            {
                if (write)
                {
                    using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                    {
                        foreach (BaseUnit unit in BaseUnits)
                        {
                            sw.WriteLine("BaseUnit#" + unit.dimension + "#" + unit.name);
                        }
                        foreach (DerivedUnit unit in DerivedUnits)
                        {
                            if (unit.add == 0) sw.WriteLine("DerivedUnit#" + unit.name + "#" + unit.baseUnits);
                            else sw.WriteLine("DerivedUnit#" + unit.name + "#" + unit.baseUnits + "#" + unit.add);
                        }
                        foreach (KeyValuePair<string, double> kvp in Constants)
                        {
                            sw.WriteLine("Constant#" + kvp.Key + "#" + kvp.Value);
                        }
                        //foreach (KeyValuePair<string, double> kvp in Prefixes)
                        //{
                        //    sw.WriteLine("Prefix#" + kvp.Key + "#" + kvp.Value);
                        //}
                    }
                }
                else
                {
                    BaseUnits.Clear();
                    DerivedUnits.Clear();
                    Constants.Clear();
                    //Prefixes.Clear();
                    using (StreamReader sr = new StreamReader(fileName, Encoding.UTF8))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] parts = line.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < parts.Length; i++) parts[i] = parts[i].Trim();

                            switch (parts[0])
                            {
                                case "BaseUnit":
                                    if (parts.Length == 3) BaseUnits.Add(new BaseUnit(parts[1], parts[2]));
                                    break;
                                case "DerivedUnit":
                                    if (parts.Length == 3) DerivedUnits.Add(new DerivedUnit(parts[1], parts[2]));
                                    if (parts.Length == 4) DerivedUnits.Add(new DerivedUnit(parts[1], parts[2], double.Parse(parts[3])));
                                    break;
                                case "Constant":
                                    if (parts.Length == 3) Constants[parts[1]] = double.Parse(parts[2]);
                                    break;
                                case "Prefix":
                                    if (parts.Length == 3) Prefixes[parts[1]] = double.Parse(parts[2]);
                                    break;
                            }
                        }
                    }
                    Validate();
                }
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
            }

        }
    }

    class LeafResult
    {
        public double prefix = 1;
        public double number = 1;
        public double unit = 1;
        public double power = 1;
        public double add = 0;
        public Dictionary<string, double> dimensions = new Dictionary<string, double>();

        public LeafResult()
        {
            foreach (string dimension in UnitSystem.Dimensions)
            {
                dimensions[dimension] = 0;
            }
        }
    }

    class Leaf
    {
        string rawPart = "";
        eLeafType eLeaf = eLeafType.NONE;
        eOperatorType eOperator = eOperatorType.NONE;

        string part = "";
        List<Leaf> children = new List<Leaf>();
        BaseUnit baseUnit = null;
        double value = 0;
        public LeafResult leafResult = new LeafResult();

        public double Additive
        {
            get
            {
                return leafResult.add;
            }
        }

        public double Multiplier
        {
            get
            {
                if (eLeaf == eLeafType.VALUE)
                {
                    return children[1].value;
                }
                return value;
            }
        }

        public double Prefix
        {
            get
            {
                if (eLeaf == eLeafType.VALUE)
                {
                    return value / children[1].value;
                }
                return 1;
            }
        }

        public Leaf(eOperatorType eOperator, eLeafType eLeaf, string rawPart)
        {
            this.eOperator = eOperator;
            this.eLeaf = eLeaf;
            this.rawPart = rawPart;

            Parse();
        }

        private void Parse()
        {
            double number = 0;

            //Trim any start and end bits
            part = Trim(rawPart);

            //Empty part is default values
            if (part == "")
            {
                if (eLeaf == eLeafType.UNIT) value = 1; //A null unit for a pure number value
                return;
            }

            //Part is a Prefix
            if (eLeaf == eLeafType.PREFIX)
            {
                string[] vals = part.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string val in vals)
                {
                    string[] bits = val.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < bits.Length; i++)
                    {
                        string bit = bits[i];
                        if (double.TryParse(bit, out number))
                        {
                            if (i == 0) leafResult.prefix *= number;
                            else leafResult.prefix /= number;
                            goto nextBit;
                        }
                        foreach (KeyValuePair<string, double> kvp in UnitSystem.Prefixes)
                        {
                            if (bit == kvp.Key)
                            {
                                if (i == 0) leafResult.prefix *= kvp.Value;
                                else leafResult.prefix /= kvp.Value;
                                goto nextBit;
                            }
                        }
                        foreach (KeyValuePair<string, double> kvp in UnitSystem.Constants)
                        {
                            if (bit == kvp.Key)
                            {
                                if (i == 0) leafResult.prefix *= kvp.Value;
                                else leafResult.prefix /= kvp.Value;
                                goto nextBit;
                            }
                        }
                        UnitSystem.Errors.Add("Prefix could not be found : " + part);
                        nextBit:;
                    }
                }
                return;
            }

            //Part is a Power
            if (eLeaf == eLeafType.POWER)
            {
                if (double.TryParse(part, out leafResult.power))
                {
                    return;
                }
                UnitSystem.Errors.Add("Power could not be found : " + part);
                return;
            }

            //Part is a base unit
            if (eLeaf == eLeafType.UNIT)
            {
                foreach (BaseUnit unit in UnitSystem.BaseUnits)
                {
                    if (part == unit.name)
                    {
                        leafResult.dimensions[unit.dimension] = 1;
                        baseUnit = unit;
                        value = 1;
                        return;
                    }
                }
                UnitSystem.Errors.Add("Base unit could not be found : " + part);
                return;
            }

            //Split operators
            if (!double.TryParse(part, out number)) SplitOperators();
            if (children.Count > 0)
            {
                UpdateCompound();
                return;
            }
            
            //Parse a possible derived unit
            foreach (DerivedUnit unit in UnitSystem.DerivedUnits)
            {
                int pos = part.LastIndexOf(unit.name);
                if (pos < 0) continue;

                children.Add(new Leaf(eOperatorType.NONE, eLeafType.PREFIX, part.Substring(0, pos)));
                children.Add(new Leaf(eOperatorType.MULTIPLY, eLeafType.DERIVEDUNIT, unit.baseUnits));
                children.Add(new Leaf(eOperatorType.NONE, eLeafType.POWER, part.Substring(pos + unit.name.Length)));

                if (UnitSystem.Errors.Count > 0)
                {
                    children.Clear();
                    UnitSystem.Errors.Clear();
                    continue;
                }

                UpdateValue();
                leafResult.add = unit.add;
                return;
            }

            //Parse a possible base unit
            foreach (BaseUnit unit in UnitSystem.BaseUnits)
            {
                int pos = part.LastIndexOf(unit.name);
                if (pos < 0) continue;

                children.Add(new Leaf(eOperatorType.NONE, eLeafType.PREFIX, part.Substring(0, pos)));
                children.Add(new Leaf(eOperatorType.MULTIPLY, eLeafType.UNIT, unit.name));
                children.Add(new Leaf(eOperatorType.NONE, eLeafType.POWER, part.Substring(pos + unit.name.Length)));

                if (UnitSystem.Errors.Count > 0)
                {
                    children.Clear();
                    UnitSystem.Errors.Clear();
                    continue;
                }

                UpdateValue();
                return;
            }

            //Parse a pure number
            children.Add(new Leaf(eOperatorType.NONE, eLeafType.PREFIX, part));
            children.Add(new Leaf(eOperatorType.MULTIPLY, eLeafType.UNIT, ""));
            children.Add(new Leaf(eOperatorType.NONE, eLeafType.POWER, ""));

            if (UnitSystem.Errors.Count > 0)
            {
                UnitSystem.Errors.Add("Unit could not be found : " + part);
                return;
            }

            UpdateValue();
        }

        private void UpdateValue()
        {
            eLeaf = eLeafType.VALUE;

            leafResult.number *= children[0].leafResult.number;
            leafResult.prefix *= children[0].leafResult.prefix;
            leafResult.power *= children[2].leafResult.power;

            value = Math.Pow(leafResult.number * leafResult.prefix * children[1].value, leafResult.power);
            foreach (KeyValuePair<string, double> kvp in children[1].leafResult.dimensions)
            {
                leafResult.dimensions[kvp.Key] = kvp.Value * leafResult.power;
            }
        }

        private void UpdateCompound()
        {
            foreach (Leaf child in children)
            {
                switch (child.eOperator)
                {
                    case eOperatorType.NONE:
                        break;
                    case eOperatorType.MULTIPLY:
                        if (value == 0) value = child.value;
                        else value *= child.value;
                        foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                        {
                            leafResult.dimensions[kvp.Key] += kvp.Value;
                        }
                        break;
                    case eOperatorType.DIVIDE:
                        if (value == 0) value = 1 / child.value;
                        else value /= child.value;
                        foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                        {
                            leafResult.dimensions[kvp.Key] -= kvp.Value;
                        }
                        break;
                    case eOperatorType.ADD:
                        if (child.leafResult.dimensions.Values.Sum() == 0) //A dimensionless number
                        {
                            value *= 1 + child.value;
                        }
                        else
                        {
                            value += child.value;
                            foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                            {
                                if (leafResult.dimensions[kvp.Key] == 0) leafResult.dimensions[kvp.Key] = kvp.Value;
                                if (leafResult.dimensions[kvp.Key] != kvp.Value)
                                {
                                    UnitSystem.Errors.Add("Cannot add incompatible dimensions : " + part);
                                }
                            }
                        }
                        break;
                    case eOperatorType.SUBTRACT:
                        if (child.leafResult.dimensions.Values.Sum() == 0) //A dimensionless number
                        {
                            value *= 1 - child.value;
                        }
                        else
                        {
                            value -= child.value;
                            foreach (KeyValuePair<string, double> kvp in child.leafResult.dimensions)
                            {
                                if (leafResult.dimensions[kvp.Key] == 0) leafResult.dimensions[kvp.Key] = kvp.Value;
                                if (leafResult.dimensions[kvp.Key] != kvp.Value)
                                {
                                    UnitSystem.Errors.Add("Cannot subtract incompatible dimensions : " + part);
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void SplitOperators()
        {
            int iBracket = 0;
            string childPart = "";
            eOperatorType childOperator = eOperatorType.MULTIPLY;
            for (int i = 0; i < part.Length; i++)
            {
                char c = part[i];
                switch (c)
                {
                    case '(':
                        iBracket++;
                        break;
                    case ')':
                        iBracket--;
                        break;
                    case '.':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            childOperator = eOperatorType.MULTIPLY;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '/':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            childOperator = eOperatorType.DIVIDE;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '+':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            childOperator = eOperatorType.ADD;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case '-':
                        if (iBracket == 0)
                        {
                            children.Add(new Leaf(childOperator, eLeaf, childPart));
                            childOperator = eOperatorType.SUBTRACT;
                            childPart = "";
                        }
                        else
                            childPart += c;
                        break;
                    case ' ':
                        break;
                    default:
                        childPart += c;
                        break;
                }
            }
            if (children.Count > 0) children.Add(new Leaf(childOperator, eLeaf, childPart));
        }

        private string Trim(string part)
        {
            part = part.Trim();
            if (part.StartsWith("(") && part.EndsWith(")")) part = part.Trim(new char[] { ' ', '(', ')' });
            return part;
        }
    }
}