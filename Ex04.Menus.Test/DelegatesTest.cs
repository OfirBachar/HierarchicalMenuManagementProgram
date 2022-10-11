using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;


namespace Ex04.Menus.Test
{
    class DelegatesTest
    {
        private readonly MainMenu r_MainMenu;

        public DelegatesTest()
        {
            r_MainMenu = new MainMenu();
        }

        public void Run()
        {
            buildMenu();
            r_MainMenu.Show();
        }

        private void buildMenu()
        {
            MenuItemHolder startMenuHolder = new MenuItemHolder("Delegates Main Menu");

            MenuItemHolder showDataTimeHolder = new MenuItemHolder("Show Date/Time");
            MenuItemHolder versionAndSpacesHolder = new MenuItemHolder("Version and Spaces");

            MenuItemAction timeAction = new MenuItemAction("Show Time");
            MenuItemAction dateAction = new MenuItemAction("Show Date");
            MenuItemAction countSpacesAction = new MenuItemAction("Count Spaces");
            MenuItemAction versionAction = new MenuItemAction("Show Version");

            timeAction.Selected += TimeAction_Selected;
            dateAction.Selected += DateAction_Selected;
            countSpacesAction.Selected += CountSpacesAction_Selected;
            versionAction.Selected += VersionAction_Selected;

            showDataTimeHolder.MenuItems.Add(timeAction);
            showDataTimeHolder.MenuItems.Add(dateAction);

            versionAndSpacesHolder.MenuItems.Add(countSpacesAction);
            versionAndSpacesHolder.MenuItems.Add(versionAction);

            startMenuHolder.MenuItems.Add(showDataTimeHolder);
            startMenuHolder.MenuItems.Add(versionAndSpacesHolder);

            r_MainMenu.CurrentMenuItemHolder = startMenuHolder;
        }

        private void VersionAction_Selected()
        {
            Console.WriteLine("Version: 22.2.4.8950");
        }

        private void CountSpacesAction_Selected()
        {
            int counterSpaces = 0;

            Console.WriteLine(@"Hello, plz write a line:
");
            string lineToCalculate = Console.ReadLine();

            foreach (char charToCheck in lineToCalculate)
            {
                if (charToCheck == ' ')
                {
                    counterSpaces++;
                }
            }

            Console.WriteLine($"The number of spaces is: {counterSpaces}");
        }

        private void DateAction_Selected()
        {
            Console.WriteLine($@"{DateTime.Today:d}");
        }

        private void TimeAction_Selected()
        {
            Console.WriteLine($@"{DateTime.Now.TimeOfDay:g}");
        }
    }
}
