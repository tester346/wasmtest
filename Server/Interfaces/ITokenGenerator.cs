using wasm.Shared.DTOs;

namespace wasm.Server.Interfaces
{
    interface IUserTokenGenerator
    {
        UserDTO GenerateTokenForUser(User user, string secret);
    }
}
