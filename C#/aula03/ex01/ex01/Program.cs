string produto; float qtde; float valor; int tipo; float total; float total2;

Console.Write("Informe Produto: ");
produto = Console.ReadLine();

Console.Write("Informe Qtde: ");
qtde = float.Parse(Console.ReadLine());

Console.Write("Informe Valor Unitário: ");
valor = float.Parse(Console.ReadLine());

Console.WriteLine("Informe tipo de pagamento: ");
Console.WriteLine("1 - PIX");
Console.WriteLine("2 - Crédito");
Console.WriteLine("3 - Boleto");
Console.WriteLine("4 - Dinheiro");
tipo = int.Parse(Console.ReadLine());

total = qtde * valor;

if (tipo == 1)
{
    total2 = total * 0.95F;
}
else if (tipo == 2)
{
    total2 = total * 1.1F;
}
else if (tipo == 3)
{
    total2 = total * 1.15F;
}
else if (tipo == 4)
{
    total2 = total;
}
else
{
    Console.WriteLine("Opção inválida");
    return;
}

Console.WriteLine("");
Console.WriteLine("Total Geral: " + total.ToString("C"));
Console.WriteLine("Total a Pagar: " + total2.ToString("C"));

