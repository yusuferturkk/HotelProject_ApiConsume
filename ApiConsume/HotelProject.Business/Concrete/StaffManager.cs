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
    public class StaffManager : GenericService<Staff>, IStaffService
    {
        public StaffManager(IGenericRepository<Staff> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
