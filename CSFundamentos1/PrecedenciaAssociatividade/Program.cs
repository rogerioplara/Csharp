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