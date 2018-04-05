using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.CSharpExersizes.Introduction
{
    public class SumOfTwoNumbers: IReturnString
    {
        public void WriteTitle()
        {
            Console.Write("Title:");
            Console.WriteLine("Sum of 2 Numbers");
        }

        public string GetProcedureValue()
        {
            return Sum(12, 13).ToString();
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
