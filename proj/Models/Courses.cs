﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj.Models
{
    [Table("tblCourses")]
    public class Courses
    {
        [Required]
        [Key,Column(Order = 0)]
        [RegularExpression("^[0-9]{1}$", ErrorMessage = "Course Id must be at least 1 digits")]
        public string CourseId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Course name must be between 4 and 50")]
        public string CourseName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Day must be sunday-friday")]
        public string Day { get; set; }
        [Required]
        [RegularExpression("^([01][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Start Hour must be at hh:mm")]
        public TimeSpan SHour { get; set; }  
        [Required]
        [RegularExpression("^[a-zA-z][0-9]$", ErrorMessage = "room must be a-z letter and 100-1000 number")]
        public string Room { get; set; }
        [Required]
        [RegularExpression("^([01][0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "End Hour must be at hh:mm")]
        public TimeSpan EHour { get; set; }

    }
}