using System.Net.Http.Json;

using var client = new HttpClient();
client.BaseAddress = new Uri("http://localhost:5000/");

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Losuj zlota mysl");
    Console.WriteLine("2. Dodaj zlota mysl");
    Console.WriteLine("3. Wyjdz");
    Console.Write("Wybor: ");
    
    var choice = Console.ReadLine();
    if (choice == "3") break;

    if (choice == "1")
    {
        try
        {
            var quote = await client.GetFromJsonAsync<Quote>("quotes/random");
            if (quote != null)
            {
                Console.WriteLine($"\n\"{quote.Text}\" - {quote.Author}");
            }
        }
        catch
        {
            Console.WriteLine("\nBlad pobierania lub brak mysli w bazie.");
        }
    }
    else if (choice == "2")
    {
        Console.Write("Tresc mysli: ");
        var text = Console.ReadLine() ?? "";
        Console.Write("Autor: ");
        var author = Console.ReadLine() ?? "";

        var newQuote = new Quote { Text = text, Author = author };
        try
        {
            var response = await client.PostAsJsonAsync("quotes", newQuote);
            if (response.IsSuccessStatusCode) Console.WriteLine("\nDodano mysl!");
            else Console.WriteLine("\nBlad serwera.");
        }
        catch
        {
            Console.WriteLine("\nBrak polaczenia z API.");
        }
    }

    Console.WriteLine("\nNacisnij dowolny klawisz...");
    Console.ReadKey();
}

class Quote 
{ 
    public int Id { get; set; }
    public string Text { get; set; } = ""; 
    public string Author { get; set; } = ""; 
}