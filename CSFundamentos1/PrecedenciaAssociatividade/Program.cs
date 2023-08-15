Console.WriteLine("## Precedência e Associatividade ##\n");

int x = 10 - 2 * 3;
Console.WriteLine(x);

int y = (10 - 2) * 3;
Console.WriteLine(y);
Console.WriteLine();


// PRECEDÊNCIA: ! -> && -> ||

bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b);
// FALSE && FALSE || TRUE
// FALSE || TRUE
// TRUE

bool c = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(c);
// FALSE && TRUE
// FALSE

//ordem dos operadores -> verificar tabela site microsoft
int n1 = 5, n2 = 6, n3 = 4;
int r = --n1 * n2 - ++n3;
Console.WriteLine(r);
// os incrementos precedem a multiplicação - resultado 19

//nesse caso o resultado será 3 (associatividade) -> o sinal de igualdade anda da direita para a esquerda
int x1 = 5, x2 = 6, x3 = 3;
int r2 = x1 = x2 = x3;
Console.WriteLine(r2);
