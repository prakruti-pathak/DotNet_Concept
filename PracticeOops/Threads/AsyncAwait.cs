using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops.Threads
{
    public class AsyncAwait
    {
        public async Task ExampleAsyncMethod()
        {
            await Task.Delay(1000); // Simulates an asynchronous operation
            Console.WriteLine("Operation Completed");
        }
        public async IAsyncEnumerable<int> GenerateNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
        public async ValueTask<int> ComputeAsync()
        {
            return await Task.FromResult(42);
        }
    }
}
