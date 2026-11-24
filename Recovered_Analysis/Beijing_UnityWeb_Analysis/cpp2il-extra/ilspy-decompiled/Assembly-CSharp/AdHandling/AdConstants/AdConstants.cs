using System;
using System.Collections.Generic;
using AdHandling.AdConstants.Internal;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Ads;
using UI.Screens;

namespace AdHandling.AdConstants;

public class AdConstants : IAdConstants
{
	private IAdConstants _constants = null;

	private static AdConstants _instance;

	private static Action m_constantsChanged;

	public static AdConstants instance => null;

	public static string FlurryApiKey
	{
		get
		{
			if (_instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Action value = default;
				constantsChanged += value;
				_instance = (AdConstants)(object)value;
			}
			return (string)(object)_instance;
		}
	}

	public bool isRestricted
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(ChallengesScreen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.ChallengesScreen>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ChallengesScreen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UI.Screens.ChallengesScreen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC24");
			object obj2 = default;
			return (nint)obj2 == 1;
		}
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string AdColonyAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string TapJoyAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public string TapJoyAppKey
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string ChartboostAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public string ChartboostAppSignature
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string InmobiAccountId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string VungleAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> VungleCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string SupersonicAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public string MobVistaAppId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public string MobVistaAppSdkKey
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string result = default;
			return result;
		}
	}

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Dictionary<AdLocationInfo, string> result = default;
			return result;
		}
	}

	public unsafe static event Action constantsChanged
	{
		add
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected Obj, but got Unknown
			//IL_00ab: Expected I, but got Obj
			//IL_00c1: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			((AdConstantsAndroid)(object)value)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(AdConstants.SetPlatformDependentConstants);
			object obj = action + 16;
			obj = value;
			nint num = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v13 (Il2CppClass<Info.AgeRestriction>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(AgeRestriction);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<Info.AgeRestriction>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AgeRestriction.restrictionChanged -= action;
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AdConstants.m_constantsChanged;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AdConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdHandling.AdConstants.AdConstants>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private AdConstants()
	{
		_ = 0;
		_ = 0;
	}

	private void SetPlatformDependentConstants()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		Delegate obj = AdConstants.m_constantsChanged;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num = (nint)typeof(AdConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AdHandling.AdConstants.AdConstants>)+5C]");
			object obj3 = (nint)0 + (nint)4;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}
}
