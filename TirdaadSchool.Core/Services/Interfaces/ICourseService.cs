using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TirdaadSchool.DataLayer.Entities.Course;

namespace TirdaadSchool.Core.Services.Interfaces
{
    public interface ICourseService
    {
        List<CourseGroup> GetCourseGroups();
        List<SelectListItem> GetPrimeryGroupsForCoures();
        List<SelectListItem> GetSubGroupsForCourses(int groupid);
    }
}