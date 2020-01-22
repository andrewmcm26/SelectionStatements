using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
       // {// IF-ELSE EXERCISE
         //var favNum = 1;

            //Console.WriteLine("Try to guess my favorite number.");
            //var guess = int.Parse(Console.ReadLine());

            //do
            //{
            //    if (guess < favNum)
            //    {
            //        Console.WriteLine("Too low");
            //        Console.WriteLine("Would you like to guess again?");
            //        var guessAgain = Console.ReadLine();
            //        if (guessAgain == "yes")
            //        {
            //            Console.WriteLine("Okay take another shot");
            //            guess = int.Parse(Console.ReadLine());
            //            if (guess == 1)
            //            {
            //                Console.WriteLine("booyah!");
            //            }
            //        }
            //        else
            //            guess = 1;
            //    }
            //    else if (guess > favNum)
            //    {
            //        Console.WriteLine("Too high");
            //        Console.WriteLine("Would you like to guess again?");
            //            var guessAgain = Console.ReadLine();
            //        if (guessAgain == "yes")
            //        {
            //            Console.WriteLine("Okay take another shot");
            //            guess = int.Parse(Console.ReadLine());
            //            if(guess == 1)
            //            {
            //                Console.WriteLine("booyah!");
            //            }
            //        }
            //        else
            //            guess = 1;
            //    }

            //    else if(guess == 1)
            //    {
            //        Console.WriteLine("booyah!");
            //    }
            //}
            //while (guess != favNum);



       // }


            //SWITCH EXERCISES
            //Console.WriteLine("Who goes there?");
            //var name = Console.ReadLine();
            //switch (name)
            //{
            //    case "michael":
            //        Console.WriteLine("Sup big mike!");
            //        break;

            //    default:
            //        Console.WriteLine($"Sup {name}");

            //        break;
            //}

            //Console.WriteLine("enter your favorite school subject");

            //var subject = Console.ReadLine();
            //switch(subject)
            //{
            //    case "math":
            //        Console.WriteLine("that's my favorite subject too");
            //        break;
            //    default:
            //        Console.WriteLine("that's not my favorite subject");
            //        break;

            //}


        {//SyntaxSugar Exercise

            //var answer = 9;
            ////string response;

            //var response = answer < 9 ? $"{answer} is less than nine" : answer > 9 ? $"{answer} is greater than nine" : $"{answer} is equal to nine";
            //Console.WriteLine(response);
            //if (answer < 9)
            //{

            //    // response = answer + " is less than nine";
            //}


            {//foreach
                //sum the items in an array
                int sum = 0;
                var array = new int[] {1,2,3,4 };
                foreach(var num in array)
                {
                    sum += num;
                    
                }
                Console.WriteLine(sum);

            }

        }
    }
}

