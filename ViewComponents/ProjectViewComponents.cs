using Microsoft.AspNetCore.Mvc;
using mvc_first.Models;

namespace mvc_first.ViewComponents
{
    public class ProjectViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var _projrct = new List<Project>
            {
                new Project(1, "مقاله اول", "گوشی اول","~/images/project/project-1.jpg"),
                new Project(2, "مقاله دوم", "گوشی دوم","~/images/project/project-2.jpg"),
                new Project(3, "مقاله سوم", "گوشی سوم","~/images/project/project-3.jpg"),
                new Project(4, "مقاله چهارم", "گوشی چهارم","~/images/project/project-4.jpg")
            };
            return View("_Project", _projrct);



        }
    }
}
