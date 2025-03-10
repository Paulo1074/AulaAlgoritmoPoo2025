int[,] matriz = new int[4, 4];
int soma_superior = 0, soma_inferior = 0, i, j;

Console.WriteLine("Digite os elementos da matriz 4x4:");
for (i = 0; i < 4; i++)
    for (j = 0; j < 4; j++)
        matriz[i, j] = int.Parse(Console.ReadLine());

for (i = 0; i < 4; i++)
    for (j = 0; j < 4; j++)
        if (i < j) soma_superior += matriz[i, j];
        else if (i > j) soma_inferior += matriz[i, j];

Console.WriteLine($"Soma da parte superior: {soma_superior}");
Console.WriteLine($"Soma da parte inferior: {soma_inferior}");
