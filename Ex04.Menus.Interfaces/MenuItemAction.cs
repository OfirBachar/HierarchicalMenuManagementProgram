using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItemAction : MenuItem
    {
        private readonly List<IOwnerMenuListener> r_Listeners;

        public MenuItemAction(string i_Text) : base(i_Text)
        {
            r_Listeners = new List<IOwnerMenuListener>();
        }

        public void AttachObserver(IOwnerMenuListener i_Observer)
        {
            r_Listeners.Add(i_Observer);
        }

        public void DetachObserver(IOwnerMenuListener i_ObserverToRemove)
        {
            r_Listeners.Remove(i_ObserverToRemove);
        }

        public void MenuItemSelected()
        {
            invokeAction();
        }

        private void invokeAction()
        {
            foreach (IOwnerMenuListener dateTimeListener in r_Listeners)
            {
                dateTimeListener.DoCommandAfterChosen();
            }
        }
    }
}
