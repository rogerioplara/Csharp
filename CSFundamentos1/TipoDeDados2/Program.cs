Console.WriteLine("Atribuindo valores a double, float e decimal");

double n1 = 1.234;

//para indicar que é um float, necessário inserir o F no fim
float n2 = 1.1234F;

//para indicar que é um decimal, necessário inserir o M no fim
decimal n3;
n3 = 1.2345m;

//como o windows está em português, o valor será serparado por vírgula quando impresso

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.WriteLine();

Console.WriteLine("Comparado a precisão de float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);