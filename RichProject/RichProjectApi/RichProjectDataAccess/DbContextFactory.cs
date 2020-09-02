using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RichProjectDataAccess
{
    public class DbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();

            DbContextConfigure.Configure(builder, "Server=.;Database=RichProject;Integrated Seurity=true;");

            return new DataContext(builder.Options);
        }
    }
}
