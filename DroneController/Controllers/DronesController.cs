using AutoMapper;
using DroneController.API.Models.Drones;
using DroneController.DL.Infrastructure.ErrorHandler;
using DroneController.DL.Models;
using DroneController.DL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DroneController.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DronesController : ControllerBase
    {
        private readonly IDroneService _service;
        private readonly IErrorHandler _errorHandler;

        public DronesController(IDroneService service, IMapper mapper, IErrorHandler errorHandler)
        {
            _service = service;
            _errorHandler = errorHandler;
        }


        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<DroneModel>> Get()
        {
            return await _service.GetAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<DroneModel> Get([Required] Guid id)
        {
            return await _service.GetById(id);
        }

        [HttpGet("{fieldLabel}/{fieldValue}")]
        public List<DroneModel> Where(string fieldLabel, string fieldValue)
        {

            return
                _service.Where(
                    entity => (string)entity.GetType().GetProperty(fieldLabel).GetValue(entity, null) == fieldValue).ToList();

        }

        [HttpGet("where/criterias/{criteriasString}")]
        public List<DroneModel> Where(string criteriasString)
        {

            var criteriasModel = JsonConvert.DeserializeObject<WhereRequestModel>(criteriasString);
            var whereResult = _service.GetAsync().Result;
            whereResult = criteriasModel.Criterias.Aggregate(whereResult, (current, attribute) => current.Where(entity => (string)entity.GetType().GetProperty(attribute.Key).GetValue(entity, null) == attribute.Value).AsEnumerable());
            return whereResult.ToList();
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] DroneModel entity)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpRequestException(string.Format(_errorHandler.GetMessage(ErrorMessagesEnum.ModelValidation), "", ModelState.Values.First().Errors.First().ErrorMessage));
            }

            _service.AddOrUpdate(entity);
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete([Required] Guid id)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpRequestException(string.Format(_errorHandler.GetMessage(ErrorMessagesEnum.ModelValidation), "", ModelState.Values.First().Errors.First().ErrorMessage));
            }

            _service.Remove(id);
        }

    }
}
