using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class PlayerPrinter<TPlayer>
    {
        public void PrintPlayerStatistics(TPlayer player)
        {
            var type = player.GetType();

            var properties = type.GetProperties();

            foreach(var property in properties)
            {
                Console.WriteLine(property.GetValue(player));
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
