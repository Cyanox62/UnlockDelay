using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.API;
using System.Collections.Generic;
using MEC;

namespace UnlockDelay
{
	partial class EventHandler : IEventHandlerWaitingForPlayers, IEventHandlerRoundStart
	{
		private readonly Plugin instance;

		public EventHandler(Plugin plugin) => instance = plugin;

		private Dictionary<Door, float> doorList = new Dictionary<Door, float>();

		public void OnWaitingForPlayers(WaitingForPlayersEvent ev)
		{
			InitDoors();
		}

		public void OnRoundStart(RoundStartEvent ev)
		{
			foreach (KeyValuePair<Door, float> entry in doorList)
			{
				Timing.RunCoroutine(DoorDelay(entry.Key, entry.Value));
			}
		}
	}
}
