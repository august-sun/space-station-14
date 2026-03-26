using Content.Shared.Damage.Systems;
using Robust.Shared.GameStates;

namespace Content.Shared.Damage.Components;

/// <summary>
/// Reduces the stamcrit threshold while the projectile is still embedded into the target.
/// </summary>
[RegisterComponent]
[NetworkedComponent]
[AutoGenerateComponentState]
[Access(typeof(SharedStaminaSystem))]
public sealed partial class StaminaDrainOnEmbedComponent : Component
{
    /// <summary>
    /// How much the target's crit threshold is reduced by for each projectile embedded.
    /// </summary>
    [DataField, AutoNetworkedField]
    public float MaxDrain = 10f;
}
