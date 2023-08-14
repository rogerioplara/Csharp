internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
        Console.WriteLine();

        string nome = "Curso C#";
        string titulo = "Curso C# Essencial";

        Console.WriteLine(nome);
        Console.WriteLine(titulo);

        //as strings são IMUTÁVEIS

        string valor = "Isto é uma string";

        //é possível fazer isso, porém será criada uma nova variável em um novo espaço de memória
        valor = "Isto é uma string alterada";

        valor = "teste";

        //para alterações de strings, o ideal é utilizar o StringBuilder

        //dynamic suporta linguagens dinamicas
        object nota = 10;
        dynamic value = 8.55m;
        object name = "Maria";
        dynamic ativa = true;
        object letra = 'A';

        Console.WriteLine(nota);
        Console.WriteLine(value);
        Console.WriteLine(name);
        Console.WriteLine(ativa);
        Console.WriteLine(letra);
    }
}