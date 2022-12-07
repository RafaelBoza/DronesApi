using DroneController.DA.Models;
using DroneController.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneController.DL.Repositories
{
    interface IDroneRepository
    {
        IQueryable<Drone> Get();
        Drone GetById(int id);
        Task<Drone> Create(Drone user, string password);
        Task<bool> Delete(Drone user);
        Task<bool> Update(Drone user);
        Task<IEnumerable<Drone>> GetAvallaibles();

    }
}
