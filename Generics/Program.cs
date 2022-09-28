using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerPrinter = new PlayerPrinter<Player>();

            playerPrinter.PrintPlayerStatistics(new Player("Free", "PerssonThePersson", 100));
            playerPrinter.PrintPlayerStatistics(new Player("Premium", "Cornelia75", 900));
            playerPrinter.PrintPlayerStatistics(new Player("Premium", "Mat-Mats", 500));

        }
    }
}
