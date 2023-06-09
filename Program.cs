﻿using System;

namespace Internal {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("Para soma digite: S");
            Console.WriteLine("Para multiplicação digite: M");

            string? op = Console.ReadLine();
            string? opDef = op?.ToUpper() ?? string.Empty;

            if(opDef == "S") {
                Console.WriteLine("Digite um número:");
                double n1;
                bool success1 = double.TryParse(Console.ReadLine(), out n1);

                Console.WriteLine("Digite outro número:");
                double n2;
                bool success2 = double.TryParse(Console.ReadLine(), out n2);

                if (success1 && success2) {
                    double result = n1 + n2;
                    Console.WriteLine("Seu resultado é:");
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine("Entrada inválida");
                }
            }
            else if(opDef == "M") {
                Console.WriteLine("Digite um número:");
                double n1;
                bool success1 = double.TryParse(Console.ReadLine(), out n1);

                Console.WriteLine("Digite outro número:");
                double n2;
                bool success2 = double.TryParse(Console.ReadLine(), out n2);

                if (success1 && success2) {
                    double result = n1 * n2;
                    Console.WriteLine("Seu resultado é:");
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine("Entrada inválida");
                }
            }
        }
    }
}