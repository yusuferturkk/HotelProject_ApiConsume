using HotelProject.Business.Abstract;
using HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.API.Contoller
{
    [Route("api/[controller]/[action]")]
    public class TestimonialController : CustomBaseController
    {
        private readonly ITestimonialService _testimonialTestimonial;

        public TestimonialController(ITestimonialService testimonialTestimonial)
        {
            _testimonialTestimonial = testimonialTestimonial;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return ActionResultInstance(await _testimonialTestimonial.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return ActionResultInstance(await _testimonialTestimonial.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Testimonial testimonial)
        {
            return ActionResultInstance(await _testimonialTestimonial.AddAsync(testimonial));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Testimonial testimonial)
        {
            return ActionResultInstance(await _testimonialTestimonial.Update(testimonial));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return ActionResultInstance(await _testimonialTestimonial.Remove(id));
        }
    }
}
