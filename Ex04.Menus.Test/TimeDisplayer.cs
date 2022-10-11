using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class TimeDisplayer : IOwnerMenuListener
    {
        public void DoCommandAfterChosen()
        {
            Console.WriteLine($@"{DateTime.Now.TimeOfDay:g}");
        }
    }
}
