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
using TicketMasterVFinal.Aplicacao.Modelos;
using TicketMasterVFinal.Aplicacao.Servicos;

namespace TicketMasterVFinal.Aplicacao.Janelas
{
    public partial class TelaPrincipal : Form
    {
        ServFuncionario servicoFunc;
        ServTicket servicoTicket;
        private int ticketIdSelecionado;

        public TelaPrincipal()
        {
            servicoFunc = new ServFuncionario();
            servicoTicket = new ServTicket();
            InitializeComponent();
            ParametrosIniciais();
        }

        private void ParametrosIniciais()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            pEntrada.Visible = true;
            pCadFuncionario.Visible = false;
            pCadTicket.Visible = false;
            pEditFuncionario.Visible = false;
            pEditTicket.Visible = false;
        }

        private void SelecionarRotina(Panel ativo)
        {
            Panel painelAtual = ObterPainelAtual();

            if (painelAtual != null && painelAtual != ativo)
                painelAtual.Visible = false;

            if (ativo != null)
                ativo.Visible = true;
        }

        private Panel ObterPainelAtual()
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is Panel painel && painel.Visible)
                    return painel;
            }
            return null;
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            string Nome = tCadNome.Text.Trim();
            fCadCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string CPF = fCadCPF.Text.Trim();

            if (!string.IsNullOrWhiteSpace(Nome) && fCadCPF.MaskFull)
            {
                servicoFunc.NovoFuncionario(new Funcionario(tCadNome.Text, fCadCPF.Text, Enumeradores.TipoSituacaoFuncionario.Ativo));
            }
            else
            {
                MessageBox.Show("É necessário informar o campo de Nome e CPF!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tCadNome.Text = "";
            fCadCPF.Text = "";
            tCadNome.Focus();
        }

        private void menuCadFuncionario_Click(object sender, EventArgs e)
        {
            SelecionarRotina(pCadFuncionario);
        }

        private void menuCadTicket_Click(object sender, EventArgs e)
        {
            SelecionarRotina(pCadTicket);
        }

        private void menuEditFuncionario_Click(object sender, EventArgs e)
        {
            SelecionarRotina(pEditFuncionario);
        }

        private void menuEditTicket_Click(object sender, EventArgs e)
        {
            SelecionarRotina(pEditTicket);
        }

        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            using (var pesquisa = new PesquisaFuncionarios())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    tCadFuncTicket.Text = pesquisa.CPFSelecionado;
                }
            }
        }

        private void btnCadTicket_Click(object sender, EventArgs e)
        {
            string cpf = tCadFuncTicket.Text.Trim();
            string qtdeTexto = tCadQtdeTickets.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(qtdeTexto))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(qtdeTexto, out int qtde))
            {
                MessageBox.Show("Quantidade de tickets inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            servicoTicket.EntregarTickets(cpf, qtde);

            tCadFuncTicket.Text = "";
            tCadQtdeTickets.Text = "";
            tCadFuncTicket.Focus();
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            var cpf = tEditCPF.Text.Trim();
            var nome = tEditFuncionario.Text.Trim();
            var situacao = cEditFuncionario.Text.Trim();

            if (Enum.TryParse<TipoSituacaoFuncionario>(situacao, out var situacaoEnumerador))
            {
                try
                {
                    servicoFunc.EditarFuncionario(cpf, nome, situacaoEnumerador);
                    MessageBox.Show("Funcionário editado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Situação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tEditCPF.Text = "";
            tEditFuncionario.Text = "";
            cEditFuncionario.Text = "";
            tEditFuncionario.Focus();
        }

        private void btnConsultarFuncionariosEdit_Click(object sender, EventArgs e)
        {
            using (var pesquisa = new PesquisaFuncionarios())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    tEditCPF.Text = pesquisa.CPFSelecionado;
                    tEditFuncionario.Text = pesquisa.NomeSelecionado;
                    cEditFuncionario.Text = pesquisa.SituacaoSelecionada.ToString();
                }
            }
        }

        private void btnConsultarTicketEdit_Click(object sender, EventArgs e)
        {
            using (var pesquisa = new PesquisaTickets())
            {
                if (pesquisa.ShowDialog() == DialogResult.OK)
                {
                    ticketIdSelecionado = (int)pesquisa.Tag;
                    tEditTicketNomeFunc.Text = pesquisa.NomeFuncionarioSelecionado;
                    tEditTicketFuncCPF.Text = pesquisa.CPFSelecionado;
                    tEditTicketQuantidade.Text = pesquisa.QuantidadeSelecionada.ToString();
                    cEditTicketAtivo.Text = pesquisa.SituacaoSelecionada;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ticketIdSelecionado == 0)
            {
                MessageBox.Show("Nenhum ticket selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tEditTicketQuantidade.Text, out int novaQuantidade))
            {
                MessageBox.Show("Quantidade inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Enum.TryParse<TipoSituacaoTicket>(cEditTicketAtivo.Text, out var novaSituacao))
            {
                MessageBox.Show("Situação inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var contexto = new AppDbContext())
                {
                    var ticket = contexto.Tickets.FirstOrDefault(t => t.id == ticketIdSelecionado);
                    if (ticket != null)
                    {
                        ticket.quantidade = novaQuantidade;
                        ticket.situacao = novaSituacao;
                        ticket.ultima_atualizacao_cadastro = DateTime.Now.ToUniversalTime();

                        contexto.SaveChanges();
                        MessageBox.Show("Ticket atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ticket não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                ticketIdSelecionado = 0;
                tEditTicketNomeFunc.Text = "";
                tEditTicketFuncCPF.Text = "";
                tEditTicketQuantidade.Text = "";
                cEditTicketAtivo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar ticket: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void funcionárioXTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relatorio = new RelatorioFuncionarioTicketPorData();
            relatorio.ShowDialog();
        }
    }
}
