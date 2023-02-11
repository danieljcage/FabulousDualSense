using System.IO;
using UnrealBuildTool;

public class DualSenseWindows : ModuleRules
{
	public DualSenseWindows(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;

		bEnableNonInlinedGenCppWarnings = true;

		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicDefinitions.Add("DS5W_USE_LIB");

			PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "include"));

			PublicSystemLibraries.Add("hid.lib");

			PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "lib", "ds5w_x64.lib"));
		}
	}
}