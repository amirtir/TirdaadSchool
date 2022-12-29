using Microsoft.AspNetCore.Mvc;
using TirdaadSchool.Core.Services.Interfaces;

namespace TirdaadSchool.ViewComponents
{
            
    public class CourseGroupComponent: ViewComponent
    {
        private ICourseService _courseService;

        public CourseGroupComponent(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            return (IViewComponentResult)View("CourseGroupView",_courseService.GetCourseGroups());
        }
    }
}