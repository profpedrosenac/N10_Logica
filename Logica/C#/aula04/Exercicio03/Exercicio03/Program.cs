int par = 0; int impar = 0; int val;
string n = "";
while (n.ToUpper() != "SAIR")
{
    Console.Write("Informe seu N: ");
    n = Console.ReadLine();
    if (int.TryParse(n, out val))
    {
        if (val % 2 == 0)
        {
            par++;
        }
        else if (val % 2 == 1)
        {
            impar++;
        }
    }  
}
Console.WriteLine("Total de Pares " + par);
Console.WriteLine("Total de Impares " + impar);


