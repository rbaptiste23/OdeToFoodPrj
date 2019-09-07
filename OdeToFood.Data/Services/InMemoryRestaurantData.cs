using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
      

        public InMemoryRestaurantData()
            {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant { Id = 1, Name="Scott's Pizza", Cuisine  = CusineType.Italian },
                    new Restaurant { Id = 1, Name="Scott's Pizza", Cuisine  = CusineType.Italian},
                    new Restaurant { Id = 1, Name="Scott's Pizza", Cuisine  = CusineType.Italian }
                };
                
                    
            }

        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }


    }
    
}
