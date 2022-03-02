using Grpc.Core;
using System;
using System.Threading;

namespace ClientForGRPC.GrpcServices
{
    public abstract class TokenService
    {
        public CancellationTokenSource CancelattionToken { get; set; }
        public Metadata Header { get; set; }

        protected TokenService()
        {
            CancelattionToken = new CancellationTokenSource(TimeSpan.FromSeconds(5));
            Header = new Metadata();
        }

        public virtual Metadata AddHeaderToken(string token) 
        {
            Header.Add("Authorization", $"Bearer {token}");
            return Header;
        }
    }
}
