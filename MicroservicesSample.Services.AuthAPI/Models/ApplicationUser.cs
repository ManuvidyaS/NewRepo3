using Microsoft.AspNetCore.Identity;

namespace MicroservicesSample.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
