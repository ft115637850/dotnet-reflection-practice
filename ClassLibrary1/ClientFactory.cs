using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.SDK
{
    public class ClientFactory : IClientFactory
    {
        public Task<IFileStorageClient> OpenClientAsync(string baseAddress, string userToken, string webProxyAddress = "")
        {
            return Task.Run(() => {
                IFileStorageClient client = new FileStorageClient();
                return client;
            });
        }
    }
}
