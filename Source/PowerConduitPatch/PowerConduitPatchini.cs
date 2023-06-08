using System;
using System.Reflection;
using HarmonyLib;
using Verse;

[StaticConstructorOnStartup]
internal class PowerConduitPatchini
{

	static PowerConduitPatchini()
	{
		new Harmony("PowerConduitPatchInvisible.admeeer.mod").PatchAll(Assembly.GetExecutingAssembly());
	}
}
