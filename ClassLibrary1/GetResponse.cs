using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.SDK
{
    public class GetResponse<T>
    {
        public T Models { get; private set; }
        public GetResponse(T models)
        {
            Models = models;
        }
    }
}
