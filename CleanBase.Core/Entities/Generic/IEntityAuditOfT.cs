namespace CleanBase.Core.Entities.Generic
{
	public interface IEntityAuditOfT <TKey> :IEntityKeyOfT<TKey>
	{
		TKey? CreatedBy {  get; set; }	
		TKey? UpdatedBy { get; set; }
		DateTime CreatedDate { get; set; }
		DateTime UpdatedDate { get; set; }
	}
}
