using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using TirdaadSchool.Core.Services.Interfaces;
using TirdaadSchool.DataLayer.Context;
using TirdaadSchool.DataLayer.Entities.Course;

namespace TirdaadSchool.Core.Services
{
    public class CourseService:ICourseService
    {
        private MyDbContext _db;

        public CourseService(MyDbContext db)
        {
            _db = db;
        }
        public List<CourseGroup> GetCourseGroups()
        {
            return _db.CourseGroups.ToList();
        }

        public List<SelectListItem> GetPrimeryGroupsForCoures()
        {
            return _db.CourseGroups.Where(g => g.ParentId == null).Select(g => new SelectListItem()
            {
                Text = g.GroupName,
                Value = g.GroupId.ToString()
            }).ToList();
        }

        public List<SelectListItem> GetSubGroupsForCourses(int groupid)
        {
            return _db.CourseGroups.Where(g => g.ParentId == groupid).Select(g => new SelectListItem()
            {
                Text = g.GroupName,
                Value = g.GroupId.ToString()
            }).ToList();
        }
    }
}