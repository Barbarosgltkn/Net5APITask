using DataAccess.Entities.Enums;

namespace Core.Plugins.Authentication.Models
{
    public class RegisterRequestModel
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }      
        public bool IsBlocked { get; set; }
        public int UserClaim { get; set; }
    }
}