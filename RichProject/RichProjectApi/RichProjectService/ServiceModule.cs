using Abp.Modules;
using Abp.Reflection.Extensions;
using RichProjectDataAccess;

namespace RichProjectService
{
    [DependsOn(typeof(DataAccessModule))]
    public class ServiceModule:AbpModule
    {
        /// <summary>
        ///     应用模块初始化
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServiceModule).GetAssembly());
        }
    }
}
