int venda_media;
double preco_atual;

Console.WriteLine("Digite um numero");
venda_media = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro numero");
preco_atual = double.Parse(Console.ReadLine());

if (venda_media < 500 && preco_atual < 30.00)
{
    preco_atual *= 1.10;
}
else if (venda_media >= 500 && preco_atual >= 30.00)
{
    preco_atual *= 0.80;
}

Console.WriteLine($"{preco_atual:F2}");
