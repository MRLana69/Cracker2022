using System;
using Cpp2ILInjected;
using NaughtyAttributes;
using SYBO.Subway.Characters;
using SYBO.Subway.StateSystem.States;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class FallingSnowThemeEffect : ThemeEffect
{
	private ParticleSystem _snowPrefab;

	private ParticleSystem _snow;

	private float zOffset;

	private Vector3 _snowOriginalPosition;

	public unsafe override void Initialize(Transform root)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected VT, but got Unknown
		//IL_0058: Expected F4, but got Obj
		//IL_0053: Expected native int or pointer, but got VT
		//IL_006d: Expected F4, but got I
		//IL_0068: Expected native int or pointer, but got VT
		object obj = this + 16;
		obj = root;
		object obj2 = _snow + 8;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v7+8]");
		_ = 0;
		Color color = (Color)(obj3 + 16);
		((Color*)(nint)color)->r = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		Shader.SetGlobalColor("_RoofedCullNext", color);
	}

	private void Game_OnGameStarted()
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got F4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj = this + 8;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DeathState._003CDelayGameOverScreen_003Ed__8 obj3 = default;
		((IDisposable)obj3).Dispose();
		_ = 1;
		object obj4 = this + 20;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DeathState._003CDelayGameOverScreen_003Ed__8 obj5 = default;
		((IDisposable)obj5).Dispose();
		object obj6 = obj5 + 8;
		obj6 = -1000f;
		object obj7 = obj5 + 8;
		_ = -1000f;
		object obj8 = obj5 + 8;
		_ = 1000f;
		object obj9 = obj5 + 8;
		_ = 1000f;
		_ = 1;
		object obj10 = this + 24;
		obj10 = obj5;
	}

	private void Game_OnGameEnded()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_snow).FindKernel((string)null) != 0)
		{
			((DrawConditionAttribute)(object)_snow)._002Ector();
			_snow.Stop();
		}
	}

	public override void UpdateEffect()
	{
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_snow).FindKernel((string)null) != 0)
		{
			_snow.Clear();
		}
	}

	public FallingSnowThemeEffect()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fb: Expected Obj, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = _snow.gameObject;
		object obj = this + 24;
		object obj2 = this + 24;
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v11 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v31 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 12;
		CharacterRendering instance = CharacterRendering.Instance;
		object obj6 = instance + 248;
		obj4 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v7+8]");
		_ = 0;
		obj5 = 0;
		_ = 0;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v8+4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v16+8]");
		float num3 = 0f + zOffset;
		Transform transform = (Transform)(obj5 + 24);
		transform = (Transform)obj5;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform.localPosition;
	}
}
