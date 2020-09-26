using BusinessLogicInterface;
using DataAccessInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Logics
{
    public class TouristSpotLogic : ITouristSpotLogic
    {
        private readonly ITouristSpotRepository touristSpotsRepository;

        public TouristSpotLogic(ITouristSpotRepository touristSpotsRepository)
        {
            this.touristSpotsRepository = touristSpotsRepository;
        }
    }
}
