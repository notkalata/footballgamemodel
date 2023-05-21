using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameModel
{
    class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }
        public override void Print()
        {
            Console.WriteLine("Defender");
            base.Print();
        }
    }
}
