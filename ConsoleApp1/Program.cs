using System;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fileStorageClientFactory = new FileStorage.SDK.ClientFactory();
            //var fileStorageClient = fileStorageClientFactory.OpenClientAsync("", "").Result;
            //var hsmaContent = fileStorageClient.GetRawGlobalFileAsync("test").Result.Models;
            //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");
            //var ass = System.Reflection.Assembly.LoadFile(path);
            var ass = AppDomain.CurrentDomain.Load("ClassLibrary1");

            var type = ass.GetType("FileStorage.SDK.ClientFactory");
            var method = type.GetMethod("OpenClientAsync", new Type[] { typeof(string), typeof(string), typeof(string) });
            var fileStorageClientFactory = Activator.CreateInstance(type);
            var parameters = new object[] { "", "", string.Empty };
            var task = method.Invoke(fileStorageClientFactory, parameters) as Task;
            var fileStorageClient = task.GetType().GetProperty("Result").GetValue(task, null);

            var clientType = ass.GetType("FileStorage.SDK.IFileStorageClient");
            var getContentMethod = clientType.GetMethod("GetRawGlobalFileAsync", new Type[] { typeof(string) });
            parameters = new object[] { "test.hsmadf" };
            task = getContentMethod.Invoke(fileStorageClient, parameters) as Task;
            var result = task.GetType().GetProperty("Result").GetValue(task, null);
            var hsmaContent = (byte[])result.GetType().GetProperty("Models").GetValue(result, null);


            Console.WriteLine(Encoding.Default.GetString(hsmaContent));
            Console.ReadKey();
        }
    }
}
