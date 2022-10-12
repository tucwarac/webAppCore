using WebAppCore.Helpers.Home;
using WebAppCore.Models.BlockModule;
using WebAppCore.Models.Home;
using WebAppCore.Models.Menu;
using WebAppCore.Models.NevigationMenu;
using System.Drawing;
using System.Security.Cryptography.Xml;

namespace WebAppCore.Helpers.Home
{
    public class HomeHelper
    {
        public async Task<HomeModel> HomeGetModel()
        {
            HomeModel homeModel = new HomeModel();

            //Mockup data 1
            HomeDynamicModel homeDynamicModel = new HomeDynamicModel();
            homeDynamicModel.Id = 1;
            homeDynamicModel.Name = "BlockModule";
            homeDynamicModel.Model = await BlockModuleGet();
            homeModel.HomeDynamicModelList.Add(homeDynamicModel);

            //Mockup data 2
            HomeDynamicModel homeDynamicModel2 = new HomeDynamicModel();
            homeDynamicModel2.Id = 2;
            homeDynamicModel2.Name = "FirstPage";
            homeModel.HomeDynamicModelList.Add(homeDynamicModel2);

            //Set default
            homeModel.HomeDynamicModelIdChoosed = 1;

            return homeModel;
        }

        public async Task<List<MenuGroupModel>> MenuGet()
        {
            var MenuGroupModelList = new List<MenuGroupModel>();

            //Mockup data
            List<MenuModel> menuModel1 = new List<MenuModel> {
                new MenuModel { Id = 110, Order = 1, Name = "Setting", Text="Setting", ActionName = "Index", ControllerName="Setting", AreaName = "Administrator", AreaText = "Administrator", ClassIcon = "fas fa-cog", ClassColor = "btn btn-info"},
                new MenuModel { Id = 120, Order = 2, Name = "Authentication", Text="Authen", ActionName = "Index", ControllerName="Authentication", AreaName = "Administrator", AreaText = "Administrator", ClassIcon = "fas fa-user-check", ClassColor = "btn btn-info" },
                new MenuModel { Id = 130, Order = 3, Name = "Authorization", Text="Authorize", ActionName = "Index", ControllerName="Authorization", AreaName = "Administrator", AreaText = "Administrator", ClassIcon = "fas fa-users-cog", ClassColor = "btn btn-info" },
            };
            var menuGroupModel1 = new MenuGroupModel();
            menuGroupModel1.Id = 100;
            menuGroupModel1.Order = 1;
            menuGroupModel1.Name = "Administrator";
            menuGroupModel1.Text = "Administrator";
            menuGroupModel1.ClassIcon = "fas fa-user-lock";
            menuGroupModel1.ClassColor = "btn btn-info";
            menuGroupModel1.MenuModelList = menuModel1;
            MenuGroupModelList.Add(menuGroupModel1);

            //Mockup data
            List<MenuModel> menuModel2 = new List<MenuModel> {
                new MenuModel { Id = 210, Order = 1, Name = "Dashboard", Text="Dashboard", ActionName = "Index", ControllerName="Home", AreaName = "Requestment", AreaText = "Requestment", ClassIcon = "fas fa-chart-pie", ClassColor = "btn btn-purple" },
                new MenuModel { Id = 220, Order = 2, Name = "Inbound", Text="Inbound", ActionName = "Index", ControllerName="Inbound", AreaName = "Requestment", AreaText = "Requestment", ClassIcon = "fas fa-arrow-down", ClassColor = "btn btn-purple" },
                new MenuModel { Id = 230, Order = 3, Name = "Outbound", Text="Outbound", ActionName = "Index", ControllerName="Outbound", AreaName = "Requestment", AreaText = "Requestment", ClassIcon = "fas fa-arrow-up", ClassColor = "btn btn-purple" },
                new MenuModel { Id = 240, Order = 4, Name = "Report", Text="Report", ActionName = "Index", ControllerName="Report", AreaName = "Requestment", AreaText = "Requestment", ClassIcon = "fas fa-file-alt", ClassColor = "btn btn-purple" },
            };
            var menuGroupModel2 = new MenuGroupModel();
            menuGroupModel2.Id = 200;
            menuGroupModel2.Order = 2;
            menuGroupModel2.Name = "Requestment";
            menuGroupModel2.Text = "Requestment";
            menuGroupModel2.ClassIcon = "fas fa-clipboard-list";
            menuGroupModel2.ClassColor = "btn btn-purple";
            menuGroupModel2.MenuModelList = menuModel2;
            MenuGroupModelList.Add(menuGroupModel2);

            //Mockup data looping
            for (int i = 3; i < 10; i++)
            {
                List<MenuModel> menuModelNList = new List<MenuModel>();
                for (int n = 0; n < 6; n++)
                {
                    var menuModel = new MenuModel { Id = Convert.ToInt32(string.Format("{0}{1}0", i, n)), Order = (n + 1), Name = string.Format("Menu", n + 1), Text = string.Format("Menu", n + 1), ActionName = "Index", ControllerName = "Report", AreaName = "Requestment", AreaText = "Requestment", ClassIcon = "fas fa-mug-hot", ClassColor = "btn btn-inverse" };
                    menuModelNList.Add(menuModel);
                }
                
                var menuGroupModelN = new MenuGroupModel();
                menuGroupModelN.Id = Convert.ToInt32(string.Format("{0}00", i));
                menuGroupModelN.Order = i;
                menuGroupModelN.Name = string.Format("Module{0}",i);
                menuGroupModelN.Text = string.Format("Module{0}", i);
                menuGroupModelN.ClassIcon = "fas fa-mug-hot";
                menuGroupModelN.ClassColor = "btn btn-inverse";
                menuGroupModelN.MenuModelList = menuModelNList;
                MenuGroupModelList.Add(menuGroupModelN);
            }

            return await Task.Factory.StartNew(() =>
            {
                return MenuGroupModelList;
            });
        }

        public async Task<NavigationMenuModel> NavigationMenuGet()
        {
            var navigationMenuModel = new NavigationMenuModel();

            navigationMenuModel.MenuGroupModelList = await MenuGet();

            //Order sub of MenuModelList by order number
            foreach (var menuGroupModel in navigationMenuModel.MenuGroupModelList)
            {
                var menuModelListOrdered = menuGroupModel.MenuModelList.OrderBy(x => x.Order).ToList();
                menuGroupModel.MenuModelList = menuModelListOrdered;
            }

            //Order main MenuGroupModelList by order number
            var menuGroupModelListOrdered = navigationMenuModel.MenuGroupModelList.OrderBy(x => x.Order).ToList();
            navigationMenuModel.MenuGroupModelList = menuGroupModelListOrdered;

            return navigationMenuModel;
        }

        public async Task<object> BlockModuleGet()
        {
            object dynamicModel = new object();

            BlockModuleModel blockModuleModel = new BlockModuleModel();
            blockModuleModel.GridColRow = 4; //12 is the max number
            blockModuleModel.GridColBox = 12 / blockModuleModel.GridColRow;
            blockModuleModel.ButtonRoundSize = 0.8;

            //
            List<MenuGroupModel> menuGroupModelList = new List<MenuGroupModel>();
            menuGroupModelList = await MenuGet();

            //
            const int heightPerOneRow = 125;
            int maxOfAllMinHeight = 0;
            //Order sub of MenuModelList by order number
            foreach (var menuGroupModel in menuGroupModelList)
            {
                var menuModelListOrdered = menuGroupModel.MenuModelList.OrderBy(x => x.Order).ToList();
                menuGroupModel.MenuModelList = menuModelListOrdered;

                //calculate for get the minHeight, the number 125 is height by 1 row
                var isRoundUp = ((menuGroupModel.MenuModelList.Count() / blockModuleModel.GridColBox) * blockModuleModel.GridColBox == menuGroupModel.MenuModelList.Count()) ? false : true;
                var minHeight = (isRoundUp) ? ((menuGroupModel.MenuModelList.Count() / blockModuleModel.GridColBox) + 1) * heightPerOneRow : (menuGroupModel.MenuModelList.Count() / blockModuleModel.GridColBox) * heightPerOneRow;
                if (minHeight > maxOfAllMinHeight)
                {
                    maxOfAllMinHeight = minHeight;
                }
            }

            //Order main MenuGroupModelList by order number
            var menuGroupModelListOdered = menuGroupModelList.OrderBy(x => x.Order).ToList();
            menuGroupModelList = menuGroupModelListOdered;

            //
            var blockModuleRowClassGrid = GetGrid(blockModuleModel.GridColRow);
            var blockModuleBoxClassGrid = GetGrid(blockModuleModel.GridColBox);
            var blockModuleBoxStyleButtonRound = blockModuleModel.ButtonRoundSize;

            //
            var blockModuleRowModel = new BlockModuleRowModel();
            blockModuleRowModel.ClassGrid = blockModuleRowClassGrid;

            foreach (var menuGroupModel in menuGroupModelList)
            {
                var blockModuleBoxModel = new BlockModuleBoxModel();
                blockModuleBoxModel.ClassGrid = blockModuleBoxClassGrid;
                blockModuleBoxModel.StyleMinHeight = string.Format("min-height: {0}px;", maxOfAllMinHeight);
                blockModuleBoxModel.StyleButtonRounded = string.Format("border-radius: {0}rem !important;", blockModuleBoxStyleButtonRound);

                blockModuleBoxModel.Order = menuGroupModel.Order;
                blockModuleBoxModel.Text = menuGroupModel.Text;
                blockModuleBoxModel.ClassIcon = menuGroupModel.ClassIcon;

                foreach (var MenuModel in menuGroupModel.MenuModelList)
                {
                    blockModuleBoxModel.MenuModelList.Add(MenuModel);
                }

                blockModuleRowModel.BlockModuleBoxList.Add(blockModuleBoxModel);
            }

            blockModuleModel.BlockModuleRowList.Add(blockModuleRowModel);

            //
            dynamicModel = blockModuleModel;

            return dynamicModel;
        }

        private string GetGrid(int splitNumber)
        {
            //12 is a max column of bootstrap grid
            int gridNumber = 12 / splitNumber;

            var gridClass = string.Format("col-sm-{0} col-md-{0} col-lg-{0} col-xl-{0}", gridNumber.ToString());

            return gridClass;
        }

    }
}
