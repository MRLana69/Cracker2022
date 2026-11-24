using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

public class Glow : MonoBehaviour
{
	private MeshRenderer meshRenderer;

	private bool _isDebugGlowEnabled;

	public bool IsDebugGlowEnabled
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)meshRenderer != 0;
		}
		internal set
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003b: Expected Obj, but got I
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected Obj, but got Unknown
			//IL_0070: Expected Obj, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+38]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
			((DailyLetterPickupManager)value).InitializePickup((DailyLetterPickup)(object)meshRenderer);
		}
	}

	public void Awake()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		object obj = this + 16;
		obj = hashSet;
		CancelInvoke();
	}

	public void SetVisible(bool visible)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0290: Expected Obj, but got I
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I4
		//IL_0099: Expected Obj, but got F4
		//IL_0061: Expected Obj, but got I4
		//IL_0070: Expected Obj, but got F4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		_isDebugGlowEnabled = visible;
		object obj5 = obj2 + 40;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S4_v4 (should have been resolved before IL gen)");
		IEnumerable source = default;
		IEnumerable<_0021_00210> enumerable = (IEnumerable<_0021_00210>)Enumerable.OfType<TResult>(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19+8]");
		_ = 0;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (~(_isDebugGlowEnabled ? 1u : 0u) == 0)
			{
				obj2 = 0;
				_ = 0;
				obj2 = 1f;
				_ = 1f;
				_ = 1f;
			}
			else
			{
				obj2 = 0;
				_ = 0;
				obj2 = 0f;
				_ = 0f;
				_ = 0f;
			}
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj11 = obj4 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj4 + obj13;
		obj14 = 121;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 121)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				return;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public Glow()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04e6: Expected I, but got Obj
		//IL_04fc: Expected Obj, but got I
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00cb: Expected I, but got Obj
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected Obj, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_062e: Expected I, but got Obj
		//IL_0644: Expected Obj, but got I
		//IL_0307: Expected Obj, but got I
		//IL_017e: Expected I, but got Obj
		//IL_0194: Expected Obj, but got I
		//IL_03bf: Expected I, but got Obj
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_01bf: Expected I, but got Obj
		//IL_0428: Expected I, but got Obj
		//IL_043e: Expected Obj, but got I
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_05df: Expected Obj, but got I4
		//IL_0469: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<DeviceInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v130 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (System.Int32)+8]");
		if ((nint)0 == 0)
		{
			GameObject gameObject = base.gameObject;
			_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)(object)gameObject).GetComponentsInParent<T>();
			nint num3 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v100 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)componentsInParent).FindKernel((string)null) != 0)
			{
				GameObject gameObject2 = base.gameObject;
				object current = ((Transform.Enumerator)(object)gameObject2).Current;
				object obj5 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj5 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num5 = (nint)typeof(Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v123 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
				object obj7 = obj2 + 4;
				object obj8 = obj7 + 1;
				obj7 = obj8;
				object obj9 = obj8 << 2;
				object obj10 = obj2 + obj9;
				obj10 = 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj11 = default;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj12 = (nint)0 << 2;
					object obj13 = obj2 + obj12;
					if ((nint)obj13 == 96)
					{
						object obj14 = obj2 + 4;
						if ((nint)obj14 > -1)
						{
							object obj15 = obj14 + -1;
							obj14 = obj15;
						}
						goto IL_0603;
					}
				}
				object obj16 = default;
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0603;
			}
		}
		object obj17 = this + 12;
		MeshRenderer componentInChildren = GetComponentInChildren<MeshRenderer>();
		obj17 = componentInChildren;
		return;
		IL_0603:
		object obj18 = this + 12;
		MeshRenderer componentInChildren2 = GetComponentInChildren<MeshRenderer>();
		obj18 = componentInChildren2;
		nint num7 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num8 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)meshRenderer).FindKernel((string)null) == 0)
		{
			return;
		}
		meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
		tag = null;
		nint num9 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num10 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S1_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Object.DestroyImmediate(meshRenderer);
		object obj21 = this + 12;
		obj21 = 0;
	}
}
