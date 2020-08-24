using CadFuncionario.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadFuncionario.View
{
    static class HomeView
    {
        /// <summary>
        /// Lista todas as opções do Menu.
        /// Só é permitido campo inteiro para realizar as escolha das opções.
        /// </summary>
        public static void Menu()
        {
            do
            {

                Console.Clear();

                Console.WriteLine("###### Escolha a opção desejada #####");
                Console.WriteLine(" 1 - Cadastro de Função: ");
                Console.WriteLine(" 2 - Cadastro de Funcionário: ");
                Console.WriteLine(" 3 - Listar Funcionarios ");
                Console.WriteLine(" 4 - Fechar");

                Console.Write("Qual a opção desejada: ");

                HomeBusiness homeController = new HomeBusiness();
                homeController.MenuSelecao();

            } while (true);
        }
    }
}

