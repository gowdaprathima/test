using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo.Interfaces;

namespace Demo.Classes
{
    public class CalculateAge : ICalculateAge
    {
        public int age { get; set; }
        public int days { get; set; }
        DOB dob = new DOB();

        public DOB Calcualteage(DateTime dateDOB)
        {
            int age;
            dob.age = DateTime.Now.Year - dateDOB.Year;

            DateTime today = DateTime.Today;
            DateTime next = dateDOB.AddYears(DateTime.Now.Year - dateDOB.Year);

            if (next < today)
                next = next.AddYears(1);
            dob.days = (next - today).Days;

            return dob;
        }
    }

    public class DOB
    {
        public int age { get; set; }
        public int days { get; set; }
    }
}