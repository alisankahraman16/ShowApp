namespace ShowsApp.Models
{
    public class ShowViewModel
    {
        public List<Show> Shows { get; set; } = null!;
        public List<Category> Categories { get; set; } = null!;   
        public string? SelectedCategory { get; set; }
    }
}