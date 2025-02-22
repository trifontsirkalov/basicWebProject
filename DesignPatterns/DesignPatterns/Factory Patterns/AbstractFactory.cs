using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Patterns
{
    //Common example iss the switch between White and Dark modes in different UIs
    public class AbstractFactory
    {
        public NavigationBarA navigationBarA = new NavigationBarA(new Android());
        public DropdownMenuA dropdownMenu = new DropdownMenuA(new Android());

        public class NavigationBarA
        {
            public NavigationBarA(IUIFactory factory) => factory.CreateButton();
        }

        public class DropdownMenuA
        {
            public DropdownMenuA(IUIFactory factory) => factory.CreateButton();
        }

        public interface IUIFactory
        {
            public ButtonA CreateButton();
        }

        public class Apple : IUIFactory
        {
            public ButtonA CreateButton()
            {
                return new ButtonA { Type = "iOS Button" };
            }
        }

        public class Android : IUIFactory
        {
            public ButtonA CreateButton()
            {
                return new ButtonA { Type = "Android Button" };
            }
        }

        public class ButtonA
        {
            public string Type { get; set; }
        }
    }
}
