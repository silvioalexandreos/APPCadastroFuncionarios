using CadFuncionario;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Business
{
    public class RelatorioFuncionarioBusiness
    {
        /// <summary>
        /// Exibe todos os registros contidos na tabela de desenvolvedores.
        /// Faz a multiplicação da quantidade de horas trabalhas vezes o valor da hora para o respectivo nível do desenvolvedor.
        /// </summary>
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
                    IList<Level> nivels = (IList<Level>)conexao.Niveis.ToList();

                    var salario = (desen.HorasTrab * desen.Nivel.VlrHora);
                    Console.WriteLine($"Status:{desen.Status}, Data Cadastro: {desen.DataCadastro}, Nome: {desen.Nome}, Email: {desen.Email}, Nivel: {desen.Nivel.Descricao}, Salario:  {salario}");
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }
    }
}

