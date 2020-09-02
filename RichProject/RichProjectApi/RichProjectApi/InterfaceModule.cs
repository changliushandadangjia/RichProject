using Abp.AspNetCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RichProjectDataAccess;
using RichProjectService;

namespace RichProjectApi
{
    [DependsOn(typeof(AbpAspNetCoreModule),typeof(ServiceModule))]
    public class InterfaceModule:AbpModule
    {
        /// <summary>
        ///     应用模块初始化
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InterfaceModule).GetAssembly());
        }
    }
}
