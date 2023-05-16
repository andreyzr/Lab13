using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Man
    {
        string name;
        int birthdayDate;
        string city;

        int BirthdayDate
        {
            get 
            { 
                return birthdayDate; 
            }
            set
            {
                if (value > 2023)
                    birthdayDate = 2021;
                else if (value > 1900)
                    birthdayDate = 1900;
                else
                    birthdayDate = value;
            }
        }
        public Man(string name, int birthdayDate, string city)
        {
            this.name = name;
            this.BirthdayDate = birthdayDate;
            this.city = city;
        }
        public string Print()
        {
            return $"{name} {birthdayDate} {city}";
        }
    }
}
