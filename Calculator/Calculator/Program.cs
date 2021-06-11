using System;

namespace Calculator
{
    class SimpleCalculator
    {

        public double num1, num2;
        public void read()
        {
            Console.WriteLine("Enter two any numbers: ");
            Console.Write("Number1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        public  void SumParams(params double[] val) // Params Paramater  
        {
            double sum = 0;
            for (int i = 0; i < val.Length; i++)
            {
                sum += val[i];
            }
            Console.WriteLine("Result: {0}", sum);
        }
        public void SumAllNumbers()
        {
            double sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number:(Warning!!When you entered 0 result is calculate): ");
                int n;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n == 0)
                        break;
                    sum += n;
                }
            }
            Console.WriteLine("The sum is: " + sum);
        }
        public void add(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Result: ({0})+({1})={2}", num1, num2, sum);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void divide(double num1, double num2)
        {
            double divide = num1 / num2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Result: ({0})/({1})={2}", num1, num2, divide);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void multiply(double num1, double num2)
        {
            double multiply = num1 * num2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Result: ({0})*({1})={2}", num1, num2, multiply);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void subtract(double num1, double num2)
        {
            double difference = num1 - num2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Result: ({0})-({1})={2}", num1, num2, difference);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
    class Operations
    {
        public static void Main()
        {
            int choise;
            SimpleCalculator sc = new SimpleCalculator();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n 1-----> ADDITION");
                Console.WriteLine("\n 2-----> SUBTRACTION");
                Console.WriteLine("\n 3-----> MULTIPLICATION");
                Console.WriteLine("\n 4-----> DIVISION");
                Console.WriteLine("\n 5-----> EXIT");
                Console.WriteLine("\nEnter your choice: ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("[1]For two numbers");
                            Console.WriteLine("[2]Endless numbers");
                            int choise2 = Convert.ToInt32(Console.ReadLine());
                            if (choise2 == 1)
                            {
                                sc.read();
                                sc.SumParams(sc.num1,sc.num2);
                                break;

                            }
                            else if (choise2 == 2)
                            {
                                sc.SumAllNumbers();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect  choise!!!");
                                continue;
                            }
                        }
                        break;
                    case 2:
                        sc.read();
                        sc.subtract(sc.num1, sc.num2);
                        break;
                    case 3:
                        sc.read();
                        sc.multiply(sc.num1, sc.num2);
                        break;
                    case 4:
                        sc.read();
                        sc.divide(sc.num1, sc.num2);
                        break;
                    case 5:
                        Console.WriteLine("\nProgram Closed...Bye");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine(" Sorry !!! Wrong  choice.");
                        break;
                }
                Console.Write("\n Press ENTER to Continue. ");
                Console.ReadLine();
            }


        }
    }
}
