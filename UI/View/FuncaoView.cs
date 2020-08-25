using System;
using System.Security.Cryptography;
using Business.Repository;
using Database;


namespace UI
{
    public class FuncaoView
    {

        FuncaoRepository funcaoRepository = new FuncaoRepository();


        public FuncaoView()
        {
                
        }

        public void CadFuncao()
        {
            Console.WriteLine("####################### Cadastro de Função #######################");

            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();

            Console.Write("Valor hora: ");
            var vlrHora = Convert.ToDouble(Console.ReadLine());

            funcaoRepository.SalvarFuncao(descricao, vlrHora);

        }
    }
}