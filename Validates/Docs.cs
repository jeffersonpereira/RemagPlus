using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Validates
{
    public static class Docs
    {
        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador = new int[] { 10,9,8,7,6,5,4,3,2};
            int[] multiplicador2 = new int[] { 11,10, 9, 8, 7, 6, 5, 4, 3, 2 };
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length < 11)
            {
                return false;
            }
            string digito = string.Empty;
            for (int a = 0; a < 2; a++)
            {
                int[] vetor = multiplicador;
                if (a == 1)
                {
                    vetor = multiplicador2;
                }
                int soma = 0;
                for (int i = 0; i < vetor.Length; i++)
                {
                    soma += int.Parse(cpf[i].ToString()) + vetor[i];
                }
                int temp = soma % cpf.Length;
                temp = temp > 2 ? 0 : cpf.Length - temp;
                digito += temp.ToString();
            }

            return string.Equals(digito, cpf.Substring(9, 2));
        }

        public static bool ValidaPIS(string pis)
        {
            if (string.IsNullOrWhiteSpace(pis))
            {
                return false;
            }
            int[] multiplicao = { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            pis = pis.Trim();
            pis = pis.Replace(".", "").Replace("-", "");
            if (pis.Length < 11)
            {
                return false;
            }
            int soma = 0;
            for (int i = 0; i < multiplicao.Length; i++)
            {
                soma += int.Parse(pis[i].ToString()) * multiplicao[i];
            }
            int temp = soma % pis.Length;
            if (temp < 2)
            {
                temp = 0;
            }
            else if (temp >= 2 && temp < 10)
            {
                temp = pis.Length - temp;
            }
            return string.Equals(pis.Substring(pis.Length - 1 , 1), temp.ToString());
        }
    }
}
