using System;
using System.IO;
using System.Threading.Tasks;

namespace something
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var t = new TestAsync();
            t.FirstAsync();
            await t.SecondAsync();
            return 0;
        }
    }

    class TestAsync {
        public async Task FirstAsync() {
            await File.WriteAllTextAsync("First.txt",$"First Run {DateTime.UtcNow}");
            await Task.Delay(100000);
        }


        public async Task SecondAsync() {
            await File.WriteAllTextAsync("Second.txt",$"Second Run {DateTime.UtcNow}");
            await Task.Delay(10);
        }
    }
}
