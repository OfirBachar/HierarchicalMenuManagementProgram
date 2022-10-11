using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        public string Text { get; set; }

        protected MenuItem(string i_Text)
        {
            Text = i_Text;
        }
    }
}
