using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameModel
{
    class Striker : FootballPlayer
    {
        public Striker(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }
        public override void Print()
        {
            Console.WriteLine("Striker");
            base.Print();
        }
    }
}
