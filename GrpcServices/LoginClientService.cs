using gRPCTest.Protos;
using System.Threading.Tasks;

namespace ClientForGRPC.GrpcServices
{
    public class LoginClientService
    {
        private readonly Login.LoginClient _login;

        public LoginClientService(Login.LoginClient login)
        {
            _login = login;
        }
        public async Task<UserLoginProDto> GetLogin(GetUserLoginRequest request) 
        {
            return await _login.GetLoginAsync(request);
        }

    }
}
