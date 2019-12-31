using wasm.Server.Interfaces;
using wasm.Shared.DTOs;

namespace wasm.Server.Services
{
    public class JWTService : IUserTokenGenerator
    {
        public UserDTO GenerateTokenForUser(User user, string secret)
        {
            throw new System.NotImplementedException();
        }
    }
}