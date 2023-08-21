// See https://aka.ms/new-console-template for more information


using StrategyPattern;

Console.WriteLine("Hello, World!");

var strategies = new Dictionary<ConsoleKey, ICalculateStrategy>
{
    {ConsoleKey.D1, new KmToMilesStrategy()},
    {ConsoleKey.D2, new MilesToKmStrategy()},
    {ConsoleKey.D3, new CmsToInchesStrategy()},
    {ConsoleKey.D4, new InchesToCmsStrategy()}
};

var quit = false;
while (!quit)
{
    var key = PrintMenu();
    if (key != ConsoleKey.Q)
    {
        Console.WriteLine();
        var found = strategies.TryGetValue(key, out var strategy);
        if (found)
        {
            Console.WriteLine($"Converting {strategy!.Name}");

            Console.WriteLine("Enter value to convert: ");
            var value = double.Parse(Console.ReadLine() ?? "0");
            var converter = new Converter(strategy);
            var text = converter.Execute(value);

            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("Strategy not found, please try again.");
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to continue!");
        Console.ReadKey();
    }
    else
    {
        quit = true;
        Console.WriteLine("Quitting ...");
    }
}

static ConsoleKey PrintMenu()
{
    Console.Clear();
    Console.WriteLine("Enter Conversion strategy. (Use number pad");
    Console.WriteLine("1 - Km To Miles");
    Console.WriteLine("2 - Miles To Km");
    Console.WriteLine("3 - Cms To Inches");
    Console.WriteLine("4 - Inches To Cms");
    Console.WriteLine("Q - quit");

    return Console.ReadKey().Key;
}