using DroneController.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneController.DL.Repositories
{
    public interface ILoadRepository 
    {
        IQueryable<Drone> Get();
        Load GetById(int id);
        Task<Load> Create(Load load);
        Task<bool> Delete(Load load);
        Task<bool> Update(Load load);
    }
}
