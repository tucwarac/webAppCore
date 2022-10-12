using WebAppCore.Models.NevigationMenu;

namespace WebAppCore.Models.Home
{
    public class HomeModel
    {
        public int HomeDynamicModelIdChoosed { get; set; }
        public List<HomeDynamicModel> HomeDynamicModelList { get; set; }

        public HomeModel()
        {
            HomeDynamicModelList = new List<HomeDynamicModel>();
        }
    }
}
