using Microsoft.AspNetCore.Mvc;
using DaygonPortfolio.Models;

namespace DaygonPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "IT_ELECTIVE_2_Prefinal_mvc-portfolio-app",
                ShortDescription = "ASP.NET Core MVC Portfolio application featuring dynamic project listing and discussion system.",
                DetailedDescription = "Comprehensive ASP.NET Core MVC project showcasing modern UI layout, controller architecture, model binding, and interactive comments.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_Prefinal_mvc-portfolio-app_Daygon_LourdKianHayden",
                ImageUrl = "/image/1.jpg"
            },
            new Project
            {
                Id = 2,
                Title = "IT_ELECTIVE_2_PREFINAL_EXAM",
                ShortDescription = "Prefinal Examination implementation for IT Elective 2 - BSIT31E2.",
                DetailedDescription = "Hands-on prefinal examination repository demonstrating advanced C# backend logic and web design patterns.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_-BSIT31E2-_PREFINAL_EXAM_Daygon_LourdKian",
                ImageUrl = "/image/2.jpg"
            },
            new Project
            {
                Id = 3,
                Title = "IT_ELECTIVE_2_MIDTERM_EXAM_6",
                ShortDescription = "Midterm Examination Project 6 implementation.",
                DetailedDescription = "Midterm practical exam covering core web development principles, structured layout rendering, and front-end markup.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_MIDTERM_EXAM_6_DAYGON",
                ImageUrl = "/image/3.jpg"
            },
            new Project
            {
                Id = 4,
                Title = "IT_ELECTIVE_2_MIDTERM_Q3",
                ShortDescription = "Midterm Quiz 3 assessment repository for IT Elective 2.",
                DetailedDescription = "Repository submitted for Midterm Quiz 3, focusing on web interface design and HTML structural components.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_MIDTERM_Q3_Daygon_LourdKian",
                ImageUrl = "/image/4.jpg"
            },
            new Project
            {
                Id = 5,
                Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3",
                ShortDescription = "Midterm Hands-on Exercises 1, 2, and 3 compilation.",
                DetailedDescription = "Combined implementation of Midterm Hands-on tasks covering modular HTML layout and styling exercises.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Daygon",
                ImageUrl = "/image/5.jpg"
            },
            new Project
            {
                Id = 6,
                Title = "IT_ELECTIVE_2_MIDTERM_Q2",
                ShortDescription = "Midterm Quiz 2 template implementation.",
                DetailedDescription = "Implementation of Midterm Quiz 2 based on university template structure.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_MIDTERM_Q2_Daygon_LourdKian",
                ImageUrl = "/image/6.jpg"
            },
            new Project
            {
                Id = 7,
                Title = "IT_ELECTIVE_2_ModelBinding",
                ShortDescription = "ASP.NET Core MVC Model Binding demonstration for BSIT 31E2.",
                DetailedDescription = "Practice repository demonstrating how HTTP request data binds to C# model objects within ASP.NET Core MVC applications.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_ModelBinding_LourdKian_Daygon_BSIT_31E2",
                ImageUrl = "/image/7.jpg"
            },
            new Project
            {
                Id = 8,
                Title = "PersonalityTest",
                ShortDescription = "Interactive web-based personality assessment test.",
                DetailedDescription = "A clean web application that asks users questions and computes personality trait assessments dynamically.",
                GithubUrl = "https://github.com/Kianneo/PersonalityTest",
                ImageUrl = "/image/8.jpg"
            },
            new Project
            {
                Id = 9,
                Title = "IT_Elective_HACKATHON_4",
                ShortDescription = "IT Elective Hackathon 4 group challenge codebase.",
                DetailedDescription = "Collaborative C# solution created during Hackathon 4 focusing on rapid software implementation and problem solving.",
                GithubUrl = "https://github.com/Kianneo/IT_Elective_HACKATHON_4",
                ImageUrl = "/image/9.jpg"
            },
            new Project
            {
                Id = 10,
                Title = "IT_ELECTIVE_2_Midterm_A1",
                ShortDescription = "Midterm Assignment 1 web project submission.",
                DetailedDescription = "First midterm assignment repository focusing on fundamental web design and layout practices.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_Midterm_A1_Daygon_LourdKianHayden",
                ImageUrl = "/image/10.jpg"
            },
            new Project
            {
                Id = 11,
                Title = "ite-two-prelim-assignment-two",
                ShortDescription = "Prelim Assignment 2 implementation repository.",
                DetailedDescription = "C# programming assignment covering core software design requirements for Prelim Assignment 2.",
                GithubUrl = "https://github.com/Kianneo/ite-two-prelim-assignment-two-DAYGON-LOURDKIANHAYDEN",
                ImageUrl = "/image/11.jpg"
            },
            new Project
            {
                Id = 12,
                Title = "ite-two-prelim-assignment-one",
                ShortDescription = "Prelim Assignment 1 implementation repository.",
                DetailedDescription = "Initial preliminary course assignment focusing on basic project setups and algorithmic logic.",
                GithubUrl = "https://github.com/Kianneo/ite-two-prelim-assignment-one-daygon-lourdkianhayden",
                ImageUrl = "/image/12.jpg"
            },
            new Project
            {
                Id = 13,
                Title = "IT_ELECTIVE_2_PRELIM_EXAM",
                ShortDescription = "Prelim Examination hands-on coding exam.",
                DetailedDescription = "Hands-on preliminary examination covering initial course learning modules and coding standards.",
                GithubUrl = "https://github.com/Kianneo/IT_ELECTIVE_2_PRELIM_EXAM_DAYGON_LOURDKIANHAYDEN",
                ImageUrl = "/image/13.jpg"
            },
            new Project
            {
                Id = 14,
                Title = "HttpServer",
                ShortDescription = "Custom HTTP Server implementation built in C#.",
                DetailedDescription = "Low-level C# project building a custom HTTP server from scratch to handle socket connections and raw HTTP requests.",
                GithubUrl = "https://github.com/Kianneo/HttpServer",
                ImageUrl = "/image/14.jpg"
            },
            new Project
            {
                Id = 15,
                Title = "BSIT_31E2_PRELIM_Q1",
                ShortDescription = "Prelim Quiz 1 assessment repository.",
                DetailedDescription = "First preliminary quiz submission containing basic project structure and fundamental logic.",
                GithubUrl = "https://github.com/Kianneo/BSIT_31E2_PRELIM_Q1_Daygon_Kian",
                ImageUrl = "/image/15.jpg"
            }
        };

        public IActionResult Index()
        {
            return View(Projects);
        }

        public IActionResult Details(int id)
        {
            var project = Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();
            return View(project);
        }

        [HttpPost]
        public IActionResult AddComment(int projectId, string author, string text)
        {
            var project = Projects.FirstOrDefault(p => p.Id == projectId);
            if (project != null && !string.IsNullOrWhiteSpace(text))
            {
                project.Comments.Add(new Comment
                {
                    Id = project.Comments.Count + 1,
                    ProjectId = projectId,
                    Author = string.IsNullOrWhiteSpace(author) ? "Anonymous" : author,
                    Text = text,
                    CreatedAt = DateTime.Now
                });
            }
            return RedirectToAction("Details", new { id = projectId });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}