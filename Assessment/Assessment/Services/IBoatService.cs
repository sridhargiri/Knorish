﻿using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public interface IBoatService
    {
        int AddBoat(BoatDataModel boatModel);
        string RentBoat(RentBoatModel rentBoatModel);
    }
}
