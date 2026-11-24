using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ABTest;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Analytics;
using Kiloo.Common.Ads;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Plugins.DeviceUtility.Internal;
using Kiloo.Common.Timer;
using Kiloo.Common.UI;
using Kiloo.Common.Utility;
using Missions;
using Mono.Security;
using SYBO.Components.Analytics;
using SYBO.Subway.Info;
using SYBO.Subway.Utilities;
using TopRun.UI;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Helpers;
using UI.Popups.ConsumablesPopupInternal;
using UI.Popups.SecretPopupInternal;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Popups;

public class SecretPopup : UIScreen
{
	[StructLayout((LayoutKind)0, Size = 20)]
	private struct PageContent(string key, Func<string> value, SecretCellType infoType = SecretCellType.Info, string key2 = null, Func<string> value2 = null)
	{
		public string key;

		public Func<string> value;

		public SecretCellType infoType = (SecretCellType)key;

		public string key2 = (string)(object)value;

		public Func<string> value2 = (Func<string>)infoType;
	}

	private enum TabNumber
	{
		Tab1,
		Tab2,
		Tab3,
		Tab4
	}

	private enum FileLogType
	{
		Data,
		Cache
	}

	private class SecretListAdapter : ListAdapter<SecretCell>
	{
		private GameObject _secretPrefab;

		private GameObject _secretSubtitlePrefab;

		private GameObject _secretEndList;

		private GameObject _secretInfoDoublePrefab;

		private const int SECRET_INFO_PREFAB = 0;

		private const int SECRET_SUBTITLE_PREFAB = 1;

		private const int SECRET_ENDLIST_PREFAB = 2;

		private const int SECRET_INFO_DOUBLE_PREFAB = 3;

		public SecretListAdapter(List<SecretCell> contentList, GameObject newSecretPrefab, GameObject newInfoDoublePrefab, GameObject newSecretSubtitlePrefab, GameObject newSecretEndList)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		}

		public void SetNewDataList(List<SecretCell> leaderboardListT)
		{
		}

		public override int GetModelType(int index)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+15]");
			return ((nint)0 != 0) ? 1 : 0;
		}

		public unsafe override Container GetContainer(Container container, int dataIndex, bool isMeasurePass)
		{
			//IL_001e: Expected I4, but got Obj
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_004b: Expected Obj, but got VT
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_00b4: Expected Obj, but got I4
			//IL_00c9: Expected Obj, but got I
			//IL_00f2: Expected Obj, but got I4
			Container container2 = default;
			Container container3 = default;
			if (container2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				container3.Measure((byte)(int)_secretPrefab != 0);
				object obj = container3 + 84;
				_0021_00210 componentInChildren = (_0021_00210)container3.model.GetComponentInChildren<T>();
				obj = componentInChildren;
				bool hasVertices = ((UIGeometry)(object)container3.model).hasVertices;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj2 = default;
				obj2.method_ptr = method_ptr;
				obj2.method = (nint)__ldftn(LanguageSelectionPopup.OnClickContainer);
				object obj3 = obj2 + 16;
				obj3 = _secretSubtitlePrefab;
				object obj4 = (hasVertices ? 1 : 0) + 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v21 (System.Boolean)+14]");
				Delegate obj5 = ((Delegate)0).CombineImpl(obj2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj6 = default;
				obj4 = obj6;
				object obj7 = (hasVertices ? 1 : 0) + 12;
				obj7 = container3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			string msg = default;
			UnityEngine.Object context = default;
			SellConsumablesHelper.Log(msg, context);
			return container3;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string> _003C_003E9__32_0;

		public static Func<string> _003C_003E9__32_1;

		public static Func<string> _003C_003E9__32_2;

		public static Func<string> _003C_003E9__32_3;

		public static Func<string> _003C_003E9__32_4;

		public static Func<string> _003C_003E9__32_5;

		public static Func<string> _003C_003E9__32_6;

		public static Func<string> _003C_003E9__32_7;

		public static Func<string> _003C_003E9__32_8;

		public static Func<string> _003C_003E9__32_9;

		public static Func<string> _003C_003E9__32_10;

		public static Func<string> _003C_003E9__32_11;

		public static Func<string> _003C_003E9__32_12;

		public static Func<string> _003C_003E9__32_13;

		public static Func<string> _003C_003E9__32_14;

		public static Func<string> _003C_003E9__32_15;

		public static Func<string> _003C_003E9__32_16;

		public static Func<string> _003C_003E9__32_17;

		public static Func<string> _003C_003E9__32_18;

		public static Func<string> _003C_003E9__32_19;

		public static Func<string> _003C_003E9__32_20;

		public static Func<string> _003C_003E9__32_21;

		public static Func<string> _003C_003E9__32_22;

		public static Func<string> _003C_003E9__32_23;

		public static Func<string> _003C_003E9__32_24;

		public static Func<string> _003C_003E9__32_25;

		public static Func<string> _003C_003E9__32_26;

		public static Func<string> _003C_003E9__32_27;

		public static Func<string> _003C_003E9__32_28;

		public static Func<string> _003C_003E9__32_29;

		public static Func<string> _003C_003E9__32_30;

		public static Func<string> _003C_003E9__32_31;

		public static Func<string> _003C_003E9__32_32;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PrivacyPolicyPopUp._003C_003Ec obj = default;
			PrivacyPolicyPopUp._003C_003Ec._003C_003E9 = obj;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_0()
		{
			//IL_001d: Expected Obj, but got I
			//IL_0021: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopup+<>c)+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Popups.SecretPopup+<>c)+8]");
			return (string)((SellConsumablesHelper)num).IsConsumableVideoCached(isInRun: false);
		}

		internal string _003CPopulateContentDictionary_003Eb__32_1()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime welcomePackStartTime = UserSave.welcomePackStartTime;
			obj = welcomePackStartTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCE1");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_2()
		{
			//IL_0011: Expected Obj, but got VT
			DateTime utcNow = CDateTime.UtcNow;
			object obj = utcNow;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCE1");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_3()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime lastDailyOnlineLog = UserSave.lastDailyOnlineLog;
			obj = lastDailyOnlineLog;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCE1");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_4()
		{
			//IL_0009: Expected Obj, but got I4
			return (string)SyboAnalyticsSave.syboAnalyticsCurrentSession;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_5()
		{
			//IL_0011: Expected Obj, but got I4
			int unrewardedCoins = InventorySave.unrewardedCoins;
			object obj = unrewardedCoins;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_6()
		{
			//IL_0011: Expected Obj, but got I4
			int coins = InventorySave.coins;
			object obj = coins;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_7()
		{
			//IL_0011: Expected Obj, but got I4
			int currentOutfitIndex = PlayerSave.currentOutfitIndex;
			object obj = currentOutfitIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_8()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int wordHuntLastPayoutDayOfYear = EventsSave.wordHuntLastPayoutDayOfYear;
			obj = wordHuntLastPayoutDayOfYear;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_9()
		{
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<Characters.CharacterId, bool> hasCharacterBeenSeen = UserSave.hasCharacterBeenSeen;
			if (hasCharacterBeenSeen != null)
			{
				return "Yes";
			}
			return "No";
		}

		internal string _003CPopulateContentDictionary_003Eb__32_10()
		{
			//IL_000a: Expected Obj, but got I4
			string type = ((Notification)33).type;
			object obj = type;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_11()
		{
			//IL_0060: Expected Obj, but got I4
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00b8: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MissionsManager instance = MissionsManager.Instance;
			bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)4);
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_12()
		{
			//IL_0060: Expected Obj, but got I4
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00b8: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MissionsManager instance = MissionsManager.Instance;
			bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)3);
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_13()
		{
			//IL_0060: Expected Obj, but got I4
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00b8: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MissionsManager instance = MissionsManager.Instance;
			bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)2);
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_14()
		{
			//IL_0060: Expected Obj, but got I4
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00b8: Expected Obj, but got I4
			//IL_00c4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AwardsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Missions.AwardsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			MissionsManager instance = MissionsManager.Instance;
			bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)1);
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_15()
		{
			//IL_0011: Expected Obj, but got I4
			int missionsVersion = PlayerSave.missionsVersion;
			object obj = missionsVersion;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_16()
		{
			return SystemInfo.GetGraphicsDeviceName();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_17()
		{
			return SystemInfo.GetDeviceModel();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_18()
		{
			//IL_0009: Expected Obj, but got I4
			return (string)SystemInfo.GetOperatingSystemFamily();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_19()
		{
			//IL_0021: Expected Obj, but got I4
			NetworkReachability internetReachability = Application.internetReachability;
			object obj = internetReachability;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_20()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I
			//IL_00ba: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7B5E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12+18]");
			return (string)0;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_21()
		{
			//IL_0066: Expected Obj, but got I4
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<DeviceInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6 (System.Int32)+8]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_22()
		{
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DeviceInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Int32)+18]");
			if ((nint)0 != 0)
			{
				return "High";
			}
			return "Low";
		}

		internal string _003CPopulateContentDictionary_003Eb__32_23()
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_0056: Expected Obj, but got I4
			//IL_000d: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 4;
			int height = Screen.height;
			obj = height;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			int sleepTimeout = Screen.sleepTimeout;
			obj2 = sleepTimeout;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string text2 = default;
			return text + "x" + text2;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_24()
		{
			string deviceUniqueIdentifier = SystemInfo.GetDeviceUniqueIdentifier();
			object obj = deviceUniqueIdentifier;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			return text + " MB";
		}

		internal string _003CPopulateContentDictionary_003Eb__32_25()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DE6");
			object obj3 = default;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_26()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DE8");
			object obj3 = default;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_27()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DEA");
			object obj3 = default;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_28()
		{
			//IL_0009: Expected Obj, but got I4
			return (string)SystemInfo.GetProcessorFrequencyMHz();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_29()
		{
			return SystemInfo.GetGraphicsDeviceVersion();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_30()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00b5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<DeviceInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6 (System.Int32)+1C]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}

		internal string _003CPopulateContentDictionary_003Eb__32_31()
		{
			//IL_0066: Expected Obj, but got I4
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj = 0;
			nint num = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<DeviceInfo>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6 (System.Int32)+20]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}

		internal string _003CPopulateContentDictionary_003Eb__32_32()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF0");
			object obj2 = default;
			object obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string result = default;
			return result;
		}
	}

	private sealed class _003CShowTextCopied_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SecretPopup _003C_003E4__this;

		private float _003Cduration_003E5__2;

		private float _003CfromAlpha_003E5__3;

		private float _003CtoAlpha_003E5__4;

		private float _003Cfactor_003E5__5;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0085: Expected Obj, but got I4
				//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Expected Obj, but got Unknown
				//IL_00e5: Expected Obj, but got I4
				//IL_0236: Expected I, but got Obj
				//IL_024c: Expected Obj, but got I
				//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d2: Expected Obj, but got Unknown
				//IL_01ee: Expected Obj, but got I4
				//IL_0277: Expected I, but got Obj
				//IL_0163: Expected Obj, but got I4
				//IL_0398: Unknown result type (might be due to invalid IL or missing references)
				//IL_039d: Expected Obj, but got Unknown
				//IL_03a6: Expected Obj, but got I4
				//IL_03ba: Expected Obj, but got I4
				SecretPopup secretPopup = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								secretPopup._copiedTextGO.tag = null;
								secretPopup._copyButton.tag = (string)1;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003Cduration_003E5__2 = 0.7f;
						_003CfromAlpha_003E5__3 = 1f;
						_003CtoAlpha_003E5__4 = 0f;
						_003Cfactor_003E5__5 = 0f;
					}
					if (!(_003Cfactor_003E5__5 < 1f))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = -1f;
						_ = 0.05f;
						object obj = this + 12;
						object obj2 = default;
						obj = obj2;
						_003C_003E1__state = 3;
						return 1;
					}
					float aspectRatio = Utils.GetAspectRatio();
					float num = aspectRatio / _003Cduration_003E5__2;
					float num2 = _003Cfactor_003E5__5 + num;
					_003Cfactor_003E5__5 = num2;
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v33 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v43 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (_003Cfactor_003E5__5 < 0f)
					{
						num5 = 0f;
					}
					else
					{
						num5 = ((!(_003Cfactor_003E5__5 > 1f)) ? _003Cfactor_003E5__5 : 1f);
					}
					_003Cfactor_003E5__5 = num5;
					float num6 = Mathf.LerpUnclamped(_003CfromAlpha_003E5__3, _003CtoAlpha_003E5__4, _003Cfactor_003E5__5);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				secretPopup._copiedTextGO.tag = (string)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
				secretPopup._copyButton.tag = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = -1f;
				_ = 0.6f;
				object obj5 = this + 12;
				object obj6 = default;
				obj5 = obj6;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CShowTextCopied_003Ed__47(int _003C_003E1__state)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0018: Expected Obj, but got I4
			object obj = this + 12;
			obj = _003C_003E1__state;
			((Container)this).hasTransientState = false;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF2");
			object obj2 = default;
			object obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			bool result = default;
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILabel _popupTitle;

	private GameObject _copyButton;

	private UILabel _copyButtonLabel;

	private Layout _copyButtonLayout;

	private GameObject _copiedTextGO;

	private UILabel _copiedTextLabel;

	private GameObject SecretCellPrefab;

	private GameObject SecretCellSubtitlePrefab;

	private GameObject SecretCellEndList;

	private GameObject SecretCellInfoDouble;

	private List<SecretCell> _contentList;

	private SecretListAdapter _adapter;

	private ScrollView _scrollView;

	private StringBuilder _infoToBeCopiedToClipboard;

	private int _lastTab1Index;

	private int _lastTab2Index;

	private int _lastTab3Index;

	private int _lastTab4Index;

	private TabNumber _lastTabOpen;

	private string _advertisingIdentifier;

	private const string ANDROID_BASED_BUNDLE_IDENTIFIER = "com.kiloo.subwaysurf";

	private const string IOS_BUNDLE_IDENTIFIER = "com.kiloo.subwaysurfers";

	private SVNDevInfo _svnDevInfo;

	private Dictionary<TabNumber, List<PageContent>> _contentDict;

	private bool _listHasBeenDisplayedOnce;

	private const string ONLINESETTINGS_ANALYTICS_SAMPLE_SIZE_KEY = "kiloo_analytics_sample";

	private const float DEFAULT_ANALYTICS_SAMPLE_SIZE = 0f;

	private List<FileInfo> _files;

	private StringBuilder fileInfoStringBuilder;

	private long _sectionSize;

	private long _totalSize;

	public override void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	public override void Show()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		ShowIfInactive();
		if (_contentList != null)
		{
			object awardCell = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AwardsScreen.AwardListAdapter awardListAdapter = default;
			awardListAdapter._002Ector((List<AwardCell>)(object)_contentList, (GameObject)awardCell, SecretCellInfoDouble, SecretCellSubtitlePrefab, (AwardsScreen)(object)SecretCellEndList);
			object obj = this + 84;
			obj = awardListAdapter;
		}
		CopyToClipboard();
		DisplayList1();
	}

	public override void Hide()
	{
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_02fb: Expected I4, but got Obj
		//IL_026c: Expected I4, but got Obj
		//IL_021e: Expected I, but got Obj
		//IL_028d: Expected Obj, but got I4
		base.Hide();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string, bool> action = default;
		object obj = action + 16;
		obj = this;
		AdSystemManager.onCachedVideo -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		AdSystemManager.onCachedInterstitial -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj3 = action3 + 16;
		obj3 = this;
		AdSystemManager.onFailedToCacheVideo -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj4 = action4 + 16;
		obj4 = this;
		AdSystemManager.onFailedToCacheInterstitial -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj5 = action5 + 16;
		obj5 = this;
		AdSystemManager.onPriorityListWrapped -= action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<string> action6 = default;
		object obj6 = action6 + 16;
		obj6 = this;
		AdSystemManager.onChangedProvider -= action6;
		if (_lastTabOpen != TabNumber.Tab1)
		{
			if (_lastTabOpen != TabNumber.Tab2)
			{
				if (_lastTabOpen != TabNumber.Tab3)
				{
					if (_lastTabOpen == TabNumber.Tab4)
					{
						SetEndOfList();
					}
				}
				else
				{
					DisplayList4();
				}
			}
			else
			{
				DisplayList3();
			}
		}
		else
		{
			DisplayList2();
		}
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v47 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v60 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SECRET_POPUP_BUTTON_COPY");
		_copyButtonLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("SECRET_POPUP_BUTTON_COPIED");
		_copiedTextLabel.fontSize = (int)text2;
		_copiedTextGO.tag = null;
		_copyButton.tag = (string)1;
		((RewardForVideoButton)(object)_copyButtonLayout).Init((VideoButtonPayload)null);
	}

	private bool IsAndroidDevice()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)"NotEnoughCurencyPopup" != 0;
	}

	private bool IsiOSDevice()
	{
		string dataPath = Application.dataPath;
		return (nint)dataPath == 11;
	}

	private void CacheStateChangedForLocation(string location)
	{
		//IL_0796: Expected Obj, but got I
		//IL_07a6: Expected Obj, but got I
		//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected Obj, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected Obj, but got Unknown
		//IL_07ea: Expected Obj, but got I
		//IL_07fa: Expected Obj, but got I
		//IL_080a: Expected Obj, but got I
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_0846: Expected Obj, but got I
		//IL_0856: Expected Obj, but got I
		//IL_0866: Expected Obj, but got I
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_08a2: Expected Obj, but got I
		//IL_08b2: Expected Obj, but got I
		//IL_08c2: Expected Obj, but got I
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected Obj, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected Obj, but got Unknown
		//IL_08fe: Expected Obj, but got I
		//IL_090e: Expected Obj, but got I
		//IL_091e: Expected Obj, but got I
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Obj, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_0952: Expected I, but got Obj
		//IL_0968: Expected Obj, but got I
		//IL_0993: Expected I, but got Obj
		//IL_09a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected Obj, but got Unknown
		//IL_09e6: Expected Obj, but got I4
		//IL_0158: Expected I, but got Obj
		//IL_030e: Expected I, but got Obj
		//IL_0324: Expected Obj, but got I
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected Obj, but got Unknown
		//IL_03a5: Expected Obj, but got I4
		//IL_034f: Expected I, but got Obj
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_0b0a: Expected I4, but got Obj
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_03e0: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05e0: Expected Obj, but got I4
		//IL_058a: Expected I, but got Obj
		//IL_0a3e: Expected I, but got Obj
		//IL_0a54: Expected Obj, but got I
		//IL_0274: Expected I, but got Obj
		//IL_0421: Expected I, but got Obj
		//IL_061b: Expected I, but got Obj
		//IL_0631: Expected Obj, but got I
		//IL_02c1: Expected I, but got Obj
		//IL_046e: Expected I, but got Obj
		//IL_0484: Expected Obj, but got I
		//IL_0ac0: Expected I, but got Obj
		//IL_0ad6: Expected Obj, but got I
		//IL_065c: Expected I, but got Obj
		//IL_04af: Expected I, but got Obj
		//IL_06a9: Expected I, but got Obj
		//IL_06bf: Expected Obj, but got I
		//IL_04fc: Expected I, but got Obj
		//IL_0b42: Expected I, but got Obj
		//IL_0b58: Expected Obj, but got I
		//IL_06ea: Expected I, but got Obj
		//IL_0737: Expected I, but got Obj
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
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S4_v7+60]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S4_v8+48]");
		object obj8 = 0;
		object obj9 = obj8 & 0x7FF;
		object obj10 = obj9 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S5_v6 (should have been resolved before IL gen)");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v12+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v13+48]");
		object obj13 = 0;
		object obj14 = obj13 & 0x7FF;
		object obj15 = obj14 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S5_v10 (should have been resolved before IL gen)");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v17+60]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v18+48]");
		object obj18 = 0;
		object obj19 = obj18 & 0x7FF;
		object obj20 = obj19 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v86 @ S5_v14 (should have been resolved before IL gen)");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S4_v22+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v23+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v105 @ S5_v18 (should have been resolved before IL gen)");
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v17 (Il2CppClass<Flurry>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v206 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num8 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v22 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num9 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v200 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NotEnoughCurrencyPopup._popupData == null)
		{
			return;
		}
		object obj28 = location - 1;
		if ((nint)location != 1)
		{
			if ((nint)obj28 != 1)
			{
				if ((nint)obj28 != 2)
				{
					return;
				}
				nint num10 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v145 (Il2CppClass<InApp.InAppManager>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num11 = (nint)typeof(InAppManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v196 (Il2CppClass<InApp.InAppManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
				((InAppManager)(object)activeInAppOffers).ShowSlideInForBoard((Boards.BoardId)"0");
				Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
				object obj30 = activeInAppOffers2 + 60;
				obj30 = 0;
				if (!(base.parentScreen__BackingField != "CharacterNameEventPopup"))
				{
					return;
				}
				nint num12 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v159 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
				object obj31 = (nint)0 & (nint)0x200;
				if (obj31 != null)
				{
					nint num13 = (nint)typeof(NotEnoughCurrencyPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S0_v190 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				InAppManagerPopupData popupData = NotEnoughCurrencyPopup._popupData;
				if (popupData.isErrorMessage)
				{
					return;
				}
				nint num14 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v168 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num15 = (nint)typeof(NotEnoughCurrencyPopup);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v184 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num16 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v177 (Il2CppClass<Flurry>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num17 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v180 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return;
			}
			nint num18 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v88 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num19 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v140 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
			((InAppManager)(object)activeInAppOffers3).NativePurchaseFail("0");
			Dictionary<string, InAppItemModel> activeInAppOffers4 = InAppManager.GetActiveInAppOffers();
			object obj35 = activeInAppOffers4 + 60;
			obj35 = 0;
			if (!(base.parentScreen__BackingField != "CharacterNameEventPopup"))
			{
				return;
			}
			nint num20 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v102 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num21 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v134 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppManagerPopupData popupData2 = NotEnoughCurrencyPopup._popupData;
			if (popupData2.isErrorMessage)
			{
				return;
			}
			nint num22 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v111 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num23 = (nint)typeof(NotEnoughCurrencyPopup);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v128 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num24 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ S0_v120 (Il2CppClass<Flurry>)+BA]");
			object obj38 = (nint)0 & (nint)0x200;
			if (obj38 != null)
			{
				nint num25 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v124 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		nint num26 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v33 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num27 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v83 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers5 = InAppManager.GetActiveInAppOffers();
		object obj40 = activeInAppOffers5 + 60;
		obj40 = 0;
		if (!(base.parentScreen__BackingField != "CharacterNameEventPopup"))
		{
			return;
		}
		nint num28 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v45 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num29 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v77 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManagerPopupData popupData3 = NotEnoughCurrencyPopup._popupData;
		if (popupData3.isErrorMessage)
		{
			return;
		}
		nint num30 = (nint)typeof(NotEnoughCurrencyPopup);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S0_v54 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+BA]");
		object obj42 = (nint)0 & (nint)0x200;
		if (obj42 != null)
		{
			nint num31 = (nint)typeof(NotEnoughCurrencyPopup);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v71 (Il2CppClass<UI.Popups.NotEnoughCurrencyPopup>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num32 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v63 (Il2CppClass<Flurry>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		if (obj43 != null)
		{
			nint num33 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ S0_v67 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void CacheStateChangedForLocation(string location, bool wasAlreadyCached)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got VT
		object obj = this + 120;
		obj = location;
		_0021_00210 componentInChildren = (_0021_00210)((GameObject)(object)location).GetComponentInChildren<T>();
		((BuyMoreInStoreLabelHelper)componentInChildren)._002Ector();
	}

	private void PopulateContentDictionary()
	{
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0111: Expected Obj, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		base.LoseFocus();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		AdSystemManager.onFailedToCacheVideo += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		AdSystemManager.onFailedToCacheInterstitial += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action3 = default;
		object obj3 = action3 + 16;
		obj3 = this;
		AdSystemManager.onFinishedWatchingVideo += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action4 = default;
		object obj4 = action4 + 16;
		obj4 = this;
		AdSystemManager.onShowedInterstitial += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<string> action5 = default;
		object obj5 = action5 + 16;
		obj5 = this;
		AdSystemManager.onChangedProvider += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		AdSystemManager adSystemManager = default;
		adSystemManager._isInitialized = (byte)num6 != 0;
		adSystemManager._lastShowedProviderPerLocation = (Dictionary<string, string>)0;
		object obj6 = adSystemManager + 16;
		obj6 = this;
		adSystemManager.Initialize();
		LoadAdvertisingInfoAsync();
	}

	private void SetListContent(TabNumber tab)
	{
		InsertInfo(null, null);
	}

	public unsafe void DisplayList1()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_37a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_37a5: Expected Obj, but got Unknown
		//IL_37d3: Expected Obj, but got I
		//IL_37e3: Expected Obj, but got I
		//IL_37f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f9: Expected Obj, but got Unknown
		//IL_3802: Unknown result type (might be due to invalid IL or missing references)
		//IL_3807: Expected Obj, but got Unknown
		//IL_3817: Unknown result type (might be due to invalid IL or missing references)
		//IL_381c: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected VT, but got Unknown
		//IL_0086: Expected native int or pointer, but got VT
		//IL_009b: Expected native int or pointer, but got VT
		//IL_00b5: Expected Obj, but got I
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0134: Expected Obj, but got I4
		//IL_0157: Expected native int or pointer, but got VT
		//IL_016c: Expected native int or pointer, but got VT
		//IL_0186: Expected Obj, but got I
		//IL_0181: Expected native int or pointer, but got VT
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_3845: Unknown result type (might be due to invalid IL or missing references)
		//IL_384a: Expected Obj, but got Unknown
		//IL_3853: Expected Obj, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected Obj, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected Obj, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0283: Expected Obj, but got I4
		//IL_01e2: Expected I, but got Obj
		//IL_02a6: Expected native int or pointer, but got VT
		//IL_02bb: Expected native int or pointer, but got VT
		//IL_02d5: Expected Obj, but got I
		//IL_02d0: Expected native int or pointer, but got VT
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0329: Expected Obj, but got I4
		//IL_0347: Expected native int or pointer, but got VT
		//IL_035c: Expected native int or pointer, but got VT
		//IL_0376: Expected Obj, but got I
		//IL_0371: Expected native int or pointer, but got VT
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I4
		//IL_03ed: Expected native int or pointer, but got VT
		//IL_0402: Expected native int or pointer, but got VT
		//IL_041c: Expected Obj, but got I
		//IL_0417: Expected native int or pointer, but got VT
		//IL_0437: Expected I, but got Obj
		//IL_044d: Expected Obj, but got I
		//IL_4db5: Expected Obj, but got I4
		//IL_4dd3: Expected native int or pointer, but got VT
		//IL_4de8: Expected native int or pointer, but got VT
		//IL_4e02: Expected Obj, but got I
		//IL_4dfd: Expected native int or pointer, but got VT
		//IL_0478: Expected I, but got Obj
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I4
		//IL_058d: Expected native int or pointer, but got VT
		//IL_05a2: Expected native int or pointer, but got VT
		//IL_05bc: Expected Obj, but got I
		//IL_05b7: Expected native int or pointer, but got VT
		//IL_04c5: Expected I, but got Obj
		//IL_04db: Expected Obj, but got I
		//IL_05dc: Expected I, but got Obj
		//IL_05f2: Expected Obj, but got I
		//IL_38c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_38cd: Expected Obj, but got Unknown
		//IL_38e4: Expected I, but got Obj
		//IL_38fa: Expected Obj, but got I
		//IL_0506: Expected I, but got Obj
		//IL_4e27: Expected Obj, but got I4
		//IL_4e45: Expected native int or pointer, but got VT
		//IL_4e5a: Expected native int or pointer, but got VT
		//IL_4e74: Expected Obj, but got I
		//IL_4e6f: Expected native int or pointer, but got VT
		//IL_4e8f: Expected I, but got Obj
		//IL_4ea5: Expected Obj, but got I
		//IL_061d: Expected I, but got Obj
		//IL_066a: Expected I, but got Obj
		//IL_0680: Expected Obj, but got I
		//IL_4ecb: Expected Obj, but got I4
		//IL_4ee9: Expected native int or pointer, but got VT
		//IL_4efe: Expected native int or pointer, but got VT
		//IL_4f18: Expected Obj, but got I
		//IL_4f13: Expected native int or pointer, but got VT
		//IL_06f8: Expected I, but got Obj
		//IL_3962: Unknown result type (might be due to invalid IL or missing references)
		//IL_3967: Expected Obj, but got Unknown
		//IL_397e: Expected I, but got Obj
		//IL_3994: Expected Obj, but got I
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected Obj, but got Unknown
		//IL_07ef: Expected Obj, but got I4
		//IL_080d: Expected native int or pointer, but got VT
		//IL_0822: Expected native int or pointer, but got VT
		//IL_083c: Expected Obj, but got I
		//IL_0837: Expected native int or pointer, but got VT
		//IL_0745: Expected I, but got Obj
		//IL_075b: Expected Obj, but got I
		//IL_06ab: Expected I, but got Obj
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_0882: Expected Obj, but got I4
		//IL_39fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a01: Expected Obj, but got Unknown
		//IL_3a18: Expected I, but got Obj
		//IL_3a2e: Expected Obj, but got I
		//IL_08a5: Expected native int or pointer, but got VT
		//IL_08ba: Expected native int or pointer, but got VT
		//IL_08d4: Expected Obj, but got I
		//IL_08cf: Expected native int or pointer, but got VT
		//IL_0786: Expected I, but got Obj
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected Obj, but got Unknown
		//IL_091a: Expected Obj, but got I4
		//IL_0938: Expected native int or pointer, but got VT
		//IL_094d: Expected native int or pointer, but got VT
		//IL_0967: Expected Obj, but got I
		//IL_0962: Expected native int or pointer, but got VT
		//IL_098f: Expected Obj, but got I
		//IL_099f: Expected Obj, but got I
		//IL_09af: Expected Obj, but got I
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cb: Expected Obj, but got Unknown
		//IL_09fb: Expected I, but got Obj
		//IL_0a11: Expected Obj, but got I
		//IL_3a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a51: Expected Obj, but got Unknown
		//IL_0a3c: Expected I, but got Obj
		//IL_3a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a6f: Expected Obj, but got Unknown
		//IL_3a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7d: Expected Obj, but got Unknown
		//IL_3aa9: Expected Obj, but got I4
		//IL_4f72: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f77: Expected Obj, but got Unknown
		//IL_4f85: Expected Obj, but got I4
		//IL_4fa3: Expected native int or pointer, but got VT
		//IL_4fb8: Expected native int or pointer, but got VT
		//IL_4fd2: Expected Obj, but got I
		//IL_4fcd: Expected native int or pointer, but got VT
		//IL_0c74: Expected Obj, but got I
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_0d6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d74: Expected Obj, but got Unknown
		//IL_0d82: Expected Obj, but got I4
		//IL_0da0: Expected native int or pointer, but got VT
		//IL_0db5: Expected native int or pointer, but got VT
		//IL_0dcf: Expected Obj, but got I
		//IL_0dca: Expected native int or pointer, but got VT
		//IL_0caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0caf: Expected Obj, but got Unknown
		//IL_0af8: Expected Obj, but got I
		//IL_0b0b: Expected Obj, but got I
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e07: Expected Obj, but got Unknown
		//IL_0e15: Expected Obj, but got I4
		//IL_0b34: Expected Obj, but got I4
		//IL_0e38: Expected native int or pointer, but got VT
		//IL_0e4d: Expected native int or pointer, but got VT
		//IL_0e67: Expected Obj, but got I
		//IL_0e62: Expected native int or pointer, but got VT
		//IL_0e82: Expected I, but got Obj
		//IL_0e98: Expected Obj, but got I
		//IL_0ce0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce5: Expected Obj, but got Unknown
		//IL_0b42: Expected Obj, but got I4
		//IL_0b60: Expected native int or pointer, but got VT
		//IL_0b75: Expected native int or pointer, but got VT
		//IL_0b8f: Expected Obj, but got I
		//IL_0b8a: Expected native int or pointer, but got VT
		//IL_0baa: Expected Obj, but got I4
		//IL_0bb3: Expected Obj, but got I4
		//IL_103f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1044: Expected Obj, but got Unknown
		//IL_0ec3: Expected I, but got Obj
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1074: Expected Obj, but got Unknown
		//IL_1082: Expected Obj, but got I4
		//IL_10a0: Expected native int or pointer, but got VT
		//IL_10b5: Expected native int or pointer, but got VT
		//IL_10cf: Expected Obj, but got I
		//IL_10ca: Expected native int or pointer, but got VT
		//IL_0f10: Expected I, but got Obj
		//IL_0f26: Expected Obj, but got I
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected Obj, but got Unknown
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		//IL_1137: Expected Obj, but got Unknown
		//IL_1145: Expected Obj, but got I4
		//IL_1163: Expected native int or pointer, but got VT
		//IL_1178: Expected native int or pointer, but got VT
		//IL_1192: Expected Obj, but got I
		//IL_118d: Expected native int or pointer, but got VT
		//IL_4fed: Expected Obj, but got I4
		//IL_500b: Expected native int or pointer, but got VT
		//IL_5020: Expected native int or pointer, but got VT
		//IL_503a: Expected Obj, but got I
		//IL_5035: Expected native int or pointer, but got VT
		//IL_0f51: Expected I, but got Obj
		//IL_11c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ca: Expected Obj, but got Unknown
		//IL_11d8: Expected Obj, but got I4
		//IL_0f9e: Expected I, but got Obj
		//IL_0fb4: Expected Obj, but got I
		//IL_11fb: Expected native int or pointer, but got VT
		//IL_1210: Expected native int or pointer, but got VT
		//IL_122a: Expected Obj, but got I
		//IL_1225: Expected native int or pointer, but got VT
		//IL_1245: Expected I, but got Obj
		//IL_125b: Expected Obj, but got I
		//IL_3b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b32: Expected Obj, but got Unknown
		//IL_3b49: Expected I, but got Obj
		//IL_3b5f: Expected Obj, but got I
		//IL_3b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ba3: Expected Obj, but got Unknown
		//IL_3bb4: Expected Obj, but got I4
		//IL_0fdf: Expected I, but got Obj
		//IL_12cd: Expected native int or pointer, but got VT
		//IL_12e2: Expected native int or pointer, but got VT
		//IL_12fc: Expected Obj, but got I
		//IL_12f7: Expected native int or pointer, but got VT
		//IL_1286: Expected I, but got Obj
		//IL_1338: Unknown result type (might be due to invalid IL or missing references)
		//IL_133d: Expected Obj, but got Unknown
		//IL_134e: Expected Obj, but got I4
		//IL_1371: Expected native int or pointer, but got VT
		//IL_1386: Expected native int or pointer, but got VT
		//IL_13a0: Expected Obj, but got I
		//IL_139b: Expected native int or pointer, but got VT
		//IL_13d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d8: Expected Obj, but got Unknown
		//IL_13e6: Expected Obj, but got I4
		//IL_1404: Expected native int or pointer, but got VT
		//IL_1419: Expected native int or pointer, but got VT
		//IL_1433: Expected Obj, but got I
		//IL_142e: Expected native int or pointer, but got VT
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Expected Obj, but got Unknown
		//IL_1496: Unknown result type (might be due to invalid IL or missing references)
		//IL_149b: Expected Obj, but got Unknown
		//IL_14a9: Expected Obj, but got I4
		//IL_14c7: Expected native int or pointer, but got VT
		//IL_14dc: Expected native int or pointer, but got VT
		//IL_14f6: Expected Obj, but got I
		//IL_14f1: Expected native int or pointer, but got VT
		//IL_151e: Expected Obj, but got I
		//IL_152e: Expected Obj, but got I
		//IL_153e: Expected Obj, but got I
		//IL_1547: Unknown result type (might be due to invalid IL or missing references)
		//IL_154c: Expected Obj, but got Unknown
		//IL_1555: Unknown result type (might be due to invalid IL or missing references)
		//IL_155a: Expected Obj, but got Unknown
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a2: Expected Obj, but got Unknown
		//IL_15b0: Expected Obj, but got I4
		//IL_15d3: Expected native int or pointer, but got VT
		//IL_15e8: Expected native int or pointer, but got VT
		//IL_1602: Expected Obj, but got I
		//IL_15fd: Expected native int or pointer, but got VT
		//IL_16f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f9: Expected Obj, but got Unknown
		//IL_1707: Expected Obj, but got I4
		//IL_172a: Expected native int or pointer, but got VT
		//IL_173f: Expected native int or pointer, but got VT
		//IL_1759: Expected Obj, but got I
		//IL_1754: Expected native int or pointer, but got VT
		//IL_165c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1661: Expected Obj, but got Unknown
		//IL_166f: Expected Obj, but got I4
		//IL_178c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1791: Expected Obj, but got Unknown
		//IL_179f: Expected Obj, but got I4
		//IL_17bd: Expected native int or pointer, but got VT
		//IL_17d2: Expected native int or pointer, but got VT
		//IL_17ec: Expected Obj, but got I
		//IL_17e7: Expected native int or pointer, but got VT
		//IL_1692: Expected native int or pointer, but got VT
		//IL_16a7: Expected native int or pointer, but got VT
		//IL_16c1: Expected Obj, but got I
		//IL_16bc: Expected native int or pointer, but got VT
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1824: Expected Obj, but got Unknown
		//IL_184f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1854: Expected Obj, but got Unknown
		//IL_1862: Expected Obj, but got I4
		//IL_1880: Expected native int or pointer, but got VT
		//IL_1895: Expected native int or pointer, but got VT
		//IL_18af: Expected Obj, but got I
		//IL_18aa: Expected native int or pointer, but got VT
		//IL_18e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e7: Expected Obj, but got Unknown
		//IL_1912: Unknown result type (might be due to invalid IL or missing references)
		//IL_1917: Expected Obj, but got Unknown
		//IL_1925: Expected Obj, but got I4
		//IL_1943: Expected native int or pointer, but got VT
		//IL_1958: Expected native int or pointer, but got VT
		//IL_1972: Expected Obj, but got I
		//IL_196d: Expected native int or pointer, but got VT
		//IL_1992: Expected I, but got Obj
		//IL_19a8: Expected Obj, but got I
		//IL_505a: Expected I, but got Obj
		//IL_5070: Expected Obj, but got I
		//IL_19d3: Expected I, but got Obj
		//IL_1a20: Expected I, but got Obj
		//IL_1a36: Expected Obj, but got I
		//IL_5096: Expected Obj, but got I4
		//IL_50b4: Expected native int or pointer, but got VT
		//IL_50c9: Expected native int or pointer, but got VT
		//IL_50e3: Expected Obj, but got I
		//IL_50de: Expected native int or pointer, but got VT
		//IL_50fe: Expected I, but got Obj
		//IL_5114: Expected Obj, but got I
		//IL_1a94: Expected I, but got Obj
		//IL_3c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c27: Expected Obj, but got Unknown
		//IL_3c3e: Expected I, but got Obj
		//IL_3c54: Expected Obj, but got I
		//IL_1ae1: Expected I, but got Obj
		//IL_1af7: Expected Obj, but got I
		//IL_1a61: Expected I, but got Obj
		//IL_513f: Expected I, but got Obj
		//IL_5155: Expected Obj, but got I
		//IL_1b55: Expected I, but got Obj
		//IL_3cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3cc1: Expected Obj, but got Unknown
		//IL_3cd8: Expected I, but got Obj
		//IL_3cee: Expected Obj, but got I
		//IL_1b88: Expected I, but got Obj
		//IL_1b9e: Expected Obj, but got I
		//IL_1b22: Expected I, but got Obj
		//IL_517b: Expected Obj, but got I4
		//IL_5199: Expected native int or pointer, but got VT
		//IL_51ae: Expected native int or pointer, but got VT
		//IL_51c8: Expected Obj, but got I
		//IL_51c3: Expected native int or pointer, but got VT
		//IL_51e3: Expected I, but got Obj
		//IL_51f9: Expected Obj, but got I
		//IL_1bfc: Expected I, but got Obj
		//IL_3d56: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d5b: Expected Obj, but got Unknown
		//IL_3d72: Expected I, but got Obj
		//IL_3d88: Expected Obj, but got I
		//IL_1c2f: Expected I, but got Obj
		//IL_1c45: Expected Obj, but got I
		//IL_1bc9: Expected I, but got Obj
		//IL_5224: Expected I, but got Obj
		//IL_523a: Expected Obj, but got I
		//IL_1ca3: Expected I, but got Obj
		//IL_3df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_3df5: Expected Obj, but got Unknown
		//IL_3e0c: Expected I, but got Obj
		//IL_3e22: Expected Obj, but got I
		//IL_1cd6: Expected I, but got Obj
		//IL_1cec: Expected Obj, but got I
		//IL_1c70: Expected I, but got Obj
		//IL_5260: Expected Obj, but got I4
		//IL_527e: Expected native int or pointer, but got VT
		//IL_5293: Expected native int or pointer, but got VT
		//IL_52ad: Expected Obj, but got I
		//IL_52a8: Expected native int or pointer, but got VT
		//IL_52c8: Expected I, but got Obj
		//IL_52de: Expected Obj, but got I
		//IL_1d4a: Expected I, but got Obj
		//IL_3e8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e8f: Expected Obj, but got Unknown
		//IL_3ea6: Expected I, but got Obj
		//IL_3ebc: Expected Obj, but got I
		//IL_1d7d: Expected I, but got Obj
		//IL_1d93: Expected Obj, but got I
		//IL_1d17: Expected I, but got Obj
		//IL_5309: Expected I, but got Obj
		//IL_531f: Expected Obj, but got I
		//IL_1df1: Expected I, but got Obj
		//IL_3f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f29: Expected Obj, but got Unknown
		//IL_3f40: Expected I, but got Obj
		//IL_3f56: Expected Obj, but got I
		//IL_1e24: Expected I, but got Obj
		//IL_1e3a: Expected Obj, but got I
		//IL_1dbe: Expected I, but got Obj
		//IL_5345: Expected Obj, but got I4
		//IL_5363: Expected native int or pointer, but got VT
		//IL_5378: Expected native int or pointer, but got VT
		//IL_5392: Expected Obj, but got I
		//IL_538d: Expected native int or pointer, but got VT
		//IL_53ad: Expected I, but got Obj
		//IL_53c3: Expected Obj, but got I
		//IL_1e98: Expected I, but got Obj
		//IL_3fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3fc3: Expected Obj, but got Unknown
		//IL_3fda: Expected I, but got Obj
		//IL_3ff0: Expected Obj, but got I
		//IL_1ecb: Expected I, but got Obj
		//IL_1ee1: Expected Obj, but got I
		//IL_1e65: Expected I, but got Obj
		//IL_53ee: Expected I, but got Obj
		//IL_5404: Expected Obj, but got I
		//IL_1f3f: Expected I, but got Obj
		//IL_4058: Unknown result type (might be due to invalid IL or missing references)
		//IL_405d: Expected Obj, but got Unknown
		//IL_4074: Expected I, but got Obj
		//IL_408a: Expected Obj, but got I
		//IL_1f72: Expected I, but got Obj
		//IL_1f88: Expected Obj, but got I
		//IL_1f0c: Expected I, but got Obj
		//IL_542a: Expected Obj, but got I4
		//IL_5448: Expected native int or pointer, but got VT
		//IL_545d: Expected native int or pointer, but got VT
		//IL_5477: Expected Obj, but got I
		//IL_5472: Expected native int or pointer, but got VT
		//IL_1fe6: Expected I, but got Obj
		//IL_40f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_40f7: Expected Obj, but got Unknown
		//IL_410e: Expected I, but got Obj
		//IL_4124: Expected Obj, but got I
		//IL_2096: Unknown result type (might be due to invalid IL or missing references)
		//IL_209b: Expected Obj, but got Unknown
		//IL_20c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c6: Expected Obj, but got Unknown
		//IL_20d4: Expected Obj, but got I4
		//IL_2019: Expected I, but got Obj
		//IL_202f: Expected Obj, but got I
		//IL_1fb3: Expected I, but got Obj
		//IL_20f7: Expected native int or pointer, but got VT
		//IL_210c: Expected native int or pointer, but got VT
		//IL_2126: Expected Obj, but got I
		//IL_2121: Expected native int or pointer, but got VT
		//IL_2141: Expected I, but got Obj
		//IL_2157: Expected Obj, but got I
		//IL_418c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4191: Expected Obj, but got Unknown
		//IL_41a8: Expected I, but got Obj
		//IL_41be: Expected Obj, but got I
		//IL_205a: Expected I, but got Obj
		//IL_549c: Expected Obj, but got I4
		//IL_54ba: Expected native int or pointer, but got VT
		//IL_54cf: Expected native int or pointer, but got VT
		//IL_54e9: Expected Obj, but got I
		//IL_54e4: Expected native int or pointer, but got VT
		//IL_550c: Expected Obj, but got I
		//IL_551c: Expected Obj, but got I
		//IL_552c: Expected Obj, but got I
		//IL_5535: Unknown result type (might be due to invalid IL or missing references)
		//IL_553a: Expected Obj, but got Unknown
		//IL_5543: Unknown result type (might be due to invalid IL or missing references)
		//IL_5548: Expected Obj, but got Unknown
		//IL_2182: Expected I, but got Obj
		//IL_2232: Expected I, but got Obj
		//IL_2248: Expected Obj, but got I
		//IL_2265: Expected I, but got Obj
		//IL_21b5: Expected I, but got Obj
		//IL_21cb: Expected Obj, but got I
		//IL_4283: Expected Obj, but got I
		//IL_4226: Unknown result type (might be due to invalid IL or missing references)
		//IL_422b: Expected Obj, but got Unknown
		//IL_4242: Expected I, but got Obj
		//IL_4258: Expected Obj, but got I
		//IL_556a: Expected Obj, but got I4
		//IL_5588: Expected native int or pointer, but got VT
		//IL_559d: Expected native int or pointer, but got VT
		//IL_55b7: Expected Obj, but got I
		//IL_55b2: Expected native int or pointer, but got VT
		//IL_55d2: Expected I, but got Obj
		//IL_55e8: Expected Obj, but got I
		//IL_2281: Expected I, but got Obj
		//IL_228f: Expected I, but got Obj
		//IL_21f6: Expected I, but got Obj
		//IL_22d0: Expected I, but got Obj
		//IL_22e6: Expected Obj, but got I
		//IL_560e: Expected Obj, but got I4
		//IL_562c: Expected native int or pointer, but got VT
		//IL_5641: Expected native int or pointer, but got VT
		//IL_565b: Expected Obj, but got I
		//IL_5656: Expected native int or pointer, but got VT
		//IL_5676: Expected I, but got Obj
		//IL_568c: Expected Obj, but got I
		//IL_2344: Expected I, but got Obj
		//IL_42d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_42d9: Expected Obj, but got Unknown
		//IL_42f0: Expected I, but got Obj
		//IL_4306: Expected Obj, but got I
		//IL_22bd: Expected I, but got Obj
		//IL_2377: Expected I, but got Obj
		//IL_238d: Expected Obj, but got I
		//IL_2311: Expected I, but got Obj
		//IL_56b2: Expected Obj, but got I4
		//IL_56d0: Expected native int or pointer, but got VT
		//IL_56e5: Expected native int or pointer, but got VT
		//IL_56ff: Expected Obj, but got I
		//IL_56fa: Expected native int or pointer, but got VT
		//IL_23eb: Expected I, but got Obj
		//IL_436e: Unknown result type (might be due to invalid IL or missing references)
		//IL_4373: Expected Obj, but got Unknown
		//IL_438a: Expected I, but got Obj
		//IL_43a0: Expected Obj, but got I
		//IL_249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a0: Expected Obj, but got Unknown
		//IL_24a9: Expected Obj, but got I4
		//IL_24b7: Expected I, but got Obj
		//IL_24cd: Expected Obj, but got I
		//IL_241e: Expected I, but got Obj
		//IL_2434: Expected Obj, but got I
		//IL_23b8: Expected I, but got Obj
		//IL_4408: Unknown result type (might be due to invalid IL or missing references)
		//IL_440d: Expected Obj, but got Unknown
		//IL_4424: Expected I, but got Obj
		//IL_443a: Expected Obj, but got I
		//IL_5724: Expected Obj, but got I4
		//IL_5742: Expected native int or pointer, but got VT
		//IL_5757: Expected native int or pointer, but got VT
		//IL_5771: Expected Obj, but got I
		//IL_576c: Expected native int or pointer, but got VT
		//IL_578c: Expected I, but got Obj
		//IL_57a2: Expected Obj, but got I
		//IL_24f8: Expected I, but got Obj
		//IL_245f: Expected I, but got Obj
		//IL_252b: Expected I, but got Obj
		//IL_2541: Expected Obj, but got I
		//IL_57e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_57e5: Expected Obj, but got Unknown
		//IL_57ee: Expected Obj, but got I4
		//IL_57f7: Expected Obj, but got I4
		//IL_5815: Expected native int or pointer, but got VT
		//IL_582a: Expected native int or pointer, but got VT
		//IL_5844: Expected Obj, but got I
		//IL_583f: Expected native int or pointer, but got VT
		//IL_259f: Expected I, but got Obj
		//IL_44a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_44a7: Expected Obj, but got Unknown
		//IL_44be: Expected I, but got Obj
		//IL_44d4: Expected Obj, but got I
		//IL_25d2: Expected I, but got Obj
		//IL_25e8: Expected Obj, but got I
		//IL_256c: Expected I, but got Obj
		//IL_453c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4541: Expected Obj, but got Unknown
		//IL_4558: Expected I, but got Obj
		//IL_456e: Expected Obj, but got I
		//IL_27c0: Expected I, but got Obj
		//IL_27d6: Expected Obj, but got I
		//IL_267c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2681: Expected Obj, but got Unknown
		//IL_268f: Expected Obj, but got I4
		//IL_2613: Expected I, but got Obj
		//IL_273b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2740: Expected Obj, but got Unknown
		//IL_274e: Expected Obj, but got I4
		//IL_26b2: Expected native int or pointer, but got VT
		//IL_26c7: Expected native int or pointer, but got VT
		//IL_26e1: Expected Obj, but got I
		//IL_26dc: Expected native int or pointer, but got VT
		//IL_28cc: Expected I, but got Obj
		//IL_28e2: Expected Obj, but got I
		//IL_2801: Expected I, but got Obj
		//IL_2771: Expected native int or pointer, but got VT
		//IL_2786: Expected native int or pointer, but got VT
		//IL_27a0: Expected Obj, but got I
		//IL_279b: Expected native int or pointer, but got VT
		//IL_2847: Unknown result type (might be due to invalid IL or missing references)
		//IL_284c: Expected Obj, but got Unknown
		//IL_285a: Expected Obj, but got I4
		//IL_585f: Expected Obj, but got I4
		//IL_587d: Expected native int or pointer, but got VT
		//IL_5892: Expected native int or pointer, but got VT
		//IL_58ac: Expected Obj, but got I
		//IL_58a7: Expected native int or pointer, but got VT
		//IL_58c7: Expected I, but got Obj
		//IL_58dd: Expected Obj, but got I
		//IL_290d: Expected I, but got Obj
		//IL_287d: Expected native int or pointer, but got VT
		//IL_2892: Expected native int or pointer, but got VT
		//IL_28ac: Expected Obj, but got I
		//IL_28a7: Expected native int or pointer, but got VT
		//IL_2940: Expected I, but got Obj
		//IL_2956: Expected Obj, but got I
		//IL_5908: Expected I, but got Obj
		//IL_591e: Expected Obj, but got I
		//IL_29b4: Expected I, but got Obj
		//IL_45ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_45f3: Expected Obj, but got Unknown
		//IL_460a: Expected I, but got Obj
		//IL_4620: Expected Obj, but got I
		//IL_29e7: Expected I, but got Obj
		//IL_29fd: Expected Obj, but got I
		//IL_2981: Expected I, but got Obj
		//IL_5944: Expected Obj, but got I4
		//IL_5962: Expected native int or pointer, but got VT
		//IL_5977: Expected native int or pointer, but got VT
		//IL_5991: Expected Obj, but got I
		//IL_598c: Expected native int or pointer, but got VT
		//IL_2a5b: Expected I, but got Obj
		//IL_4688: Unknown result type (might be due to invalid IL or missing references)
		//IL_468d: Expected Obj, but got Unknown
		//IL_46a4: Expected I, but got Obj
		//IL_46ba: Expected Obj, but got I
		//IL_2b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b10: Expected Obj, but got Unknown
		//IL_2b23: Expected I, but got Obj
		//IL_2b39: Expected Obj, but got I
		//IL_2a8e: Expected I, but got Obj
		//IL_2aa4: Expected Obj, but got I
		//IL_2a28: Expected I, but got Obj
		//IL_4722: Unknown result type (might be due to invalid IL or missing references)
		//IL_4727: Expected Obj, but got Unknown
		//IL_473e: Expected I, but got Obj
		//IL_4754: Expected Obj, but got I
		//IL_59b6: Expected Obj, but got I4
		//IL_59d4: Expected native int or pointer, but got VT
		//IL_59e9: Expected native int or pointer, but got VT
		//IL_5a03: Expected Obj, but got I
		//IL_59fe: Expected native int or pointer, but got VT
		//IL_2b64: Expected I, but got Obj
		//IL_2acf: Expected I, but got Obj
		//IL_2c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c19: Expected Obj, but got Unknown
		//IL_2c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c44: Expected Obj, but got Unknown
		//IL_2c52: Expected Obj, but got I4
		//IL_2b97: Expected I, but got Obj
		//IL_2bad: Expected Obj, but got I
		//IL_2c75: Expected native int or pointer, but got VT
		//IL_2c8a: Expected native int or pointer, but got VT
		//IL_2ca4: Expected Obj, but got I
		//IL_2c9f: Expected native int or pointer, but got VT
		//IL_47bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_47c1: Expected Obj, but got Unknown
		//IL_47d8: Expected I, but got Obj
		//IL_47ee: Expected Obj, but got I
		//IL_2bd8: Expected I, but got Obj
		//IL_2d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d11: Expected Obj, but got Unknown
		//IL_2d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d41: Expected Obj, but got Unknown
		//IL_2d4f: Expected Obj, but got I4
		//IL_2d6d: Expected native int or pointer, but got VT
		//IL_2d82: Expected native int or pointer, but got VT
		//IL_2d9c: Expected Obj, but got I
		//IL_2d97: Expected native int or pointer, but got VT
		//IL_2ea2: Expected I, but got Obj
		//IL_2eb8: Expected Obj, but got I
		//IL_2df2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2df7: Expected Obj, but got Unknown
		//IL_314c: Expected I, but got Obj
		//IL_3162: Expected Obj, but got I
		//IL_2ee3: Expected I, but got Obj
		//IL_2e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e27: Expected Obj, but got Unknown
		//IL_2e35: Expected Obj, but got I4
		//IL_2e53: Expected native int or pointer, but got VT
		//IL_2e68: Expected native int or pointer, but got VT
		//IL_2e82: Expected Obj, but got I
		//IL_2e7d: Expected native int or pointer, but got VT
		//IL_2f16: Expected I, but got Obj
		//IL_2f2c: Expected Obj, but got I
		//IL_5b75: Expected Obj, but got I4
		//IL_5b93: Expected native int or pointer, but got VT
		//IL_5ba8: Expected native int or pointer, but got VT
		//IL_5bc2: Expected Obj, but got I
		//IL_5bbd: Expected native int or pointer, but got VT
		//IL_5bdd: Expected I, but got Obj
		//IL_5bf3: Expected Obj, but got I
		//IL_318d: Expected I, but got Obj
		//IL_31c0: Expected I, but got Obj
		//IL_31d6: Expected Obj, but got I
		//IL_5a2d: Expected I, but got Obj
		//IL_5a43: Expected Obj, but got I
		//IL_2f57: Expected I, but got Obj
		//IL_5c19: Expected Obj, but got I4
		//IL_5c37: Expected native int or pointer, but got VT
		//IL_5c4c: Expected native int or pointer, but got VT
		//IL_5c66: Expected Obj, but got I
		//IL_5c61: Expected native int or pointer, but got VT
		//IL_3234: Expected I, but got Obj
		//IL_4a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4a50: Expected Obj, but got Unknown
		//IL_4a67: Expected I, but got Obj
		//IL_4a7d: Expected Obj, but got I
		//IL_2f8a: Expected I, but got Obj
		//IL_2fa0: Expected Obj, but got I
		//IL_32e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e9: Expected Obj, but got Unknown
		//IL_32f7: Expected Obj, but got I4
		//IL_3315: Expected native int or pointer, but got VT
		//IL_332a: Expected native int or pointer, but got VT
		//IL_3344: Expected Obj, but got I
		//IL_333f: Expected native int or pointer, but got VT
		//IL_3267: Expected I, but got Obj
		//IL_327d: Expected Obj, but got I
		//IL_3201: Expected I, but got Obj
		//IL_5a69: Expected Obj, but got I4
		//IL_5a87: Expected native int or pointer, but got VT
		//IL_5a9c: Expected native int or pointer, but got VT
		//IL_5ab6: Expected Obj, but got I
		//IL_5ab1: Expected native int or pointer, but got VT
		//IL_5ad1: Expected I, but got Obj
		//IL_5ae7: Expected Obj, but got I
		//IL_2ffe: Expected I, but got Obj
		//IL_487d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4882: Expected Obj, but got Unknown
		//IL_4899: Expected I, but got Obj
		//IL_48af: Expected Obj, but got I
		//IL_3377: Unknown result type (might be due to invalid IL or missing references)
		//IL_337c: Expected Obj, but got Unknown
		//IL_338a: Expected Obj, but got I4
		//IL_4ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_4aea: Expected Obj, but got Unknown
		//IL_4b01: Expected I, but got Obj
		//IL_4b17: Expected Obj, but got I
		//IL_3031: Expected I, but got Obj
		//IL_3047: Expected Obj, but got I
		//IL_2fcb: Expected I, but got Obj
		//IL_33ad: Expected native int or pointer, but got VT
		//IL_33c2: Expected native int or pointer, but got VT
		//IL_33dc: Expected Obj, but got I
		//IL_33d7: Expected native int or pointer, but got VT
		//IL_33f7: Expected I, but got Obj
		//IL_340d: Expected Obj, but got I
		//IL_32a8: Expected I, but got Obj
		//IL_5b0d: Expected Obj, but got I4
		//IL_5b2b: Expected native int or pointer, but got VT
		//IL_5b40: Expected native int or pointer, but got VT
		//IL_5b5a: Expected Obj, but got I
		//IL_5b55: Expected native int or pointer, but got VT
		//IL_30a5: Expected I, but got Obj
		//IL_4917: Unknown result type (might be due to invalid IL or missing references)
		//IL_491c: Expected Obj, but got Unknown
		//IL_4933: Expected I, but got Obj
		//IL_4949: Expected Obj, but got I
		//IL_30d8: Expected I, but got Obj
		//IL_30ee: Expected Obj, but got I
		//IL_3072: Expected I, but got Obj
		//IL_3750: Expected Obj, but got I
		//IL_3760: Expected Obj, but got I
		//IL_3770: Expected Obj, but got I
		//IL_3779: Unknown result type (might be due to invalid IL or missing references)
		//IL_377e: Expected Obj, but got Unknown
		//IL_3787: Unknown result type (might be due to invalid IL or missing references)
		//IL_378c: Expected Obj, but got Unknown
		//IL_3438: Expected I, but got Obj
		//IL_49b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_49b6: Expected Obj, but got Unknown
		//IL_49cd: Expected I, but got Obj
		//IL_49e3: Expected Obj, but got I
		//IL_346b: Expected I, but got Obj
		//IL_3481: Expected Obj, but got I
		//IL_3119: Expected I, but got Obj
		//IL_5c8b: Expected Obj, but got I4
		//IL_5ca9: Expected native int or pointer, but got VT
		//IL_5cbe: Expected native int or pointer, but got VT
		//IL_5cd8: Expected Obj, but got I
		//IL_5cd3: Expected native int or pointer, but got VT
		//IL_5cf3: Expected I, but got Obj
		//IL_5d09: Expected Obj, but got I
		//IL_34ac: Expected I, but got Obj
		//IL_34df: Expected I, but got Obj
		//IL_34f5: Expected Obj, but got I
		//IL_5d2f: Expected Obj, but got I4
		//IL_5d4d: Expected native int or pointer, but got VT
		//IL_5d62: Expected native int or pointer, but got VT
		//IL_5d7c: Expected Obj, but got I
		//IL_5d77: Expected native int or pointer, but got VT
		//IL_5d97: Expected I, but got Obj
		//IL_5dad: Expected Obj, but got I
		//IL_3553: Expected I, but got Obj
		//IL_4b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_4b9c: Expected Obj, but got Unknown
		//IL_4bb3: Expected I, but got Obj
		//IL_4bc9: Expected Obj, but got I
		//IL_3586: Expected I, but got Obj
		//IL_359c: Expected Obj, but got I
		//IL_3520: Expected I, but got Obj
		//IL_5dd3: Expected Obj, but got I4
		//IL_5df1: Expected native int or pointer, but got VT
		//IL_5e06: Expected native int or pointer, but got VT
		//IL_5e20: Expected Obj, but got I
		//IL_5e1b: Expected native int or pointer, but got VT
		//IL_5e3b: Expected I, but got Obj
		//IL_5e51: Expected Obj, but got I
		//IL_35fa: Expected I, but got Obj
		//IL_4c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c36: Expected Obj, but got Unknown
		//IL_4c4d: Expected I, but got Obj
		//IL_4c63: Expected Obj, but got I
		//IL_362d: Expected I, but got Obj
		//IL_3643: Expected Obj, but got I
		//IL_35c7: Expected I, but got Obj
		//IL_5e77: Expected Obj, but got I4
		//IL_5e95: Expected native int or pointer, but got VT
		//IL_5eaa: Expected native int or pointer, but got VT
		//IL_5ec4: Expected Obj, but got I
		//IL_5ebf: Expected native int or pointer, but got VT
		//IL_36a1: Expected I, but got Obj
		//IL_4ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_4cd0: Expected Obj, but got Unknown
		//IL_4ce7: Expected I, but got Obj
		//IL_4cfd: Expected Obj, but got I
		//IL_36d4: Expected I, but got Obj
		//IL_36ea: Expected Obj, but got I
		//IL_366e: Expected I, but got Obj
		//IL_4d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d6a: Expected Obj, but got Unknown
		//IL_4d81: Expected I, but got Obj
		//IL_4d97: Expected Obj, but got I
		//IL_3715: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 192;
		object obj3 = obj2 + 160;
		obj3 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v3+60]");
		object obj5 = 0;
		object obj6 = obj5;
		object obj7 = obj6 & 0x1FFF;
		object obj8 = obj7 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v48 @ S4_v4 (should have been resolved before IL gen)");
		object obj9 = this + 124;
		object obj10 = default;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PageContent> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj12 = default;
		object obj11 = obj12 + 16;
		obj11 = this;
		object obj13 = obj2 + 140;
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		PageContent pageContent = (PageContent)(obj2 + 168);
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		object obj15 = default;
		object obj14 = obj15 + 16;
		obj14 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		object obj17 = default;
		object obj16 = obj17 + 16;
		obj16 = this;
		object obj18 = obj2 + 120;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v73 (Il2CppClass<Globals>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v2739 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj20 = obj2 + 100;
		obj20 = Globals.BUILD_PURPOSE;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		object obj22 = default;
		object obj21 = obj22 + 16;
		object obj23 = default;
		obj21 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		object obj25 = default;
		object obj24 = obj25 + 16;
		obj24 = this;
		object obj26 = obj2 + 80;
		obj26 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		object obj28 = default;
		object obj27 = obj28 + 16;
		obj27 = this;
		object obj29 = obj2 + 60;
		obj29 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj29);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v123+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v123+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num9 = 0;
		_ = 0;
		object obj31 = default;
		object obj30 = obj31 + 16;
		obj30 = this;
		object obj32 = obj2 + 40;
		obj32 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v143+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v143+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		nint num10 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v154 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S0_v2733 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__32_0 == null;
		bool flag2 = !flag;
		Func<string> func = _003C_003Ec._003C_003E9__32_0;
		if (!flag2)
		{
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v2707 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num13 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v2727 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num14 = 0;
			_ = 0;
			Func<string> func2 = default;
			object obj35 = func2 + 16;
			obj35 = _003C_003Ec._003C_003E9;
			nint num15 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v2724 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj36 = (nint)0 + (nint)4;
			obj36 = func2;
			func = func2;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num16 = 0;
		_ = 0;
		object obj38 = default;
		object obj37 = obj38 + 16;
		obj37 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		nint num17 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v195 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num18 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ S0_v2700 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__32_1 == null;
		bool flag4 = !flag3;
		Func<string> func3 = _003C_003Ec._003C_003E9__32_1;
		if (!flag4)
		{
			nint num19 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v568 @ S0_v2674 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num20 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v602 @ S0_v2694 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num21 = 0;
			_ = 0;
			Func<string> func4 = default;
			object obj41 = func4 + 16;
			obj41 = _003C_003Ec._003C_003E9;
			nint num22 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ S0_v2691 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj42 = (nint)0 + (nint)8;
			obj42 = func4;
			func3 = func4;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		nint num23 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v217 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		if (obj43 != null)
		{
			nint num24 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v2667 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = _003C_003Ec._003C_003E9__32_2 == null;
		bool flag6 = !flag5;
		Func<string> func5 = _003C_003Ec._003C_003E9__32_2;
		if (!flag6)
		{
			nint num25 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S0_v2641 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num26 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S0_v2661 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num27 = 0;
			_ = 0;
			Func<string> func6 = default;
			object obj45 = func6 + 16;
			obj45 = _003C_003Ec._003C_003E9;
			nint num28 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S0_v2658 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj46 = (nint)0 + (nint)12;
			obj46 = func6;
			func5 = func6;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num29 = 0;
		_ = 0;
		object obj48 = default;
		object obj47 = obj48 + 16;
		obj47 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num30 = 0;
		_ = 0;
		object obj50 = default;
		object obj49 = obj50 + 16;
		obj49 = this;
		obj20 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num31 = 0;
		_ = 0;
		object obj52 = default;
		object obj51 = obj52 + 16;
		obj51 = this;
		obj26 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list.Add(pageContent);
		nint num32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ S4_v20 (Il2CppMethodInfo)+C]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S4_v21+60]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ S4_v22+48]");
		object obj55 = 0;
		object obj56 = obj55 & 0x7FF;
		object obj57 = obj56 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v968 @ S5_v91 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PageContent> list2 = default;
		list2._002Ector();
		nint num33 = (nint)typeof(AdLocations);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v923 @ S0_v302 (Il2CppClass<AdLocations>)+BA]");
		object obj58 = (nint)0 & (nint)0x200;
		if (obj58 != null)
		{
			nint num34 = (nint)typeof(AdLocations);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v929 @ S0_v2634 (Il2CppClass<AdLocations>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj59 = obj2 + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj60 = default;
		nint num35 = default;
		object obj63 = default;
		object obj64 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj60 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ S0_v2583+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj61 = num35 + 12;
				obj61 = this;
				object obj62 = num35 + 8;
				obj62 = obj63;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				((Func<string>)5459)._002Ector(obj64, (IntPtr)num35);
				obj13 = 0;
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
				System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
				((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
				System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj57 = 0;
				obj55 = 0;
			}
		}
		object obj65 = obj3 + 4;
		object obj66 = obj65 + 1;
		obj65 = obj66;
		object obj67 = obj66 << 2;
		object obj68 = obj3 + obj67;
		obj68 = 618;
		object obj69 = default;
		if (obj69 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12+4]");
			object obj70 = (nint)0 << 2;
			object obj71 = obj3 + obj70;
			if ((nint)obj71 == 618)
			{
				object obj72 = obj3 + 4;
				if ((nint)obj72 > -1)
				{
					object obj73 = obj72 + -1;
					obj72 = obj73;
				}
				goto IL_4f51;
			}
		}
		object obj74 = default;
		if (obj74 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_4f51;
		IL_4f51:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num36 = 0;
		_ = 0;
		object obj76 = default;
		object obj75 = obj76 + 16;
		obj75 = this;
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num37 = 0;
		_ = 0;
		object obj78 = default;
		object obj77 = obj78 + 16;
		obj77 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num38 = 0;
		_ = 0;
		object obj80 = default;
		object obj79 = obj80 + 16;
		obj79 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num39 = 0;
		_ = 0;
		object obj82 = default;
		object obj81 = obj82 + 16;
		obj81 = this;
		obj20 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		nint num40 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1397 @ S0_v391 (Il2CppClass<Globals>)+BA]");
		object obj83 = (nint)0 & (nint)0x200;
		if (obj83 != null)
		{
			nint num41 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1403 @ S0_v2540 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num42 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1418 @ S0_v2486 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj84 = (nint)0 & (nint)0x200;
			if (obj84 != null)
			{
				nint num43 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1454 @ S0_v2534 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag7 = _003C_003Ec._003C_003E9__32_3 == null;
			bool flag8 = !flag7;
			Func<string> func7 = _003C_003Ec._003C_003E9__32_3;
			if (!flag8)
			{
				nint num44 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1491 @ S0_v2508 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj85 = (nint)0 & (nint)0x200;
				if (obj85 != null)
				{
					nint num45 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ S0_v2528 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num46 = 0;
				_ = 0;
				Func<string> func8 = default;
				object obj86 = func8 + 16;
				obj86 = _003C_003Ec._003C_003E9;
				nint num47 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1601 @ S0_v2525 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj87 = (nint)0 + (nint)16;
				obj87 = func8;
				func7 = func8;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list2.Add(pageContent);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num48 = 0;
		_ = 0;
		object obj89 = default;
		object obj88 = obj89 + 16;
		obj88 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num49 = 0;
		_ = 0;
		object obj91 = default;
		object obj90 = obj91 + 16;
		obj90 = this;
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num50 = 0;
		_ = 0;
		object obj93 = default;
		object obj92 = obj93 + 16;
		obj92 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num51 = 0;
		_ = 0;
		object obj95 = default;
		object obj94 = obj95 + 16;
		obj94 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num52 = 0;
		_ = 0;
		object obj97 = default;
		object obj96 = obj97 + 16;
		obj96 = this;
		obj20 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		nint num53 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1719 @ S0_v475 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj98 = (nint)0 & (nint)0x200;
		if (obj98 != null)
		{
			nint num54 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1725 @ S0_v2481 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string assetBundlesCachePath = AssetBundleManager.GetAssetBundlesCachePath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num55 = 0;
		_ = 0;
		object obj100 = default;
		object obj99 = obj100 + 16;
		obj99 = assetBundlesCachePath;
		obj26 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		string assetBundlesCachePath2 = AssetBundleManager.GetAssetBundlesCachePath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num56 = 0;
		_ = 0;
		object obj102 = default;
		object obj101 = obj102 + 16;
		obj101 = assetBundlesCachePath2;
		obj29 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj29);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v123+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v123+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num57 = 0;
		_ = 0;
		object obj104 = default;
		object obj103 = obj104 + 16;
		obj103 = this;
		obj32 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v143+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v143+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num58 = 0;
		_ = 0;
		object obj106 = default;
		object obj105 = obj106 + 16;
		obj105 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num59 = 0;
		_ = 0;
		object obj108 = default;
		object obj107 = obj108 + 16;
		obj107 = this;
		obj59 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj59);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v307+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v307+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list2.Add(pageContent);
		nint num60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1951 @ S4_v42 (Il2CppMethodInfo)+C]");
		object obj109 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1952 @ S4_v43+60]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1953 @ S4_v44+48]");
		object obj111 = 0;
		object obj112 = obj111 & 0x7FF;
		object obj113 = obj112 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v1961 @ S5_v35 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PageContent> list3 = default;
		list3._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num61 = 0;
		_ = 0;
		object obj115 = default;
		object obj114 = obj115 + 16;
		obj114 = this;
		obj2 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		IEnumerator enumerator = ((SecretPopup)null).ShowTextCopied();
		if (enumerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num62 = 0;
			_ = 0;
			object obj117 = default;
			object obj116 = obj117 + 16;
			obj116 = this;
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list3.Add(pageContent);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num63 = 0;
		_ = 0;
		object obj119 = default;
		object obj118 = obj119 + 16;
		obj118 = this;
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num64 = 0;
		_ = 0;
		object obj121 = default;
		object obj120 = obj121 + 16;
		obj120 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num65 = 0;
		_ = 0;
		object obj123 = default;
		object obj122 = obj123 + 16;
		obj122 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num66 = 0;
		_ = 0;
		object obj125 = default;
		object obj124 = obj125 + 16;
		obj124 = this;
		obj20 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num67 = 0;
		_ = 0;
		object obj127 = default;
		object obj126 = obj127 + 16;
		obj126 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num68 = 0;
		_ = 0;
		object obj129 = default;
		object obj128 = obj129 + 16;
		obj128 = this;
		obj26 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj26);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v103+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num69 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2304 @ S0_v691 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj130 = (nint)0 & (nint)0x200;
		if (obj130 != null)
		{
			nint num70 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2310 @ S0_v2456 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag9 = _003C_003Ec._003C_003E9__32_4 == null;
		bool flag10 = !flag9;
		Func<string> func9 = _003C_003Ec._003C_003E9__32_4;
		if (!flag10)
		{
			nint num71 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2330 @ S0_v2431 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj131 = (nint)0 & (nint)0x200;
			if (obj131 != null)
			{
				nint num72 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2357 @ S0_v2451 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num73 = 0;
			_ = 0;
			Func<string> func10 = default;
			object obj132 = func10 + 16;
			obj132 = _003C_003Ec._003C_003E9;
			nint num74 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2401 @ S0_v2448 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj133 = (nint)0 + (nint)20;
			obj133 = func10;
			func9 = func10;
		}
		nint num75 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2350 @ S0_v703 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj134 = (nint)0 & (nint)0x200;
		if (obj134 != null)
		{
			nint num76 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2369 @ S0_v2424 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag11 = _003C_003Ec._003C_003E9__32_5 == null;
		bool flag12 = !flag11;
		Func<string> func11 = _003C_003Ec._003C_003E9__32_5;
		if (!flag12)
		{
			nint num77 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2406 @ S0_v2399 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj135 = (nint)0 & (nint)0x200;
			if (obj135 != null)
			{
				nint num78 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2440 @ S0_v2419 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num79 = 0;
			_ = 0;
			Func<string> func12 = default;
			object obj136 = func12 + 16;
			obj136 = _003C_003Ec._003C_003E9;
			nint num80 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2481 @ S0_v2416 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj137 = (nint)0 + (nint)24;
			obj137 = func12;
			func11 = func12;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num81 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2485 @ S0_v725 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj138 = (nint)0 & (nint)0x200;
		if (obj138 != null)
		{
			nint num82 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2492 @ S0_v2393 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag13 = _003C_003Ec._003C_003E9__32_6 == null;
		bool flag14 = !flag13;
		Func<string> func13 = _003C_003Ec._003C_003E9__32_6;
		if (!flag14)
		{
			nint num83 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2509 @ S0_v2368 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj139 = (nint)0 & (nint)0x200;
			if (obj139 != null)
			{
				nint num84 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2536 @ S0_v2388 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num85 = 0;
			_ = 0;
			Func<string> func14 = default;
			object obj140 = func14 + 16;
			obj140 = _003C_003Ec._003C_003E9;
			nint num86 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2577 @ S0_v2385 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj141 = (nint)0 + (nint)28;
			obj141 = func14;
			func13 = func14;
		}
		nint num87 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2529 @ S0_v737 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj142 = (nint)0 & (nint)0x200;
		if (obj142 != null)
		{
			nint num88 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2548 @ S0_v2362 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag15 = _003C_003Ec._003C_003E9__32_7 == null;
		bool flag16 = !flag15;
		Func<string> func15 = _003C_003Ec._003C_003E9__32_7;
		if (!flag16)
		{
			nint num89 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2582 @ S0_v2337 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj143 = (nint)0 & (nint)0x200;
			if (obj143 != null)
			{
				nint num90 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2616 @ S0_v2357 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num91 = 0;
			_ = 0;
			Func<string> func16 = default;
			object obj144 = func16 + 16;
			obj144 = _003C_003Ec._003C_003E9;
			nint num92 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2657 @ S0_v2354 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj145 = (nint)0 + (nint)32;
			obj145 = func16;
			func15 = func16;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num93 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2661 @ S0_v759 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj146 = (nint)0 & (nint)0x200;
		if (obj146 != null)
		{
			nint num94 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2668 @ S0_v2331 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag17 = _003C_003Ec._003C_003E9__32_8 == null;
		bool flag18 = !flag17;
		Func<string> func17 = _003C_003Ec._003C_003E9__32_8;
		if (!flag18)
		{
			nint num95 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2685 @ S0_v2306 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj147 = (nint)0 & (nint)0x200;
			if (obj147 != null)
			{
				nint num96 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2712 @ S0_v2326 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num97 = 0;
			_ = 0;
			Func<string> func18 = default;
			object obj148 = func18 + 16;
			obj148 = _003C_003Ec._003C_003E9;
			nint num98 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2753 @ S0_v2323 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj149 = (nint)0 + (nint)36;
			obj149 = func18;
			func17 = func18;
		}
		nint num99 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2705 @ S0_v771 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj150 = (nint)0 & (nint)0x200;
		if (obj150 != null)
		{
			nint num100 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2724 @ S0_v2300 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag19 = _003C_003Ec._003C_003E9__32_9 == null;
		bool flag20 = !flag19;
		Func<string> func19 = _003C_003Ec._003C_003E9__32_9;
		if (!flag20)
		{
			nint num101 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2758 @ S0_v2275 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj151 = (nint)0 & (nint)0x200;
			if (obj151 != null)
			{
				nint num102 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2792 @ S0_v2295 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num103 = 0;
			_ = 0;
			Func<string> func20 = default;
			object obj152 = func20 + 16;
			obj152 = _003C_003Ec._003C_003E9;
			nint num104 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2833 @ S0_v2292 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj153 = (nint)0 + (nint)40;
			obj153 = func20;
			func19 = func20;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num105 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2837 @ S0_v793 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj154 = (nint)0 & (nint)0x200;
		if (obj154 != null)
		{
			nint num106 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2844 @ S0_v2269 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag21 = _003C_003Ec._003C_003E9__32_10 == null;
		bool flag22 = !flag21;
		Func<string> func21 = _003C_003Ec._003C_003E9__32_10;
		if (!flag22)
		{
			nint num107 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2861 @ S0_v2244 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj155 = (nint)0 & (nint)0x200;
			if (obj155 != null)
			{
				nint num108 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2888 @ S0_v2264 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num109 = 0;
			_ = 0;
			Func<string> func22 = default;
			object obj156 = func22 + 16;
			obj156 = _003C_003Ec._003C_003E9;
			nint num110 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2929 @ S0_v2261 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj157 = (nint)0 + (nint)44;
			obj157 = func22;
			func21 = func22;
		}
		nint num111 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2881 @ S0_v805 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj158 = (nint)0 & (nint)0x200;
		if (obj158 != null)
		{
			nint num112 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2900 @ S0_v2238 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag23 = _003C_003Ec._003C_003E9__32_11 == null;
		bool flag24 = !flag23;
		Func<string> func23 = _003C_003Ec._003C_003E9__32_11;
		if (!flag24)
		{
			nint num113 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2934 @ S0_v2213 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj159 = (nint)0 & (nint)0x200;
			if (obj159 != null)
			{
				nint num114 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2968 @ S0_v2233 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num115 = 0;
			_ = 0;
			Func<string> func24 = default;
			object obj160 = func24 + 16;
			obj160 = _003C_003Ec._003C_003E9;
			nint num116 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3009 @ S0_v2230 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj161 = (nint)0 + (nint)48;
			obj161 = func24;
			func23 = func24;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num117 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3013 @ S0_v827 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj162 = (nint)0 & (nint)0x200;
		if (obj162 != null)
		{
			nint num118 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3020 @ S0_v2207 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag25 = _003C_003Ec._003C_003E9__32_12 == null;
		bool flag26 = !flag25;
		Func<string> func25 = _003C_003Ec._003C_003E9__32_12;
		if (!flag26)
		{
			nint num119 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3037 @ S0_v2182 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj163 = (nint)0 & (nint)0x200;
			if (obj163 != null)
			{
				nint num120 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3064 @ S0_v2202 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num121 = 0;
			_ = 0;
			Func<string> func26 = default;
			object obj164 = func26 + 16;
			obj164 = _003C_003Ec._003C_003E9;
			nint num122 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3105 @ S0_v2199 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj165 = (nint)0 + (nint)52;
			obj165 = func26;
			func25 = func26;
		}
		nint num123 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3057 @ S0_v839 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj166 = (nint)0 & (nint)0x200;
		if (obj166 != null)
		{
			nint num124 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3076 @ S0_v2176 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag27 = _003C_003Ec._003C_003E9__32_13 == null;
		bool flag28 = !flag27;
		Func<string> func27 = _003C_003Ec._003C_003E9__32_13;
		if (!flag28)
		{
			nint num125 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3110 @ S0_v2151 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj167 = (nint)0 & (nint)0x200;
			if (obj167 != null)
			{
				nint num126 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3144 @ S0_v2171 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num127 = 0;
			_ = 0;
			Func<string> func28 = default;
			object obj168 = func28 + 16;
			obj168 = _003C_003Ec._003C_003E9;
			nint num128 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3185 @ S0_v2168 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj169 = (nint)0 + (nint)56;
			obj169 = func28;
			func27 = func28;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num129 = 0;
		_ = 0;
		object obj171 = default;
		object obj170 = obj171 + 16;
		obj170 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num130 = 0;
		_ = 0;
		object obj173 = default;
		object obj172 = obj173 + 16;
		obj172 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num131 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3256 @ S0_v889 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj174 = (nint)0 & (nint)0x200;
		if (obj174 != null)
		{
			nint num132 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3262 @ S0_v2145 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag29 = _003C_003Ec._003C_003E9__32_14 == null;
		bool flag30 = !flag29;
		Func<string> func29 = _003C_003Ec._003C_003E9__32_14;
		if (!flag30)
		{
			nint num133 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3279 @ S0_v2120 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj175 = (nint)0 & (nint)0x200;
			if (obj175 != null)
			{
				nint num134 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3312 @ S0_v2140 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num135 = 0;
			_ = 0;
			Func<string> func30 = default;
			object obj176 = func30 + 16;
			obj176 = _003C_003Ec._003C_003E9;
			nint num136 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3353 @ S0_v2137 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj177 = (nint)0 + (nint)60;
			obj177 = func30;
			func29 = func30;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list3.Add(pageContent);
		nint num137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3362 @ S4_v63 (Il2CppMethodInfo)+C]");
		object obj178 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3363 @ S4_v64+60]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3364 @ S4_v65+48]");
		object obj180 = 0;
		object obj181 = obj180 & 0x7FF;
		object obj182 = obj181 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v3372 @ S5_v52 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<PageContent> list4 = default;
		list4._002Ector();
		nint num138 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3382 @ S0_v917 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj183 = (nint)0 & (nint)0x200;
		bool flag31 = obj183 == null;
		nint num139 = (nint)typeof(_003C_003Ec);
		if (!flag31)
		{
			nint num140 = (nint)typeof(_003C_003Ec);
			num139 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3388 @ S0_v2114 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num139 = (nint)typeof(_003C_003Ec);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3390 @ L1_v131 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
		object obj184 = -(-64);
		bool flag32 = obj184 == null;
		bool flag33 = !flag32;
		object obj185 = obj184;
		if (!flag33)
		{
			nint num141 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3407 @ S0_v2089 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj186 = (nint)0 & (nint)0x200;
			if (obj186 != null)
			{
				nint num142 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3440 @ S0_v2109 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num143 = 0;
			_ = 0;
			object obj188 = default;
			object obj187 = obj188 + 16;
			obj187 = _003C_003Ec._003C_003E9;
			nint num144 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3481 @ S0_v2106 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj189 = -(-64);
			obj189 = obj188;
			obj185 = obj188;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		nint num145 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3485 @ S0_v940 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj190 = (nint)0 & (nint)0x200;
		if (obj190 != null)
		{
			nint num146 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3492 @ S0_v2083 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag34 = _003C_003Ec._003C_003E9__32_16 == null;
		bool flag35 = !flag34;
		Func<string> func31 = _003C_003Ec._003C_003E9__32_16;
		if (!flag35)
		{
			nint num147 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3509 @ S0_v2058 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj191 = (nint)0 & (nint)0x200;
			if (obj191 != null)
			{
				nint num148 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3542 @ S0_v2078 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num149 = 0;
			_ = 0;
			Func<string> func32 = default;
			object obj192 = func32 + 16;
			obj192 = _003C_003Ec._003C_003E9;
			nint num150 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3583 @ S0_v2075 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj193 = (nint)0 + (nint)68;
			obj193 = func32;
			func31 = func32;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		nint num151 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3587 @ S0_v962 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj194 = (nint)0 & (nint)0x200;
		if (obj194 != null)
		{
			nint num152 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3594 @ S0_v2052 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag36 = _003C_003Ec._003C_003E9__32_17 == null;
		bool flag37 = !flag36;
		Func<string> func33 = _003C_003Ec._003C_003E9__32_17;
		if (!flag37)
		{
			nint num153 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3611 @ S0_v2027 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj195 = (nint)0 & (nint)0x200;
			if (obj195 != null)
			{
				nint num154 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3644 @ S0_v2047 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num155 = 0;
			_ = 0;
			Func<string> func34 = default;
			object obj196 = func34 + 16;
			obj196 = _003C_003Ec._003C_003E9;
			nint num156 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3685 @ S0_v2044 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj197 = (nint)0 + (nint)72;
			obj197 = func34;
			func33 = func34;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num157 = 0;
		_ = 0;
		object obj199 = default;
		object obj198 = obj199 + 16;
		obj198 = 0;
		nint num158 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3708 @ S0_v993 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj200 = (nint)0 & (nint)0x200;
		if (obj200 != null)
		{
			nint num159 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3714 @ S0_v2021 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag38 = _003C_003Ec._003C_003E9__32_18 == null;
		bool flag39 = !flag38;
		Func<string> func35 = _003C_003Ec._003C_003E9__32_18;
		if (!flag39)
		{
			nint num160 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3734 @ S0_v1996 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj201 = (nint)0 & (nint)0x200;
			if (obj201 != null)
			{
				nint num161 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3767 @ S0_v2016 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num162 = 0;
			_ = 0;
			Func<string> func36 = default;
			object obj202 = func36 + 16;
			obj202 = _003C_003Ec._003C_003E9;
			nint num163 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3808 @ S0_v2013 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj203 = (nint)0 + (nint)76;
			obj203 = func36;
			func35 = func36;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		nint num164 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3812 @ S0_v1017 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj204 = (nint)0 & (nint)0x200;
		if (obj204 != null)
		{
			nint num165 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3819 @ S0_v1990 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag40 = _003C_003Ec._003C_003E9__32_19 == null;
		bool flag41 = !flag40;
		Func<string> func37 = _003C_003Ec._003C_003E9__32_19;
		if (!flag41)
		{
			nint num166 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3836 @ S0_v1965 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj205 = (nint)0 & (nint)0x200;
			if (obj205 != null)
			{
				nint num167 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3859 @ S0_v1985 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num168 = 0;
			_ = 0;
			Func<string> func38 = default;
			object obj206 = func38 + 16;
			obj206 = _003C_003Ec._003C_003E9;
			nint num169 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3914 @ S0_v1982 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj207 = (nint)0 + (nint)80;
			obj207 = func38;
			func37 = func38;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num170 = 0;
		_ = 0;
		object obj209 = default;
		object obj208 = obj209 + 16;
		obj208 = 0;
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		if (((SecretPopup)null).IsiOSDevice())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num171 = 0;
			_ = 0;
			object obj211 = default;
			object obj210 = obj211 + 16;
			obj210 = this;
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		IEnumerator enumerator2 = ((SecretPopup)null).ShowTextCopied();
		if (enumerator2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num172 = 0;
			_ = 0;
			object obj213 = default;
			object obj212 = obj213 + 16;
			obj212 = this;
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		nint num173 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4022 @ S0_v1054 (Il2CppClass<Globals>)+BA]");
		object obj214 = (nint)0 & (nint)0x200;
		if (obj214 != null)
		{
			nint num174 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4051 @ S0_v1921 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num175 = 0;
			_ = 0;
			object obj216 = default;
			object obj215 = obj216 + 16;
			obj215 = this;
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		nint num176 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4097 @ S0_v1063 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj217 = (nint)0 & (nint)0x200;
		if (obj217 != null)
		{
			nint num177 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4127 @ S0_v1897 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag42 = _003C_003Ec._003C_003E9__32_20 == null;
		bool flag43 = !flag42;
		Func<string> func39 = _003C_003Ec._003C_003E9__32_20;
		if (!flag43)
		{
			nint num178 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4155 @ S0_v1872 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj218 = (nint)0 & (nint)0x200;
			if (obj218 != null)
			{
				nint num179 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4188 @ S0_v1892 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num180 = 0;
			_ = 0;
			Func<string> func40 = default;
			object obj219 = func40 + 16;
			obj219 = _003C_003Ec._003C_003E9;
			nint num181 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4229 @ S0_v1889 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj220 = (nint)0 + (nint)84;
			obj220 = func40;
			func39 = func40;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		nint num182 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4233 @ S0_v1085 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj221 = (nint)0 & (nint)0x200;
		if (obj221 != null)
		{
			nint num183 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4240 @ S0_v1866 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag44 = _003C_003Ec._003C_003E9__32_21 == null;
		bool flag45 = !flag44;
		Func<string> func41 = _003C_003Ec._003C_003E9__32_21;
		if (!flag45)
		{
			nint num184 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4257 @ S0_v1841 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj222 = (nint)0 & (nint)0x200;
			if (obj222 != null)
			{
				nint num185 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4284 @ S0_v1861 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num186 = 0;
			_ = 0;
			Func<string> func42 = default;
			object obj223 = func42 + 16;
			obj223 = _003C_003Ec._003C_003E9;
			nint num187 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4325 @ S0_v1858 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj224 = (nint)0 + (nint)88;
			obj224 = func42;
			func41 = func42;
		}
		nint num188 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4277 @ S0_v1097 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj225 = (nint)0 & (nint)0x200;
		if (obj225 != null)
		{
			nint num189 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4296 @ S0_v1835 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag46 = _003C_003Ec._003C_003E9__32_22 == null;
		bool flag47 = !flag46;
		Func<string> func43 = _003C_003Ec._003C_003E9__32_22;
		if (!flag47)
		{
			nint num190 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4330 @ S0_v1810 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj226 = (nint)0 & (nint)0x200;
			if (obj226 != null)
			{
				nint num191 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4364 @ S0_v1830 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num192 = 0;
			_ = 0;
			Func<string> func44 = default;
			object obj227 = func44 + 16;
			obj227 = _003C_003Ec._003C_003E9;
			nint num193 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4405 @ S0_v1827 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj228 = (nint)0 + (nint)92;
			obj228 = func44;
			func43 = func44;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num194 = 0;
		_ = 0;
		object obj230 = default;
		object obj229 = obj230 + 16;
		obj229 = this;
		nint num195 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4428 @ S0_v1128 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj231 = (nint)0 & (nint)0x200;
		if (obj231 != null)
		{
			nint num196 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4434 @ S0_v1804 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag48 = _003C_003Ec._003C_003E9__32_23 == null;
		bool flag49 = !flag48;
		Func<string> func45 = _003C_003Ec._003C_003E9__32_23;
		if (!flag49)
		{
			nint num197 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4454 @ S0_v1779 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj232 = (nint)0 & (nint)0x200;
			if (obj232 != null)
			{
				nint num198 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4487 @ S0_v1799 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num199 = 0;
			_ = 0;
			Func<string> func46 = default;
			object obj233 = func46 + 16;
			obj233 = _003C_003Ec._003C_003E9;
			nint num200 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4528 @ S0_v1796 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj234 = (nint)0 + (nint)96;
			obj234 = func46;
			func45 = func46;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num201 = 0;
		_ = 0;
		object obj236 = default;
		object obj235 = obj236 + 16;
		obj235 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num202 = 0;
		_ = 0;
		object obj238 = default;
		object obj237 = obj238 + 16;
		obj237 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		IEnumerator enumerator3 = ((SecretPopup)null).ShowTextCopied();
		if (enumerator3 != null || ((SecretPopup)null).IsiOSDevice())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num203 = 0;
			_ = 0;
			object obj240 = default;
			object obj239 = obj240 + 16;
			obj239 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num204 = 0;
			_ = 0;
			object obj242 = default;
			object obj241 = obj242 + 16;
			obj241 = this;
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		if (((SecretPopup)null).IsiOSDevice())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num205 = 0;
			_ = 0;
			object obj244 = default;
			object obj243 = obj244 + 16;
			obj243 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num206 = 0;
			_ = 0;
			object obj246 = default;
			object obj245 = obj246 + 16;
			obj245 = this;
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		nint num207 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4713 @ S0_v1186 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj247 = (nint)0 & (nint)0x200;
		if (obj247 != null)
		{
			nint num208 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4737 @ S0_v1716 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7BED");
		object obj248 = default;
		if (obj248 != null)
		{
			nint num209 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4779 @ S0_v1568 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj249 = (nint)0 & (nint)0x200;
			if (obj249 != null)
			{
				nint num210 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4822 @ S0_v1711 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag50 = _003C_003Ec._003C_003E9__32_24 == null;
			bool flag51 = !flag50;
			Func<string> func47 = _003C_003Ec._003C_003E9__32_24;
			if (!flag51)
			{
				nint num211 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4854 @ S0_v1686 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj250 = (nint)0 & (nint)0x200;
				if (obj250 != null)
				{
					nint num212 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4915 @ S0_v1706 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num213 = 0;
				_ = 0;
				Func<string> func48 = default;
				object obj251 = func48 + 16;
				obj251 = _003C_003Ec._003C_003E9;
				nint num214 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4984 @ S0_v1703 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj252 = (nint)0 + (nint)100;
				obj252 = func48;
				func47 = func48;
			}
			nint num215 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4874 @ S0_v1580 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj253 = (nint)0 & (nint)0x200;
			if (obj253 != null)
			{
				nint num216 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4927 @ S0_v1680 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag52 = _003C_003Ec._003C_003E9__32_25 == null;
			bool flag53 = !flag52;
			Func<string> func49 = _003C_003Ec._003C_003E9__32_25;
			if (!flag53)
			{
				nint num217 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4989 @ S0_v1655 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj254 = (nint)0 & (nint)0x200;
				if (obj254 != null)
				{
					nint num218 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5045 @ S0_v1675 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num219 = 0;
				_ = 0;
				Func<string> func50 = default;
				object obj255 = func50 + 16;
				obj255 = _003C_003Ec._003C_003E9;
				nint num220 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5102 @ S0_v1672 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj256 = (nint)0 + (nint)104;
				obj256 = func50;
				func49 = func50;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
			nint num221 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5106 @ S0_v1602 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj257 = (nint)0 & (nint)0x200;
			if (obj257 != null)
			{
				nint num222 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5147 @ S0_v1649 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag54 = _003C_003Ec._003C_003E9__32_26 == null;
			bool flag55 = !flag54;
			Func<string> func51 = _003C_003Ec._003C_003E9__32_26;
			if (!flag55)
			{
				nint num223 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5191 @ S0_v1624 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj258 = (nint)0 & (nint)0x200;
				if (obj258 != null)
				{
					nint num224 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5236 @ S0_v1644 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num225 = 0;
				_ = 0;
				Func<string> func52 = default;
				object obj259 = func52 + 16;
				obj259 = _003C_003Ec._003C_003E9;
				nint num226 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5303 @ S0_v1641 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj260 = (nint)0 + (nint)108;
				obj260 = func52;
				func51 = func52;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		nint num227 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4816 @ S0_v1194 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj261 = (nint)0 & (nint)0x200;
		if (obj261 != null)
		{
			nint num228 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4837 @ S0_v1562 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag56 = _003C_003Ec._003C_003E9__32_27 == null;
		bool flag57 = !flag56;
		Func<string> func53 = _003C_003Ec._003C_003E9__32_27;
		if (!flag57)
		{
			nint num229 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4882 @ S0_v1537 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj262 = (nint)0 & (nint)0x200;
			if (obj262 != null)
			{
				nint num230 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4943 @ S0_v1557 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num231 = 0;
			_ = 0;
			Func<string> func54 = default;
			object obj263 = func54 + 16;
			obj263 = _003C_003Ec._003C_003E9;
			nint num232 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5033 @ S0_v1554 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj264 = (nint)0 + (nint)112;
			obj264 = func54;
			func53 = func54;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		nint num233 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5037 @ S0_v1216 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
		object obj265 = (nint)0 & (nint)0x200;
		if (obj265 != null)
		{
			nint num234 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5073 @ S0_v1531 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag58 = _003C_003Ec._003C_003E9__32_28 == null;
		bool flag59 = !flag58;
		Func<string> func55 = _003C_003Ec._003C_003E9__32_28;
		if (!flag59)
		{
			nint num235 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5114 @ S0_v1506 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj266 = (nint)0 & (nint)0x200;
			if (obj266 != null)
			{
				nint num236 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5162 @ S0_v1526 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num237 = 0;
			_ = 0;
			Func<string> func56 = default;
			object obj267 = func56 + 16;
			obj267 = _003C_003Ec._003C_003E9;
			nint num238 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5229 @ S0_v1523 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
			object obj268 = (nint)0 + (nint)116;
			obj268 = func56;
			func55 = func56;
		}
		obj13 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num239 = 0;
		_ = 0;
		object obj270 = default;
		object obj269 = obj270 + 16;
		obj269 = this;
		obj18 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v62+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num240 = 0;
		_ = 0;
		object obj272 = default;
		object obj271 = obj272 + 16;
		obj271 = this;
		obj20 = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj20);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+8]");
		((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v78+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
		list4.Add(pageContent);
		nint num241 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5370 @ S0_v1276 (Il2CppClass<Globals>)+BA]");
		object obj273 = (nint)0 & (nint)0x200;
		if (obj273 != null)
		{
			nint num242 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5376 @ S0_v1500 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_SHOW_PERFORMANCE_INFO ? 1u : 0u) == 0)
		{
			nint num243 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5388 @ S0_v1289 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj274 = (nint)0 & (nint)0x200;
			if (obj274 != null)
			{
				nint num244 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5441 @ S0_v1495 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag60 = _003C_003Ec._003C_003E9__32_29 == null;
			bool flag61 = !flag60;
			Func<string> func57 = _003C_003Ec._003C_003E9__32_29;
			if (!flag61)
			{
				nint num245 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5458 @ S0_v1470 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj275 = (nint)0 & (nint)0x200;
				if (obj275 != null)
				{
					nint num246 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5491 @ S0_v1490 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num247 = 0;
				_ = 0;
				Func<string> func58 = default;
				object obj276 = func58 + 16;
				obj276 = _003C_003Ec._003C_003E9;
				nint num248 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5532 @ S0_v1487 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj277 = (nint)0 + (nint)120;
				obj277 = func58;
				func57 = func58;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
			nint num249 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5536 @ S0_v1311 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj278 = (nint)0 & (nint)0x200;
			if (obj278 != null)
			{
				nint num250 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5543 @ S0_v1464 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag62 = _003C_003Ec._003C_003E9__32_30 == null;
			bool flag63 = !flag62;
			Func<string> func59 = _003C_003Ec._003C_003E9__32_30;
			if (!flag63)
			{
				nint num251 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5560 @ S0_v1439 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj279 = (nint)0 & (nint)0x200;
				if (obj279 != null)
				{
					nint num252 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5593 @ S0_v1459 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num253 = 0;
				_ = 0;
				Func<string> func60 = default;
				object obj280 = func60 + 16;
				obj280 = _003C_003Ec._003C_003E9;
				nint num254 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5634 @ S0_v1456 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj281 = (nint)0 + (nint)124;
				obj281 = func60;
				func59 = func60;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
			nint num255 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5638 @ S0_v1333 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj282 = (nint)0 & (nint)0x200;
			if (obj282 != null)
			{
				nint num256 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5645 @ S0_v1433 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag64 = _003C_003Ec._003C_003E9__32_31 == null;
			bool flag65 = !flag64;
			Func<string> func61 = _003C_003Ec._003C_003E9__32_31;
			if (!flag65)
			{
				nint num257 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5662 @ S0_v1408 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj283 = (nint)0 & (nint)0x200;
				if (obj283 != null)
				{
					nint num258 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5695 @ S0_v1428 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num259 = 0;
				_ = 0;
				Func<string> func62 = default;
				object obj284 = func62 + 16;
				obj284 = _003C_003Ec._003C_003E9;
				nint num260 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5736 @ S0_v1425 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj285 = (nint)0 + (nint)128;
				obj285 = func62;
				func61 = func62;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
			nint num261 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5740 @ S0_v1355 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
			object obj286 = (nint)0 & (nint)0x200;
			if (obj286 != null)
			{
				nint num262 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5747 @ S0_v1402 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag66 = _003C_003Ec._003C_003E9__32_32 == null;
			bool flag67 = !flag66;
			Func<string> func63 = _003C_003Ec._003C_003E9__32_32;
			if (!flag67)
			{
				nint num263 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5763 @ S0_v1377 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+BA]");
				object obj287 = (nint)0 & (nint)0x200;
				if (obj287 != null)
				{
					nint num264 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5788 @ S0_v1397 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num265 = 0;
				_ = 0;
				Func<string> func64 = default;
				object obj288 = func64 + 16;
				obj288 = _003C_003Ec._003C_003E9;
				nint num266 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5825 @ S0_v1394 (Il2CppClass<UI.Popups.SecretPopup+<>c>)+5C]");
				object obj289 = (nint)0 + (nint)132;
				obj289 = func64;
				func63 = func64;
			}
			obj13 = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DFA");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->key, obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+8]");
			((PageContent*)(nint)pageContent)->infoType = SecretCellType.Info;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+10]");
			System.Runtime.CompilerServices.Unsafe.Write(&((PageContent*)(nint)pageContent)->value2, (Func<string>)0);
			list4.Add(pageContent);
		}
		nint num267 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5426 @ S4_v90 (Il2CppMethodInfo)+C]");
		object obj290 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5427 @ S4_v91+60]");
		object obj291 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5428 @ S4_v92+48]");
		object obj292 = 0;
		object obj293 = obj292 & 0x7FF;
		object obj294 = obj293 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v5436 @ S5_v76 (should have been resolved before IL gen)");
	}

	public void DisplayList2()
	{
		//IL_0029: Expected Obj, but got I4
		LoadAdvertisingInfoAsync();
		InsertTitle(null);
		_lastTabOpen = TabNumber.Tab1;
		SetAdvertisingInfo((string)_lastTab1Index);
		_listHasBeenDisplayedOnce = true;
	}

	public void DisplayList3()
	{
		//IL_0011: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		LoadAdvertisingInfoAsync();
		InsertTitle((string)1);
		_lastTabOpen = TabNumber.Tab2;
		SetAdvertisingInfo((string)_lastTab2Index);
	}

	public void DisplayList4()
	{
		//IL_0011: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		LoadAdvertisingInfoAsync();
		InsertTitle((string)2);
		_lastTabOpen = TabNumber.Tab3;
		SetAdvertisingInfo((string)_lastTab3Index);
	}

	private void SetEndOfList()
	{
		//IL_0011: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		LoadAdvertisingInfoAsync();
		InsertTitle((string)3);
		_lastTabOpen = TabNumber.Tab4;
		SetAdvertisingInfo((string)_lastTab4Index);
	}

	private void InsertInfo(string label, string value)
	{
		if (_lastTabOpen == TabNumber.Tab2)
		{
			DisplayList3();
		}
	}

	private void InsertTitle(string title)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected Obj, but got Unknown
		//IL_03c9: Expected Obj, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected Obj, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected Obj, but got Unknown
		//IL_043d: Expected I4, but got Obj
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 160;
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 20;
		object obj5 = obj2 + 128;
		obj5 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj2 + 104;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 96;
		obj7 = obj;
		_ = -1;
		SaveIndex();
		object obj8 = obj2 - -64;
		List<PageContent> list = _contentDict.get_Item((TabNumber)title);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7BF8");
		obj5 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+18]");
		_ = 0;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj6 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+10]");
			_ = 0;
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v29+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			if ((nint)0 != 0)
			{
				obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+10]");
				_ = 0;
				obj3 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj4 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+10]");
				_ = 0;
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			else
			{
				obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+10]");
				_ = 0;
				obj3 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
		}
		object obj10 = obj7 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj7 + obj12;
		obj13 = 132;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj7 + obj14;
			if ((nint)obj15 == 132)
			{
				object obj16 = obj7 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_04d9;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04d9;
		IL_04d9:
		ResetList();
	}

	private void InsertDoubleInfo(string label1, string value1, string label2, string value2)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = this;
		object obj3 = obj2 + 12;
		obj3 = label1;
		object obj4 = value1;
		_ = value1.m_stringLength;
		object obj5 = obj2 + 16;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj4 = label2;
		_ = label2.m_stringLength;
		object obj6 = obj2 + 28;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj4 = value2;
		_ = value2.m_stringLength;
		object obj7 = obj2 + 40;
		obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		string text = default;
		text.m_stringLength = (int)num;
		_ = 0;
		object obj8 = text + 16;
		obj8 = obj2;
		Timer.Log(text);
	}

	private void ResetList()
	{
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0082: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SecretCell secretCell = default;
		secretCell.cellType = SecretCellType.EndList;
		_contentList.Add(secretCell);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_scrollView).FindKernel((string)null) != 0 && _adapter != null)
		{
			_scrollView.CalculateVirtualRelativeWidgetBounds((ScrollView.BoundsCalculationMode)_adapter);
		}
	}

	private void SaveIndex()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
	}

	private void ScrollToLastIndex(int index)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SecretCell secretCell = default;
		object obj = secretCell + 20;
		obj = index;
		secretCell.cellType = SecretCellType.Subtitle;
		_contentList.Add(secretCell);
	}

	private IEnumerator ShowTextCopied()
	{
		//IL_001d: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 8;
		return (IEnumerator)flag;
	}

	private string GetBundleIdentifier()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = this;
		return text;
	}

	private string GetVersion()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		ApplicationInstallMode installMode = Application.installMode;
		IEnumerator enumerator = ((SecretPopup)null).ShowTextCopied();
		if ((enumerator == null) ? ((string)installMode != "com.kiloo.subwaysurf") : ((string)installMode != "com.kiloo.subwaysurfers"))
		{
			return "Validated";
		}
		return (string)installMode;
	}

	private string GetFirstInstalledVersion()
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_021b: Expected I, but got Obj
		//IL_02db: Expected I4, but got Obj
		//IL_02db: Expected I4, but got Obj
		//IL_02db: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		//IL_01ef: Expected Obj, but got I4
		//IL_01a8: Expected I, but got Obj
		if (((SecretPopup)null).IsiOSDevice())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v34 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v53 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
			throw new ArrayTypeMismatchException();
		}
		IEnumerator enumerator = ((SecretPopup)null).ShowTextCopied();
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v8 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 != null;
		if (enumerator != null)
		{
			if (flag)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string bundleIdentifier2 = DeviceUtility.GetBundleIdentifier();
			DeviceUtilityAndroid deviceUtilityAndroid = DeviceUtilityAndroid.CreatePlugin();
			int num5 = bundleIdentifier2.IndexOf((char)(int)" (", (int)deviceUtilityAndroid, (int)")");
			return (string)num5;
		}
		if (flag)
		{
			nint num6 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v17 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return DeviceUtility.GetBundleIdentifier();
	}

	private string GetInitialInstallDate()
	{
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_0188: Expected Obj, but got I4
		//IL_00d9: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (UserSave.hasAdRemovalUpgrade)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			return "Earlier than 1.73.0";
		}
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v15 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v21 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasAdRemovalUpgrade = UserSave.hasAdRemovalUpgrade;
		return (string)hasAdRemovalUpgrade;
	}

	private string GetUsedDeviceMemory()
	{
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_0265: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01ae: Expected Obj, but got VT
		//IL_01b7: Expected Obj, but got VT
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_023f: Expected Obj, but got VT
		//IL_00fc: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v57 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v51 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 8;
		obj5 = lastTimeAVideoForKeysWasSeen;
		obj2 = DateTime.MinValue;
		object obj6 = obj2 + 24;
		obj6 = obj5;
		object obj7 = obj2 + 32;
		obj7 = obj2;
		object obj8 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj9 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		if (obj8 == obj9)
		{
			return "Earlier than January 2015";
		}
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v45 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastTimeAVideoForKeysWasSeen2 = UserSave.lastTimeAVideoForKeysWasSeen;
		obj = lastTimeAVideoForKeysWasSeen2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCE1");
		string result = default;
		return result;
	}

	private string GetApplicationMemoryLimit()
	{
		//IL_008b: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_010b: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		string deviceUniqueIdentifier = SystemInfo.GetDeviceUniqueIdentifier();
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v27 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int currentMemoryUsage = DeviceUtility.GetCurrentMemoryUsage();
		object obj3 = deviceUniqueIdentifier - currentMemoryUsage;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string[] values = default;
		string result = string.ConcatArray(values, (int)" MB");
		if (currentMemoryUsage == 0)
		{
			result = "Unknown";
		}
		return result;
	}

	private string GetApplicationMemoryUsage()
	{
		//IL_008e: Expected Obj, but got I4
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_00fd: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v26 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int batteryLevel = DeviceUtility.GetBatteryLevel();
		obj = batteryLevel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string[] values = default;
		string text = string.ConcatArray(values, (int)" MB");
		bool flag = obj == null;
		string result = "Unknown";
		if (!flag)
		{
			result = text;
		}
		return result;
	}

	private string GetPeakMemoryUsage()
	{
		//IL_008e: Expected Obj, but got I4
		//IL_009c: Expected I, but got Obj
		//IL_00b2: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I4
		//IL_00fd: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v26 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int peakMemoryUsage = DeviceUtility.GetPeakMemoryUsage();
		obj = peakMemoryUsage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string[] values = default;
		string text = string.ConcatArray(values, (int)" MB");
		bool flag = obj == null;
		string result = "Unknown";
		if (!flag)
		{
			result = text;
		}
		return result;
	}

	private string GetDebugMode()
	{
		//IL_008f: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		object obj = 0;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v22 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int memoryUsageLimit = DeviceUtility.GetMemoryUsageLimit();
		obj = memoryUsageLimit;
		if (memoryUsageLimit != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			string[] values = default;
			return string.ConcatArray(values, (int)" MB");
		}
		return "Unknown";
	}

	private string GetScreenDPI()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			return "ON";
		}
		return "Off";
	}

	private string GetBatteryLevel()
	{
		//IL_0057: Expected Obj, but got F4
		//IL_0024: Expected Obj, but got F4
		//IL_0040: Expected I4, but got Obj
		object obj = 0f;
		float value = UnityEngine.Random.value;
		if (value == 0f)
		{
			return "Unknown";
		}
		float value2 = UnityEngine.Random.value;
		obj = value2;
		OverflowException values = new OverflowException();
		return string.ConcatArray((string[])(object)values, (int)" DPI");
	}

	private string GetTotalDiskSpace()
	{
		//IL_008f: Expected Obj, but got I4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I4
		//IL_0078: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v23 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int freeDiskSpace = DeviceUtility.GetFreeDiskSpace();
		obj = freeDiskSpace;
		if (freeDiskSpace == -1)
		{
			return "Unknown";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string[] values = default;
		return string.ConcatArray(values, (int)"%");
	}

	private string GetUsedDiskSpace()
	{
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0101: Expected Obj, but got F4
		//IL_0060: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int freeSDCardSpace = DeviceUtility.GetFreeSDCardSpace();
		float num3 = (float)freeSDCardSpace * (1f / 1024f);
		object obj2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string values = $"{args:F2}";
		string result = string.ConcatArray((string[])(object)values, (int)" GB");
		if (num3 == -1f)
		{
			result = "Unknown";
		}
		return result;
	}

	private string GetUsedSDCardSpace()
	{
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0140: Expected Obj, but got F4
		//IL_0072: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int totalDiskSpace = DeviceUtility.GetTotalDiskSpace();
		float num3 = (float)totalDiskSpace * (1f / 1024f);
		int freeSDCardSpace = DeviceUtility.GetFreeSDCardSpace();
		float num4 = (float)freeSDCardSpace * (1f / 1024f);
		float num5 = num4 - num3;
		object obj2 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string values = $"{args:F2}";
		string result = string.ConcatArray((string[])(object)values, (int)" GB");
		if (num3 == -1f)
		{
			result = "Unknown";
		}
		return result;
	}

	private string GetTotalSDCardSpace()
	{
		//IL_00bf: Expected I, but got Obj
		//IL_00d5: Expected Obj, but got I
		//IL_0140: Expected Obj, but got F4
		//IL_0072: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int totalSDCardSpace = DeviceUtility.GetTotalSDCardSpace();
		float num3 = (float)totalSDCardSpace * (1f / 1024f);
		bool hasPhysicalBackButton = DeviceUtility.hasPhysicalBackButton;
		float num4 = (float)(hasPhysicalBackButton ? 1 : 0) * (1f / 1024f);
		float num5 = num4 - num3;
		object obj2 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string values = $"{args:F2}";
		string result = string.ConcatArray((string[])(object)values, (int)" GB");
		if (num3 == -1f)
		{
			result = "Unknown";
		}
		return result;
	}

	private string GetOnlineSettings()
	{
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0101: Expected Obj, but got F4
		//IL_0060: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v29 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool hasPhysicalBackButton = DeviceUtility.hasPhysicalBackButton;
		float num3 = (float)(hasPhysicalBackButton ? 1 : 0) * (1f / 1024f);
		object obj2 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string values = $"{args:F2}";
		string result = string.ConcatArray((string[])(object)values, (int)" GB");
		if (num3 == -1f)
		{
			result = "Unknown";
		}
		return result;
	}

	private string GetOnlineSettingsPlatform()
	{
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_ONLINESETTINGS_SET ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v19 (Il2CppClass<Globals>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v45 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string oNLINESETTINGS_SET = Globals.ONLINESETTINGS_SET;
			if (Globals.ONLINESETTINGS_SET != null && oNLINESETTINGS_SET.m_stringLength != 0)
			{
				nint num5 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v28 (Il2CppClass<Globals>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v35 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return Globals.ONLINESETTINGS_SET;
			}
		}
		return "Live";
	}

	private string GetOnlineSettingsChecksum()
	{
		//IL_0122: Expected Obj, but got I4
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I4
		//IL_0108: Expected I4, but got Obj
		object obj = 0;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v30 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		string currentPlatformPretty = ((OnlineSettings)(object)saveDataPath).GetCurrentPlatformPretty();
		string[] array = currentPlatformPretty.Split(null);
		obj = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
		string result;
		if (currentPlatformPretty != "ios")
		{
			result = "iOS";
		}
		else
		{
			bool flag = currentPlatformPretty.m_stringLength > 0;
			bool flag2 = !flag;
			result = currentPlatformPretty;
			if (!flag2)
			{
				string text = default;
				string values = text.ToUpperInvariant();
				string text2 = currentPlatformPretty.Trim((char[])1);
				string text3 = string.ConcatArray((string[])(object)values, (int)text2);
				result = text3;
			}
		}
		return result;
	}

	private string GetKilooAnalyticsSample()
	{
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.String)+1C]");
		string result = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.String)+1C]");
		if ((nint)0 == 0)
		{
			result = "No";
		}
		return result;
	}

	private string GetKilooAnalyticsInfo()
	{
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00c6: Expected I4, but got Obj
		//IL_00d2: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		float startOffset = ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"kiloo_analytics_sample", 0f);
		object obj2 = startOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		return text + "%";
	}

	private string GetAnalyticsSamplingKey()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Manager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Analytics.Manager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Manager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Kiloo.Analytics.Manager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C17");
		object obj2 = default;
		if (obj2 != null)
		{
			return "Yes";
		}
		return "No";
	}

	private string GetTimezone()
	{
		//IL_0016: Expected Obj, but got F4
		float userSampleValue = Manager.userSampleValue;
		object obj = userSampleValue;
		return (string)(object)new OverflowException();
	}

	private string CheckForInAppLegacyPurchase()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got F8
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got VT
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got F8
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0.0;
		object obj3 = obj2 + 8;
		obj3 = 0;
		DateTime utcNow = CDateTime.UtcNow;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v36 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = utcNow;
		object obj5 = obj2 + 24;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D775");
		object obj6 = default;
		obj3 = obj6;
		double num3 = (double)obj3 * 2.7777777777777777E-11;
		obj = num3;
		OverflowException type = new OverflowException();
		string text = ((!(num3 > 0.0)) ? "GMT" : "GMT+");
		return (string)((IConvertible)text).ToType((Type)(object)type, (IFormatProvider)(object)":00");
	}

	private string CheckForInAppConsumablePurchase()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int inAppConsumablePurchaseCount = UserSave.inAppConsumablePurchaseCount;
		obj = inAppConsumablePurchaseCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private string CheckForInAppNonconsumablePurchase()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int inAppNonConsumablePurchaseCount = UserSave.inAppNonConsumablePurchaseCount;
		obj = inAppNonConsumablePurchaseCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private string CheckForInAppRestoredPurchase()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int inAppRestoredPurchaseCount = UserSave.inAppRestoredPurchaseCount;
		obj = inAppRestoredPurchaseCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private string GetFacebookID()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string> inAppPurchaseHistory = UserSave.inAppPurchaseHistory;
		obj = inAppPurchaseHistory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private void LoadAdvertisingInfoAsync()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c1: Expected I4, but got Obj
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00de: Expected I4, but got Obj
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_00fb: Expected I4, but got Obj
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0118: Expected I4, but got Obj
		if (~(_listHasBeenDisplayedOnce ? 1u : 0u) != 0)
		{
			return;
		}
		Container lastVisibleContainerOnScreen = _scrollView.GetLastVisibleContainerOnScreen();
		if (_lastTabOpen != TabNumber.Tab1)
		{
			if (_lastTabOpen != TabNumber.Tab2)
			{
				if (_lastTabOpen != TabNumber.Tab3)
				{
					if (_lastTabOpen == TabNumber.Tab4)
					{
						object obj = lastVisibleContainerOnScreen - -64;
						_lastTab4Index = (int)obj;
					}
				}
				else
				{
					object obj2 = lastVisibleContainerOnScreen - -64;
					_lastTab3Index = (int)obj2;
				}
			}
			else
			{
				object obj3 = lastVisibleContainerOnScreen - -64;
				_lastTab2Index = (int)obj3;
			}
		}
		else
		{
			object obj4 = lastVisibleContainerOnScreen - -64;
			_lastTab1Index = (int)obj4;
		}
	}

	private void SetAdvertisingInfo(string text)
	{
		//IL_0015: Expected VT, but got Obj
		_scrollView.SmoothScrollToOffset((Vector3)text, (Action)null, 0f);
	}

	private string GetAdvertisingID()
	{
		//IL_02b3: Expected I, but got Obj
		//IL_02c9: Expected Obj, but got I
		//IL_0409: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_032d: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_036b: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03c2: Expected Obj, but got I
		//IL_03e9: Expected I4, but got Obj
		//IL_03e9: Expected I4, but got Obj
		//IL_03e9: Expected Obj, but got I
		//IL_0292: Expected Obj, but got I4
		//IL_024b: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v73 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (((SocialManager)facebookDialogsSupported).HasFacebookAccessToken())
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v19 (Il2CppClass<SocialManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v69 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v24 (System.Boolean)+38]");
			if ((nint)0 != 0)
			{
				nint num5 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Il2CppClass<SocialManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v65 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool facebookDialogsSupported3 = SocialManager.facebookDialogsSupported;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33 (System.Boolean)+38]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v34+10]");
				if ((nint)0 != 0)
				{
					nint num7 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v38 (Il2CppClass<SocialManager>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v61 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool facebookDialogsSupported4 = SocialManager.facebookDialogsSupported;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v43 (System.Boolean)+38]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v44+8]");
					if ((nint)0 != 0)
					{
						nint num9 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v48 (Il2CppClass<SocialManager>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num10 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v57 (Il2CppClass<SocialManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool facebookDialogsSupported5 = SocialManager.facebookDialogsSupported;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v53 (System.Boolean)+38]");
						object obj8 = 0;
						bool facebookDialogsSupported6 = SocialManager.facebookDialogsSupported;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v11 (System.Boolean)+38]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v54+10]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v12+8]");
						int num12 = ((string)num11).IndexOf((char)(int)" (id: ", 0, (int)")");
						return (string)num12;
					}
				}
			}
		}
		return "Not logged in to Facebook";
	}

	private string GetGameCenterID()
	{
		return _advertisingIdentifier;
	}

	private string CheckForRootedDevice()
	{
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_024d: Expected Obj, but got I4
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		if (!((SocialManager)facebookDialogsSupported).gamecenterIsLoggedOut)
		{
			return "Not logged in.";
		}
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (Il2CppClass<SocialManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v46 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (System.Boolean)+3C]");
		object obj3 = 0;
		Encoding latin = Encoding.Latin1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj5 = default;
		object obj4 = obj5 + 12;
		string text = "";
		object obj6 = default;
		string text3 = default;
		object obj10 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
		{
			object obj7 = obj5 + 16;
			object obj8 = obj7 + obj6;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text2 = text + text3 + " ";
			obj6 = obj10 + 1;
			text = text2;
		}
		if (text != null)
		{
			return text;
		}
		return "";
	}

	private string TruncateProviderID(string providerID)
	{
		if (providerID != null)
		{
			return "yes";
		}
		return "no";
	}

	private string GetAdLocationStatus(AdLocationInfo adLocationInfo)
	{
		//IL_008d: Expected I4, but got Obj
		bool flag = (string)(object)adLocationInfo != "none";
		bool flag2 = !flag;
		bool flag3 = !flag2;
		string result = "none";
		if (!flag3)
		{
			bool flag4 = adLocationInfo == null || adLocationInfo.id == null;
			bool flag5 = !flag4;
			bool flag6 = !flag5;
			result = "none";
			if (!flag6)
			{
				bool flag7 = (nint)adLocationInfo.id > 1;
				bool flag8 = !flag7;
				result = "none";
				if (!flag8)
				{
					string format = ((!((string)(object)adLocationInfo).EndsWith((char)(int)"_(saved)")) ? "{0}" : "({0})");
					string args = ((string)(object)adLocationInfo).InternalSubString(0, 2);
					string text = string.Format(format, (object[])(object)args);
					result = text;
				}
			}
		}
		return result;
	}

	private string CheckForJailbrokenDevice()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private string GetSyboAnalyticsHashedDeviceId()
	{
		if (Directory.IsRootDirectory("/bin/bash"))
		{
			return "Yes";
		}
		return "No";
	}

	private string GetSyboAnalyticsSamplingThreshold()
	{
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(BaseSessionEvent);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(BaseSessionEvent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<SYBO.Components.Analytics.BaseSessionEvent>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = BaseSessionEvent.GetDeviceID == null;
		string result = "NA";
		if (!flag)
		{
			string text = BaseSessionEvent.GetDeviceID();
			result = text;
		}
		return result;
	}

	private string GetSyboAnalyticsEnabled()
	{
		//IL_0060: Expected Obj, but got F4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		//IL_00c9: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		object obj = 0f;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		float startOffset = ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"sybo_analytics_sampling_threshold", 0f);
		obj = startOffset;
		return (string)(object)new OverflowException();
	}

	private unsafe string GetRestrictionActive()
	{
		//IL_0060: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00c5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		bool flag = ((OnlineSettings)(object)saveDataPath).TryGetValue("sybo_analytics_enabled", out *(string*)null);
		obj = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
		string result = default;
		return result;
	}

	private string GetKilooLoggerID()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.waitForAgeRestriction)
		{
			return "Yes";
		}
		return "No";
	}

	private string GetKilooTag()
	{
		//IL_0009: Expected Obj, but got I4
		return (string)AnalyticsSave.hasLoggedGameCenterLogin;
	}

	private string GetUserBirthday()
	{
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v20 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, Friend.Status> friendStatus = SocialSave.friendStatus;
		if (friendStatus == null || friendStatus.buckets == null)
		{
			return "Not set";
		}
		return (string)(object)friendStatus;
	}

	private string GetApplicationGenuine()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00ad: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime scheduledFirstInterstitialShowTime = AdsSave.scheduledFirstInterstitialShowTime;
		obj = scheduledFirstInterstitialShowTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF5");
		string result = default;
		return result;
	}

	private string GetApplicationInstaller()
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		object obj = 0;
		if (Application.isEditor)
		{
			bool genuineCheckAvailable = Application.genuineCheckAvailable;
			obj = genuineCheckAvailable;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
			string result = default;
			return result;
		}
		return "N/A";
	}

	private string GetAmountOfOwnedHoverboards()
	{
		string cloudProjectId = Application.cloudProjectId;
		object obj = cloudProjectId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private string GetAmountOfOwnedCharacters()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_02dd: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 40;
		obj5 = 0;
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<Info.Boards>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v98 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v82 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v91 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 != null)
			{
				object obj10 = obj5 + 1;
				obj5 = obj10;
			}
		}
		object obj11 = obj4 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj4 + obj13;
		obj14 = 58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 58)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_03ce;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03ce;
		IL_03ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private string GetABTestStatus()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_0296: Expected Obj, but got I4
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Expected Obj, but got I4
		//IL_02dd: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected Obj, but got Unknown
		//IL_0358: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 40;
		obj5 = 0;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v98 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		object obj9 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v82 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v91 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 != null)
			{
				object obj10 = obj5 + 1;
				obj5 = obj10;
			}
		}
		object obj11 = obj4 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj4 + obj13;
		obj14 = 58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj4 + obj15;
			if ((nint)obj16 == 58)
			{
				object obj17 = obj4 + 4;
				if ((nint)obj17 > -1)
				{
					object obj18 = obj17 + -1;
					obj17 = obj18;
				}
				goto IL_03ce;
			}
		}
		object obj19 = default;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03ce;
		IL_03ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private string GetMigratedPlayerInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected Obj, but got Unknown
		//IL_0788: Expected Obj, but got I4
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07b8: Expected I, but got Obj
		//IL_07ce: Expected Obj, but got I
		//IL_0838: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I4
		//IL_0604: Expected Obj, but got I
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_084b: Expected I, but got Obj
		//IL_0861: Expected Obj, but got I
		//IL_0924: Expected Obj, but got I4
		//IL_06e3: Expected I, but got Obj
		//IL_06f9: Expected Obj, but got I
		//IL_0670: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected Obj, but got Unknown
		//IL_01d2: Expected I, but got Obj
		//IL_0724: Expected I, but got Obj
		//IL_021d: Expected Obj, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_056c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(ABTestData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11 (Il2CppClass<ABTest.ABTestData>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(ABTestData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v86 (Il2CppClass<ABTest.ABTestData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		string text = string.Empty;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		string text2 = default;
		object obj6;
		string text3 = default;
		string text4 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj6 = 32;
			bool flag = obj7 == null;
			obj6 = 33;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj6 = 11;
			nint num3 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v110 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v166 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj6 = 12;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj9 == null)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 != null)
			{
				text2 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
			nint num5 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S0_v127 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v146 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					text3 = text2;
					obj6 = 24;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			text3 = text2;
			obj6 = 30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			text3 = text2;
			text = text4;
		}
		object obj12 = obj6 - 11;
		string text5 = default;
		if ((nint)obj6 != 11 && (nint)obj12 != 1)
		{
			if ((nint)obj12 == 2 || (nint)obj12 == 3)
			{
				goto IL_0929;
			}
			if ((nint)obj12 != 4)
			{
				if ((nint)obj12 == 5 || (nint)obj12 == 6)
				{
					goto IL_0929;
				}
				if ((nint)obj12 != 7)
				{
					if ((nint)obj12 == 8 || (nint)obj12 == 9 || (nint)obj12 == 10 || (nint)obj12 == 11)
					{
						goto IL_0929;
					}
					if ((nint)obj12 != 12)
					{
						if ((nint)obj12 != 13)
						{
							if ((nint)obj12 == 14 || (nint)obj12 == 15 || (nint)obj12 == 16 || (nint)obj12 == 17 || (nint)obj12 == 18)
							{
								goto IL_0929;
							}
							if ((nint)obj12 != 19)
							{
								if ((nint)obj12 != 20)
								{
									if ((nint)obj12 != 21)
									{
										if ((nint)obj12 == 22)
										{
											object obj13 = obj4 + 4;
											object obj14 = obj13 + 1;
											obj13 = obj14;
											object obj15 = obj14 << 2;
											object obj16 = obj4 + obj15;
											obj16 = 114;
											text5 = text;
										}
										goto IL_0929;
									}
								}
								else
								{
									text = text3;
								}
							}
							else
							{
								text = text3;
							}
						}
						else
						{
							text = text3;
						}
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj17 = default;
		object obj18 = default;
		if (obj17 == obj18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			text5 = text;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0929;
		IL_094e:
		if (text5 == null || text5.m_stringLength == 0)
		{
			nint num7 = (nint)typeof(ABTestManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v45 (Il2CppClass<ABTest.ABTestManager>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num8 = (nint)typeof(ABTestManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S0_v53 (Il2CppClass<ABTest.ABTestManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C30");
			object obj20 = default;
			bool flag2 = obj20 == null;
			bool flag3 = !flag2;
			text5 = "None";
			if (!flag3)
			{
				text5 = "Not initialized";
			}
		}
		return text5;
		IL_0929:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj4 + obj21;
			if ((nint)obj22 == 114)
			{
				object obj23 = obj4 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_094e;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_094e;
	}

	private string GetMigratedPlayerPrefsVersion()
	{
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v17 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int migratedPlayerPrefsVersion = UserSave.migratedPlayerPrefsVersion;
		int num3 = migratedPlayerPrefsVersion & 1;
		obj = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
		string result = default;
		return result;
	}

	public void CopyToClipboard()
	{
		//IL_003c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		LogType logType = default;
		object obj = logType + 16;
		obj = this;
		if (Application.GetStackTraceLogType(logType) == StackTraceLogType.None)
		{
			((WithdrawConsentPopup)this).LogWithdraw("Platform not supported");
		}
	}

	public unsafe void CopyAppFileInformationToClipboard()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I4
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0845: Expected Obj, but got I4
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Expected Obj, but got Unknown
		//IL_08a1: Expected I, but got Obj
		//IL_08b7: Expected Obj, but got I
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected Obj, but got Unknown
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected I, but got Unknown
		//IL_090b: Expected I, but got Obj
		//IL_0926: Expected I, but got Obj
		//IL_093c: Expected Obj, but got I
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected Obj, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected Obj, but got Unknown
		//IL_0998: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0650: Expected Obj, but got I4
		//IL_0a9e: Expected I, but got Obj
		//IL_0ab4: Expected Obj, but got I
		//IL_070d: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_07c5: Expected I, but got Obj
		//IL_0743: Unknown result type (might be due to invalid IL or missing references)
		//IL_0748: Expected Obj, but got Unknown
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I4
		//IL_0178: Expected Obj, but got I
		//IL_019f: Expected Obj, but got I
		//IL_02db: Expected I, but got Obj
		//IL_04a5: Expected Obj, but got I
		//IL_01eb: Expected I, but got Obj
		//IL_053a: Expected Obj, but got I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected Obj, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 160;
		object obj3 = obj2 + 96;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 72;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 - -64;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj6 = this + 92;
		obj6 = stringBuilder;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v31 (Il2CppClass<System.Type>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v328 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = obj2 + 60;
		obj8 = typeof(TabNumber);
		nint num3 = (nint)(obj2 + 128);
		((IntPtr*)num3)->m_value = (void*)(nint)obj8;
		Type enumType = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v27 (Il2CppClass<System.Enum>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v218 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 40;
		object obj11 = obj2 + 20;
		ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
		int num6 = ((Array)array).InternalArray__ICollection_get_Count();
		object obj12 = 0;
		object obj13 = default;
		object obj14 = default;
		object obj24 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		object obj29 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj13 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj3 = (object)((IntPtr*)num3)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+18]");
				_ = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj14 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj4 = (object)((IntPtr*)num3)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+10]");
					_ = 0;
					obj10 = (object)((IntPtr*)num3)->m_value;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38 (System.IntPtr)+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v32+8]");
					if ((nint)0 != 0)
					{
						((IntPtr*)num3)->m_value = (void*)(nint)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+10]");
						_ = 0;
						obj10 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						obj11 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+10]");
						_ = 0;
						obj2 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					}
					else
					{
						((IntPtr*)num3)->m_value = (void*)(nint)obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+10]");
						_ = 0;
						obj10 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					}
				}
				object obj15 = obj5 + 4;
				object obj16 = obj15 + 1;
				obj15 = obj16;
				object obj17 = obj16 << 2;
				object obj18 = obj5 + obj17;
				obj18 = 235;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+4]");
					object obj19 = (nint)0 << 2;
					object obj20 = obj5 + obj19;
					if ((nint)obj20 == 235)
					{
						object obj21 = obj5 + 4;
						if ((nint)obj21 > -1)
						{
							object obj22 = obj21 + -1;
							obj21 = obj22;
						}
						continue;
					}
				}
				if (obj12 == null)
				{
					obj12 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj23 = obj24;
				object obj25 = obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj25 == obj27)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					obj28 = obj29;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				break;
			}
			object obj30 = obj5 + 4;
			object obj31 = obj30 + 1;
			obj30 = obj31;
			object obj32 = obj31 << 2;
			object obj33 = obj5 + obj32;
			obj33 = 268;
			obj28 = obj12;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj34 = default;
		if (obj34 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v21+4]");
			object obj35 = (nint)0 << 2;
			object obj36 = obj5 + obj35;
			if ((nint)obj36 == 268)
			{
				object obj37 = obj5 + 4;
				if ((nint)obj37 > -1)
				{
					object obj38 = obj37 + -1;
					obj37 = obj38;
				}
				goto IL_0a86;
			}
		}
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a86;
		IL_0a86:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num7 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S1_v50 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj39 = (nint)0 & (nint)0x200;
		if (obj39 != null)
		{
			nint num8 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v57 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string message = default;
		DeviceUtility.MakeIOSNSLog(message);
		string bundleIdentifier = GetBundleIdentifier();
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)bundleIdentifier);
	}

	private void AppendSection(string sectionName, string path, FileLogType fileSectionType)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0026: Expected VT, but got I4
		//IL_0026: Expected VT, but got Obj
		//IL_0026: Expected VT, but got Obj
		//IL_0026: Expected Obj, but got I4
		object obj = this - -64;
		TopRunOnlineScreen.PositionModelOnSprite((UIWidget)_lastTab3Index, (GameObject)(object)sectionName, (Vector3)path, (Vector3)obj, (Vector3)fileSectionType);
	}

	private static string BytesToMegabytes(double len)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private void WalkDirectoryTree(DirectoryInfo directoryInfo, FileLogType fileSectionType)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_003b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		SecretCell secretCell = default;
		object obj = secretCell + 12;
		obj = directoryInfo;
		object obj2 = secretCell + 16;
		obj2 = fileSectionType;
		secretCell.cellType = SecretCellType.Info;
		_contentList.Add(secretCell);
	}

	public SecretPopup()
	{
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_038e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_03d9: Expected Obj, but got I4
		//IL_03d9: Expected I4, but got Obj
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_015d: Expected I, but got Obj
		//IL_0252: Expected F8, but got I8
		//IL_0109: Expected Obj, but got I4
		//IL_0109: Expected I4, but got Obj
		//IL_00ba: Expected I, but got Obj
		//IL_0281: Expected I4, but got Obj
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_02a2: Expected I, but got Obj
		//IL_02b8: Expected Obj, but got I
		//IL_0401: Expected Obj, but got I4
		//IL_0401: Expected I4, but got Obj
		//IL_041a: Expected I8, but got I4
		//IL_0208: Expected I, but got Obj
		//IL_02e3: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		fileInfoStringBuilder.AppendHelper((string)null);
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v58 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		_003CLoadAdvertisingInfoAsync_003Eb__77_0(null, (byte)(int)cachePath != 0, null);
		if (((SecretPopup)null).IsiOSDevice())
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v48 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v54 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int androidApiLevel = DeviceUtility.GetAndroidApiLevel();
			_003CLoadAdvertisingInfoAsync_003Eb__77_0(null, (byte)androidApiLevel != 0, null);
			string absoluteURL = Application.absoluteURL;
			_003CLoadAdvertisingInfoAsync_003Eb__77_0(null, (byte)(int)absoluteURL != 0, (string)1);
		}
		nint num5 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v43 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIdentifier = DeviceUtility.GetDeviceIdentifier();
		_003CLoadAdvertisingInfoAsync_003Eb__77_0(null, (byte)(int)deviceIdentifier != 0, (string)1);
		IEnumerator enumerator = ((SecretPopup)null).ShowTextCopied();
		if (enumerator != null)
		{
			nint num7 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v34 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v39 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = DeviceUtility.GetiOSBuildNumber();
			_003CLoadAdvertisingInfoAsync_003Eb__77_0(null, (byte)(int)text != 0, (string)1);
		}
		byte[] bytes = Mono.Security.BitConverterLE.GetBytes((double)_totalSize);
		object obj5 = ((IConvertible)"Total overall size is ").ToType((Type)(object)bytes, (IFormatProvider)(object)" MB");
		StringBuilder stringBuilder = fileInfoStringBuilder.Append((char)(int)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num9 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v22 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v28 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string message = default;
		DeviceUtility.MakeIOSNSLog(message);
		_totalSize = 0L;
	}

	private void _003CLoadAdvertisingInfoAsync_003Eb__77_0(string advertisingId, bool trackingEnabled, string error)
	{
		//IL_0048: Expected Obj, but got I4
		//IL_003a: Expected I8, but got I4
		if (Directory.IsRootDirectory((string)trackingEnabled))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			DirectoryInfo directoryInfo = default;
			directoryInfo.Delete(trackingEnabled);
			((SecretHelper)(object)this).UpdateInfo((string)(object)directoryInfo, error);
			_sectionSize = 0L;
		}
	}
}
