void Ex1()
{
    int[] nums = new int[3];

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Número #{i + 1}: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }

    int max = nums.Max();

    Console.WriteLine($"{max} é o maior.");
}

//Ex1();

void Ex3()
{
    int i1 = 0;
    int soma1 = 0;
    while (i1 <= 10)
    {
        soma1 += i1;
        i1++;
    }
    Console.WriteLine(soma1);
}

//Ex3();

void Ex4()
{
    Console.Write("Digite um número de 1 a 10 ou 0 para sair: ");
    int num = Convert.ToInt32(Console.ReadLine());

    while (num is not 0)
    {
        if (num > 0)
        {
            Console.WriteLine($"\nNúmero selecionado: {num}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        Console.Write("\nDigite um número de 1 a 10 ou 0 para sair: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
}

Ex4();