using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o nível do professor (1, 2 ou 3):");
        int nivel = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o número de horas/aula trabalhadas:");
        int horasAula = Convert.ToInt32(Console.ReadLine());

        decimal valorHoraAula = 0;

        switch (nivel)
        {
            case 1:
                valorHoraAula = 12.00m;
                break;
            case 2:
                valorHoraAula = 17.00m;
                break;
            case 3:
                valorHoraAula = 25.00m;
                break;
            default:
                Console.WriteLine("Nível inválido!");
                return;
        }

        decimal salario = valorHoraAula * horasAula;

        Console.WriteLine("Salário do professor: R$" + salario);
    }
}
