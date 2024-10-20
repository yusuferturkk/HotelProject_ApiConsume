using AutoMapper;
using HotelProject.Business.Abstract;
using HotelProject.Dto.EntityDtos.RoomDtos;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelProject.API.Contoller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomController : CustomBaseController
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return ActionResultInstance(await _roomService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return ActionResultInstance(await _roomService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Room room)
        {
            return ActionResultInstance(await _roomService.AddAsync(room));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Room room)
        {
            return ActionResultInstance(await _roomService.Update(room));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _roomService.Remove(id));
        }
    }
}
