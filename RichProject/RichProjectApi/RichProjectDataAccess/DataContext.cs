using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RichProjectDomain.Model.DatabaseDto;

namespace RichProjectDataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<WealthDetail> WealthDetail { get; set; }
    }
}
