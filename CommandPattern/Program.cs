// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;
using CommandPattern;

Console.WriteLine("Hello, this is command pattern demo with calculator!");


var calculator = new Calculator();
Console.WriteLine($"Initial value: {calculator.CurrentValue}");


var quit = false;
while (!quit)
{
    //Console.Clear();    
    var key = PrintCommands();
    Console.WriteLine();
    
    Console.WriteLine("Enter value:");
    var value = double.Parse(Console.ReadLine() ?? "0");
    
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
    }
    
    Console.WriteLine($"Running total: {calculator.CurrentValue}");
}

static ConsoleKey PrintCommands()
{
    Console.WriteLine();
    Console.WriteLine("Select");
    Console.WriteLine("x Multiply");
    Console.WriteLine("D Divide");
    Console.WriteLine("+ Addition");
    Console.WriteLine("- Subtraction");
    Console.WriteLine("Q to quit");

    Console.WriteLine("Enter Command");
    return Console.ReadKey().Key;

}