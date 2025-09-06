using Microsoft.EntityFrameworkCore;
using MVC_One.Models;

namespace MVC_One.Data
{
    public class MVC_OneContext: DbContext
    {

        public MVC_OneContext(DbContextOptions<MVC_OneContext> options) :base(options){}

        public DbSet<TaskModel> Tasks { get; set; }
    }
}
