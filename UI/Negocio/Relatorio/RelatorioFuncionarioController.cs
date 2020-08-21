using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI;

namespace CadFuncionario.Controller
{
    class RelatorioFuncionarioController
    {
        /// <summary>
        /// Exibe todos os registros contidos na tabela de desenvolvedores.
        /// Faz a multiplicação da quantidade de horas trabalhas vezes o valor da hora para o respectivo nível do desenvolvedor.
        /// </summary>
        public RelatorioFuncionarioController()
        {
                
        }

        
        public void Exibir()
        {
            using (var conexao = new Conexao())
            {
                
                Console.Clear();

                IList<Desenvolvedor> desenvolvedores = conexao.Desenvolvedores.ToList();
                foreach (var desen in desenvolvedores)
                {
                    IList<Nivel> nivels = conexao.Niveis.ToList();

                    double salario = (desen.HorasTrab * desen.Nivel.VlrHora);
                    Console.WriteLine($"Status:{desen.Status}, Data Cadastro: {desen.DataCadastro}, Nome: {desen.Nome}, Email: {desen.Email}, Nivel: {desen.Nivel.Descricao}, Salario:  {salario}");
                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }
    }
}

