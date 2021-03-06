using Microsoft.AspNetCore.Identity;

namespace NT_Model.Entity
{
    public class AppUser : IdentityUser, IBaseEntity
    {
        public string NickName { get; set; }

        public int Sex { get; set; }
        
        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }

        public WeChatInfo WeChatInfo { get; set; } 
    }
}