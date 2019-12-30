using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.SDK
{
    public interface IClientFactory
    {
        Task<IFileStorageClient> OpenClientAsync(string baseAddress, string userToken, string webProxyAddress = "");
    }
}
