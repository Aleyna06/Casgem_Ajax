using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4FNRCPJ\\SQLEXPRESS; initial catalog=CasgemAjaxDb; integrated security = true;");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
