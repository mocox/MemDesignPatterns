// See https://aka.ms/new-console-template for more information

using CommandPattern;

Console.WriteLine("Hello, this is command pattern demo with a simple calculator!");


var calculator = new Calculator();
Console.WriteLine($"Initial value: {calculator.CurrentValue}");


var quit = false;
while (!quit)
{
    
    Console.WriteLine($"Running total: {calculator.CurrentValue}");
    
    //Console.Clear();    
    var key = PrintCommands();
    Console.WriteLine();

    var value = 0.0d;
    if (key != ConsoleKey.U)
    {
        Console.WriteLine("Enter value:");
        value = double.Parse(Console.ReadLine() ?? "0");
    }

    Console.WriteLine("Enter Command");
    
    
    switch (key)
    {
        case ConsoleKey.OemPlus:
            calculator.ExecuteCommand(new AddCommand(value));
            break;
        case ConsoleKey.X:
            calculator.ExecuteCommand(new MultiplyCommand(value));
            break;
        case ConsoleKey.D:
            calculator.ExecuteCommand(new DivideCommand(value));
            break;
        case ConsoleKey.OemMinus:
            calculator.ExecuteCommand(new SubtractCommand(value));
            break;
        case ConsoleKey.Q:
            quit = true;
            break;
        case ConsoleKey.U:
            calculator.Undo();
            break;
    }
}



static ConsoleKey PrintCommands()
{
    Console.WriteLine();
    Console.WriteLine("Select");
    Console.WriteLine("x Multiply");
    Console.WriteLine("D Divide");
    Console.WriteLine("+ Addition");
    Console.WriteLine("- Subtraction");
    Console.WriteLine("U - Undo");
    Console.WriteLine("Q to quit");
    
    return Console.ReadKey().Key;

}