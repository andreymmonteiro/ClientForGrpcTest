using AutoMapper;
using ClientForGRPC.GrpcServices;
using gRPCTest.Protos;
using Mapper.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClientForGRPC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginClientService _login;
        private readonly IMapper _mapper;

        public LoginController(LoginClientService login, IMapperGrpc mapper)
        {
            _login = login;
            _mapper = mapper.GetMapper();
        }
        
        [HttpGet("user-login/{userName}/{password}")]
        public async Task<IActionResult> GetUserLogin(string userName, string password) 
        {
            var request = new GetUserLoginRequest() { UserName = userName, Password = password };
            var result = await _login.GetLogin(request);
            return Ok(result);
        }
    }
}
