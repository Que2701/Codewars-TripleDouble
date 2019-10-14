using System;
using System.Linq;


namespace TripleTroubleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleDouble(357377966, 683260056));
        }
        public static int TripleDouble(long num1, long num2)
        {
            //code me ^^
            long triple = 0, trouble = 0;

            for (int i = 0; i < num1.ToString().Length - 3; i++)
            {
                if (triple > 0) break;
                triple = num1.ToString()[i] == num1.ToString()[i + 1] && num1.ToString()[i] == num1.ToString()[i + 2] ?
                    long.Parse(char.ToString(num1.ToString()[i])) : 0;
            }

            for (int i = 0; i < num2.ToString().Length - 1; i++)
            {
                if (trouble > 0) break;
                trouble = num2.ToString()[i] == num2.ToString()[i + 1] && long.Parse(char.ToString(num2.ToString()[i])) == triple ?
                    1 : 0;
            }

            return (int)trouble;
        }

    }
}
