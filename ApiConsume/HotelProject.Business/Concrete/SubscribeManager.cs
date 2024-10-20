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
    public class SubscribeManager : GenericService<Subscribe>, ISubscribeService
    {
        public SubscribeManager(IGenericRepository<Subscribe> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
