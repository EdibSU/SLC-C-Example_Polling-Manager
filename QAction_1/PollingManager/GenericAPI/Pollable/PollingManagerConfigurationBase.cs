namespace Skyline.DataMiner.PollingManager
{
	using System.Collections.Generic;
	using System.Linq;

	using Skyline.DataMiner.Scripting;

	public abstract class PollingManagerConfigurationBase
	{
		public PollingManagerConfigurationBase(SLProtocol protocol)
		{
			Protocol = protocol;
			Dependencies = new List<Dependency>();
		}

		public SLProtocol Protocol { get; set; }

		public List<PollableBase> ListRows => Rows.Select(row => row.Value).ToList();

		protected abstract Dictionary<string, PollableBase> Rows { get; set; }

		protected List<Dependency> Dependencies { get; set; }

		public void Create()
		{
			CreateRelations();
			CreateDependencies();
		}

		protected virtual void CreateRelations()
		{
		}

		protected virtual void CreateDependencies()
		{
		}
	}
}
