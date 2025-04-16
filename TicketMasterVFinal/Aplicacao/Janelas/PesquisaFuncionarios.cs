using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMasterVFinal.Aplicacao.Controladores.Servicos;
using TicketMasterVFinal.Aplicacao.Enumeradores;

namespace TicketMasterVFinal.Aplicacao.Janelas
{
    public partial class PesquisaFuncionarios : System.Windows.Forms.Form
    {
        private ServFuncionario servFuncionario;
        public string CPFSelecionado { get; set; }
        public string NomeSelecionado { get; set; }
        public TipoSituacaoFuncionario SituacaoSelecionada { get; set; }

        public PesquisaFuncionarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            servFuncionario = new ServFuncionario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable tabelaDados = new DataTable();
            tabelaDados.Columns.Add("ID", typeof(int));
            tabelaDados.Columns.Add("Nome", typeof(string));
            tabelaDados.Columns.Add("CPF", typeof(string));
            tabelaDados.Columns.Add("Situação", typeof(int));
        }

        private void dataGridFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridFuncionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CPFSelecionado = dataGridFuncionarios.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                NomeSelecionado = dataGridFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                SituacaoSelecionada = (TipoSituacaoFuncionario)Enum.Parse(
                    typeof(TipoSituacaoFuncionario),
                    dataGridFuncionarios.Rows[e.RowIndex].Cells["Situacao"].Value.ToString()
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void PesquisaFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarTodosFuncionarios();
        }

        private void CarregarTodosFuncionarios()
        {
            var lista = servFuncionario.ConsultarFuncionarios()
                .Select(f => new
                {
                    f.Id,
                    f.Nome,
                    f.CPF,
                    Situacao = f.Situacao.ToString()
                })
                .ToList();

            dataGridFuncionarios.DataSource = lista;

            dataGridFuncionarios.Columns["Id"].HeaderText = "ID";
            dataGridFuncionarios.Columns["Nome"].HeaderText = "Nome";
            dataGridFuncionarios.Columns["CPF"].HeaderText = "CPF";
            dataGridFuncionarios.Columns["Situacao"].HeaderText = "Situação";
        }

        private void CarregarFuncionarioPorCpf(string cpf)
        {
            var lista = servFuncionario.ConsultarFuncionarios()
                .Where(f => f.CPF.Contains(cpf))
                .Select(f => new
                {
                    f.Id,
                    f.Nome,
                    f.CPF,
                    Situacao = f.Situacao.ToString()
                })
                .ToList();

            dataGridFuncionarios.DataSource = lista;

            dataGridFuncionarios.Columns["Id"].HeaderText = "ID";
            dataGridFuncionarios.Columns["Nome"].HeaderText = "Nome";
            dataGridFuncionarios.Columns["CPF"].HeaderText = "CPF";
            dataGridFuncionarios.Columns["Situacao"].HeaderText = "Situação";
        }

        private void btnBuscarPesquisaFuncionario_Click_1(object sender, EventArgs e)
        {
            string cpf = tPesquisaFuncionariosTela.Text.Trim();

            if (string.IsNullOrEmpty(cpf))
                CarregarTodosFuncionarios();
            else
                CarregarFuncionarioPorCpf(cpf);
        }
    }
}
