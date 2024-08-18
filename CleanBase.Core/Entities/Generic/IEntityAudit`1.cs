namespace CleanBase.Core.Entities.Generic
{
	public interface IEntityAudit <TKey> :IEntityKey<TKey>
	{
		TKey? CreatedBy {  get; set; }	
		TKey? UpdatedBy { get; set; }
		DateTime CreatedDate { get; set; }
		DateTime UpdatedDate { get; set; }
	}
}
