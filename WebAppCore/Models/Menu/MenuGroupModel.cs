using WebAppCore.Models.NevigationMenu;

namespace WebAppCore.Models.Menu
{
    public class MenuGroupModel
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
        public string? ClassIcon { get; set; }
        public string? ClassColor { get; set; }

        public List<MenuModel> MenuModelList { get; set; }

        public MenuGroupModel()
        {
            MenuModelList = new List<MenuModel>();
        }
    }
}
