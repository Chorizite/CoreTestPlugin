using System.IO;
using System;
using Microsoft.Extensions.Logging;
using Chorizite.Core.Plugins;
using Chorizite.Core.Plugins.AssemblyLoader;
using Chorizite.Core;

namespace Core.DatService {
    /// <summary>
    /// CoreTestPlugin
    /// </summary>
    public class CoreTestPlugin : IPluginCore {
        internal static ILogger? Log;

        protected CoreTestPlugin(AssemblyPluginManifest manifest, ILogger log) : base(manifest) {
            Log = log;

            Log?.LogDebug($"CoreTestPlugin Version: {Manifest.Version}");
        }

        protected override void Dispose() {
            
        }
    }
}
