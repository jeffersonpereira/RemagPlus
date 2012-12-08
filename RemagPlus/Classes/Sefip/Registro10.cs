using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using RemagLib;

namespace RemagPlus.Classes.Sefip
{
    public static class Registro10
    {
        public static void GravaRegistro10(this TextWriter file, remag_empresa empresa, int codPagamento)
        {
            char branco = ' ';
            char zero = '0';

            file.Write("10");
            file.Write(empresa.IsCNPJ ? "1" : "2");//Tipo de inscrição (1 - CNPJ, 2 - CEI)
            file.Write(empresa.cnpj.PadLeft(14, zero)); // Inscrição do responsável
            file.Write(zero.ToString().PadRight(36, zero)); // Zeros
            file.Write(empresa.razao_social.PadRight(40, branco));// Nome da empresa
            file.Write(empresa.endereco.PadRight(50, branco)); // Endereço
            file.Write(empresa.bairro.PadRight(20, branco)); // Bairro
            file.Write(empresa.cep.PadRight(8, branco)); // Cep
            file.Write(empresa.Municipio.nome.PadRight(20, branco)); // Cidade
            file.Write(empresa.Municipio.uf.PadRight(2, branco)); // Uf
            file.Write(empresa.telefone.PadRight(12, branco)); // Telefone
            file.Write("N"); // Indicador de alteração de endereço
            file.Write(empresa.cnae.ToString().PadRight(7, zero)); // CNAE
            file.Write("N"); // Indicador de alteração de CNAE
            file.Write("00"); // RAT
            file.Write("0");//Codigo de centralização
            file.Write("1");//Indicador de simples
            file.Write(empresa.fpas);//FPAS
            file.Write("0000");//Codigo de outras entidades
            file.Write(codPagamento);//Codigo de pagamento GPS
            file.Write(zero.ToString().PadRight(5, zero));//Data de recolhimento - caso seja em atraso
            file.Write(zero.ToString().PadRight(15, zero));//Salario familia
            file.Write(zero.ToString().PadRight(15, zero));//Salario maternidade
            file.Write(zero.ToString().PadRight(15, zero));//Contribuicao descontada do empregado
            file.Write("0"); // Indicador de valor positivo ou negativo
            file.Write(zero.ToString().PadRight(14, zero));//Valor devido a previdência
            file.Write(branco.ToString().PadRight(16, branco)); // Banco, agencia e conta corrente
            file.Write(zero.ToString().PadRight(45, zero));//Zeros
            file.Write(branco.ToString().PadRight(4, branco)); // Brancos
            file.Write("*"); //Final da linha
            file.WriteLine();
        }
    }
}
