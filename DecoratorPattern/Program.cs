// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

Console.WriteLine("Hello, Welcome to Decorator Pattern!");
Console.WriteLine();
Console.WriteLine("Lets say we have a Basket and want to add an item to the basket");
Console.WriteLine("We can add a discount to the item and get the price of the item");
Console.WriteLine("We can also add tax to the item and get the price of the item");
Console.WriteLine();

Console.WriteLine("Lets create an item with an initial value and name");
// the original item
var item = new BasketItem("Telescope");
item.AddPrice(10.00);
Console.WriteLine($"Base Price for {item.Name} is {item.GetPrice():C}");

Console.WriteLine();
Console.WriteLine("Now we can add a discount to the item");
// we can add a discount to the item
var discountDecorator = new DiscountDecorator(item);
double discount = 2.00;
discountDecorator.AddDiscount(discount);
Console.WriteLine($"Price with discount of {discount:C} is {item.GetPrice():C}");

Console.WriteLine();
Console.WriteLine("Now we can add tax to the item");
// now we need to add tax to the item
var taxDecorator = new TaxDecorator(discountDecorator);
taxDecorator.AddTax(10.00);
Console.WriteLine($"Price with tax of 10% for {item.Name} is {item.GetPrice():C}");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();