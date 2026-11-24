using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;

namespace SYBO.Subway.Level;

[Serializable]
public class EnvironmentModelAssets
{
	public string Name;

	public const string FieldPatternEnvironment = "Environment";

	public EnvironmentKind Environment;

	public const string FieldPatternSequenceVariations = "SequenceVariations";

	public EnvironmentSegmentSequence[] SequenceVariations;

	public EnvironmentModelAssets()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		object obj = this + 24;
		obj = hashSet;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<object> hashSet2 = default;
		hashSet2._002Ector();
		object obj2 = this + 28;
		obj2 = hashSet2;
		((Validator<>)this)._002Ector();
	}
}
