using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    class InterfaceTest
    {
        private readonly MainMenu r_MainMenu;

        public InterfaceTest()
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
            MenuItemHolder startMenuHolder = new MenuItemHolder("Interface Main Menu");

            MenuItemHolder showDataTimeHolder = new MenuItemHolder("Show Date/Time");
            MenuItemHolder versionAndSpacesHolder = new MenuItemHolder("Version and Spaces");

            MenuItemAction timeAction = new MenuItemAction("Show Time");
            MenuItemAction dateAction = new MenuItemAction("Show Date");
            MenuItemAction countSpacesAction = new MenuItemAction("Count Spaces");
            MenuItemAction versionAction = new MenuItemAction("Show Version");

            TimeDisplayer timeDisplayer = new TimeDisplayer();
            DateDisplayer dateDisplayer = new DateDisplayer();
            SpaceCalculator spacesCalc = new SpaceCalculator();
            VersionDisplayer versionDisplayer = new VersionDisplayer();

            timeAction.AttachObserver(timeDisplayer);
            dateAction.AttachObserver(dateDisplayer);
            countSpacesAction.AttachObserver(spacesCalc);
            versionAction.AttachObserver(versionDisplayer);

            showDataTimeHolder.MenuItems.Add(timeAction);
            showDataTimeHolder.MenuItems.Add(dateAction);

            versionAndSpacesHolder.MenuItems.Add(countSpacesAction);
            versionAndSpacesHolder.MenuItems.Add(versionAction);

            startMenuHolder.MenuItems.Add(showDataTimeHolder);
            startMenuHolder.MenuItems.Add(versionAndSpacesHolder);

            r_MainMenu.CurrentMenuItemHolder = startMenuHolder;
        }
    }
}
