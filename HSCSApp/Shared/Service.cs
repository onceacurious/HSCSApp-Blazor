namespace HSCSApp.Shared
{
    public class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
    }
}