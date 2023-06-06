using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02.Models
{
    public class SubjectNotification
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
    }
}
