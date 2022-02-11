using AutoMapper;
using ClientForGRPC.Models.Login;
using gRPCTest.Protos;
using Models.User;
using System.Collections.Generic;

namespace Mapper
{
    public class DtoToProto : Profile
    {
        public DtoToProto()
        {
            CreateMap<UserDto, UserProDto>().ReverseMap();
            CreateMap<UserCreateDto, CreateUserRequest>().ReverseMap();
            CreateMap<UserCreateResultDto, UserCreateResultProtoDto>().ReverseMap();
            CreateMap<UserUpdateDto, UpdateUserRequest>().ReverseMap();
            CreateMap<UserUpdateResultDto, UserUpdateResultProtoDto>().ReverseMap();
            CreateMap<ListUserProDto, List<UserDto>>().ReverseMap();

            CreateMap<LoginDto, GetUserLoginRequest>().ReverseMap();
        }
    }
}
