using Assessment.Models;
using Assessment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Services
{
    public class BoatService : IBoatService
    {
        private readonly IBoatRepository _boatRepository;
        public BoatService(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }
        public int AddBoat(BoatDataModel boatModel)
        {

            return _boatRepository.AddBoat(boatModel);
        }
        public string RentBoat(RentBoatModel rentBoatModel)
        {

            return _boatRepository.RentBoat(rentBoatModel);
        }
    }
}
