using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace qgb48.EntityFrameworkCore
{
    public static class qgb48DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<qgb48DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<qgb48DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
