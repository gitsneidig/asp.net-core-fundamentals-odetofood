using System;
using System.Collections.Generic;
using System.Text;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name="Scott's Pizza", Location="Missouri", Cuisine=CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Jeff's Indian Buffet", Location = "Missouri", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 3, Name = "Karen's Cantina", Location = "Missouri", Cuisine = CuisineType.Italian }
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
