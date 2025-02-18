double x1, x2, y1, y2, d, p1, p2;   
{ 
    {
        Console.Write("Digite a coordenada x1: ");
        x1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a coordenada y1: ");
        y1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a coordenada x2: ");
        x2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a coordenada y2: ");
        y2 = int.Parse(Console.ReadLine());

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"A distância entre os pontos ({x1}, {y1}) e ({x2}, {y2}) é: {distancia:F2}");
    }
}
