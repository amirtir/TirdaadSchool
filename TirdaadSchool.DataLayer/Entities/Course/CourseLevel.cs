using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TirdaadSchool.DataLayer.Entities.Course
{
    public class CourseLevel
    {
        [Key]
        public int LevelId { get; set; }
        [MaxLength(50)]
        [Required]
        public string LevelName { get; set; }
        
        public List<Course> Courses { get; set; }
    }
}