using CadFuncionario;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Business
{
    public class RelatorioFuncionarioBusiness
    {
        public RelatorioFuncionarioBusiness()
        {
                
        }

        
        public void Exibir()
        {
            using (var conexao = new Connection())
            {
                
                Console.Clear();

                IList<Developer> desenvolvedores = (IList<Developer>)conexao.Desenvolvedores.ToList();
                foreach (var desen in desenvolvedores)
                {
                    IList<Level> levels = (IList<Level>)conexao.Niveis.ToList();

                    var salario = (desen.HorasTrab * desen.level.VlrHora);
                    Console.WriteLine($"Status:{desen.Status}, Data Cadastro: " +
                        $"{desen.DataCadastro}, Nome: {desen.Nome}, Email: " +
                        $"{desen.Email}, Salario:  {salario}");
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }
    }
}

