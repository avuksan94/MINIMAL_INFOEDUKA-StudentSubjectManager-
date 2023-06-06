using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02
{
    public class SubjectLecturer
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
    }
}
