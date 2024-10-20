using HotelProject.Dto.ServiceDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Abstract
{
    public interface IGenericService<TEntity> 
        where TEntity : class 
    {
        Task<ResponseDto<TEntity>> GetByIdAsync(int id);
        Task<ResponseDto<IEnumerable<TEntity>>> GetAllAsync();
        Task<ResponseDto<IEnumerable<TEntity>>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<ResponseDto<TEntity>> AddAsync(TEntity entity);
        Task<ResponseDto<NoContentDto>> Remove(int id);
        Task<ResponseDto<NoContentDto>> Update(TEntity entity);
    }
}