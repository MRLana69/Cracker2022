using System;
using Cpp2ILInjected;
using SYBO.Common.Automation.Steps;
using UnityEngine;

namespace SYBO.Subway.Automation.Steps;

public class OpenCloseUIElementStep : AutomationStep
{
	public enum UIElementType
	{
		Popup,
		Screen
	}

	private enum StepState
	{
		None,
		WaitingBeforeOpen,
		Open,
		Closed
	}

	private UIElementType _type;

	private string _name;

	private const float DelayBefore = 0.2f;

	private const float OpenTime = 0.2f;

	private const float DelayAfter = 0.2f;

	private float _currentDuration;

	private StepState _currentState;

	private bool _skipFrame;

	public unsafe OpenCloseUIElementStep(UIElementType uiElementType, string name)
	{
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected I, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_029c: Expected Obj, but got I4
		//IL_0047: Expected I, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_02e3: Expected I, but got Obj
		//IL_0088: Expected I, but got Obj
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_00e4: Expected VT, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0337: Expected I, but got Obj
		//IL_010d: Expected VT, but got Obj
		//IL_0197: Expected I, but got Obj
		//IL_01f3: Expected VT, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_021c: Expected VT, but got Obj
		object obj = default;
		nint num = (nint)(obj + 56);
		object obj2 = obj + 32;
		Transform transform = (Transform)(obj + 16);
		object obj3 = obj + 12;
		object obj4 = obj + 40;
		obj4 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L2 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep+UIElementType)+8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L2 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep+UIElementType)+8]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v45 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v68 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(SuperSneakers);
			((IntPtr*)num)->m_value = (void*)(nint)obj3;
			Type type = Type.internal_from_handle((IntPtr)num);
			object obj6 = default;
			if (obj6 == type)
			{
				_ = 0;
				GameObject gameObject = ((Component)(object)this).gameObject;
				((Transform)num).position = (Vector3)gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+4]");
				_ = 0;
				GameObject gameObject2 = ((Component)(object)this).gameObject;
				transform.rotation = (Quaternion)gameObject2;
				obj4 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
				_ = 0f;
			}
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v14 (Il2CppClass<System.Type>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v38 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(SuperSneakers);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Type type2 = Type.internal_from_handle((IntPtr)num);
		object obj8 = default;
		if (obj8 == type2)
		{
			_ = 1;
			GameObject gameObject3 = ((Component)(object)this).gameObject;
			((Transform)num).position = (Vector3)gameObject3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IntPtr)+4]");
			_ = 0;
			GameObject gameObject4 = ((Component)(object)this).gameObject;
			transform.rotation = (Quaternion)gameObject4;
			obj4 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F950");
			_ = 0f;
		}
	}

	public override void Initialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public override void Cleanup()
	{
		_currentState = StepState.WaitingBeforeOpen;
	}

	public unsafe override void Update(float unscaledDeltaTime)
	{
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0354: Expected Obj, but got I
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03c6: Expected I, but got Obj
		//IL_03dc: Expected Obj, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected VT, but got Unknown
		//IL_0442: Expected F4, but got Obj
		//IL_043d: Expected native int or pointer, but got VT
		//IL_0457: Expected F4, but got I
		//IL_0452: Expected native int or pointer, but got VT
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0076: Expected F4, but got Obj
		//IL_0071: Expected native int or pointer, but got VT
		//IL_008b: Expected F4, but got I
		//IL_0086: Expected native int or pointer, but got VT
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I4, but got Unknown
		//IL_00c6: Expected I4, but got Obj
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected I4, but got Unknown
		//IL_00ee: Expected I4, but got Obj
		//IL_0108: Expected F4, but got Obj
		//IL_0103: Expected native int or pointer, but got VT
		//IL_011d: Expected F4, but got I
		//IL_0118: Expected native int or pointer, but got VT
		//IL_013f: Expected I4, but got VT
		//IL_013f: Expected Obj, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0168: Expected F4, but got Obj
		//IL_0163: Expected native int or pointer, but got VT
		//IL_017d: Expected F4, but got I
		//IL_0178: Expected native int or pointer, but got VT
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_019a: Expected F4, but got I4
		//IL_01ab: Expected F4, but got Obj
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_01c0: Expected F4, but got I
		//IL_01bb: Expected native int or pointer, but got VT
		//IL_01e9: Expected I4, but got VT
		//IL_01e9: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_022e: Expected F4, but got Obj
		//IL_0229: Expected native int or pointer, but got VT
		//IL_0243: Expected F4, but got I
		//IL_023e: Expected native int or pointer, but got VT
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_028c: Expected F4, but got Obj
		//IL_0287: Expected native int or pointer, but got VT
		//IL_02a1: Expected F4, but got I
		//IL_029c: Expected native int or pointer, but got VT
		//IL_02c0: Expected I4, but got Obj
		//IL_02da: Expected I4, but got Obj
		//IL_02f4: Expected F4, but got Obj
		//IL_02ef: Expected native int or pointer, but got VT
		//IL_0309: Expected F4, but got I
		//IL_0304: Expected native int or pointer, but got VT
		//IL_032a: Expected I4, but got VT
		//IL_032a: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep)+90]");
		object obj3 = (nint)0 + (nint)236;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v6+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep)+9C]");
		float num = 0f + unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FixedRotation fixedRotation = default;
		fixedRotation.Awake();
		object obj4 = this + 160;
		obj4 = fixedRotation;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v79 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 132;
		Vector3 one = Vector3.one;
		object obj7 = obj2 + 120;
		Vector3 down = Vector3.down;
		Quaternion quaternion = (Quaternion)(obj2 + 180);
		((Quaternion*)(nint)quaternion)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v26+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		object obj8 = obj2 + 108;
		Quaternion quaternion2 = Quaternion.Inverse(quaternion);
		object obj9 = obj2 + 96;
		Vector3 down2 = Vector3.down;
		((Quaternion*)(nint)quaternion)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v33+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		object obj10 = obj2 + 84;
		Quaternion quaternion3 = Quaternion.Inverse(quaternion);
		bool flag = (byte)(obj2 + 156) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj6 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v24+8]");
		_ = 0;
		bool flag2 = (byte)(obj2 + 168) != 0;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj8 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v31+8]");
		_ = 0;
		((Quaternion*)(nint)quaternion)->x = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v37+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep)+A0]");
		((ParticleSystem)0).Simulate(0f, flag, flag2, (byte)(int)quaternion != 0);
		object obj11 = obj2 + 72;
		Vector3 down3 = Vector3.down;
		((Quaternion*)(nint)quaternion)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v48+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		object obj12 = obj2 + 60;
		Vector3 vector = (Vector3)quaternion / (float)_type;
		((Quaternion*)(nint)quaternion)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v54+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		float val = unscaledDeltaTime * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep)+A0]");
		((UIProgressBar)0).Set(val, (byte)(int)quaternion != 0);
		object obj13 = obj2 + 48;
		Vector3 one2 = Vector3.one;
		object obj14 = obj2 + 36;
		Vector3 down4 = Vector3.down;
		((Quaternion*)(nint)quaternion)->x = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v62+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		object obj15 = obj2 + 24;
		Vector3 vector2 = (Vector3)quaternion / 0.001f;
		object obj16 = obj2 + 12;
		Vector3 down5 = Vector3.down;
		((Quaternion*)(nint)quaternion)->x = (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v68+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Vector3 vector3 = (Vector3)quaternion / 0.001f;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj13 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v60+8]");
		_ = 0;
		((bool*)(flag2 ? 1 : 0))->m_value = (byte)(int)obj15 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v66+8]");
		_ = 0;
		((Quaternion*)(nint)quaternion)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.OpenCloseUIElementStep)+A0]");
		((ParticleSystem)0).Simulate(unscaledDeltaTime, flag, flag2, (byte)(int)quaternion != 0);
	}
}
