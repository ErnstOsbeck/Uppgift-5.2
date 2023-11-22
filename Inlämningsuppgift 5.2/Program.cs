using System;

namespace uppgift_5._2
{
    class program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            Random slump = new Random();
            tal[0] = slump.Next(1, 10);
            tal[1] = slump.Next(1, 10);
            Console.WriteLine("skriv in ett tal");
            tal[2] = int.Parse(Console.ReadLine());
            Console.Write(tal[0] + " " + tal[1] + " " + tal[2]);
            Console.Read();
        }
    }
}
