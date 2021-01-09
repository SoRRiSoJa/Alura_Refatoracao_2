using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{
    class Aluno
    {
        private readonly List<Curso> cursos;
        internal IReadOnlyCollection<Curso> Cursos { get => new ReadOnlyCollection<Curso>(cursos); }

        public Aluno()
        {
            cursos = new List<Curso>();
        }
        public void Adcionar(Curso curso) 
        {
            cursos.Add(curso);
        }
        public void Remover(Curso curso) 
        {
            cursos.Remove(curso);
        }
    }
}
