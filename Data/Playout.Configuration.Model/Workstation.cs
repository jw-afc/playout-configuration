using System;
using System.Runtime.Serialization;

namespace Playout.Configuration.Model
{
	[DataContract]
	public class Workstation : BaseModel.BaseModel
    {
	    [DataMember]
		public string Scenario { get; set; }
	    [DataMember]
		public DateTime? Loaded { get; set; }
	    [DataMember]
		public DateTime? LastAccessed { get; set; }
	    [DataMember]
		public string Group { get; set; }

	    public Workstation()
	    {
		    
	    }

		public Workstation(string scenario, DateTime? loaded = null, DateTime? lastAccessed = null, string group = "")
	    {
		    Scenario = scenario;
		    Loaded = loaded;
		    LastAccessed = lastAccessed;
		    Group = group;
	    }
	}
}
