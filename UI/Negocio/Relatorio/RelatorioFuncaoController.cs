using CadFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Controller.Relatorio
{
    public class RelatorioFuncaoController
    {
        public void ExibirFuncoes()
        {
            using (var conexao = new Conexao())
            {

                IList<Nivel> nivels = conexao.Niveis.ToList();

                foreach (var funcoes in nivels)
                {
                    Console.WriteLine($"ID: {funcoes.Id}, Função: { funcoes.Descricao}, Valor hora: R$ {funcoes.VlrHora}");
                    
                }
            }           
        }
    }
}
