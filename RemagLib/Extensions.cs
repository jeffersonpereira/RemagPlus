using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data;
using System.IO;
using System.Globalization;
using RemagLib;

namespace RemagPlus.Extensao
{
    public static class Extensions
    {
        /// <summary>
        /// Espaços à esquerda.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="value"></param>
        /// <param name="tamanho"></param>
        /// <param name="removeAcento"></param>
        public static void WriteRight(this TextWriter file,string value, int tamanho, bool removeAcento = true)
        {
            if (value.Length > tamanho)
            {
                value = value.Substring(0, tamanho);
            }
            if (value == null)
            {
                value = string.Empty;
            }
            if (removeAcento)
            {
                value = value.RemoverAcentos();
            }
            file.Write(value.SpaceRight(tamanho));
        }

        /// <summary>
        /// Zeros à direita.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="value"></param>
        /// <param name="zeros"></param>
        public static void WriteLeft(this TextWriter file, int value, int zeros)
        {
            file.Write(value.ToString().StrZeroLeft(zeros));
        }

        /// <summary>
        /// Zeros à direita.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="value"></param>
        /// <param name="zeros"></param>
        public static void WriteCurrency(this TextWriter file, decimal value, int tamanho)
        {
            string valor = value.DecimalToString();
            file.WriteLeft(valor, tamanho);
        }

        /// <summary>
        /// Zeros à direita.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="value"></param>
        /// <param name="zeros"></param>
        public static void WriteLeft(this TextWriter file, string value, int zeros)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                value = "0";
            }
            value = value.TrimStart();
            value = value.TrimEnd();
            file.Write(value.StrZeroLeft(zeros));
        }

        public static T LoadKey<T>(this DataEntities context, string propriedade, object keyValue)
        {
            IEnumerable<KeyValuePair<string, object>> entityKeyValues =
            new KeyValuePair<string, object>[] {
           new KeyValuePair<string, object>(propriedade, keyValue) };
            EntityKey key = new EntityKey(context.GetType().Name + "." + typeof(T).Name, entityKeyValues);
            return (T)context.GetObjectByKey(key);
        }
        /// <summary>
        /// Retorna o primeiro dia de uma data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DateTime ToFirstDay(this DateTime data)
        {
            data = new DateTime(data.Year, data.Month, 01);
            return data;
        }

        /// <summary>
        /// Retorna o último dia de uma data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DateTime ToLastDay(this DateTime data)
        {
            data = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            return data;
        }

        /// <summary>
        /// Retorna string com espaços a esquerda
        /// </summary>
        /// <param name="value"></param>
        /// <param name="space"></param>
        /// <returns></returns>

        public static string SpaceRight(this string value, int space)
        {
            return value.PadRight(space, ' ');
        }

        /// <summary>
        /// Retorna string com zeros a Direita
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeros"></param>
        /// <returns></returns>
        public static string StrZeroLeft(this string value, int zeros)
        {
            return value.PadLeft(zeros, '0');
        }

        /// <summary>
        /// Retorna string com zeros a esquerda
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeros"></param>
        /// <returns></returns>
        public static string StrZeroRight(this string value,int zeros)
        {
            return value.PadRight(zeros, '0');
        }

        /// <summary>
        /// Retorna decimal formatado para string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public static string DecimalToString(this decimal value)
        {
            return string.Format("{0:0.##}", (value * 100));
        }

        private static string RemoverAcentos(this string texto)
        {
            string s = texto.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            for (int k = 0; k < s.Length; k++)
            {
                UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(s[k]);
                if (uc != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[k]);
                }
            }
            return sb.ToString();
        }
    }
}
