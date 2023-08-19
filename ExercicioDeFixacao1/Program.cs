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
            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
          
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
