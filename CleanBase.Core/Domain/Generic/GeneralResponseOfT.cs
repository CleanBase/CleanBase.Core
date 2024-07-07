namespace CleanBase.Core.Domain.Generic
{
	public class GeneralResponseOfT<T>
	{
		public T Result { get; set; }
		public string Message { get; set; }
		public GeneralResponseOfT(T result, string message) 
		{
			this.Result = result;
			this.Message = message;
		}
	}
}
