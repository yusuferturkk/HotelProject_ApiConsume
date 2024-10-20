using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.API.Contoller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscribeController : CustomBaseController
    {
        private readonly ISubscribeService _subscribeSubscribe;

        public SubscribeController(ISubscribeService subscribeSubscribe)
        {
            _subscribeSubscribe = subscribeSubscribe;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return ActionResultInstance(await _subscribeSubscribe.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return ActionResultInstance(await _subscribeSubscribe.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Subscribe subscribe)
        {
            return ActionResultInstance(await _subscribeSubscribe.AddAsync(subscribe));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Subscribe subscribe)
        {
            return ActionResultInstance(await _subscribeSubscribe.Update(subscribe));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _subscribeSubscribe.Remove(id));
        }
    }
}
