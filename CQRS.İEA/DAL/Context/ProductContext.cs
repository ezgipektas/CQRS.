using CQRS.İEA.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.İEA.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-FJT4L6QM;initial catalog=DbCQRS;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
