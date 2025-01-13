using AuthAPI.Models.Dtos;

namespace AuthAPI.Services.IService
{
    public interface IAuth
    {
        Task<object> Login(LoginRequestDto loginRequestDto);
        Task<object> Register(RegisterRequestDto registerRequestDto);

    }
}
