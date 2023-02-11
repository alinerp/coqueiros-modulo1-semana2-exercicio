using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_3
{
    public class MensagemCelular
    {
        public int Telefone;
        public string Mensagem;

        public MensagemCelular(int telefone, string mensagem)
        {
            Telefone = telefone;
            Mensagem = mensagem;
        }

        public void Executar(){
            EnviarMensagemAoTelefone();
            Console.WriteLine("Método Executado pelo Console");
        }

        private void EnviarMensagemAoTelefone(){
            Console.WriteLine("Metodo privado executado na classe");
            Console.WriteLine($"Telefone: {Telefone} Mensagem: {Mensagem}");
        }

    }
}