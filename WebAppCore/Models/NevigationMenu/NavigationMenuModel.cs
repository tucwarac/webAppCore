using WebAppCore.Models.Menu;

namespace WebAppCore.Models.NevigationMenu
{
    public class NavigationMenuModel : MenuGroupModel
    {
        public List<MenuGroupModel> MenuGroupModelList { get; set; }

        public NavigationMenuModel()
        {
            MenuGroupModelList = new List<MenuGroupModel>();
        }
    }
}
