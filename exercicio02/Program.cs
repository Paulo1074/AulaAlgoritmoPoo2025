double calculo = 0;
Console.WriteLine("Digite M se for masculino F se for feminino");
string sexo = Console.ReadLine().ToLower();
Console.WriteLine("Digite sua altura");
double alt = double.Parse(Console.ReadLine());

if (sexo == "m")
{
    calculo = (72.2 * alt) - 58;
}
else if (sexo == "f")
{
    calculo = (62.1 * alt) - 44.7;
}
else
{
    Console.WriteLine("erro");
}

Console.WriteLine($"O seu imc é {calculo}");