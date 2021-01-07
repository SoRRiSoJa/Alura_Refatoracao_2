using System;
using System.Collections.Generic;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Website { get; set; }
        public Cliente()
        {

        }

        public Cliente(int id,string nome, string telefone, string website)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Website = website;
        }
        public override string ToString()
        {
            return $"{Nome} - {Telefone} - {Website}";
        }
    }
}
