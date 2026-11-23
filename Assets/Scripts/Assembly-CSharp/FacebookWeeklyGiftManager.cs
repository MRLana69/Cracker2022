using System;
using Cpp2ILInjected;
using UnityEngine;

public class FacebookWeeklyGiftManager
{
	private PlayerInfo playerInfoInstance;

	private const string SHOW_GIFT_POPUP = "show_facebook_gift_popup";

	private static FacebookWeeklyGiftManager _instance;

	public static FacebookWeeklyGiftManager Instance
	{
		get
		{
			if (_instance == null)
			{
				FacebookWeeklyGiftManager facebookWeeklyGiftManager = default;
				facebookWeeklyGiftManager._002Ector();
				_instance = facebookWeeklyGiftManager;
			}
			return _instance;
		}
	}

	private FacebookWeeklyGiftManager()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		playerInfoInstance = instance;
		CheckAndUpdateNextWeeklyGiftDate();
	}

	public void PopupDidShow()
	{
		PlayerPrefs.SetInt("show_facebook_gift_popup", 0);
	}

	public bool ShouldDisplayPopup()
	{
		if (PlayerPrefs.GetInt("show_facebook_gift_popup", 0) != 0)
		{
			return IsGiftAvailable();
		}
		return false;
	}

	public void GiftWasClaimed()
	{
		PlayerInfo playerInfo = playerInfoInstance;
		if (!playerInfo._hasCollectedFacebookWeeklyGiftThisWeek)
		{
			playerInfo._dirty = true;
			playerInfo._hasCollectedFacebookWeeklyGiftThisWeek = true;
		}
	}

	public void CheckAndUpdateNextWeeklyGiftDate()
	{
		PlayerInfo playerInfo = playerInfoInstance;
		if (!(playerInfo._lastKnownServerTime == DateTime.MinValue))
		{
			TryCalculateAndSetNextGiftDeadlineIfNeeded();
		}
	}

	public unsafe void TryCalculateAndSetNextGiftDeadlineIfNeeded()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0135: Expected I8, but got I4
		//IL_0130: Expected native int or pointer, but got VT
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected VT, but got Unknown
		//IL_0172: Expected Ref, but got VT
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002a: Expected Ref, but got VT
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected VT, but got Unknown
		//IL_0045: Expected Ref, but got VT
		//IL_006d: Expected native int or pointer, but got VT
		//IL_0093: Expected VT, but got I8
		//IL_00df: Expected VT, but got I8
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		PlayerInfo playerInfo = playerInfoInstance;
		DateTime nextWeekday = GetNextWeekday(playerInfo._lastKnownServerTime, DayOfWeek.Saturday);
		DateTime dateTime2 = dateTime + 8;
		int year = ((DateTime*)dateTime2)->Year;
		DateTime dateTime3 = dateTime + 8;
		int month = ((DateTime*)dateTime3)->Month;
		DateTime dateTime4 = dateTime + 8;
		int day = ((DateTime*)dateTime4)->Day;
		*(DateTime*)(nint)dateTime = new DateTime(year, month, day, 11, 59, 59);
		PlayerInfo playerInfo2 = playerInfoInstance;
		if (playerInfo2._weeklyGiftEndTime != (DateTime)dateTime._dateData)
		{
			PlayerInfo playerInfo3 = playerInfoInstance;
			playerInfo3._dirty = true;
			playerInfo3._weeklyGiftEndTime = (DateTime)dateTime._dateData;
			PlayerInfo playerInfo4 = playerInfoInstance;
			if (~(playerInfo4._hasCollectedFacebookWeeklyGiftThisWeek ? 1u : 0u) == 0)
			{
				playerInfo4._dirty = true;
				playerInfo4._hasCollectedFacebookWeeklyGiftThisWeek = false;
			}
			PlayerPrefs.SetInt("show_facebook_gift_popup", 1);
		}
	}

	public unsafe static DateTime GetNextWeekday(DateTime startDate, DayOfWeek weekday)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00fc: Expected I8, but got I4
		//IL_00f7: Expected native int or pointer, but got VT
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected VT, but got Unknown
		//IL_0113: Expected Ref, but got VT
		//IL_0124: Expected Obj, but got I4
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0166: Invalid comparison between F8 and I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected VT, but got Unknown
		//IL_01a8: Expected Ref, but got VT
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected VT, but got Unknown
		//IL_002f: Expected Ref, but got VT
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected VT, but got Unknown
		//IL_004f: Expected Ref, but got VT
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected VT, but got Unknown
		//IL_006a: Expected Ref, but got VT
		//IL_0092: Expected native int or pointer, but got VT
		//IL_00b1: Expected VT, but got I8
		//IL_00b1: Expected VT, but got I
		//IL_00d2: Expected F8, but got I4
		//IL_00e9: Expected F8, but got I4
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 16);
		((DateTime*)(nint)dateTime)->_dateData = 0uL;
		DateTime dateTime2 = dateTime + 8;
		DayOfWeek dayOfWeek = ((DateTime*)dateTime2)->DayOfWeek;
		object obj2 = weekday - dayOfWeek;
		object obj3 = obj2 + 7;
		object obj4 = obj3 / 7;
		object obj5 = obj4 * 7;
		double num = (double)obj3 - (double)obj5;
		bool flag = num == 0.0;
		bool flag2 = !flag;
		double value = num;
		if (!flag2)
		{
			DateTime dateTime3 = dateTime + 8;
			int year = ((DateTime*)dateTime3)->Year;
			DateTime dateTime4 = dateTime + 8;
			int month = ((DateTime*)dateTime4)->Month;
			DateTime dateTime5 = dateTime + 8;
			int day = ((DateTime*)dateTime5)->Day;
			*(DateTime*)(nint)dateTime = new DateTime(year, month, day, 12, 0, 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
			int num2 = DateTime.Compare((DateTime)0, (DateTime)dateTime._dateData);
			bool flag3 = num2 < 0;
			double num3 = 0.0;
			if (!flag3)
			{
				num3 = 7.0;
			}
			value = num3;
		}
		DateTime dateTime6 = dateTime + 8;
		return ((DateTime*)dateTime6)->AddDays(value);
	}

	public bool IsGiftAvailable()
	{
		PlayerInfo playerInfo = playerInfoInstance;
		bool flag = playerInfo._weeklyGiftEndTime != DateTime.MinValue;
		bool flag2 = !flag;
		bool result = false;
		if (!flag2)
		{
			PlayerInfo playerInfo2 = playerInfoInstance;
			result = false;
			if (!playerInfo2._hasCollectedFacebookWeeklyGiftThisWeek)
			{
				SocialManager instance = SocialManager.instance;
				bool facebookIsLoggedIn = instance.facebookIsLoggedIn;
				result = facebookIsLoggedIn;
			}
		}
		return result;
	}
}
