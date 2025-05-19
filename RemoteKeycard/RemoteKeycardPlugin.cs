using System;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace RemoteKeycard
{
    public class RemoteKeycardPlugin : Plugin<RemoteKeycardConfig>
    {
        
        // The name of the plugin
        public override string Name { get; } = "RemoteKeycard";

        // The description of the plugin
        public override string Description { get; } = "Opens Doors remotely if you have a valid keycard in your pocket";

        // The author of the plugin
        public override string Author { get; } = "Me!";

        // The current version of the plugin
        public override Version Version { get; } = new Version(0, 1, 0);

        // The required version of LabAPI (usually the version the plugin was built with)
        public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);
        
        public override void Enable()
        {
            // This will run when the plugin loads!
        }

        public override void Disable()
        {
            // Runs when the plugin is disabled
        }
        
    }
}