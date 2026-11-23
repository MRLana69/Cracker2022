using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Utility;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class OnlineSettings
{
	private sealed class _003CDownloadCoroutine_003Ed__33(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineSettings _003C_003E4__this;

		private bool _003CdownloadSucceded_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01b5: Expected Ref, but got F8
			//IL_0231: Expected Obj, but got I4
			//IL_0215: Expected Obj, but got I4
			//IL_03a1: Expected I, but got Obj
			//IL_02c2: Expected Obj, but got I4
			//IL_02a6: Expected Obj, but got I4
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Expected VT, but got Unknown
			//IL_036d: Expected Ref, but got VT
			object obj2 = default;
			object obj = obj2 - 32;
			_ = 0;
			_ = 0;
			OnlineSettings onlineSettings = _003C_003E4__this;
			StringBuilder stringBuilder = default;
			string bundleVersion;
			object obj3;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0572;
				}
				_003C_003E1__state = -1;
				string error = _003Cwww_003E5__3.error;
				if (error != null)
				{
					string error2 = _003Cwww_003E5__3.error;
					string text = "OnlineSettings download failed: " + error2;
				}
				else
				{
					_003CdownloadSucceded_003E5__2 = true;
					string text2 = _003Cwww_003E5__3.text;
					if (text2.Contains("<html"))
					{
						string text3 = "OnlineSettings download failed: " + text2;
					}
					else
					{
						onlineSettings.SetCurrentChecksum(text2);
						if (ValidateChecksum(text2))
						{
							string text4 = _003Cwww_003E5__3.text;
							Dictionary<string, string> settings = StringUtility.ParseProperties(text4);
							onlineSettings._settings = settings;
							onlineSettings.SaveToFile();
						}
					}
				}
				Action<bool> onOnlineSettingsDownloadResult = onlineSettings.onOnlineSettingsDownloadResult;
				if (onlineSettings.onOnlineSettingsDownloadResult != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v212 @ S0_v148 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
				}
				_003Cwww_003E5__3 = null;
			}
			else
			{
				_003C_003E1__state = -1;
				if (~(Globals.DEBUG_USE_FAKE_ONLINE_SETTINGS ? 1u : 0u) != 0)
				{
					_003CdownloadSucceded_003E5__2 = false;
					object value = "http://10.0.0.169/hoodrunner";
					if (!Globals.DEBUG_OVERRIDE_ONLINE_SETTINGS_URL)
					{
						value = "http://hoodrunner.kiloo.com";
					}
					stringBuilder._002Ector((string)value);
					StringBuilder stringBuilder2 = stringBuilder.Append("/newonlinesettings.php");
					StringBuilder stringBuilder3 = stringBuilder.Append("?platform=");
					StringBuilder stringBuilder4 = stringBuilder3.Append("android");
					StringBuilder stringBuilder5 = stringBuilder.Append("&locale=");
					string locale = DeviceUtility.GetLocale();
					StringBuilder stringBuilder6 = stringBuilder5.Append(locale);
					DateTime now = CDateTime.Now;
					TimeSpan currentTimeZoneUTCOffset = TimeUtility.GetCurrentTimeZoneUTCOffset(now);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					double num = 0.0 * 2.7777777777777777E-11;
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					double num2 = (double)obj + 16.0;
					string value2 = ((double*)num2)->ToString("F2", invariantCulture);
					StringBuilder stringBuilder7 = stringBuilder.Append("&timezone=");
					StringBuilder stringBuilder8 = stringBuilder7.Append(value2);
					bundleVersion = DeviceUtility.GetBundleVersion();
					if (bundleVersion != null)
					{
						obj3 = 0;
						if (bundleVersion._stringLength != 0)
						{
							goto IL_05dd;
						}
					}
					obj3 = 1;
					goto IL_05dd;
				}
				Dictionary<string, string> settings2 = StringUtility.ParseProperties("efe40d19b11ddd485b4188664e9969f4bc89de0d\n[latestversion] 1.7.4\n[latestversion_changelist] \n\n\n* Subway Surfers in the Snow!\n* Limited Holiday character\n* Discover special Boards\n* Receive a free GIFT!\n* Optimized for iPhone 5!\n[in_app_tier_1] 2500\n[in_app_tier_2] 15000\n[in_app_tier_3] -40\n[in_app_tier_4] 250000\n[in_app_tier_5] -30\n[in_app_tier_6] -30\n[in_app_tier_7] -30\n[in_app_tier_8] -30\n[in_app_double_coins] -5\n[discount_end_time] 1496318400\n[videoads_providerlist] vungleclips\n[hoverboard_expiretime_liberty] 23-12-2012 22:00:00\n[hoverboard_starttime_liberty] 20-11-2012 22:00:00\n[character_expiretime_nychar] 23-12-2012 22:00:00\n[character_starttime_nychar] 13-10-2012 22:00:00\n[character_expiretime_elftricky] 23-11-2012 22:00:00\n[character_starttime_elftricky] 23-11-2012 22:00:00\n[enable_local_notifications] true[save_me_locales] en_US;en_UK;[offerwall_number_of_offers] 4[offerwall_session_timeout] 24[offerwall_offers_timeout] 24[offerwall_balance_timeout] 24[offerwal_min_reward_allowed] 10[offerwall_max_reward_allowed] 10000[offerwall_filter_free] true[save_me_locales] all[event_id]1496318400[event_value] 0;0[event_type] CharacterName[event_start] 1404694800[event_end] 1496318400[event_ribbon_text]ad3;3;6[number_of_fails_for_interstitial] 1[interstitials_limit_per_hour] 10[interstitials_limit_per_day] 40[intesrtitials_delay_seconds] 10[keys_rewarded_for_video_ad] 2[sybo_analytics_enabled] true[sybo_analytics_endpoint_baseurl] https://subwaysurf.dev.bladesofbrim.com[sybo_analytics_sampling_threshold] 1[sybo_analytics_max_games_without_flush] 1[sybo_analytics_games_in_session_before_first_flush] 1");
				onlineSettings._settings = settings2;
				onlineSettings.SaveToFile();
				Action<bool> onOnlineSettingsDownloadResult2 = onlineSettings.onOnlineSettingsDownloadResult;
				if (onlineSettings.onOnlineSettingsDownloadResult != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v132 @ S0_v138 (System.Action`1<System.Boolean>)+C] (should have been resolved before IL gen)");
				}
			}
			Action onFinishedDownloadingOnlineSettingsHandler = onlineSettings._onFinishedDownloadingOnlineSettingsHandler;
			if (onlineSettings._onFinishedDownloadingOnlineSettingsHandler != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			UnityEngine.Object.Destroy(onlineSettings._downloadGameObject);
			onlineSettings._downloadGameObject = null;
			onlineSettings._isDownloading = false;
			goto IL_0572;
			IL_05dd:
			if (obj3 == null)
			{
				StringBuilder stringBuilder9 = stringBuilder.Append("&version=");
				StringBuilder stringBuilder10 = stringBuilder9.Append(bundleVersion);
			}
			if (~(Globals.DEBUG_USE_ONLINESETTINGS_SET ? 1u : 0u) != 0)
			{
				goto IL_0302;
			}
			string oNLINESETTINGS_SET = Globals.ONLINESETTINGS_SET;
			object obj4;
			if (Globals.ONLINESETTINGS_SET != null)
			{
				obj4 = 0;
				if (oNLINESETTINGS_SET._stringLength != 0)
				{
					goto IL_0605;
				}
			}
			obj4 = 1;
			goto IL_0605;
			IL_0605:
			if (obj4 == null)
			{
				StringBuilder stringBuilder11 = stringBuilder.Append("&set=");
				string value3 = WWW.EscapeURL(Globals.ONLINESETTINGS_SET);
				StringBuilder stringBuilder12 = stringBuilder11.Append(value3);
			}
			goto IL_0302;
			IL_0302:
			if (~(Globals.DEBUG_USE_ONLINESETTINGS_TESTTIME ? 1u : 0u) == 0)
			{
				StringBuilder stringBuilder13 = stringBuilder.Append("&testtime=");
				DateTime utcNow = CDateTime.UtcNow;
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				DateTime dateTime = (DateTime)(obj + 8);
				string s = ((DateTime*)dateTime)->ToString("s", invariantCulture2);
				string value4 = WWW.EscapeURL(s);
				StringBuilder stringBuilder14 = stringBuilder13.Append(value4);
			}
			nint num3 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v394 @ S1_v45 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			WWW wWW = default;
			string url = default;
			wWW._002Ector(url);
			_003Cwww_003E5__3 = wWW;
			_003C_003E2__current = _003Cwww_003E5__3;
			_003C_003E1__state = 1;
			goto IL_0572;
			IL_0572:
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public const string DISABLED_SETTING = "disabled";

	private const string PLATFORM = "android";

	private const string URL = "/newonlinesettings.php";

	private static readonly char[] LINEBREAK_CHARS;

	private const string FILE_SECRET = "pdvshbhkndf92k19zvbckawd92fjk";

	private const int FILEFORMAT_VERSION = 1;

	private static OnlineSettings _instance;

	private Dictionary<string, string> _settings;

	private bool _isDownloading;

	private GameObject _downloadGameObject;

	private Action _onFinishedDownloadingOnlineSettingsHandler;

	public Action<bool> onOnlineSettingsDownloadResult;

	private string _checksumToShow;

	public static bool isInstanced => _instance != null;

	public static OnlineSettings instance
	{
		get
		{
			if (_instance == null)
			{
				OnlineSettings onlineSettings = default;
				onlineSettings._002Ector();
				_instance = onlineSettings;
			}
			return _instance;
		}
	}

	public bool isDownloading => _isDownloading;

	private OnlineSettings()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> settings = default;
		_settings = settings;
		LoadFromFile();
	}

	public void AddOnFinishedDownloadingOnlineSettingsHandler(Action handler)
	{
		Delegate obj = Delegate.Combine(_onFinishedDownloadingOnlineSettingsHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onFinishedDownloadingOnlineSettingsHandler = default;
		_onFinishedDownloadingOnlineSettingsHandler = onFinishedDownloadingOnlineSettingsHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void RemoveOnFinishedDownloadingOnlineSettingsHandler(Action handler)
	{
		Delegate obj = Delegate.Remove(_onFinishedDownloadingOnlineSettingsHandler, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		Action onFinishedDownloadingOnlineSettingsHandler = default;
		_onFinishedDownloadingOnlineSettingsHandler = onFinishedDownloadingOnlineSettingsHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
	}

	public void DownloadNow()
	{
		if (~(_isDownloading ? 1u : 0u) != 0)
		{
			if (_downloadGameObject != null)
			{
				UnityEngine.Object.Destroy(_downloadGameObject);
			}
			GameObject gameObject = default;
			gameObject._002Ector("OnlineSettingsDownloader");
			_downloadGameObject = gameObject;
			UnityEngine.Object.DontDestroyOnLoad(_downloadGameObject);
			NewMonoBehaviour newMonoBehaviour = _downloadGameObject.AddComponent<NewMonoBehaviour>();
			IEnumerator routine = DownloadCoroutine();
			Coroutine coroutine = newMonoBehaviour.StartCoroutine(routine);
		}
	}

	public unsafe double GetValue(string key, double defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Ref, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (!_settings.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_039a;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		double result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			double num = default;
			result = num;
			if (flag)
			{
				goto IL_03a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag2 = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text = "OnlineSettings.GetValue() " + key + " returns the defaultValue because send string was " + (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_039a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					if (flag3)
					{
						goto IL_03ac;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj15 = default;
			obj5 = obj15;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj5 = obj15;
			}
		}
		goto IL_03ac;
		IL_03ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_039a;
		IL_03a7:
		return result;
		IL_039a:
		result = defaultValue;
		goto IL_03a7;
	}

	public unsafe float GetValue(string key, float defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Ref, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (!_settings.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_039a;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		float result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			float num = default;
			result = num;
			if (flag)
			{
				goto IL_03a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag2 = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text = "OnlineSettings.GetValue() " + key + " returns the defaultValue because send string was " + (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_039a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					if (flag3)
					{
						goto IL_03ac;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj15 = default;
			obj5 = obj15;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj5 = obj15;
			}
		}
		goto IL_03ac;
		IL_03ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_039a;
		IL_03a7:
		return result;
		IL_039a:
		result = defaultValue;
		goto IL_03a7;
	}

	public unsafe int GetValue(string key, int defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Ref, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (!_settings.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_039a;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		int result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			int num = default;
			result = num;
			if (flag)
			{
				goto IL_03a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag2 = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text = "OnlineSettings.GetValue() " + key + " returns the defaultValue because send string was " + (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_039a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					if (flag3)
					{
						goto IL_03ac;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj15 = default;
			obj5 = obj15;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj5 = obj15;
			}
		}
		goto IL_03ac;
		IL_03ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_039a;
		IL_03a7:
		return result;
		IL_039a:
		result = defaultValue;
		goto IL_03a7;
	}

	public unsafe uint GetValue(string key, uint defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected Ref, but got Unknown
		//IL_029e: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (!_settings.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_038b;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		uint result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			uint num = default;
			result = num;
			if (flag)
			{
				goto IL_0398;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag2 = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text = "OnlineSettings.GetValue() " + key + " returns the defaultValue because send string was " + (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_038b;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					if (flag3)
					{
						goto IL_039d;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj15 = default;
			obj5 = obj15;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj5 = obj15;
			}
		}
		goto IL_039d;
		IL_039d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_038b;
		IL_0398:
		return result;
		IL_038b:
		result = defaultValue;
		goto IL_0398;
	}

	public unsafe string GetValue(string key, string defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Ref, but got Unknown
		//IL_005b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = _settings.TryGetValue(key, out *(string*)(obj + 12));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		string result = (string)0;
		if (!flag)
		{
			result = defaultValue;
		}
		return result;
	}

	public unsafe bool GetValue(string key, bool defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Ref, but got Unknown
		//IL_02ad: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_01eb: Expected Obj, but got I
		//IL_021e: Expected Obj, but got I
		//IL_024c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (!_settings.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_039a;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag = (nint)0 != 1;
			bool flag2 = default;
			result = flag2;
			if (flag)
			{
				goto IL_03a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj3 = default;
		object obj4 = default;
		bool flag3 = obj3 != obj4;
		object obj6 = default;
		object obj5 = obj6;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj8 = default;
				object obj7 = obj8;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj9 = default;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj10 = (nint)0 << 2;
						object obj11 = obj + obj10;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj12 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text = "OnlineSettings.GetValue() " + key + " returns the defaultValue because send string was " + (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = -1;
						goto IL_039a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj14 = obj8;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag4 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj5 = 0;
					if (flag4)
					{
						goto IL_03ac;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag5 = (nint)0 != 1;
			object obj15 = default;
			obj5 = obj15;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj5 = obj15;
			}
		}
		goto IL_03ac;
		IL_03ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_039a;
		IL_03a7:
		return result;
		IL_039a:
		result = defaultValue;
		goto IL_03a7;
	}

	public bool TryGetValue(string key, out string valueString)
	{
		return _settings.TryGetValue(key, out valueString);
	}

	public bool HasValue(string key)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public string GetCurrentPlatform()
	{
		return "android";
	}

	public string GetChecksumToShow()
	{
		return _checksumToShow;
	}

	private IEnumerator DownloadCoroutine()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void SetCurrentChecksum(string response)
	{
		int num = response.IndexOfAny(LINEBREAK_CHARS);
		if (num >= 1)
		{
			string checksumToShow = response.Substring(0, num);
			_checksumToShow = checksumToShow;
		}
		else
		{
			_checksumToShow = null;
		}
	}

	private static bool ValidateChecksum(string response)
	{
		bool result = true;
		if (!Globals.DEBUG_USE_FAKE_ONLINE_SETTINGS)
		{
			int num = response.IndexOfAny(LINEBREAK_CHARS);
			if (num >= 1)
			{
				string strA = response.Substring(0, num);
				int startIndex = num + 1;
				string text = response.Substring(startIndex);
				string text2 = text.Trim();
				string data = text2 + "resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg";
				byte[] bytes = Checksum.ComputeSHA1(data);
				string strB = StringUtility.ToHexString(bytes);
				int num2 = string.Compare(strA, strB, StringComparison.InvariantCultureIgnoreCase);
				bool flag = num2 == 0;
				result = true;
				if (flag)
				{
					goto IL_0131;
				}
			}
			result = false;
		}
		goto IL_0131;
		IL_0131:
		return result;
	}

	private void LoadFromFile()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected Obj, but got Unknown
		//IL_05b0: Expected Obj, but got I
		//IL_05db: Expected Obj, but got I
		//IL_0600: Expected Obj, but got I
		//IL_04ec: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											Dictionary<string, string> settings = default;
											_settings = settings;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												return;
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									goto IL_02aa;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_02aa;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		goto IL_02aa;
		IL_059a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ L1_v3+4]");
		object obj4 = (nint)0 << 2;
		object obj6;
		object obj5 = obj6 + obj4;
		object obj7;
		obj5 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ L1_v3+4]");
		object obj8 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ L1_v3+4]");
		object obj9 = -1;
		return;
		IL_02aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj10 = default;
		object obj11 = default;
		bool flag = obj10 == obj11;
		bool flag2 = !flag;
		obj6 = obj3;
		object obj12 = default;
		obj7 = obj12;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj14 = default;
				object obj13 = obj14;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					obj6 = obj3;
					obj7 = obj14;
					object obj15 = default;
					if (obj15 != null)
					{
						goto IL_059a;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj16 = obj14;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							obj6 = obj3;
							obj7 = obj14;
							object obj17 = default;
							if (obj17 != null)
							{
								goto IL_059a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj18 = obj14;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								return;
							}
						}
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj6 = 0;
			object obj19 = default;
			obj7 = obj19;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_059a;
	}

	private void SaveToFile()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0559: Expected Obj, but got I
		//IL_0417: Expected Obj, but got I
		//IL_0442: Expected Obj, but got I
		//IL_0467: Expected Obj, but got I
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_04f8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3DE");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 == 1)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														goto IL_0317;
													}
													return;
												}
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									goto IL_0317;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						goto IL_0317;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0317;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0317;
		IL_0317:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag = obj4 != obj5;
		object obj7 = default;
		object obj6 = obj7;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj9 = default;
				object obj8 = obj9;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj10 = default;
					if (obj10 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj11 = (nint)0 << 2;
						object obj12 = obj3 + obj11;
						obj12 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj13 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 << 2;
						object obj15 = obj14 + obj3;
						object obj16 = obj15 - 4;
						object obj17 = obj16;
						bool flag2 = obj16 == null;
						string text = null;
						string text2 = "Failed to save OnlineSettings to file: ";
						if (!flag2)
						{
							object obj18 = obj17;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v426 @ S1_v53+D4] (should have been resolved before IL gen)");
							string text3 = default;
							text = text3;
							text2 = "Failed to save OnlineSettings to file: ";
						}
						string text4 = text2 + text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj19 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj20 = obj9;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj6 = 0;
					if (flag3)
					{
						goto IL_064c;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			object obj21 = default;
			obj6 = obj21;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj6 = obj21;
			}
		}
		goto IL_064c;
		IL_064c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private static string GetSaveDataPath()
	{
		string userDataPath = DeviceUtility.GetUserDataPath();
		return userDataPath + "/onlinesettings";
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static OnlineSettings()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		char[] array = default;
		array[0] = '\n';
		array[1] = '\r';
		LINEBREAK_CHARS = array;
	}
}
