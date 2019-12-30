using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.SDK
{
    public class FileStorageClient : IFileStorageClient
    {
        public Task<GetResponse<byte[]>> GetRawGlobalFileAsync(string fileName)
        {
            return Task.Run(() => {
                return new GetResponse<byte[]>(Encoding.Default.GetBytes(fileName));
            });
        }
    }
}
