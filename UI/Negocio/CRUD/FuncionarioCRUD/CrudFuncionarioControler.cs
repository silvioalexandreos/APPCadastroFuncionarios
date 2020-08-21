using CadFuncionario;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Controller.Funcionario
{
    class CrudFuncionarioControler
    {
        Desenvolvedor dev = new Desenvolvedor();

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


            using (var conexao = new Conexao())
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
