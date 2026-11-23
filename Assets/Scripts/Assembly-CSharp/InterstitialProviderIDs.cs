using System.Collections.Generic;

public static class InterstitialProviderIDs
{
	public const string INMOBI = "inmobi";

	public const string CHARTBOOST = "chartboost";

	public const string MDOTM = "mdotm";

	public const string SUPERSONIC = "supersonic";

	public const string FACEBOOK = "facebook";

	public static List<string> allValidProviderIDs;

	private static List<string> debugProviderIDs;

	public static List<string> GetDebugProviderIDs()
	{
		((List<T>)(object)debugProviderIDs).Clear();
		if (~(Globals.DEBUG_INTERSTITIAL_PROVIDERS ? 1u : 0u) == 0)
		{
			if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_INMOBI ? 1u : 0u) == 0 && !debugProviderIDs.Contains("inmobi"))
			{
				debugProviderIDs.Add("inmobi");
			}
			if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_CHARTBOOST ? 1u : 0u) == 0 && !debugProviderIDs.Contains("chartboost"))
			{
				debugProviderIDs.Add("chartboost");
			}
			if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_MDOTM ? 1u : 0u) == 0 && !debugProviderIDs.Contains("mdotm"))
			{
				debugProviderIDs.Add("mdotm");
			}
			if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_SUPERSONIC ? 1u : 0u) == 0 && !debugProviderIDs.Contains("supersonic"))
			{
				debugProviderIDs.Add("supersonic");
			}
			if (~(Globals.DEBUG_INTERSTITIAL_PROVIDER_FACEBOOK ? 1u : 0u) == 0 && !debugProviderIDs.Contains("facebook"))
			{
				debugProviderIDs.Add("facebook");
			}
		}
		return debugProviderIDs;
	}

	static InterstitialProviderIDs()
	{
		List<string> list = default;
		list._002Ector();
		list.Add("inmobi");
		list.Add("chartboost");
		list.Add("mdotm");
		list.Add("supersonic");
		list.Add("facebook");
		allValidProviderIDs = list;
		List<string> list2 = default;
		list2._002Ector();
		debugProviderIDs = list2;
	}
}
