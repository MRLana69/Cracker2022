using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

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
		VideoAd,
		FacebookLogin,
		FacebookWeeklyGift
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

		public StringID title;

		public StringID desc;

		public StringID iOSDesc;

		public string iconName = string.Empty;

		public string url;

		public string overrideAmountOfCoinsOnlineSettingKey;

		public unsafe int GetAmountOfCoins()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0038: Expected Obj, but got I4
			//IL_001c: Expected Obj, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Ref, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected Ref, but got Unknown
			//IL_00ac: Expected Obj, but got I
			//IL_0124: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			_ = 0;
			_ = 0;
			string text = overrideAmountOfCoinsOnlineSettingKey;
			object obj3;
			if (overrideAmountOfCoinsOnlineSettingKey != null)
			{
				obj3 = 0;
				if (text._stringLength != 0)
				{
					goto IL_0171;
				}
			}
			obj3 = 1;
			goto IL_0171;
			IL_0171:
			if (obj3 == null)
			{
				OnlineSettings instance = OnlineSettings.instance;
				if (instance.TryGetValue(overrideAmountOfCoinsOnlineSettingKey, out *(string*)(obj + 12)))
				{
					ref int result = ref *(int*)(obj + 8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					if (int.TryParse((string)0, out result))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						if ((nint)0 >= (nint)1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							return 0;
						}
					}
					else
					{
						string text2 = overrideAmountOfCoinsOnlineSettingKey;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
						string text3 = "EarnCurrencyProfile ERROR: Unable to parse int from onlinesetting " + text2 + ": " + (string)0;
					}
				}
			}
			return defaultAmountOfCoins;
		}
	}

	private const string ONLINESETTINGS_VIDEOADS_DEFAULTREWARD_KEY = "videoads_defaultreward";

	public static readonly EarnCurrencyProfile[] profiles;

	private const string DATA_PROFILE_MAIN_SPLIT = ";";

	private const string DATA_PROFILE_SUB_SPLIT = "=";

	private static readonly string[] DATA_PROFILE_ALL_SPLITS;

	private static string[] profileData;

	private static bool isVideoAddsSupported
	{
		get
		{
			RuntimePlatform platform = Application.platform;
			bool flag = platform == RuntimePlatform.Android;
			bool result = true;
			if (!flag)
			{
				RuntimePlatform platform2 = Application.platform;
				result = true;
			}
			return result;
		}
	}

	public static bool ShouldShowInGUI(int profileIndex)
	{
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I
		//IL_01ee: Expected Obj, but got I
		//IL_00ef: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I4
		int num = profileIndex << 2;
		object obj = profiles + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+10]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+8]");
		object obj3 = -9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+8]");
		string text;
		object obj4;
		bool result;
		if ((nint)0 != 9)
		{
			if ((nint)obj3 == 1)
			{
				FacebookWeeklyGiftManager instance = FacebookWeeklyGiftManager.Instance;
				return instance.IsGiftAvailable();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+10]");
			if ((nint)0 <= (nint)1)
			{
				text = GetProfileData(profileIndex);
				if (text != null)
				{
					obj4 = 0;
					if (text._stringLength != 0)
					{
						goto IL_0213;
					}
				}
				obj4 = 1;
				goto IL_0213;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+8]");
			bool flag = (nint)0 != 8;
			result = true;
			if (!flag)
			{
				bool flag2 = isVideoAddsSupported;
				result = flag2;
			}
			goto IL_022a;
		}
		PlayerInfo instance2 = PlayerInfo.Instance;
		return (byte)(~(instance2._hasPayedOutFacebook ? 1u : 0u)) != 0;
		IL_0213:
		result = true;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12+10]");
			if ((nint)0 == 1)
			{
				string bundleVersion = DeviceUtility.GetBundleVersion();
				bool flag3 = text != bundleVersion;
				result = true;
				if (flag3)
				{
					goto IL_022a;
				}
			}
			return false;
		}
		goto IL_022a;
		IL_022a:
		return result;
	}

	public static int GetNumberOfDisplayedNonOfferEarners()
	{
		int num = 0;
		int num2 = default;
		while (true)
		{
			EarnCurrencyProfile[] array = profiles;
			if (array.Length <= num)
			{
				break;
			}
			num2++;
			if (!ShouldShowInGUI(num))
			{
				num2 = num2;
			}
			int num3 = num + 1;
			num = num3;
		}
		return num2;
	}

	public static void Trigger(int profileIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (!ShouldShowInGUI(profileIndex))
		{
			return;
		}
		int num = profileIndex << 2;
		object obj3 = profiles + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v21+10]");
		EarnCurrencyProfile earnCurrencyProfile = (EarnCurrencyProfile)0;
		_ = -1;
		obj = (Enum)(object)typeof(Id);
		_ = earnCurrencyProfile.id;
		string text = obj.ToString();
		if (earnCurrencyProfile.id == Id.FacebookLogin)
		{
			SocialManager instance = SocialManager.instance;
			if (instance.FacebookLogin(null))
			{
				UIScreenController instance2 = UIScreenController.Instance;
				instance2.FacebookLogIn(loggedIn: true);
			}
		}
		if (earnCurrencyProfile.type != Type.OpenURL)
		{
			if (earnCurrencyProfile.type != Type.VideoAd)
			{
				if (earnCurrencyProfile.type == Type.ClaimReward)
				{
					if (earnCurrencyProfile.id == Id.FacebookWeeklyGift)
					{
						RewardManager.AddRewardToUnlock(CelebrationRewardOrigin.SuperMysteryBox, shouldSaveToDisk: false);
						FacebookWeeklyGiftManager instance3 = FacebookWeeklyGiftManager.Instance;
						PlayerInfo playerInfoInstance = instance3.playerInfoInstance;
						if (!playerInfoInstance._hasCollectedFacebookWeeklyGiftThisWeek)
						{
							playerInfoInstance._dirty = true;
							playerInfoInstance._hasCollectedFacebookWeeklyGiftThisWeek = true;
						}
					}
				}
				else
				{
					_ = -1;
					obj = (Enum)(object)typeof(Type);
					_ = earnCurrencyProfile.type;
					string text2 = obj.ToString();
					string text3 = "Unhandled earner type: " + text2;
				}
			}
		}
		else
		{
			int amountOfCoins = earnCurrencyProfile.GetAmountOfCoins();
			if (amountOfCoins >= 1)
			{
				PlayerInfo instance4 = PlayerInfo.Instance;
				int amountOfCoins2 = instance4.amountOfCoins;
				int amountOfCoins3 = amountOfCoins2 + amountOfCoins;
				instance4.amountOfCoins = amountOfCoins3;
			}
		}
		if (earnCurrencyProfile.repeatability <= Repeatability.OncePerVersion)
		{
			string bundleVersion = DeviceUtility.GetBundleVersion();
			SetAndSaveProfileData(profileIndex, bundleVersion);
		}
		if (earnCurrencyProfile.type != Type.OpenURL)
		{
			if (earnCurrencyProfile.type != Type.VideoAd)
			{
				if (earnCurrencyProfile.type == Type.ClaimReward)
				{
					if (earnCurrencyProfile.id == Id.FacebookWeeklyGift)
					{
						UIScreenController instance5 = UIScreenController.Instance;
						instance5.QueueMysteryBox();
					}
				}
				else
				{
					_ = -1;
					obj = (Enum)(object)typeof(Type);
					_ = earnCurrencyProfile.type;
					string text4 = obj.ToString();
					string text5 = "Unhandled earner type: " + text4;
				}
				return;
			}
			VideoAdsManager instance6 = VideoAdsManager.instance;
			if (instance6.state__BackingField == VideoAdsManager.State.Uninitialized)
			{
				VideoAdsManager instance7 = VideoAdsManager.instance;
				instance7.Init();
			}
			VideoAdsManager instance8 = VideoAdsManager.instance;
			if (!instance8.PlayVideoIfAvailable())
			{
				VideoAdsManager instance9 = VideoAdsManager.instance;
				instance9.TryCachingVideosAgain();
			}
			else
			{
				UIScreenController instance10 = UIScreenController.Instance;
				instance10.ShowVideoAdsOverlay();
			}
		}
		else
		{
			Application.OpenURL(earnCurrencyProfile.url);
		}
	}

	private static void InitProfileDataArrayIfNeeded()
	{
		//IL_0088: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_02c4: Expected Obj, but got I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_0110: Expected VT, but got Obj
		//IL_012e: Expected Obj, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_015f: Expected VT, but got Obj
		//IL_0182: Expected Obj, but got I
		if (profileData != null)
		{
			return;
		}
		EarnCurrencyProfile[] array = profiles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		string[] array2 = default;
		profileData = array2;
		PlayerInfo instance = PlayerInfo.Instance;
		string earnCurrenyData = instance._earnCurrenyData;
		object obj;
		if (instance._earnCurrenyData != null)
		{
			obj = 0;
			if (earnCurrenyData._stringLength != 0)
			{
				goto IL_0261;
			}
		}
		obj = 1;
		goto IL_0261;
		IL_0261:
		if (obj != null)
		{
			return;
		}
		string[] array3 = instance._earnCurrenyData.Split(DATA_PROFILE_ALL_SPLITS, StringSplitOptions.None);
		object obj2 = 0;
		while (true)
		{
			object obj3 = array3.Length - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj4 = obj2 << 2;
				object obj5 = (object)array3 + obj4;
				object obj6 = obj2 + 1;
				object obj7 = obj6 << 2;
				object obj8 = (object)array3 + obj7;
				System.Type typeFromHandle = System.Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Id));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v38+10]");
				if (Enum.IsDefined(typeFromHandle, 0))
				{
					System.Type typeFromHandle2 = System.Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Id));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v38+10]");
					object obj9 = Enum.Parse(typeFromHandle2, (string)0, ignoreCase: true);
					throw new NullReferenceException();
				}
				object obj10 = obj2 + 1;
				obj2 = obj10;
				continue;
			}
			break;
		}
	}

	private static string GetProfileData(int profileIndex)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got I
		InitProfileDataArrayIfNeeded();
		int num = profileIndex << 2;
		object obj = profileData + num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12+10]");
		return (string)0;
	}

	private static void SetAndSaveProfileData(int profileIndex, string data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		InitProfileDataArrayIfNeeded();
		throw new ArrayTypeMismatchException();
	}

	static EarnCoinsData()
	{
		//IL_0025: Expected I4, but got I8
		//IL_0045: Expected I4, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		EarnCurrencyProfile earnCurrencyProfile = default;
		earnCurrencyProfile._002Ector();
		earnCurrencyProfile.iOSDesc = StringID.EARN_COINS_SPONSORED_VIDEO_DESCRIPTION;
		earnCurrencyProfile.title = StringID.EARN_COINS_SPONSORED_VIDEO;
		earnCurrencyProfile.repeatability = Repeatability.Forever;
		earnCurrencyProfile.id = Id.VideoAd;
		earnCurrencyProfile.iconName = "icon_small_mini_mysteryBox_glow";
		earnCurrencyProfile.overrideAmountOfCoinsOnlineSettingKey = "videoads_defaultreward";
		throw new ArrayTypeMismatchException();
	}
}
