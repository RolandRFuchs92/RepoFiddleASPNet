using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.CSharpExersizes.Introduction
{
    public class MultipleOperations:IReturnString
    {
        public void WriteTitle()
        {
            Console.Write("Title: ");
            Console.WriteLine("Multiple Operations");
        }

        public string GetProcedureValue()
        {
            return $"{Operation1()}\r\n{Operation2()}\r\n{Operation3()}\r\n{Operation4()}"; ;
        }

        private int Operation1()
        {
            return -6 + 3 * 5;
        }

        private int Operation2()
        {
            return (13 - 2) * 7;
        }

        private int Operation3()
        {
            return (5 + -2) * (20 / 10);
        }

        private int Operation4()
        {
            return (12 + 4) / (5 / 4);
        }
    }
}
