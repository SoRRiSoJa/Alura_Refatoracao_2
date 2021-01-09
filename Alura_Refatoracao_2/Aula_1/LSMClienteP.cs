using System;
using System.Collections.Generic;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{
    class LSMClienteP
    {
        public string Nome { get; set; }
        public decimal TotalCompras { get; set; }


        public LSMClienteP(string nome)
        {
            Nome = nome;
        }

        public void AddItem(Item item)
        {
            TotalCompras += item.Total;
        }

        internal void Remove(Item item)
        {
            TotalCompras -= item.Total;
        }
    }
}
