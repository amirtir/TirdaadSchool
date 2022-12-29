using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TirdaadSchool.DataLayer.Entities.Course
{
    public class CourseEpisode
    {
        [Required]
        [Key]
        public int EpisodeId { get; set; }
        
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [DisplayName("عنوان بخش")]
        public string EpisodeTitle { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DisplayName("زمان بخش")]
        public TimeSpan EpisodeTime { get; set; }

        [DisplayName("فایل")]
        public string EpisodeFileName { get; set; }

        [DisplayName("رایگان")]
        public bool IsFree { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}