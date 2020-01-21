using System;

namespace SelectionStatements
{
    class Switch
    {
        static void Main(string[] args)
        {

            //SWITCH EXERCISES

            var name = Console.ReadLine();
            switch(name)
            {
                case "michael":
                    Console.WriteLine("Sup big mike!");
                    break;

                default:
                    Console.WriteLine($"Sup {name}");
                    break;
            }
        }
    }
}
