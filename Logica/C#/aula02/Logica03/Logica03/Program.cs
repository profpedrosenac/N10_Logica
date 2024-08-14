float n1; float n2; float n3; float n4; float media;

Console.Write("Informe N1: ");
if (float.TryParse(Console.ReadLine(),out n1) == false)
{
    Console.WriteLine("Erro, valor deve ser numérico!");
    return;
}
if (n1 < 0 || n1 >10)
{
    Console.WriteLine("Erro, valor deve ser entre 0 e 10!");
    return;
}

Console.Write("Informe N2: ");
if (float.TryParse(Console.ReadLine(), out n2) == false)
{
    Console.WriteLine("Erro, valor deve ser numérico!");
    return;
}
if (n2 < 0 || n2 > 10)
{
    Console.WriteLine("Erro, valor deve ser entre 0 e 10!");
    return;
}


Console.Write("Informe N3: ");
if (float.TryParse(Console.ReadLine(), out n3) == false)
{
    Console.WriteLine("Erro, valor deve ser numérico!");
    return;
}
if (n3 < 0 || n3 > 10)
{
    Console.WriteLine("Erro, valor deve ser entre 0 e 10!");
    return;
}


Console.Write("Informe N4: ");
if (float.TryParse(Console.ReadLine(), out n4) == false)
{
    Console.WriteLine("Erro, valor deve ser numérico!");
    return;
}
if (n4 < 0 || n4 > 10)
{
    Console.WriteLine("Erro, valor deve ser entre 0 e 10!");
    return;
}



media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine();
Console.WriteLine(media);