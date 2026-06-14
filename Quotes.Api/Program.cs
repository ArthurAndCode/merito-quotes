using Microsoft.EntityFrameworkCore;
using Quotes.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<QuoteDbContext>(opt => opt.UseInMemoryDatabase("QuotesDb"));

var app = builder.Build();

app.MapPost("/quotes", async (Quote quote, QuoteDbContext db) =>
{
    db.Quotes.Add(quote);
    await db.SaveChangesAsync();
    return Results.Created($"/quotes/{quote.Id}", quote);
});

app.MapGet("/quotes/random", async (QuoteDbContext db) =>
{
    var quotes = await db.Quotes.ToListAsync();
    if (!quotes.Any())
    {
        return Results.NotFound();
    }
    
    var random = new Random();
    var index = random.Next(quotes.Count);
    return Results.Ok(quotes[index]);
});

app.Run();