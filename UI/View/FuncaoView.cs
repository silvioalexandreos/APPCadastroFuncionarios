using CadFuncionario.Controller;
using CadFuncionario.View;
using System;
using System.Security.Cryptography;
using Database;
using Business.CRUD.FuncionarioCRUD;

namespace CadFuncionario.UI
{
    public class FuncaoView
    {
        CrudFuncaoControler crudFuncao = new CrudFuncaoControler(); 
        public FuncaoView()
        {
                
        }

        public void CadFuncao()
        {

            Console.WriteLine("####################### Cadastro de Função #######################");

            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Valor hora: ");
            double vlrHora = Convert.ToDouble(Console.ReadLine());
           
            crudFuncao.SalvarFuncao(descricao, vlrHora);

        }
    }
}