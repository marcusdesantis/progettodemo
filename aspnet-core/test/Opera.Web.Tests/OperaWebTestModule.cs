using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Opera.EntityFrameworkCore;
using Opera.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Opera.Web.Tests
{
    [DependsOn(
        typeof(OperaWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class OperaWebTestModule : AbpModule
    {
        public OperaWebTestModule(OperaEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OperaWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(OperaWebMvcModule).Assembly);
        }
    }
}