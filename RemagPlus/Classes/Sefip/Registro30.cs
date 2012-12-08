using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RemagLib;

namespace RemagPlus.Classes.Sefip
{
    public static class Registro30
    {
        public static void GravaRegistro30(this TextWriter file, List<remag_funcionario> funcionario,remag_empresa empresa)
        {
            char branco = ' ';
            char zero = '0';
            foreach (remag_funcionario f in funcionario)
            {
                file.Write("30");
                file.Write(empresa.IsCNPJ ? 1 : 2);//Tipo de inscricao da empresa
                file.Write(empresa.cnpj.PadLeft(14, zero));//inscricao da empresa
                file.Write(branco.ToString()); // tipo inscricao tomador
                file.Write(branco.ToString().SpaceRight(14));//inscricao tomador
                file.Write(f.pis.PadLeft(11, zero));
                file.Write(f.data_admissao.ToString("ddMMyyyy"));
                file.Write(f.Categoria.tipo.ToString().PadLeft(2, zero));
                file.Write(f.nome.PadRight(70, branco));
                file.Write(branco.ToString().PadRight(11, branco));
                file.Write(f.ctps.Trim().PadLeft(7, zero));
                file.Write(f.serie.Trim().PadLeft(5, zero));
                file.Write(f.data_opcao.ToString("ddMMyyyy"));
                file.Write(f.data_nascimento.ToString("ddMMyyyy"));
                file.Write(f.CBO.cbo.ToString().Substring(0, 4).PadLeft(5, zero));
                file.Write(f.remuneracao.DecimalToString().PadLeft(15, zero)); // Remuneração sem 13
                file.Write(zero.ToString().PadLeft(15, zero)); // Remuneração sobre 13
                file.Write(branco.ToString().PadLeft(2, branco));
                file.Write(branco.ToString().PadLeft(2, branco));//ocorrencia
                file.Write(zero.ToString().PadLeft(15, zero));
                file.Write(zero.ToString().PadLeft(15, zero));
                file.Write(zero.ToString().PadLeft(15, zero));
                file.Write(zero.ToString().PadLeft(15, zero));
                file.Write(branco.ToString().PadLeft(98, branco));
                file.Write("*");
                file.WriteLine();
            }
        }
    }
}
