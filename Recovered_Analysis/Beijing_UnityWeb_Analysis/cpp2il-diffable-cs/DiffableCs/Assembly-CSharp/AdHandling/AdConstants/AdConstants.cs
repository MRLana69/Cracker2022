namespace AdHandling.AdConstants;

public class AdConstants : IAdConstants
{
	private static AdConstants _instance; //Field offset: 0x0
	private static Action constantsChanged; //Field offset: 0x4
	private IAdConstants _constants; //Field offset: 0x8

	public static event Action constantsChanged
	{
		 add { } //Length: 136
		 remove { } //Length: 129
	}

	public string AdColonyAppId
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> AdColonyCacheIDs
	{
		 get { } //Length: 54
	}

	public string ChartboostAppId
	{
		 get { } //Length: 54
	}

	public string ChartboostAppSignature
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> ChartboostCacheIDs
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> FacebookCacheIDs
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> FlurryAdCacheIDs
	{
		 get { } //Length: 54
	}

	public static string FlurryApiKey
	{
		 get { } //Length: 103
	}

	public string InmobiAccountId
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> InmobiCacheIDs
	{
		 get { } //Length: 54
	}

	public static AdConstants instance
	{
		 get { } //Length: 3
	}

	public bool isRestricted
	{
		 get { } //Length: 80
	}

	public string MobVistaAppId
	{
		 get { } //Length: 54
	}

	public string MobVistaAppSdkKey
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> MobVistaCacheIDs
	{
		 get { } //Length: 54
	}

	public string SupersonicAppId
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> SupersonicCacheIDs
	{
		 get { } //Length: 54
	}

	public string TapJoyAppId
	{
		 get { } //Length: 54
	}

	public string TapJoyAppKey
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> TapJoyCacheIDs
	{
		 get { } //Length: 54
	}

	public string VungleAppId
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> VungleCacheIDs
	{
		 get { } //Length: 54
	}

	public Dictionary<AdLocationInfo, string> YeahMobiCacheIDs
	{
		 get { } //Length: 54
	}

	private AdConstants() { }

	public static void add_constantsChanged(Action value) { }

	public string get_AdColonyAppId() { }

	public Dictionary<AdLocationInfo, string> get_AdColonyCacheIDs() { }

	public string get_ChartboostAppId() { }

	public string get_ChartboostAppSignature() { }

	public Dictionary<AdLocationInfo, string> get_ChartboostCacheIDs() { }

	public Dictionary<AdLocationInfo, string> get_FacebookCacheIDs() { }

	public Dictionary<AdLocationInfo, string> get_FlurryAdCacheIDs() { }

	public static string get_FlurryApiKey() { }

	public string get_InmobiAccountId() { }

	public Dictionary<AdLocationInfo, string> get_InmobiCacheIDs() { }

	public static AdConstants get_instance() { }

	public bool get_isRestricted() { }

	public string get_MobVistaAppId() { }

	public string get_MobVistaAppSdkKey() { }

	public Dictionary<AdLocationInfo, string> get_MobVistaCacheIDs() { }

	public string get_SupersonicAppId() { }

	public Dictionary<AdLocationInfo, string> get_SupersonicCacheIDs() { }

	public string get_TapJoyAppId() { }

	public string get_TapJoyAppKey() { }

	public Dictionary<AdLocationInfo, string> get_TapJoyCacheIDs() { }

	public string get_VungleAppId() { }

	public Dictionary<AdLocationInfo, string> get_VungleCacheIDs() { }

	public Dictionary<AdLocationInfo, string> get_YeahMobiCacheIDs() { }

	public static void remove_constantsChanged(Action value) { }

	private void SetPlatformDependentConstants() { }

}

