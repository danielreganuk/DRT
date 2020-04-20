using Microsoft.EntityFrameworkCore;
using DRT.Persistence;

namespace DRT.Persistence.MySQL
{
    public class MySqlFnzDbContext : FnzDbContext
    {
        public MySqlFnzDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}