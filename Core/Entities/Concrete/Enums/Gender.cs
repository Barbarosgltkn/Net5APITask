using System.ComponentModel.DataAnnotations;


namespace DataAccess.Entities.Enums
{
    public enum Gender
    {
        [Display(Name = "FEMALE")] FEMALE = 1,
        [Display(Name = "MALE")] MALE = 2,
        [Display(Name = "OTHER")] OTHER = 3,

    }
}
