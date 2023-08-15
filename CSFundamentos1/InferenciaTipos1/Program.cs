Console.WriteLine("## Inferência de Tipos (var) ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2400.00m;

//forma de transformar o valor em valor monetário local ToString("c")
Console.WriteLine($"{nome} tem {idade} anos e recebe {salario.ToString("c")} por mês");

//limitações var

////não pode atribuir null a uma variável var
//var salario = null;
////deve ser inicializada
//var titulo;
////não pode ter múltiplas declarações
//var salario, imposto, total;
////não posso mudar o tipo após inicializar
//var num = 10;
//num = num + 20;
//num = "Teste";

var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}

//var pode ser considerado sugar syntax
//usada para declarar tipos anônimos
//usada em laços for e foreach
//usada em instruções using