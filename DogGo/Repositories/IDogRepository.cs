using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using DogGo.Models;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        void AddDog(Dog dog);
        void DeleteDog(int dogId);
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        void UpdateDog(Dog dog);
        
        //Method for model View
        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}
