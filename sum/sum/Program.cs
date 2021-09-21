using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to our caliculater");
            Console.WriteLine("press 1 for addition");
            Console.WriteLine("press 2 for substraction");
            Console.WriteLine("press 3 for multiplication");
            Console.WriteLine("press 4 for division");
            int option = Convert.ToInt32(Console.ReadLine());
            Double result = 0;
            double a = 0;
            double b = 0;
            Double[] arr = new Double[] { };
              switch (option)
            {
               case 1:
               case 2:
                    {
                        Console.WriteLine("press 1 for array");
                        Console.WriteLine("press 2 for two numbers");
                        int op = Convert.ToInt32(Console.ReadLine());
                        
                        switch (op)
                        {
                           case 1: 
                              arr=  GetArray();
                                break;
                            case 2:
                                
                                GetDoubleValues(out a,out b);
                                break;

                        }
                        if(arr.Length>0)
                        {
                            if(option==1)
                            {
                                result= Calic.addition(arr);
                                 }
                            else
                            {
                                result = Calic.substraction(arr);
                               
                            }
                            
                        }
                        else
                        {
                            if (option == 1)
                                result = Calic.addition(a, b);
                            else
                            {
                                result = Calic.substraction(a, b);
                            }
                        }

                        break;
                    }
               
               
                case 3:
                    {
                       arr= GetArray();
                        result = Calic.multiplication(arr);
                        break;
                    }

                case 4:
                    {
                        GetDoubleValues(out a, out b);
                         try
                        {
                            result = Math.Round(Calic.division(a, b));
                            
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                         break;
                    }
                default:
                    {
                        Console.WriteLine("wrong optionferformed try again");
                        break;
                    }

            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static Double[]  GetArray()
        {
            Console.WriteLine("arry size");
            int size = int.Parse(Console.ReadLine());
            double[] arr = new double[size];
            Console.WriteLine("arry og eliments");
            for (int i = 0; i < size; i++)
            {
                arr[i] = double.Parse(Console.ReadLine().Replace("(", "").Replace(")", "").Replace("--", ""), CultureInfo.InvariantCulture);

            }
            return  arr;
        }
        public static void GetDoubleValues(out double a,out double b)
        {
            Console.WriteLine("Enter two doble Values");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
        }
    }
}
