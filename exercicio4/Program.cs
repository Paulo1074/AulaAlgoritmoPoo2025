double horas_trabalhadas, salario_por_hora, total;

Console.WriteLine("Digite as horas trabalhadas no mês:");
horas_trabalhadas = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário por hora:");
salario_por_hora = double.Parse(Console.ReadLine());

total = horas_trabalhadas <= 160 ? horas_trabalhadas * salario_por_hora : (160 * salario_por_hora) + ((horas_trabalhadas - 160) * salario_por_hora * 1.5);

Console.WriteLine($"Salário total: {total:F2}");
