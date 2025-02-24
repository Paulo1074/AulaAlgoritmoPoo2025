Console.Write("Digite o sexo (masculino/feminino): ");
string sexo = Console.ReadLine().ToLower();

Console.Write("Digite a altura (em metros)");
double altura = double.Parse(Console.ReadLine());

double pesoIdeal;
if (sexo == "masculino")
{
    pesoIdeal = (72.7 * altura) - 58;
}
else if (sexo == "feminino")
{
    pesoIdeal = (62.1 * altura) - 44.7;
}
else
{
    Console.WriteLine("Sexo inválido");
    return;
}

Console.WriteLine($"o peso ideal é {pesoIdeal} kg");