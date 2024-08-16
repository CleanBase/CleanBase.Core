using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Settings
{
	public class AppSettings
	{
		public string AppId { get; set; } = "CleanBase";
		public string KeyVaultApiUrl { get; set; }
		public string CoreConnectionString { get; set; }
		public string Schema { get; set; }
		public string TablePrefix { get; set; } = string.Empty;
		public string AllowedHosts { get; set; }
		public string PathBase { get; set; } = string.Empty;

		// Authentication Settings
		public AuthSettingSection Auth { get; set; } = new AuthSettingSection();

		// Azure Storage Settings
		public AzureStorageSetting AzureStorageSetting { get; set; } = new AzureStorageSetting();

		// Application Insights Settings
		public ApplicationInsightsSettings ApplicationInsights { get; set; } = new ApplicationInsightsSettings();

		// Email Settings
		public EmailSettings EmailSettings { get; set; } = new EmailSettings();

		// Cache Settings
		public CacheSettings Cache { get; set; } = new CacheSettings
		{
			SlidingExpiration = 60
		};

		// Computed Property for Allowed Hosts
		public virtual string[] AllowedHostsValues =>
			string.IsNullOrEmpty(AllowedHosts)
			? Array.Empty<string>()
			: AllowedHosts.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

		// Method to Merge Settings
		public virtual void MergeSettings(AppSettings settings)
		{
			if (settings == null) throw new ArgumentNullException(nameof(settings));

			// Merging Email Settings
			EmailSettings.Account = settings.EmailSettings.Account ?? EmailSettings.Account;
			EmailSettings.ApiKey = settings.EmailSettings.ApiKey ?? EmailSettings.ApiKey;
			EmailSettings.Password = settings.EmailSettings.Password ?? EmailSettings.Password;

			// Merging Auth Settings
			Auth.Audience = settings.Auth.Audience ?? Auth.Audience;
			Auth.Authority = settings.Auth.Authority ?? Auth.Authority;
			Auth.Exponent = settings.Auth.Exponent ?? Auth.Exponent;
			Auth.Modulus = settings.Auth.Modulus ?? Auth.Modulus;
			Auth.RequireHttpsMetadata = settings.Auth.RequireHttpsMetadata;
			Auth.UserProfileApiUrl = settings.Auth.UserProfileApiUrl ?? Auth.UserProfileApiUrl;

			// Merging Azure Storage Settings
			AzureStorageSetting.BlobConnectionString = settings.AzureStorageSetting.BlobConnectionString ?? AzureStorageSetting.BlobConnectionString;

			// Merging Application Insights Settings
			ApplicationInsights.InstrumentationKey = settings.ApplicationInsights.InstrumentationKey ?? ApplicationInsights.InstrumentationKey;

			// Add any other settings that might need to be merged here
		}
	}
}
