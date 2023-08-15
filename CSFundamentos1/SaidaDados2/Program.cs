Console.WriteLine("Saída de dados: usando sequência de escape\n");

string local = "c:\\dados\\poesias.txt";

string frase = "Ele falou: \"Não fui eu\" ";

Console.WriteLine(local);
Console.WriteLine(frase);

string pizza = "\nPizza\nde\nMussarela";
string bolo = "\nBolo\tde\vChocolate";
//\v é escape para tab vertical

Console.WriteLine(pizza);
Console.WriteLine(bolo);