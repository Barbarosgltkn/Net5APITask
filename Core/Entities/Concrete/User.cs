using Core.Entities.Concrete.Enums;
using DataAccess.Entities.Enums;

namespace Core.Entities.Concrete
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public bool IsBlocked { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public UserClaim UserClaim { get; set; }       
    }
}
