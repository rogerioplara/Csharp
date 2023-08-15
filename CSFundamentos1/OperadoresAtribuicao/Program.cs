using System.Drawing;

Console.WriteLine("## Operadores de atribuição ##\n");

//usando operadores de atribruição com tipos numéricos;

double x = 10;
x = 20;

Console.WriteLine($"Valor inicial de x = {x}");

Console.WriteLine($"x += 5 ==> {x += 5}");
Console.WriteLine($"x -= 3 ==> {x -= 3}");
Console.WriteLine($"x *= 4 ==> {x *= 4}");
Console.WriteLine($"x /= 5 ==> {x /= 5}");
Console.WriteLine($"x %= 5 ==> {x %= 5}");


//operador + e += pode ser usado com strings
Console.WriteLine();

var y = "123";

Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y += \"456\" ==> {y += "456"}");