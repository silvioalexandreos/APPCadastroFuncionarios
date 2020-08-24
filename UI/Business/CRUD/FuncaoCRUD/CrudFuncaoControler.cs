using CadFuncionario;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace UI.Controller.Funcao
{
    class CrudFuncaoControler
    {
        Level nivel = new Level();

        public void SalvarFuncao(string descricao, double vlrHora)
        {
            nivel.Descricao = descricao;
            nivel.ValidaCampoDescricao(descricao);

            nivel.ValidaCampoVlrHoras(vlrHora);
            nivel.VlrHora = vlrHora;

            using (var conexao = new Connection())
            {
                conexao.Niveis.Add(nivel);
                conexao.SaveChanges();
                Console.WriteLine("Cadastro Salvo com sucesso...");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }
    }
}
