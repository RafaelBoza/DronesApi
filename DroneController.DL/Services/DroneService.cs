using AutoMapper;
using DroneController.DA.Models;
using DroneController.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DroneController.DL.Services
{
    public class DroneService : IDroneService
    {
        private readonly IBaseService<Drone> _service;
        private readonly IMapper _mapper;


        public DroneService(IBaseService<Drone> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DroneModel>> GetAsync()
        {
            var result = await _service.GetAsync();
            return result.Select(t => _mapper.Map<Drone, DroneModel>(t));
        }

        public async Task<DroneModel> GetById(Guid id)
        {
            return _mapper.Map<Drone, DroneModel>(await _service.GetById(id));
        }

        public IEnumerable<DroneModel> Where(Expression<Func<Drone, bool>> exp)
        {
            var whereResult = _service.Where(exp).ToList();
            return _mapper.Map<List<Drone>, List<DroneModel>>(whereResult).AsEnumerable();
        }

        public void AddOrUpdate(DroneModel entry)
        {
            _service.AddOrUpdate(_mapper.Map<DroneModel, Drone>(entry));
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

    }
}
