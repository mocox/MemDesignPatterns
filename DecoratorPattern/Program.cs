// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

Console.WriteLine("Hello, Welcome to Decorator Pattern!");

// the original item
var item = new BasketItem();
item.AddPrice(10.00);
Console.WriteLine($"Price: £{item.GetPrice()}");

// we can add a discount to the item
var discountDecorator = new DiscountDecorator();
discountDecorator.SetItem(item);
discountDecorator.AddDiscount(2.00);
Console.WriteLine($"Price with discount £2.00: £{discountDecorator.GetPrice()}");

// now we need to add tax to the item
var taxDecorator = new TaxDecorator();
taxDecorator.SetItem(discountDecorator);
taxDecorator.AddTax(10.00);
Console.WriteLine($"Price with tax of 10%: £{taxDecorator.GetPrice():#.##}");


Console.WriteLine("Press any key to exit...");
Console.ReadKey();