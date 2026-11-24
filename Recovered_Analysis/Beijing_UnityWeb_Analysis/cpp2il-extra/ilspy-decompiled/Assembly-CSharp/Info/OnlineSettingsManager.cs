using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Cpp2ILInjected;
using InApp;
using Info.Localization;
using Kiloo;
using Kiloo.Common.Backend;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Monetization.FlurryPlugin;
using UnityEngine;

namespace Info;

public static class OnlineSettingsManager
{
	private const string DEBUG_LOGS_TAG = "[OnlineSettingsManager]: ";

	private const string BASE_URL = "https://onlinesettings.kiloo-games.com/";

	private const string FILENAME = "settings";

	private static OnlineSettings<OnlineSettingsData> _onlineSettings;

	private static LocalizedOnlineSettings _localizedOnlineSettings;

	private static bool _initialized;

	private static string _filePath;

	public static Action onNewSettingsDownloaded;

	private static readonly Globals.BuildPurpose[] TEST_TIME_BUILDS_SUPPORTED;

	public static OnlineSettingsData data
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00aa: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string cachePath = DeviceUtility.GetCachePath();
			return (OnlineSettingsData)(object)string.ConcatArray((string[])(object)cachePath, (int)"/onlinesettings");
		}
	}

	public static LocalizedOnlineSettings localizedData
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettingsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			OnNewSettingsDownloaded();
			OnlineSettings<OnlineSettingsData> onlineSettings = _onlineSettings;
			OnlineSettings<OnlineSettingsData>.Data data = onlineSettings._data;
			return (LocalizedOnlineSettings)(object)data.data;
		}
	}

	public static void Initialize()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		char[] array = default;
		object obj = array + 16;
		obj = 10;
		object obj2 = array + 18;
		obj2 = 13;
		OnlineSettings.LINEBREAK_CHARS = array;
	}

	public unsafe static void DownloadNow()
	{
		//IL_066b: Expected I, but got Obj
		//IL_0681: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01b1: Expected I, but got Obj
		//IL_01c7: Expected Obj, but got I
		//IL_023f: Expected I, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_0272: Expected I, but got Obj
		//IL_01f2: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I
		//IL_0722: Expected Obj, but got I4
		//IL_028e: Expected I, but got Obj
		//IL_02be: Expected I, but got Obj
		//IL_032f: Expected I, but got Obj
		//IL_0345: Expected Obj, but got I
		//IL_02e4: Expected I, but got Obj
		//IL_0895: Expected I, but got Obj
		//IL_08ab: Expected Obj, but got I
		//IL_0370: Expected I, but got Obj
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0839: Expected Obj, but got I4
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_054d: Expected I, but got Obj
		//IL_03fe: Expected I, but got Obj
		//IL_0472: Expected I, but got Obj
		//IL_0488: Expected Obj, but got I
		//IL_07c3: Expected I, but got Obj
		//IL_07d9: Expected Obj, but got I
		//IL_04b3: Expected I, but got Obj
		//IL_0500: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v187 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v177 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnlineSettingsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v183 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Log("You are trying to manually initialize Online Settings, however they are already initialized.\nIf data is accessed previous to manual initialization, the class will be initialized lazily.");
			return;
		}
		nint num5 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v15 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v172 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		bool flag;
		if (cachePath == null || cachePath.m_stringLength == 0)
		{
			flag = false;
		}
		else
		{
			nint num7 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v157 (Il2CppClass<System.IO.Path>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v163 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			flag = Path.SameRoot(cachePath, "settings");
		}
		nint num9 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v24 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		bool flag2 = obj5 == null;
		nint num10 = (nint)typeof(OnlineSettingsManager);
		if (!flag2)
		{
			nint num11 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v150 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num10 = (nint)typeof(OnlineSettingsManager);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num10 = (nint)typeof(OnlineSettingsManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ L0_v8 (Il2CppClass<Info.OnlineSettingsManager>)+5C]");
		object obj6 = (nint)0 + (nint)12;
		obj6 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)"https://onlinesettings.kiloo-games.com/");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		OnlineSettings<OnlineSettingsData> onlineSettings = default;
		onlineSettings._002Ector(uri, _filePath, (IJsonSerializer)(object)text);
		_onlineSettings = onlineSettings;
		nint num12 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v48 (Il2CppClass<Globals>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v144 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_ONLINESETTINGS_SET ? 1u : 0u) == 0)
		{
			nint num14 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v96 (Il2CppClass<Globals>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num15 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v138 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string oNLINESETTINGS_SET = Globals.ONLINESETTINGS_SET;
			if (Globals.ONLINESETTINGS_SET != null && oNLINESETTINGS_SET.m_stringLength != 0)
			{
				nint num16 = (nint)typeof(OnlineSettingsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v106 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num17 = (nint)typeof(OnlineSettingsManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v128 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				OnlineSettings<OnlineSettingsData> onlineSettings2 = _onlineSettings;
				nint num18 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v117 (Il2CppClass<Globals>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num19 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v122 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
			}
		}
		nint num20 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v57 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num21 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v89 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)(delegate*<void>)(&OnNewSettingsDownloaded);
		object obj12 = action + 16;
		obj12 = 0;
		((OnlineSettings<>)(object)_onlineSettings).downloaded -= action;
		throw new NullReferenceException();
	}

	private static void CheckInitialization()
	{
		//IL_034b: Expected Obj, but got I4
		//IL_0359: Expected I, but got Obj
		//IL_036f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_03e2: Expected I, but got Obj
		//IL_03f8: Expected Obj, but got I
		//IL_04c7: Expected Obj, but got I4
		//IL_01bd: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0257: Expected I, but got Obj
		//IL_026d: Expected Obj, but got I
		//IL_042f: Expected Obj, but got VT
		//IL_043d: Expected I, but got Obj
		//IL_0453: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_02e5: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v115 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v109 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnlineSettings<OnlineSettingsData> onlineSettings = _onlineSettings;
		if (~(onlineSettings.isDownloading__BackingField ? 1u : 0u) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v32 (Il2CppClass<Globals>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v103 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG ? 1u : 0u) == 0)
		{
			nint num7 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v56 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(OnlineSettingsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v97 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v14 (Il2CppClass<Globals>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v30 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IOrderedEnumerable<_0021_00210> orderedEnumerable = (IOrderedEnumerable<_0021_00210>)Enumerable.OrderBy<TSource, TKey>((IEnumerable<TSource>)(object)TEST_TIME_BUILDS_SUPPORTED, (Func<TSource, TKey>)Globals.BUILD_PURPOSE);
			if (orderedEnumerable != null)
			{
				nint num11 = (nint)typeof(OnlineSettingsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v65 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num12 = (nint)typeof(OnlineSettingsManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v91 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				OnlineSettings<OnlineSettingsData> onlineSettings2 = _onlineSettings;
				DateTime today = CDateTime.Today;
				obj = today;
				nint num13 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v77 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num14 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v87 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				CultureInfo currentCulture = CultureInfo.CurrentCulture;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF9");
				WWW wWW = default;
				string error = wWW.error;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
		throw new NullReferenceException();
	}

	private static void OnNewSettingsDownloaded()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Log("OnlineSettings are not initialized but you are trying to access them. Initializing lazily.\nPlease avoid this scenario by explicitly using the Initialize() method.");
		DownloadNow();
	}

	private static void InitializeLocalizedSettings()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnlineSettingsManager._002Ecctor();
		if (onNewSettingsDownloaded != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[OnlineSettingsManager]: ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	static OnlineSettingsManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnlineSettings<OnlineSettingsData> onlineSettings = _onlineSettings;
		OnlineSettings<OnlineSettingsData>.Data data = onlineSettings._data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InAppItemModel inAppItemModel = default;
		inAppItemModel.localizedPrice = (string)(object)data.data;
		nint num3 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v21 (Il2CppClass<Info.OnlineSettingsManager>)+5C]");
		object obj2 = (nint)0 + (nint)4;
		obj2 = inAppItemModel;
	}
}
