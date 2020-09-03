using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace RichProjectAdmin.Web.Controllers
{
    public class WealtDetailController : AbpController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}