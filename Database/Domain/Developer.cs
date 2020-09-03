using CadFuncionario;
using Database.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Developer : Person
    {
        public int HorasTrab { get; set; }
        public int LevelID { get; set; }
        

        public Developer()
        {
            DataCadastro = DateTime.Now;
            Status = true;
        }
        public Developer(DateTime dateTime, string nome, string email, int horasTrab, int levelEnum)
        {
            var level = new Level();

            DataCadastro = dateTime;
            Status = true;
            Nome = nome;
            Email = email;
            HorasTrab = horasTrab;
            LevelID = level.Id;
        }
     

        public string ValidaCampoNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) throw new Exception("Preencha o campo nome corretamente.");

            return nome;
        }

        public int ValidarCampoNivel(int nivel)
        {
            if (nivel < 1 && nivel > 3) throw new Exception("Digite um nível valido.");

            return nivel;
        }

        public int ValidarCamposQtdHoras(int qtdHoras)
        {
            if (qtdHoras < 0) throw new Exception("Quantidade de horas não pode ser negativa.");

            return qtdHoras;
        }

        public string ValidarCampoEmail(string email)
        {
            int emailIndice = email.IndexOf("@");

            if (emailIndice < 0) throw new Exception("Email inválido.");

            return email;
        }
    }
}