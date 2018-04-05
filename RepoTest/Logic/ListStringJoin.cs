using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo;

namespace RepoTest.Logic
{
    public class ListStringJoin : IReturnString
    {
        public string GetProcedureValue()
        {
             return (string.Join("\r\n", new FrontRepo().GetCountryList().Select(i => i.PERSONCountryName)));
        }
    }
}
