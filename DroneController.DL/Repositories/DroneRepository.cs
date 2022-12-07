using DroneController.DA.Models;
using DroneController.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneController.DL.Repositories
{
    public class DroneRepository : IDroneRepository
    {    
        Task<Drone> IDroneRepository.Create(Drone user, string password)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDroneRepository.Delete(Drone user)
        {
            throw new NotImplementedException();
        }

        Task<bool> IDroneRepository.Update(Drone user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Drone>> GetAvallaibles()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Drone> Get()
        {
            throw new NotImplementedException();
        }

        public Drone GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
