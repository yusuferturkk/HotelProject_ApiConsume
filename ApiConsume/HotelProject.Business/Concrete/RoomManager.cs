using HotelProject.Business.Abstract;
using HotelProject.DataAccess.Abstract;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Business.Concrete
{
    public class RoomManager : GenericService<Room>, IRoomService
    {
        public RoomManager(IGenericRepository<Room> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
