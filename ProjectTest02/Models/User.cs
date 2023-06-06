using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest02.Models
{
    public enum UserRole
    {
        Administrator,
        Lecturer

        //Trenutno su uvede samo ove dvije role,moguce je dodati trecu rolu ubuduce koja bi imala pristup admin dashbourdu ali je korisnik predavac
    }

    public class User
    {
        public UserRole Role { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }   
        public bool HasAccess { get; set; }
        public override string ToString() => $"{Role}, {Username}, {Password}, {HasAccess}";
    }
}
