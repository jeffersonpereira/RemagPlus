using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using RemagPlus.Classes;
using RemagPlus.Classes.Sefip;
using RemagLib;

namespace RemagPlus
{
    public enum IndicadorFGTS
    { 
      GRF_Prazo=1,
      GRF_Atraso=2,
      GRF_Atraso_Acao_Fiscal=3,
      Individualizacao = 5,
      Individualizacao_Acao_Fiscal = 6,
      
    }
    public class ArquivoSefip
    {
        public ArquivoSefip(DateTime competencia, List<remag_funcionario> funcionario, int codigo_recolhimento,bool isAtrasoInss,string dataAtrasoInss,IndicadorFGTS indicadoFgts,DateTime dataAtrasoFgts,string caminho,string modalidade, int codPagamento, out string mensagem)
        {
            try
            {
                StreamWriter file = new StreamWriter(caminho);
                //Regitro 00
                char branco = ' ';
                char zero = '0';
                file.GravaRegistro00(Globals.Empresa.Responsavel, Globals.Empresa, competencia, codigo_recolhimento, modalidade, indicadoFgts, isAtrasoInss, dataAtrasoInss, dataAtrasoFgts);
                //Registro 10
                file.GravaRegistro10(Globals.Empresa, codPagamento);
                //REGISTRO 30
                file.GravaRegistro30(funcionario, Globals.Empresa);
                file.GravaRegistro90();
            }
            catch (Exception)
            {
                mensagem="Ocorreu um erro na geração do arquivo";
            }
            finally
            {
                mensagem="O arquivo foi gerado com sucesso!";
            }
        }
    }
}
