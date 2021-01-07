using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{
    class Empresa
    {
        public Empresa()
        {
            using (var streamReader = File.OpenText("clientes.csv"))
            {
                string linha = string.Empty;
                while ((linha = streamReader.ReadLine()) != null)
                {
                    string[] fields = linha.Split(',');
                    Cliente cli = new Cliente(int.Parse(fields[0]), fields[1],fields[2],fields[3]);
                    
                    Console.WriteLine("Dados do Cliente");
                    Console.WriteLine("================");
                    Console.WriteLine("ID: " + cli.Id);
                    Console.WriteLine("Nome: " + cli.Nome);
                    Console.WriteLine("Telefone: " + cli.Telefone);
                    Console.WriteLine("Website: " + cli.Website);
                    Console.WriteLine("================");
                }
            }
        }
}
