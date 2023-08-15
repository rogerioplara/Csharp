Console.WriteLine("## Operadores Lógicos Condicionais ##\n");


/*
 * Sempre retornará true ou false - tabela verdade
 * &&   AND     E
 * ||   OR      OU
 * !    NOT     NÃO
 */

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");

//operador AND -> &&
resultado = c1 && c2;
Console.WriteLine("Operador And (&&): " + resultado);

//operador OR -> ||
resultado = c1 || c2;
Console.WriteLine("Operador OR (||): " + resultado);

//operador NOT -> !
resultado = !c1;
Console.WriteLine("Operador NOT (!): " + resultado);
