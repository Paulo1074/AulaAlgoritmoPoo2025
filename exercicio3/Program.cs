int dia_semana;

Console.WriteLine("Digite um numero de 1 ate 7");
dia_semana = int.Parse(Console.ReadLine());   

if (dia_semana == 1)
{
    Console.WriteLine("Domingo");
}
else if (dia_semana == 2)
{
    Console.WriteLine("Segunda");
}
else if (dia_semana == 3)
{
    Console.WriteLine("Terça");
}
else if (dia_semana == 4)
{
    Console.WriteLine("Quarta");
  
}
else if (dia_semana == 5)
{
    Console.WriteLine("Quinta");
}
else if (dia_semana == 6)
{
    Console.WriteLine("Sexta");
}
else if (dia_semana == 7)
{
    Console.WriteLine("Sabado");
}
else
{
    Console.WriteLine("ERRO");
}
