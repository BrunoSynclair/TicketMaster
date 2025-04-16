using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TicketMasterVFinal.Aplicacao.Enumeradores;
using TicketMasterVFinal.Aplicacao.Modelos;

namespace TicketMasterVFinal.Aplicacao.Servicos
{
    public class RepoFuncionario
    {
        public List<Funcionario> ListarTodos()
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Funcionarios
                               .OrderBy(f => f.Id)
                               .ToList();
            }
        }

        public void Adicionar(string Nome, string CPF)
        {

            using (var contexto = new AppDbContext())
            {
                contexto.Funcionarios.Add(new Funcionario(Nome, CPF, TipoSituacaoFuncionario.Ativo));
                contexto.SaveChanges();
            }
        }

        public bool VerificaCPF(string CPF)
        {
            using (var contexto = new AppDbContext())
            {
                bool cpfExiste = contexto.Funcionarios.Any(funcionario => funcionario.CPF == CPF);
                return cpfExiste;
            }
        }

        public bool VerificaSituacao(string cpf)
        {
            using (var contexto = new AppDbContext())
            {
                var funcionario = contexto.Funcionarios.FirstOrDefault(f => f.CPF == cpf);
                if (funcionario == null) return true;

                return funcionario.Situacao != TipoSituacaoFuncionario.Ativo;
            }
        }

        public int? BuscarIdPorCPF(string cpf)
        {
            using (var contexto = new AppDbContext())
            {
                var funcionario = contexto.Funcionarios.FirstOrDefault(f => f.CPF == cpf);
                return funcionario?.Id;
            }
        }

        public Funcionario Editar(string cpf, string novoNome, TipoSituacaoFuncionario novaSituacao)
        {
            using (var contexto = new AppDbContext())
            {
                var funcionario = contexto.Funcionarios.FirstOrDefault(f => f.CPF == cpf);
                if (funcionario == null)
                {
                    throw new Exception("Funcionário não encontrado.");
                }

                funcionario.Nome = novoNome;
                funcionario.Situacao = novaSituacao;
                funcionario.ultima_atualizacao_cadastro = DateTime.Now.ToUniversalTime();

                contexto.SaveChanges();

                return funcionario;
            }
        }
    }
}
