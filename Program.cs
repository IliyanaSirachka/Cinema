using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());
            var price = -1.0;

            switch (type)
            {
                case "premiere":
                    price = 12;
                    break;
                case "normal":
                    price = 7.5;
                    break;
                case "discount":
                    price = 5;
                    break;
            }

            if (price > 0)
            {
                var result = row * col * price;
                Console.WriteLine("{0:f2}", result);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
