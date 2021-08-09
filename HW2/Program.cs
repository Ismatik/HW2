using System;

namespace HW2Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question2 
            // Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить
            // каждой переменной большее из этих значений, а если равны, то присвоить переменным
            // нулевые значения. Вывести новые значения переменных A и B.
            Console.WriteLine("Enter first number = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number = ");
            int b = int.Parse(Console.ReadLine());
            if(a == b)
            {
                a = b = 0;
            }   
            else
            {
                if(a>b)
                {
                    b = a;
                }
                else
                {
                    a = b;
                }
            }         
            Console.WriteLine($"New valuse of A and B are {a} , {b}");
            // Question 3
            Random random = new Random();
            double rand1 = random.Next(0 , 10000);
            double rand2 = random.Next(0 , 10000);
            double result;
            Console.WriteLine("Enter your sign: ");
            string sign = Console.ReadLine();
            switch(sign){
                case "+": result = rand1 + rand2; 
                Console.WriteLine($"Your result is {result}");
                break;
                case "-": result = rand1 - rand2;
                Console.WriteLine($"Your difference is {result}");
                break;
                case "*": result = rand1 * rand2;
                Console.WriteLine($"Your multiplication is {result}");
                break;
                case "/":
                string text = rand2 == 0 ? ("Division by 0, not acceptable") : ("Your division is " + (rand1 / rand2).ToString());
                Console.WriteLine(text);
                // case "/":try{
                //     result = rand1 / rand2;
                //     Console.WriteLine($"Your division is {result}");
                // }
                // catch(DivideByZeroException){
                //     Console.WriteLine("Division by zero");
                // }
                break;
            }
            // Question4
            Console.WriteLine("Enter number in range from 0 to 100");
            int num = int.Parse(Console.ReadLine());
            if(num >= 0 && num <= 14){
                Console.WriteLine("Number in the range [0,14]");
            }
            else if(num >= 15 && num <= 35)
            {
                Console.WriteLine("Number in the range [15,35]");
            }
            else if(num >= 36 && num <= 50)
            {
                Console.WriteLine("Number in the range [36,50]");
            }
            else if(num >= 51 && num <= 100)
            {
                Console.WriteLine("Number in the range [51, 100]");
            }
            else{Console.WriteLine("Your number not in the range [0,100]");}
        }
    }
}
