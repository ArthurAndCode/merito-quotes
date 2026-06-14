while (true)
{
    Console.Clear();
    Console.WriteLine("1. Losuj zlota mysl");
    Console.WriteLine("2. Dodaj zlota mysl");
    Console.WriteLine("3. Wyjdz");
    Console.Write("Wybor: ");
    
    var choice = Console.ReadLine();
    if (choice == "3") break;

    Console.WriteLine("\nNacisnij dowolny klawisz...");
    Console.ReadKey();
}