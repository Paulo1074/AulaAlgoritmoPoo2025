double[] notas = new double[7];
double soma_notas = 0, maior, menor;
int i;

Console.WriteLine("Digite as 7 notas dos juízes:");
for (i = 0; i < 7; i++) notas[i] = double.Parse(Console.ReadLine());

maior = menor = notas[0];

for (i = 1; i < 7; i++)
{
    if (notas[i] > maior) maior = notas[i];
    if (notas[i] < menor) menor = notas[i];
}

for (i = 0; i < 7; i++)
    if (notas[i] != maior && notas[i] != menor) soma_notas += notas[i];

Console.WriteLine($"Nota final do atleta: {soma_notas:F2}");
