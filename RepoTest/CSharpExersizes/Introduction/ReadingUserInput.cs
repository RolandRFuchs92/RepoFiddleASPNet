using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoTest.CSharpExersizes.Introduction
{
    public class ReadingUserInput : IReturnString
    {
        public void WriteTitle()
        {
            Console.Write("Title:");
            Console.WriteLine("Read User Input");
        }

        public string GetProcedureValue()
        {
            Console.WriteLine("Whats your favorite colour?");
            var userInput = Console.ReadLine();
            return "Mine too!";
        }
    }
}
