using Microsoft.EntityFrameworkCore;

namespace Quotes.Api;

public class QuoteDbContext : DbContext
{
    public QuoteDbContext(DbContextOptions<QuoteDbContext> options) : base(options) { }

    public DbSet<Quote> Quotes => Set<Quote>();
}