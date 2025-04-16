using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TicketMasterVFinal.Aplicacao.Enumeradores;

namespace TicketMasterVFinal.Aplicacao.Modelos
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Key]
        [Column("id")]
        public int? Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("cpf")]
        public string CPF { get; set; }
        [Column("situacao")]
        public TipoSituacaoFuncionario? Situacao { get; set; } = TipoSituacaoFuncionario.Ativo;

        [Column("ultima_atualizacao_cadastro")]
        public DateTime? ultima_atualizacao_cadastro { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cpf, TipoSituacaoFuncionario situacao)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Situacao = situacao;
            this.ultima_atualizacao_cadastro = DateTime.Now.ToUniversalTime();
        }

        public Funcionario(int id, string nome, string cpf, TipoSituacaoFuncionario situacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.Situacao = situacao;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, CPF: {CPF}, Situação: {Situacao}";
        }
    }
}
