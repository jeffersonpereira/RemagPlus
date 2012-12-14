using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamagPlus.Importacao
{
    public static class StringExtensions
    {
        public static decimal StrToDecimal(this string value,int casaDecimal = 2)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return decimal.Zero;
            }

            for (int i = 0; i < value.Length; i++)
            {
                if(!char.IsDigit(value[i]) && !char.Equals(value[i],','))
                {
                    return decimal.Zero;
                }
            }
            int length = value.Length - casaDecimal;
            if(casaDecimal > 0)
            {
                value = value.Substring(0, length) + "," + value.Substring(length, casaDecimal);
            }
            decimal valor;
            if (!decimal.TryParse(value, out valor))
            {
                throw new ArgumentException(string.Format("Não foi possível converter {0} para decimal",value));
            }
            return valor;
        }
    }
}
