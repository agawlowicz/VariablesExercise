using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Amanda";
            int age = 20;
            char grade = 'A';
            bool amAdult = true;
            double moneyInBank = 99.87;
            decimal piEstimate = 3.14159M;

            Console.WriteLine($"My name is {name} and I am {age} years old. An estimate for pi is {piEstimate} and I earned a grade {grade} while in school. " +
                $"It is {amAdult} that I am an adult, and I have {moneyInBank} dollars in my bank account. I want to earn more money.");
        }
    }
}
