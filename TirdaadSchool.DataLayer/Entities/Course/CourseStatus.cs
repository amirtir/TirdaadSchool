using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TirdaadSchool.DataLayer.Entities.Course
{
    public class CourseStatus
    {
        [Key]
        public int StatusId { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string StatusName { get; set; }

        public List<Course> Courses { get; set; }
    }
}