using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wasm.Server.Services
{
    public class UserService
    {
        private readonly Context _context;
        private readonly JWTService _jwt;

        public UserService(JWTService jwt, Context context)
        {
            _jwt = jwt;
            _context = context;
        }
    }
}
