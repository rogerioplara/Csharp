// if-else-if pode ser utilizado para avaliar mais de uma condição
// se uma condição for verdadeira, executa e pula o restante. Se nenhuma for, executa o else

Console.WriteLine("Informe a nota do aluno: \t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
  Console.WriteLine("\nAluno Reprovado");
}
else if (nota >= 5 && nota <6)
{
  Console.WriteLine("\nAluno de Recuperação");
} 
else if (nota >= 6 && nota <= 9) 
{
  Console.WriteLine("\nAluno Aprovado!");
} 
else if(nota > 9)
{
  Console.WriteLine("\nAluno aprovado com Distinção");
}

Console.WriteLine("\nFim do processamento");
Console.ReadKey();