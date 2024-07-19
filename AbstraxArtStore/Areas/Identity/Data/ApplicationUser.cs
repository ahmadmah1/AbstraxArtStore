using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AbstraxArtStore.Models;
using Microsoft.AspNetCore.Identity;

namespace AbstraxArtStore.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Key] public int CustomerId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }


   

}

