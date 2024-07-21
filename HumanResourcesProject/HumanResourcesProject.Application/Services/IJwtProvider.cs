using HumanResourcesProject.Application.Features.Auth.Login;
using HumanResourcesProject.Domain.Entities;

namespace HumanResourcesProject.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
