using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_4;

    public class Guitarra

    {
        private static string afinacao;
        public Guitarra()
        {
            afinacao = "SOL";
        }
        public void Tocar(){
            TomAfinado();
        }        
        public void Tocar(string afinacaoAtual){
            afinacao  = afinacaoAtual;
            TomAfinado();
        }
        private void  TomAfinado( ){
            Console.WriteLine("A guitarra está com afinação em "+ afinacao);
        }
    }