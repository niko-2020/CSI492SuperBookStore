using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CRWBookStore.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the CRWBookStoreUser class
    public class CRWBookStoreUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        //public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }


    }
}
