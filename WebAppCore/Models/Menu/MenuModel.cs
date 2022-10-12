namespace WebAppCore.Models.Menu
{
    public class MenuModel
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
        public string? ActionName { get; set; }
        public string? ControllerName { get; set; }
        public string? AreaName { get; set; }
        public string? AreaText { get; set; }
        public string? ClassIcon { get; set; }
        public string? ClassColor { get; set; }
    }
}
