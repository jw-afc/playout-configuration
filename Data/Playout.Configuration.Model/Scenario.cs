using System.Runtime.Serialization;

namespace Playout.Configuration.Model
{
	[DataContract]
	public class Scenario
	{
	    [DataMember]
		public string Id { get; set; }
	    [DataMember]
		public string DisplayId { get; set; }
	    [DataMember]
		public string DalFile { get; set; }
	}
}
