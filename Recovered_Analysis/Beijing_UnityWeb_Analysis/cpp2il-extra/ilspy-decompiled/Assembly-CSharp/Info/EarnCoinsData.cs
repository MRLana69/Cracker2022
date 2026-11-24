using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Info;

public static class EarnCoinsData
{
	public enum Id
	{
		FacebookKiloo,
		FacebookSybo,
		TwitterKiloo,
		TwitterSybo,
		YoutubeKiloo,
		YoutubeSybo,
		Review,
		AdColony,
		VideoAdCycle,
		FacebookLogin,
		FacebookWeeklyGift,
		RewardForVideo
	}

	public enum Type
	{
		OpenURL,
		VideoAd,
		ClaimReward
	}

	public enum Repeatability
	{
		Once,
		OncePerVersion,
		Forever
	}

	public class EarnCurrencyProfile
	{
		public Id id;

		public Type type;

		public Repeatability repeatability;

		public int defaultAmountOfCoins;

		public string title;

		public string desc;

		public string iOSDesc;

		public string iconName;

		public string url;

		public string overrideAmountOfCoinsOnlineSettingKey;

		public int GetAmountOfCoins()
		{
			return (int)repeatability;
		}
	}

	private const string ONLINESETTINGS_VIDEOADS_DEFAULTREWARD_KEY = "videoads_defaultreward";

	private static Action<Id, int> m_OnRewardURLOpened;

	public static readonly EarnCurrencyProfile[] profiles;

	private unsafe static bool isVideoAddsSupported
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected I, but got Unknown
			//IL_011b: Expected I, but got Obj
			//IL_0136: Expected I, but got Obj
			//IL_014c: Expected Obj, but got I
			//IL_00ed: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(System.Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(System.Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v21 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object typeFromHandle = typeof(Boards.BoardId);
			nint num3 = (nint)(typeFromHandle + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
			System.Type enumType = System.Type.internal_from_handle((IntPtr)num3);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<System.Enum>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v16 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)Enum.InternalGetNames((System.RuntimeType)enumType) != 0;
		}
	}

	public static event Action<Id, int> OnRewardURLOpened
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
			nint num = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onRewardURLOpened = EarnCoinsData.m_OnRewardURLOpened;
			Action<Id, int> onRewardURLOpened2 = default;
			while (true)
			{
				Delegate obj2 = onRewardURLOpened.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Info.EarnCoinsData>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(EarnCoinsData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Info.EarnCoinsData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)EarnCoinsData.m_OnRewardURLOpened == onRewardURLOpened)
				{
					EarnCoinsData.m_OnRewardURLOpened = onRewardURLOpened2;
				}
				if ((object)EarnCoinsData.m_OnRewardURLOpened != onRewardURLOpened)
				{
					onRewardURLOpened = EarnCoinsData.m_OnRewardURLOpened;
					continue;
				}
				break;
			}
		}
	}

	public static bool ShouldShowInGUI(int profileIndex)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [profileIndex @ L0 (System.Int32)+8]");
		return false;
	}

	public static int GetNumberOfDisplayedNonOfferEarners()
	{
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 11)
		{
			return 1;
		}
		string dataPath2 = Application.dataPath;
		if ((nint)dataPath2 == 8)
		{
			return 1;
		}
		string dataPath3 = Application.dataPath;
		if (dataPath3 != null)
		{
			string dataPath4 = Application.dataPath;
			return ((nint)dataPath4 == 7) ? 1 : 0;
		}
		return 1;
	}

	public static void Trigger(int profileIndex)
	{
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate onRewardURLOpened = EarnCoinsData.m_OnRewardURLOpened;
		Action<Id, int> onRewardURLOpened2 = default;
		while (true)
		{
			Delegate obj2 = onRewardURLOpened.RemoveImpl((Delegate)profileIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((object)EarnCoinsData.m_OnRewardURLOpened == onRewardURLOpened)
			{
				EarnCoinsData.m_OnRewardURLOpened = onRewardURLOpened2;
			}
			if ((object)EarnCoinsData.m_OnRewardURLOpened != onRewardURLOpened)
			{
				onRewardURLOpened = EarnCoinsData.m_OnRewardURLOpened;
				continue;
			}
			break;
		}
	}

	static EarnCoinsData()
	{
		//IL_0f47: Expected Obj, but got I
		//IL_0f57: Expected Obj, but got I
		//IL_0f68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Expected Obj, but got Unknown
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7b: Expected Obj, but got Unknown
		//IL_0f98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9d: Expected Obj, but got Unknown
		//IL_0faf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected Obj, but got Unknown
		//IL_0fd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Expected Obj, but got Unknown
		//IL_0fe9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fee: Expected Obj, but got Unknown
		//IL_1019: Expected Obj, but got I
		//IL_1029: Expected Obj, but got I
		//IL_1039: Expected Obj, but got I
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_1047: Expected Obj, but got Unknown
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_1055: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_008f: Expected Obj, but got I
		//IL_009f: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0248: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0322: Expected Obj, but got I
		//IL_0332: Expected Obj, but got I
		//IL_0342: Expected Obj, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected Obj, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_0401: Expected Obj, but got I
		//IL_0411: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got I
		//IL_04eb: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected Obj, but got Unknown
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected Obj, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected Obj, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05da: Expected Obj, but got I
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected Obj, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected Obj, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected Obj, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Expected Obj, but got Unknown
		//IL_0694: Expected Obj, but got I
		//IL_06a4: Expected Obj, but got I
		//IL_06b4: Expected Obj, but got I
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected Obj, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected Obj, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected Obj, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected Obj, but got Unknown
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0773: Expected Obj, but got I
		//IL_0783: Expected Obj, but got I
		//IL_0793: Expected Obj, but got I
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Obj, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07af: Expected Obj, but got Unknown
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected Obj, but got Unknown
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected Obj, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected Obj, but got Unknown
		//IL_084d: Expected Obj, but got I
		//IL_085d: Expected Obj, but got I
		//IL_086d: Expected Obj, but got I
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected Obj, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected Obj, but got Unknown
		//IL_08e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Expected Obj, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_092c: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I
		//IL_094c: Expected Obj, but got I
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected Obj, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected Obj, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected Obj, but got Unknown
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected Obj, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected Obj, but got Unknown
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Expected Obj, but got Unknown
		//IL_0a06: Expected Obj, but got I
		//IL_0a16: Expected Obj, but got I
		//IL_0a26: Expected Obj, but got I
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected Obj, but got Unknown
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected Obj, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a69: Expected Obj, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected Obj, but got Unknown
		//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa3: Expected Obj, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Obj, but got Unknown
		//IL_0ae5: Expected Obj, but got I
		//IL_0af5: Expected Obj, but got I
		//IL_0b05: Expected Obj, but got I
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b13: Expected Obj, but got Unknown
		//IL_0b1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b21: Expected Obj, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected Obj, but got Unknown
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected Obj, but got Unknown
		//IL_0b78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Expected Obj, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b94: Expected Obj, but got Unknown
		//IL_0bbf: Expected Obj, but got I
		//IL_0bcf: Expected Obj, but got I
		//IL_0bdf: Expected Obj, but got I
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected Obj, but got Unknown
		//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfb: Expected Obj, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected Obj, but got Unknown
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c39: Expected Obj, but got Unknown
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected Obj, but got Unknown
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected Obj, but got Unknown
		//IL_0c9e: Expected Obj, but got I
		//IL_0cae: Expected Obj, but got I
		//IL_0cbe: Expected Obj, but got I
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected Obj, but got Unknown
		//IL_0cd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cda: Expected Obj, but got Unknown
		//IL_0cf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Expected Obj, but got Unknown
		//IL_0d0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d13: Expected Obj, but got Unknown
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected Obj, but got Unknown
		//IL_0d48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected Obj, but got Unknown
		//IL_0d78: Expected Obj, but got I
		//IL_0d88: Expected Obj, but got I
		//IL_0d98: Expected Obj, but got I
		//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da6: Expected Obj, but got Unknown
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db4: Expected Obj, but got Unknown
		//IL_0f08: Expected I, but got Obj
		//IL_0f1e: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 8;
		obj6 = "HOVERBOARD_TITLE";
		object obj8 = obj7 + 12;
		obj8 = "Hoverboard";
		_ = 0;
		_ = 0;
		object obj9 = obj7 + 28;
		obj9 = "";
		object obj10 = obj7 + 32;
		obj10 = "";
		_ = 0;
		_ = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v7+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S4_v8+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj17 = default;
		object obj16 = obj17 + 8;
		obj16 = "HOVERBOARDS_BOUNCER";
		object obj18 = obj17 + 12;
		obj18 = "Jumpboard";
		_ = 240000;
		_ = 2;
		object obj19 = obj17 + 28;
		obj19 = "HOVERBOARD_ABILITY_SUPER_JUMP_DESCRIPTION";
		object obj20 = obj17 + 32;
		obj20 = "";
		_ = 0;
		_ = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S4_v12+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v13+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v124 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj27 = default;
		object obj26 = obj27 + 8;
		obj26 = "HOVERBOARDS_LOWRIDER";
		object obj28 = obj27 + 12;
		obj28 = "Lowrider";
		_ = 270000;
		_ = 2;
		object obj29 = obj27 + 28;
		obj29 = "HOVERBOARD_ABILITY_STAY_LOW_DESCRIPTION";
		object obj30 = obj27 + 32;
		obj30 = "";
		_ = 0;
		_ = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S4_v17+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S4_v18+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj37 = default;
		object obj36 = obj37 + 8;
		obj36 = "HOVERBOARDS_FREESTYLER";
		object obj38 = obj37 + 12;
		obj38 = "Snowboard";
		_ = 38000;
		_ = 2;
		object obj39 = obj37 + 28;
		obj39 = "";
		object obj40 = obj37 + 32;
		obj40 = "";
		_ = 0;
		_ = 0;
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S4_v22+60]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S4_v23+48]");
		object obj43 = 0;
		object obj44 = obj43 & 0x7FF;
		object obj45 = obj44 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v220 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj47 = default;
		object obj46 = obj47 + 8;
		obj46 = "HOVERBOARDS_BIG_KAHUNA";
		object obj48 = obj47 + 12;
		obj48 = "Surfboard";
		_ = 55000;
		_ = 2;
		object obj49 = obj47 + 28;
		obj49 = "";
		object obj50 = obj47 + 32;
		obj50 = "";
		_ = 0;
		_ = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S4_v27+60]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S4_v28+48]");
		object obj53 = 0;
		object obj54 = obj53 & 0x7FF;
		object obj55 = obj54 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v268 @ S5_v22 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj57 = default;
		object obj56 = obj57 + 8;
		obj56 = "HOVERBOARDS_SUPERHERO";
		object obj58 = obj57 + 12;
		obj58 = "Bamboard";
		_ = 3200;
		_ = 2;
		object obj59 = obj57 + 28;
		obj59 = "";
		object obj60 = obj57 + 32;
		obj60 = "";
		_ = 0;
		_ = 0;
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S4_v32+60]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S4_v33+48]");
		object obj63 = 0;
		object obj64 = obj63 & 0x7FF;
		object obj65 = obj64 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v316 @ S5_v26 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj67 = default;
		object obj66 = obj67 + 8;
		obj66 = "HOVERBOARDS_STARBOARD";
		object obj68 = obj67 + 12;
		obj68 = "Starboard";
		_ = 0;
		_ = 4;
		object obj69 = obj67 + 28;
		obj69 = "";
		object obj70 = obj67 + 32;
		obj70 = "";
		_ = 0;
		_ = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S4_v37+60]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S4_v38+48]");
		object obj73 = 0;
		object obj74 = obj73 & 0x7FF;
		object obj75 = obj74 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v364 @ S5_v30 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj77 = default;
		object obj76 = obj77 + 8;
		obj76 = "HOVERBOARDS_MIAMI";
		object obj78 = obj77 + 12;
		obj78 = "Miami";
		_ = 4800;
		_ = 2;
		object obj79 = obj77 + 28;
		obj79 = "";
		object obj80 = obj77 + 32;
		obj80 = "";
		_ = 0;
		_ = 0;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S4_v42+60]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S4_v43+48]");
		object obj83 = 0;
		object obj84 = obj83 & 0x7FF;
		object obj85 = obj84 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v412 @ S5_v34 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj87 = default;
		object obj86 = obj87 + 8;
		obj86 = "HOVERBOARDS_MONSTER";
		object obj88 = obj87 + 12;
		obj88 = "Monster";
		_ = 25000;
		_ = 2;
		object obj89 = obj87 + 28;
		obj89 = "";
		object obj90 = obj87 + 32;
		obj90 = "";
		_ = 0;
		_ = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ S4_v47+60]");
		object obj92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S4_v48+48]");
		object obj93 = 0;
		object obj94 = obj93 & 0x7FF;
		object obj95 = obj94 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v460 @ S5_v38 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj97 = default;
		object obj96 = obj97 + 8;
		obj96 = "HOVERBOARDS_SKULL_FIRE";
		object obj98 = obj97 + 12;
		obj98 = "SkullFire";
		_ = 65000;
		_ = 2;
		object obj99 = obj97 + 28;
		obj99 = "";
		object obj100 = obj97 + 32;
		obj100 = "";
		_ = 0;
		_ = 0;
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj101 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ S4_v52+60]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S4_v53+48]");
		object obj103 = 0;
		object obj104 = obj103 & 0x7FF;
		object obj105 = obj104 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v508 @ S5_v42 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj107 = default;
		object obj106 = obj107 + 8;
		obj106 = "HOVERBOARDS_DAREDEVIL";
		object obj108 = obj107 + 12;
		obj108 = "Daredevil";
		_ = 75000;
		_ = 2;
		object obj109 = obj107 + 28;
		obj109 = "HOVERBOARD_ABILITY_SPEED_UP_DESCRIPTION";
		object obj110 = obj107 + 32;
		obj110 = "";
		_ = 0;
		_ = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj111 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ S4_v57+60]");
		object obj112 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S4_v58+48]");
		object obj113 = 0;
		object obj114 = obj113 & 0x7FF;
		object obj115 = obj114 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v556 @ S5_v46 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj117 = default;
		object obj116 = obj117 + 8;
		obj116 = "HOVERBOARDS_LUMBERJACK";
		object obj118 = obj117 + 12;
		obj118 = "Treehugger";
		_ = 1500;
		_ = 2;
		object obj119 = obj117 + 28;
		obj119 = "";
		object obj120 = obj117 + 32;
		obj120 = "";
		_ = 0;
		_ = 0;
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S4_v62+60]");
		object obj122 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ S4_v63+48]");
		object obj123 = 0;
		object obj124 = obj123 & 0x7FF;
		object obj125 = obj124 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v604 @ S5_v50 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj127 = default;
		object obj126 = obj127 + 8;
		obj126 = "HOVERBOARDS_SCOOT";
		object obj128 = obj127 + 12;
		obj128 = "Rome";
		_ = 30000;
		_ = 2;
		object obj129 = obj127 + 28;
		obj129 = "";
		object obj130 = obj127 + 32;
		obj130 = "";
		_ = 0;
		_ = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S4_v67+60]");
		object obj132 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S4_v68+48]");
		object obj133 = 0;
		object obj134 = obj133 & 0x7FF;
		object obj135 = obj134 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v652 @ S5_v54 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj137 = default;
		object obj136 = obj137 + 8;
		obj136 = "HOVERBOARDS_GREAT_WHITE";
		object obj138 = obj137 + 12;
		obj138 = "GreatWhiteWakeboard";
		_ = 17000;
		_ = 2;
		object obj139 = obj137 + 28;
		obj139 = "";
		object obj140 = obj137 + 32;
		obj140 = "";
		_ = 0;
		_ = 0;
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ S4_v71 (Il2CppMethodInfo)+C]");
		object obj141 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ S4_v72+60]");
		object obj142 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S4_v73+48]");
		object obj143 = 0;
		object obj144 = obj143 & 0x7FF;
		object obj145 = obj144 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v700 @ S5_v58 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj147 = default;
		object obj146 = obj147 + 8;
		obj146 = "HOVERBOARDS_HOTROD";
		object obj148 = obj147 + 12;
		obj148 = "HotRod";
		_ = 240000;
		_ = 2;
		object obj149 = obj147 + 28;
		obj149 = "HOVERBOARD_ABILITY_SPEED_UP_DESCRIPTION";
		object obj150 = obj147 + 32;
		obj150 = "";
		_ = 0;
		_ = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S4_v76 (Il2CppMethodInfo)+C]");
		object obj151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ S4_v77+60]");
		object obj152 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S4_v78+48]");
		object obj153 = 0;
		object obj154 = obj153 & 0x7FF;
		object obj155 = obj154 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v748 @ S5_v62 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj157 = default;
		object obj156 = obj157 + 8;
		obj156 = "HOVERBOARDS_TELEBOARD";
		object obj158 = obj157 + 12;
		obj158 = "teleboard";
		_ = 190000;
		_ = 2;
		object obj159 = obj157 + 28;
		obj159 = "HOVERBOARD_ABILITY_ZAP_SIDEWAYS_DESCRIPTION";
		object obj160 = obj157 + 32;
		obj160 = "";
		_ = 0;
		_ = 0;
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S4_v81 (Il2CppMethodInfo)+C]");
		object obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S4_v82+60]");
		object obj162 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v788 @ S4_v83+48]");
		object obj163 = 0;
		object obj164 = obj163 & 0x7FF;
		object obj165 = obj164 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v796 @ S5_v66 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj167 = default;
		object obj166 = obj167 + 8;
		obj166 = "HOVERBOARDS_GLIDER";
		object obj168 = obj167 + 12;
		obj168 = "gliderboard";
		_ = 300000;
		_ = 2;
		object obj169 = obj167 + 28;
		obj169 = "HOVERBOARD_ABILITY_SMOOTH_DRIFT_DESCRIPTION";
		object obj170 = obj167 + 32;
		obj170 = "";
		_ = 0;
		_ = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ S4_v86 (Il2CppMethodInfo)+C]");
		object obj171 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ S4_v87+60]");
		object obj172 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ S4_v88+48]");
		object obj173 = 0;
		object obj174 = obj173 & 0x7FF;
		object obj175 = obj174 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v844 @ S5_v70 (should have been resolved before IL gen)");
		Dictionary<Boards.BoardId, Boards.Board> boardData = default;
		Boards.boardData = boardData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Boards.BoardId> list = default;
		list._002Ector();
		list.Add(Boards.BoardId.snowboard);
		list.Add(Boards.BoardId.bouncer);
		list.Add(Boards.BoardId.hotrod);
		list.Add(Boards.BoardId.teleboard);
		list.Add(Boards.BoardId.skullfire);
		list.Add(Boards.BoardId.normal);
		list.Add(Boards.BoardId.lowrider);
		list.Add(Boards.BoardId.starboard);
		list.Add(Boards.BoardId.speedboard);
		list.Add(Boards.BoardId.greatWhiteWakeboard);
		list.Add(Boards.BoardId.gliderboard);
		list.Add(Boards.BoardId.rome);
		list.Add(Boards.BoardId.treehugger);
		list.Add(Boards.BoardId.theoriginal);
		list.Add(Boards.BoardId.surfboard);
		list.Add(Boards.BoardId.miami);
		list.Add(Boards.BoardId.monster);
		nint num19 = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ S0_v304 (Il2CppClass<Info.Boards>)+5C]");
		object obj176 = (nint)0 + (nint)4;
		obj176 = list;
	}
}
