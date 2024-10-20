using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HotelProject.Dto.ServiceDtos
{
    public class ResponseDto<T> where T : class
    {
        public T Data { get; private set; }
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessful { get; private set; }
        public ErrorDto Error { get; private set; }

        public static ResponseDto<T> Success(int statudCode)
        {
            return new ResponseDto<T> { StatusCode = statudCode, Data = default, IsSuccessful = true };
        }

        public static ResponseDto<T> Success(int statudCode, T data)
        {
            return new ResponseDto<T> { StatusCode = statudCode, Data = data, IsSuccessful = true };
        }

        public static ResponseDto<T> Fail(int statusCode, string error, bool isShow)
        {
            var errorDto = new ErrorDto(error, isShow);
            return new ResponseDto<T> { StatusCode = statusCode, Error = errorDto, IsSuccessful = false };
        }

        public static ResponseDto<T> Fail(int statusCode, ErrorDto errorDto)
        {
            return new ResponseDto<T> { StatusCode = statusCode, Error = errorDto, IsSuccessful = false };
        }
    }
}
