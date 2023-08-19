// See https://aka.ms/new-console-template for more information

using MediatR01;

Console.WriteLine("Hello, World!");


var network = new NetworkMediator();
var desktop = new DesktopComputer( network, "C1");
var server = new ServerComputer(network, "S1");

network.Register("C1", desktop);
network.Register("S1", server);

desktop.SendCommand("S1", "Hello Server1");
server.SendCommand("C1", "Hello Computer1");
desktop.SendCommand("S!", "Hello", 7);

Console.ReadKey();