using System;

namespace SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine(CalcSqrt(b));
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch (Exception  ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        public static double CalcSqrt(int a)
        {       
            if (a <= 0)
            {
                throw new ArgumentException("Invalid number");
            }

             double result = Math.Sqrt(a);
             return result;
        }
    }
}
