using BaseLib.Abstracts;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.Runs;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// IHealAmountModifier.ModifyHealAdditive() -> AbstractModel.ModifyHealAmount() -> IHealAmountModifier.ModifyHealMultiplicative()
/// reserve AbstractModel.ModifyHealAmount() in the process for compatibility
/// </summary>

// TODO: The method Hook.ModifyHealAmount is not found in my environment. I'm not sure if it really doesn't exist (renamed with version updates) or if it's a problem with my personal environment. I assume there might be an issue with this part due to updates, but I'm not certain about the author's specific requirements here, so I commented it out instead of fixing it.

/**
[HarmonyPatch(typeof(Hook), nameof(Hook.ModifyHealAmount))]
public static class ModifyHealAmountPatches
{
    [HarmonyPrefix]
    static void Prefix(IRunState runState, CombatState? combatState, Creature creature, ref decimal amount)
    {
        decimal num = amount;

        foreach (var item in runState.IterateHookListeners(combatState))
        {
            if (item is IHealAmountModifier mod)
                num += mod.ModifyHealAdditive(creature, amount); // pass the amount before any addition
        }

        amount = num;
    }

    [HarmonyPostfix]
    static void Postfix(IRunState runState, CombatState? combatState, Creature creature, ref decimal __result)
    {
        decimal num = __result;

        foreach (var item in runState.IterateHookListeners(combatState))
        {
            if (item is IHealAmountModifier mod)
                num *= mod.ModifyHealMultiplicative(creature, __result); // pass the amount before any multiplication
        }

        __result = Math.Max(0m, num);
    }
}
*/