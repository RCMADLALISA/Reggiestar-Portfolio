namespace Reginald_Madlalisa_Portfolio.Models
{
    public class PortfolioViewModel
    {
        public PersonalInfo PersonalInfo { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
    }

    public class PersonalInfo
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public string Email { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }
        public string Location { get; set; }
        public string CVPath { get; set; }
        public string ProfilePicturePath { get; set; }
    }

    public class Skill
    {
        public string Category { get; set; }
        public List<string> Items { get; set; }
    }

    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string Link { get; set; }
        public string ImagePath { get; set; }
    }
}