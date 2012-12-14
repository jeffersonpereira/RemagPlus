using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RemagPlus.Extensao;
using System.Data.Objects;

namespace RemagLib
{
    public partial class DataEntities
    {
        public void CriarDadosPadroes()
        {
            remag_usuario usuario = new remag_usuario();
            this.AddToremag_usuario(usuario);
            usuario.login = "demo";
            usuario.nome = "Demonstração";
            usuario.Senha = "1";

            remag_responsavel responsavel = new remag_responsavel();
            responsavel.nome = "demo";
            responsavel.cnpj_cei_cpf = "53429812000113";
            responsavel.remag_municipio = this.remag_municipio.First();
            responsavel.tipo_inscricao = "CNPJ";
            responsavel.bairro = "demo";
            responsavel.endereco = "demo";
            responsavel.email = "demo@demo.com";
            responsavel.cep = "40000000";
            responsavel.contato = "demo";
            responsavel.telefone = "7133333333";
            this.AddToremag_responsavel(responsavel);

            remag_empresa empresa = new remag_empresa();
            empresa.remag_categoria_empregador = this.remag_categoria_empregador.First();
            empresa.remag_responsavel = responsavel;
            empresa.remag_municipio = this.remag_municipio.First();
            empresa.razao_social = "EMPRESA DEMOSNTRAÇÃO";
            empresa.tipo_inscricao = "CNPJ";
            empresa.cnpj = "53429812000113";
            this.SaveChanges();
        }

        public int DeletarIndividualizacao(remag_empresa empresa, DateTime competencia, DateTime recolhimento)
        {
            string compe = competencia.ToString("MM/yyyy");
            var individualicoes = (from i in remag_individualizacao
                                   where i.remag_funcionario.empresa_id == empresa.empresa_id &&
                                   i.competencia == compe && i.data_recolhimento == recolhimento
                                   select i).ToList();

            foreach (remag_individualizacao f in individualicoes)
            {
                remag_individualizacao individualizacao = f;
                if (individualizacao != null)
                {
                    DeleteObject(individualizacao);
                }
            }
            int registros = SaveChanges();
            return registros;

        }

        /// <summary>
        /// Retirna lista de funcionários.
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="exercicio"></param>
        /// <param name="totalRemunercao"></param>
        /// <returns></returns>
        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa, DateTime exercicio, out decimal totalRemunercao)
        {
            List<remag_funcionario> funcionario = this.remag_funcionario.Where<remag_funcionario>(f => f.data_admissao <= exercicio && f.empresa_id == empresa.empresa_id).ToList();
            List<remag_funcionario> newList = new List<remag_funcionario>();
            decimal total = decimal.Zero;
            foreach (remag_funcionario f in funcionario)
            {
                if (f.data_demissao.HasValue && f.data_demissao.Value.ToFirstDay() <= exercicio)
                {
                    continue;
                }
                newList.Add(f);
                total += f.remuneracao;
            }
            totalRemunercao = total;
            return newList.OrderBy<remag_funcionario, DateTime>(f => f.data_admissao).ToList();
        }

        /// <summary>
        /// Retorna lista de funcionário com salário dentro da faixa indicada.
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="valorI"></param>
        /// <param name="valorF"></param>
        /// <returns></returns>
        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa, decimal valorI, decimal valorF)
        {
            return this.remag_funcionario.Where(f => f.remuneracao >= valorI && f.remuneracao <= valorF && f.empresa_id == empresa.empresa_id).ToList();
        }

        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa, bool isAtivo, bool isInativo, bool isOrdemNome, bool isOrdemPis)
        {
            List<remag_funcionario> funcionario = new List<remag_funcionario>();
            foreach (remag_funcionario fu in this.remag_funcionario.Where<remag_funcionario>(f => f.empresa_id == empresa.empresa_id).ToList())
            {
                if (isAtivo && !fu.movimentacao_id.HasValue)
                {
                    funcionario.Add(fu);
                }
                else if (isInativo && !fu.movimentacao_id.HasValue)
                {
                    funcionario.Add(fu);
                }
                else
                {
                    funcionario.Add(fu);
                }
            }
            if (isOrdemNome)
            {
                return funcionario.OrderBy<remag_funcionario, string>(f => f.nome).ToList();
            }
            else
            {
                return funcionario.OrderBy<remag_funcionario, string>(f => f.pis).ToList();
            }

            return funcionario;
        }

        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa, string pis)
        {
            List<remag_funcionario> funcionario = this.remag_funcionario.Where<remag_funcionario>(f => f.empresa_id == empresa.empresa_id && f.pis.Equals(pis)).ToList();
            return funcionario;
        }

        /// <summary>
        /// Retorna uma lista de funcionário por data de recolhimento
        /// </summary>
        /// <param name="recolhimento"></param>
        /// <returns></returns>
        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa, DateTime recolhimento)
        {
            List<remag_individualizacao> individualizacao = this.remag_individualizacao.Where<remag_individualizacao>(i => i.remag_funcionario.empresa_id == empresa.empresa_id && i.data_individualizacao == recolhimento).ToList();
            List<remag_funcionario> funcionario = new List<remag_funcionario>();
            foreach (remag_individualizacao ind in individualizacao)
            {
                funcionario.Add(ind.remag_funcionario);
            }
            return funcionario;
        }
        /// <summary>
        /// Lista de funcionário com individualização
        /// </summary>
        /// <returns></returns>
        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa)
        {
            List<remag_individualizacao> individualizacao = this.remag_individualizacao.Where<remag_individualizacao>(i => i.remag_funcionario.empresa_id == empresa.empresa_id).ToList();
            List<remag_funcionario> funcionario = new List<remag_funcionario>();
            foreach (remag_individualizacao ind in individualizacao)
            {
                funcionario.Add(ind.remag_funcionario);
            }
            return funcionario;
        }

        /// <summary>
        /// Retorna uma lista de funcionário por faixa de data de admissão
        /// </summary>
        /// <param name="dataI"></param>
        /// <param name="dataF"></param>
        /// <returns></returns>
        public IList<remag_funcionario> GetFuncionarioDados(remag_empresa empresa, DateTime dataI, DateTime dataF)
        {
            List<remag_funcionario> funcionario = this.remag_funcionario.Where<remag_funcionario>(f => f.data_admissao >= dataI && f.data_admissao <= dataF && f.empresa_id == empresa.empresa_id).ToList();
            return funcionario;
        }

        /// <summary>
        /// Retorna todos os salários
        /// </summary>
        /// <returns></returns>
        public List<remag_salario_minimo> GetSalarioMinimo()
        {
            return this.remag_salario_minimo.ToList();
        }

        /// <summary>
        /// Retorna salários por faixa de vigência.
        /// </summary>
        /// <param name="dataI"></param>
        /// <param name="dataF"></param>
        /// <returns></returns>
        public List<remag_salario_minimo> GetSalarioMinimo(DateTime dataI, DateTime dataF)
        {
            return this.remag_salario_minimo.Where(sa => sa.vigencia >= dataI && sa.vigencia <= dataF).ToList();
        }
        /// <summary>
        /// Individualiza os valores proporcionalmente
        /// </summary>
        /// <param name="funcionario"></param>
        /// <param name="totalRemuneracao">Total de todas as remunerações</param>
        /// <param name="depositoTotal">Valor total do depósito</param>
        /// <param name="deposito13Total">Valor total do depósito 13°</param>
        /// <param name="jamTotal">Valor total do jam</param>
        /// <param name="jam"></param>
        /// <param name="deposito"></param>
        /// <param name="deposito13"></param>
        public void Individualiza(remag_funcionario funcionario, decimal totalRemuneracao, decimal depositoTotal, decimal deposito13Total, decimal jamTotal, out decimal jam, out decimal deposito, out decimal deposito13)
        {
            jam = Math.Round((jamTotal / totalRemuneracao * funcionario.remuneracao), 2);
            deposito = Math.Round((depositoTotal / totalRemuneracao * funcionario.remuneracao), 2);
            deposito13 = Math.Round((deposito13Total / totalRemuneracao * funcionario.remuneracao), 2);
        }
        /// <summary>
        /// Aplica 8% sobre o salário mínimo
        /// </summary>
        /// <param name="vigencia"></param>
        /// <param name="depositoTotal"></param>
        /// <param name="deposito13Total"></param>
        /// <param name="jamTotal"></param>
        /// <param name="jam"></param>
        /// <param name="deposito"></param>
        /// <param name="deposito13"></param>
        public void Individualiza(DateTime vigencia, decimal depositoTotal, decimal deposito13Total, decimal jamTotal, out decimal jam, out decimal deposito, out decimal deposito13)
        {
            jam = deposito13 = Math.Round((GetSalarioMinimo(vigencia) * 0.08M), 2);
            deposito = deposito13 = Math.Round((GetSalarioMinimo(vigencia) * 0.08M), 2);
            deposito13 = deposito13 = Math.Round((GetSalarioMinimo(vigencia) * 0.08M), 2);
        }

        /// <summary>
        /// Individualiza valores por rateio
        /// </summary>
        /// <param name="depositoTotal"></param>
        /// <param name="deposito13Total"></param>
        /// <param name="jamTotal"></param>
        /// <param name="qtdFuncionario"></param>
        /// <param name="jam"></param>
        /// <param name="deposito"></param>
        /// <param name="deposito13"></param>
        public void Individualiza(decimal depositoTotal, decimal deposito13Total, decimal jamTotal, int qtdFuncionario, out decimal jam, out decimal deposito, out decimal deposito13)
        {
            jam = Math.Round((depositoTotal / qtdFuncionario), 2);
            deposito = Math.Round((depositoTotal / qtdFuncionario), 2);
            deposito13 = Math.Round((deposito13Total / qtdFuncionario), 2);
        }


        /// <summary>
        /// Retorna o valor de um salário mínimo na vigência indicada.
        /// </summary>
        /// <param name="vigencia"></param>
        /// <returns></returns>
        public decimal GetSalarioMinimo(DateTime vigencia)
        {
            vigencia = vigencia.ToFirstDay();
            remag_salario_minimo salario = (from s in this.remag_salario_minimo
                                            where s.vigencia <= vigencia
                                            orderby s.vigencia descending
                                            select s).FirstOrDefault();
            decimal valor = decimal.Zero;
            if (salario != null)
            {
                valor = salario.valor;
            }
            return valor;
        }

        /// <summary>
        /// Remove as individualizações do período indicado.
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="recolhimento"></param>
        public int DeleteIndividualizacao(remag_empresa empresa, DateTime competencia, DateTime recolhimento)
        {
            string compe = competencia.ToString("MM/yyyy");
            var individualicoes = (from i in this.remag_individualizacao
                                   where i.remag_funcionario.empresa_id == empresa.empresa_id &&
                                   i.competencia == compe && i.data_recolhimento == recolhimento
                                   select i).ToList();

            foreach (remag_individualizacao f in individualicoes)
            {
                remag_individualizacao individualizacao = f;
                if (individualizacao != null)
                {
                    this.DeleteObject(individualizacao);
                }
            }
            int registros = this.SaveChanges();
            return registros;
        }

        /// <summary>
        /// Retorna a individualização de um funcionário
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="funcionario"></param>
        /// <param name="recolhimento"></param>
        /// <returns></returns>

        public remag_individualizacao GetIndividualizacao(DateTime competencia, remag_funcionario funcionario, DateTime recolhimento)
        {
            string comp = competencia.ToString("MM/yyyy");
            return this.remag_individualizacao.FirstOrDefault(i => i.funcionario_id == funcionario.funcionario_id && i.competencia == comp && i.data_recolhimento == recolhimento);
        }
        /// <summary>
        /// Retorna uma lista de Individualização pelo Pis
        /// </summary>
        /// <param name="pis"></param>
        /// <returns></returns>
        public List<remag_individualizacao> GetIndividualizacao(string pis)
        {
            return this.remag_individualizacao.Where<remag_individualizacao>(i => i.remag_funcionario.pis == pis).ToList();
        }
        /// <summary>
        /// Retorna uma lista de individualizações pela data de recolhimento
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<remag_individualizacao> GetIndividualizacao(remag_empresa empresa, DateTime data)
        {
            return this.remag_individualizacao.Where<remag_individualizacao>(i => i.data_individualizacao == data && i.remag_funcionario.empresa_id == empresa.empresa_id).ToList();
        }
        /// <summary>
        /// Retorna uma lista de Individualização pela competência
        /// </summary>
        /// <param name="competencia"></param>
        /// <param name="isCompetencia"></param>
        /// <returns></returns>
        public List<remag_individualizacao> GetIndividualizacao(remag_empresa empresa, string competencia, bool isCompetencia)
        {
            return this.remag_individualizacao.Where<remag_individualizacao>(i => i.competencia == competencia && i.remag_funcionario.empresa_id == empresa.empresa_id).ToList();
        }
        /// <summary>
        /// Retorna todas as individualizações da empresa
        /// </summary>
        /// <returns></returns>
        public List<remag_individualizacao> GetIndividualizacao(remag_empresa empresa)
        {
            return this.remag_individualizacao.Where<remag_individualizacao>(i => i.remag_funcionario.empresa_id == empresa.empresa_id).ToList();
        }

        public List<remag_individualizacao> GetIndividualizacao(remag_empresa empresa,string pis)
        {
            return remag_individualizacao.Where<remag_individualizacao>(i => i.remag_funcionario.pis == pis && i.remag_funcionario.empresa_id == empresa.empresa_id).ToList();
        }

        /// <summary>
        /// Retorna a configuração.
        /// </summary>
        /// <returns></returns>
        public remag_configuracao GetConfiguracao()
        {
            return this.remag_configuracao.FirstOrDefault();
        }

        public List<T> GetPesquisa<T>(string tabela, string campo, string valor)
        {
            string sql = string.Format("select value c from {0} as c where c.{1} like '%{2}%'", tabela, campo, valor);
            ObjectQuery<T> lista = CreateQuery<T>(sql);
            return lista.ToList();
        }

        public List<T> GetPesquisa<T>(string tabela, string campo, string valor, remag_empresa empresa)
        {
            string sql = string.Format("select value c from {0} as c where c.empresa_id={1} and c.{2} like '%{3}%'", tabela, empresa.empresa_id, campo, valor);
            ObjectQuery<T> lista = CreateQuery<T>(sql);
            
            return lista.ToList();
        }
    }
}
