Console.WriteLine("## Break e Continue ##");

int n = 1;
for (int i = 0; i < 10; i++)
{
    if (i == 5) continue;

    if (i > 8) break;

    Console.WriteLine(i);
}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();