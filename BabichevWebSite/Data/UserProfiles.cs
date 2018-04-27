using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabichevWebSite.Data
{
    public class UserProfiles
    {
        [Key]
        public int UserId { get; set; }
    }
}
