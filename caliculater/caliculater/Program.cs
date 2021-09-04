using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caliculater
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Calc();
                Console.WriteLine("do you want continue(Y/N)");
                string s =Console.ReadLine();
                
                if (s.ToUpper() == "N")
                    break;

            }

        }

        private static void Calc()
        {
            Console.WriteLine("Welcom to our caliculater");
            Console.WriteLine("press 1 for addition");
            Console.WriteLine("press 2 for substraction");
            Console.WriteLine("press 3 for multiplication");
            Console.WriteLine("press 4 for division");
            Console.WriteLine("press 5 for sqrt");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (option)
            {
                case 1:
                    {
                        result = addition(num1, num2);
                        break;
                    }
                case 2:
                    {
                        result = substraction(num1, num2);
                        break;
                    }
                case 3:
                    {
                        result = multiplication(num1, num2);
                        break;
                    }
                case 4:
                    {
                        if(num2==0)
                        {
                            Console.WriteLine("num2 can not be 0 for division, Please enter num2 again");
                            num2 = double.Parse(Console.ReadLine());
                        }
                        result = division(num1, num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("wrong optionferformed try again");
                        break;
                    }

            }
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("performed result is " + result);
            
        }

        public static Double addition(Double num1, Double num2)
            {
                Double result = num1 + num2;
                return result;
            }
            public static Double substraction(Double num1, Double num2)
            {
                Double result = num1 - num2;
                return result;
            }
            public static double multiplication(Double num1, Double num2)
            {
                Double result = num1 * num2;
                return result;
            }
            public static Double division(Double num1, Double num2)
            {
                Double result = num1 / num2;
                return result;
                
            }





        }

    public class Calculator
    {
        public void Calc()
        {
            Console.WriteLine("Calc is calculator class is called");
        }
    }
    }




         
