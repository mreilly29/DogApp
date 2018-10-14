using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogApp.Models;

namespace DogApp
{
    public class DogRepository : IDogRepository
    {
        //fields
        List<Dog> allDogs = new List<Dog>()
        {
            new Dog() { Id = 1, Name = "Moana", Url = "Moana.jpg"},
            new Dog() { Id = 2, Name = "Dingle", Url = "Dingle.jpg"},
            new Dog() { Id = 3, Name = "Spot", Url = "Spot.jpg"}
        };
        
        //methods
        public List<Dog> GetAll()
        {         
            return allDogs;
        }
        
        public Dog FindById(int id)
        {
            return allDogs[id - 1];
        }  
       
    }
}
