using AutoMapper;
using gRPCTest.Protos;
using Models;

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
        }
    }
}
