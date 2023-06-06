using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02.Models
{
    public class Notification
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public DateTime PostTime{ get; set; }
        public DateTime ExperationTime { get; set; }
        public string  SenderEmail { get; set; }


        public override string ToString() => $"{Id}, {Title}, {Description}, {PostTime.ToString()}, {ExperationTime.ToString()}";
    }
}
