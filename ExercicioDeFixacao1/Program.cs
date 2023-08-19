using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int rooms;
            double price;

            string lastName;
            int age;
            double height;

            Console.WriteLine("Entre com o seu nome completo:");
            name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            rooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');

            lastName = vet[0];
            age = int.Parse(vet[1]);
            height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.ReadLine();
            Console.WriteLine("O seu nome é " + name);
            Console.WriteLine("Sua casa tem " + rooms + " quarto(s)");
            Console.WriteLine("O preço da última coisa que comprou foi de R$ " + price.ToString("F2", CultureInfo.InvariantCulture));
          
            Console.WriteLine("o Sr(a). " + lastName);
            Console.WriteLine("tem " + age + " anos de idade");
            Console.WriteLine("e possui " + height.ToString("F2", CultureInfo.InvariantCulture) + " metros de altura");

            Console.ReadLine();
        }
    }
}
