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

            name = Console.ReadLine();
            rooms = int.Parse(Console.ReadLine());
            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');

            lastName = vet[0];
            age = int.Parse(vet[1]);
            height = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.ReadLine();
            Console.WriteLine("Entre com o seu nome completo:");
            Console.WriteLine(name);
            
            Console.WriteLine("Quantos quartos tem na sua casa?");
            Console.WriteLine(rooms);
            
            Console.WriteLine("Entre com o preço de um produto:");
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.WriteLine("Entre com seu último nome, idade e altura");
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
