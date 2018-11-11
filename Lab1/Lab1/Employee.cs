using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public abstract class Employee
    {
        public int Id;
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }

        public string GetFullName()
        {
            return this.FirstName+" "+this.LastName;
        }

        public bool IsActive()
        {
            return this.EndDate >= this.StartDate;
        }
    }
}
