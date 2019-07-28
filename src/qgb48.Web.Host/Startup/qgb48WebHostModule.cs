using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using qgb48.Configuration;

namespace qgb48.Web.Host.Startup
{
    [DependsOn(
       typeof(qgb48WebCoreModule))]
    public class qgb48WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public qgb48WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(qgb48WebHostModule).GetAssembly());
        }
    }
}
