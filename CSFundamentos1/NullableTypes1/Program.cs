Console.WriteLine("## Nullable Types ##\n");

//int valor = null;
//Console.WriteLine(valor);

//nullable type pode receber um valor null
//sintaxe Nullable<tipo><nome> = null;
//ex: Nullable<bool> b = null;
//o bool suporte true, false e null

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);

//pode ter a declaração simplificada utilizando a interrogação
int? I = null;
double? D = null;
bool? B = null;

//são diferentes dos tipos por valor
//não é possível atribuir um nullable type a um int, mas o inverso é verdadeiro

//é possível utilizar o operador ?? para tribuir um tino anulável a um não anulável
int? x = null;
int y = x ?? 0;
Console.WriteLine(b);
//traduzindo: se x for null, atribui 0 a variavel int y

//propriedades somente leitura: HasValue e Value
int? c = null;
if (c.HasValue)
{
    Console.WriteLine($"c = {c.Value}");
}
else
{
    Console.WriteLine("c não possui um valor (null)");
}