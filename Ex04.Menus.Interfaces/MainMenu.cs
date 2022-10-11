using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        public MenuItemHolder CurrentMenuItemHolder { get; set; }

        private readonly Stack r_AllChosenMenus = new Stack();

        private int m_Level;

        public void Show()
        {
            bool quit = false;

            while(quit == false)
            {
                int indexNumber;

                Console.Clear();
                Console.WriteLine(CurrentMenuItemHolder?.ToString());

                try
                {
                    indexNumber = checkUserChoiceValid(0, CurrentMenuItemHolder.MenuItems.Count);
                }
                catch(Exception exception)
                {
                    Console.WriteLine($@"{exception.Message}
Press any Key to Try again.");
                    Console.ReadKey();

                    continue;
                }

                if (indexNumber == 0)
                {
                    if (m_Level == 0)
                    {
                        break;
                    }

                    CurrentMenuItemHolder = (MenuItemHolder)r_AllChosenMenus.Pop();
                    m_Level--;
                    CurrentMenuItemHolder.LevelOfMenu = m_Level;

                    continue;
                }

                if (CurrentMenuItemHolder?.MenuItems[indexNumber - 1] is MenuItemAction menuItemAction)
                {
                    Console.Clear();
                    menuItemAction.MenuItemSelected();
                    Console.WriteLine("press any key for continue");
                    Console.ReadKey();
                }
                else
                {
                    r_AllChosenMenus.Push(CurrentMenuItemHolder);
                    CurrentMenuItemHolder = CurrentMenuItemHolder?.MenuItems[indexNumber - 1] as MenuItemHolder;

                    if(CurrentMenuItemHolder != null)
                    {
                        m_Level++;
                        CurrentMenuItemHolder.LevelOfMenu = m_Level;
                    }
                }
            }
        }

        private int checkUserChoiceValid(int i_MinValue, int i_MaxValue)
        {
            string backOrExit = m_Level == 0 ? "Exit" : "Back";
            Console.WriteLine($"Enter Your Request: (1 to {CurrentMenuItemHolder?.MenuItems.Count} or press 0 to {backOrExit})");
            string indexSelected = Console.ReadLine();
            int indexNumber;
            bool isFormatValid = int.TryParse(indexSelected, out indexNumber);

            if(isFormatValid == false)
            {
                throw new FormatException("Need to be made only by numbers!");
            }
            
            if(indexNumber < i_MinValue || indexNumber > i_MaxValue)
            {
                throw new IndexOutOfRangeException($"The number should be between {i_MinValue} and {i_MaxValue}");
            }

            return indexNumber;
        }
    }
}
