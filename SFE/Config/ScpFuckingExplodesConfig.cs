using Synapse.Config;
using System.Collections.Generic;
using System.ComponentModel;

namespace SFE.Config
{
    public class ScpFuckingExplodesConfig : AbstractConfigSection
    {
        [Description("IDs of SCPs which shall explode on death")]
        public List<int> ExplodingScps { get; set; } = new List<int>();
    }
}
