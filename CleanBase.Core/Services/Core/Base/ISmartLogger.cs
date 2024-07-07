using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace CleanBase.Core.Services.Core.Base
{
	public interface ISmartLogger
	{
		string UserName { get; set; }
		ILogger Logger { get; set; }

		/// <summary>
		/// Information
		/// </summary>
		/// <param name="messageTemplate"></param>
		void Information(string messageTemplate);
		void Information<T>(string messageTemplate, T propertyValue);
		void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
		void Information<T0, T1, T2>(
		  string messageTemplate,
		  T0 propertyValue0,
		  T1 propertyValue1,
		  T2 propertyValue2);
		void Information(Exception exception, string messageTemplate, params object[] propertyValues);

		/// <summary>
		/// InformationJson using params *limit number of object[] data =< 3
		/// </summary>
		/// <param name="messageTemplate"></param>
		/// <param name="data"></param>
		void InformationJson(string messageTemplate, params object[] data);

		/// <summary>
		/// Error
		/// </summary>
		/// <param name="messageTemplate"></param>
		/// <param name="data"></param>
		void ErrorJson(string messageTemplate, params object[] data);
		void Error(string messageTemplate);
		void Error<T>(string messageTemplate, T propertyValue);
		void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1);
		void Error<T0, T1, T2>(
		  string messageTemplate,
		  T0 propertyValue0,
		  T1 propertyValue1,
		  T2 propertyValue2);
		void Error(string messageTemplate, params object[] propertyValues);
		void Error(Exception exception, string messageTemplate);
		void Error<T>(Exception exception, string messageTemplate, T propertyValue);
		void Error<T0, T1>(
		  Exception exception,
		  string messageTemplate,
		  T0 propertyValue0,
		  T1 propertyValue1);
		void Error<T0, T1, T2>(
		  Exception exception,
		  string messageTemplate,
		  T0 propertyValue0,
		  T1 propertyValue1,
		  T2 propertyValue2);
		void Error(Exception exception, string messageTemplate, params object[] propertyValues);
	}
}
