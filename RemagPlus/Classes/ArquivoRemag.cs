using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using RemagPlus.Classes;
using RemagLib;

namespace RemagPlus
{
    class ArquivoRemag
    {
        public ArquivoRemag(DateTime competencia,DateTime recolhimento, string caminho, IEnumerable<remag_funcionario> funcionario, out string mensagem)
        {
            try
            {
                StreamWriter file = new StreamWriter(caminho,false,Encoding.ASCII);
                int i = 1;
                //INFORMAÇÕES DO RESPONSÁVEL - REGISTRO TIPO 0
                file.Write(0);                            //Tipo de registro
                file.Write(1);                            //Código
                file.Write("REMESSA");                      //Literal
                file.Write("02");                           //Identificador do serviço
                file.WriteRight("F.G.T.S.",15);                      //Identificador do serviço
                file.Write("01");                           //Classe de empresa 01-Unica, 02-Matriz/Filial, 03 Multiplas
                file.WriteRight("UNICA",18);               //Classe de empresa 01-Unica, 02-Matriz/Filial, 03 Multiplas
                file.Write(Globals.Empresa.Responsavel.IsCNPJ ? "1" : "2");                            //tipo de inscrição do responsável (1 - CGC, 2 - CEI, 3 - CPF)
                file.WriteLeft(Globals.Empresa.Responsavel.cnpj_cei_cpf,14); //Inscrição
                file.WriteRight(Globals.Empresa.Responsavel.nome,30); //Nome da empresa responsável
                file.WriteRight(Globals.Empresa.Responsavel.contato,20); //Nome do contato
                string telefone = Globals.Empresa.Responsavel.telefone;
                if (!string.IsNullOrWhiteSpace(telefone) && telefone.Length == 11)
                {
                    telefone = telefone.Substring(1, 10);

                }

                file.WriteLeft(telefone, 10);  //Telefone
                file.WriteLeft(0,7);   //Telex
                file.WriteLeft(telefone, 10);  //Telefone
                file.Write(104);                             //Código de compensação
                file.WriteRight("C ECON FEDERAL",15); //Nome do banco responsável
                file.Write(DateTime.Today.ToString("ddMMyy")); //Data de gravação do arquivo
                file.WriteLeft(0,5);                           //Densidade - Valor
                file.Write("D/D");                             //Densidade - Unidade
                file.Write(competencia.ToString("MMyy"));      //Competencia
                file.WriteLeft(27,3);                             //Código de recolhimento
                file.Write(recolhimento.ToString("ddMMyy"));   //Data de recolhimento
                file.WriteLeft(0,8);                        //Banco agencia
                file.Write("4");                               //Versão do layout
                file.WriteRight(string.Empty,5);
                file.WriteRight(string.Empty, 21);                                //brancos
                file.WriteLeft(0,26);      //zeros
                file.WriteLeft(i, 6);                          //Sequencial
                file.WriteLine();

                //REGISTRO TIPO 1  -  CABECALHO COM INFORMACOES DA EMPRESA   (HEADER DA EMPRESA)

                file.Write(1);
                file.WriteLeft(Globals.Empresa.codigo_cef,14);          //Número identificado da empresa
                file.WriteRight(Globals.Empresa.razao_social,40); //Nome da empresa
                file.WriteRight(Globals.Empresa.endereco,50); //Logradouro
                file.WriteRight(Globals.Empresa.bairro,20); //Bairro
                file.WriteLeft(Globals.Empresa.cep,8); //CEP
                file.WriteRight(Globals.Empresa.Municipio.nome,20); //Cidade
                file.Write(Globals.Empresa.Municipio.uf);
                file.WriteLeft(Globals.Empresa.cnae,5);
                file.Write(Globals.Empresa.sat.DecimalToString().StrZeroLeft(7));
                file.Write(Globals.Empresa.CategoriaEmpresa.tipo);
                file.Write(0); // Centralização
                file.WriteRight(string.Empty, 49);
                file.Write(Globals.Empresa.IsCNPJ ? 1 : 2);
                file.WriteLeft(Globals.Empresa.cnpj,14);          //Número identificado da empresa
                file.WriteLeft(0,11);
                i++;
                file.WriteLeft(i,6); //Sequencia
                file.WriteLine();

                //REGISTRO TIPO 2  -  REGISTRO DE EMPREGADO / DEPOSITO
                
                decimal totalJam = decimal.Zero;
                decimal totalDeposito = decimal.Zero;
                decimal totalDeposito13 = decimal.Zero;
                foreach (remag_funcionario f in funcionario)
                {
                    string exercicio = competencia.ToString("MM/yyyy");
                    remag_individualizacao individual = f.remag_individualizacao.FirstOrDefault(id => id.competencia == exercicio && id.data_recolhimento == recolhimento);

                    file.Write(2);
                    file.WriteLeft(Globals.Empresa.codigo_cef,14);          //Número identificado da empresa
                    file.WriteRight(string.Empty,25);       // Para uso da empresa
                    file.WriteLeft(0,11);          //Código do empregado
                    file.WriteLeft(f.funcionario_id,11);         //Mátricula do empregado na empresa
                    //string ctps = f.ctps.StrZeroLeft(7);
                    //throw new ArgumentException(ctps);
                    file.WriteLeft(f.ctps,7);          //Carteira de trabalho
                    file.WriteLeft(f.serie,5);          //Série da carteira de trabalho
                    file.Write(f.data_admissao.ToString("ddMMyy"));          //Data de admissão
                    file.Write(string.Concat(f.AdmissaoNumerica.codigo,f.AdmissaoAlfa.codigo));          //Código que caracteriza - ver tabela
                    file.WriteRight(f.nome,40);          //Nome do empregado
                    file.Write(f.data_opcao.ToString("ddMMyy"));          //Data de opção
                    file.Write(f.optante.Value ? "2" : "4");          //Tipo (2 - optante, 4 - Não optante)
                    file.Write(f.data_nascimento.ToString("ddMMyy"));          //Data de nascimento
                    if (f.movimentacao_id.HasValue && !f.data_demissao.HasValue)
                    {
                        throw new Exception(string.Format("Funcionário {0} possue movimentação de saída, mas não possue data de saída.",f.nome));
                    }
                    file.WriteLeft(f.movimentacao_id.HasValue ? f.data_demissao.Value.ToString("ddMMyy") : "0",6);          //Data de movimentação (caso nao tenha preencher com 0)
                    file.Write(f.movimentacao_id.HasValue ? f.Movimentacao.codigo_movimentacao : " ");          //Código de movimentação
                    file.WriteCurrency(individual.valor_deposito,11);          //Depósito sem 13° salário
                    file.WriteCurrency(individual.valor_deposito13,11);          //Depósito sobre a parcela do 13° salário
                    file.WriteCurrency(individual.valor_jam,13);          //Valor do JAM
                    file.WriteRight(string.Empty, 15);          //Local de trabalho
                    file.WriteRight(string.Empty,26);          //Brancos
                    file.Write(Globals.Empresa.IsCNPJ ? "1" : "2");                            //Tipo de identificação da empresa (1 - CGC, 2 - CEI)
                    file.WriteLeft(Globals.Empresa.cnpj,14); //Inscricao
                    file.WriteLeft(f.pis,11);          //PIS/PASEP
                    i++;
                    file.WriteLeft(i,6);
                    file.WriteLine();
                    //Sequencia
                    totalDeposito += individual.valor_deposito;
                    totalDeposito13 += individual.valor_deposito13;
                    totalJam += individual.valor_jam;
                }
                //REGISTRO TIPO 8   -   TOTALIZADOR DE EMPRESA   (TRAILER DE EMPRESA)
                file.Write(8);
                file.WriteLeft(Globals.Empresa.codigo_cef,14);          //Número identificado da empresa
                file.WriteLeft((i - 2),7);          //Quantidade de contas ou registro do tipo 2
                file.WriteCurrency(totalDeposito,16);          //Total Depósito sem 13° salário
                file.WriteCurrency(totalDeposito13,16);          //Total Depósito sobre a parcela do 13° salário
                file.WriteCurrency(totalJam,16);          //Total Valor do JAM
                file.WriteLeft(0, 7);          //Quantidade de alterações cadastrais
                file.WriteLeft(0, 7);          //Quantidade de registros do tipo 4
                file.WriteRight(string.Empty,134);          //Brancos
                file.Write(Globals.Empresa.IsCNPJ ? "1" : "2");                            //Tipo de identificação da empresa (1 - CGC, 2 - CEI)
                file.Write(Globals.Empresa.cnpj.StrZeroLeft(14));          //Número identificado da empresa
                file.Write("9".PadRight(11,'9'));          //9999...
                i++;
                file.WriteLeft(i,6); //Sequencia

                //REGISTRO TIPO 9  -  TOTALIZADOR DE ARQUIVO   (TRAILER DE ARQUIVO)

                file.WriteLine();
                file.Write(9);
                file.WriteLeft(1, 7);          //Total de registros do tipo 0
                file.WriteLeft(1, 7);          //Total de registros do tipo 1
                file.WriteLeft((i - 3),7);          //Total de registros do tipo 2
                file.WriteLeft(0, 7);          //Total de registros do tipo 3
                file.WriteLeft(0, 7);          //Total de registros do tipo 4
                file.WriteLeft(1,7);          //Total de registros do tipo 8
                file.WriteLeft(1, 7);          //Total de registros do tipo 9
                file.WriteCurrency(totalDeposito,16);          //Depósito sem 13° salário
                file.WriteCurrency(totalDeposito13,16);          //Depósito sobre a parcela do 13° salário
                file.WriteCurrency(totalJam,16);          //Valor do JAM
                file.WriteRight(string.Empty,120);          //Branco
                file.Write("9".PadRight(26, '9'));
                i++;
                file.WriteLeft(i,6);                       //Sequencia
                file.WriteLine("SUB");//Fim do arquivo
                file.Close();
                
            }
            catch (IOException erro)
            {
                throw new IOException("Não foi possível gerar o arquivo. " + erro);
            }
            finally
            {
                mensagem = "Arquivo gerado com sucesso!";
            }

        }
    }
}
