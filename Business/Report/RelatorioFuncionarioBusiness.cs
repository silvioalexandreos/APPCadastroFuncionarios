using CadFuncionario;
using Database;
using Database.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
                        var vlrHoras = (from sl in conexao.Niveis
                                       join s in conexao.Desenvolvedores 
                                       on sl.Descricao equals s.LevelEnum
                                       where  s.LevelEnum == sl.Descricao 
                                       select sl).First(); 

                        Level levelSql = new Level();
                        Developer developerSql = new Developer();
                        IList<Level> level = (IList<Level>)conexao.Niveis.ToList();


                        var salario = (desen.HorasTrab * vlrHoras.VlrHora);
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

