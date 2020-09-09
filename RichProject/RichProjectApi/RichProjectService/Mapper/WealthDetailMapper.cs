using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectService.Mapper
{
    public class WealthDetailMapper:Profile
    {
        public WealthDetailMapper()
        {
            CreateMap<WealthDetail, WealthDetail>();
        }
    }
}
