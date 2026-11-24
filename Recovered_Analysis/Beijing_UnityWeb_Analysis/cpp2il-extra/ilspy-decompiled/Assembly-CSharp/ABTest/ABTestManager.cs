using System;
using System.Collections.Generic;
using System.Linq;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Analytics;
using Kiloo.Common.Ads;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Components.Logging.Ftp;
using UnityEngine;

namespace ABTest;

public static class ABTestManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ABTestData.ABTestDataItem, string> _003C_003E9__10_0;

		public static Func<ABTestData.ABTestDataItem, ABTest> _003C_003E9__10_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AdController._003C_003Ec obj = default;
			AdController._003C_003Ec._003C_003E9 = obj;
		}

		internal string _003CSetupTestData_003Eb__10_0(ABTestData.ABTestDataItem x)
		{
			//IL_0015: Expected Obj, but got I
			//IL_002f: Expected Obj, but got I
			//IL_0066: Expected Obj, but got I
			//IL_008c: Expected Obj, but got I4
			string identifier = x.identifier;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ABTest.ABTestManager+<>c)+8]");
			if (identifier == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ABTest.ABTestManager+<>c)+C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+20]");
				if (((List<string>)0).Contains(x.defaultPayload))
				{
					return null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ABTest.ABTestManager+<>c)+C]");
				object obj2 = 0;
				string defaultPayload = x.defaultPayload;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v9+34]");
				char c = defaultPayload.get_Chars(0);
				return (string)c;
			}
			return null;
		}

		internal ABTest _003CSetupTestData_003Eb__10_1(ABTestData.ABTestDataItem y)
		{
			return (ABTest)(object)y.identifier;
		}
	}

	private static List<string> _tags;

	private static Dictionary<string, ABTest> _tests;

	public static Action<string, string> onRegisterDailyReport;

	public static Action<string, int> onTagAdded;

	private static bool isInitialized__BackingField;

	private static uint _boostsScreen;

	private static uint _earnCoinsScreen;

	private static uint _storeScreen;

	private static uint _quickStorePopup;

	public static bool isInitialized
	{
		get
		{
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Expected Obj, but got Unknown
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			//IL_03a6: Expected I4, but got Obj
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_0329: Expected I, but got Obj
			//IL_033f: Expected Obj, but got I
			//IL_015a: Expected I, but got Obj
			//IL_0258: Expected I, but got Obj
			//IL_01cb: Expected I, but got Obj
			string dataPath = Application.dataPath;
			object obj = dataPath - 8;
			object obj4;
			if ((nint)dataPath != 8)
			{
				if ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3)
				{
					nint num = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v29 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v65 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
					nint num3 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v7 (Il2CppClass<Globals>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					bool flag = obj3 == null;
					if (iOSOtherAudioPlaying)
					{
						if (!flag)
						{
							nint num4 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v59 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj4 = ((~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) != 0) ? "D5BDSJTZB2JX75Y2T4SN" : "XJ5NMRG7R5WGC4BZC6XQ");
					}
					else
					{
						if (!flag)
						{
							nint num5 = (nint)typeof(Globals);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v44 (Il2CppClass<Globals>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj4 = ((~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) != 0) ? "YR898G65YFPWNMQ6X5H5" : "XJ5NMRG7R5WGC4BZC6XQ");
					}
				}
				else
				{
					obj4 = "";
				}
			}
			else
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Globals>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v21 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = ((~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) != 0) ? "CIJUE322XIHTDWNV519J" : "GDGAT7PY98MAEQQIWC68");
			}
			return (byte)(int)obj4 != 0;
		}
		private set
		{
		}
	}

	public static void Initialize()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_0216: Expected I, but got Obj
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_0585: Expected Obj, but got I
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected Obj, but got Unknown
		//IL_02b2: Expected I, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_0308: Expected I, but got Obj
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<ABTestData.ABTestDataItem> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ABTestData.ABTestDataItem aBTestDataItem = default;
		object obj = aBTestDataItem + 12;
		obj = "doublecoins";
		object obj2 = aBTestDataItem + 16;
		obj2 = "E";
		aBTestDataItem.testRange = TestRange.Kiloo;
		object obj3 = aBTestDataItem + 24;
		obj3 = "Double Coin Variation";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list2 = default;
		list2._002Ector();
		list2.Add("A");
		list2.Add("B");
		list2.Add("C");
		list2.Add("D");
		list2.Add("E");
		object obj4 = aBTestDataItem + 28;
		obj4 = list2;
		list.Add(aBTestDataItem);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ABTestData.ABTestDataItem aBTestDataItem2 = default;
		object obj5 = aBTestDataItem2 + 12;
		obj5 = "twokeys";
		object obj6 = aBTestDataItem2 + 16;
		obj6 = "B";
		aBTestDataItem2.testRange = TestRange.Kiloo;
		object obj7 = aBTestDataItem2 + 24;
		obj7 = "Two Keys Variation";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list3 = default;
		list3._002Ector();
		list3.Add("A");
		list3.Add("B");
		object obj8 = aBTestDataItem2 + 28;
		obj8 = list3;
		list.Add(aBTestDataItem2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ABTestData.ABTestDataItem aBTestDataItem3 = default;
		object obj9 = aBTestDataItem3 + 12;
		obj9 = "welcomepackprice";
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v50 (Il2CppClass<Globals>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v109 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = aBTestDataItem3 + 16;
		object obj14 = default;
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v122 (Il2CppClass<Globals>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			bool flag = obj12 == null;
			nint num4 = (nint)typeof(Globals);
			if (!flag)
			{
				nint num5 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v130 (Il2CppClass<Globals>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(Globals);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(Globals);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ L0_v10 (Il2CppClass<Globals>)+5C]");
			object obj13 = (nint)0 + (nint)88;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		}
		else
		{
			obj14 = "0";
		}
		obj11 = obj14;
		aBTestDataItem3.testRange = TestRange.Kiloo;
		object obj15 = aBTestDataItem3 + 24;
		obj15 = "Different price an content for Welcome Pack";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list4 = default;
		list4._002Ector();
		list4.Add("0");
		list4.Add("1");
		list4.Add("2");
		object obj16 = aBTestDataItem3 + 28;
		obj16 = list4;
		list.Add(aBTestDataItem3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ABTestData.ABTestDataItem aBTestDataItem4 = default;
		object obj17 = aBTestDataItem4 + 12;
		obj17 = "mainscreenbuttons";
		object obj18 = aBTestDataItem4 + 16;
		obj18 = "A";
		aBTestDataItem4.testRange = TestRange.Kiloo;
		object obj19 = aBTestDataItem4 + 24;
		obj19 = "Main Screen Button rearrange";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list5 = default;
		list5._002Ector();
		list5.Add("A");
		list5.Add("B");
		list5.Add("C");
		list5.Add("D");
		list5.Add("B2");
		list5.Add("C2");
		object obj20 = aBTestDataItem4 + 28;
		obj20 = list5;
		list.Add(aBTestDataItem4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ABTestData.ABTestDataItem aBTestDataItem5 = default;
		object obj21 = aBTestDataItem5 + 12;
		obj21 = "doublecoinsvideo";
		object obj22 = aBTestDataItem5 + 16;
		obj22 = "B";
		aBTestDataItem5.testRange = TestRange.Kiloo;
		object obj23 = aBTestDataItem5 + 24;
		obj23 = "Double Coins Video";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list6 = default;
		list6._002Ector();
		list6.Add("A");
		list6.Add("B");
		object obj24 = aBTestDataItem5 + 28;
		obj24 = list6;
		list.Add(aBTestDataItem5);
		ABTestData.testData = list;
	}

	private static void OnHasRefreshed(RefreshType refreshType)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (byte)(refreshType & RefreshType.UI) != 0;
		isInitialized__BackingField = flag;
	}

	private unsafe static void SetupTestData()
	{
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01ce: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_024d: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C30");
		object obj2 = default;
		if (obj2 != null)
		{
			return;
		}
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v42 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EA82");
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v21 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v38 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnFinishedDownloadingOnlineSettings);
		object obj5 = action + 16;
		obj5 = 0;
		((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<RefreshType> action2 = default;
		object obj6 = action2 + 16;
		obj6 = 0;
		AppRefreshHandler.hasRefreshed -= action2;
		OnFinishedDownloadingOnlineSettings();
	}

	public static bool IsActive(string identifier)
	{
		//IL_002a: Expected I4, but got Obj
		string text = string.ConcatArray((string[])(object)"debug_payload_", identifier.m_stringLength);
		return (byte)UnityEngine.Random.Range((int)text, 0) != 0;
	}

	public static string GetTag(string identifier)
	{
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		//IL_0252: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I4
		//IL_0139: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v52 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v46 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest aBTest = _tests.get_Item(identifier);
			if (~(aBTest.isForcedDisabled__BackingField ? 1u : 0u) == 0)
			{
				return null;
			}
			nint num6 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v29 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num7 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v39 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest aBTest2 = _tests.get_Item(identifier);
			bool flag = aBTest2.isActive__BackingField;
			return (string)flag;
		}
		return null;
	}

	public static string GetDefaultPayload(string identifier)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string tag = GetTag(identifier);
		if (tag != null)
		{
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v18 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v27 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest aBTest = _tests.get_Item(identifier);
			return aBTest.tag__BackingField;
		}
		return string.Empty;
	}

	public static string GetPayloadString(string identifier)
	{
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_020c: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = identifier;
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v49 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C30");
		object obj4 = default;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v34 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v43 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, ABTest> tests = _tests;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			ABTest aBTest = tests.get_Item((string)0);
			return aBTest.defaultPayload__BackingField;
		}
		nint num5 = (nint)typeof(ABTestData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v18 (Il2CppClass<ABTest.ABTestData>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(ABTestData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v27 (Il2CppClass<ABTest.ABTestData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = obj2;
		throw new NullReferenceException();
	}

	public static bool GetPayloadBool(string identifier)
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01b3: Expected I4, but got Obj
		//IL_00f5: Expected I, but got Obj
		//IL_0199: Expected I4, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string tag = GetTag(identifier);
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (tag != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v30 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest aBTest = _tests.get_Item(identifier);
			return (byte)(int)aBTest.payload__BackingField != 0;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v18 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string payloadString = GetPayloadString(identifier);
		return (byte)(int)payloadString != 0;
	}

	public static uint GetPayloadUInt(string identifier)
	{
		//IL_01e1: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_031a: Expected I, but got Obj
		//IL_0330: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02b2: Expected I, but got Obj
		//IL_02c8: Expected Obj, but got I
		//IL_02fa: Expected I4, but got Obj
		//IL_0142: Expected I, but got Obj
		//IL_0241: Expected I, but got Obj
		//IL_0257: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_028e: Expected I4, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_00d1: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string tag = GetTag(identifier);
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (tag != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v31 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest aBTest = _tests.get_Item(identifier);
			string payloadString = GetPayloadString(identifier);
			nint num5 = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v8 (Il2CppClass<System.Boolean>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(bool);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S2_v14 (Il2CppClass<System.Boolean>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = bool.TrimWhiteSpaceAndNull(payloadString);
			return aBTest.GetPayload((uint)(int)text);
		}
		if (!flag)
		{
			nint num7 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v19 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string payloadString2 = GetPayloadString(identifier);
		nint num8 = (nint)typeof(bool);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v12 (Il2CppClass<System.Boolean>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num9 = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v17 (Il2CppClass<System.Boolean>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = bool.TrimWhiteSpaceAndNull(payloadString2);
		return (uint)(int)text2;
	}

	public unsafe static int GetPayloadInt(string identifier)
	{
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0203: Expected I, but got Obj
		//IL_0219: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_010b: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string tag = GetTag(identifier);
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (tag != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v31 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest aBTest = _tests.get_Item(identifier);
			string payloadString = GetPayloadString(identifier);
			TypeCode typeCode = ((uint*)payloadString)->GetTypeCode();
			return aBTest.GetPayload((int)typeCode);
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v19 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string payloadString2 = GetPayloadString(identifier);
		return (int)((uint*)payloadString2)->GetTypeCode();
	}

	private static void OnFinishedDownloadingOnlineSettings()
	{
		//IL_02cc: Expected I, but got Obj
		//IL_02e2: Expected Obj, but got I
		//IL_0479: Expected I, but got Obj
		//IL_048f: Expected Obj, but got I
		//IL_030d: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_057f: Expected I, but got Obj
		//IL_0595: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_04f4: Expected Obj, but got I
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_0530: Expected I, but got Obj
		//IL_0546: Expected Obj, but got I
		//IL_0563: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_037d: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_0458: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0263: Expected I, but got Obj
		//IL_0293: Expected I, but got Obj
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_02b9: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v41 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveTags();
		nint num3 = (nint)typeof(ABTestData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<ABTest.ABTestData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTestData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v35 (Il2CppClass<ABTest.ABTestData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v5 (Il2CppClass<ABTest.ABTestManager+<>c>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v88 (Il2CppClass<ABTest.ABTestManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__10_0 == null;
		bool flag2 = !flag;
		Func<ABTestData.ABTestDataItem, string> func = _003C_003Ec._003C_003E9__10_0;
		if (!flag2)
		{
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v62 (Il2CppClass<ABTest.ABTestManager+<>c>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v82 (Il2CppClass<ABTest.ABTestManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			Func<ABTestData.ABTestDataItem, string> func2 = default;
			object obj5 = func2 + 16;
			obj5 = _003C_003Ec._003C_003E9;
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v79 (Il2CppClass<ABTest.ABTestManager+<>c>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = func2;
			func = func2;
		}
		nint num11 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v15 (Il2CppClass<ABTest.ABTestManager+<>c>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v55 (Il2CppClass<ABTest.ABTestManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__10_1 == null;
		bool flag4 = !flag3;
		Func<ABTestData.ABTestDataItem, ABTest> func3 = _003C_003Ec._003C_003E9__10_1;
		if (!flag4)
		{
			nint num13 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v29 (Il2CppClass<ABTest.ABTestManager+<>c>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v49 (Il2CppClass<ABTest.ABTestManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num15 = 0;
			_ = 0;
			Func<ABTestData.ABTestDataItem, ABTest> func4 = default;
			object obj9 = func4 + 16;
			obj9 = _003C_003Ec._003C_003E9;
			nint num16 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S1_v46 (Il2CppClass<ABTest.ABTestManager+<>c>)+5C]");
			object obj10 = (nint)0 + (nint)8;
			obj10 = func4;
			func3 = func4;
		}
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S4_v2 (Il2CppMethodInfo)+18]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x7FF;
		object obj14 = obj13 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v183 @ S5_v4 (should have been resolved before IL gen)");
		nint num18 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v21 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		bool flag5 = obj15 == null;
		nint num19 = (nint)typeof(ABTestManager);
		if (!flag5)
		{
			nint num20 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v29 (Il2CppClass<ABTest.ABTestManager>)+74]");
			bool flag6 = (nint)0 == 0;
			bool flag7 = !flag6;
			num19 = (nint)typeof(ABTestManager);
			if (!flag7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num19 = (nint)typeof(ABTestManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ L0_v13 (Il2CppClass<ABTest.ABTestManager>)+5C]");
		object obj16 = (nint)0 + (nint)4;
		object obj17 = default;
		obj16 = obj17;
		LoadTags();
	}

	private static void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_03f4: Expected Obj, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_042e: Expected Obj, but got I4
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_0458: Expected I, but got Obj
		//IL_046e: Expected Obj, but got I
		//IL_0068: Expected Obj, but got VT
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04a1: Expected Obj, but got VT
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected Obj, but got Unknown
		//IL_00c1: Expected I, but got Obj
		//IL_010e: Expected I, but got Obj
		//IL_0124: Expected Obj, but got I
		//IL_014f: Expected I, but got Obj
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Obj, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_0605: Expected Obj, but got VT
		//IL_0332: Expected Obj, but got I
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_0220: Expected I, but got Obj
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 32;
		obj3 = 0;
		object obj4 = obj2 + 80;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 + 72;
		obj6 = obj;
		_ = -1;
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v154 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LoadTags();
		DateTime wordHuntExpireTime = EventsSave.wordHuntExpireTime;
		DateTime today = CDateTime.Today;
		obj3 = today;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34 (Il2CppClass<System.DateTime>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v150 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj2 + 16;
		obj9 = wordHuntExpireTime;
		object obj10 = obj2 + 8;
		object obj11 = default;
		obj10 = obj11;
		object obj12 = obj2 + 40;
		obj12 = obj9;
		string text = (string)(obj2 + 48);
		text = (string)obj10;
		object obj13 = obj12 & 0x3FFFFFFFFFFFFFFFL;
		object obj14 = text & 0x3FFFFFFFFFFFFFFFL;
		if (obj13 == obj14)
		{
			return;
		}
		nint num5 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v53 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num6 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v144 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj4 = text;
		_ = text.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v45 (System.String)+10]");
		_ = 0;
		object obj16 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj16 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj5 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num7 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v128 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num8 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v137 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj18 = obj6 + 4;
		object obj19 = obj18 + 1;
		obj18 = obj19;
		object obj20 = obj19 << 2;
		object obj21 = obj6 + obj20;
		obj21 = 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj22 = (nint)0 << 2;
			object obj23 = obj6 + obj22;
			if ((nint)obj23 == 88)
			{
				object obj24 = obj6 + 4;
				if ((nint)obj24 > -1)
				{
					object obj25 = obj24 + -1;
					obj24 = obj25;
				}
				goto IL_05f4;
			}
		}
		object obj26 = default;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05f4;
		IL_05f4:
		DateTime today2 = CDateTime.Today;
		obj2 = today2;
		text = (string)obj2;
		AnalyticsSave.abTestPlayerSeed = text;
	}

	private static void Update(ABTest test)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = test;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (!obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnFinishedDownloadingOnlineSettings();
	}

	private static void RegisterDailyReport(string identifier)
	{
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I
		//IL_0100: Expected I, but got Obj
		//IL_014d: Expected I, but got Obj
		//IL_0163: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((ABTest)(object)identifier).EnableDebugPayload((string)(object)_tags);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [identifier @ L0 (System.String)+21]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [identifier @ L0 (System.String)+2C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [identifier @ L0 (System.String)+2C]");
		bool flag;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v15+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return;
		}
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v19 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v55 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> tags = _tags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [identifier @ L0 (System.String)+2C]");
		if (tags.Contains((string)0))
		{
			return;
		}
		nint num5 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v29 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v49 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<string> tags2 = _tags;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [identifier @ L0 (System.String)+2C]");
		tags2.Add((string)0);
		if (onTagAdded != null)
		{
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S3_v3 (Il2CppMethodInfo)+18]");
			object obj5 = 0;
			object obj6 = obj5;
			object obj7 = obj6 & 0x1FFF;
			object obj8 = obj7 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S4_v6 (should have been resolved before IL gen)");
		}
		SendPageCountFlurry();
	}

	private static void LoadTags()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02c5: Expected Obj, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0312: Expected I, but got Obj
		//IL_0328: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_00f2: Expected I, but got Obj
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v110 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v94 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v103 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj9 = obj5 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj5 + obj11;
		obj12 = 58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj5 + obj13;
			if ((nint)obj14 == 58)
			{
				object obj15 = obj5 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				return;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private static void SaveTags()
	{
		//IL_00c1: Expected Obj, but got I4
		//IL_00ca: Expected Obj, but got I4
		//IL_0020: Expected I, but got Obj
		//IL_0036: Expected Obj, but got I
		//IL_0061: Expected I, but got Obj
		string flurryUserId = AnalyticsSave.flurryUserId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 59;
		string source = flurryUserId.Substring(num);
		List<string> tags = Enumerable.ToList((IEnumerable<string>)(object)source);
		nint num2 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v10 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_tags = tags;
	}

	private unsafe static bool IsDateToday(string previousDate)
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_020b: Expected I, but got Obj
		//IL_0221: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I4
		//IL_00dc: Expected I4, but got Obj
		//IL_0084: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string tag = GetTag(previousDate);
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		if (tag != null)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v31 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ABTest identifier = _tests.get_Item(previousDate);
			string payloadString = GetPayloadString(previousDate);
			TypeCode typeCode = ((int*)payloadString)->GetTypeCode();
			string onlineSettingsKey = ABTest.GetOnlineSettingsKey((string)(object)identifier, (string)typeCode);
			return (byte)(int)onlineSettingsKey != 0;
		}
		if (!flag)
		{
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v19 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string payloadString2 = GetPayloadString(previousDate);
		return (byte)((int*)payloadString2)->GetTypeCode() != 0;
	}

	public static void CountPages(string screenName)
	{
		//IL_03a2: Expected I, but got Obj
		//IL_03b8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01af: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_01de: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I
		//IL_023a: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_027e: Expected I, but got Obj
		//IL_0294: Expected Obj, but got I
		//IL_040d: Expected I, but got Obj
		//IL_0423: Expected Obj, but got I
		//IL_02bf: Expected I, but got Obj
		//IL_030c: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string tag = GetTag(screenName);
		if (tag == null)
		{
			return;
		}
		nint num3 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v61 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool payloadBool = GetPayloadBool(screenName);
		string defaultPayload = GetDefaultPayload(screenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S3_v4+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S4_v5 (should have been resolved before IL gen)");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S4_v8+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S4_v9+48]");
		object obj10 = 0;
		object obj11 = obj10 & 0x7FF;
		object obj12 = obj11 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v128 @ S5_v7 (should have been resolved before IL gen)");
		string defaultPayload2 = GetDefaultPayload(screenName);
		object obj13 = ((IConvertible)payloadBool).ToType((Type)(object)"_", (IFormatProvider)(object)defaultPayload2);
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S4_v13+60]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S4_v14+48]");
		object obj16 = 0;
		object obj17 = obj16 & 0x7FF;
		object obj18 = obj17 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v157 @ S5_v11 (should have been resolved before IL gen)");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S4_v17 (Il2CppMethodInfo)+C]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S4_v18+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S4_v19+48]");
		object obj21 = 0;
		object obj22 = obj21 & 0x7FF;
		object obj23 = obj22 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S5_v15 (should have been resolved before IL gen)");
		nint num9 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v36 (Il2CppClass<Flurry>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v57 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num11 = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v41 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num12 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v53 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Tracker.CreateEvent(Kiloo.Analytics.EventType.ABTestDailyReport, null, screenName);
		if (onRegisterDailyReport != null)
		{
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S3_v12 (Il2CppMethodInfo)+18]");
			object obj26 = 0;
			object obj27 = obj26;
			object obj28 = obj27 & 0x1FFF;
			object obj29 = obj28 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v24 (should have been resolved before IL gen)");
		}
	}

	public static void SendPageCountFlurry()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] strB = _tags.ToArray();
		int num3 = string.CompareOrdinalIgnoreCaseHelper(";", (string)(object)strB);
		AnalyticsSave.flurryUserId = (string)num3;
	}

	public static bool HasDebugPayload(string identifier)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01eb: Expected Obj, but got VT
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I8
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got VT
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v49 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v21 (Il2CppClass<Utils>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v45 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 24;
		obj6 = DateTime.MinValue;
		string text = (string)(obj2 + 48);
		text = (string)obj6;
		long fileSize = ((FtpClient)(object)identifier).GetFileSize(text);
		obj = fileSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		DateTime utcNow = CDateTime.UtcNow;
		obj3 = utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		object obj7 = obj2 + 8;
		object obj8 = default;
		obj7 = obj8;
		object obj9 = default;
		obj2 = obj9;
		object obj10 = obj2 + 40;
		obj10 = obj7;
		text = (string)obj2;
		object obj11 = obj10 & 0x3FFFFFFFFFFFFFFFL;
		object obj12 = text & 0x3FFFFFFFFFFFFFFFL;
		return obj11 == obj12;
	}

	public static string GetDebugPayload(string identifier)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ABTest aBTest = _tests.get_Item(identifier);
		return aBTest.GetDebugPayload();
	}

	public static void EnableDebugPayload(string identifier, string value)
	{
		string text = string.ConcatArray((string[])(object)"debug_payload_", identifier.m_stringLength);
		((TooltipAttribute)(object)text)._002Ector(value);
	}

	public static void DisableDebugPayload(string identifier)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_023e: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_01c6: Expected I, but got Obj
		//IL_027f: Expected I, but got Obj
		if (identifier != "EarnCoinsScreen")
		{
			nint num = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v57 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v64 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uint earnCoinsScreen = _earnCoinsScreen + 1;
			_earnCoinsScreen = earnCoinsScreen;
		}
		else if (identifier != "UpgradesUI_shop")
		{
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v43 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v50 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uint boostsScreen = _boostsScreen + 1;
			_boostsScreen = boostsScreen;
		}
		else if (identifier != "CoinsUI_shop")
		{
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v29 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v36 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uint storeScreen = _storeScreen + 1;
			_storeScreen = storeScreen;
		}
		else
		{
			if (!(identifier != "CoinsUI_quick"))
			{
				return;
			}
			nint num7 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v15 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v22 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			uint quickStorePopup = _quickStorePopup + 1;
			_quickStorePopup = quickStorePopup;
		}
	}

	private static void LogWarn(string msg, UnityEngine.Object context = null)
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ABTest identifier = _tests.get_Item(msg);
		EnableDebugPayload((string)(object)identifier, (string)(object)context);
		ABTest identifier2 = _tests.get_Item(msg);
		RegisterDailyReport((string)(object)identifier2);
	}

	private static void LogErr(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[ABTestManager] ", (int)msg);
		SDebug.LogFormat(msg2, (object[])(object)context);
	}

	static ABTestManager()
	{
		//IL_02ea: Expected I, but got Obj
		//IL_0300: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I4
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected Obj, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_0353: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_0373: Expected Obj, but got I
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_03a7: Expected I, but got Obj
		//IL_03bd: Expected Obj, but got I
		//IL_03dd: Expected Obj, but got I
		//IL_03ed: Expected Obj, but got I
		//IL_03fd: Expected Obj, but got I
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0431: Expected I, but got Obj
		//IL_0447: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d2: Expected I, but got Obj
		//IL_01e8: Expected Obj, but got I
		//IL_0208: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_025c: Expected I, but got Obj
		//IL_0272: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_013d: Expected I, but got Obj
		//IL_029d: Expected I, but got Obj
		//IL_0163: Expected I, but got Obj
		nint num = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v78 (Il2CppClass<ABTest.ABTestManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = _earnCoinsScreen + _boostsScreen;
		object obj3 = _storeScreen + obj2;
		object obj4 = _quickStorePopup + obj3;
		if (obj4 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S3_v6 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S3_v7+60]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v91 @ S4_v5 (should have been resolved before IL gen)");
		nint num4 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v20 (Il2CppClass<ABTest.ABTestManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		bool flag = obj10 == null;
		nint num5 = (nint)typeof(ABTestManager);
		if (!flag)
		{
			nint num6 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v72 (Il2CppClass<ABTest.ABTestManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num5 = (nint)typeof(ABTestManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num5 = (nint)typeof(ABTestManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ L0_v6 (Il2CppClass<ABTest.ABTestManager>)+5C]");
		object obj11 = (nint)0 + (nint)28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @110C5");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v7 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S4_v8+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v9+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S5_v7 (should have been resolved before IL gen)");
		nint num8 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v31 (Il2CppClass<ABTest.ABTestManager>)+5C]");
		object obj17 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @110C5");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S4_v12 (Il2CppMethodInfo)+C]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S4_v13+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S4_v14+48]");
		object obj20 = 0;
		object obj21 = obj20 & 0x7FF;
		object obj22 = obj21 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S5_v11 (should have been resolved before IL gen)");
		nint num10 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v38 (Il2CppClass<ABTest.ABTestManager>)+5C]");
		object obj23 = (nint)0 + (nint)20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @110C5");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S4_v17 (Il2CppMethodInfo)+C]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S4_v18+60]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S4_v19+48]");
		object obj26 = 0;
		object obj27 = obj26 & 0x7FF;
		object obj28 = obj27 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v185 @ S5_v15 (should have been resolved before IL gen)");
		nint num12 = (nint)typeof(ABTestManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v45 (Il2CppClass<ABTest.ABTestManager>)+5C]");
		object obj29 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @110C5");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S4_v22 (Il2CppMethodInfo)+C]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S4_v23+60]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S4_v24+48]");
		object obj32 = 0;
		object obj33 = obj32 & 0x7FF;
		object obj34 = obj33 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S5_v19 (should have been resolved before IL gen)");
		nint num14 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v52 (Il2CppClass<Flurry>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num15 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v68 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_boostsScreen = 0u;
		_earnCoinsScreen = 0u;
		_storeScreen = 0u;
		_quickStorePopup = 0u;
	}
}
