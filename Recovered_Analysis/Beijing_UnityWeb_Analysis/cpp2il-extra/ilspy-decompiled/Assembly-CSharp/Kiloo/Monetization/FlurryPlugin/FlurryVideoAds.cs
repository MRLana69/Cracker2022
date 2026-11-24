using System;
using AppRefresh;
using Cpp2ILInjected;
using Kiloo.Monetization.FacebookAds;
using Kiloo.Monetization.FlurryPlugin.Internal;
using Kiloo.Serialization;
using UnityEngine;

namespace Kiloo.Monetization.FlurryPlugin;

public static class FlurryVideoAds
{
	private static IFlurryVideoAds _platformBridge;

	private static bool _initialized;

	private static FlurryAdsCallback m_onTakeoverWillDisplay;

	private static FlurryAdsCallback m_onTakeoverWillClose;

	private static FlurryAdsCallback m_onVideoDidFinish;

	private static FlurryAdsCallback m_onVideoDidNotFinish;

	private static FlurryAdsCallback m_onVideoAvailable;

	private static FlurryAdsCallback m_onVideoUnavailable;

	private static FlurryAdsCallback m_onVideoClicked;

	private static Action<bool> m_onInitFinished;

	public static event FlurryAdsCallback onTakeoverWillDisplay
	{
		add
		{
			//IL_00ef: Expected I, but got Obj
			//IL_0105: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!IsSupportedOnPlatform())
			{
				return;
			}
			nint num3 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onTakeoverWillDisplay;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)8;
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

	public static event FlurryAdsCallback onTakeoverWillClose
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onTakeoverWillDisplay;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)8;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onTakeoverWillClose;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)12;
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

	public static event FlurryAdsCallback onVideoDidFinish
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onTakeoverWillClose;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)12;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoDidFinish;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)16;
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

	public static event FlurryAdsCallback onVideoDidNotFinish
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoDidFinish;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)16;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoDidNotFinish;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)20;
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

	public static event FlurryAdsCallback onVideoAvailable
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoDidNotFinish;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)20;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoAvailable;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)24;
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

	public static event FlurryAdsCallback onVideoUnavailable
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoAvailable;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)24;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoUnavailable;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)28;
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

	public static event FlurryAdsCallback onVideoClicked
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoUnavailable;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)28;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoClicked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)32;
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

	public static event Action<bool> onInitFinished
	{
		add
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onVideoClicked;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)32;
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
			nint num = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FlurryVideoAds.m_onInitFinished;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FlurryVideoAds);
				if (!flag)
				{
					nint num5 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FlurryVideoAds);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FlurryVideoAds);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+5C]");
				object obj5 = (nint)0 + (nint)36;
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

	private static bool IsInitialized()
	{
		return AppRefreshHandler.refreshInProgress__BackingField;
	}

	public static bool IsSupportedOnPlatform()
	{
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_platformBridge != null)
		{
			nint num3 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v27 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(_initialized ? 1u : 0u) == 0)
			{
				return true;
			}
		}
		return false;
	}

	public static void Initialize()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		throw new ArrayTypeMismatchException();
	}

	public static void CacheAd(string adSpace)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public static void ShowAd(string adSpace)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IsSupportedOnPlatform())
		{
			return;
		}
		nint num3 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v19 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
	}

	public static bool HasCachedAd(string adSpace)
	{
		//IL_003b: Expected I4, but got Obj
		if (((Type)(object)adSpace).IsAbstract)
		{
			string message = ((ArgumentException)(object)adSpace).Message;
			return (byte)(int)message != 0;
		}
		return false;
	}

	public static void EnableDebugLogs()
	{
		//IL_0699: Expected I, but got Obj
		//IL_06af: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_026f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I
		//IL_011f: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I
		//IL_01e1: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I4
		//IL_02fd: Expected I, but got Obj
		//IL_0313: Expected Obj, but got I
		//IL_02b0: Expected I, but got Obj
		//IL_0160: Expected I, but got Obj
		//IL_073e: Expected I, but got Obj
		//IL_0754: Expected Obj, but got I
		//IL_0222: Expected I, but got Obj
		//IL_081b: Expected I, but got Obj
		//IL_0831: Expected Obj, but got I
		//IL_033e: Expected I, but got Obj
		//IL_038b: Expected I, but got Obj
		//IL_0457: Expected I, but got Obj
		//IL_03f1: Expected I, but got Obj
		//IL_04ef: Expected I, but got Obj
		//IL_0505: Expected Obj, but got I
		//IL_060b: Expected I, but got Obj
		//IL_0621: Expected Obj, but got I
		//IL_0530: Expected I, but got Obj
		//IL_057d: Expected I, but got Obj
		//IL_0593: Expected Obj, but got I
		//IL_064c: Expected I, but got Obj
		//IL_05be: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v159 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v155 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FlurryVideoAdsAndroid flurryVideoAdsAndroid = FlurryVideoAdsAndroid.CreatePlugin();
		if ((object)flurryVideoAdsAndroid == null)
		{
			return;
		}
		string dataPath = Application.dataPath;
		FlurryVideoAdsIos platformBridge;
		if ((nint)dataPath == 8)
		{
			nint num5 = (nint)typeof(FlurryVideoAdsIos);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v145 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(FlurryVideoAdsIos);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v151 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsIos>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = FacebookNativeAds.IsInitialized();
			platformBridge = (FlurryVideoAdsIos)flag;
		}
		else
		{
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 != 11)
			{
				nint num7 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v134 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(FlurryVideoAds);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v140 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				LogWarning("There's no platform bridge for the current platform.");
				return;
			}
			nint num9 = (nint)typeof(FlurryVideoAdsAndroid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v123 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(FlurryVideoAdsAndroid);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v129 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.Internal.FlurryVideoAdsAndroid>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			platformBridge = FlurryVideoAdsIos.CreatePlugin();
		}
		nint num11 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v27 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v113 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_platformBridge = platformBridge;
		nint num13 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v34 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v107 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = _platformBridge == null;
		nint num15 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v11 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		bool flag3 = obj8 != null;
		if (flag2)
		{
			if (flag3)
			{
				nint num16 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v103 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LogWarning("An error occured when creating Flurry bridge.");
			return;
		}
		if (flag3)
		{
			nint num17 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v93 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		nint num18 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ S0_v54 (Il2CppClass<Globals>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num19 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v87 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
		{
			nint num20 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v76 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num21 = (nint)typeof(FlurryVideoAds);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v81 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		nint num22 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v63 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num23 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v69 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_initialized = true;
	}

	public static void EnableTestAds()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IsSupportedOnPlatform())
		{
			return;
		}
		nint num3 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		if ((object)context != null)
		{
			object obj = msg + 8;
			obj = context;
			return;
		}
		nint num = (nint)typeof(KilooSerializer.Options);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v8 (Il2CppClass<Kiloo.Serialization.KilooSerializer+Options>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(KilooSerializer.Options);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v14 (Il2CppClass<Kiloo.Serialization.KilooSerializer+Options>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = msg + 8;
		obj3 = KilooSerializer.Options.defaultOptions;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"FlurryVideoAds: ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static FlurryVideoAds()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!IsSupportedOnPlatform())
		{
			return;
		}
		nint num3 = (nint)typeof(FlurryVideoAds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FlurryVideoAds);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<Kiloo.Monetization.FlurryPlugin.FlurryVideoAds>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
	}
}
