using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment.BoatModel
{
    public partial class BoatCustomerRent
    {
        [Key]
        public int BoatId { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        public bool IsRented { get; set; }

        [ForeignKey(nameof(BoatId))]
        [InverseProperty(nameof(BoatDetails.BoatCustomerRent))]
        public virtual BoatDetails Boat { get; set; }
    }
}
