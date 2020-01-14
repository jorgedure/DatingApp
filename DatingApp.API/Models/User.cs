using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id {get;set;}
        public string UserName {get;set;}
        public byte[] HashPassword {get; set;} 
        public byte[] SaltPassword {get; set;}
        public string Gender { get; set; }
        public DateTime DateOfBirdh { get; set; }
        public string KnowsnAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookinFor { get; set; }
        public string Intereses { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}