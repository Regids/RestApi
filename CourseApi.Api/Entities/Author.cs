using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Api.Entidades
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string firstName { get; set; }
        public string lastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }
        public DateTimeOffset DateOfDeath { get; set; }

        [Required]
        [MaxLength(50)]

        public string MainCategory { get; set; }

        public ICollection<Course> Courses { get; set; }
            = new List<Course>();
    }
}
