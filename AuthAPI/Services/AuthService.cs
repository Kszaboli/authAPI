using AuthAPI.Models;
using AuthAPI.Models.Dtos;
using AuthAPI.Services.IService;

namespace AuthAPI.Services
{
    public class AuthService : IAuth
    {
        private readonly AppDBContext _appDBContext;

        public AuthService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public Task<object> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<object> Register(RegisterRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
