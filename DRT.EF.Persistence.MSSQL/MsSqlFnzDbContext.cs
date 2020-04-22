using Microsoft.EntityFrameworkCore;

namespace DRT.Persistence.MSSQL
{
    public class MsSqlDRTDbContext : DRTDbContext
    {
        public MsSqlDRTDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}