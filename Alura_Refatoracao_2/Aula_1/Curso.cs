using System;
using System.Collections.Generic;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{
    class Curso
    {
        readonly string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public Curso(string nome)
        {
            this.nome = nome;
        }
    }
}
