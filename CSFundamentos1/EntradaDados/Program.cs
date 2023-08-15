Console.WriteLine("## Entrada de dados ##\n");

Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Seu nome é {nome}!");

Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Você tem {idade} anos de idade!\n");

Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos de idade");

//Console.Read(); lê somente 1 caractere e retorna seu código ASCII
//Console.ReadLine(); lê a linha como um todo
//Console.ReadKey(); lê a próxima entrada no teclado e retorna essa tecla

