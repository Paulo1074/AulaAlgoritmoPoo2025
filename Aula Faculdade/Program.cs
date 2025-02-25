using System;
class program
{
    static void Main()
    { 
    Console.WriteLine("Digite o número de horas trabalhadas: ");
    double horastrabalhadas = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o salário por  hora: ");
    double salárioporhora = Convert.ToDouble(Console.ReadLine());

    int horasmensais = 40 * 4; // 160 horas mês
        double salarioTotal = 0;

        if (horastrabalhadas > horasmensais)
    {
        double horasextras = horastrabalhadas - horasmensais;
        double valorHoraExtra = salárioporhora * 1.5; //50% a mais

        salarioTotal = (horasmensais * salárioporhora) + (horasextras * valorHoraExtra);
    }
    else
    {
        salarioTotal = horastrabalhadas * salárioporhora;

    }
        Console.WriteLine($"O salário total do funcionário é: R$ {salarioTotal:F2}");
    }
}
