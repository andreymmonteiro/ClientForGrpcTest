using gRPCTest.Protos;
using System;
using System.Threading.Tasks;

namespace ClientForGRPC.GrpcServices
{
    public class UserClientService : TokenService
    {
        private readonly User.UserClient _userClient;

        public UserClientService(User.UserClient userClient)
        {
            _userClient = userClient;
        }
        public async Task<ListUserProDto> GetAll(GetAttUserRequest getAllRequest) 
        {
            var header = AddHeaderToken(getAllRequest.Token);
            var result = await _userClient.GetAllAsync(getAllRequest, cancellationToken : CancelattionToken.Token, headers : header);
            return result;
        }
        public async Task<UserProDto> Get(string id) 
        {
            var getUserRequest = new GetUserRequest {  Id = id };
            return await _userClient.GetAsync(getUserRequest);
        }
        public async Task<UserCreateResultProtoDto> Post(CreateUserRequest userCreate) 
        {
            var result = await _userClient.PostAsync(userCreate);
            return result;
        }
        public async Task<DeleteUserResponse> Delete(Guid id)
        {
            DeleteUserRequest request = new DeleteUserRequest { Id = id.ToString() };
            return await _userClient.DeleteAsync(request);
        }

    }
}
