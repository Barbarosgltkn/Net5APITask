using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete.Enums
{
    public enum UserClaim
    {
        [Display(Name = "ADMIN")] ADMIN = 1,
        [Display(Name = "DEPARMENT")] DEPARMENT = 2,
        [Display(Name = "OTHER")] OTHER = 3,
    }
}
