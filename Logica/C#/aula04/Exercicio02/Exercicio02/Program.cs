int i = -1; 
string nome = "";

while (nome.ToUpper() != "SAIR")
{   
    Console.WriteLine("Informe seu nome");
    nome = Console.ReadLine();
    Console.WriteLine("");

    i++;
}

Console.WriteLine("Qtde de nomes informados: " + i);
