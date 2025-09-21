using ProjectName.Dal.Abstraction;
using ProjectName.Dal.Imp;
using ProjectName.Sal.Abstraction;
using ProjectName.Sal.Imp;
using ProjectName.Service.Abstraction;
using ProjectName.Service.Imp;

namespace RegisterModule
{
    public static class RegisterModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<IProjectNameService, ProjectNameService>();
            services.AddScoped<IProjectNameDal, ProjectNameDal>();
            services.AddScoped<IProjectNameSal, ProjectNameSal>();
        }

    }
}
