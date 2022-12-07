using DroneController.DA.Models;
using DroneController.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DroneController.DL.Services
{
    public interface IDroneService
    {
        void AddOrUpdate(DroneModel entry);
        Task<IEnumerable<DroneModel>> GetAsync();
        Task<DroneModel> GetById(Guid id);
        void Remove(Guid id);
        IEnumerable<DroneModel> Where(Expression<Func<Drone, bool>> exp);

    }
}
