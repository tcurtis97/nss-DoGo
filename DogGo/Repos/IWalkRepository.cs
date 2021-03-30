using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetAll();
        public List<Walk> GetWalksByWalkerId(int walkerId);
    }
}
