using CadFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Controller.Relatorio
{
    public class RelatorioFuncaoBusiness
    {
        public void ExibirFuncoes()
        {
            using (var conexao = new Connection())
            {

                IList<Level> nivels = conexao.Niveis.ToList();

                foreach (var funcoes in nivels)
                {
                    Console.WriteLine($"ID: {funcoes.Id}, Função: { funcoes.Descricao}, Valor hora: R$ {funcoes.VlrHora}");
                    
                }
            }           
        }
    }
}
