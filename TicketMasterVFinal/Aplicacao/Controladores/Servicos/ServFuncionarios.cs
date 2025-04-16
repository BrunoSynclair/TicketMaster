using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketMasterVFinal.Aplicacao.Enumeradores;
using TicketMasterVFinal.Aplicacao.Modelos;
using TicketMasterVFinal.Aplicacao.Servicos;

namespace TicketMasterVFinal.Aplicacao.Controladores.Servicos
{
    class ServFuncionario
    {
        RepoFuncionario repoFuncionario = new RepoFuncionario();
        public ServFuncionario() { }

        public List<Funcionario> ConsultarFuncionarios()
        {
            try
            {
                return repoFuncionario.ListarTodos();
            }
            catch (Npgsql.PostgresException erro)
            {
                MessageBox.Show($"Falha ao realizar a consulta: {erro.Message}","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void NovoFuncionario(Funcionario funcionario)
        {
            if (!ValidarCPF(funcionario.CPF))
            {
                MessageBox.Show("CPF inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (repoFuncionario.VerificaCPF(funcionario.CPF))
            {
                MessageBox.Show("CPF já cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repoFuncionario.Adicionar(funcionario.Nome, funcionario.CPF);
            MessageBox.Show("Funcionário cadastrado com sucesso!");
        }

        public Funcionario EditarFuncionario(string cpf, string novoNome, TipoSituacaoFuncionario situacao)
        {
            return repoFuncionario.Editar(cpf, novoNome, situacao);
        }

        public static bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
