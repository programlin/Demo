using Quartz;
using System;
using System.Threading.Tasks;

namespace LongRunningTask.Jobs
{
    public class DemoJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(() =>
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine($"第{i}次執行");
                    context.CancellationToken.WaitHandle.WaitOne(TimeSpan.FromSeconds(2));
                }
            });
        }
    }
}
