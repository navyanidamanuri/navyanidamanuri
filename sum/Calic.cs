using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace sum
{
     public static class Calic
    {
        //addition method with double numbers
        public static Double addition(Double a, Double b)
        {
           return a+b;
        }
        //addition method with array
        public static  Double addition(Double[] arr)
        {
           Double add = 0;
            for(int i=0;i<arr.Length;i++)
            {
                add += arr[i];
            }
            return add;
        }
        //substraction method with double numbers
        public static Double substraction(Double a, Double b)
        {
            
            return a-b;
        }
        //substraction  method with arrys
        public static Double substraction(Double[] arr)
        {
            Double sub = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sub -= arr[i];
            }
            return sub;
        }
        //multiplication
        public static double multiplication(Double[] arr)
        {
            Double mul = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                mul *= arr[i];
            }
            return mul;
        }
        //division
        public static Double division(Double a,Double b)
        {
            return a / b;

        }
     }

}

