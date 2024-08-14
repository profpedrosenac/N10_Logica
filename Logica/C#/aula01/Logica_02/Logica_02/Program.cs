// See https://aka.ms/new-console-template for more information

string nome;
string sobrenome;
int idade;

Console.Write("Informe seu nome: ");
nome = Console.ReadLine();

Console.Write("Informe seu sobrenome: ");
sobrenome = Console.ReadLine();

Console.Write("Informe sua idade: ");
idade =  int.Parse(Console.ReadLine());

Console.WriteLine("Seu nome completo: " + nome + " " + sobrenome +
                  " com idade de " + idade.ToString() + " anos.");