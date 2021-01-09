using System;
using System.Collections.Generic;
using System.Text;

namespace Alura_Refatoracao_2.Aula_1
{

    class ContaCorrente
    {
        private decimal saldo;

        public decimal Saldo { get => saldo; }

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            this.saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }
    }
}
