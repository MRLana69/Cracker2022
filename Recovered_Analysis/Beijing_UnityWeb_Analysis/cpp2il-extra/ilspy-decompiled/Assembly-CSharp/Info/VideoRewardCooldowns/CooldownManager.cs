using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Info.Localization;
using Kiloo;
using SYBO.Subway.Info;
using UnityEngine;

namespace Info.VideoRewardCooldowns;

public class CooldownManager
{
	private static CooldownManager _instance;

	private const string OS_KEY = "video_reward_cooldowns";

	private const char OS_ENTRY_SEPARATOR = ',';

	private const char OS_COMPONENT_SEPARATOR = ':';

	private const int INFINITE_CHARGES_VALUE = -1;

	private OnlineSettings _onlineSettings;

	private Cooldowns _cooldowns;

	private static CooldownManager instance
	{
		get
		{
			//IL_00fc: Expected I, but got Obj
			//IL_0112: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(WelcomePopupTheme);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.WelcomePopupTheme>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(WelcomePopupTheme);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Info.WelcomePopupTheme>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (object)WelcomePopupTheme._instance == null;
			bool flag2 = !flag;
			CooldownManager result = (CooldownManager)(object)WelcomePopupTheme._instance;
			if (!flag2)
			{
				_0021_00210[] array = (_0021_00210[])(object)Resources.LoadAll<T>("Info/WelcomePopupTheme");
				nint num3 = (nint)typeof(WelcomePopupTheme);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v20 (Il2CppClass<Info.WelcomePopupTheme>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(WelcomePopupTheme);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27 (Il2CppClass<Info.WelcomePopupTheme>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WelcomePopupTheme._instance = (WelcomePopupTheme)(object)array;
				result = (CooldownManager)(object)array;
			}
			return result;
		}
	}

	private unsafe void LoadAndParseFromOnlineSettings()
	{
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 8;
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		obj2 = saveDataPath;
		object obj3 = this + 12;
		bool hasLoggedStaticData = AnalyticsSave.hasLoggedStaticData;
		obj3 = hasLoggedStaticData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CooldownManager.LoadAndParseFromOnlineSettings);
		object obj4 = action + 16;
		obj4 = this;
		_onlineSettings.RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		Consume((string)(object)this);
	}

	private Cooldown Parse(string data)
	{
		//IL_006c: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.VideoRewardCooldowns.CooldownManager)+2C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.VideoRewardCooldowns.CooldownManager)+2C]");
			object obj = (nint)0 + (nint)16;
			object obj2 = (object)data << 2;
			return (Cooldown)(object)(obj + obj2);
		}
		return (Cooldown)(-1);
	}

	private static bool HasCharge(Cooldown cd)
	{
		return (byte)cd.seconds__BackingField != 0;
	}

	public static bool HasCharge(string id)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_01d5: Expected Obj, but got I
		//IL_01ff: Expected Obj, but got VT
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 16;
		object obj6 = obj2 + 8;
		if (id.m_firstChar == -1)
		{
			return true;
		}
		nint num = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v12 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v39 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		DateTime today = CDateTime.Today;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v30 (Il2CppClass<System.DateTime>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v53 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+18]");
		obj4 = 0;
		object obj9 = default;
		obj5 = obj9;
		obj3 = obj4;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
		obj6 = today;
		object obj10 = default;
		obj2 = obj10;
		obj3 = obj6;
		obj = obj2;
		object obj11 = obj3 & 0x3FFFFFFFFFFFFFFFL;
		object obj12 = obj & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
		{
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+10]");
		return (nint)0 < (nint)(int)id.m_firstChar;
	}

	public unsafe static void Consume(string id)
	{
		//IL_00f8: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Obj, but got Unknown
		//IL_0058: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		bool flag = default;
		((bool*)(flag ? 1 : 0))->m_value = false;
		if (((InAppManager)id.m_stringLength).RestoreNonConsumablePurchases((string[])(object)"video_reward_cooldowns", flag))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num = default;
			object obj = num + 16;
			obj = 44;
			string text = ((string)((bool*)(flag ? 1 : 0))->m_value).Substring(num);
			object obj2 = text + 12;
			object obj3 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				object obj4 = text + 16;
				object obj5 = obj3 << 2;
				object str = obj4 + obj5;
				string id2 = string.Copy((string)str);
				Cooldown data = ((Cooldowns)null).Get(id2);
				((LocalizedOnlineSettings)id.m_firstChar)._002Ector((OnlineSettingsData)(object)data);
				object obj6 = obj3 + 1;
				obj3 = obj6;
			}
		}
	}

	public unsafe static int GetChargesUsed(string id)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		string[] inAppBundleTiers = InAppData.GetInAppBundleTiers();
		bool flag = InAppData.TryConvertDynamicPurchaseIdToCharacterType((string)inAppBundleTiers.Length, out *(Characters.CharacterId*)id);
		if (flag)
		{
			return HasCharge((string)flag) ? 1 : 0;
		}
		return 0;
	}
}
