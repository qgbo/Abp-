using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using qgb48.Authorization.Roles;
using qgb48.Authorization.Users;
using qgb48.MultiTenancy;
using qgb48.Orders;
using qgb48.Tests;

namespace qgb48.EntityFrameworkCore
{
    public class qgb48DbContext : AbpZeroDbContext<Tenant, Role, User, qgb48DbContext>
    {
        /* Define a DbSet for each entity of the application */


        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Test> Tests { get; set; }
        public qgb48DbContext(DbContextOptions<qgb48DbContext> options)
            : base(options)
        {
        }
    }
}
