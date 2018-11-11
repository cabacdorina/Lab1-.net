using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   public  class Product
    {
       
       public int Id;
       public  String Name { get; set; }
       public String Description { get; set; }
       public DateTime StartDate { get; set; }
       public DateTime EndDate { get; set; }
       public double Price { get; set; }
       public double VAT { get; set; }   

       
        public bool IsValid()
        {
            if (this.StartDate > this.EndDate)
            {
                return false;
            }
            return true;
        }

        public void ComputeVat()
        {
            this.VAT = 0.24 * this.Price;
        }
       
        
    }
   
}



