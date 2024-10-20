using HotelProject.DataAccess.Abstract;
using HotelProject.DataAccess.Concrete;
using HotelProject.DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
