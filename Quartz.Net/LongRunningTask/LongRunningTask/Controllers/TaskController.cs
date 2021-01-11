using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LongRunningTask.Jobs;
using Microsoft.AspNetCore.Mvc;
using Quartz;

namespace LongRunningTask.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ScheduleJob()
        {
            return View();
        }

        public async Task<IActionResult> NewTask([FromServices] ISchedulerFactory schedulerFactory, CancellationToken cancellationToken)
        {
            var scheduler = await schedulerFactory.GetScheduler(cancellationToken);


            //sched.scheduleJob(job, trigger);

            //await scheduler.ScheduleJob(trigger => trigger
            //    .StartAt(DateBuilder.EvenSecondDate(DateTimeOffset.UtcNow.AddSeconds(7)))
            //);
                

            return View();
        }
    }
}