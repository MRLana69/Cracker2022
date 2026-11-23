using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public static class InterstitialLocations
{
	private static Location[] _showLocations;

	public static readonly List<string> ALLOWED_CACHE_SCREENS;

	static InterstitialLocations()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00c2: Expected VT, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_02b8: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 96;
		_ = 0;
		_ = 0;
		_ = 0;
		List<string> list = default;
		list._002Ector();
		list.Add("CoinsUI_shop");
		list.Add("CharacterScreen");
		list.Add("GameoverUI");
		list.Add("AwardsScreen");
		list.Add("UpgradesUI_shop");
		list.Add("BoardScreen");
		list.Add("EarnCoinsScreen");
		list.Add("FriendsUI");
		list.Add("LeaderboardUI");
		list.Add("TopRunUI");
		ALLOWED_CACHE_SCREENS = list;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(LocationID));
		Array values = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v39+C]");
		object obj3 = -1;
		object obj4 = obj3 << 2;
		object obj6 = default;
		object obj5 = obj6 + obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v34+10]");
		object obj7 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Location[] showLocations = default;
		_showLocations = showLocations;
		Location[] showLocations2 = _showLocations;
		object obj8 = obj + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 0;
		_ = 0;
		_ = DateTime.MinValue;
		_ = DateTime.MinValue;
		_ = 0;
		object obj9 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
		_ = 0;
		Location[] showLocations3 = _showLocations;
		object obj10 = obj + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 1;
		_ = 0;
		_ = DateTime.MinValue;
		_ = DateTime.MinValue;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Location[] showLocations4 = _showLocations;
		object obj11 = obj + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		_ = 2;
		_ = 300;
		_ = DateTime.MinValue;
		_ = DateTime.MinValue;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
	}

	public unsafe static Location GetLocation(LocationID locationID)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0031: Expected native int or pointer, but got VT
		//IL_004b: Expected VT, but got I
		//IL_0046: Expected native int or pointer, but got VT
		//IL_005b: Expected native int or pointer, but got VT
		object obj = (int)locationID * 24;
		object obj2 = (object)_showLocations + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6+20]");
		Location location = default;
		((Location*)(nint)location)->defaultTimeLimitToNextShow = 0u;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6+18]");
		((Location*)(nint)location)->lastShownAdTimeStamp = (DateTime)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6+10]");
		((Location*)(nint)location)->id = LocationID.DisableShow;
		return location;
	}

	public unsafe static Location SetLocationLastShownAdTimeStamp(Location location, DateTime timeStamp)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I4
		//IL_00f1: Expected native int or pointer, but got VT
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_0113: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 80;
		object obj3 = (int)location.id * 24;
		object obj4 = (object)_showLocations + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		object obj5 = (int)location.id * 24;
		object obj6 = (object)_showLocations + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		Location location2 = default;
		((Location*)(nint)location2)->defaultTimeLimitToNextShow = 0u;
		((Location*)(nint)location2)->lastShownAdTimeStamp = timeStamp;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		((Location*)(nint)location2)->id = LocationID.DisableShow;
		return location2;
	}
}
