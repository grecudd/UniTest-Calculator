using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            int a;
            int b;
            char ch;

            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose operator (+, -, *, /) : ");
            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Result : " + getResult(a, b, ch));
        }

        public static int getResult(int a, int b, char ch)
        {
            try
            {
                int result = 0;
                switch (ch)
                {
                    case '+': result = a + b; break;
                    case '-': result = a - b; break;
                    case '*': result = a * b; break;
                    case '/': result = a / b; break;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
