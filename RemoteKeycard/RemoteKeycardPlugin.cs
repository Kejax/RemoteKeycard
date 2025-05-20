using System;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using Respawning;
using Respawning.Graphics;

namespace RemoteKeycard
{
    public class RemoteKeycardPlugin : Plugin<RemoteKeycardConfig>
    {
        
        // The name of the plugin
        public override string Name { get; } = "RemoteKeycard";

        // The description of the plugin
        public override string Description { get; } = "Opens Doors remotely if you have a valid keycard in your pocket";

        // The author of the plugin
        public override string Author { get; } = "Kejax";

        // The current version of the plugin
        public override Version Version { get; } = new Version(0, 1, 0);

        // The required version of LabAPI (usually the version the plugin was built with)
        public override Version RequiredApiVersion { get; } = new (LabApiProperties.CompiledVersion);
        
        public KeycardEventHandler KeycardEventHandler = new ();
        
        public override void Enable()
        {
            CustomHandlersManager.RegisterEventsHandler(KeycardEventHandler);
            
        }

        public override void Disable()
        {
            CustomHandlersManager.UnregisterEventsHandler(KeycardEventHandler);
        }
        
    }
}