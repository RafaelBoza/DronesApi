using DroneController.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DroneController.DL.Services
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAsync();

        Task<T> GetById(Guid id);

        IEnumerable<T> Where(Expression<Func<T, bool>> exp);

        void AddOrUpdate(T entry);

        void Remove(Guid id);

    }
}
