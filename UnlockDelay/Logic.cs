using MEC;
using System.Collections.Generic;
using Smod2.API;
using System.Linq;

namespace UnlockDelay
{
	partial class EventHandler
	{
		private void InitDoors()
		{
			doorList.Clear();
			List<Door> dList = instance.Server.Map.GetDoors();

			foreach (string s in instance.GetConfigString("dl_list").Split(','))
			{
				string[] split = s.Split(':');
				string door = split[0].Trim().ToUpper();
				string delay = split[1].Trim();

				Door d = dList.FirstOrDefault(x => x.Name == door);

				if (d != null)
				{
					if (float.TryParse(delay, out float fl))
					{
						doorList.Add(d, fl);
					}
					else
					{
						instance.Info($"ERROR: Invalid delay '{delay}' in entry '{s}'. Ignoring entry...");
					}
				}
				else
				{
					instance.Info($"ERROR: Invalid door name '{door}' in entry '{s}'. Ignoring entry...");
				}
			}
		}

		private IEnumerator<float> DoorDelay(Door door, float delay)
		{
			door.Locked = true;
			yield return Timing.WaitForSeconds(delay);
			door.Locked = false;
		}
	}
}
