using System;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using UnityEngine;
using WordHunt;

public class Achievements
{
	public const int ACHIEVEMENT_COUNT = 41;

	private string[] _achievementIds;

	private Mission[] _achievementArray;

	private static Achievements _instance;

	public string[] achievementIds
	{
		get
		{
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Expected Obj, but got Unknown
			//IL_034f: Expected Obj, but got I4
			//IL_0363: Expected I, but got Obj
			//IL_0379: Expected Obj, but got I
			//IL_0497: Expected I, but got Obj
			//IL_04ad: Expected Obj, but got I
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected Obj, but got Unknown
			//IL_03b1: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_028a: Expected Obj, but got I
			//IL_00e8: Expected I, but got Obj
			//IL_00fe: Expected Obj, but got I
			//IL_0258: Expected Obj, but got I4
			//IL_042c: Expected I4, but got Obj
			//IL_01c9: Expected I, but got Obj
			//IL_0410: Expected I4, but got Obj
			//IL_0158: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 24;
			obj = 0;
			_ = 0;
			nint num = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v92 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int wordHuntLastPayoutDayOfYear = EventsSave.wordHuntLastPayoutDayOfYear;
			nint num3 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(WordHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v88 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = (string)(obj2 + 12);
			WordHuntManager.LogError(text, (UnityEngine.Object)wordHuntLastPayoutDayOfYear);
			obj = text;
			_ = text.m_stringLength;
			obj2 = text;
			_ = text.m_stringLength;
			if ((nint)obj2 == 1)
			{
				text = (string)obj;
				string text2 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				text2.m_stringLength = 0;
				bool flag = text.m_stringLength == 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
				nint num5 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v49 (Il2CppClass<HouseKeeper>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				bool flag2 = obj5 == null;
				bool triggeredViaMysteryPowerup = default;
				if (flag)
				{
					if (!flag2)
					{
						nint num6 = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v84 (Il2CppClass<HouseKeeper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return (string[])(object)((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_SMB").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_SMB_PERSONAL", triggeredViaMysteryPowerup);
				}
				if (!flag2)
				{
					nint num7 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v74 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (string[])(object)((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_MB").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_MB_PERSONAL", triggeredViaMysteryPowerup);
			}
			text = (string)obj;
			string text3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			text3.m_stringLength = 0;
			object obj6;
			if (text != null)
			{
				obj6 = 0;
			}
			else
			{
				text = (string)obj;
				string text4 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				text4.m_stringLength = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24 (System.String)+4]");
				obj6 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			text = (string)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	public Mission[] achievementArray => (Mission[])(object)_achievementIds;

	public static Achievements Instance
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Achievements achievements = default;
			achievements._achievementIds = null;
			return achievements;
		}
	}

	public int GetNumberOfHoverboardsUsed()
	{
		//IL_0007: Expected I4, but got Obj
		return (int)_achievementArray;
	}

	public int GetAchievementIndexInArray(MissionType type)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		object obj2 = default;
		object obj = obj2 + 16;
		DateTime today = CDateTime.Today;
		obj = today;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v30 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		object obj5 = default;
		obj4 = obj5;
		object obj6 = default;
		obj2 = obj6;
		object obj7 = obj2 + 24;
		obj7 = obj4;
		object obj8 = obj2 + 32;
		obj8 = obj2;
		object obj9 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		return (obj9 == obj10) ? 1 : 0;
	}

	public Achievements()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
