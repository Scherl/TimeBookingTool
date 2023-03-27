using Microsoft.EntityFrameworkCore;

namespace TimeBooking.Data.Context
{
    public class RepositoryBase 
    {
        private readonly IDbContextFactory<zeiterfassungContext> _factory;
        private readonly zeiterfassungContext _context;

        protected RepositoryBase(IDbContextFactory<zeiterfassungContext> factory)
        {
            _factory = factory;
            _context = factory.CreateDbContext();
        }

        protected zeiterfassungContext Context => _context;
        protected Task<zeiterfassungContext> CreateContextAsync() => _factory.CreateDbContextAsync();
    }


}
