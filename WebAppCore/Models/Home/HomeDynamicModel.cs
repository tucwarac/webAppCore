namespace WebAppCore.Models.Home
{
    public class HomeDynamicModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public object Model { get; set; } = null!;

        public HomeDynamicModel()
        {
            Model = new object();
        }
    }
}
