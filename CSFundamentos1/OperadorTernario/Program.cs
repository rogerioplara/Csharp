Console.WriteLine("## Operador Unário e Ternário ##\n");

// O operador ternário utiliza 3 argumentos e avalia uma expressão booleana  ? :

Console.WriteLine("Informe um número: \n");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {n} é {-n}\n");

//condição ? expressão_se_true : expressão_se_false;

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {resultado}\n\n");

// aninhando operações

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string resultado2 = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(resultado2);