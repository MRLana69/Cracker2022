using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Ads;

public static class AdLocations
{
	public static readonly AdLocationInfo POOL1_VIDEOS;

	public static readonly AdLocationInfo POOL2_VIDEOS;

	public static readonly AdLocationInfo POOL3_VIDEOS;

	public static readonly AdLocationInfo HOME_INTERSTITIALS;

	public static readonly AdLocationInfo HOME_VIDEOS;

	public static readonly AdLocationInfo GAME_OVER_INTERSTITIALS;

	public static readonly AdLocationInfo EARN_COINS_VIDEOS;

	public static readonly AdLocationInfo DOUBLE_UP_VIDEOS;

	public static readonly AdLocationInfo WORDY_WEEKEND_VIDEOS;

	public static readonly AdLocationInfo BOARD_BUTTON_VIDEOS;

	public static readonly AdLocationInfo REVIVAL_VIDEOS;

	public static readonly AdLocationInfo GAMEOVER_DOUBLE_COINS_VIDEOS;

	public static readonly AdLocationInfo HOVERBOARD_POPUP_VIDEOS;

	public static readonly AdLocationInfo HOVERBOARD_FREE_VIDEOS;

	public static readonly AdLocationInfo HOVERBOARD_RUN_VIDEOS;

	public static readonly AdLocationInfo SKIP_MISSION_PAUSE_VIDEOS;

	public static readonly AdLocationInfo SKIP_MISSION_TOUR_VIDEOS;

	public static readonly AdLocationInfo FREE_COINS_FREE_VIDEOS;

	public static readonly AdLocationInfo FREE_COINS_POPUP_VIDEOS;

	public static readonly AdLocationInfo HEADSTART_FREE_VIDEOS;

	public static readonly AdLocationInfo HEADSTART_RUN_VIDEOS;

	public static readonly AdLocationInfo SCOREBOOSTER_FREE_VIDEOS;

	public static readonly AdLocationInfo SCOREBOOSTER_RUN_VIDEOS;

	public static ICollection<AdLocationInfo> adLocations;

	private static AdLocationInfo NewAdLocation(string id, AdType type, bool isPoolLocation)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00af: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+38]");
		if ((nint)0 == 0)
		{
			return (AdLocationInfo)(-1);
		}
		object obj = id - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+38]");
		if (0 <= (nint)obj)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+30]");
		object obj2 = 0 + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+38]");
		AdLocationInfo adLocationInfo = (AdLocationInfo)(0 - obj);
		nint num = default;
		AdLocationInfo adLocationInfo2 = (AdLocationInfo)(num * (isPoolLocation ? 1 : 0));
		AdLocationInfo adLocationInfo3;
		if (System.Runtime.CompilerServices.Unsafe.As<AdLocationInfo, UIntPtr>(ref adLocationInfo) > System.Runtime.CompilerServices.Unsafe.As<AdLocationInfo, UIntPtr>(ref adLocationInfo2))
		{
			adLocationInfo3 = adLocationInfo2;
			adLocationInfo = adLocationInfo2;
		}
		else
		{
			adLocationInfo3 = adLocationInfo;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12367");
		object obj3 = obj + (object)adLocationInfo3;
		obj = obj3;
		return adLocationInfo3;
	}
}
