using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MenuItemAction : MenuItem
    {
        public event Action Selected;

        public MenuItemAction(string i_Text) : base(i_Text) {}
        
        public void MenuItemSelected()
        {
            OnSelected();
        }

        protected virtual void OnSelected()
        {
            Selected?.Invoke();
        }
    }
}
