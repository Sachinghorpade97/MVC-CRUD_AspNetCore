using CRUD_AspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_AspNetCore.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)  
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
