using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Repository
{
    public interface IBoatRepository
    {
        int AddBoat(BoatDataModel boat);
        string RentBoat(RentBoatModel rentBoatModel);
    }
}
