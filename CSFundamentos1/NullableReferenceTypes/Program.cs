Console.WriteLine("## Nullable Reference Types ##\n");

// quando o tipo de referência não tem nenhuma referência, retorna null

// recurso de tempo de compilação, avisa quando o código pode levar a excessões de referencia nula mas roda o código

// sua finalidade é minimizar a chance do erro System.NullReferenceException

// o alerta é ativado quando o element <Nullable> no projeto é definido como enable;
// <nullable>enable</nullable>

string? nome = null;
//como acessar sem correr o risco de causar erro, se não for nulo o método é executado, se for null o resultado é null
Console.WriteLine(nome?.ToUpper());

// é possível também utilizar dessa forma:
string name = "";
Console.WriteLine(name?.ToUpper()); //null conditionalo operator

