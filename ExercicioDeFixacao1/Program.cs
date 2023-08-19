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
            height = double.Parse(vet[2]);

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
