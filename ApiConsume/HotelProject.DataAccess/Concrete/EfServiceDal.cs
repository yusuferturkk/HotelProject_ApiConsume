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
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
