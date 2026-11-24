using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Debugging;
using Info;
using Kiloo;
using SYBO.Subway;
using SYBO.Subway.Info;
using UI.Generic.Layout;
using UI.Screens.PauseScreenInternal;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace WeeklyHunt;

public static class WeeklyHuntManager
{
	private static bool _hasInited;

	private static Action m_itemCountUpdated;

	public static Vector3 HUNT_ITEM_POSITION_OFFSET;

	public static Vector3 HUNT_ITEM_ROTATION;

	public static Vector3 HUNT_ITEM_SCALE_OFFSET;

	public static bool canCollectAllTokensInOneRun;

	private static Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData> huntPeriodData
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FPSCounter instance = FPSCounter.Instance;
			return (Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(instance.UpdateInterval - instance.frames);
		}
	}

	public unsafe static event Action itemCountUpdated
	{
		add
		{
			//IL_016c: Expected Obj, but got I4
			//IL_0188: Expected I, but got F4
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected Obj, but got Unknown
			//IL_019f: Expected Obj, but got I4
			//IL_01a8: Expected Obj, but got F4
			//IL_01bc: Expected I, but got Obj
			//IL_01d2: Expected Obj, but got I
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected Obj, but got Unknown
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Expected VT, but got Unknown
			//IL_0220: Expected F4, but got Obj
			//IL_021b: Expected native int or pointer, but got VT
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			//IL_0248: Expected F4, but got Obj
			//IL_0243: Expected native int or pointer, but got VT
			//IL_025d: Expected F4, but got I
			//IL_0258: Expected native int or pointer, but got VT
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected Obj, but got Unknown
			//IL_0278: Expected Obj, but got F4
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected Obj, but got Unknown
			//IL_0299: Expected Obj, but got I4
			//IL_02a2: Expected Obj, but got F4
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Expected Obj, but got Unknown
			//IL_02cb: Expected F4, but got Obj
			//IL_02c6: Expected native int or pointer, but got VT
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected Obj, but got Unknown
			//IL_02f3: Expected F4, but got Obj
			//IL_02ee: Expected native int or pointer, but got VT
			//IL_0308: Expected F4, but got I
			//IL_0303: Expected native int or pointer, but got VT
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Expected Obj, but got Unknown
			//IL_0323: Expected Obj, but got F4
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Expected Obj, but got Unknown
			//IL_0344: Expected Obj, but got I4
			//IL_034d: Expected Obj, but got F4
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Expected Obj, but got Unknown
			//IL_0376: Expected F4, but got Obj
			//IL_0371: Expected native int or pointer, but got VT
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Expected Obj, but got Unknown
			//IL_005f: Expected F4, but got Obj
			//IL_005a: Expected native int or pointer, but got VT
			//IL_0074: Expected F4, but got I
			//IL_006f: Expected native int or pointer, but got VT
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_008f: Expected Obj, but got F4
			//IL_00a2: Expected Obj, but got I4
			//IL_00ab: Expected Obj, but got F4
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Expected Obj, but got Unknown
			//IL_00d4: Expected F4, but got Obj
			//IL_00cf: Expected native int or pointer, but got VT
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected Obj, but got Unknown
			//IL_00fc: Expected F4, but got Obj
			//IL_00f7: Expected native int or pointer, but got VT
			//IL_0111: Expected F4, but got I
			//IL_010c: Expected native int or pointer, but got VT
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Expected Obj, but got Unknown
			//IL_012c: Expected Obj, but got F4
			//IL_0013: Expected I, but got Obj
			((Delegate)value).m_target = 1;
			((Delegate)value).method = (IntPtr)4;
			((Delegate)value).delegate_trampoline = (IntPtr)2.5f;
			object obj2 = default;
			object obj = obj2 + 40;
			obj = 0;
			obj = 13.64f;
			_ = 0f;
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v78 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = obj2 + 56;
			obj4 = obj;
			Vector4 vector = (Vector4)(obj2 + 112);
			((Vector4*)(nint)vector)->x = (float)obj4;
			object obj5 = obj2 + 100;
			Vector3 vector2 = vector;
			((Vector4*)(nint)vector)->x = (float)obj5;
			Vector4 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25+8]");
			((Vector4*)(nint)vector3)->z = 0f;
			object obj6 = value + 28;
			obj6 = vector.x;
			_ = vector.z;
			object obj7 = obj2 + 24;
			obj7 = 0;
			obj7 = -10f;
			_ = -15.97f;
			object obj8 = obj2 + 48;
			obj8 = obj7;
			((Vector4*)(nint)vector)->x = (float)obj8;
			object obj9 = obj2 + 88;
			Vector3 vector4 = vector;
			((Vector4*)(nint)vector)->x = (float)obj9;
			Vector4 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v39+8]");
			((Vector4*)(nint)vector5)->z = 0f;
			object obj10 = value + 40;
			obj10 = vector.x;
			_ = vector.z;
			object obj11 = obj2 + 8;
			obj11 = 0;
			obj11 = -33.5f;
			_ = 0f;
			object obj12 = obj2 + 32;
			obj12 = obj11;
			((Vector4*)(nint)vector)->x = (float)obj12;
			object obj13 = obj2 + 76;
			Vector3 vector6 = vector;
			((Vector4*)(nint)vector)->x = (float)obj13;
			Vector4 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v53+8]");
			((Vector4*)(nint)vector7)->z = 0f;
			object obj14 = value + 52;
			obj14 = vector.x;
			_ = vector.z;
			obj2 = 0;
			obj2 = 36.66f;
			_ = 0.5f;
			object obj15 = obj2 + 16;
			obj15 = obj2;
			((Vector4*)(nint)vector)->x = (float)obj15;
			object obj16 = obj2 - -64;
			Vector3 vector8 = vector;
			((Vector4*)(nint)vector)->x = (float)obj16;
			Vector4 vector9 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v66+8]");
			((Vector4*)(nint)vector9)->z = 0f;
			object obj17 = value - -64;
			obj17 = vector.x;
			_ = vector.z;
			_ = 30;
			_ = 29;
			_ = 30;
			_ = 29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = WeeklyHuntManager.m_itemCountUpdated;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(WeeklyHuntManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(WeeklyHuntManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(WeeklyHuntManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public unsafe static bool IsAnyPeriodActive()
	{
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected VT, but got Unknown
		//IL_0328: Expected VT, but got I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I4
		//IL_0359: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_0565: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_058a: Expected VT, but got Obj
		//IL_04f4: Expected Ref, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_007a: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got VT
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I4
		//IL_00ea: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I4
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_043a: Expected Obj, but got I
		//IL_0442: Expected Obj, but got VT
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I4
		//IL_01be: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I4
		//IL_0254: Expected I4, but got Obj
		//IL_0270: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_02b1: Expected I, but got Obj
		object obj = default;
		Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.Enumerator enumerator = (Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.Enumerator)(obj + 88);
		enumerator = (Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.Enumerator)0;
		_ = 0;
		_ = 0;
		object obj2 = obj + 48;
		obj2 = 0;
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v137 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj + 56;
		object obj5 = obj + 24;
		object obj6 = obj + 16;
		object obj7 = obj + 40;
		object obj8 = obj + 32;
		object obj9 = obj + 8;
		object obj10 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		enumerator = (Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.Enumerator)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v32+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v32+10]");
		_ = 0;
		bool result;
		while (true)
		{
			if (((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.Enumerator*)enumerator)->MoveNext())
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHunt.WeeklyHuntData+WeeklyHuntPeriodData>+Enumerator<System.Int32, WeeklyHunt.WeeklyHuntData+WeeklyHuntPeriodData>)+C]");
				obj5 = 0;
				obj2 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Collections.Generic.Dictionary`2<System.Int32, WeeklyHunt.WeeklyHuntData+WeeklyHuntPeriodData>+Enumerator<System.Int32, WeeklyHunt.WeeklyHuntData+WeeklyHuntPeriodData>)+C]");
				obj6 = 0;
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+4]");
				object obj11 = 0;
				DateTime today = CDateTime.Today;
				nint num3 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v68 (Il2CppClass<System.DateTime>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num4 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v133 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v61+20]");
				obj7 = 0;
				obj8 = today;
				obj4 = obj7;
				obj10 = obj8;
				object obj13 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj14 = obj10 & 0x3FFFFFFFFFFFFFFFL;
				object obj15;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
				{
					obj15 = 1;
				}
				else
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14);
					object obj16 = (flag ? 1u : 0u) << 31;
					obj15 = obj16 >> 31;
				}
				if ((nint)obj15 < 0)
				{
					continue;
				}
				DateTime today2 = CDateTime.Today;
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v86 (Il2CppClass<System.DateTime>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num6 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v124 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v61+18]");
				obj9 = 0;
				obj = today2;
				obj4 = obj9;
				obj10 = obj;
				object obj18 = obj4 & 0x3FFFFFFFFFFFFFFFL;
				object obj19 = obj10 & 0x3FFFFFFFFFFFFFFFL;
				object obj20;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19))
				{
					obj20 = 1;
				}
				else
				{
					bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19);
					object obj21 = (flag2 ? 1u : 0u) << 31;
					obj20 = obj21 >> 31;
				}
				if ((nint)obj20 > 0)
				{
					continue;
				}
				bool flag3 = (nint)obj2 != 4;
				result = (byte)(int)obj2 != 0;
				if (flag3)
				{
					break;
				}
				nint num7 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v104 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num8 = (nint)typeof(WeeklyHuntData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v113 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(WeeklyHuntData.hideLastPeriod ? 1u : 0u) != 0)
				{
					result = true;
					break;
				}
				continue;
			}
			result = false;
			break;
		}
		return result;
	}

	public static bool IsHuntStillActive()
	{
		//IL_0212: Expected I, but got Obj
		//IL_0228: Expected Obj, but got I
		//IL_02e7: Expected I, but got Obj
		//IL_02fd: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_01a9: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v58 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnRunStarted();
		nint num3 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v54 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = IsAnyPeriodActive();
		if (flag)
		{
			nint num5 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v50 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FPSCounter instance = FPSCounter.Instance;
			WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(flag ? 1 : 0);
			if (weeklyHuntPeriodData.itemsCollected < weeklyHuntPeriodData.itemsToCollect)
			{
				if (weeklyHuntPeriodData.itemsCollected == 0)
				{
					nint num7 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(WeeklyHuntManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v44 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					canCollectAllTokensInOneRun = true;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static WeeklyHuntData.PeriodStatus GetPeriodStatus(WeeklyHuntData.PrizePeriodId period)
	{
		//IL_00bb: Expected Obj, but got I4
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0136: Expected Obj, but got VT
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TimeSpan timeLeftForActivePeriod = GetTimeLeftForActivePeriod();
		obj = timeLeftForActivePeriod;
		nint num3 = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v23 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF7");
		string text = default;
		bool flag = (string)period == text;
		return (WeeklyHuntData.PeriodStatus)((flag ? 1 : 0) ^ 1);
	}

	public static WeeklyHuntData.WeeklyHuntPeriodData GetPrizeDataForPeriod(WeeklyHuntData.PrizePeriodId period)
	{
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_0302: Expected Obj, but got VT
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0318: Expected Obj, but got VT
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0113: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I4
		//IL_0521: Expected I, but got Obj
		//IL_0537: Expected Obj, but got I
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got VT
		//IL_0478: Expected Obj, but got VT
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected Obj, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected Obj, but got Unknown
		//IL_013d: Expected I, but got Obj
		//IL_0153: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I4
		//IL_020e: Expected I, but got Obj
		//IL_03c7: Expected Obj, but got VT
		//IL_03cf: Expected Obj, but got VT
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_017e: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I4
		//IL_0200: Expected Obj, but got I4
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v111 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnRunStarted();
		FPSCounter instance = FPSCounter.Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item((int)period);
		DateTime today = CDateTime.Today;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v107 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 24;
		object obj5 = obj4 + 16;
		object obj6 = obj4 + 40;
		obj6 = weeklyHuntPeriodData.periodEndDate;
		object obj7 = obj4 + 32;
		obj7 = today;
		object obj8 = obj4 + 48;
		obj8 = obj6;
		object obj9 = obj4 + 56;
		obj9 = obj7;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		object obj11 = obj9 & 0x3FFFFFFFFFFFFFFFL;
		object obj12;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			obj12 = 1;
		}
		else
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11);
			object obj13 = (flag ? 1u : 0u) << 31;
			obj12 = obj13 >> 31;
		}
		if ((nint)obj12 >= 0)
		{
			DateTime today2 = CDateTime.Today;
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v76 (Il2CppClass<System.DateTime>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v97 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = weeklyHuntPeriodData.periodStartDate;
			obj5 = today2;
			obj8 = obj3;
			obj9 = obj5;
			object obj15 = obj8 & 0x3FFFFFFFFFFFFFFFL;
			object obj16 = obj9 & 0x3FFFFFFFFFFFFFFFL;
			object obj17;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
			{
				obj17 = 1;
			}
			else
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16);
				object obj18 = (flag2 ? 1u : 0u) << 31;
				obj17 = obj18 >> 31;
			}
			if ((nint)obj17 <= 0)
			{
				return (WeeklyHuntData.WeeklyHuntPeriodData)2;
			}
		}
		DateTime today3 = CDateTime.Today;
		nint num7 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v49 (Il2CppClass<System.DateTime>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num8 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v69 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj20 = obj4 + 8;
		obj20 = weeklyHuntPeriodData.periodEndDate;
		obj4 = today3;
		obj8 = obj20;
		obj9 = obj4;
		object obj21 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		object obj22 = obj9 & 0x3FFFFFFFFFFFFFFFL;
		object obj23;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			obj23 = 1;
		}
		else
		{
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22);
			object obj24 = (flag3 ? 1u : 0u) << 31;
			obj23 = obj24 >> 31;
		}
		return (WeeklyHuntData.WeeklyHuntPeriodData)(obj23 >> 31);
	}

	public static bool CanSpawnToken()
	{
		//IL_038b: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03df: Expected I, but got Obj
		//IL_03f5: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		//IL_01e6: Expected Obj, but got I
		//IL_0112: Expected I, but got Obj
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_0462: Expected Obj, but got VT
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got VT
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected Obj, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected Obj, but got Unknown
		//IL_027a: Expected Obj, but got I4
		//IL_0211: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I4
		//IL_02a4: Expected I, but got Obj
		//IL_02ba: Expected Obj, but got I
		//IL_0519: Expected Obj, but got VT
		//IL_0521: Expected Obj, but got VT
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_034e: Expected Obj, but got I4
		//IL_02e5: Expected I, but got Obj
		//IL_032d: Expected Obj, but got I4
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v117 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnRunStarted();
		FPSCounter instance = FPSCounter.Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(1);
		nint num3 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v111 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hideLastPeriod = WeeklyHuntData.hideLastPeriod;
		nint num5 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v8 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		int key;
		if (hideLastPeriod)
		{
			if (!flag)
			{
				nint num6 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v107 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = 3;
		}
		else
		{
			if (!flag)
			{
				nint num7 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v99 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = 4;
		}
		FPSCounter instance2 = FPSCounter.Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData2 = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance2).get_Item(key);
		DateTime today = CDateTime.Today;
		nint num8 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v34 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v91 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		object obj5 = obj6 + 8;
		object obj7 = obj6 + 24;
		obj7 = weeklyHuntPeriodData2.periodEndDate;
		object obj8 = obj6 + 16;
		obj8 = today;
		object obj9 = obj6 + 32;
		obj9 = obj7;
		object obj10 = obj6 + 40;
		obj10 = obj8;
		object obj11 = obj9 & 0x3FFFFFFFFFFFFFFFL;
		object obj12 = obj10 & 0x3FFFFFFFFFFFFFFFL;
		object obj13;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			obj13 = 1;
		}
		else
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
			object obj14 = (flag2 ? 1u : 0u) << 31;
			obj13 = obj14 >> 31;
		}
		if ((nint)obj13 >= 0)
		{
			DateTime today2 = CDateTime.Today;
			nint num10 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v62 (Il2CppClass<System.DateTime>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num11 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v82 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = weeklyHuntPeriodData.periodStartDate;
			obj6 = today2;
			obj9 = obj5;
			obj10 = obj6;
			object obj16 = obj9 & 0x3FFFFFFFFFFFFFFFL;
			object obj17 = obj10 & 0x3FFFFFFFFFFFFFFFL;
			object obj18;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17))
			{
				obj18 = 1;
			}
			else
			{
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17);
				object obj19 = (flag3 ? 1u : 0u) << 31;
				obj18 = obj19 >> 31;
			}
			if ((nint)obj18 <= 0)
			{
				return true;
			}
		}
		return false;
	}

	public static bool GetHiddenUntilUnlockedForPeriod(WeeklyHuntData.PrizePeriodId period)
	{
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02eb: Expected I, but got Obj
		//IL_0301: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_0346: Expected I4, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01ae: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v57 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnRunStarted();
		WeeklyHuntData.PrizePeriodId prizePeriodId = default;
		WeeklyHuntData.PrizePeriodId prizePeriodId2;
		if (prizePeriodId != WeeklyHuntData.PrizePeriodId.None)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v49 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v53 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		else
		{
			nint num5 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v42 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hideLastPeriod = WeeklyHuntData.hideLastPeriod;
			nint num7 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v8 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 != null;
			if (hideLastPeriod)
			{
				if (!flag)
				{
					prizePeriodId = WeeklyHuntData.PrizePeriodId.PeriodThree;
				}
				else
				{
					nint num8 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v36 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						prizePeriodId2 = WeeklyHuntData.PrizePeriodId.PeriodThree;
						goto IL_034b;
					}
					prizePeriodId = WeeklyHuntData.PrizePeriodId.PeriodThree;
				}
			}
			else if (!flag)
			{
				prizePeriodId = WeeklyHuntData.PrizePeriodId.PeriodFour;
			}
			else
			{
				nint num9 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					prizePeriodId2 = WeeklyHuntData.PrizePeriodId.PeriodFour;
					goto IL_034b;
				}
				prizePeriodId = WeeklyHuntData.PrizePeriodId.PeriodFour;
			}
		}
		goto IL_032c;
		IL_032c:
		FPSCounter instance = FPSCounter.Instance;
		return (byte)(int)((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item((int)prizePeriodId) != 0;
		IL_034b:
		prizePeriodId = prizePeriodId2;
		goto IL_032c;
	}

	private static CelebrationReward GetRewardForPeriod(WeeklyHuntData.PrizePeriodId period)
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnRunStarted();
		if (period != WeeklyHuntData.PrizePeriodId.None)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v24 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FPSCounter instance = FPSCounter.Instance;
			WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item((int)period);
			bool hiddenUntilUnlocked = weeklyHuntPeriodData.hiddenUntilUnlocked;
			return (CelebrationReward)hiddenUntilUnlocked;
		}
		return null;
	}

	public static void ItemPickedUp()
	{
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected Obj, but got Unknown
		//IL_06a6: Expected Obj, but got I4
		//IL_06ec: Expected Obj, but got I
		//IL_06fc: Expected Obj, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_071b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0720: Expected Obj, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected Obj, but got Unknown
		//IL_0774: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0126: Expected Obj, but got I
		//IL_0136: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected Obj, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b6: Expected Obj, but got I4
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0244: Expected Obj, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02cc: Expected Obj, but got I
		//IL_02dc: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected Obj, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected Obj, but got Unknown
		//IL_035c: Expected Obj, but got I4
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected Obj, but got Unknown
		//IL_03ea: Expected Obj, but got I4
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0478: Expected Obj, but got I
		//IL_0488: Expected Obj, but got I
		//IL_0498: Expected Obj, but got I
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I4
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_0543: Expected Obj, but got I4
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected Obj, but got Unknown
		//IL_0588: Expected Obj, but got I4
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_061c: Expected Obj, but got I
		//IL_062c: Expected Obj, but got I
		//IL_063c: Expected Obj, but got I
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected Obj, but got Unknown
		//IL_0670: Expected I, but got Obj
		//IL_0686: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 156;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		WeeklyHuntData.hideLastPeriod = true;
		WeeklyHuntData._hasInited = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S3_v3+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 10;
		_ = 0;
		_ = 0;
		object obj9 = default;
		object obj8 = obj9 + 20;
		obj8 = "WEEKLY_HUNT_PERIOD_ONE_PERIOD_TITLE";
		object obj10 = obj2 + 72;
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj11 = obj2 + 120;
		obj11 = obj10;
		object obj12 = obj2 + 128;
		obj12 = obj11;
		object obj13 = obj2 - -64;
		obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj14 = obj2 + 112;
		obj14 = obj13;
		obj12 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 3;
		_ = 3;
		_ = 2;
		_ = 3;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		object obj15 = obj9 + 40;
		obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+18]");
		_ = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S4_v8 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S4_v9+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S4_v10+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v168 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 20;
		_ = 0;
		_ = 0;
		object obj22 = default;
		object obj21 = obj22 + 20;
		obj21 = "WEEKLY_HUNT_PERIOD_TWO_PERIOD_TITLE";
		object obj23 = obj2 + 48;
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj24 = obj2 + 104;
		obj24 = obj23;
		obj12 = obj24;
		object obj25 = obj2 + 40;
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj26 = obj2 + 96;
		obj26 = obj25;
		obj12 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 1;
		_ = 5;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		object obj27 = obj22 + 40;
		obj27 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+18]");
		_ = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S4_v15 (Il2CppMethodInfo)+C]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S4_v16+60]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S4_v17+48]");
		object obj30 = 0;
		object obj31 = obj30 & 0x7FF;
		object obj32 = obj31 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v276 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 25;
		_ = 0;
		_ = 0;
		object obj34 = default;
		object obj33 = obj34 + 20;
		obj33 = "WEEKLY_HUNT_PERIOD_THREE_PERIOD_TITLE";
		object obj35 = obj2 + 32;
		obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj36 = obj2 + 88;
		obj36 = obj35;
		obj12 = obj36;
		object obj37 = obj2 + 16;
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj38 = obj2 + 80;
		obj38 = obj37;
		obj12 = obj38;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 7;
		_ = 3;
		_ = 6;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		object obj39 = obj34 + 40;
		obj39 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+18]");
		_ = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S4_v22 (Il2CppMethodInfo)+C]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S4_v23+60]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S4_v24+48]");
		object obj42 = 0;
		object obj43 = obj42 & 0x7FF;
		object obj44 = obj43 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v386 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 10;
		_ = 0;
		_ = 0;
		object obj46 = default;
		object obj45 = obj46 + 20;
		obj45 = "WEEKLY_HUNT_PERIOD_FOUR_PERIOD_TITLE";
		object obj47 = obj2 + 8;
		obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj48 = obj2 + 56;
		obj48 = obj47;
		obj12 = obj48;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC83");
		object obj49 = obj2 + 24;
		obj49 = obj2;
		obj12 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = 2;
		_ = 3;
		_ = 2;
		_ = 15;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
		_ = 0;
		object obj50 = obj46 + 40;
		obj50 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+18]");
		_ = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S4_v29 (Il2CppMethodInfo)+C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S4_v30+60]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S4_v31+48]");
		object obj53 = 0;
		object obj54 = obj53 & 0x7FF;
		object obj55 = obj54 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v495 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v168 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+5C]");
		object obj56 = (nint)0 + (nint)4;
		object obj57 = default;
		obj56 = obj57;
	}

	private static void InitIfNeeded()
	{
		//IL_07c6: Expected Obj, but got I4
		//IL_07d4: Expected I, but got Obj
		//IL_07ea: Expected Obj, but got I
		//IL_0b04: Expected I, but got Obj
		//IL_0b1a: Expected Obj, but got I
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected Obj, but got Unknown
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected Obj, but got Unknown
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0831: Expected Obj, but got Unknown
		//IL_083a: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0875: Expected I, but got Obj
		//IL_088b: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_06ef: Expected I, but got Obj
		//IL_08c7: Expected Obj, but got I
		//IL_08d7: Expected Obj, but got I
		//IL_08e7: Expected Obj, but got I
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected Obj, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_091b: Expected I, but got Obj
		//IL_0931: Expected Obj, but got I
		//IL_073c: Expected I, but got Obj
		//IL_0752: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_018c: Expected I, but got Obj
		//IL_077d: Expected I, but got Obj
		//IL_01e3: Expected I, but got Obj
		//IL_01f9: Expected Obj, but got I
		//IL_0996: Expected Obj, but got VT
		//IL_0224: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v167 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnRunStarted();
		nint num3 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v163 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj + 20;
		object obj5 = obj + 16;
		object obj6 = obj + 12;
		object obj7 = obj + 8;
		bool key = IsAnyPeriodActive();
		FPSCounter instance = FPSCounter.Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(key ? 1 : 0);
		if (weeklyHuntPeriodData.itemsCollected < weeklyHuntPeriodData.itemsToCollect)
		{
			int itemsCollected = weeklyHuntPeriodData.itemsCollected + 1;
			weeklyHuntPeriodData.itemsCollected = itemsCollected;
			nint num5 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v68 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v159 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FPSCounter instance2 = FPSCounter.Instance;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v4+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v5+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S5_v5 (should have been resolved before IL gen)");
			nint num8 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v76 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v155 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((WeeklyHuntIconPositioning)null).ForceUpdate();
			if (weeklyHuntPeriodData.itemsCollected == weeklyHuntPeriodData.itemsToCollect)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num10 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v88 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num11 = (nint)typeof(WeeklyHuntData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v151 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TimeSpan timeLeftForActivePeriod = GetTimeLeftForActivePeriod();
				obj = timeLeftForActivePeriod;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBF");
				object obj16 = default;
				obj4 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
		}
		nint num12 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v37 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num13 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v60 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (WeeklyHuntManager.m_itemCountUpdated == null)
		{
			return;
		}
		nint num14 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v47 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num15 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v54 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
	}

	private unsafe static void OnRunStarted()
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_01e0: Expected Obj, but got I
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0249: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_hasInited ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v45 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_hasInited = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnRunStarted);
		object obj3 = action + 16;
		obj3 = 0;
		nint num5 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v29 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v41 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)(delegate*<void>)(&OnRunEnded);
		object obj5 = action2 + 16;
		obj5 = 0;
		Game.OnMenuScreenShown -= action2;
	}

	private static void OnRunEnded()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = IsAnyPeriodActive();
		if (!flag)
		{
			return;
		}
		nint num3 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v36 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FPSCounter instance = FPSCounter.Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(flag ? 1 : 0);
		if (weeklyHuntPeriodData.itemsCollected != 0)
		{
			return;
		}
		nint num5 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v30 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		canCollectAllTokensInOneRun = true;
	}

	private static void OnWeekCompleted()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		canCollectAllTokensInOneRun = false;
	}

	public static int GetPrizeDataCount()
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (IsHuntStillActive())
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v24 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool period = IsAnyPeriodActive();
			nint num5 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v13 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool hiddenUntilUnlockedForPeriod = GetHiddenUntilUnlockedForPeriod(period ? WeeklyHuntData.PrizePeriodId.PeriodOne : WeeklyHuntData.PrizePeriodId.None);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (System.Boolean)+C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21 (System.Boolean)+8]");
			return (num7 < 0) ? 1 : 0;
		}
		return 0;
	}

	public static bool IsBoardAwardedInCurrentPeriod(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_0f27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Expected Obj, but got Unknown
		//IL_0f35: Expected Obj, but got I4
		//IL_0f55: Expected I, but got Obj
		//IL_0f6b: Expected Obj, but got I
		//IL_1150: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Expected Obj, but got Unknown
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected Obj, but got Unknown
		//IL_116c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1171: Expected Obj, but got Unknown
		//IL_1190: Expected Obj, but got I
		//IL_11a0: Expected Obj, but got I
		//IL_11b0: Expected Obj, but got I
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11be: Expected Obj, but got Unknown
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected Obj, but got Unknown
		//IL_0029: Expected I, but got Obj
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0658: Expected F4, but got I
		//IL_066d: Expected F4, but got I
		//IL_00b7: Expected I, but got Obj
		//IL_107e: Expected I, but got Obj
		//IL_1094: Expected Obj, but got I
		//IL_123e: Expected F4, but got I
		//IL_1253: Expected F4, but got I
		//IL_06d2: Expected F4, but got I
		//IL_06e7: Expected F4, but got I
		//IL_0140: Expected F4, but got I
		//IL_0155: Expected F4, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_0ea1: Expected I, but got Obj
		//IL_02e1: Expected F4, but got I
		//IL_02f6: Expected F4, but got I
		//IL_074c: Expected F4, but got I
		//IL_0761: Expected F4, but got I
		//IL_03bb: Expected F4, but got I
		//IL_03d0: Expected F4, but got I
		//IL_027b: Expected F4, but got I
		//IL_0290: Expected F4, but got I
		//IL_02aa: Expected I4, but got Obj
		//IL_10bf: Expected I, but got Obj
		//IL_10d5: Expected Obj, but got I
		//IL_050c: Expected F4, but got I
		//IL_0521: Expected F4, but got I
		//IL_0541: Expected I, but got Obj
		//IL_0557: Expected Obj, but got I
		//IL_0355: Expected F4, but got I
		//IL_036a: Expected F4, but got I
		//IL_037c: Expected Obj, but got F4
		//IL_0384: Expected I4, but got Obj
		//IL_12ad: Expected F4, but got I
		//IL_12c2: Expected F4, but got I
		//IL_07c6: Expected F4, but got I
		//IL_07db: Expected F4, but got I
		//IL_104a: Expected I4, but got Obj
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected Obj, but got Unknown
		//IL_0432: Expected F4, but got I
		//IL_0447: Expected F4, but got I
		//IL_0466: Expected I4, but got Obj
		//IL_0e54: Expected I, but got Obj
		//IL_0582: Expected I, but got Obj
		//IL_0840: Expected F4, but got I
		//IL_0855: Expected F4, but got I
		//IL_04a6: Expected F4, but got I
		//IL_04bb: Expected F4, but got I
		//IL_04cd: Expected Obj, but got F4
		//IL_04d5: Expected I4, but got Obj
		//IL_0960: Expected F4, but got I
		//IL_0975: Expected F4, but got I
		//IL_09ce: Expected Obj, but got I
		//IL_0896: Expected I, but got Obj
		//IL_08ac: Expected Obj, but got I
		//IL_0b01: Expected F4, but got I
		//IL_0b16: Expected F4, but got I
		//IL_0bdb: Expected F4, but got I
		//IL_0bf0: Expected F4, but got I
		//IL_0a9b: Expected F4, but got I
		//IL_0ab0: Expected F4, but got I
		//IL_0aca: Expected I4, but got Obj
		//IL_08d7: Expected I, but got Obj
		//IL_0d2c: Expected F4, but got I
		//IL_0d41: Expected F4, but got I
		//IL_0d61: Expected I, but got Obj
		//IL_0d77: Expected Obj, but got I
		//IL_0b75: Expected F4, but got I
		//IL_0b8a: Expected F4, but got I
		//IL_0b9c: Expected Obj, but got F4
		//IL_0ba4: Expected I4, but got Obj
		//IL_1121: Expected I4, but got Obj
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected Obj, but got Unknown
		//IL_0c52: Expected F4, but got I
		//IL_0c67: Expected F4, but got I
		//IL_0c86: Expected I4, but got Obj
		//IL_0da2: Expected I, but got Obj
		//IL_0cc6: Expected F4, but got I
		//IL_0cdb: Expected F4, but got I
		//IL_0ced: Expected Obj, but got F4
		//IL_0cf5: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 140;
		obj = boardId;
		object obj3 = obj2 + 112;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v298 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FPSCounter fPSCounter = (FPSCounter)(obj2 + 84);
		object obj5 = obj2 + 56;
		object obj6 = obj2 + 28;
		FPSCounter instance = FPSCounter.Instance;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v3+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v4+44]");
		object obj9 = 0;
		object obj10 = obj9 & 0x1FFF;
		object obj11 = obj10 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74 @ S3_v4 (should have been resolved before IL gen)");
		object obj12 = default;
		if ((nint)obj12 > -1)
		{
			nint num4 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v42 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num5 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v294 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			fPSCounter.ToggleVisible((byte)boardId != 0);
			obj3 = fPSCounter;
			_ = ((UnityEngine.Object)fPSCounter).m_CachedPtr;
			_ = fPSCounter.UpdateInterval;
			_ = fPSCounter.accum;
			obj5 = fPSCounter;
			_ = ((UnityEngine.Object)fPSCounter).m_CachedPtr;
			_ = fPSCounter.UpdateInterval;
			_ = fPSCounter.accum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+4]");
			if ((nint)0 == 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				DailyChallengeRewardHelper dailyChallengeRewardHelper = default;
				dailyChallengeRewardHelper.Refresh();
				fPSCounter = (FPSCounter)obj3;
				FPSCounter fPSCounter2 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
				((UnityEngine.Object)fPSCounter2).m_CachedPtr = (IntPtr)0;
				FPSCounter fPSCounter3 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
				fPSCounter3.UpdateInterval = 0f;
				FPSCounter fPSCounter4 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
				fPSCounter4.accum = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
				((UnityEngine.Object)dailyChallengeRewardHelper).m_CachedPtr = (IntPtr)0;
				obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
				dailyChallengeRewardHelper._rewardLayout = (Layout)0;
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
				_ = 0;
				dailyChallengeRewardHelper._checkmark = (UISprite)obj6;
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if ((nint)0 == 2)
				{
					fPSCounter = (FPSCounter)obj3;
					FPSCounter fPSCounter5 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
					((UnityEngine.Object)fPSCounter5).m_CachedPtr = (IntPtr)0;
					FPSCounter fPSCounter6 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
					fPSCounter6.UpdateInterval = 0f;
					FPSCounter fPSCounter7 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
					fPSCounter7.accum = 0f;
					dailyChallengeRewardHelper._superMysteryBoxReward = (GameObject)(object)fPSCounter.OptionalMinFPSLabel;
					bool flag = (byte)(int)dailyChallengeRewardHelper != 0;
				}
				else
				{
					fPSCounter = (FPSCounter)obj3;
					FPSCounter fPSCounter8 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
					((UnityEngine.Object)fPSCounter8).m_CachedPtr = (IntPtr)0;
					FPSCounter fPSCounter9 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
					fPSCounter9.UpdateInterval = 0f;
					FPSCounter fPSCounter10 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
					fPSCounter10.accum = 0f;
					if (((UnityEngine.Object)fPSCounter).m_CachedPtr == (IntPtr)8)
					{
						fPSCounter = (FPSCounter)obj3;
						FPSCounter fPSCounter11 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
						((UnityEngine.Object)fPSCounter11).m_CachedPtr = (IntPtr)0;
						FPSCounter fPSCounter12 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
						fPSCounter12.UpdateInterval = 0f;
						FPSCounter fPSCounter13 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
						fPSCounter13.accum = 0f;
						dailyChallengeRewardHelper._rewardLabel = (UILabel)fPSCounter.UpdateInterval;
						bool flag = (byte)(int)dailyChallengeRewardHelper != 0;
					}
					else
					{
						fPSCounter = (FPSCounter)obj3;
						FPSCounter fPSCounter14 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
						((UnityEngine.Object)fPSCounter14).m_CachedPtr = (IntPtr)0;
						FPSCounter fPSCounter15 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
						fPSCounter15.UpdateInterval = 0f;
						FPSCounter fPSCounter16 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
						fPSCounter16.accum = 0f;
						if (((UnityEngine.Object)fPSCounter).m_CachedPtr == (IntPtr)7)
						{
							fPSCounter = (FPSCounter)obj3;
							FPSCounter fPSCounter17 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
							((UnityEngine.Object)fPSCounter17).m_CachedPtr = (IntPtr)0;
							FPSCounter fPSCounter18 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
							fPSCounter18.UpdateInterval = 0f;
							FPSCounter fPSCounter19 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
							fPSCounter19.accum = 0f;
							dailyChallengeRewardHelper._6BagsReward = (GameObject)(object)fPSCounter._label;
							nint num6 = (nint)typeof(BoardManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ S1_v317 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
							object obj14 = (nint)0 & (nint)0x200;
							if (obj14 != null)
							{
								nint num7 = (nint)typeof(BoardManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S1_v332 (Il2CppClass<Data.Managers.BoardManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							BoardManager.LockBoard((Boards.BoardId)dailyChallengeRewardHelper._6BagsReward);
							_0021_00210[] array = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
							object obj15 = dailyChallengeRewardHelper + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							throw new NullReferenceException();
						}
						fPSCounter = (FPSCounter)obj3;
						FPSCounter fPSCounter20 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
						((UnityEngine.Object)fPSCounter20).m_CachedPtr = (IntPtr)0;
						FPSCounter fPSCounter21 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
						fPSCounter21.UpdateInterval = 0f;
						FPSCounter fPSCounter22 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
						fPSCounter22.accum = 0f;
						bool flag2 = ((UnityEngine.Object)fPSCounter).m_CachedPtr != (IntPtr)3;
						bool flag = (byte)(int)dailyChallengeRewardHelper != 0;
						if (!flag2)
						{
							fPSCounter = (FPSCounter)obj3;
							FPSCounter fPSCounter23 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
							((UnityEngine.Object)fPSCounter23).m_CachedPtr = (IntPtr)0;
							FPSCounter fPSCounter24 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
							fPSCounter24.UpdateInterval = 0f;
							FPSCounter fPSCounter25 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
							fPSCounter25.accum = 0f;
							dailyChallengeRewardHelper._rewardLabel = (UILabel)fPSCounter.UpdateInterval;
							flag = (byte)(int)dailyChallengeRewardHelper != 0;
						}
					}
				}
			}
			else
			{
				fPSCounter = (FPSCounter)obj3;
				FPSCounter fPSCounter26 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
				((UnityEngine.Object)fPSCounter26).m_CachedPtr = (IntPtr)0;
				FPSCounter fPSCounter27 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
				fPSCounter27.UpdateInterval = 0f;
				FPSCounter fPSCounter28 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
				fPSCounter28.accum = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
				bool flag;
				if ((nint)0 != 5)
				{
					fPSCounter = (FPSCounter)obj3;
					FPSCounter fPSCounter29 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
					((UnityEngine.Object)fPSCounter29).m_CachedPtr = (IntPtr)0;
					FPSCounter fPSCounter30 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
					fPSCounter30.UpdateInterval = 0f;
					FPSCounter fPSCounter31 = fPSCounter;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
					fPSCounter31.accum = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
					if ((nint)0 != 2)
					{
						fPSCounter = (FPSCounter)obj3;
						FPSCounter fPSCounter32 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
						((UnityEngine.Object)fPSCounter32).m_CachedPtr = (IntPtr)0;
						FPSCounter fPSCounter33 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
						fPSCounter33.UpdateInterval = 0f;
						FPSCounter fPSCounter34 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
						fPSCounter34.accum = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
						if ((nint)0 != 4)
						{
							fPSCounter = (FPSCounter)obj3;
							FPSCounter fPSCounter35 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
							((UnityEngine.Object)fPSCounter35).m_CachedPtr = (IntPtr)0;
							FPSCounter fPSCounter36 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
							fPSCounter36.UpdateInterval = 0f;
							FPSCounter fPSCounter37 = fPSCounter;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
							fPSCounter37.accum = 0f;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
							if ((nint)0 != 1)
							{
								fPSCounter = (FPSCounter)obj3;
								FPSCounter fPSCounter38 = fPSCounter;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
								((UnityEngine.Object)fPSCounter38).m_CachedPtr = (IntPtr)0;
								FPSCounter fPSCounter39 = fPSCounter;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
								fPSCounter39.UpdateInterval = 0f;
								FPSCounter fPSCounter40 = fPSCounter;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
								fPSCounter40.accum = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
								if ((nint)0 != 6)
								{
									nint num8 = (nint)typeof(MysteryBox);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v206 (Il2CppClass<MysteryBox>)+BA]");
									object obj16 = (nint)0 & (nint)0x200;
									if (obj16 != null)
									{
										nint num9 = (nint)typeof(MysteryBox);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S0_v212 (Il2CppClass<MysteryBox>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Normal);
									_ = 3;
									flag = (byte)megaJackpotAmount != 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
									DailyChallengeRewardHelper dailyChallengeRewardHelper2 = default;
									dailyChallengeRewardHelper2.Refresh();
									fPSCounter = (FPSCounter)obj3;
									FPSCounter fPSCounter41 = fPSCounter;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
									((UnityEngine.Object)fPSCounter41).m_CachedPtr = (IntPtr)0;
									FPSCounter fPSCounter42 = fPSCounter;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
									fPSCounter42.UpdateInterval = 0f;
									FPSCounter fPSCounter43 = fPSCounter;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
									fPSCounter43.accum = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
									((UnityEngine.Object)dailyChallengeRewardHelper2).m_CachedPtr = (IntPtr)0;
									obj5 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
									dailyChallengeRewardHelper2._rewardLayout = (Layout)0;
									obj6 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
									_ = 0;
									dailyChallengeRewardHelper2._checkmark = (UISprite)obj6;
									obj2 = obj3;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
									if ((nint)0 == 2)
									{
										fPSCounter = (FPSCounter)obj3;
										FPSCounter fPSCounter44 = fPSCounter;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
										((UnityEngine.Object)fPSCounter44).m_CachedPtr = (IntPtr)0;
										FPSCounter fPSCounter45 = fPSCounter;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
										fPSCounter45.UpdateInterval = 0f;
										FPSCounter fPSCounter46 = fPSCounter;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
										fPSCounter46.accum = 0f;
										dailyChallengeRewardHelper2._superMysteryBoxReward = (GameObject)(object)fPSCounter.OptionalMinFPSLabel;
										flag = (byte)(int)dailyChallengeRewardHelper2 != 0;
									}
									else
									{
										fPSCounter = (FPSCounter)obj3;
										FPSCounter fPSCounter47 = fPSCounter;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
										((UnityEngine.Object)fPSCounter47).m_CachedPtr = (IntPtr)0;
										FPSCounter fPSCounter48 = fPSCounter;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
										fPSCounter48.UpdateInterval = 0f;
										FPSCounter fPSCounter49 = fPSCounter;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
										fPSCounter49.accum = 0f;
										if (((UnityEngine.Object)fPSCounter).m_CachedPtr == (IntPtr)8)
										{
											fPSCounter = (FPSCounter)obj3;
											FPSCounter fPSCounter50 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
											((UnityEngine.Object)fPSCounter50).m_CachedPtr = (IntPtr)0;
											FPSCounter fPSCounter51 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
											fPSCounter51.UpdateInterval = 0f;
											FPSCounter fPSCounter52 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
											fPSCounter52.accum = 0f;
											dailyChallengeRewardHelper2._rewardLabel = (UILabel)fPSCounter.UpdateInterval;
											flag = (byte)(int)dailyChallengeRewardHelper2 != 0;
										}
										else
										{
											fPSCounter = (FPSCounter)obj3;
											FPSCounter fPSCounter53 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
											((UnityEngine.Object)fPSCounter53).m_CachedPtr = (IntPtr)0;
											FPSCounter fPSCounter54 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
											fPSCounter54.UpdateInterval = 0f;
											FPSCounter fPSCounter55 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
											fPSCounter55.accum = 0f;
											if (((UnityEngine.Object)fPSCounter).m_CachedPtr == (IntPtr)7)
											{
												fPSCounter = (FPSCounter)obj3;
												FPSCounter fPSCounter56 = fPSCounter;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
												((UnityEngine.Object)fPSCounter56).m_CachedPtr = (IntPtr)0;
												FPSCounter fPSCounter57 = fPSCounter;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
												fPSCounter57.UpdateInterval = 0f;
												FPSCounter fPSCounter58 = fPSCounter;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
												fPSCounter58.accum = 0f;
												dailyChallengeRewardHelper2._6BagsReward = (GameObject)(object)fPSCounter._label;
												nint num10 = (nint)typeof(BoardManager);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S1_v187 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
												object obj17 = (nint)0 & (nint)0x200;
												if (obj17 != null)
												{
													nint num11 = (nint)typeof(BoardManager);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ S1_v202 (Il2CppClass<Data.Managers.BoardManager>)+74]");
													if ((nint)0 == 0)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
													}
												}
												BoardManager.LockBoard((Boards.BoardId)dailyChallengeRewardHelper2._6BagsReward);
												_0021_00210[] array2 = (_0021_00210[])(object)UnityEngine.Object.FindObjectsOfType<T>();
												object obj18 = dailyChallengeRewardHelper2 + 32;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
												throw new NullReferenceException();
											}
											fPSCounter = (FPSCounter)obj3;
											FPSCounter fPSCounter59 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
											((UnityEngine.Object)fPSCounter59).m_CachedPtr = (IntPtr)0;
											FPSCounter fPSCounter60 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
											fPSCounter60.UpdateInterval = 0f;
											FPSCounter fPSCounter61 = fPSCounter;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
											fPSCounter61.accum = 0f;
											bool flag3 = ((UnityEngine.Object)fPSCounter).m_CachedPtr != (IntPtr)3;
											flag = (byte)(int)dailyChallengeRewardHelper2 != 0;
											if (!flag3)
											{
												fPSCounter = (FPSCounter)obj3;
												FPSCounter fPSCounter62 = fPSCounter;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
												((UnityEngine.Object)fPSCounter62).m_CachedPtr = (IntPtr)0;
												FPSCounter fPSCounter63 = fPSCounter;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
												fPSCounter63.UpdateInterval = 0f;
												FPSCounter fPSCounter64 = fPSCounter;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
												fPSCounter64.accum = 0f;
												dailyChallengeRewardHelper2._rewardLabel = (UILabel)fPSCounter.UpdateInterval;
												flag = (byte)(int)dailyChallengeRewardHelper2 != 0;
											}
										}
									}
								}
								goto IL_1011;
							}
						}
						nint num12 = (nint)typeof(MysteryBox);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v98 (Il2CppClass<MysteryBox>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num13 = (nint)typeof(MysteryBox);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v109 (Il2CppClass<MysteryBox>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int megaJackpotAmount2 = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Normal);
						fPSCounter = (FPSCounter)obj3;
						FPSCounter fPSCounter65 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
						((UnityEngine.Object)fPSCounter65).m_CachedPtr = (IntPtr)0;
						FPSCounter fPSCounter66 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
						fPSCounter66.UpdateInterval = 0f;
						FPSCounter fPSCounter67 = fPSCounter;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
						fPSCounter67.accum = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
						_ = 0;
						flag = (byte)megaJackpotAmount2 != 0;
						goto IL_1011;
					}
				}
				nint num14 = (nint)typeof(MysteryBox);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v67 (Il2CppClass<MysteryBox>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num15 = (nint)typeof(MysteryBox);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v78 (Il2CppClass<MysteryBox>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int megaJackpotAmount3 = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Super);
				fPSCounter = (FPSCounter)obj3;
				FPSCounter fPSCounter68 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+8]");
				((UnityEngine.Object)fPSCounter68).m_CachedPtr = (IntPtr)0;
				FPSCounter fPSCounter69 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+10]");
				fPSCounter69.UpdateInterval = 0f;
				FPSCounter fPSCounter70 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11+18]");
				fPSCounter70.accum = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Debugging.FPSCounter)+4]");
				_ = 0;
				flag = (byte)megaJackpotAmount3 != 0;
			}
		}
		else
		{
			bool flag = false;
		}
		goto IL_1011;
		IL_1011:
		_ = 8;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public static int ItemsCollectedForBoardType(Boards.BoardId boardId)
	{
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Expected Obj, but got I4
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0112: Expected F4, but got I
		//IL_0127: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 + 56;
		obj = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v54 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FPSCounter fPSCounter = (FPSCounter)(obj2 + 28);
		bool flag = IsAnyPeriodActive();
		if (flag)
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v50 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			fPSCounter.ToggleVisible(flag);
			obj = fPSCounter;
			_ = ((UnityEngine.Object)fPSCounter).m_CachedPtr;
			_ = fPSCounter.UpdateInterval;
			_ = fPSCounter.accum;
			obj2 = fPSCounter;
			_ = ((UnityEngine.Object)fPSCounter).m_CachedPtr;
			_ = fPSCounter.UpdateInterval;
			_ = fPSCounter.accum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			if ((nint)0 == 7)
			{
				fPSCounter = (FPSCounter)obj;
				FPSCounter fPSCounter2 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)fPSCounter2).m_CachedPtr = (IntPtr)0;
				FPSCounter fPSCounter3 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
				fPSCounter3.UpdateInterval = 0f;
				FPSCounter fPSCounter4 = fPSCounter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+18]");
				fPSCounter4.accum = 0f;
				return ((nint)fPSCounter._label == (nint)boardId) ? 1 : 0;
			}
			return 0;
		}
		return 0;
	}

	public static int ItemsToCollectForBoardType(Boards.BoardId boardId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_0506: Expected Obj, but got I4
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_055f: Expected I, but got Obj
		//IL_0575: Expected Obj, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I4
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_05af: Expected I, but got Obj
		//IL_05c5: Expected Obj, but got I
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_0228: Expected I, but got Obj
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 - -64;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 56;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v167 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 28;
		FPSCounter instance = FPSCounter.Instance;
		Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.KeyCollection keys = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+8]");
		_ = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v102 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num4 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v160 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+18]");
				_ = 0;
				obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if ((nint)0 != 7)
				{
					continue;
				}
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+14]");
				if ((nint)0 != (nint)boardId)
				{
					continue;
				}
				nint num5 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v130 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v153 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj11 = obj5 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj5 + obj13;
				obj14 = 97;
				break;
			}
			object obj15 = obj5 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj5 + obj17;
			obj18 = 95;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj5 + obj19;
			if ((nint)obj20 == 97)
			{
				object obj21 = obj5 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_067f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj5 + obj23;
			if ((nint)obj24 == 95)
			{
				object obj25 = obj5 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_067f;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_067f;
		IL_067f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v143+C]");
		return 0;
	}

	public static WeeklyHuntData.PrizeData GetPrizeForPeriod(WeeklyHuntData.PrizePeriodId periodId)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I4, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.PrizeData prizeData = default;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = WeeklyHuntData._huntPeriodData.get_Item((int)prizeData);
		weeklyHuntPeriodData.itemsCollected = (int)periodId;
		((WeeklyHuntIconPositioning)null).ForceUpdate();
		return prizeData;
	}

	public static WeeklyHuntData.WeeklyHuntPrize DeterminePrize(WeeklyHuntData.PrizeData prizeData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Expected Obj, but got Unknown
		//IL_0506: Expected Obj, but got I4
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I4
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_055f: Expected I, but got Obj
		//IL_0575: Expected Obj, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_030b: Expected Obj, but got I4
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0393: Expected Obj, but got I
		//IL_045a: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_0201: Invalid comparison between I and VT
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected Obj, but got Unknown
		//IL_05af: Expected I, but got Obj
		//IL_05c5: Expected Obj, but got I
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected Obj, but got Unknown
		//IL_0228: Expected I, but got Obj
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 - -64;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 56;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v167 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 28;
		FPSCounter instance = FPSCounter.Instance;
		Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>.KeyCollection keys = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @821F");
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+8]");
		_ = 0;
		object obj8 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v102 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num4 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v160 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+18]");
				_ = 0;
				obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				if ((nint)0 != 7)
				{
					continue;
				}
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v28+14]");
				if ((object)0 != (object)prizeData)
				{
					continue;
				}
				nint num5 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v130 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(WeeklyHuntManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S0_v153 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj11 = obj5 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj5 + obj13;
				obj14 = 97;
				break;
			}
			object obj15 = obj5 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj5 + obj17;
			obj18 = 95;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj5 + obj19;
			if ((nint)obj20 == 97)
			{
				object obj21 = obj5 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_067f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj5 + obj23;
			if ((nint)obj24 == 95)
			{
				object obj25 = obj5 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_067f;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_067f;
		IL_067f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v143+8]");
		return WeeklyHuntData.WeeklyHuntPrize.NotAvailable;
	}

	public static string Get(WeeklyHuntData.PrizeData prizeData)
	{
		//IL_01c7: Expected Obj, but got I4
		//IL_0020: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got I
		//IL_00ac: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_00f2: Expected Obj, but got I
		//IL_015f: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		object obj = prizeData.amount;
		_ = prizeData.rewardType;
		_ = prizeData.characterId;
		_ = prizeData.trophyType;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 == 5)
		{
			return (string)2;
		}
		obj = prizeData.amount;
		_ = prizeData.rewardType;
		_ = prizeData.characterId;
		_ = prizeData.trophyType;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj2 = (nint)0 + (nint)(-6);
		if (obj2 != null)
		{
			if ((nint)obj2 == 1)
			{
				SDebug.LogFormat("Unknown BoardType", null);
			}
			obj = prizeData.amount;
			_ = prizeData.rewardType;
			_ = prizeData.characterId;
			_ = prizeData.trophyType;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			object obj3 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			if ((nint)0 != 1)
			{
				if ((nint)obj3 != 1 && (nint)obj3 == 2)
				{
					return (string)5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				if ((nint)0 == 15)
				{
					return (string)4;
				}
				return null;
			}
			return (string)3;
		}
		return (string)1;
	}

	public unsafe static string GetPrizeTitle(WeeklyHuntData.PrizeData prizeData)
	{
		//IL_0658: Expected Obj, but got I4
		//IL_0684: Expected I, but got Obj
		//IL_069a: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected VT, but got Unknown
		//IL_0782: Expected I4, but got Obj
		//IL_077d: Expected native int or pointer, but got VT
		//IL_0792: Expected native int or pointer, but got VT
		//IL_07a7: Expected native int or pointer, but got VT
		//IL_07bc: Expected native int or pointer, but got VT
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_021c: Expected I, but got Obj
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_02aa: Expected I, but got Obj
		//IL_02f7: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_0338: Expected I, but got Obj
		//IL_0385: Expected I, but got Obj
		//IL_039b: Expected Obj, but got I
		//IL_03c6: Expected I, but got Obj
		//IL_0413: Expected I, but got Obj
		//IL_0429: Expected Obj, but got I
		//IL_0454: Expected I, but got Obj
		//IL_04a1: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I
		//IL_04e2: Expected I, but got Obj
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_0570: Expected I, but got Obj
		//IL_05bd: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I
		//IL_05fe: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		object obj = prizeData.amount;
		_ = prizeData.rewardType;
		_ = prizeData.characterId;
		_ = prizeData.trophyType;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v138 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.PrizeData prizeData2 = (WeeklyHuntData.PrizeData)(obj + 28);
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->amount = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->rewardType = CelebrationRewardType._notset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->characterId = Characters.CharacterId.slick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->trophyType = Trophies.Trophy.diamond;
		string text = Get(prizeData2);
		object obj3 = text - 1;
		if ((nint)text != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2)
				{
					if ((nint)obj3 != 3)
					{
						if ((nint)obj3 != 4)
						{
							if ((nint)obj3 != 5)
							{
								if ((nint)obj3 != 6)
								{
									if ((nint)obj3 != 7)
									{
										if ((nint)obj3 == 8)
										{
											nint num3 = (nint)typeof(Strings);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v123 (Il2CppClass<Strings>)+BA]");
											object obj4 = (nint)0 & (nint)0x200;
											if (obj4 != null)
											{
												nint num4 = (nint)typeof(Strings);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v130 (Il2CppClass<Strings>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											return Strings.GetDefault("WEEKLYHUNT_PRIZE_CHERRY");
										}
										return string.Empty;
									}
									nint num5 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v111 (Il2CppClass<Strings>)+BA]");
									object obj5 = (nint)0 & (nint)0x200;
									if (obj5 != null)
									{
										nint num6 = (nint)typeof(Strings);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v118 (Il2CppClass<Strings>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									return Strings.GetDefault("HOVERBOARDS_LONDONBOARD03");
								}
								nint num7 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v99 (Il2CppClass<Strings>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num8 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v106 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								return Strings.GetDefault("WEEKLYHUNT_PRIZE_RIO");
							}
							nint num9 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v87 (Il2CppClass<Strings>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num10 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v94 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							return Strings.GetDefault("HOVERBOARDS_LONDONBOARD01");
						}
						nint num11 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v75 (Il2CppClass<Strings>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num12 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v82 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return Strings.GetDefault("WEEKLYHUNT_PRIZE_HEADSTART_TITLE");
					}
					nint num13 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v63 (Il2CppClass<Strings>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num14 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return Strings.GetDefault("WEEKLYHUNT_PRIZE_SCOREBOOSTER_TITLE");
				}
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v51 (Il2CppClass<Strings>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num16 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v58 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return Strings.GetDefault("WEEKLYHUNT_PRIZE_HOVERBOARD_TITLE");
			}
			nint num17 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v39 (Il2CppClass<Strings>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num18 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v46 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return Strings.GetDefault("WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE");
		}
		nint num19 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v27 (Il2CppClass<Strings>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num20 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Strings.GetDefault("WEEKLYHUNT_PRIZE_KEYS_TITLE");
	}

	public unsafe static string GetPrizeTitleShort(WeeklyHuntData.PrizeData prizeData)
	{
		//IL_0658: Expected Obj, but got I4
		//IL_0684: Expected I, but got Obj
		//IL_069a: Expected Obj, but got I
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_0775: Expected VT, but got Unknown
		//IL_0782: Expected I4, but got Obj
		//IL_077d: Expected native int or pointer, but got VT
		//IL_0792: Expected native int or pointer, but got VT
		//IL_07a7: Expected native int or pointer, but got VT
		//IL_07bc: Expected native int or pointer, but got VT
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected Obj, but got Unknown
		//IL_01db: Expected I, but got Obj
		//IL_01f1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_021c: Expected I, but got Obj
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_02aa: Expected I, but got Obj
		//IL_02f7: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_0338: Expected I, but got Obj
		//IL_0385: Expected I, but got Obj
		//IL_039b: Expected Obj, but got I
		//IL_03c6: Expected I, but got Obj
		//IL_0413: Expected I, but got Obj
		//IL_0429: Expected Obj, but got I
		//IL_0454: Expected I, but got Obj
		//IL_04a1: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I
		//IL_04e2: Expected I, but got Obj
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_0570: Expected I, but got Obj
		//IL_05bd: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I
		//IL_05fe: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		object obj = prizeData.amount;
		_ = prizeData.rewardType;
		_ = prizeData.characterId;
		_ = prizeData.trophyType;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v138 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.PrizeData prizeData2 = (WeeklyHuntData.PrizeData)(obj + 28);
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->amount = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->rewardType = CelebrationRewardType._notset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->characterId = Characters.CharacterId.slick;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
		((WeeklyHuntData.PrizeData*)(nint)prizeData2)->trophyType = Trophies.Trophy.diamond;
		string text = Get(prizeData2);
		object obj3 = text - 1;
		if ((nint)text != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 != 2)
				{
					if ((nint)obj3 != 3)
					{
						if ((nint)obj3 != 4)
						{
							if ((nint)obj3 != 5)
							{
								if ((nint)obj3 != 6)
								{
									if ((nint)obj3 != 7)
									{
										if ((nint)obj3 == 8)
										{
											nint num3 = (nint)typeof(Strings);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v123 (Il2CppClass<Strings>)+BA]");
											object obj4 = (nint)0 & (nint)0x200;
											if (obj4 != null)
											{
												nint num4 = (nint)typeof(Strings);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v130 (Il2CppClass<Strings>)+74]");
												if ((nint)0 == 0)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
												}
											}
											return Strings.GetDefault("WEEKLYHUNT_PRIZE_CHERRY");
										}
										return string.Empty;
									}
									nint num5 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v111 (Il2CppClass<Strings>)+BA]");
									object obj5 = (nint)0 & (nint)0x200;
									if (obj5 != null)
									{
										nint num6 = (nint)typeof(Strings);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v118 (Il2CppClass<Strings>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									return Strings.GetDefault("HOVERBOARDS_LONDONBOARD03");
								}
								nint num7 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v99 (Il2CppClass<Strings>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num8 = (nint)typeof(Strings);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v106 (Il2CppClass<Strings>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								return Strings.GetDefault("WEEKLYHUNT_PRIZE_RIO");
							}
							nint num9 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v87 (Il2CppClass<Strings>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num10 = (nint)typeof(Strings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v94 (Il2CppClass<Strings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							return Strings.GetDefault("HOVERBOARDS_LONDONBOARD01");
						}
						nint num11 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v75 (Il2CppClass<Strings>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num12 = (nint)typeof(Strings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v82 (Il2CppClass<Strings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return Strings.GetDefault("WEEKLYHUNT_PRIZE_HEADSTART_TITLE");
					}
					nint num13 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v63 (Il2CppClass<Strings>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num14 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v70 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return Strings.GetDefault("WEEKLYHUNT_PRIZE_SCOREBOOSTER_TITLE");
				}
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v51 (Il2CppClass<Strings>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num16 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v58 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return Strings.GetDefault("WEEKLYHUNT_PRIZE_HOVERBOARD_TITLE");
			}
			nint num17 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v39 (Il2CppClass<Strings>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num18 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v46 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return Strings.GetDefault("WEEKLYHUNT_PRIZE_SUPERMYSTERYBOX_TITLE");
		}
		nint num19 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v27 (Il2CppClass<Strings>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num20 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v34 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return Strings.GetDefault("WEEKLYHUNT_PRIZE_KEYS_TITLE");
	}

	public static TimeSpan GetTimeLeftForActivePeriod()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(WeeklyHuntData._hasInited ? 1u : 0u) != 0)
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v32 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v37 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			WeeklyHuntData.LoadProgressFromResources();
		}
		nint num5 = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = WeeklyHuntData._huntPeriodData.get_Item(1);
		return (TimeSpan)weeklyHuntPeriodData.periodStartDate;
	}

	public unsafe static DateTime GetEndTimeForActivePeriod()
	{
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0217: Expected I, but got Obj
		//IL_022d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got VT
		//IL_01b9: Expected Obj, but got VT
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected VT, but got Unknown
		//IL_01d4: Expected I8, but got Obj
		//IL_01cf: Expected native int or pointer, but got VT
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01f7: Expected Ref, but got VT
		//IL_01fb: Expected VT, but got I8
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v48 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool key = IsAnyPeriodActive();
		nint num3 = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v44 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FPSCounter instance = FPSCounter.Instance;
		WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)(object)instance).get_Item(key ? 1 : 0);
		DateTime today = CDateTime.Today;
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v27 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v40 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 8;
		obj4 = weeklyHuntPeriodData.periodEndDate;
		obj5 = today;
		DateTime dateTime = (DateTime)(obj5 + 16);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		IFormatProvider formatProvider = (IFormatProvider)(obj5 + 24);
		formatProvider = (IFormatProvider)obj5;
		return (DateTime)((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
	}

	static WeeklyHuntManager()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I4
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(canCollectAllTokensInOneRun ? 1u : 0u) == 0)
		{
			((NewMonoBehaviour)36)._002Ector();
		}
	}
}
