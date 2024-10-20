using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.API.Contoller
{
    [Route("api/[controller]/[action]")]
    public class StaffController : CustomBaseController
    {
        private readonly IStaffService _staffStaff;

        public StaffController(IStaffService staffStaff)
        {
            _staffStaff = staffStaff;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return ActionResultInstance(await _staffStaff.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return ActionResultInstance(await _staffStaff.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Staff staff)
        {
            return ActionResultInstance(await _staffStaff.AddAsync(staff));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Staff staff)
        {
            return ActionResultInstance(await _staffStaff.Update(staff));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _staffStaff.Remove(id));
        }
    }
}
