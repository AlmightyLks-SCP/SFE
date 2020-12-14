using SFE.Config;
using Synapse.Api;
using Synapse.Api.Events.SynapseEventArguments;
using Synapse.Api.Plugin;

namespace SFE
{
    [PluginInformation(
        Author = "AlmightyLks",
        Description = "Make SCPs go poof when ded",
        Name = "SCP Fucking Explodes",
        SynapseMajor = 2,
        SynapseMinor = 2,
        SynapsePatch = 0,
        Version = "1.0.0"
        )]
    public class SFE : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "SCP Fucking Explodes")]
        public ScpFuckingExplodesConfig Config { get; set; }

        public override void Load()
        {
            Synapse.Api.Events.EventHandler.Get.Player.PlayerDeathEvent += Player_PlayerDeathEvent;

            base.Load();
        }

        private void Player_PlayerDeathEvent(PlayerDeathEventArgs ev)
        {
            if (!Config.ExplodingScps.Contains(ev.Victim.RoleID))
                return;

            Map.Get.Explode(ev.Victim.Position, Synapse.Api.Enum.GrenadeType.Grenade, ev.Victim);
        }
    }
}
