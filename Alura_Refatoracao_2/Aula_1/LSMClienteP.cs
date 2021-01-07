using System;
using System.Collections.Generic;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{
    class LSMClienteP
    {
        readonly string nome;
        readonly decimal totalCompras;

        public string Nome => nome;

        public decimal TotalCompras { get=>totalCompras; }

        public LSMClienteP(string nome)
        {
            this.nome = nome;
        }

    }
}
