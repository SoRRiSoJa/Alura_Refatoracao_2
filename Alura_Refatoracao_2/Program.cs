using Alura_Refatoracao_2.Aula_1;
using System;

namespace Alura_Refatoracao_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();
            aluno.Adcionar(new Curso("JavaScript Básico"));
            aluno.Adcionar(new Curso("C# Intermediário"));
            aluno.Adcionar(new Curso("Java Avançado"));

        }
    }
}
