using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.CSharpExersizes.Introduction
{
    public class DivisionOfTwoNumbers:IReturnString
    {
        public void WriteTitle()
        {
            Console.Write("Title: ");
            Console.WriteLine("Division of 2 Numbers");
        }

        public string GetProcedureValue()
        {
            return Divide(24,5).ToString();
        }

        private int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
