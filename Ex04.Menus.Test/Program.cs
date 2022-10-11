using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            InterfaceTest interfaceTest = new InterfaceTest();
            interfaceTest.Run();
            DelegatesTest delegatesTest = new DelegatesTest();
            delegatesTest.Run();
        }
    }
}
