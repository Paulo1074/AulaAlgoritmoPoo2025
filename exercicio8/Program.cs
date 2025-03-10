int[] vetor = new int[20], vetor_compactado;
int n, qtd = 0, i, index;

Console.WriteLine("Digite 20 numeros:");
for (i = 0; i < 20; i++) vetor[i] = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de N:");
n = int.Parse(Console.ReadLine());

for (i = 0; i < 20; i++)
    if (vetor[i] > n) qtd++;

vetor_compactado = new int[qtd];
index = 0;

for (i = 0; i < 20; i++)
    if (vetor[i] > n) vetor_compactado[index++] = vetor[i];

Console.WriteLine("Vetor compactado:");
foreach (int valor in vetor_compactado) Console.Write(valor + " ");
Console.WriteLine();
