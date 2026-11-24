using System;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UnityEngine;

namespace Info;

public static class ScoreMultiplierInfo
{
	private static Action m_onScoreMultiplierChanged;

	public static int scoreMultiplier
	{
		get
		{
			//IL_0196: Expected I, but got Obj
			//IL_01ac: Expected Obj, but got I
			//IL_0226: Expected I, but got Obj
			//IL_023c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01d7: Expected I, but got Obj
			//IL_01ed: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_025f: Expected I4, but got Obj
			//IL_00bb: Expected I, but got Obj
			//IL_00d1: Expected Obj, but got I
			//IL_0149: Expected I, but got Obj
			//IL_00fc: Expected I, but got Obj
			nint num = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Outfits>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<Info.Outfits>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (Outfits._instance != null)
			{
				_0021_00210[] instance = (_0021_00210[])(object)Resources.LoadAll<T>("Info/Outfits");
				nint num5 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v33 (Il2CppClass<Info.Outfits>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Outfits);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v39 (Il2CppClass<Info.Outfits>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Outfits._instance = (Outfits)(object)instance;
			}
			nint num7 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v16 (Il2CppClass<Info.Outfits>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<Info.Outfits>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)Outfits._instance;
		}
	}

	public static int rawMultiplier
	{
		get
		{
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0289: Expected I, but got Obj
			//IL_029f: Expected Obj, but got I
			//IL_008c: Expected Obj, but got I
			//IL_00cb: Expected Obj, but got I4
			//IL_00f9: Expected I, but got Obj
			//IL_00bd: Expected Obj, but got I4
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Expected I4, but got Unknown
			//IL_00d9: Expected Obj, but got I4
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v60 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
			string privacyPolicyUrl = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (System.String)+70]");
			bool flag = (nint)0 == 0;
			bool flag2 = allowSellConsumablesDuringRun;
			if (!flag)
			{
				bool flag3 = (byte)((allowSellConsumablesDuringRun ? 1u : 0u) + 5u) != 0;
				flag2 = flag3;
			}
			string privacyPolicyUrl2 = Globals.GetPrivacyPolicyUrl();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v17 (System.String)+64]");
			bool flag4;
			if ((nint)0 != 0)
			{
				string privacyPolicyUrl3 = Globals.GetPrivacyPolicyUrl();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v45 (System.String)+68]");
				object obj2 = -1;
				object obj3 = (((nint)obj2 != 1) ? ((object)5) : ((object)6));
				if ((nint)obj2 == 2)
				{
					obj3 = 7;
				}
				flag4 = (byte)(int)(obj3 + flag2) != 0;
			}
			else
			{
				flag4 = flag2;
			}
			nint num3 = (nint)typeof(PlusMultiplier);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v21 (Il2CppClass<PlusMultiplier>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(PlusMultiplier);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v37 (Il2CppClass<PlusMultiplier>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = (byte)(~(PlusMultiplier.plusMultiplierEnabled ? 1u : 0u)) != 0;
			bool flag6 = flag4;
			if (!flag5)
			{
				bool flag7 = (byte)((flag4 ? 1u : 0u) + 10u) != 0;
				flag6 = flag7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A02");
			object obj5 = default;
			if (obj5 != null)
			{
				bool flag8 = (byte)((flag6 ? 1u : 0u) << 1) != 0;
				flag6 = flag8;
			}
			return flag6 ? 1 : 0;
		}
	}

	public static event Action onScoreMultiplierChanged
	{
		add
		{
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = ScoreMultiplierInfo.m_onScoreMultiplierChanged;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(ScoreMultiplierInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)ScoreMultiplierInfo.m_onScoreMultiplierChanged == obj2)
				{
					ScoreMultiplierInfo.m_onScoreMultiplierChanged = action;
				}
				if ((object)ScoreMultiplierInfo.m_onScoreMultiplierChanged != obj2)
				{
					obj2 = ScoreMultiplierInfo.m_onScoreMultiplierChanged;
					continue;
				}
				break;
			}
		}
	}

	public static void TriggerOnScoreMultiplierChanged()
	{
	}

	static ScoreMultiplierInfo()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ScoreMultiplierInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ScoreMultiplierInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TransformExtensions.Reset((Transform)(object)ScoreMultiplierInfo.m_onScoreMultiplierChanged);
	}
}
