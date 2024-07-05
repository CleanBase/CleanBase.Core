using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Jobs
{
	public interface IProcessingJobConsumer
	{
		bool IsRunning { get; }

		Task StartAsync(CancellationToken cancellationToken);
		Task StopAsync(CancellationToken cancellationToken);

		void SetSchedule(string cronExpression, TimeZoneInfo timeZone = null);
		void SetTimeRange(TimeSpan startTime, TimeSpan endTime);

		Task HandleError(Exception exception, CancellationToken cancellationToken);
	}
}
