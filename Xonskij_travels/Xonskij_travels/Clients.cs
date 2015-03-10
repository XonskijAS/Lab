using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xonskij_travels
{
    class Clients:Travels
    {
        private string Name;
        private string Surname;
        private string Patronymic;
        private string Passport;

        public string GetName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public string GetSurname
        {
            get
            {
                return this.Surname;
            }
            set
            {
                this.Surname = value;
            }
        }
        public string GetPatronymic
        {
            get
            {
                return this.Patronymic;
            }
            set
            {
                this.Patronymic = value;
            }
        }
        public string GetPassport
        {
            get
            {
                return this.Passport;
            }
            set
            {
                this.Passport = value;
            }
        }
    }
}