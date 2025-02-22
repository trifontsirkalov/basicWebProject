
// Am I Creating something in two places identicaly. If so just create it in one place 


new NavigationBar();
new DropdownMenu();


public class NavigationBar
{
    public NavigationBar() => ButtonFactory.CreateButton();
}

public class DropdownMenu
{
    public DropdownMenu() => ButtonFactory.CreateButton();
}

public class ButtonFactory
{
    public static Button CreateButton()
    {
        return new Button { Type = "Red Button" };
    }
}

public class Button
{
    public string Type { get; set; }
}