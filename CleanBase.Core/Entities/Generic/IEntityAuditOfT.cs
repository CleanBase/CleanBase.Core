namespace CleanBase.Core.Entities.Generic
{
	public interface IEntityAuditOfT <TKey> :IEntityKeyOfT<TKey>
	{
		TKey? CreateBy {  get; set; }	
		TKey? UpdateBy { get; set; }
		DateTime CreatedDate { get; set; }
		DateTime UpdatedDate { get; set; }
	}
}
