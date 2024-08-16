using CleanBase.Core.Services.Core.Base;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core
{
    public class SmartLogger : ISmartLogger
    {
        private readonly IIdentityProvider _identityProvider;

        public ILogger Logger { get; set; }
        public string UserName { get; set; }

        public SmartLogger(ILogger logger, IIdentityProvider identityProvider)
        {
            Logger = logger;
            _identityProvider = identityProvider;
        }

        private string FormatMessage(string messageTemplate)
        {
            var interpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
            interpolatedStringHandler.AppendLiteral("[");
            interpolatedStringHandler.AppendFormatted(_identityProvider.RequestId);
            interpolatedStringHandler.AppendLiteral("][");
            interpolatedStringHandler.AppendFormatted(_identityProvider.Identity?.UserName ?? UserName);
            interpolatedStringHandler.AppendLiteral("] ");
            interpolatedStringHandler.AppendFormatted(messageTemplate);
            return interpolatedStringHandler.ToStringAndClear();
        }

        public void Information(string messageTemplate) =>
            Logger.Information(FormatMessage(messageTemplate));

        public void Information<T>(string messageTemplate, T propertyValue) =>
            Logger.Information(FormatMessage(messageTemplate), propertyValue);

        public void Information<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) =>
            Logger.Information(FormatMessage(messageTemplate), propertyValue0, propertyValue1);

        public void Information<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2) =>
            Logger.Information(FormatMessage(messageTemplate), propertyValue0, propertyValue1, propertyValue2);

        public void Information(string messageTemplate, params object[] propertyValues)
        {
            var formattedMessage = FormatMessage(messageTemplate);
            Logger.Information(formattedMessage + " " + string.Join(" ", propertyValues.Select(v => v.ToString())));
        }

        public void Information(Exception exception, string messageTemplate) =>
            Logger.Information(exception, FormatMessage(messageTemplate));

        public void Information<T>(Exception exception, string messageTemplate, T propertyValue) =>
            Logger.Information(exception, FormatMessage(messageTemplate), propertyValue);

        public void Information<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) =>
            Logger.Information(exception, FormatMessage(messageTemplate), propertyValue0, propertyValue1);

        public void Information<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2) =>
            Logger.Information(exception, FormatMessage(messageTemplate), propertyValue0, propertyValue1, propertyValue2);

        public void Information(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            var formattedMessage = FormatMessage(messageTemplate);
            Logger.Information(exception, formattedMessage + " " + string.Join(" ", propertyValues.Select(v => v.ToString())));
        }

        public void Error(string messageTemplate) =>
            Logger.Error(FormatMessage(messageTemplate));

        public void Error<T>(string messageTemplate, T propertyValue) =>
            Logger.Error(FormatMessage(messageTemplate), propertyValue);

        public void Error<T0, T1>(string messageTemplate, T0 propertyValue0, T1 propertyValue1) =>
            Logger.Error(FormatMessage(messageTemplate), propertyValue0, propertyValue1);

        public void Error<T0, T1, T2>(string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2) =>
            Logger.Error(FormatMessage(messageTemplate), propertyValue0, propertyValue1, propertyValue2);

        public void Error(string messageTemplate, params object[] propertyValues)
        {
            var formattedMessage = FormatMessage(messageTemplate);
            Logger.Error(formattedMessage + " " + string.Join(" ", propertyValues.Select(v => v.ToString())));
        }

        public void Error(Exception exception, string messageTemplate) =>
            Logger.Error(exception, FormatMessage(messageTemplate));

        public void Error<T>(Exception exception, string messageTemplate, T propertyValue) =>
            Logger.Error(exception, FormatMessage(messageTemplate), propertyValue);

        public void Error<T0, T1>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1) =>
            Logger.Error(exception, FormatMessage(messageTemplate), propertyValue0, propertyValue1);

        public void Error<T0, T1, T2>(Exception exception, string messageTemplate, T0 propertyValue0, T1 propertyValue1, T2 propertyValue2) =>
            Logger.Error(exception, FormatMessage(messageTemplate), propertyValue0, propertyValue1, propertyValue2);

        public void Error(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            var formattedMessage = FormatMessage(messageTemplate);
            Logger.Error(exception, formattedMessage + " " + string.Join(" ", propertyValues.Select(v => v.ToString())));
        }

        public void InformationJson(string messageTemplate, params object[] data)
        {
            var jsonData = string.Join(", ", data.Select(JsonConvert.SerializeObject));
            Information($"{messageTemplate}: {jsonData}");
        }

        public void ErrorJson(string messageTemplate, params object[] data)
        {
            var jsonData = string.Join(", ", data.Select(JsonConvert.SerializeObject));
            Error($"{messageTemplate}: {jsonData}");
        }
    }

}