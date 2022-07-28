using System;
using System.Collections.Generic;

namespace Homework6classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index;
            Mobile Motorolla = new Mobile("+375293334455", "zx9", 249.99);
            Mobile Pokophone = new Mobile("+375293332211", "POCO9", 189.5);
            Console.WriteLine($"Weight of device1: {Motorolla.Weight}");
            Console.WriteLine($"Weight of device2:{Pokophone.Weight}");
            Console.WriteLine($"Model of device 1:{Motorolla.Model}");
            Console.WriteLine($"Model of device 2 :{Pokophone.Model}");
            Motorolla.Weight = -212;
            Console.WriteLine(Motorolla.Weight);
            Motorolla.RecieveCall("Plotva");
            //random choose of mobile; Позже в методы перекину
            var random = new Random();
            var list = new List<string> { "Iphone", "Motorolla", "Pocophone", "Nokia" };
            index = random.Next(list.Count);
            Console.WriteLine(list[index]);
        }
    }
}
