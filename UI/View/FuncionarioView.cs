
using CadFuncionario.View;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using UI.Controller.Funcionario;
using UI.Controller.Relatorio;
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
            CrudFuncionarioControler crudFuncionario = new CrudFuncionarioControler();
            RelatorioFuncaoBusiness relatorioFuncao = new RelatorioFuncaoBusiness();

            Console.Clear();
            Console.WriteLine("####################### Cadastro de Funcionário #######################");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Opções de Função:");
            relatorioFuncao.ExibirFuncoes();
            Console.WriteLine("");
            Console.Write("Digite o ID da Função: ");
            int nivelId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas horas trabalho no mês: ");
            int qtdHoras = Convert.ToInt32(Console.ReadLine());

            crudFuncionario.SalvarFuncionario(nome, email, nivelId, qtdHoras);
        }
    }
}
