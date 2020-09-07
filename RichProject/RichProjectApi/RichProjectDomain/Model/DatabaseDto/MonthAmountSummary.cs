using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectDomain.Model.DatabaseDto
{
    public class MonthAmountSummary
    {
        public int Id { get; set; }
        public string TimeFlag { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModifycationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
