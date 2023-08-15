using System.Text;

Console.WriteLine("## Operadores Relacionais ##\n");

/*
 * sempre retornará true ou false:
 * == igualdade
 * > maior que
 * < menor que
 * >= maior ou igual
 * <= menor ou igual
 * != não igual ou diferente de
 */

var x = 10;
var y = 20;
Console.WriteLine(x == y); // false

// pode ser utilizado com strings
string a = "curso";
string b = "Curso";
//false - case sensitive
Console.WriteLine(a == b);
//false - mesmo comportamento do operador de igualdade
Console.WriteLine(a.Equals(b));

Console.WriteLine();

Console.WriteLine(x == y); //false
Console.WriteLine(x > y); //false
Console.WriteLine(x < y); //true
Console.WriteLine(x >= y); //false
Console.WriteLine(x <= y); // true
Console.WriteLine(x != y); // true

Console.WriteLine();