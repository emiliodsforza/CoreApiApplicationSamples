using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "The Title must be different than the Description")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out the Title")]
        [MaxLength(100, ErrorMessage = "The Title shouldn't have than 100 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You should fill out the Description")]
        [MaxLength(1500, ErrorMessage = "The Description shouldn't have more 1500 characters")]
        public virtual string Description { get; set; }
    }
}
