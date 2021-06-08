// Connect with the DbContext and also to make a connection with the Database.
using Microsoft.EntityFrameworkCore;

namespace Dapper_ORM.DataContext
{
    public class AppContext : DbContext
    {
        public AppContext() { }
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}