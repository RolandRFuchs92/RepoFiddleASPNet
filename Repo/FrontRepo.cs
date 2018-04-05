using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Repo.Context;
using Repo.Model;

namespace Repo
{
    public class FrontRepo
    {
        public List<PERSONCountry> GetCountryList()
        {
            var people = new List<PERSONCountry>();

            using (var db = new LearnDB())
            {
                people = db.PERSONCountries.ToList();
            }

            return people;
        }
    }
}
