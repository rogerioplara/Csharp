Console.WriteLine("Definindo Identificadores");
Console.WriteLine();

//Identificadores válidos
string nome;
string nomeCompleto;
int idade;
int _valor;
int idade1;

//identificadores inválidos
/*
int 5idade;
int $valor;
int valor#;
string nome Completo;
*/

//para nomes de variáveis: camel case
string descontoTotal;

//constantes: maiúsculas
double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";

//nomes de classes e métodos: pascal case
class ImprimirTexto
{
    public void ImprimeNome()
    {
        Console.WriteLine("Rogerio");
    }
}