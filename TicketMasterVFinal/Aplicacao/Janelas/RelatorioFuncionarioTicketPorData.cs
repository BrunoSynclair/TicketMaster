using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using TicketMasterVFinal.Aplicacao.Modelos;

namespace TicketMasterVFinal.Aplicacao.Janelas
{
    public partial class RelatorioFuncionarioTicketPorData : Form
    {
        public RelatorioFuncionarioTicketPorData()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnGerarRelatorioFuncTicketPorData_Click(object sender, EventArgs e)
        {
            var inicio = DateTime.SpecifyKind(dtInicio.Value.Date, DateTimeKind.Utc);
            var fim = DateTime.SpecifyKind(dtFim.Value.Date.AddDays(1).AddTicks(-1), DateTimeKind.Utc);

            using (var db = new AppDbContext())
            {
                var tickets = db.Tickets
                    .Include(t => t.Funcionario)
                    .Where(t => t.ultima_atualizacao_cadastro >= inicio && t.ultima_atualizacao_cadastro <= fim)
                    .ToList();

                if (tickets.Count == 0)
                {
                    MessageBox.Show("Nenhum ticket encontrado no período informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var sb = new StringBuilder();

                sb.AppendLine("Tickets gerados por período");
                sb.AppendLine();

                var ticketsPorFuncionario = tickets
                    .GroupBy(t => t.Funcionario)
                    .OrderBy(f => f.Key.CPF);

                foreach (var grupoFuncionario in ticketsPorFuncionario)
                {
                    sb.AppendLine($"{grupoFuncionario.Key.CPF} - {grupoFuncionario.Key.Nome}");
                    sb.AppendLine("ID".PadRight(5) + "Quantidade".PadRight(12) + "Situação".PadRight(20) + "Data");

                    foreach (var ticket in grupoFuncionario.OrderBy(t => t.id))
                    {
                        string situacaoTexto = ticket.situacao == Enumeradores.TipoSituacaoTicket.Ativo
                            ? "Ticket(s) Ativo"
                            : "Ticket(s) Inativo";

                        string dataTexto = ticket.ultima_atualizacao_cadastro?.ToLocalTime().ToString("dd/MM/yyyy");

                        sb.AppendLine(
                            ticket.id.ToString().PadRight(5) +
                            ticket.quantidade.ToString().PadRight(12) +
                            situacaoTexto.PadRight(20) +
                            dataTexto
                        );
                    }

                    sb.AppendLine();
                }

                var caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "relatorio_tickets.txt");
                File.WriteAllText(caminho, sb.ToString());

                MessageBox.Show($"Relatório salvo em:\n{caminho}", "Relatório Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("notepad.exe", caminho);
            }
        }
    }
}
