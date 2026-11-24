using System;
using System.Collections.Generic;
using System.Linq;
using Cloud;
using Cpp2ILInjected;
using Data.Save;
using Info;
using TopRun;
using UI.DebugPopup;
using UnityEngine;
using WeeklyHunt;

namespace UI.Breadcrumbs;

public class Breadcrumb : MonoBehaviour
{
	public enum BreadcrumbEvent
	{
		WordHunt,
		WeeklyHunt,
		MissionSet,
		CloudSaveError,
		CloudSaveConflict,
		CloudSaveOk
	}

	[Serializable]
	public class BreadcrumbSave
	{
		public string lastDailyWord;

		public long weeklyHuntPeriodExpireDateTicks;

		public int lastMissionSet;

		public BreadcrumbSave()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private bool _newMissionSet;

	private bool _newWeeklyHunt;

	private bool _newWordHunt;

	private bool _cloudSaveError;

	private bool _cloudSaveConflict;

	private bool _cloudSaveOk;

	private UISprite _normalBackground;

	private UISprite _exclamationMark;

	private UILabel _number;

	private void Start()
	{
		CancelInvoke();
	}

	public void EnableListeners(BreadcrumbEvent[] events)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = (Delegate)_cloudSaveConflict;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)events);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 16;
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

	private void SetupNormalBreadcrumb(int breadcrumbNumber)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I4
		if (breadcrumbNumber != 0)
		{
			bool newWordHunt = Enumerable.Contains((IEnumerable<BreadcrumbEvent>)breadcrumbNumber, BreadcrumbEvent.WordHunt);
			_newWordHunt = newWordHunt;
			bool newWeeklyHunt = Enumerable.Contains((IEnumerable<BreadcrumbEvent>)breadcrumbNumber, BreadcrumbEvent.WeeklyHunt);
			_newWeeklyHunt = newWeeklyHunt;
			bool newMissionSet = Enumerable.Contains((IEnumerable<BreadcrumbEvent>)breadcrumbNumber, BreadcrumbEvent.MissionSet);
			_newMissionSet = newMissionSet;
			bool cloudSaveConflict = Enumerable.Contains((IEnumerable<BreadcrumbEvent>)breadcrumbNumber, BreadcrumbEvent.CloudSaveConflict);
			_cloudSaveConflict = cloudSaveConflict;
			bool cloudSaveError = Enumerable.Contains((IEnumerable<BreadcrumbEvent>)breadcrumbNumber, BreadcrumbEvent.CloudSaveError);
			_cloudSaveError = cloudSaveError;
			bool cloudSaveOk = Enumerable.Contains((IEnumerable<BreadcrumbEvent>)breadcrumbNumber, BreadcrumbEvent.CloudSaveOk);
			_cloudSaveOk = cloudSaveOk;
			Update();
		}
		else
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
		}
	}

	private void SetupSpecialBreadcrumb(string spriteName)
	{
		//IL_00a6: Expected I4, but got Obj
		//IL_00d1: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		_normalBackground.fillCenter = (byte)(int)"notification_counter_sticker" != 0;
		string text = _normalBackground.tag;
		bool flag = (nint)spriteName > 0;
		((GameObject)(object)text).tag = (string)flag;
		string text2 = _exclamationMark.tag;
		bool flag2 = (nint)spriteName == 1;
		((GameObject)(object)text2).tag = (string)flag2;
		string text3 = _number.tag;
		bool flag3 = (nint)spriteName > 1;
		((GameObject)(object)text3).tag = (string)flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_number.fontSize = fontSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private void CheckIfListening()
	{
		Update();
	}

	private void Update()
	{
		//IL_00f3: Expected Obj, but got I4
		bool flag = ~(_newWordHunt ? 1u : 0u) == 0 || ~(_newWeeklyHunt ? 1u : 0u) == 0 || ~(_newMissionSet ? 1u : 0u) == 0 || ~(_cloudSaveConflict ? 1u : 0u) == 0 || ~(_cloudSaveError ? 1u : 0u) == 0 || _cloudSaveOk;
		string text = tag;
		((GameObject)(object)text).tag = (string)flag;
	}

	private void CheckListeners()
	{
		//IL_0006: Expected I4, but got Obj
		Consume((BreadcrumbEvent)this);
	}

	private bool CheckCloudSaveOk()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009e: Expected I4, but got Obj
		//IL_00a2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(InAppManagerDebugPopupDataEntries);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.DebugPopup.InAppManagerDebugPopupDataEntries>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InAppManagerDebugPopupDataEntries);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UI.DebugPopup.InAppManagerDebugPopupDataEntries>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)InAppManagerDebugPopupDataEntries._appManagerPopupDatas.get_Item((InAppManagerPopupType)this) != 0;
	}

	private bool CheckCloudSaveConflict()
	{
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj2 = default;
		if ((nint)obj2 == 1)
		{
			return (byte)OnboardingSave.numberOfRunsSinceLastGuideline != 0;
		}
		return false;
	}

	private bool CheckCloudSaveError()
	{
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj2 = default;
		if ((nint)obj2 == 3)
		{
			return (byte)OnboardingSave.numberOfRunsSinceLastGuideline != 0;
		}
		return false;
	}

	private bool CheckNewMissionSet()
	{
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj2 = default;
		if ((nint)obj2 == 2)
		{
			return (byte)OnboardingSave.numberOfRunsSinceLastGuideline != 0;
		}
		return false;
	}

	private static bool CheckNewWeeklyHunt()
	{
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("DoubleCoinsVideoPayoutCap", 3000u);
		if ((int)value < 1)
		{
			return true;
		}
		return (byte)value != 0;
	}

	private static bool CheckNewWordhunt()
	{
		//IL_0144: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0196: Expected Obj, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b6: Expected I, but got Obj
		//IL_01cc: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(WeeklyHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v32 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (WeeklyHuntManager.CanSpawnToken())
		{
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v28 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TimeSpan welcomePackTimeLeft = WelcomePackManager.welcomePackTimeLeft;
			obj = welcomePackTimeLeft;
			object obj4 = obj & 0x3FFFFFFFFFFFFFFFL;
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v12 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v19 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SSEventType lastEventTypeShown = UserSave.lastEventTypeShown;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v17 (SSEventType)+10]");
			return obj4 != null;
		}
		return false;
	}

	public static void Consume(BreadcrumbEvent e)
	{
		//IL_0036: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_026b: Expected Obj, but got I4
		//IL_00fc: Expected Obj, but got I4
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L0 (UI.Breadcrumbs.Breadcrumb+BreadcrumbEvent)+10]");
		if ((nint)0 != 0 && ((Breadcrumb)null).CheckCloudSaveError())
		{
			((PlayerInfoChangedEventArgs)e).player = (IPlayer)(object)"ic_brdrcmb_conflict";
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L0 (UI.Breadcrumbs.Breadcrumb+BreadcrumbEvent)+F]");
		if ((nint)0 != 0 && ((Breadcrumb)null).CheckNewMissionSet())
		{
			((PlayerInfoChangedEventArgs)e).player = (IPlayer)(object)"ic_brdrcmb_error";
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L0 (UI.Breadcrumbs.Breadcrumb+BreadcrumbEvent)+11]");
		if ((nint)0 != 0 && ((Breadcrumb)null).CheckCloudSaveConflict())
		{
			((PlayerInfoChangedEventArgs)e).player = (IPlayer)(object)"ic_check";
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L0 (UI.Breadcrumbs.Breadcrumb+BreadcrumbEvent)+C]");
		string text;
		if ((nint)0 != 0)
		{
			IPlayer player = ((PlayerInfoChangedEventArgs)null).player;
			text = ((player == null) ? null : ((string)1));
		}
		else
		{
			text = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L0 (UI.Breadcrumbs.Breadcrumb+BreadcrumbEvent)+D]");
		bool flag = (nint)0 == 0;
		string text2 = text;
		if (!flag)
		{
			bool flag2 = CheckNewWordhunt();
			bool flag3 = !flag2;
			text2 = text;
			if (!flag3)
			{
				string text3 = text + 1;
				text2 = text3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [e @ L0 (UI.Breadcrumbs.Breadcrumb+BreadcrumbEvent)+E]");
		if ((nint)0 != 0 && TopRunMaintenance.IsActive())
		{
			string text4 = text2 + 1;
			text2 = text4;
		}
		((Breadcrumb)e).SetupSpecialBreadcrumb(text2);
	}

	public Breadcrumb()
	{
		//IL_0319: Expected Obj, but got I4
		//IL_004c: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_034b: Expected I, but got Obj
		//IL_0361: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I4
		//IL_039d: Expected Obj, but got I4
		//IL_008d: Expected I, but got Obj
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_00da: Expected I, but got Obj
		//IL_0168: Expected I, but got Obj
		//IL_0290: Expected I, but got Obj
		//IL_02a6: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		//IL_01cb: Expected Obj, but got I
		//IL_03e0: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_02d1: Expected I, but got Obj
		//IL_0424: Expected Obj, but got VT
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_01f6: Expected I, but got Obj
		//IL_0243: Expected I, but got Obj
		object obj = 0;
		if ((object)this != null)
		{
			if ((nint)this != 1)
			{
				if ((nint)this != 2)
				{
					return;
				}
				nint num = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v48 (Il2CppClass<Data.Save.UserSave>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(UserSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v54 (Il2CppClass<Data.Save.UserSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SSEventType lastEventTypeShown = UserSave.lastEventTypeShown;
				int missionsVersion = PlayerSave.missionsVersion;
				return;
			}
			nint num3 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v25 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v43 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!WeeklyHuntManager.CanSpawnToken())
			{
				return;
			}
			nint num5 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v39 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SSEventType lastEventTypeShown2 = UserSave.lastEventTypeShown;
			nint num7 = (nint)typeof(WeeklyHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v22 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(WeeklyHuntManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v30 (Il2CppClass<WeeklyHunt.WeeklyHuntManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TimeSpan welcomePackTimeLeft = WelcomePackManager.welcomePackTimeLeft;
			obj = welcomePackTimeLeft;
			object obj6 = obj & 0x3FFFFFFFFFFFFFFFL;
			return;
		}
		nint num9 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v20 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventType lastEventTypeShown3 = UserSave.lastEventTypeShown;
		nint num11 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v7 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v14 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = lastEventTypeShown3 + 8;
		bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
		obj9 = wordHuntPayedOut;
	}
}
