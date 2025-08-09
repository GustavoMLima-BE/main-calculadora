using System;

namespace ProgramaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float i = 0;
            float input;
            while (i == 0)
            {
                Console.WriteLine("Digite o calculo desejado: \n 1 - Soma \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão \n 5 - Sair");
                input = float.Parse(Console.ReadLine());
                {
                    if (input == 1)
                    {
                        Console.WriteLine("Digite o primeiro numero:");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero:");
                        float num2 = float.Parse(Console.ReadLine());
                        float sum = num1 + num2;
                        Console.WriteLine("A soma é: " + sum);
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Digite o primeiro numero:");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero:");
                        float num2 = float.Parse(Console.ReadLine());
                        float difference = num1 - num2;
                        Console.WriteLine("A subtração é: " + difference);
                    }
                    else if (input == 3)
                    {
                        Console.WriteLine("Digite o primeiro numero:");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero:");
                        float num2 = float.Parse(Console.ReadLine());
                        float product = num1 * num2;
                        Console.WriteLine("A multiplicação é: " + product);
                    }
                    else if (input == 4)
                    {
                        Console.WriteLine("Digite o primeiro numero:");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero:");
                        float num2 = float.Parse(Console.ReadLine());
                        float sum = num1 / num2;
                        Console.WriteLine("A divisão é: " + sum);
                    }
                    else
                    {
                        Console.WriteLine("Saindo do programa...");
                        i++;
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
