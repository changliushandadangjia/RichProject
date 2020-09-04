using System;
using System.Collections.Generic;
using System.Text;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace RichProjectAdmin.Application
{
    public class ApplicationModule:AbpModule
    {
        /// <summary>
        ///     应用模块初始化
        /// </summary>
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ApplicationModule).GetAssembly());
        }
    }
}
