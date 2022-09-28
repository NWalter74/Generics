using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Player
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string type, string name, int score)
        {
            Type = type;
            Name = name;
            Score = score;
        }
    }
}
