using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.SDK
{
    public interface IFileStorageClient
    {
        Task<GetResponse<byte[]>> GetRawGlobalFileAsync(string fileName);
    }
}
