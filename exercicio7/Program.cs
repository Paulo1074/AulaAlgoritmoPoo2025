int[] vetor1 = new int[5], vetor2 = new int[10];
int pontos = 0, i, j;

Console.WriteLine("Digite os 5 números do gabarito:");
for (i = 0; i < 5; i++) vetor1[i] = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os 10 números da aposta:");
for (i = 0; i < 10; i++) vetor2[i] = int.Parse(Console.ReadLine());

for (i = 0; i < 10; i++)
    for (j = 0; j < 5; j++)
        if (vetor2[i] == vetor1[j]) pontos++;

Console.WriteLine($"O apostador fez {pontos} pontos");
