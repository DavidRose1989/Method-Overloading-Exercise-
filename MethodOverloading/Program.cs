using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace MethodOverloading
{
    public class Program
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Add(decimal num1, decimal num2, decimal num3)
        { 
            Console.WriteLine(num1 + num2 + num3);
        }

        public static string Add(int num5, int num6, bool numtrue)
        {
            

            if(numtrue is true && (num5 + num6) != 1)
            {
               return ($" {num5 + num6} dollars");
            }
           else if (numtrue is true && (num5 + num6)  == 1)
            {
               return($"{num5 + num6} dollar");
            }
            else 
            { 
            return $"{num5+ num6}";
            }
        

        }
        
        static void Main()
        {
            Console.WriteLine(Add(0, 1, true));
        }

            
    }
}
