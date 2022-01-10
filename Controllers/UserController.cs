using AutoMapper;
using ClientForGRPC.GrpcServices;
using gRPCTest.Protos;
using Mapper.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientForGRPC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserClientService serviceGrpc;
        private readonly IMapper mapper;

        public UserController(UserClientService serviceGrpc, IMapperGrpc mapper)
        {
            this.serviceGrpc = serviceGrpc;
            this.mapper = mapper.GetMapper();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            var result = await serviceGrpc.GetAll(new GetAttUserRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id) 
        {
            var result = await serviceGrpc.Get(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(UserCreateDto userCreate) 
        {
            CreateUserRequest userRequest = mapper.Map<CreateUserRequest>(userCreate);
            return Ok(await serviceGrpc.Post(userRequest));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id) 
        {
            return Ok(await serviceGrpc.Delete(id));
        }
    }
}
