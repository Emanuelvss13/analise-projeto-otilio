using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtilioFinal.Models
{
    public class Departament
    {
        [Key]
        public int id { get; set; }
        private string name { get; set; }

        public ICollection<Seller> Sellers { get; set; }

        public void AddSeller(Seller seller) {

        }

        public double TotalSales(DateTime initial, DateTime final) {
            return 0.0;
        }
    }
}
