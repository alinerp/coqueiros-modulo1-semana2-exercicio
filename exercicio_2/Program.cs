/*
Detalhes da classe

Modificador de acesso publico
Propriedades
Id tipo inteiro (int)
Nome tipo texto (string)
DataNascimento tipo DataHora (datetime)
MenorIdade tipo boleano (bool)
Criar um método que escreva no console o texto com os campos da Classe
Exemplo. Código {Id}, Nome {Nome}, Data Nascimento {DataNascimento}
Instanciar a classe no console conforme mostrado em aula
*/

using exercicio_2;

/*var fichaInscricao = new FichaInscricao();
fichaInscricao.Id = 012345;
fichaInscricao.Nome = "José da Silva";
fichaInscricao.DataNascimento = new DateTime(2000, 10, 01);
fichaInscricao.MenorIdade = true;
fichaInscricao.Imprimir();*/

var fichaInscricao2 = new FichaInscricao(012345, "José da Silva", new DateTime(2000, 10, 01), true);
fichaInscricao2.Imprimir();
