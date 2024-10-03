using Application.Services;
using Domain.Dto.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ILogger<ServiceController> _logger;
        private readonly ServiceEntityService _serviceEntityService;

        public ServiceController(ILogger<ServiceController> logger, ServiceEntityService serviceEntityService)
        {
            _logger = logger;
            _serviceEntityService = serviceEntityService;
        }

        [HttpGet]
        public ServiceDto? Get(int id)
        {
            return _serviceEntityService.GetByIdAsync(id).Result;
        }

        [HttpGet("GetAll")]
        public List<ServiceDto> GetAll()
        {
            return _serviceEntityService.GetAllAsync().Result;
        }

        [HttpPost]
        public ServiceDto Post(ServiceDto dto)
        {
            return _serviceEntityService.CreateAsync(dto).Result;
        }

        [HttpPut]
        public ServiceDto Put(ServiceDto dto)
        {
            return _serviceEntityService.UpdateAsync(dto).Result;
        }

        [HttpDelete]
        public async Task Delete(int id)
        {
            await _serviceEntityService.DeleteAsync(id);
        }
    }
}
