using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.BoatModel;


namespace Assessment.Repository
{
    public class BoatRepository : IBoatRepository
    {
        public int AddBoat(BoatDataModel boat)
        {
            int boatid = 0;
            try
            {
                using (var context = new BoatDataContext())
                {
                    BoatDetails b = new BoatDetails();
                    b.BoatId = boat.BoatId;
                    b.BoatName = boat.BoatName;
                    b.HourlyRate = boat.HourlyRate;
                    context.BoatDetails.Add(b);
                    context.SaveChanges();
                    boatid = b.BoatId;
                }
                return boatid;
            }
            catch
            {

                throw;
            }
        }
        public string RentBoat(RentBoatModel rentBoatModel)
        {
            string message = "";
            try
            {
                using (var context = new BoatDataContext())
                {
                    var found = context.BoatCustomerRent.Where(x => x.BoatId == rentBoatModel.BoatId
                    && x.CustomerName == rentBoatModel.CustName && x.IsRented).FirstOrDefault();
                    if (found != null)
                    {
                        message = "This boat already remted out";
                    }
                    else
                    {
                        BoatCustomerRent rent = new BoatCustomerRent();
                        rent.IsRented = true;
                        rent.CustomerName = rentBoatModel.CustName;
                        rent.BoatId = rentBoatModel.BoatId;
                        context.BoatCustomerRent.Add(rent);
                        context.SaveChanges();
                        message = "boat remted successfully!";
                    }
                }
                return message;
            }
            catch
            {

                throw;
            }
        }
    }
}
