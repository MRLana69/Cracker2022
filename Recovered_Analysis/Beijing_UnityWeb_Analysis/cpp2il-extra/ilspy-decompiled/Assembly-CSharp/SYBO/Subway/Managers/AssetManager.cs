using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class AssetManager : SingletonMonoBehaviour<AssetManager>
{
	private Dictionary<EnvironmentBaseInfo, Transform> _combinedEnvBaseModels;

	protected override void SubclassInitialize()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	public Transform GetEnvironmentBaseModel(EnvironmentBaseInfo envBaseInfo)
	{
		int num = 0;
		float num3 = default;
		float num4 = default;
		while (true)
		{
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseInfo @ L1 (SYBO.Subway.Level.EnvironmentBaseInfo)+C]");
			if ((nint)num2 >= (nint)0)
			{
				break;
			}
			PickupData pickupData = ((List<PickupData>)(object)envBaseInfo).get_Item(num);
			num3 = num4 + pickupData._spawnWeight;
			int num5 = num + 1;
			num = num5;
		}
		float time = Time.time;
		float num6 = time * num3;
		int num7 = 0;
		float num8 = 0f;
		PickupData result;
		while (true)
		{
			int num9 = num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseInfo @ L1 (SYBO.Subway.Level.EnvironmentBaseInfo)+C]");
			if ((nint)num9 >= (nint)0)
			{
				result = null;
				break;
			}
			PickupData pickupData2 = ((List<PickupData>)(object)envBaseInfo).get_Item(num7);
			float num10 = num8 + pickupData2._spawnWeight;
			bool flag = !(num6 > num10);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			result = pickupData2;
			if (flag3)
			{
				break;
			}
			int num11 = num7 + 1;
			num7 = num11;
			num8 = num10;
		}
		return (Transform)(object)result;
	}

	private unsafe void CreateModelInstances(out GroundAssetGroup instances)
	{
		((InputEventArgs)(object)this)._002Ector((InputType)(int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref instances), (KeyCode)4);
	}

	private unsafe void DestroyModelInstances(ref GroundAssetGroup ga)
	{
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected Obj, but got Unknown
		//IL_0736: Expected Obj, but got I4
		//IL_0768: Expected I, but got Obj
		//IL_077e: Expected Obj, but got I
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got Unknown
		//IL_07c7: Expected Obj, but got I
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got Ref
		//IL_00dd: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got Ref
		//IL_016c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I4
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01ef: Expected Obj, but got Ref
		//IL_0200: Expected Obj, but got I
		//IL_020c: Expected Obj, but got I4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_027e: Expected Obj, but got Ref
		//IL_028f: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_0312: Expected Obj, but got Ref
		//IL_0323: Expected Obj, but got I
		//IL_032f: Expected Obj, but got I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_03a1: Expected Obj, but got Ref
		//IL_03b2: Expected Obj, but got I
		//IL_03c3: Expected Obj, but got I4
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_0435: Expected Obj, but got Ref
		//IL_0446: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_04c4: Expected Obj, but got Ref
		//IL_04d5: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected Obj, but got Unknown
		//IL_0558: Expected Obj, but got Ref
		//IL_0569: Expected Obj, but got I
		//IL_0575: Expected Obj, but got I4
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected Obj, but got Unknown
		//IL_05e7: Expected Obj, but got Ref
		//IL_05f8: Expected Obj, but got I
		//IL_0609: Expected Obj, but got I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_067b: Expected Obj, but got Ref
		//IL_068c: Expected Obj, but got I
		//IL_0698: Expected Obj, but got I4
		//IL_06fc: Expected Obj, but got Ref
		//IL_070d: Expected Obj, but got I
		//IL_071e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 728;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v159 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ThemeManager themeManager = (ThemeManager)(obj2 + 676);
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v14 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		themeManager.ThemeChanged += (Action<Theme>)0;
		obj = themeManager;
		_ = ((UnityEngine.Object)themeManager).m_CachedPtr;
		_ = themeManager._distortion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (SYBO.Subway.Themes.ThemeManager)+18]");
		_ = 0;
		_ = themeManager._theme;
		_ = themeManager._cameraCulling;
		_ = themeManager._backgroundToFogBlendStartDistance;
		object obj4 = obj2 + 624;
		obj4 = themeManager;
		_ = ((UnityEngine.Object)themeManager).m_CachedPtr;
		_ = themeManager._distortion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (SYBO.Subway.Themes.ThemeManager)+18]");
		_ = 0;
		_ = themeManager._theme;
		_ = themeManager._cameraCulling;
		_ = themeManager._backgroundToFogBlendStartDistance;
		bool flag = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)obj4);
		ref GroundAssetGroup reference = ref *(flag ? ((GroundAssetGroup*)1) : ((GroundAssetGroup*)null));
		object obj5 = obj2 + 572;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 4));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v40+4]");
		bool flag2 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj6 = flag2;
		object obj7 = obj2 + 520;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj8 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v50+8]");
		bool flag3 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj8 = flag3;
		object obj9 = obj2 + 468;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v60+C]");
		bool flag4 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj10 = flag4;
		object obj11 = obj2 + 416;
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj12 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 16));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v70+10]");
		bool flag5 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj12 = flag5;
		object obj13 = obj2 + 364;
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj14 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 20));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v80+14]");
		bool flag6 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj14 = flag6;
		object obj15 = obj2 + 312;
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj16 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 24));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v90+18]");
		bool flag7 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj16 = flag7;
		object obj17 = obj2 + 260;
		obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj18 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 28));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S0_v100+1C]");
		bool flag8 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj18 = flag8;
		object obj19 = obj2 + 208;
		obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj20 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 32));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v110+20]");
		bool flag9 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj20 = flag9;
		object obj21 = obj2 + 156;
		obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 36));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v120+24]");
		bool flag10 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj22 = flag10;
		object obj23 = obj2 + 104;
		obj23 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj24 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 40));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v130+28]");
		bool flag11 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj24 = flag11;
		object obj25 = obj2 + 52;
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj26 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 44));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v140+2C]");
		bool flag12 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj26 = flag12;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+30]");
		_ = 0;
		object obj27 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref ga, 48));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+30]");
		bool flag13 = SYBO.Common.Utilities.GameObjectUtil.IsDestroyed((GameObject)0);
		obj27 = flag13;
	}

	public void CombineGroundModels()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
		this._002Ector();
	}

	public void CombineEnvironmentBaseModelsAndStore(EnvironmentBaseInfo envBaseInfo, Transform left, Transform mid, Transform right, int preloadAmount = 2)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0064: Expected Obj, but got I4
		//IL_007a: Expected Obj, but got I
		_ = 0;
		((PickupSpawnPoint)(object)this).SetContainingRoute();
		object obj = right & 1;
		object obj2 = this - -64;
		object obj3 = right & 1;
		obj2 = obj3;
		_ = 1;
		_ = 1;
		object obj4 = preloadAmount & 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Managers.AssetManager)+64]");
		((TrackObject)0).Deactivate();
	}

	public static Transform[] GetEnvironmentBasePrefabs(EnvironmentBaseInfo envBaseInfo)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseInfo @ L0 (SYBO.Subway.Level.EnvironmentBaseInfo)+10]");
		return (Transform[])0;
	}

	public static Transform[] GetPrefabsForBaseInfo(GroundAssetGroup ga, EnvironmentBaseInfo envBaseInfo)
	{
		//IL_000e: Expected Obj, but got I4
		object result = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		return (Transform[])result;
	}

	public unsafe AssetManager()
	{
		//IL_06d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d9: Expected Ref, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Ref, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Ref, but got Unknown
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected Obj, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0746: Expected I4, but got Obj
		//IL_0746: Expected I4, but got Obj
		//IL_0746: Expected I4, but got Obj
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected Obj, but got Unknown
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected Obj, but got Unknown
		//IL_0794: Expected I4, but got Obj
		//IL_0794: Expected I4, but got Obj
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected Obj, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b0: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07f2: Expected Obj, but got I
		//IL_07f2: Expected I4, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got I
		//IL_0109: Expected I4, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I
		//IL_0167: Expected I4, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I
		//IL_01c2: Expected I4, but got Obj
		//IL_01c2: Expected I4, but got Obj
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I
		//IL_0220: Expected I4, but got Obj
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected Obj, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I
		//IL_0283: Expected I4, but got Obj
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02e1: Expected Obj, but got I
		//IL_02e1: Expected I4, but got Obj
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0344: Expected Obj, but got I
		//IL_0344: Expected I4, but got Obj
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got I
		//IL_03a2: Expected I4, but got Obj
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected Obj, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_0405: Expected Obj, but got I
		//IL_0405: Expected I4, but got Obj
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0463: Expected Obj, but got I
		//IL_0463: Expected I4, but got Obj
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected Obj, but got Unknown
		//IL_04c6: Expected Obj, but got I
		//IL_04c6: Expected I4, but got Obj
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_0524: Expected Obj, but got I
		//IL_0524: Expected I4, but got Obj
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected Obj, but got Unknown
		//IL_0559: Expected I4, but got Obj
		//IL_0567: Expected I, but got Obj
		//IL_057d: Expected Obj, but got I
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		//IL_05ac: Expected I4, but got Obj
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05e1: Expected I4, but got Obj
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0641: Expected I, but got Obj
		//IL_0657: Expected Obj, but got I
		//IL_0682: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj = default;
		((AssetManager)null).DestroyModelInstances(ref *(GroundAssetGroup*)(obj + 16));
		((AssetManager)null).DestroyModelInstances(ref *(GroundAssetGroup*)(obj + 68));
		((AssetManager)null).DestroyModelInstances(ref *(GroundAssetGroup*)(obj + 120));
		nint num = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EnvironmentBaseInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v44 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = obj + 16;
		object obj4 = obj + 68;
		object colliderName = obj + 120;
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)EnvironmentBaseInfo.Tracks0, (Character.StumbleHorizontalHit)obj3, (Character.StumbleVerticalHit)obj4, (string)colliderName, true);
		object obj5 = obj + 16;
		object obj6 = obj + 68;
		object colliderName2 = obj + 120;
		EnvironmentBaseInfo tracks = EnvironmentBaseInfo.Tracks1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v7+10]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks, (Character.StumbleHorizontalHit)obj5, Character.StumbleVerticalHit.Upper, (string)colliderName2, true);
		object obj7 = obj + 16;
		object obj8 = obj + 68;
		object obj9 = obj + 120;
		EnvironmentBaseInfo tracks1ShadowMid = EnvironmentBaseInfo.Tracks1ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v15+4]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S3_v11+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v11+4]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks1ShadowMid, (Character.StumbleHorizontalHit)num3, (Character.StumbleVerticalHit)num4, (string)0, true);
		object obj10 = obj + 16;
		object obj11 = obj + 68;
		object obj12 = obj + 120;
		EnvironmentBaseInfo tracks1ShortShadowStart = EnvironmentBaseInfo.Tracks1ShortShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v18+8]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S3_v15+20]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v15+8]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks1ShortShadowStart, (Character.StumbleHorizontalHit)num5, (Character.StumbleVerticalHit)num6, (string)0, true);
		object obj13 = obj + 16;
		object obj14 = obj + 68;
		object obj15 = obj + 120;
		EnvironmentBaseInfo tracks1ShortShadowEnd = EnvironmentBaseInfo.Tracks1ShortShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S2_v21+C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S3_v19+24]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S4_v19+C]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks1ShortShadowEnd, (Character.StumbleHorizontalHit)num7, (Character.StumbleVerticalHit)num8, (string)0, true);
		object obj16 = obj + 16;
		object obj17 = obj + 68;
		object obj18 = obj + 120;
		EnvironmentBaseInfo tracks2 = EnvironmentBaseInfo.Tracks2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S2_v24+10]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S4_v23+10]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks2, (Character.StumbleHorizontalHit)num9, (Character.StumbleVerticalHit)obj17, (string)0, true);
		object obj19 = obj + 16;
		object obj20 = obj + 68;
		object obj21 = obj + 120;
		EnvironmentBaseInfo tracks2ShadowMid = EnvironmentBaseInfo.Tracks2ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S2_v27+18]");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S3_v27+4]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S4_v27+18]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks2ShadowMid, (Character.StumbleHorizontalHit)num10, (Character.StumbleVerticalHit)num11, (string)0, true);
		object obj22 = obj + 16;
		object obj23 = obj + 68;
		object obj24 = obj + 120;
		EnvironmentBaseInfo tracks2ShortShadowStart = EnvironmentBaseInfo.Tracks2ShortShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S2_v30+20]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S3_v31+8]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S4_v31+20]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks2ShortShadowStart, (Character.StumbleHorizontalHit)num12, (Character.StumbleVerticalHit)num13, (string)0, true);
		object obj25 = obj + 16;
		object obj26 = obj + 68;
		object obj27 = obj + 120;
		EnvironmentBaseInfo tracks2ShortShadowEnd = EnvironmentBaseInfo.Tracks2ShortShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S2_v33+24]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S3_v35+C]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S4_v35+24]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks2ShortShadowEnd, (Character.StumbleHorizontalHit)num14, (Character.StumbleVerticalHit)num15, (string)0, true);
		object obj28 = obj + 16;
		object obj29 = obj + 68;
		object obj30 = obj + 120;
		EnvironmentBaseInfo tracks3 = EnvironmentBaseInfo.Tracks3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S2_v36+10]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S3_v39+10]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S4_v39+10]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3, (Character.StumbleHorizontalHit)num16, (Character.StumbleVerticalHit)num17, (string)0, true);
		object obj31 = obj + 16;
		object obj32 = obj + 68;
		object obj33 = obj + 120;
		EnvironmentBaseInfo tracks3ShadowStart = EnvironmentBaseInfo.Tracks3ShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S2_v39+14]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S3_v43+14]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S4_v43+14]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3ShadowStart, (Character.StumbleHorizontalHit)num18, (Character.StumbleVerticalHit)num19, (string)0, true);
		object obj34 = obj + 16;
		object obj35 = obj + 68;
		object obj36 = obj + 120;
		EnvironmentBaseInfo tracks3ShadowMid = EnvironmentBaseInfo.Tracks3ShadowMid;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S2_v42+18]");
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S3_v47+18]");
		nint num21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S4_v47+18]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3ShadowMid, (Character.StumbleHorizontalHit)num20, (Character.StumbleVerticalHit)num21, (string)0, true);
		object obj37 = obj + 16;
		object obj38 = obj + 68;
		object obj39 = obj + 120;
		EnvironmentBaseInfo tracks3ShadowEnd = EnvironmentBaseInfo.Tracks3ShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S2_v45+1C]");
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S3_v51+1C]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S4_v51+1C]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3ShadowEnd, (Character.StumbleHorizontalHit)num22, (Character.StumbleVerticalHit)num23, (string)0, true);
		object obj40 = obj + 16;
		object obj41 = obj + 68;
		object obj42 = obj + 120;
		EnvironmentBaseInfo tracks3ShortShadowStart = EnvironmentBaseInfo.Tracks3ShortShadowStart;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S2_v48+20]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S3_v55+20]");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S4_v55+20]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3ShortShadowStart, (Character.StumbleHorizontalHit)num24, (Character.StumbleVerticalHit)num25, (string)0, true);
		object obj43 = obj + 16;
		object obj44 = obj + 68;
		object obj45 = obj + 120;
		EnvironmentBaseInfo tracks3ShortShadowEnd = EnvironmentBaseInfo.Tracks3ShortShadowEnd;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S2_v51+24]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S3_v59+24]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S4_v59+24]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3ShortShadowEnd, (Character.StumbleHorizontalHit)num26, (Character.StumbleVerticalHit)num27, (string)0, true);
		object obj46 = obj + 16;
		EnvironmentBaseInfo tracks3Gates = EnvironmentBaseInfo.Tracks3Gates;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S3_v62+28]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3Gates, Character.StumbleHorizontalHit.Left, Character.StumbleVerticalHit.Upper, (string)null, true);
		nint num28 = (nint)typeof(EnvironmentBaseInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S1_v75 (Il2CppClass<SYBO.Subway.Level.EnvironmentBaseInfo>)+5C]");
		object obj47 = -(-64);
		object obj48 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S3_v65+2C]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)obj47, Character.StumbleHorizontalHit.Left, Character.StumbleVerticalHit.Upper, (string)null, true);
		object obj49 = obj + 16;
		EnvironmentBaseInfo tracks3Special = EnvironmentBaseInfo.Tracks3Special;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S3_v68+30]");
		((Character)(object)this).NotifyOnStumble((Character.StumbleType)tracks3Special, Character.StumbleHorizontalHit.Left, Character.StumbleVerticalHit.Upper, (string)null, true);
		EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs> value = (EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs>)(obj + 16);
		((QualitySettingsManager)null).OnQualityTypeChanged += value;
		EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs> value2 = (EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs>)(obj + 68);
		((QualitySettingsManager)null).OnQualityTypeChanged += value2;
		EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs> value3 = (EventHandler<QualitySettingsManager.QualityTypeChangedEventArgs>)(obj + 120);
		((QualitySettingsManager)null).OnQualityTypeChanged += value3;
		nint num29 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S0_v35 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj50 = (nint)0 & (nint)0x200;
		if (obj50 != null)
		{
			nint num30 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v40 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PoolManager.BeginBalancing(null);
	}
}
