
using System;
using HarmonyLib;
using RimWorld;


namespace PowerConduitPatch {

    [HarmonyPatch(typeof(PowerNetGraphics))]
    [HarmonyPatch("PrintWirePieceConnecting")]
    internal class PowerConduitPatchInvisible {

        public static bool Prefix(){
            return false;
        }
    }
}