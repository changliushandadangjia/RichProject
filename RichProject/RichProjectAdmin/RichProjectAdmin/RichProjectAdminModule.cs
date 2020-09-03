using Abp.AspNetCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Web;
using RichProjectAdmin.Application;

namespace RichProjectAdmin.Web
{
    [DependsOn(typeof(AbpAspNetCoreModule), typeof(ApplicationModule))]
    public class RichProjectAdminModule: AbpModule
    {
        /// <summary>
        ///     应用模块初始化
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RichProjectAdminModule).GetAssembly());
        }
    }
}
