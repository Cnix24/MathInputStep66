using System;

namespace MathInputStep66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            string multiplyInput = Console.ReadLine();
            int multiplyTotal = Convert.ToInt32(multiplyInput) * 50;
            Console.WriteLine("Wow! That number multiplied by 50 equals: " + multiplyTotal);
 
            Console.WriteLine("Give me another number! I need to do more math!");
            string additionInput = Console.ReadLine();
            int additionTotal = Convert.ToInt32(additionInput) + 25;
            Console.WriteLine("I cannot even believe this. That number added to 25 equals: " + additionTotal + ". So cool.");

            Console.WriteLine("I know I'm asking a lot, but now I wanna do division! Can we do division? Another number! Decimals are chill.");
            string divisionInput = Console.ReadLine();
            double divisionTotal = Convert.ToDouble(divisionInput) / 12.5;
            Console.WriteLine("You're not going to believe this. " + divisionInput + " divided by 12.5 equals: " +divisionTotal);

            Console.WriteLine("Let's try something a little different. Still mathy though so I'm gonna need another number.");
            string boolInput = Console.ReadLine();
            bool boolTotal = Convert.ToInt32(boolInput) >= 50;
            Console.WriteLine("Is " + boolInput + " greater than 50?: " + boolTotal +". I really wasn't sure until this moment!");

            Console.WriteLine("I PROMISE: this is the last one. Another number por favor.");
            string remainderInput = Console.ReadLine();
            double remainderTotal = Convert.ToDouble(remainderInput) % 7;
            Console.WriteLine("Does " + remainderInput + " have a remainder when divided by 7? Let's see the result: " + remainderTotal);
        }
    }
}
