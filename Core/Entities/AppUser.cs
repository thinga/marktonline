using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities
{
    public class AppUser : IdentityUser
    {
        public string DisplayName {get; set; }
         public int HandyNumber { get; set; }

        public Addresse Addresse { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LasActive { get; set; } = DateTime.Now;
       

        public ICollection<UserPhoto> UserPhotos { get; set; }



        
    }
}