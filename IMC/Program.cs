using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;
            double IMC;

            Console.Write("Digite sua Altura(m): ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite seu Peso(kg): ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("\n");

            IMC = peso / (altura * altura);
            Console.WriteLine("Seu resultado de IMC é = {0} kg/m²", IMC);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();
        }
    }
}
