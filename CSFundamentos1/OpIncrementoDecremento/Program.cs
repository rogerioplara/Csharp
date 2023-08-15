Console.WriteLine("## Operadores de Incremento e Decremento ##\n");

var x = 10;
x++;
Console.WriteLine(x);

x--;
Console.WriteLine(x);
Console.WriteLine();

//pode ser feito o pré incremento ou pós incremento

//faz a operação e depois incrementa
var y = 0;
var resultado = y++ + 10;
Console.WriteLine($"Pós incremento ==> {resultado}");

//incrementa e depois faz a operação
y = 0;
var resultado2 = ++y + 10;
Console.WriteLine($"Pré incremento ==> {resultado2}");

Console.WriteLine();

//faz a operação e depois incrementa
var z = 0;
var r = z-- + 10;
Console.WriteLine($"Pós incremento ==> {r}");

//incrementa e depois faz a operação
z = 0;
var r2 = --z + 10;
Console.WriteLine($"Pré incremento ==> {r2}");