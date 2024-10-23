using MicroservicesSample.Services.AuthAPI.Models;

namespace MicroservicesSample.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser);
    }
}
