using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectAdmin.Domain.Model
{
    public class WealthDetail
    {
        public int Id { get; set; }
        public string WealthArea { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModifycationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
