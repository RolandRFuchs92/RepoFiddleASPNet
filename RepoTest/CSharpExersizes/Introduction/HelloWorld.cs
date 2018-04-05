using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.CSharpExersizes.Introduction
{
    public class HelloWorld: IReturnString
    {
        public void WriteTitle()
        {
            Console.Write("Title:");
            Console.WriteLine("Hello World");
        }

        public string GetProcedureValue()
        {
            return "Hello World";
        }
    }
}
