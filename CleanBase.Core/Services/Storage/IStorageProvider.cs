using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Storage
{
	public interface IStorageProvider
	{
		Task<bool> CheckExistsAsync(string blobFilePath);

		Uri GenerateReadSasUri(string blobFilePath, DateTimeOffset expiresOn);

		/// <summary>
		/// Reads the content of a file as a string asynchronously from the specified blob container.
		/// </summary>
		Task<string> ReadFileAsStringAsync(string blobContainerName, string blobFileName);

		/// <summary>
		/// Reads the content of a file as a string asynchronously from the specified absolute URI.
		/// </summary>
		Task<string> ReadFileAsStringAsync(string absoluteUri);

		/// <summary>
		/// Reads the content of a file as Base64 string asynchronously from the specified blob container.
		/// </summary>
		Task<string> ReadFileAsBase64Async(string blobContainerName, string blobFileName);

		/// <summary>
		/// Reads the content of a file as Base64 string asynchronously from the specified absolute URI.
		/// </summary>
		Task<string> ReadFileAsBase64Async(string absoluteUri);

		/// <summary>
		/// Reads the content of a file as a stream asynchronously from the specified blob container.
		/// </summary>
		Task<Stream> ReadFileAsStreamAsync(string blobContainerName, string blobFileName);

		/// <summary>
		/// Reads the content of a file as a stream asynchronously from the specified absolute URI.
		/// </summary>
		Task<Stream> ReadFileAsStreamAsync(string absoluteUri);

		Task<string> UploadFileAsync(string filePath, string blobFilePath);

		/// <summary>
		/// Uploads the specified byte array to the specified container with optional content type.
		/// </summary>
		Task<string> UploadBytesAsync(string relativeFilePath, string containerName, byte[] data, string contentType = null);

		/// <summary>
		/// Get metadata file 
		/// </summary>
		/// <param name="blobContainerName"></param>
		/// <param name="blobName"></param>
		/// <returns></returns>
		Task<IDictionary<string, string>> GetMetadataAsync(string blobContainerName, string blobName);

		/// <summary>
		/// Set metadata file
		/// </summary>
		/// <param name="blobContainerName"></param>
		/// <param name="blobName"></param>
		/// <param name="metadata"></param>
		/// <returns></returns>
		Task SetMetadataAsync(string blobContainerName, string blobName, IDictionary<string, string> metadata);

		/// <summary>
		/// List all file of a container
		/// </summary>
		/// <param name="blobContainerName"></param>
		/// <returns></returns>
		Task<IEnumerable<string>> ListFilesAsync(string blobContainerName);

	}
}
