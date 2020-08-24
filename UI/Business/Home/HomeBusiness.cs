using System;
using System.Collections.Generic;
using System.Text;

namespace CadFuncionario.Controller
{
    class HomeBusiness
    {
        public HomeBusiness()
        {

        }
        /// <summary>
        /// Opção 1: Cadastro de Função,  
        /// Opção 2: Cadastro de funcionário,
        /// Opção  3: listar todos os cadastros selecionados.
        /// </summary>
        /// 
        public void MenuSelecao()
        {
            FuncaoView cadastrarController = new FuncaoView();
            FuncionarioView funcionario = new FuncionarioView();
            RelatorioFuncionarioBusiness listar = new RelatorioFuncionarioBusiness();


            try
            {
                int selecao;
                selecao = Convert.ToInt32(Console.ReadLine());

                switch (selecao)
                {
                    case 1:
                        Console.Clear();
                        cadastrarController.CadFuncao();
                        break;
                    case 2:
                        Console.Clear();
                        funcionario.CadFuncionario();
                        break;
                    case 3:
                        Console.Clear();
                        listar.Exibir();
                        break;
                    case 4:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção invalida.");
                        break;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("O campo deve ser preenchido com valor numérico.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}
