// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

Console.WriteLine("Hello, Welcome to Decorator Pattern!");

// the original item
var item = new BasketItem("Telescope");
item.AddPrice(10.00);
Console.WriteLine($"Base Price is {item.GetPrice():C}");

// we can add a discount to the item
var discountDecorator = new DiscountDecorator(item);
double discount = 2.00;
discountDecorator.AddDiscount(discount);
Console.WriteLine($"Price with discount of {discount:C} is {item.GetPrice():C}");

// now we need to add tax to the item
var taxDecorator = new TaxDecorator(discountDecorator);
taxDecorator.AddTax(10.00);
Console.WriteLine($"Price with tax of 10% for {item.Name} is {item.GetPrice():C}");


Console.WriteLine("Press any key to exit...");
Console.ReadKey();