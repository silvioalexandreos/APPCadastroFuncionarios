
using Business;
using Business.CRUD.FuncionarioCRUD;
using CadFuncionario.View;
using Database.Domain.Enum;
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

            //LevelEnum levelEnum = new LevelEnum();

            Console.Clear();
            Console.WriteLine("####################### Cadastro de Funcionário #######################");

            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            
            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.WriteLine(" 1 - Junior | 2 - Pleno | 3 - Sênior ");
            Console.Write("Digite o ID da Função: ");

            int level = Convert.ToInt32(Console.ReadLine());

            switch (level)
            {
                case 1:
                    level = (int)LevelEnum.Junior;
                    break;
                case 2:
                    level = (int)LevelEnum.Pleno;
                    break;
                case 3:
                    level = (int)LevelEnum.Senior;
                    break;
                default:
                    throw new Exception("Valor digitado é inválido.");
            }

            LevelEnum level1 = (int)level;



            Console.Write("Quantas horas trabalho no mês: ");
            var qtdHoras = Convert.ToInt32(Console.ReadLine());

            funcionarioRepository.SalvarFuncionario(nome, email, level1, qtdHoras);
        }
    }
}
