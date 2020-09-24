using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RichProjectDomain.Model.DatabaseDto;
using RichProjectDomain.Model.InputModel;

namespace RichProjectApi.Controllers
{
    public class ShareDetailController : AbpController
    {

        
        public List<ShareDealDetail> GetGetShareDetail([FromBody] ShareDetailQueryInputDto input)
        {

        }
    }
}