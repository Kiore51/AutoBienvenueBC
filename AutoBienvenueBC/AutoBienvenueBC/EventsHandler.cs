using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.CustomHandlers;
using LabApi.Features.Wrappers;

namespace AutoBienvenueBC
{
    public class EventsHandler : CustomEventsHandler
    {
        public override void OnPlayerJoined(PlayerJoinedEventArgs ev)
        {
            if (Plugin.Singleton == null)
            {
                return;
            }

            string PlayerName = ev.Player.Nickname;
            ev.Player.SendBroadcast(Plugin.Singleton.Config.welcomeMessage, Plugin.Singleton.Config.messageDuration);
        }
    }
}