Console.WriteLine("Digite um numero A:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero B:");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero C:");
int n3 = int.Parse(Console.ReadLine());

int R = n1 + n2;
int SomaR = R * R;

int S = n2 + n3;
int SomaS = S * S;

int SomaRS = (SomaR + SomaS) /2;
Console.WriteLine(SomaRS);

