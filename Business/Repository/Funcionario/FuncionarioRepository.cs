using CadFuncionario;
using Database;
using Database.Domain.Enum;
using System;

namespace Business.CRUD.FuncionarioCRUD
{
    public class FuncionarioRepository
    {
        Developer dev = new Developer();

        public void SalvarFuncionario(string nome, string email, int level, int qtdHoras, int levelID)
        {

            dev.ValidaCampoNome(nome);
            dev.Nome = nome;
            

            dev.ValidarCampoEmail(email);
            dev.Email = email;


            dev.ValidarCampoNivel(level);
            dev.LevelEnum = (LevelEnum)level;
            

            dev.ValidarCamposQtdHoras(qtdHoras);
            dev.HorasTrab = qtdHoras;

            dev.LevelID = levelID;

            using (var conexao = new Connection())
            {
                conexao.Desenvolvedores.Add(dev);
                conexao.SaveChanges();
                Console.WriteLine("Cadastro Salvo com sucesso...");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }

        public void SalvarFuncionario()
        {
            throw new NotImplementedException();
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        