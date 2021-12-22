using AutoMapper;
using Mapper.Interface;
using System;

namespace Mapper
{
    public class AutoMapperFixtureGrpc : IMapperGrpc
    {
        

        public IMapper GetMapper() 
        {
            var config = new MapperConfiguration(options => 
            {
                options.AddProfile(new DtoToProto());
            });
            return config.CreateMapper();
        }
    }
}
