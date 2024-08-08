string usuario; string senha;

Console.WriteLine("Informe o usuário");
usuario = Console.ReadLine();
Console.WriteLine("Informe a senha");
senha = Console.ReadLine();

if (usuario == "matuzalem" && senha == "123a")
{
    Console.WriteLine("Seja bem vindo usuário Matuzalem");
}
else if (usuario == "benegundes" && senha == "vaifilao")
{
    Console.WriteLine("Seja bem vindo usuário Benegunde");
}
else if (usuario == "judith" && senha == "genoveva")
{
    Console.WriteLine("Seja bem vindo usuário Judith");
}
else
{
    Console.WriteLine("Usuário ou senha inválido");
}