using Microsoft.EntityFrameworkCore;

namespace DRT.Persistence.MSSQL
{
    public class MsSqlFnzDbContext : FnzDbContext
    {
        public MsSqlFnzDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}