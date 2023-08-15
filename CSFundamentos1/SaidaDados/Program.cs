Console.WriteLine("Saída de dados: Formatação ");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.WriteLine(idade);

//escrever na mesma linha 'Maria tem 25 anos'

//concatenação
Console.WriteLine(nome + " tem " + idade + " anos.");

//interpolação
Console.WriteLine($"{nome} tem {idade} anos.");

//placeholders
Console.WriteLine("{0} tem {1} anos.", nome, idade);