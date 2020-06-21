// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Infidel : ModuleRules
{
	public Infidel(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
