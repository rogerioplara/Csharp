Console.WriteLine("## Constantes ##");

// declaradas usando o modificador const e devem ser inicializadas

const int ANO = 12;
const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

Console.WriteLine(DIAS_POR_MES);

//calcular a área e o perímetro de um círculo

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do círculo: ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"Perímetro = {perimetro:N4}");
Console.WriteLine($"Area = {area:N4}");