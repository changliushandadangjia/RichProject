using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectDomain.Model.InputModel
{
    public class ShareDetailQueryInputDto
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Name { get; set; }
        
        public string ShareCode { get; set; }
    }
}
