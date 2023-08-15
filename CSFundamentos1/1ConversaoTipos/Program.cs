Console.WriteLine("## Conversão de tipos ##\n");

//conversão implícita, é possível com tipos compatíveis
//nesse caso, o int tem 4 bytes e double tem 8 -> o inverso não é verdadeiro
int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numerDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numerDouble);
Console.WriteLine(numeroDecimal);

Console.WriteLine("Conversão explícita\n");

double a = 12.456;
//nesse caso é necessário fazer um cast, porém pode perder precisão
int b = (int)a;
Console.WriteLine(b);

//perde-se dados do resultado por causa dos tipos, necessário fazer o cast
int num1 = 10;
int num2 = 4;
float resultado = (float)num1 / num2;
Console.WriteLine(resultado);

