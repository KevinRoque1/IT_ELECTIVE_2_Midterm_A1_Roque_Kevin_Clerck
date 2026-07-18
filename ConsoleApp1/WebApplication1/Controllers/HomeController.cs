using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Home";
        ViewData["Greeting"] = "Hello, I'm";
        ViewData["FullName"] = "Roque, Kevin Clerck A.";
        ViewData["JobTitle"] = "Aspiring Software Developer";
        ViewData["Intro"] = "I'm a 3rd-year Information Technology student who enjoys building clean, practical web applications. I like turning ideas into working software and I'm always looking for opportunities to learn new tools and frameworks.";
        ViewData["ProfileImage"] = "~/images/pictureportfolio.png";
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Me";
        ViewData["Tagline"] = "Get to know my background and goals";
        ViewData["AboutParagraph1"] = "I'm an Information Technology student from Lyceum of Alabang with a strong interest in web development and software engineering. Over the past two years, I've been studying front-end and back-end development, from building console programs to simple static sites using HTML, CSS and built-in programs in MS Access.";
        ViewData["AboutParagraph2"] = "I'm currently pursuing a Bachelor of Science in Information Technology, and my goal is to land an entry-level developer role where I can keep growing my skills, work alongside experienced engineers, and eventually specialize in full-stack development.";
        ViewData["EducationDegree"] = "BS Information Technology";
        ViewData["EducationYears"] = "2023 - Present";
        ViewData["CareerGoal"] = "Land an entry-level developer role and grow into a full-stack engineer.";
        return View();
    }

    public IActionResult Skills()
    {
        ViewData["Title"] = "Skills";
        ViewData["Tagline"] = "Languages, frameworks, and tools I work with";
        ViewData["ProgrammingSkills"] = new List<string> { "C#", "Python", "Java", "VB.NET" };
        ViewData["WebSkills"] = new List<string> { "ASP.NET Core MVC", "HTML5 & CSS3", "Bootstrap 5" };
        ViewData["DatabaseSkills"] = new List<string> { "Microsoft Access" };
        ViewData["ToolSkills"] = new List<string> { "Git & GitHub", "Visual Studio", "VS Code" };
        return View();
    }

    public IActionResult Projects()
    {
        ViewData["Title"] = "Projects";
        ViewData["Tagline"] = "A few things I've built";

        ViewData["Project1Title"] = "Student Portal System";
        ViewData["Project1Desc"] = "A web app for managing student records, grades, and enrollment for a small school.";
        ViewData["Project1Badge"] = "C#";
        ViewData["Project1Link"] = "https://github.com/KevinRoque1/BSIT31E1_PRELIM_H1_ROQUE_KEVIN_CLERCK";

        ViewData["Project2Title"] = "Loan Calculator";
        ViewData["Project2Desc"] = "A Windows Forms Application where customers can take a loan.";
        ViewData["Project2Badge"] = "VB.NET";

        ViewData["Project3Title"] = "Visual Design Portfolio";
        ViewData["Project3Desc"] = "A pixel-art themed personal portfolio page showcasing an About Me, image gallery, and academic activities, designed to highlight visual and layout design skills.";
        ViewData["Project3Badges"] = new List<string> { "Photoshop", "HTML", "CSS" };

        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact";
        ViewData["Tagline"] = "Let's get in touch";
        ViewData["Email"] = "kcofficial14@gmail.com";
        ViewData["Phone"] = "+63 912 345 6789";
        ViewData["PhoneDisplay"] = "+63 912 345 6789";
        ViewData["GitHubUrl"] = "https://github.com/KevinRoque1";
        ViewData["GitHubDisplay"] = "github.com/KevinRoque1";
        ViewData["LinkedInUrl"] = "https://www.linkedin.com/in/kevin-clerck-roque-a82904422/";
        ViewData["LinkedInDisplay"] = "linkedin.com/in/kevin-clerck-roque-a82904422/";
        ViewData["FacebookUrl"] = "https://www.facebook.com/kcers.roque.2024/";
        ViewData["FacebookDisplay"] = "facebook.com/kcers.roque.2024/";
        ViewData["ResumeFile"] = "~/files/resume.pdf";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Title"] = "Privacy Policy";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}