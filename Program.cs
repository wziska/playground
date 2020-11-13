using System;
using System.Threading.Tasks;

namespace playground
{
    class Program
    {
        private static readonly string connString = "Endpoint=sb://wzdemo.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=b5QkH4OQv1B330hRsrU19lGs1z5F1iwE1bPPbmdXCPI=";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello service bus!");

            var helper = new ManagementHelper(connString);

            var queue = await helper.GetQueue("qqq");
            System.Console.WriteLine($"queue: {queue}");
        }
    }
}
