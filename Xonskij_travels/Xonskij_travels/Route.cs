using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xonskij_travels
{
    class Route: Travels
    {
        private string DepartureDate;
        private int DaysOfStay;

        public string GetDepartureDate
        {
            get
            {
                return this.DepartureDate;
            }
            set
            {
                this.DepartureDate = value;
            }
        }
        public int GetDaysOfStay
        {
            get
            {
                return this.DaysOfStay;
            }
            set
            {
                this.DaysOfStay = value;
            }
        }
    
    }
}
