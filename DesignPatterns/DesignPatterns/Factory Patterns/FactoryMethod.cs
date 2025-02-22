using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factory_Patterns.AbstractFactory;

namespace Factory_Patterns
{
    internal class FactoryMethod
    {
        public NavigationBar navigationBar = new NavigationBar();
        public DropdownMenu dropdownMenu = new DropdownMenu();
        public AndroidNavigationBar dropdownMenus = new AndroidNavigationBar();
        public AndroidDropdownMenu dropdownMenau = new AndroidDropdownMenu();

        public abstract class Element
        {
            protected abstract Button CreateButton();

            public Element() => CreateButton();
        }

        public class NavigationBar : Element
        {
            protected override Button CreateButton()
            {
                return new Button { Type = "Default Button"};
            }
        }

        public class DropdownMenu : Element
        {
            protected override Button CreateButton()
            {
                return new Button { Type = "Default Button"};
            }
        }

        public class AndroidNavigationBar : Element
        {
            protected override Button CreateButton()
            {
                return new Button { Type = "Android Button" };
            }
        }

        public class AndroidDropdownMenu : Element
        {
            protected override Button CreateButton()
            {
                return new Button { Type = "Android Button" };
            }
        }

        public class Button
        {
            public string Type { get; set; }
        }
    }
}
