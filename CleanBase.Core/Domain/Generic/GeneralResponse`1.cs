namespace CleanBase.Core.Domain.Generic
{
	public class GeneralResponse<T>
	{
		public T Result { get; set; }
		public string Message { get; set; }
		public GeneralResponse(T result, string message) 
		{
			this.Result = result;
			this.Message = message;
		}
	}
}
