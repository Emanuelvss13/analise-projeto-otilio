using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OtilioFinal.Models
{
    public class SalesRecord
    {
        [Key]
        public int id { get; set; }

        private DateTime date { get; set; }

        private double amount { get; set; }

        private SaleRecordStatus status { get; set; }
    }
}
