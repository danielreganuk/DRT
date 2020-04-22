using Microsoft.EntityFrameworkCore;
using DRT.Persistence;

namespace DRT.Persistence.MySQL
{
    public class MySqlDRTDbContext : DRTDbContext
    {
        public MySqlDRTDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}