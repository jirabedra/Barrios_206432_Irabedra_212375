using DataAccessInterface;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class TouristSpotRepository : ITouristSpotRepository
    {
        private readonly DbSet<TouristSpot> touristSpots;
        private readonly DbContext myContext;

        public TouristSpotRepository(DbContext context)
        {
            this.myContext = context;
            this.touristSpots = context.Set<TouristSpot>();
        }
    }
}
