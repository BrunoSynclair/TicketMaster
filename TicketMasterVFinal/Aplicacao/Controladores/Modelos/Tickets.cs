using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketMasterVFinal.Aplicacao.Enumeradores;

namespace TicketMasterVFinal.Aplicacao.Modelos
{
    [Table("tickets")]
    public class Tickets
    {
        [Key]
        [Column("id")]
        public int? id { get; set; }

        [Column("quantidade")]
        public int quantidade { get; set; }

        [Column("funcionario_id")]
        public int funcionarioID { get; set; }

        [ForeignKey("funcionarioID")]
        public virtual Funcionario Funcionario { get; set; }

        [Column("situacao")]
        public TipoSituacaoTicket situacao { get; set; } = TipoSituacaoTicket.Ativo;

        [Column("data_modificacao")]
        public DateTime? ultima_atualizacao_cadastro { get; set; }

        public Tickets() { }

        public Tickets(int quantidade, int funcionarioID, TipoSituacaoTicket situacao)
        {
            this.quantidade = quantidade;
            this.funcionarioID = funcionarioID;
            this.situacao = situacao;
            ultima_atualizacao_cadastro = DateTime.Now.ToUniversalTime();
        }

        public override string ToString()
        {
            return $"ID: {id}, Funcionário ID: {funcionarioID}, Quantidade: {quantidade}, Situação: {situacao}, Data de Modificação: {ultima_atualizacao_cadastro}";
        }
    }
}
