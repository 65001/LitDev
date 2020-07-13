using System;
using System.Text;

namespace LitDev.Finances
{
    public class FinancialWrapper<T>
    {
        public string symbol;
        public T[] financials;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"symbol={symbol};");
            for (int i = 0; i < financials.Length; i++)
            {
                sb.AppendFormat("{0}={1};", (i + 1), Utilities.ArrayParse( financials[i].ToString() ) );
            }

            return sb.ToString();
        }
    }
}