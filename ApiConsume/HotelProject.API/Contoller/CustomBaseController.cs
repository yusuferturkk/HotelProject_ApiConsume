﻿using HotelProject.Dto.ServiceDtos;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.API.Contoller
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance<T>(ResponseDto<T> response) where T : class
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
            };
        }
    }
}
