using System;
using System.Windows.Forms;
using TicketMasterVFinal.Aplicacao.Modelos;
using TicketMasterVFinal.Aplicacao.Servicos;

namespace TicketMasterVFinal.Aplicacao.Controladores.Servicos
{
    internal class ServTicket
    {
        private readonly RepoTickets repoTickets;
        private readonly RepoFuncionario repoFuncionario;

        public ServTicket()
        {
            repoTickets = new RepoTickets();
            repoFuncionario = new RepoFuncionario();
        }

        public void EntregarTickets(string FuncionarioCPF, int Quantidade)
        {
            if (!repoFuncionario.VerificaCPF(FuncionarioCPF))
            {
                MessageBox.Show("Funcionário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (repoFuncionario.VerificaSituacao(FuncionarioCPF))
            {
                MessageBox.Show("Não é possível entregar tickets para funcionário inativo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? funcionarioId = repoFuncionario.BuscarIdPorCPF(FuncionarioCPF);

            if (funcionarioId == null)
            {
                MessageBox.Show("Erro ao localizar ID do funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novoTicket = new Tickets
            {
                funcionarioID = funcionarioId.Value,
                quantidade = Quantidade,
                ultima_atualizacao_cadastro = DateTime.UtcNow
            };

            repoTickets.Adicionar(novoTicket);
            MessageBox.Show("Ticket registrado com sucesso!");
        }
        public List<Tickets> ListarTicketsPorCpf(string cpf)
        {
            int? funcionarioId = repoFuncionario.BuscarIdPorCPF(cpf);

            if (funcionarioId == null)
                return new List<Tickets>();

            return repoTickets.ListarTodos()
                .Where(t => t.funcionarioID == funcionarioId.Value)
                .ToList();
        }

    }
}
