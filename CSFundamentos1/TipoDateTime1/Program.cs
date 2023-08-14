Console.WriteLine("## Struct DateTime ##\n");

//criando data atual
DateTime hoje = DateTime.Now;
Console.WriteLine($"Hoje: {hoje}\n");

//adicionando valores
Console.WriteLine("Adicionando valores");
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));
Console.WriteLine();

//obter o dia da semana e do ano
Console.WriteLine("Obter o dia da semana e o ano");
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);
Console.WriteLine();

//formato longo e curto
Console.WriteLine("Formato longo e curto");
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());
Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());
Console.WriteLine();

//criando data específica: aaaa,mm,dd
Console.WriteLine("Criando data específica");
DateTime dataHoje = new DateTime(2023, 08, 13);
Console.WriteLine(dataHoje);

//definir as horas
Console.WriteLine("Definindo as horas");
DateTime dataHoraHoje = new DateTime(2023, 08, 13, 10,10,54);
Console.WriteLine(dataHoraHoje);
Console.WriteLine();

//extrair informações da data atual
Console.WriteLine("Extraindo informações da data atual");
Console.WriteLine("Ano: " + hoje.Year);
Console.WriteLine("Mês: " + hoje.Month);
Console.WriteLine("Dia: " + hoje.Day);
Console.WriteLine("Hora: " + hoje.Hour);
Console.WriteLine("Minuto: " + hoje.Minute);
Console.WriteLine("Segundo: " + hoje.Second);
Console.WriteLine("Milisegundo: " + hoje.Millisecond);



