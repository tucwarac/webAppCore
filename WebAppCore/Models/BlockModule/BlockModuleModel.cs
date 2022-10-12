namespace WebAppCore.Models.BlockModule
{
    public class BlockModuleModel
    {
        public int GridColRow { get; set; }
        public int GridColBox { get; set; }
        public double ButtonRoundSize { get; set; }
        public List<BlockModuleRowModel> BlockModuleRowList { get; set; }

        public BlockModuleModel()
        {
            BlockModuleRowList = new List<BlockModuleRowModel>();
        }
    }
}
