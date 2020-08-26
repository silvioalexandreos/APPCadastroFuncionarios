using CadFuncionario;
using Database;
using System;
using Business;
using Database.Domain.Enum;

namespace Business.Repository
{
    public class FuncaoRepository
    {
        Level level = new Level();
        LevelEnum levelEnum = new LevelEnum();

        public void SalvarFuncao(LevelEnum levelEnum, double vlrHora)
        {

            level.Descricao = levelEnum;
            level.VlrHora = vlrHora;


            using (var conexao = new Connection())
            {
                conexao.Niveis.Add(level);
                conexao.SaveChanges();
                Console.WriteLine("Cadastro Salvo com sucesso...");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu incial.");
                Console.ReadLine();
            }
        }
    }
}
