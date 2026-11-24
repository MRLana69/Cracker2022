using Cpp2ILInjected;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class RollImpactColorControl : MonoBehaviour
{
	private Renderer _rollImpactRockRenderer;

	private ParticleSystem _rollImpactDustParticles;

	private void Start()
	{
		CancelInvoke();
	}

	public unsafe RollImpactColorControl()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_01ee: Expected I, but got Obj
		//IL_0204: Expected Obj, but got I
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_025d: Expected Obj, but got I
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected VT, but got Unknown
		//IL_028d: Expected F4, but got Obj
		//IL_0288: Expected native int or pointer, but got VT
		//IL_02a2: Expected F4, but got I
		//IL_029d: Expected native int or pointer, but got VT
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00f4: Expected F4, but got Obj
		//IL_00ef: Expected native int or pointer, but got VT
		//IL_0109: Expected F4, but got I
		//IL_0104: Expected native int or pointer, but got VT
		//IL_011c: Expected Obj, but got I4
		//IL_013b: Expected F4, but got Obj
		//IL_0136: Expected native int or pointer, but got VT
		//IL_0150: Expected F4, but got I
		//IL_014b: Expected native int or pointer, but got VT
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 160;
		object obj3 = obj2 + 52;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 48;
		obj4 = 0;
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v58 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Material sharedMaterial = _rollImpactRockRenderer.sharedMaterial;
		object obj6 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj7 = (nint)0 + (nint)112;
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v3+8]");
		_ = 0;
		Vector4 vector = (Vector4)(obj2 + 112);
		((Vector4*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v15+8]");
		((Vector4*)(nint)vector)->z = 0f;
		sharedMaterial.SetVector("_Color", vector);
		object obj8 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj9 = (nint)0 + (nint)128;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v21+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		object obj10 = (nint)0 + (nint)144;
		obj2 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v26+8]");
		_ = 0;
		object obj11 = obj2 + 96;
		obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v29+8]");
		_ = 0;
		((Vector4*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector4*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1176B");
		obj = 0;
		obj = _rollImpactDustParticles;
		obj4 = obj;
		((Vector4*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector4*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1175D");
	}
}
