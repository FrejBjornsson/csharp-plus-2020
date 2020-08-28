using System;

namespace Session02Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in tre värden, separerat med kommatecken");
            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var number in inputArray)
            {
                Console.WriteLine("Värdet är" + number);
            }
        }
    }
}
