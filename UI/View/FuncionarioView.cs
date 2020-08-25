
using Business;
using Business.CRUD.FuncionarioCRUD;
using CadFuncionario.View;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace CadFuncionario.Controller
{
    
    public class FuncionarioView
    {
        
        public FuncionarioView()
        {
                
        }

        public void CadFuncionario()
        {
            FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
            RelatorioFuncaoBusiness relatorioFuncao = new RelatorioFuncaoBusiness();

            Console.Clear();
            Console.WriteLine("####################### Cadastro de Funcionário #######################");

            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            
            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.WriteLine("Opções de Função:");
            relatorioFuncao.ExibirFuncoes();
            Console.WriteLine("");
            Console.Write("Digite o ID da Função: ");
            var nivelId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas horas trabalho no mês: ");
            var qtdHoras = Convert.ToInt32(Console.ReadLine());

            funcionarioRepository.SalvarFuncionario(nome, email, nivelId, qtdHoras);
        }
    }
}
