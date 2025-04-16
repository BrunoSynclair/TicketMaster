using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace TicketMasterVFinal.Aplicacao.Janelas
{
    public partial class PesquisaTickets : Form
    {
        public string NomeFuncionarioSelecionado { get; private set; }
        public string CPFSelecionado { get; private set; }
        public int QuantidadeSelecionada { get; private set; }
        public string SituacaoSelecionada { get; private set; }


        public PesquisaTickets()
        {
            InitializeComponent();
            dataGridFuncionarios.AutoGenerateColumns = true;
            this.Load += PesquisaTickets_Load;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void PesquisaTickets_Load(object sender, EventArgs e)
        {
            CarregarTickets();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CarregarTickets()
        {
            using (var contexto = new AppDbContext())
            {
                var lista = contexto.Tickets
                    .Include(t => t.Funcionario)
                    .Select(t => new
                    {
                        Id = t.id,
                        NomeFuncionario = t.Funcionario.Nome,
                        CPF = t.Funcionario.CPF,
                        Quantidade = t.quantidade,
                        Situacao = t.situacao.ToString(),
                        UltimaAlteracao = t.ultima_atualizacao_cadastro.HasValue
                            ? t.ultima_atualizacao_cadastro.Value.ToLocalTime().ToString("dd/MM/yyyy HH:mm")
                            : ""
                    })
                    .ToList();

                dataGridFuncionarios.DataSource = lista;

                dataGridFuncionarios.Columns["Id"].HeaderText = "ID";
                dataGridFuncionarios.Columns["NomeFuncionario"].HeaderText = "Nome do Funcionário";
                dataGridFuncionarios.Columns["CPF"].HeaderText = "CPF";
                dataGridFuncionarios.Columns["Quantidade"].HeaderText = "Quantidade";
                dataGridFuncionarios.Columns["Situacao"].HeaderText = "Situação";
                dataGridFuncionarios.Columns["UltimaAlteracao"].HeaderText = "Última Alteração";
            }
        }

        private void dataGridFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridFuncionarios.Rows[e.RowIndex];

                this.Tag = Convert.ToInt32(row.Cells["Id"].Value);
                this.NomeFuncionarioSelecionado = row.Cells["NomeFuncionario"].Value.ToString();
                this.CPFSelecionado = row.Cells["CPF"].Value.ToString();
                this.QuantidadeSelecionada = Convert.ToInt32(row.Cells["Quantidade"].Value);
                this.SituacaoSelecionada = row.Cells["Situacao"].Value.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dataGridFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            string cpf = tPesquisaFuncionariosTela.Text.Trim();

            using (var contexto = new AppDbContext())
            {
                var query = contexto.Tickets.Include(t => t.Funcionario).AsQueryable();

                if (!string.IsNullOrEmpty(cpf))
                    query = query.Where(t => t.Funcionario.CPF.Contains(cpf));

                var lista = query
                    .Select(t => new
                    {
                        Id = t.id,
                        NomeFuncionario = t.Funcionario.Nome,
                        CPF = t.Funcionario.CPF,
                        Quantidade = t.quantidade,
                        Situacao = t.situacao.ToString(),
                        UltimaAlteracao = t.ultima_atualizacao_cadastro.HasValue
                            ? t.ultima_atualizacao_cadastro.Value.ToLocalTime().ToString("dd/MM/yyyy HH:mm")
                            : ""
                    })
                    .ToList();

                dataGridFuncionarios.DataSource = lista;

                dataGridFuncionarios.Columns["Id"].HeaderText = "ID";
                dataGridFuncionarios.Columns["NomeFuncionario"].HeaderText = "Nome do Funcionário";
                dataGridFuncionarios.Columns["CPF"].HeaderText = "CPF";
                dataGridFuncionarios.Columns["Quantidade"].HeaderText = "Quantidade";
                dataGridFuncionarios.Columns["Situacao"].HeaderText = "Situação";
                dataGridFuncionarios.Columns["UltimaAlteracao"].HeaderText = "Última Alteração";
            }
        }
    }
}
