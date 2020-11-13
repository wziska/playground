// using Microsoft.Azure.Management.ServiceBus;
using Microsoft.Azure.ServiceBus.Management;
using System;
using System.Threading.Tasks;

namespace playground
{
    public class ManagementHelper
    {
        private ManagementClient client;

        public ManagementHelper(string connectionString)
        {
            client = new ManagementClient(connectionString);
        }

        public async Task<string> GetQueue(string queuePath)
        {
            var queue = await client.GetQueueAsync(queuePath);
            return $"path: {queue.Path}, status: {queue.Status}";
        }
    }
}
