
class Funcionario
{                   //( parâmetros                        )                             
    public Funcionario( string cpf, string nome, int idade) {//Contrutor é o que dispara as informações quando chamadas pelo new NomeClasse.
        Console.WriteLine($"O seu nome é: {nome}"); 
        Console.WriteLine($"A sua idade é: {idade}");
        Console.WriteLine($"O seu CPF é: {cpf}");
    }
};
