using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment.BoatModel
{
    public partial class BoatDetails
    {
        [Key]
        public int BoatId { get; set; }
        [StringLength(50)]
        public string BoatName { get; set; }
        public int HourlyRate { get; set; }

        [InverseProperty("Boat")]
        public virtual BoatCustomerRent BoatCustomerRent { get; set; }
    }
}
