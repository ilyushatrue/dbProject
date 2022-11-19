using Microsoft.AspNetCore.Identity;

namespace dbProj.Data.Identity
{
    public class ApplicationIdentityUser : IdentityUser
    {
        public long ApplicationId { get; set; }
    }
}
