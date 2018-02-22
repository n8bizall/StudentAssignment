using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentAssignment
{
    public class CollegeOfStudent
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)][Required]
        public string MyProperty { get; set; }

        [MaxLength(30)]
        public string Major { get; set; }

        [Required]
        public int GradYear { get; set; }

        [Required]
        public bool GradWithHonors { get; set; }

        public bool AlumniDoner { get; set; }
    }
}
