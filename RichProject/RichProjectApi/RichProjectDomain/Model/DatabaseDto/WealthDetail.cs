using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectDomain.Model.DatabaseDto
{
    /// <summary>
    /// 财富实体
    /// </summary>
    public class WealthDetail
    {
        public int Id { get; set; }

        /// <summary>
        /// 放钱的地方
        /// </summary>
        public string WealthArea { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModifycationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
