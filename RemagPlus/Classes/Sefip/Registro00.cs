using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RemagPlus.Properties;
using RemagLib;

namespace RemagPlus.Classes.Sefip
{
    public static class Registro00
    {
        public static void GravaRegistro00(this TextWriter file, remag_responsavel responsavel, remag_empresa empresa, DateTime competencia, int codRecolhimento, string modalidade, IndicadorFGTS indicador, bool isAtrasoInss, string dataAtrasoInss, DateTime dataAtrasoFgts)
        {
            file.Write("00");
            file.Write(string.Empty, 51); // Brancos
            file.Write("1"); //Tipo de remessa
            file.Write(responsavel.IsCNPJ ? 1 : 2);//Tipo de inscrição do responsável (1 - CNPJ, 2 - CEI, 3 - CPF)
            file.WriteLeft(responsavel.cnpj_cei_cpf,14); // Inscrição do responsável
            file.WriteRight(responsavel.nome,30); // Nome do responsável
            file.WriteRight(responsavel.contato,20);// Pessoa para contato
            file.WriteRight(responsavel.endereco,50); // Endereço
            file.WriteRight(responsavel.bairro,20); // Bairro
            file.WriteRight(responsavel.cep,8); // Cep
            file.WriteRight(responsavel.Municipio.nome,20); // Cidade
            file.WriteRight(responsavel.Municipio.uf,2); // Uf
            file.WriteLeft(responsavel.telefone,12); // Telefone
            file.WriteRight(responsavel.email,60); // Email
            file.Write(competencia.ToString("yyyyMM")); // Competencia
            file.Write(codRecolhimento);//Codigo de recolhimento

            switch (indicador)
            {
                case IndicadorFGTS.GRF_Prazo: file.Write(((int)IndicadorFGTS.GRF_Prazo).ToString());
                    break;
                case IndicadorFGTS.GRF_Atraso: file.Write(((int)IndicadorFGTS.GRF_Atraso).ToString());
                    break;
                case IndicadorFGTS.GRF_Atraso_Acao_Fiscal: file.Write(((int)IndicadorFGTS.GRF_Atraso_Acao_Fiscal).ToString());
                    break;
                case IndicadorFGTS.Individualizacao: file.Write(((int)IndicadorFGTS.Individualizacao).ToString());
                    break;
                case IndicadorFGTS.Individualizacao_Acao_Fiscal: file.Write(((int)IndicadorFGTS.Individualizacao_Acao_Fiscal).ToString());
                    break;
                default:
                    break;
            }

            file.Write(modalidade);//Modalidade do arquivo - Branco, 1 ou 9 - FGTS
            switch (indicador)
            {
                case IndicadorFGTS.GRF_Prazo: file.WriteRight(string.Empty,8);
                    break;
                case IndicadorFGTS.GRF_Atraso: file.Write(dataAtrasoFgts.ToString("ddMMyyyy"));
                    break;
                case IndicadorFGTS.GRF_Atraso_Acao_Fiscal: file.Write(dataAtrasoFgts.ToString("ddMMyyyy"));
                    break;
                case IndicadorFGTS.Individualizacao: file.Write(dataAtrasoFgts.ToString("ddMMyyyy"));
                    break;
                case IndicadorFGTS.Individualizacao_Acao_Fiscal: file.Write(dataAtrasoFgts.ToString("ddMMyyyy"));
                    break;
                default:
                    break;
            }

            file.Write(isAtrasoInss ? "2" : "1");//Indicador de recolhimento previdencia (1 - No prazo, 2 - Em atraso, 3 - Nao gera GPS)
            file.Write(isAtrasoInss ? Convert.ToDateTime(dataAtrasoInss).ToString("ddMMyyyy") : string.Empty,8);//Data de recolhimento - caso seja em atraso
            file.Write(string.Empty, 7);//Selic
            file.Write(empresa.IsCNPJ ? 1 : 2);//Tipo de inscrição do responsável (1 - CNPJ, 2 - CEI, 3 - CPF)
            file.WriteLeft(empresa.cnpj,14); // Inscrição do responsável
            file.Write(string.Empty, 18); // Brancos
            file.Write("*"); //Final da linha
            file.WriteLine();

        }
    }
}
