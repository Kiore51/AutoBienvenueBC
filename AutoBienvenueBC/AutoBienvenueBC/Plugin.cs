using System;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using LabApi.Loader.Features.Plugins.Enums;

namespace AutoBienvenueBC
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton { get; set; } = null;
        public override string Name { get; } =  "AutoBienvenueBC";
        public override string Description { get; } = "Auto Welcome Broadcast plugin";
        public override string Author { get; } = "Kiore";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);
        public override LoadPriority Priority { get; } = LoadPriority.Medium;
        public EventsHandler Events { get; } = new  EventsHandler();

        public override void Enable()
        {
            Singleton = this;
            CustomHandlersManager.RegisterEventsHandler(Events);
        }

        public override void Disable()
        {
            
            CustomHandlersManager.UnregisterEventsHandler(Events);
        }
    }
}