using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.CSharpExersizes.Introduction
{
    public class MultiplyUserVariables : IReturnString
    {
        public void WriteTitle()
        {
            Console.Write("Title: ");
            Console.WriteLine("Multiply User Variables\r\n");
        }

        public string GetProcedureValue()
        {
            Console.WriteLine("Give us a number!");
            
            Console.WriteLine("Give us another number!");
            var b = Console.ReadKey();

            return Multiply(a,b);
        }

        private int GetUserInt()
        {
            var userInput = "";
            do
            {
                userInput = Console.ReadKey().ToString();



            } while (true);

            return 1;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
