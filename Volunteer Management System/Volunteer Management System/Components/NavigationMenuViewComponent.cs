using Microsoft.AspNetCore.Mvc;

namespace Volunteer_Management_System.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "Hello from the Nav View Component";
        }
    }
}
