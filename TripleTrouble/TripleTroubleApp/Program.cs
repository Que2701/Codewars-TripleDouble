using System;
using System.Linq;


namespace TripleTroubleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TripleDouble(1112, 122));
        }
        public static int TripleDouble(long num1, long num2)
        {
            //code me ^^
            int numCount = 0;
            int checker1 = 0;
            int checker2 = 0;
            foreach (var outterItem in num1.ToString())
            {
                foreach (var innerItem in num1.ToString())
                {
                    if (outterItem == innerItem && numCount != 3)
                    {
                        numCount++;
                        if (numCount == 3)
                            checker1 = innerItem;
                    }
                    else if (numCount == 3)
                        break;
                    else
                        numCount = 0;
                }
            }

            int returnValue = numCount == 3 ? 1 : 0;
            numCount = 0;

            foreach (var outterItem in num2.ToString())
            {
                numCount = 0;
                foreach (var innerItem in num2.ToString())
                {
                    if (outterItem == innerItem && numCount != 2)
                    {
                        
                        if (innerItem == checker1)
                        {
                            numCount++;
                            checker2 = innerItem;
                        }
                    }
                    else if (numCount == 2)
                        break;
                    else
                        numCount = 0;
                }
            }

            returnValue = checker1 == checker2 ? 1 : 0;

            return returnValue;
        }

    }
}
