using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtilioFinal.Models
{
    public class Seller
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double baseSalary { get; set; }

        
        public virtual ICollection<SalesRecord> Sales { get; set; }

        public virtual Departament Department { get; set; }

        public void AddSales(SalesRecord salesRecord) {

        }

        public void RemoveSales(SalesRecord salesRecord) {
            
        }

        public double TotalSales(DateTime initial, DateTime final) {

            return 0.0;
        }
    }
}
