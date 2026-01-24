using Emplyee.Dal.Abstraction;
using Emplyee.Dal.Imp;
using Emplyee.Sal.Abstraction;
using Emplyee.Sal.Imp;
using Emplyee.Service.Abstraction;
using Emplyee.Service.Imp;

namespace RegisterModule
{
    public static class RegisterModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<IEmplyeeService, EmplyeeService>();
            services.AddScoped<IEmplyeeDal, EmplyeeDal>();
            services.AddScoped<IEmplyeeSal, EmplyeeSal>();
        }

    }
}
