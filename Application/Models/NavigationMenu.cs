namespace ToolKitV.Models
{
    public class NavigationMenu
    {
        public class Option
        {
            public string Name { get; set; }
            public string IconPath { get; set; }
            public string ViewName { get; set; }
            public bool Enabled { get; set; }
        }
    }
}
