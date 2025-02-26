using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Responda com 'sim' ou 'não' às perguntas a seguir.");

        Console.Write("O animal é um mamífero? ");
        string mamifero = Console.ReadLine().ToLower();

        if (mamifero == "sim")
        {
            Console.Write("É quadrúpede? ");
            string quadrupede = Console.ReadLine().ToLower();

            if (quadrupede == "sim")
            {
                Console.Write("É carnívoro? ");
                string carnivoro = Console.ReadLine().ToLower();

                if (carnivoro == "sim")
                {
                    Console.WriteLine("O animal escolhido foi o leão.");
                }
                else
                {
                    Console.Write("É herbívoro? ");
                    string herbivoro = Console.ReadLine().ToLower();

                    if (herbivoro == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o cavalo.");
                    }
                }
            }
            else
            {
                Console.Write("É bípede? ");
                string bipede = Console.ReadLine().ToLower();

                if (bipede == "sim")
                {
                    Console.Write("É onívoro? ");
                    string onivoro = Console.ReadLine().ToLower();

                    if (onivoro == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o homem.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi o macaco.");
                    }
                }
                else
                {
                    Console.WriteLine("O animal escolhido foi o morcego.");
                }
            }
        }
        else
        {
            Console.Write("O animal é uma ave? ");
            string ave = Console.ReadLine().ToLower();

            if (ave == "sim")
            {
                Console.Write("É uma ave que não voa? ");
                string naoVoa = Console.ReadLine().ToLower();

                if (naoVoa == "sim")
                {
                    Console.Write("Vive na água? ");
                    string viveNaAgua = Console.ReadLine().ToLower();

                    if (viveNaAgua == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o pinguim.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi o avestruz.");
                    }
                }
                else
                {
                    Console.Write("É uma ave de rapina? ");
                    string rapina = Console.ReadLine().ToLower();

                    if (rapina == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi a águia.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi o pato.");
                    }
                }
            }
            else
            {
                Console.WriteLine("O animal escolhido foi a baleia.");
            }
        }
    }
}
