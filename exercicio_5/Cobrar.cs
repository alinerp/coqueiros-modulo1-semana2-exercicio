using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_5
{
    public class Cobrar
    {
        private decimal Valor;//this (propriedade de classe sempre letra Maiscula)
        private decimal Multa;//this

        public Cobrar(decimal valor, decimal multa) {
            this.Valor = valor;
            this.Multa = multa;
        }

        private decimal CalcularMulta(decimal _valor, decimal _multa)//Esses parametros não tem ligação as propriedades da classe
        {
            return _valor + _multa;
        }

        public void Calcular(){ //variáveis sempre com letra minuscula
            var somaValor = this.CalcularMulta(this.Valor, this.Multa);
            Console.WriteLine($"Valor cobrado {this.Valor}, Multa {this.Multa}, Soma Valor {somaValor}");
        }
    }
}