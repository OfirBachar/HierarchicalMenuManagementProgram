using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class SpaceCalculator : IOwnerMenuListener
    {
        public void DoCommandAfterChosen()
        {
            int counterSpaces = 0;

            Console.WriteLine(@"Hello, plz write a line:
");
            string lineToCalculate = Console.ReadLine();

            foreach(char charToCheck in lineToCalculate)
            {
                if(charToCheck == ' ')
                {
                    counterSpaces++;
                }
            }

            Console.WriteLine($"The number of spaces is: {counterSpaces}");
        }
    }
}
