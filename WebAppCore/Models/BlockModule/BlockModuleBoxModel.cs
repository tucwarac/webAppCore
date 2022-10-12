using WebAppCore.Models.Menu;

namespace WebAppCore.Models.BlockModule
{
    public class BlockModuleBoxModel : MenuGroupModel
    {
        public int MaxColumn { get; set; }
        public string? ClassGrid { get; set; }
        public string? StyleMinHeight { get; set; }
        public string? StyleButtonRounded { get; set; }
    }
}
