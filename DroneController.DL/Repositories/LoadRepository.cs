using DroneController.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneController.DL.Repositories
{
    public class LoadRepository : ILoadRepository
    {
        public Task<Load> Create(Load load)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Load load)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Drone> Get()
        {
            throw new NotImplementedException();
        }

        public Load GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Load load)
        {
            throw new NotImplementedException();
        }
    }
}
