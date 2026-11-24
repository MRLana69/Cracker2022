using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using UI.Screens;
using UnityEngine;

namespace TopRun.UI;

public class TopRunNormalStateHelper : MonoBehaviour
{
	private enum NormalStateType
	{
		Ongoing,
		WaitingForResults,
		Over
	}

	private NormalStateType currentState__BackingField;

	private UISprite _background;

	private UILabel _leftLabel;

	private UILabel _rightLabel;

	private ITournament _currentTournament;

	private const string ZERO_CLOCK = "00:00:00";

	private const int HOURS_THRESHOLD = 100;

	private const string DAYS_LEFT_FORMAT = "[B6CCE0]{0}[-] {1}";

	private NormalStateType currentState
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (TopRun.UI.TopRunNormalStateHelper)+9]");
			return ((nint)0 != 0) ? NormalStateType.WaitingForResults : NormalStateType.Ongoing;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			object obj = value & NormalStateType.WaitingForResults;
		}
	}

	public void InitNormalState()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void Update()
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_022e: Expected Obj, but got VT
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj5 = default;
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if (obj6 != null)
			{
				object obj7 = this + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				CharacterScreenController characterScreenController = default;
				obj7 = characterScreenController;
				DateTime today = CDateTime.Today;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v32 (Il2CppClass<System.DateTime>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v59 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj4 = today;
				object obj9 = default;
				obj2 = obj9;
				obj3 = obj4;
				obj = obj2;
				object obj10 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				object obj11 = obj & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj12 = default;
					if (obj12 != null)
					{
						((TopRunOnlineScreen)this)._003CCreateMaintenanceCharacterModel_003Eb__64_0(characterScreenController);
					}
					else
					{
						SetWaitingForResultsState((ITournament)characterScreenController);
					}
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj13 = default;
				if (obj13 != null)
				{
					((TopRunOnlineScreen)this)._003CCreateMaintenanceCharacterModel_003Eb__64_0(characterScreenController);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj14 = default;
				if ((nint)obj14 > 0)
				{
					SetOverState((ITournament)characterScreenController);
				}
				else
				{
					((TopRunOnlineScreen)this)._003CCreateMaintenanceCharacterModel_003Eb__64_0(characterScreenController);
				}
				return;
			}
		}
		SDebug.LogFormat("Normal State triggered while no Tournament Data is available.", null);
	}

	private void SetOngoingState(ITournament tournament)
	{
		//IL_000a: Expected I4, but got Obj
		currentState__BackingField = (NormalStateType)tournament;
	}

	private void SetWaitingForResultsState(ITournament tournament)
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0072: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		currentState__BackingField = NormalStateType.Ongoing;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v33 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("TOPRUN_WEEK_TITLE");
		object obj3 = default;
		object obj2 = obj3 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj4 = default;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_leftLabel.fontSize = (int)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = obj3 + 8;
		object obj6 = default;
		obj5 = obj6;
		TopRunOnlineScreen topRunOnlineScreen = (TopRunOnlineScreen)(obj3 + 16);
		topRunOnlineScreen = (TopRunOnlineScreen)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E83");
		throw new ArrayTypeMismatchException();
	}

	private void SetOverState(ITournament tournament)
	{
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_0072: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0094: Expected I4, but got Obj
		currentState__BackingField = NormalStateType.WaitingForResults;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v16 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("TOPRUN_WEEK_TITLE");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		object obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_leftLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("TOPRUN_STATE_WAIT_FOR_RESULTS");
		_rightLabel.fontSize = (int)text2;
	}

	private string GetDaysLeft(DateTime tournamentEnd)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11E3A");
		return null;
	}

	private unsafe static string GetDaysPostfix(DateTime tournamentEnd)
	{
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I4
		//IL_01a3: Invalid comparison between VT and I4
		//IL_0018: Expected native int or pointer, but got VT
		//IL_008b: Expected Obj, but got I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_00b9: Expected Obj, but got VT
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected VT, but got Unknown
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0115: Expected I, but got Obj
		object obj = tournamentEnd + 2147483648L;
		if ((long)obj >= 4294967296L)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			System.ParamsArray paramsArray = default;
			System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)paramsArray, new System.ParamsArray("Part of OID doesn't fit in Int32"));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		DateTime dateTime = tournamentEnd;
		object obj2 = 1;
		while (dateTime >= (object)128)
		{
			DateTime dateTime2 = (DateTime)(dateTime >> 7);
			object obj3 = obj2 + 1;
			dateTime = dateTime2;
			obj2 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = 0;
		string text = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj5 = obj4 * 7;
			object obj6 = obj5 & 0x3F;
			object obj7 = tournamentEnd >> (int)obj6;
			TimeSpan timeSpan = (TimeSpan)(obj7 & 0x7F);
			bool flag = obj4 == null;
			TimeSpan ts = timeSpan;
			if (!flag)
			{
				TimeSpan timeSpan2 = timeSpan + 128;
				ts = timeSpan2;
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v28 (Il2CppClass<System.Convert>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v37 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = obj2 - obj4;
			object obj10 = text + obj9;
			object obj11 = obj10 + 15;
			string text2 = PauseScreen.FormatTopRunTimeLeft(ts);
			obj11 = text2;
			object obj12 = obj4 + 1;
			obj4 = obj12;
		}
		return text;
	}

	private bool HasNextTournamentStarted(DateTime nextTournamentStartTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11E3A");
		return false;
	}

	private string GetTimeToNextTournament(DateTime nextTournamentStartTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11E3A");
		return null;
	}

	private string GetTimeLeftFormatted(TimeSpan timeSpan)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public TopRunNormalStateHelper()
	{
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected Obj, but got Unknown
		//IL_02e9: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_0310: Expected Obj, but got VT
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_00e4: Expected I, but got Obj
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_0201: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 24;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 32;
		obj5 = 0;
		if (_currentTournament == null)
		{
			return;
		}
		obj5 = currentState__BackingField;
		if (currentState__BackingField != NormalStateType.Ongoing)
		{
			if (currentState__BackingField != NormalStateType.WaitingForResults)
			{
				if (currentState__BackingField == NormalStateType.Over)
				{
					((TopRunOnlineScreen)this)._003CCreateMaintenanceCharacterModel_003Eb__64_0((CharacterScreenController)_currentTournament);
					return;
				}
				obj5 = currentState__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj6 = default;
			if (obj6 == null)
			{
				return;
			}
			nint num = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v56 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v61 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TopRunRewardHelper.CalculateBeatenFriendsAward();
			return;
		}
		SetWaitingForResultsState(_currentTournament);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		DateTime today = CDateTime.Today;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v28 (Il2CppClass<System.DateTime>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v48 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = today;
		object obj9 = default;
		obj2 = obj9;
		obj3 = obj4;
		obj = obj2;
		object obj10 = obj3 & 0x3FFFFFFFFFFFFFFFL;
		object obj11 = obj & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj12 = default;
			if ((nint)obj12 < 1)
			{
				((TopRunOnlineScreen)this)._003CCreateMaintenanceCharacterModel_003Eb__64_0((CharacterScreenController)_currentTournament);
			}
			else
			{
				SetOverState(_currentTournament);
			}
		}
	}
}
