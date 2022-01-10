using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Identity
{
    public class AppUser : IdentityUser
    {
        public string DisplayName {get; set; }
         public string HandyNumber { get; set; }

        public Address Address { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LasActive { get; set; } = DateTime.Now;
       

        public ICollection<UserPhoto> UserPhotos { get; set; }



        
    }
}