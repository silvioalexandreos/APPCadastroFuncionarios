using CadFuncionario;
using Database;
using System;
using Business;


namespace Business.Repository
{
    public class FuncaoRepository
    {
        Level level = new Level();

        public void SalvarFuncao(string descricao, double vlrHora)
        {
            level.Descricao = descricao;
            level.ValidaCampoDescricao(descricao);

            level.ValidaCampoVlrHoras(vlrHora);
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
