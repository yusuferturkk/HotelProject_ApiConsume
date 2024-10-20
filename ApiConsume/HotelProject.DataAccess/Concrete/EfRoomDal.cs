using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Repository;
using HotelProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess.Concrete
{
    public class EfRoomDal : GenericRepository<Room>, IRoomDal
    {
        public EfRoomDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
