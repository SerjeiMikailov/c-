using System;

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
                int n1;
                bool success1 = int.TryParse(Console.ReadLine(), out n1);

                Console.WriteLine("Digite outro número:");
                int n2;
                bool success2 = int.TryParse(Console.ReadLine(), out n2);

                if (success1 && success2) {
                    int result = n1 + n2;
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine("Entrada inválida");
                }
            }
            else if(opDef == "M") {
                Console.WriteLine("Digite um número:");
                int n1;
                bool success1 = int.TryParse(Console.ReadLine(), out n1);

                Console.WriteLine("Digite outro número:");
                int n2;
                bool success2 = int.TryParse(Console.ReadLine(), out n2);

                if (success1 && success2) {
                    int result = n1 * n2;
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine("Entrada inválida");
                }
            }
        }
    }
}