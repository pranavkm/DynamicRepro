// See https://aka.ms/new-console-template for more information
using ConsoleApp23;
using System.Dynamic;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

while (true)
{
    var container = new DynamicContainer();
    Repro.RunController(container);
    Repro.RunView(container);

    Console.ReadLine();

}


