using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_8
{
    public class Pessoa
    {
        string Nome;
        DateTime DataNascimento;

        public void MostrarIdade()
        {
            var idade = CalcularIdade();
            Console.WriteLine($"Nome {this.Nome} tem a Idade {idade}");
        }

        private int CalcularIdade()
        {
            
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - this.DataNascimento.Year;
            if (this.DataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            } 
            return idade;
        }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
            this.Nome = nome;
        }
    }
}