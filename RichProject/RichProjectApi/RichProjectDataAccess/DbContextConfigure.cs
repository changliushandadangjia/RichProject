using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace RichProjectDataAccess
{
    public static class DbContextConfigure
    {
        public static void Configure(DbContextOptionsBuilder<DataContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DataContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
