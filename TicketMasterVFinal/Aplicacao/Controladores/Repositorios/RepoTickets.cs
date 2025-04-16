using System.Collections.Generic;
using System.Linq;
using TicketMasterVFinal.Aplicacao.Modelos;

namespace TicketMasterVFinal.Aplicacao.Servicos
{
    public class RepoTickets
    {
        public void Adicionar(Tickets ticket)
        {
            using (var contexto = new AppDbContext())
            {
                contexto.Tickets.Add(ticket);
                contexto.SaveChanges();
            }
        }

        public List<Tickets> ListarTodos()
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Tickets.ToList();
            }
        }
    }
}
