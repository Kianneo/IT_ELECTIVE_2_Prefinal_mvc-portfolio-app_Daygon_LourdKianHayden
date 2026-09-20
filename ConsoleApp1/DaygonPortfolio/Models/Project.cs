namespace DaygonPortfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}