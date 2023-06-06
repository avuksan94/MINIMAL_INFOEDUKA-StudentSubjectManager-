using ProjectTest02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Subject name is required")]
        [StringLength(500)]
        public string Name { get; set; }
        public string Carrier { get; set; }
        [Required(ErrorMessage = "The subject requires ECTS points!!")]
        [Range(1, 6, ErrorMessage = "ECTS points must be between 1 and 6")]
        public int Ects { get; set; }
        public ICollection<SubjectLecturer> SubjectLecturers { get; set; }

        public override string ToString() => $"{Name}";
    }
}
