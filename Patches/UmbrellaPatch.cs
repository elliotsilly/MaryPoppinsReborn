using HarmonyLib;
using UnityEngine;

namespace MarryPoppins
{
    [HarmonyPatch(typeof(UmbrellaItem), "OnActivate")]
    public class UmbrellaActivatePatch
    {
        static void Postfix(UmbrellaItem __instance)
        {
            if (__instance.IsMyItem())
            {
                if (__instance.itemState == TransferrableObject.ItemStates.State0)
                {
                    Plugin.umbrellaOpened = true;
                }
                else if (__instance.itemState == TransferrableObject.ItemStates.State1)
                {
                    Plugin.umbrellaOpened = false;
                }
            }
        }
    }
}
