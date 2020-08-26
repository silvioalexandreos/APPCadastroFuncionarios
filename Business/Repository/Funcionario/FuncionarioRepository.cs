using CadFuncionario;
using Database;
using Database.Domain.Enum;
using System;

namespace Business.CRUD.FuncionarioCRUD
{
    public class FuncionarioRepository
    {
        Developer dev = new Developer();
        Level level = new Level();

        public void SalvarFuncionario(string nome, string email, Level levelT, int qtdHoras)
        {
            
            dev.Nome = nome;
            dev.ValidaCampoNome(nome);

            dev.Email = email;
            dev.ValidarCampoEmail(email);

            dev.level = levelT;

            dev.HorasTrab = qtdHoras;
            dev.ValidarCamposQtdHoras(qtdHoras);


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
