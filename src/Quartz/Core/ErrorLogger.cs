using System.Threading;
using System.Threading.Tasks;

using Quartz.Listener;
using Quartz.Logging;
using Quartz.Util;

namespace Quartz.Core
{
    /// <summary>
    /// ErrorLogger - Scheduler Listener Class
    /// </summary>
    internal class ErrorLogger : SchedulerListenerSupport
    {
        private readonly ILog log = LogProvider.GetLogger(typeof(ErrorLogger));

        public override Task SchedulerError(
            string msg,
            SchedulerException cause,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            log.ErrorException(msg, cause);
            return TaskUtil.CompletedTask;
        }
    }
}