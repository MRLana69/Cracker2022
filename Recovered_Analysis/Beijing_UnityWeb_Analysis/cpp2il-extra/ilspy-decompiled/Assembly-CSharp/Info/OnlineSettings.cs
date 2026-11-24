using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using SYBO.Common.Data;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UnityEngine;

namespace Info;

public class OnlineSettings
{
	private sealed class _003CDownloadCoroutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineSettings _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0050: Expected I, but got Obj
				//IL_0066: Expected Obj, but got I
				//IL_0503: Unknown result type (might be due to invalid IL or missing references)
				//IL_0508: Expected Obj, but got Unknown
				//IL_0091: Expected I, but got Obj
				//IL_0451: Expected I, but got Obj
				//IL_0467: Expected Obj, but got I
				//IL_01dd: Expected I, but got Obj
				//IL_01f3: Expected Obj, but got I
				//IL_05ff: Expected Obj, but got I4
				//IL_0608: Unknown result type (might be due to invalid IL or missing references)
				//IL_060d: Expected Obj, but got Unknown
				//IL_0616: Expected Obj, but got I4
				//IL_0492: Expected I, but got Obj
				//IL_0318: Expected I, but got Obj
				//IL_032e: Expected Obj, but got I
				//IL_021e: Expected I, but got Obj
				//IL_0145: Expected I, but got Obj
				//IL_015b: Expected Obj, but got I
				//IL_05ce: Expected I4, but got Obj
				//IL_026b: Expected I4, but got Obj
				//IL_027d: Expected I, but got Obj
				//IL_0293: Expected Obj, but got I
				//IL_0359: Expected I, but got Obj
				//IL_0186: Expected I, but got Obj
				//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a6: Expected Obj, but got Unknown
				//IL_02be: Expected I, but got Obj
				OnlineSettings onlineSettings = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						goto IL_05ef;
					}
					_003C_003E1__state = -1;
					bool obj2;
					if (((WWW)null).isDone)
					{
						bool isDone = ((WWW)null).isDone;
						string text = string.ConcatArray((string[])(object)"OnlineSettings download failed: ", isDone ? 1 : 0);
						nint num = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v96 (Il2CppClass<Info.OnlineSettings>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v101 (Il2CppClass<Info.OnlineSettings>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj2 = false;
					}
					else
					{
						Texture2D texture = ((WWW)null).texture;
						nint num3 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v56 (Il2CppClass<UnityEngine.Debug>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num4 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v86 (Il2CppClass<UnityEngine.Debug>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Debug.LogError(texture);
						if (((string)(object)texture).EndsWith("<html"))
						{
							string text2 = string.ConcatArray((string[])(object)"OnlineSettings download failed: ", (int)texture);
							nint num5 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v49 (Il2CppClass<Info.OnlineSettings>)+BA]");
							object obj4 = (nint)0 & (nint)0x200;
							if (obj4 != null)
							{
								nint num6 = (nint)typeof(OnlineSettings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v54 (Il2CppClass<Info.OnlineSettings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
							obj2 = true;
						}
						else
						{
							LogError((string)(object)onlineSettings, texture);
							nint num7 = (nint)typeof(OnlineSettings);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v65 (Il2CppClass<Info.OnlineSettings>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num8 = (nint)typeof(OnlineSettings);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v78 (Il2CppClass<Info.OnlineSettings>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							List<Outfit> list = Outfits.TryGetOutfitsForCharacter((Characters.CharacterId)texture);
							if (list != null)
							{
								object obj6 = onlineSettings + 8;
								Texture2D texture2 = ((WWW)null).texture;
								string text3 = Kiloo.Common.Utility.StringUtility.FormatProperties((Dictionary<string, string>)(object)texture2);
								obj6 = text3;
								((OnlineSettingsData)(object)onlineSettings)._002Ector();
							}
							else
							{
								SDebug.LogFormat("OnlineSettings checksum verification failed", null);
							}
							obj2 = true;
						}
					}
					if (((OnlineSettingsData)(object)onlineSettings).bundlesEnabledLocales != null)
					{
						((OnlineSettingsData)(object)onlineSettings).bundlesEnabledLocales(obj2);
					}
				}
				else
				{
					_003C_003E1__state = -1;
					((OnlineSettingsData)(object)onlineSettings).mysteryBoxDoubleRewardAllowKeys = true;
					nint num9 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v25 (Il2CppClass<Globals>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num10 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v39 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj8 = onlineSettings + 8;
					string text4 = Kiloo.Common.Utility.StringUtility.FormatProperties((Dictionary<string, string>)(object)"efe40d19b11ddd485b4188664e9969f4bc89de0d\n[latestversion] 1.7.4\n[latestversion_changelist] \n\n\n* Subway Surfers in the Snow!\n* Limited Holiday character\n* Discover special Boards\n* Receive a free GIFT!\n* Optimized for iPhone 5!\n[in_app_tier_1] 2500\n[in_app_tier_2] 15000\n[in_app_tier_3] -40\n[in_app_tier_4] 250000\n[in_app_tier_5] -30\n[in_app_tier_6] -30\n[in_app_tier_7] -30\n[in_app_tier_8] -30\n[in_app_double_coins] -5\n[discount_end_time] 1496318400\n[videoads_providerlist] vungleclips\n[hoverboard_expiretime_liberty] 23-12-2012 22:00:00\n[hoverboard_starttime_liberty] 20-11-2012 22:00:00\n[character_expiretime_nychar] 23-12-2012 22:00:00\n[character_starttime_nychar] 13-10-2012 22:00:00\n[character_expiretime_elftricky] 23-11-2012 22:00:00\n[character_starttime_elftricky] 23-11-2012 22:00:00\n[enable_local_notifications] true[save_me_locales] en_US;en_UK;[offerwall_number_of_offers] 4[offerwall_session_timeout] 24[offerwall_offers_timeout] 24[offerwall_balance_timeout] 24[offerwal_min_reward_allowed] 10[offerwall_max_reward_allowed] 10000[offerwall_filter_free] true[save_me_locales] all[event_id]1496318400[event_value] 0;0[event_type] CharacterName[event_start] 1404694800[event_end] 1496318400[event_ribbon_text]ad3;3;6[number_of_fails_for_interstitial] 1[interstitials_limit_per_hour] 10[interstitials_limit_per_day] 40[intesrtitials_delay_seconds] 10[keys_rewarded_for_video_ad] 2[sybo_analytics_enabled] true[sybo_analytics_endpoint_baseurl] https://subwaysurf.dev.bladesofbrim.com[sybo_analytics_sampling_threshold] 1[sybo_analytics_max_games_without_flush] 1[sybo_analytics_games_in_session_before_first_flush] 1[home_interstitials_list] supersonic:1_100,inmobi:2_100,chartboost:3_100,supersonic:4_100,facebook:5_100[home_videos_list] supersonic:1_100,adcolony:2_100,tapjoy:3_100,inmobi:4_100,flurry:5_100,chartboost:7_100[default_interstitial_list] supersonic:1_100,inmobi:2_100,chartboost:3_100,supersonic:4_100,facebook:5_100[default_video_list] supersonic:1_100,adcolony:2_100,tapjoy:3_100,inmobi:4_100,flurry:5_100,chartboost:7_100[ad_location_home_videos_enabled] true[ad_location_earn_coins_videos_enabled] true[ad_location_double_up_videos_enabled] true[ad_location_home_interstitials_enabled] true[ad_location_game_over_interstitials_enabled] true[loadscreen_allow_usertips] true[loadscreen_title] Player Tip[loadscreen_usertip_list]Abdennor, Mascara, Algeria;Earn Coins for your Facebook friends by making multiple runs!/Bayezed, Dhaka, Bangladesh;Activate your Hoverboard when you see obstacles in front of you and don't know what to do!/Jonathan, Sarawak, Malaysia;Play the Wordy Weekend event to unlock limited Characters!/Tyler, Rhode Island, USA;If you keep opening Mystery Boxes you might win the grand prize!/Amber, Cambridge, England;Complete the Weekly Hunt to win cool prizes!/Lukas, Copenhagen, Denmark;Double tap to activate your Hoverboards!/Ahmad, Selangor, Malaysia;Login to Facebook to earn more rewards!/Mikael, Kumasi, Ghana;Use Hoverboards to survive a crash!/Daniel, Vicensa, Italy;Remember to Double Up your items whenever possible!/Amar, Gothenburg, Sweden;Use Trains and other objects to stay as high in the air as possible!/Roberto, Knokke, Belgium;Try to stay as high in the air as possible!/Cooper, Dubbo, Australia;Use Hoverboards! If things get too hectic an explosion will clear the stage!/Meighan, Alberta, Canada;Super Jump with Hoverboards and Super Sneakers to get over the Trains!/Mostafa, Alexandria, Egypt;Invite your friends to play Subway Surfers for more fun!/Eelis, Hämeenlinna, Finland;Try to be on the roof of every Train as long as possible!/Amber, Cambridge, England;Use the Power Jumper to jump up onto the tunnels!/Thomas, Colorado, USA;Fully upgrade the Freestyler Board to get both Double Jump and Super Jump!/Musthapa, Sarawak, Malaysia;With the upgraded Monster board you can jump over the Trains, and it is also really fast!/Lasse, Birkelse, Denmark;Some Hoverboards have upgrades that make them faster!/Mansoor, Sindh, Pakistan;Open more Mystery Boxes in the Terrific Tuesday event and win mega prizes!/Sunil, Mumbai, India;Use the Bouncer board to pick up Coins from below!/Fakhry, Victoria, Malaysia;Get the Bouncer board to enjoy Super Sneakers and Hoverboard features at the same time!/Joshua, Maine, USA;You can cancel jumps by rolling in mid air!/Joshua, Maine, USA;You can hop on barriers to get onto trains!/Rachel, Ho Chi Minh City, Vietnam;To collect the High Jumper Awards get help from the Bouncer board!/Salman, Hyderabad, India;Don't forget the Daily Challenge! It rewards Super Mystery Boxes!/Liliane, Yaoundé, Cameroun;Earn Awards to get more Keys!");
					obj8 = text4;
					((OnlineSettingsData)(object)onlineSettings)._002Ector();
					if (((OnlineSettingsData)(object)onlineSettings).bundlesEnabledLocales != null)
					{
						((OnlineSettingsData)(object)onlineSettings).bundlesEnabledLocales(obj: true);
					}
				}
				if (((OnlineSettingsData)(object)onlineSettings).saveMeLocales != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)((OnlineSettingsData)(object)onlineSettings).chartboostDelaySeconds);
				object obj10 = onlineSettings + 16;
				obj10 = 0;
				((OnlineSettingsData)(object)onlineSettings).mysteryBoxDoubleRewardAllowKeys = false;
				goto IL_05ef;
				IL_05ef:
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDownloadCoroutine_003Ed__36(int _003C_003E1__state)
		{
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_017a: Expected Obj, but got I4
			//IL_018d: Expected Obj, but got I4
			//IL_002c: Expected I, but got Obj
			//IL_0042: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_0125: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (!obj3.System_002EIConvertible_002EToBoolean(provider))
			{
				return;
			}
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v38 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int userAge = AgeRestriction.GetUserAge();
			bool userAgeRegistered = AgeRestriction.IsConsentGiven();
			AgeRestriction._userAgeRegistered = userAgeRegistered;
			int userAge2 = AgeRestriction.GetUserAge();
			if ((userAge ^ userAge2) == 0)
			{
				return;
			}
			nint num3 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v25 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v32 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TransformExtensions.Reset((Transform)(object)AgeRestriction.restrictionChanged);
		}

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Expected I4, but got Unknown
			//IL_0191: Expected Obj, but got I4
			//IL_01a1: Expected Obj, but got I
			//IL_003d: Expected I, but got Obj
			//IL_0053: Expected Obj, but got I
			//IL_01f6: Expected Obj, but got I
			//IL_007e: Expected I, but got Obj
			//IL_0132: Expected I4, but got Obj
			//IL_0140: Expected Obj, but got I4
			//IL_0152: Expected I4, but got Obj
			IFormatProvider formatProvider = default;
			bool flag = (byte)(formatProvider + 4) != 0;
			((bool*)(flag ? 1 : 0))->m_value = false;
			formatProvider = (IFormatProvider)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings+<DownloadCoroutine>d__36)+2C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings+<DownloadCoroutine>d__36)+2C]");
			bool flag2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				nint num = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v21 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v38 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = GetSaveDataPath();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings+<DownloadCoroutine>d__36)+2C]");
				if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])0, flag))
				{
					if ((((bool*)(flag ? 1 : 0))->m_value ? ((int*)1) : ((int*)null))->System_002EIConvertible_002EToBoolean(formatProvider))
					{
						if ((nint)formatProvider >= 1)
						{
							return (byte)(int)formatProvider != 0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings+<DownloadCoroutine>d__36)+2C]");
						int num3 = "EarnCurrencyProfile ERROR: Unable to parse int from onlinesetting ".IndexOf('\0', (int)": ", ((bool*)(flag ? 1 : 0))->m_value ? 1 : 0);
						SDebug.LogFormat((string)num3, null);
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings+<DownloadCoroutine>d__36)+14]");
			return false;
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

	public const string DISABLED_SETTING = "disabled";

	private const string PLATFORM = "WebGL";

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

	public Dictionary<string, string> rawSettings
	{
		get
		{
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Expected Obj, but got Unknown
			//IL_003f: Expected I, but got Obj
			//IL_0055: Expected Obj, but got I
			//IL_0080: Expected I, but got Obj
			//IL_00e6: Expected I, but got Obj
			//IL_00fc: Expected Obj, but got I
			//IL_0174: Expected I, but got Obj
			//IL_018a: Expected Obj, but got I
			//IL_0127: Expected I, but got Obj
			//IL_01b5: Expected I, but got Obj
			object obj = _settings - 3;
			if ((nint)_settings != 3)
			{
				if ((nint)obj == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A23B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A235");
					nint num = (nint)typeof(ItemInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v5 (Il2CppClass<Info.ItemInfo>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(ItemInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v10 (Il2CppClass<Info.ItemInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Boards.BoardId boardId = default;
					HoverboardThemes.HoverboardTheme boardTheme = default;
					return (Dictionary<string, string>)(object)ItemInfo.GetItemTitleId(boardId, boardTheme);
				}
				nint num3 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v19 (Il2CppClass<Info.ItemInfo>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(ItemInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v24 (Il2CppClass<Info.ItemInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (Dictionary<string, string>)(object)ItemInfo.GetItemTitleId((InAppItemModel.BundleItem)(object)_settings);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A23B");
			nint num5 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v6 (Il2CppClass<Info.ItemInfo>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(ItemInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v11 (Il2CppClass<Info.ItemInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppItemModel.ItemType itemType = default;
			return (Dictionary<string, string>)(object)ItemInfo.GetItemTitleId(itemType);
		}
	}

	public unsafe static bool isInstanced
	{
		get
		{
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected Obj, but got Unknown
			//IL_0347: Expected Obj, but got I4
			//IL_0355: Expected I, but got Obj
			//IL_036b: Expected Obj, but got I
			//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Expected Obj, but got Unknown
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e5: Expected VT, but got Unknown
			//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Expected Obj, but got Unknown
			//IL_0077: Expected I, but got Obj
			//IL_008d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_039b: Expected I, but got Obj
			//IL_03b1: Expected Obj, but got I
			//IL_051d: Expected Obj, but got VT
			//IL_0526: Expected Obj, but got VT
			//IL_0533: Expected I8, but got Obj
			//IL_052e: Expected native int or pointer, but got VT
			//IL_0548: Expected Ref, but got VT
			//IL_0554: Expected Obj, but got I8
			//IL_0562: Expected I, but got Obj
			//IL_0578: Expected Obj, but got I
			//IL_00b8: Expected I, but got Obj
			//IL_03fc: Expected I, but got Obj
			//IL_0412: Expected Obj, but got I
			//IL_0105: Expected I, but got Obj
			//IL_0152: Expected I, but got Obj
			//IL_020e: Expected I, but got Obj
			//IL_0224: Expected Obj, but got I
			//IL_019f: Expected I, but got Obj
			//IL_024f: Expected I, but got Obj
			//IL_0297: Expected F8, but got I4
			//IL_02d4: Expected F8, but got I4
			//IL_0494: Invalid comparison between F8 and I4
			//IL_0311: Expected F8, but got I4
			//IL_04bb: Invalid comparison between F8 and I4
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v99 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IFormatProvider formatProvider = (IFormatProvider)(obj2 + 32);
			DateTime dateTime = (DateTime)(obj2 + 24);
			object obj4 = obj2 + 8;
			if (AgeRestriction.waitForAgeRestriction)
			{
				return false;
			}
			DateTime utcNow = CDateTime.UtcNow;
			nint num3 = (nint)typeof(FacebookRewardsInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v27 (Il2CppClass<Info.FacebookRewardsInfo>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(FacebookRewardsInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v92 (Il2CppClass<Info.FacebookRewardsInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v35 (Il2CppClass<System.DateTime>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v88 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = utcNow;
			obj2 = FacebookRewardsInfo.connectPopupLastShownOnFriendsScreen;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
			formatProvider = (IFormatProvider)obj2;
			long num7 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj = num7;
			nint num8 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v45 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num9 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v84 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue(FacebookRewardsInfo.FACEBOOK_REWARD_TIME_LIMIT_KEY, (uint)FacebookRewardsInfo.POPUP_DISPLAY_TIME_LIMIT);
			nint num10 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v53 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num11 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v80 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UserSave.allAssetBundlesDownloaded)
			{
				return false;
			}
			double num12 = (double)obj * 1E-07;
			nint num13 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v63 (Il2CppClass<System.Math>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num14 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v75 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			double num15;
			if (num12 != num12)
			{
				num15 = -2147483648.0;
			}
			else if (num12 < 2147483648.0)
			{
				num15 = ((num12 > -2147483649.0) ? num12 : (-2147483648.0));
			}
			else
			{
				num15 = -2147483648.0;
			}
			double num16 = 0.0 - num15;
			if (num15 > -1.0)
			{
				num16 = num15;
			}
			return !(num16 < (double)(int)value);
		}
	}

	public static OnlineSettings instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _instance != null;
			return (OnlineSettings)flag;
		}
	}

	public bool isDownloading
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_settings != 0;
		}
	}

	public void AddOnFinishedDownloadingOnlineSettingsHandler(Action handler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_0438: Expected Obj, but got I4
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_0472: Expected Obj, but got I4
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_049c: Expected I, but got Obj
		//IL_04b2: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_0257: Expected Obj, but got I4
		//IL_02be: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_0377: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_00f2: Expected I, but got Obj
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_020a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 + 40;
		obj6 = obj;
		_ = -1;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v164 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
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
		object obj8 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v114 (Il2CppClass<Strings>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num4 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v157 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					object obj11 = obj6 + 4;
					object obj12 = obj11 + 1;
					obj11 = obj12;
					object obj13 = obj12 << 2;
					object obj14 = obj6 + obj13;
					obj14 = 96;
					break;
				}
				continue;
			}
			object obj15 = obj6 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj6 + obj17;
			obj18 = 86;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		OnlineSettings onlineSettings;
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj6 + obj19;
			if ((nint)obj20 == 96)
			{
				object obj21 = obj6 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				onlineSettings = (OnlineSettings)obj2;
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj6 + obj23;
			if ((nint)obj24 == 86)
			{
				object obj25 = obj6 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_05a6;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05a6;
		IL_05a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		onlineSettings = (OnlineSettings)obj5;
	}

	public void RemoveOnFinishedDownloadingOnlineSettingsHandler(Action handler)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 20;
		Delegate obj2 = ((Delegate)_onFinishedDownloadingOnlineSettingsHandler).CombineImpl((Delegate)handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj3 = default;
		obj = obj3;
	}

	private OnlineSettings()
	{
	}

	public void DownloadNow()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
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
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
		SaveToFile();
	}

	public double GetValue(string key, double defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0212: Expected I4, but got Obj
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = ((List<object>)this).get_Item((int)key);
		object obj4;
		if (obj3 == null)
		{
			obj4 = null;
		}
		else
		{
			obj4 = (((object)obj3.GetType() != typeof(double)) ? null : obj3);
		}
		if (obj4 != null)
		{
			throw new NullReferenceException();
		}
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23 (Il2CppClass<System.Convert>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v73 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj7 = default;
		object obj6 = obj7;
		object obj9 = default;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj10 = default;
		if (obj8 == obj10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj12 = default;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj14 = default;
			object obj13 = obj14;
		}
		else
		{
			object obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		double result = default;
		return result;
	}

	public float GetValue(string key, float defaultValue)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_002b: Invalid comparison between I and F4
		//IL_00b9: Expected Obj, but got I4
		//IL_00db: Expected F4, but got Obj
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings)+20]");
		object obj = 0 + defaultValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings)+20]");
		if (0f > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings)+20]");
			if (0 >= (nint)onOnlineSettingsDownloadResult)
			{
				_ = 0f;
				ScoreMultiplier.ValueChangedEventArgs valueChangedEventArgs = (ScoreMultiplier.ValueChangedEventArgs)(_downloadGameObject + 1);
				((ScoreMultiplier)this).RaiseOnValueChanged(valueChangedEventArgs);
				((ScoreMultiplier)this).StopCoolDownCoroutine();
			}
		}
		object obj2 = (_isDownloading ? 1 : 0) + 16;
		object obj3 = (object)_downloadGameObject << 2;
		object obj4 = obj2 + obj3;
		return (float)obj4;
	}

	public int GetValue(string key, int defaultValue)
	{
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_045e: Expected Obj, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_04a2: Expected I, but got Obj
		//IL_04b8: Expected Obj, but got I
		//IL_0325: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_03c7: Expected I, but got Obj
		//IL_03dd: Expected Obj, but got I
		//IL_036c: Expected I, but got Obj
		//IL_04ea: Expected I4, but got Obj
		//IL_034f: Expected Obj, but got I
		//IL_0408: Expected I, but got Obj
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		object obj3 = key - 2;
		if ((nint)key != 2)
		{
			if ((nint)obj3 == 1)
			{
				goto IL_021e;
			}
			if ((nint)obj3 != 2)
			{
				if ((nint)obj3 == 3 || (nint)obj3 == 4 || (nint)obj3 == 5 || (nint)obj3 == 6 || (nint)obj3 == 7 || (nint)obj3 == 8 || (nint)obj3 == 9 || (nint)obj3 == 10 || (nint)obj3 == 11 || (nint)obj3 == 12 || (nint)obj3 == 13 || (nint)obj3 != 14)
				{
					goto IL_021e;
				}
				object obj4 = _onFinishedDownloadingOnlineSettingsHandler + 8;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v50+8]");
				_ = 0;
			}
			else
			{
				object obj5 = _onFinishedDownloadingOnlineSettingsHandler + 32;
				obj2 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v44+8]");
				_ = 0;
			}
		}
		else
		{
			object obj6 = _onFinishedDownloadingOnlineSettingsHandler + 20;
			obj2 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v34+8]");
			_ = 0;
		}
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = defaultValue - 1;
		UnityEngine.Object obj8;
		if (defaultValue != 1)
		{
			if ((nint)obj7 != 1)
			{
				if ((nint)obj7 == 2)
				{
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					obj8 = (UnityEngine.Object)0;
				}
				else
				{
					obj8 = null;
				}
			}
			else
			{
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				obj8 = (UnityEngine.Object)0;
			}
		}
		else
		{
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			obj8 = (UnityEngine.Object)obj2;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (obj8 != null)
		{
			return 0;
		}
		nint num3 = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v28 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v34 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)obj8);
		return (int)prefabPool;
		IL_021e:
		obj2 = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string msg = "No logic defined for environment type " + text;
		SDebug.LogFormat(msg, null);
		return 0;
	}

	public unsafe uint GetValue(string key, uint defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		ref string reference = ref *(string*)(obj2 + 8);
		reference = ref *(string*)null;
		obj2 = obj;
		_ = -1;
		if (_settings.TryGetValue(key, out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj3 = default;
			object obj4 = default;
			if (obj3 == obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj6 = default;
				object obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj8 = default;
				object obj7 = obj8;
			}
			else
			{
				object obj9 = default;
				object obj7 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			uint result = default;
			return result;
		}
		return defaultValue;
	}

	public unsafe string GetValue(string key, string defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		ref string reference = ref *(string*)(obj2 + 8);
		reference = ref *(string*)null;
		obj2 = obj;
		_ = -1;
		if (_settings.TryGetValue(key, out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj3 = default;
			object obj4 = default;
			if (obj3 == obj4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj6 = default;
				object obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj8 = default;
				object obj7 = obj8;
			}
			else
			{
				object obj9 = default;
				object obj7 = obj9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			string result = default;
			return result;
		}
		return defaultValue;
	}

	public unsafe bool GetValue(string key, bool defaultValue)
	{
		//IL_000e: Expected I4, but got Obj
		ref string reference = ref *(string*)null;
		if (_settings.TryGetValue(key, out reference))
		{
			return (byte)(int)reference != 0;
		}
		return defaultValue;
	}

	public unsafe bool TryGetValue(string key, out string valueString)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected Ref, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		ref string reference = ref *(string*)(obj2 + 8);
		reference = ref *(string*)null;
		obj2 = obj;
		_ = -1;
		ref string reference2 = default;
		if (_settings.TryGetValue(key, out reference))
		{
			nint num = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v25 (Il2CppClass<System.Boolean>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(bool);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v81 (Il2CppClass<System.Boolean>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj5 = default;
			object obj4 = obj5;
			object obj7 = default;
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj8 = default;
			if (obj6 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj12 = default;
				object obj11 = obj12;
			}
			else
			{
				object obj11 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		else
		{
			reference2 = ref valueString;
		}
		return (byte)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) != 0;
	}

	public unsafe bool HasValue(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected I, but got Unknown
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0908: Expected Obj, but got I4
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected Obj, but got Unknown
		//IL_091f: Expected Obj, but got I4
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected Obj, but got Unknown
		//IL_0831: Expected I, but got Obj
		//IL_0847: Expected Obj, but got I
		//IL_0aa8: Expected I, but got Obj
		//IL_0872: Expected I, but got Obj
		//IL_0048: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_01b8: Expected Obj, but got I
		//IL_01e3: Expected I, but got Obj
		//IL_0308: Expected I, but got Obj
		//IL_031e: Expected Obj, but got I
		//IL_07ac: Expected I4, but got Obj
		//IL_07ac: Expected I4, but got Obj
		//IL_0349: Expected I, but got Obj
		//IL_07d2: Expected I, but got Obj
		//IL_054c: Expected I, but got Obj
		//IL_0562: Expected Obj, but got I
		//IL_058d: Expected I, but got Obj
		//IL_046e: Expected I, but got Obj
		//IL_0484: Expected Obj, but got I
		//IL_04af: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		nint num = (nint)(obj2 + 24);
		object obj3 = obj2 + 20;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = obj;
		_ = -1;
		string empty = string.Empty;
		object obj8;
		object obj10;
		object obj11 = default;
		if (this != null && (object)_downloadGameObject != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings)+28]");
			object obj6 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings)+28]");
			if ((nint)0 != 1)
			{
				if ((nint)obj6 != 1)
				{
					if ((nint)obj6 == 2)
					{
						nint num2 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v194 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num3 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v235 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj9 = default;
						obj8 = obj9;
						obj10 = obj11;
						goto IL_09b1;
					}
					if ((nint)obj6 != 3)
					{
						if ((nint)obj6 != 4 && (nint)obj6 != 5 && (nint)obj6 != 6 && (nint)obj6 != 7)
						{
							if ((nint)obj6 == 8 || (nint)obj6 == 9 || (nint)obj6 == 10)
							{
								nint num4 = (nint)typeof(ItemInfo);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S0_v272 (Il2CppClass<Info.ItemInfo>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								if (obj12 != null)
								{
									nint num5 = (nint)typeof(ItemInfo);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S0_v285 (Il2CppClass<Info.ItemInfo>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								object obj13 = default;
								empty = (string)obj13;
								goto IL_0799;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.OnlineSettings)+28]");
							if ((nint)0 != 20)
							{
								goto IL_09e2;
							}
						}
						nint num6 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v246 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num7 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v259 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj15 = default;
						empty = (string)obj15;
						goto IL_0799;
					}
				}
				goto IL_09e2;
			}
			nint num8 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v111 (Il2CppClass<InApp.InAppData>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num9 = (nint)typeof(InAppData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v152 (Il2CppClass<InApp.InAppData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj17 = default;
			obj8 = obj17;
			obj10 = obj11;
			goto IL_09b1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num10 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (Il2CppClass<System.Type>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num11 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v43 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(InAppItemModel);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new ArrayTypeMismatchException();
		IL_0799:
		string text = key.Remove((int)"_", (int)string.Empty);
		string text2 = text.ToUpper();
		empty = text2;
		nint num12 = (nint)key;
		bool flag;
		if (key != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S0_v101 (Il2CppClass<System.String>)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		IL_09b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj19 = default;
		if (obj10 == obj19)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj21 = default;
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj23 = default;
			object obj22 = obj23;
		}
		else
		{
			object obj22 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		goto IL_0799;
		IL_09e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj24 = default;
		obj8 = obj24;
		obj10 = obj11;
		goto IL_09b1;
	}

	public string GetCurrentPlatform()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = _isDownloading;
		return (string)flag;
	}

	public string GetCurrentPlatformPretty()
	{
		return "WebGL";
	}

	public string GetChecksumToShow()
	{
		//IL_008e: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got Obj
		string currentPlatformPretty = ((OnlineSettings)null).GetCurrentPlatformPretty();
		string[] array = currentPlatformPretty.Split(null);
		object obj = array;
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

	private IEnumerator DownloadCoroutine()
	{
		return (IEnumerator)(object)_checksumToShow;
	}

	private void SetCurrentChecksum(string response)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 20;
		Delegate obj2 = ((Delegate)_onFinishedDownloadingOnlineSettingsHandler).RemoveImpl((Delegate)(object)response);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj3 = default;
		obj = obj3;
	}

	private static bool ValidateChecksum(string response)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = response;
		return flag;
	}

	private void LoadFromFile()
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01c7: Expected I4, but got Obj
		//IL_00e2: Expected I, but got Obj
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected Obj, but got Unknown
		//IL_01ed: Expected I, but got Obj
		//IL_0203: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I4
		//IL_022e: Expected I, but got Obj
		//IL_0170: Expected I, but got Obj
		if (~(_isDownloading ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v26 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v30 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_downloadGameObject).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(_downloadGameObject);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"OnlineSettingsDownloader";
		object obj4 = this + 16;
		obj4 = gameObject;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)_downloadGameObject).Exec();
		NewMonoBehaviour newMonoBehaviour = _downloadGameObject.AddComponent<NewMonoBehaviour>();
		bool flag = ValidateChecksum((string)(object)this);
		Coroutine coroutine = newMonoBehaviour.StartCoroutine_Auto((IEnumerator)flag);
	}

	private void SaveToFile()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v144 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj8 = default;
		if (obj6 == obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj10 = default;
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
		}
		else
		{
			object obj11 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private static string GetSaveDataPath()
	{
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0210: Expected I, but got Obj
		//IL_0226: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0130: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_01c6: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_instance == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			OnlineSettings onlineSettings = default;
			onlineSettings.DownloadNow();
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num4 = (nint)typeof(OnlineSettings);
			if (!flag)
			{
				nint num5 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<Info.OnlineSettings>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(OnlineSettings);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(OnlineSettings);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<Info.OnlineSettings>)+5C]");
			object obj3 = (nint)0 + (nint)4;
			obj3 = onlineSettings;
		}
		nint num6 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)_instance;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((string)(object)context).IndexOf((string)(object)LINEBREAK_CHARS);
		if (num3 < 1)
		{
			object obj2 = msg + 28;
			obj2 = 0;
		}
		else
		{
			object obj3 = msg + 28;
			string text = ((string)(object)context).InternalSubString(0, num3);
			obj3 = text;
		}
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	static OnlineSettings()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
