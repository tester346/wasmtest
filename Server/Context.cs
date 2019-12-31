using Microsoft.EntityFrameworkCore;

namespace wasm.Server
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}