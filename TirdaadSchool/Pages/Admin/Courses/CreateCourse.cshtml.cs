using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Entities.Course;

namespace TirdaadSchool.Web.Pages.Admin.Courses
{
    public class CreateCourse : PageModel
    {
        private ICourseService _courseService;

        public CreateCourse(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty] public Course Course { get; set; }

        public void OnGet()
        {
            var groups = _courseService.GetPrimeryGroupsForCoures();
            ViewData["PrimeryGroups"] = new SelectList(groups,"Value","Text");
            var subgroups = _courseService.GetSubGroupsForCourses(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subgroups,"Value","Text");
            
        }
    }
}