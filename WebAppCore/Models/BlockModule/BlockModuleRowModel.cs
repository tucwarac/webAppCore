using WebAppCore.Models.Menu;

namespace WebAppCore.Models.BlockModule
{
    public class BlockModuleRowModel
    {
        public int MaxColumn { get; set; }
        public string? ClassGrid { get; set; }
        public List<BlockModuleBoxModel> BlockModuleBoxList { get; set; }

        public BlockModuleRowModel()
        {
            BlockModuleBoxList = new List<BlockModuleBoxModel>();
        }
    }
}
