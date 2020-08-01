using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Models
{
    public class BoatDataModel
    {
        public int BoatId { get; set; }
        [Required]
        public string BoatName { get; set; }
        [Required]
        public int HourlyRate { get; set; }
    }
    public class RentBoatModel
    {
        [Required]
        public int BoatId { get; set; }
        [Required]
        public string CustName { get; set; }

    }
}
