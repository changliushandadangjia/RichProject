using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectAdmin.Domain.Model
{
    public class LargePayDetail
    {
        public int Id { get; set; }

        /// <summary>
        /// 放钱的地方
        /// </summary>
        public string PayName { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModifycationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
