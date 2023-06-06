using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02
{
    public class Lecturer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression("^[^0-9{}()_+=*&^%$#@!]+$", ErrorMessage = "Name cannot contain numbers or special characters")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression("^[^0-9{}()_+=*&^%$#@!]+$", ErrorMessage = "Surname cannot contain numbers or special characters")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        public ICollection<SubjectLecturer> SubjectLecturers { get; set; }

        public override string ToString() => $"{Name} {Surname}";
    }
}
