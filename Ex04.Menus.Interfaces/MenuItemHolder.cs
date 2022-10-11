using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItemHolder : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;

        public int LevelOfMenu { get; set; }

        public List<MenuItem> MenuItems => r_MenuItems;

        public MenuItemHolder(string i_TextItem) : base(i_TextItem)
        {
            r_MenuItems = new List<MenuItem>();
            LevelOfMenu = 0;
        }

        public override string ToString()
        {
            int index = 1;
            StringBuilder menuBuilderMsg = new StringBuilder();
            
            menuBuilderMsg.AppendLine(Text);
            menuBuilderMsg.AppendLine("------------------------");

            foreach(MenuItem menuItem in r_MenuItems)
            {
                menuBuilderMsg.AppendLine($"{index} -> {menuItem.Text}");
                index++;
            }

            menuBuilderMsg.AppendLine(LevelOfMenu == 0 ? "0 -> Exit" : "0 -> Back");
            menuBuilderMsg.AppendLine("------------------------");

            return menuBuilderMsg.ToString();
        }
    }
}
