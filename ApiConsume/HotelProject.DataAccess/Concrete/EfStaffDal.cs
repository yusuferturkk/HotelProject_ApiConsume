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
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
