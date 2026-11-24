using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class QualityToggle : MonoBehaviour
{
	private QualityFeature _feature;

	private GameObject _unsupported;

	private GameObject _supported;

	private void Awake()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00f2: Expected Obj, but got I
		//IL_0102: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S5_v6 (should have been resolved before IL gen)");
		object obj11 = this + 8;
		object obj12 = default;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v8 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v9+60]");
		object obj14 = 0;
		object obj15 = obj14;
		object obj16 = obj15 & 0x1FFF;
		object obj17 = obj16 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S4_v13 (should have been resolved before IL gen)");
		object obj18 = this + 12;
		object obj19 = default;
		obj18 = obj19;
	}

	public QualityToggle()
	{
		//IL_001e: Expected VT, but got Obj
		//IL_002d: Expected Obj, but got VT
		//IL_003f: Expected Obj, but got I4
		//IL_0014: Expected Obj, but got I4
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		bool flag = ((QualityManager)val).PrewarmParticleSystems(_feature);
		string text = (string)((flag ? 1 : 0) ^ 1);
		_unsupported.tag = text;
		_supported.tag = (string)flag;
	}
}
