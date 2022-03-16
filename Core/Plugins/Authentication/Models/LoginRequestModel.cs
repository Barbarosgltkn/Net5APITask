using Core.Entities.Concrete;

namespace Core.Plugins.Authentication.Models
{
    public class LoginRequestModel : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}