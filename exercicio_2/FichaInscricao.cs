using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_2;

public class FichaInscricao
{
    public int Id;
    public string Nome;
    public DateTime DataNascimento;
    public bool MenorIdade;

    public void Imprimir() {
        Console.WriteLine($"Codigo: {Id} Nome: {Nome} Data Nascimento: {DataNascimento}");
    }

    public FichaInscricao(int id, string nome, DateTime dataNascimento, bool menorIdade)
    {
        Id = id;
        Nome = nome;
        DataNascimento = dataNascimento;
        MenorIdade = menorIdade;
    }

}
