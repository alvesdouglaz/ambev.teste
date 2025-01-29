using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DbContext> options) : base(options) {}
    }
}