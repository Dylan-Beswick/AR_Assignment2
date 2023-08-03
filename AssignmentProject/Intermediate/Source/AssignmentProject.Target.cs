using UnrealBuildTool;

public class AssignmentProjectTarget : TargetRules
{
	public AssignmentProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("AssignmentProject");
	}
}
