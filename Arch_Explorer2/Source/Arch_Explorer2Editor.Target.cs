// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Arch_Explorer2EditorTarget : TargetRules
{
	public Arch_Explorer2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Arch_Explorer2" } );
	}
}
