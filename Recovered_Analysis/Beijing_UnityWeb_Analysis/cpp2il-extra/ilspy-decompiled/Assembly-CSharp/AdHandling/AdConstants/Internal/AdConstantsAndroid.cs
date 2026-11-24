using System.Collections.Generic;
using ABTest;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Ads;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace AdHandling.AdConstants.Internal;

public class AdConstantsAndroid : IAdConstants
{
	private readonly Dictionary<AdLocationInfo, string> _flurryAdCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _adColonyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _tapjoyCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _chartboostCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _inmobiCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _vungleCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _supersonicCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _facebookCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _mobvistaCacheIDs;

	private readonly Dictionary<AdLocationInfo, string> _yeahMobiCacheIDs;

	public bool isRestricted
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs => null;

	public string AdColonyAppId => (string)(object)_flurryAdCacheIDs;

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"appb11379f4ddcc42228a";

	public string TapJoyAppId => (string)(object)_adColonyCacheIDs;

	public string TapJoyAppKey => "79933fc1-a870-4194-9cca-68e4f571c2a6";

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"eZM_wahwQZScymjk9XHCpgECSP0VI8bStoPGyKycVJ5Eu9INVkRW5F_pE2wy";

	public string ChartboostAppId => (string)(object)_tapjoyCacheIDs;

	public string ChartboostAppSignature => "5ae07ba9bd01440b6fdaa9a4";

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"3d931818f15ceb555b569f79368713aef7ad4b93";

	public string InmobiAccountId => (string)(object)_chartboostCacheIDs;

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"6c7ea8566bfd4b2c82269e3647046624";

	public string VungleAppId => (string)(object)_inmobiCacheIDs;

	public Dictionary<AdLocationInfo, string> VungleCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"5ae049895c15a747a459d838";

	public string SupersonicAppId => (string)(object)_vungleCacheIDs;

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"70fc829d";

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs => _supersonicCacheIDs;

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs => _facebookCacheIDs;

	public string MobVistaAppId => (string)(object)_mobvistaCacheIDs;

	public string MobVistaAppSdkKey => "101364";

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs => (Dictionary<AdLocationInfo, string>)(object)"f51fde5b5c666de31358328df8b3141a";

	public AdConstantsAndroid()
	{
		//IL_063e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_0567: Expected I, but got Obj
		//IL_057d: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_05a8: Expected I, but got Obj
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected Obj, but got Unknown
		//IL_01fa: Expected I, but got Obj
		//IL_0210: Expected Obj, but got I
		//IL_06cf: Expected I, but got Obj
		//IL_06e5: Expected Obj, but got I
		//IL_023b: Expected I, but got Obj
		//IL_0494: Expected I, but got Obj
		//IL_04aa: Expected Obj, but got I
		//IL_0422: Expected I, but got Obj
		//IL_031e: Expected I, but got Obj
		//IL_0334: Expected Obj, but got I
		//IL_02ac: Expected I, but got Obj
		//IL_04d5: Expected I, but got Obj
		//IL_035f: Expected I, but got Obj
		string dataPath = Application.dataPath;
		object obj = dataPath - 8;
		AdConstantsIOSRestricted adConstantsIOSRestricted;
		if ((nint)dataPath != 8)
		{
			if ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3)
			{
				nint num = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v68 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v140 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v18 (Il2CppClass<Globals>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag = obj3 == null;
				if (iOSOtherAudioPlaying)
				{
					if (!flag)
					{
						nint num4 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v134 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						AdConstantsKindleRestricted adConstantsKindleRestricted = default;
						adConstantsKindleRestricted._002Ector();
						adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsKindleRestricted;
					}
					else
					{
						nint num5 = (nint)typeof(AgeRestriction);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v114 (Il2CppClass<Info.AgeRestriction>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num6 = (nint)typeof(AgeRestriction);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v127 (Il2CppClass<Info.AgeRestriction>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						AdConstantsKindle_TEST adConstantsKindle_TEST;
						if (AgeRestriction.waitForAgeRestriction)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							global::ABTest.ABTest aBTest = default;
							aBTest.DisableDebugPayload();
							adConstantsKindle_TEST = (AdConstantsKindle_TEST)(object)aBTest;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							AdConstantsKindle_TEST adConstantsKindle_TEST2 = default;
							adConstantsKindle_TEST2._002Ector();
							adConstantsKindle_TEST = adConstantsKindle_TEST2;
						}
						adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsKindle_TEST;
					}
				}
				else
				{
					if (!flag)
					{
						nint num7 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v101 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						AdConstantsAndroidRestricted adConstantsAndroidRestricted = default;
						adConstantsAndroidRestricted._002Ector();
						adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsAndroidRestricted;
					}
					else
					{
						nint num8 = (nint)typeof(AgeRestriction);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v82 (Il2CppClass<Info.AgeRestriction>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num9 = (nint)typeof(AgeRestriction);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v94 (Il2CppClass<Info.AgeRestriction>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (AgeRestriction.waitForAgeRestriction)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							AdConstantsEditor adConstantsEditor = default;
							adConstantsEditor._002Ector();
							adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsEditor;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							AdConstantsAndroid_TEST adConstantsAndroid_TEST = default;
							adConstantsAndroid_TEST._002Ector();
							adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsAndroid_TEST;
						}
					}
				}
			}
			else
			{
				nint num10 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v51 (Il2CppClass<Info.AgeRestriction>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v63 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (AgeRestriction.waitForAgeRestriction)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					AdConstantsIOS adConstantsIOS = default;
					adConstantsIOS._002Ector();
					adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsIOS;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					AdConstantsEditorRestricted adConstantsEditorRestricted = default;
					adConstantsEditorRestricted._002Ector();
					adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsEditorRestricted;
				}
			}
		}
		else
		{
			nint num12 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Globals>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num13 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v44 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_USE_TEST_AD_CONSTANTS ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				AdConstantsIOSRestricted adConstantsIOSRestricted2 = default;
				adConstantsIOSRestricted2._002Ector();
				adConstantsIOSRestricted = adConstantsIOSRestricted2;
			}
			else
			{
				nint num14 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v24 (Il2CppClass<Info.AgeRestriction>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num15 = (nint)typeof(AgeRestriction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v37 (Il2CppClass<Info.AgeRestriction>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (AgeRestriction.waitForAgeRestriction)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					AdConstantsKindle adConstantsKindle = default;
					adConstantsKindle._002Ector();
					adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsKindle;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					AdConstantsIOS_TEST adConstantsIOS_TEST = default;
					adConstantsIOS_TEST._002Ector();
					adConstantsIOSRestricted = (AdConstantsIOSRestricted)(object)adConstantsIOS_TEST;
				}
			}
		}
		object obj7 = this + 8;
		obj7 = adConstantsIOSRestricted;
		TransformExtensions.Reset((Transform)(object)AdConstants.constantsChanged);
	}
}
