using System;

namespace VerificadorPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Número Primo");

            Console.Write("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            bool ehPrimo = VerificarPrimo(numero);

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }

            // Aguarda a tecla Enter para fechar a aplicação
            Console.ReadLine();
        }

        static bool VerificarPrimo(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
