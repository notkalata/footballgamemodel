using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameModel
{
    class Coach : Person
    {
        public Coach(string name, int age) : base(name, age)
        {

        }

        public override void Print()
        {
            Console.WriteLine("Coach");
            base.Print();
        }
    }
}
