using Microsoft.AspNetCore.Mvc;
using Reginald_Madlalisa_Portfolio.Models;
using System.Diagnostics;

namespace Reginald_Madlalisa_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new PortfolioViewModel
            {
                PersonalInfo = new PersonalInfo
                {
                    Name = "Reginald Cebisile Madlalisa",
                    Title = "IT Graduate",
                    Introduction = "Welcome To My Digital Space. " +
                    " As a Passionate IT professional specializing in modern techs like Networks, Data Analysis, Database, System design 1 & 2, Website Development and innovative digital solutions. And with a strong foundation in IT, I am passionate about leveraging technology to create seamless, efficient, and future ready systems. Whether it's designing user-friendly websites, optimizing networks, or exploring the latest techs trends, My goal is to bring innovative ideas to Life. "
                     + "Feel free to explore my work, and let's connect to build something extraordinary!!!",
                    Email = "madlalisar@gmail.com",
                    GitHub = "https://github.com/RCMADLALISA",
                    LinkedIn = "https://linkedin.com/in/reginald-cebisile-madlalisa-08a192324",
                    Location = "Your Location",
                    CVPath = "/CV/Reginald_Cebisile_Madlalisa_CV.pdf",
                    ProfilePicturePath = "/images/profile-picture.jpg"
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Category = "Technical Skills",
                        Items = new List<string> { "C#", ".NET Core", "SQL Server", "HTML/CSS", "Git" }
                    },
                    new Skill
                    {
                        Category = "Soft Skills",
                        Items = new List<string> { "Problem Solving", "Team Collaboration", "Communication", "Project Management", "Time management", "Team player" }
                    },
                    new Skill
                    {
                        Category = "Tools & Technologies",
                        Items = new List<string> { "Visual Studio", "Azure", "GitHub", "BlueJ", "CodeBlocks" }
                    }
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Project 1",
                        Description = "In progress, we'll be updated in due time, and there are all the techs i'll be using",
                        Technologies = new List<string> { "ASP.NET Core", "SQL Server", "Bootstrap" },
                        Link = "#",
                        ImagePath = "/images/project1.jpg"
                    },
                    new Project
                    {
                        Title = "Project 2",
                        Description = "In progress, we'll be updated in due time, and there are all the techs i'll be using",
                        Technologies = new List<string> { "React", "Node.js", "MongoDB" },
                        Link = "#",
                        ImagePath = "/images/project2.jpg"
                    }
                }
            };

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}