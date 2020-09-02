using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.EntityFrameworkCore;

namespace RichProjectDataAccess
{
    public class DataAccessModule : AbpModule
    {
        public override void PreInitialize()
        {
        }

        /// <summary>
        ///     应用模块初始化
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DataAccessModule).GetAssembly());
        }
    }
}
