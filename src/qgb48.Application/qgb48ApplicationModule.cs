using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using qgb48.Authorization;
using qgb48.Tests;

namespace qgb48
{
    [DependsOn(
        typeof(qgb48CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class qgb48ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<qgb48AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(qgb48ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
           


            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
