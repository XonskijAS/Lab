using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xonskij_travels
{
    class Сountrys:Travels
    {
        private string CountryName;

        public string GetCountry
        {
            get
            {
                return this.CountryName;
            }
            set
            {
                this.CountryName = value;
            }
        }
    }
}
