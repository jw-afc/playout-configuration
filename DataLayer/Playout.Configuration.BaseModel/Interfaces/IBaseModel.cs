using System.Runtime.Serialization;

namespace Playout.Configuration.BaseModel.Interfaces
{
	public interface IBaseModel
	{
		[DataMember]
		int Id { get; set; }

		[DataMember]
		byte[] Version { get; set; }
	}
}
