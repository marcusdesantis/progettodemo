using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Opera.EntityFrameworkCore
{
    public static class OperaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OperaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OperaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
