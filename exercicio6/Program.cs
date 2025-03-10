double s = 1, numerador = 3, denominador = 2;

while (numerador <= 99)
{
    s += numerador / denominador;
    numerador += 2;
    denominador++;
}

Console.WriteLine($"Valor de S: {s:F2}");
