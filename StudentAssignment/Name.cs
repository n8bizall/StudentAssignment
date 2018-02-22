using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentAssignment
{
    public class NameOfStudent
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(30)][Required]
        public string Name { get; set; }

        [Required]
        public int CollegeOfStudentId { get; set; }

        public virtual NameOfStudent Names { get; set; }

    }
}
