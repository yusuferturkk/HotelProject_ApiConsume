using AutoMapper;
using HotelProject.Business.Abstract;
using HotelProject.Business.Constants;
using HotelProject.DataAccess.Abstract;
using HotelProject.Dto.EntityDtos;
using HotelProject.Dto.ServiceDtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;


        public GenericService(IGenericRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<TEntity>> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();

            return ResponseDto<TEntity>.Success(200, entity);
        }

        public async Task<ResponseDto<IEnumerable<TEntity>>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return ResponseDto<IEnumerable<TEntity>>.Success(200, entities);
        }

        public async Task<ResponseDto<TEntity>> GetByIdAsync(int id)
        {
            var isExistEntity = await _repository.GetByIdAsync(id);
            if (isExistEntity == null)
            {
                return ResponseDto<TEntity>.Fail(404, Messages.IdNotFound, true);
            }
            return ResponseDto<TEntity>.Success(200, isExistEntity);
        }

        public async Task<ResponseDto<NoContentDto>> Remove(int id)
        {
            var isExistEntity = await _repository.GetByIdAsync(id);
            if (isExistEntity == null)
            {
                return ResponseDto<NoContentDto>.Fail(404, Messages.IdNotFound, true);
            }
            
            _repository.Remove(isExistEntity);
            await _unitOfWork.CommitAsync();
            return ResponseDto<NoContentDto>.Success(200);
        }

        public async Task<ResponseDto<NoContentDto>> Update(TEntity entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
            return ResponseDto<NoContentDto>.Success(200);
        }

        public async Task<ResponseDto<IEnumerable<TEntity>>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            var list = _repository.Where(predicate);
            return ResponseDto<IEnumerable<TEntity>>.Success(200, await list.ToListAsync());
        }
    }
}
