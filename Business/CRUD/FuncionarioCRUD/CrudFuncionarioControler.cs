using CadFuncionario;
using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.CRUD.FuncionarioCRUD
{
    public class CrudFuncionarioControler
    {
        Developer dev = new Developer();

        public void SalvarFuncionario(string nome, string email, int nivelId, int qtdHoras)
        {
            dev.Nome = nome;
            dev.ValidaCampoNome(nome);
            dev.Email = email;
            dev.ValidarCampoEmail(email);
            dev.NivelId = nivelId;
            dev.ValidarCampoNivel(nivelId);
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
    }
}
