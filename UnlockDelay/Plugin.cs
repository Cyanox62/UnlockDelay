using Smod2.Attributes;
using Smod2.Config;

namespace UnlockDelay
{
	[PluginDetails(
	author = "Cyanox",
	name = "UnlockDelay",
	description = "Locks certain doors for a set period of time at the start of the round.",
	id = "cyan.unlock.delay",
	version = "1.0.0",
	SmodMajor = 3,
	SmodMinor = 4,
	SmodRevision = 0
	)]
	public class Plugin : Smod2.Plugin
	{
		public override void OnDisable()
		{
		}

		public override void OnEnable()
		{
		}

		public override void Register()
		{
			// Register Events
			AddEventHandlers(new EventHandler(this));
			AddConfig(new ConfigSetting("dl_list", "", true, "The list of doors to be locked and for how long."));
		}
	}
}
