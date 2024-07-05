using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Jobs
{
	public interface IBackgroundJob
	{
		void RemoveJob(string jobCode);
		void Trigger(string jobCode);

		string Enqueue(Expression<Action> methodCall);
		string Enqueue(Expression<Func<Task>> methodCall);

		string Schedule(Expression<Action> methodCall, TimeSpan delay);
		string Schedule(Expression<Func<Task>> methodCall, TimeSpan delay);

		string Schedule(Expression<Action> methodCall, DateTimeOffset enqueueAt);
		string Schedule(Expression<Func<Task>> methodCall, DateTimeOffset enqueueAt);

		string Schedule<T>(Expression<Action<T>> methodCall, TimeSpan delay);
		string Schedule<T>(Expression<Func<T, Task>> methodCall, TimeSpan delay);

		string Schedule<T>(Expression<Action<T>> methodCall, DateTimeOffset enqueueAt);
		string Schedule<T>(Expression<Func<T, Task>> methodCall, DateTimeOffset enqueueAt);

		void Recurring(string jobCode, Expression<Func<Task>> function, string cron, TimeZoneInfo timeZone = null, string queue = "default");
		void Recurring<TService>(string jobCode, Expression<Func<TService, Task>> function, string cron, TimeZoneInfo timeZone = null, string queue = "default");

		void UpdateSchedule(string jobCode, TimeSpan newDelay);
		void CancelSchedule(string jobCode);
		void PauseJob(string jobCode);
		void ResumeJob(string jobCode);
		string GetJobStatus(string jobCode);
	}
}
