using Microsoft.EntityFrameworkCore;

namespace wasm.Server
{
    internal class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}