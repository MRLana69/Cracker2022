using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Data;

[Serializable]
public class StackablePrefabData
{
	private List<GameObject> _prefabs;

	private StackableBuildDirection _stackableBuildDirection;

	public List<GameObject> Prefabs
	{
		get
		{
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected Obj, but got Unknown
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			object obj = obj2 + 84;
			object obj3 = this + 8;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v6+8]");
			_ = 0;
			object obj4 = obj2 + 72;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	public StackableBuildDirection StackableBuildDirection
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (StackableBuildDirection)_prefabs;
		}
	}

	public unsafe StackablePrefabData()
	{
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02e0: Invalid comparison between Obj and F4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Ref, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0055: Expected I, but got Obj
		//IL_006b: Expected Obj, but got I
		//IL_0362: Expected F4, but got Obj
		//IL_0362: Expected F4, but got Obj
		//IL_0362: Expected F4, but got Obj
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0326: Invalid comparison between I and F4
		//IL_0096: Expected I, but got Obj
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Ref, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got F4
		//IL_041a: Expected F4, but got I
		//IL_041a: Expected F4, but got I
		//IL_041a: Expected F4, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected Obj, but got Unknown
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03c6: Invalid comparison between I and F4
		//IL_0183: Expected I, but got Obj
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Ref, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected Obj, but got Unknown
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_048d: Expected F4, but got I
		//IL_048d: Expected F4, but got I
		//IL_048d: Expected F4, but got I
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_026d: Expected I, but got Obj
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		object obj = this + 32;
		object obj2 = this + 20;
		float maxSpeed = default;
		if (obj2 == (object)0f)
		{
			object obj3 = this + 8;
			obj = obj3;
		}
		else
		{
			object obj4 = this + 8;
			ref float currentVelocity = ref *(float*)(this + 44);
			object obj5 = this + 20;
			float unscaledTime = Time.unscaledTime;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S4_v34 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v39 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = Mathf.SmoothDampAngle((float)obj, (float)obj4, ref currentVelocity, (float)obj5, maxSpeed, unscaledTime);
			object obj7 = num3 & 0x7FFFFFFF;
			if ((nint)obj7 <= 2139095040)
			{
				object obj8 = this + 32;
				obj8 = num3;
			}
		}
		object obj9 = this + 32;
		object obj10 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v15+4]");
		if (0f == 0f)
		{
			object obj11 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v32+4]");
			_ = 0;
		}
		else
		{
			object obj12 = this + 8;
			ref float currentVelocity2 = ref *(float*)(this + 48);
			object obj13 = this + 20;
			float unscaledTime2 = Time.unscaledTime;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S4_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S4_v26 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v13+4]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v25+4]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S3_v10+4]");
			float num8 = Mathf.SmoothDampAngle(num6, num7, ref currentVelocity2, 0f, maxSpeed, unscaledTime2);
			object obj15 = num8 & 0x7FFFFFFF;
			if ((nint)obj15 <= 2139095040)
			{
				object obj16 = this + 32;
			}
		}
		object obj17 = this + 32;
		object obj18 = this + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v22+8]");
		if (0f == 0f)
		{
			object obj19 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v22+8]");
			_ = 0;
			return;
		}
		object obj20 = this + 8;
		ref float currentVelocity3 = ref *(float*)(this + 52);
		object obj21 = this + 20;
		float unscaledTime3 = Time.unscaledTime;
		nint num9 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S4_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S4_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v20+8]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v15+8]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S3_v6+8]");
		float num13 = Mathf.SmoothDampAngle(num11, num12, ref currentVelocity3, 0f, maxSpeed, unscaledTime3);
		object obj23 = num13 & 0x7FFFFFFF;
		if ((nint)obj23 <= 2139095040)
		{
			object obj24 = this + 32;
		}
	}
}
