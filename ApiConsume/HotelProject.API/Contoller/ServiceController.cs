using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Dto.EntityDtos;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.API.Contoller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceController : CustomBaseController
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return ActionResultInstance(await _serviceService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return ActionResultInstance(await _serviceService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Service service)
        {
            return ActionResultInstance(await _serviceService.AddAsync(service));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Service service)
        {
            return ActionResultInstance(await _serviceService.Update(service));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _serviceService.Remove(id));
        }
    }
}
