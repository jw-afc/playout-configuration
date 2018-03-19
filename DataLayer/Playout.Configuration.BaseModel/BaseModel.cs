using System.Runtime.Serialization;
using Playout.Configuration.BaseModel.Interfaces;

namespace Playout.Configuration.BaseModel
{
	[DataContract]
	public abstract class BaseModel : IBaseModel
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public byte[] Version { get; set; }
	}
}
