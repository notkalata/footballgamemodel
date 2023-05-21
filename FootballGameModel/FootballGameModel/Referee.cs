using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameModel
{
    class Referee : Person
    {
        public Referee(string name, int age) : base(name, age)
        {

        }

        public override void Print()
        {
            Console.WriteLine("Referee");
            base.Print();
        }
    }
}
