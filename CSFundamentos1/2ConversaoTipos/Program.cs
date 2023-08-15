Console.WriteLine("## ToString() ##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

//converte os números para string
string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

//também é possível utilizar a classe Convert();
/*
ToBoolean();
ToChar();
ToDouble();
ToInt16();
ToInt32();
ToString();
*/
Console.WriteLine();

int n1 = 10;
double n2 = 5.35;
bool n3 = true;

Console.WriteLine(Convert.ToString(n1));
Console.WriteLine(Convert.ToDouble(n1));
Console.WriteLine(Convert.ToString(n3));
Console.WriteLine(Convert.ToInt32(n2));

//quando uma conversão de estreitamento de dados resultar em perda de dados, vai ocorrer uma OverflowException
int a = 100000;
Console.WriteLine(Convert.ToByte(a));