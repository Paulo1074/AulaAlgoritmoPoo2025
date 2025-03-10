string resposta;

Console.WriteLine("O animal é mamífero? (S/N)");
resposta = Console.ReadLine().ToUpper();

if (resposta == "S")
{
    Console.WriteLine("É quadrúpede? (S/N)");
    resposta = Console.ReadLine().ToUpper();
    if (resposta == "S")
    {
        Console.WriteLine("É carnívoro? (S/N)");
        resposta = Console.ReadLine().ToUpper();
        Console.WriteLine(resposta == "S" ? "Leão" : "Cavalo");
    }
    else
    {
        Console.WriteLine("É bípedo? (S/N)");
        resposta = Console.ReadLine().ToUpper();
        Console.WriteLine(resposta == "S" ? "Homem ou Macaco" : "Morcego");
    }
}
else
{
    Console.WriteLine("É ave? (S/N)");
    resposta = Console.ReadLine().ToUpper();
    if (resposta == "S")
    {
        Console.WriteLine("É nadadora? (S/N)");
        resposta = Console.ReadLine().ToUpper();
        Console.WriteLine(resposta == "S" ? "Pato" : "Águia");
    }
    else
    {
        Console.WriteLine("Baleia");
    }
}
