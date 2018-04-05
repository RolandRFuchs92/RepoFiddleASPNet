using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo;
using Repo.Model;

namespace RepoTest.Logic
{
    public class Using_Delegates : IReturnString
    {
        public string GetProcedureValue()
        {
            var delegateValue = "";
            var personFormatList = "";
            Func<List<PERSONCountry>, string> format1 = PersonListFormat1;
            Func<List<PERSONCountry>, string> format2 = PersonListFormat2;

            var lst = new FrontRepo().GetCountryList();

            //Write it out with inner void function to Access parent Variables
            Action<string> writeThat = (i) =>
            {
                delegateValue = "Wrote it like THAT:";
                delegateValue += format1(lst);
            };

            personFormatList = format1(lst);
            //Write it with delegate void to not access parent variables
            Action<string> writeThis = WriteItLikeThis;
            writeThis(personFormatList);
            writeThat(PersonListFormat1(lst));

            return delegateValue;
            
        }

        public List<PERSONCountry> PersonCountryList()
        {
            return new FrontRepo().GetCountryList().Take(5).ToList();
        }

        public static void WriteItLikeThis(string methodFunc)
        {
            Console.WriteLine("FORCE TO CONSOLE WINDOW");
            Console.WriteLine("Wrote it like THIS:");
            Console.WriteLine(methodFunc);
        }

        public static string PersonListFormat1(List<PERSONCountry> people)
        {
            string personList = "";

            foreach (var person in people)
            {
                personList += $"{person.PERSONCountryID}) {person.PERSONCountryName} with country code {person.PERSONCountryCode}\r\n";
            }
            return personList;
        }


        public static string PersonListFormat2(List<PERSONCountry> people)
        {
            string personList = "";

            foreach (var person in people)
            {
                personList += $"{person.PERSONCountryName} {person.PERSONCountryCode}\r\n";
            }

            return personList;
        }
    }
}
