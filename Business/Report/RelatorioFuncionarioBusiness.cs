using CadFuncionario;
using Database;
using System;
using System.Linq;


namespace Business
{
    public class RelatorioFuncionarioBusiness
    {       
        public void Exibir()
        {
            using (var conexao = new Connection())
            {
                Console.Clear();

                var niveis = conexao.Niveis.ToList();
                var desenvolvedores = conexao.Desenvolvedores.ToList();

                foreach (var desen in desenvolvedores)
                {
                    var salario = (desen.HorasTrab * desen.Level.VlrHora);

                    Console.WriteLine($"Status:{desen.Status}, Data Cadastro: " +
                        $"{desen.DataCadastro}, Nome: {desen.Nome}, Email: " +
                        $"{desen.Email}, Nível: {desen.LevelEnum}, Salario: {salario}");                   
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }
    }
}
