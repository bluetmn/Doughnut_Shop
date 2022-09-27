using Microsoft.EntityFrameworkCore;
using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.data;

public class ApplicationDBContext : DbContext {

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        
    }

    public DbSet<Doughnut>? DoughnutDB { get; set; }
}