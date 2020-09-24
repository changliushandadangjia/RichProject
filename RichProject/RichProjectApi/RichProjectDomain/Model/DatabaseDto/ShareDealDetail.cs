using System;
using System.Collections.Generic;
using System.Text;

namespace RichProjectDomain.Model.DatabaseDto
{
    public class ShareDealDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShareCode { get; set; }
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
        public decimal ShareNumber { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
        public DateTime BuyTime { get; set; }
        public DateTime SaleTime { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastModifycationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
