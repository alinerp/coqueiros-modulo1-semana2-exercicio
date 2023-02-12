using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_6
{
    public class Filme
    {
        public string NomeFilme;
        public string Categoria;

        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }

        public void Exibir(){

            Console.WriteLine($"Filme {NomeFilme}, Catergoria {Categoria}");
        }
      
        
    }
}