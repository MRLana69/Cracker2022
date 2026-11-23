using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using TopRun;
using UnityEngine;

public class TopRunNormalStateHelper : MonoBehaviour
{
	public enum NormalStateType
	{
		Ongoing,
		WaitingForResults,
		Over
	}

	private UISprite _background;

	private UILabel _weekLabel;

	private UILabel _statusLabel;

	private UILabel _numberLabel;

	private UILabel _nextSoonLabel;

	private ITournament currentTournament;

	private const string zeroClock = "00:00:00";

	private int hoursThreshold = 100;

	private NormalStateType currentState__BackingField;

	public NormalStateType currentState
	{
		get
		{
			return currentState__BackingField;
		}
		private set
		{
			currentState__BackingField = value;
		}
	}

	public void InitNormalState()
	{
		if (TopRunRoot.manager__BackingField == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		ITournament tournament = default;
		currentTournament = tournament;
		DateTime utcNow = CDateTime.UtcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime dateTime = default;
		if (utcNow > dateTime)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj2 = default;
			object obj3 = default;
			if (obj2 == null)
			{
				if ((nint)obj3 > 0)
				{
					SetWaitingForResultsState(tournament);
					return;
				}
			}
			else if ((nint)obj3 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj4 = default;
				if ((nint)obj4 >= 1 && TopRunRewardHelper.ShouldShowResults())
				{
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj5 = default;
			if (obj5 == null)
			{
				SetOngoingState(tournament);
				return;
			}
		}
		SetOverState(tournament);
	}

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Ref, but got Unknown
		//IL_0162: Expected VT, but got I4
		//IL_0154: Expected VT, but got I4
		//IL_02c0: Expected Obj, but got Ref
		object obj = default;
		ref bool reference = ref *(bool*)(obj - 16);
		_ = 0;
		if (currentTournament == null)
		{
			return;
		}
		if (currentState__BackingField != NormalStateType.Ongoing)
		{
			if (currentState__BackingField != NormalStateType.WaitingForResults)
			{
				if (currentState__BackingField == NormalStateType.Over)
				{
					reference = ref *(bool*)null;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
					DateTime nextTournamentStartTime = default;
					string text = TimeUntilNextTournament(nextTournamentStartTime, out reference);
					_numberLabel.text = text;
					if (reference)
					{
						SetNextTournamentSoon();
						return;
					}
					GameObject gameObject = _nextSoonLabel.gameObject;
					gameObject.SetActive(value: false);
					GameObject gameObject2 = _numberLabel.gameObject;
					gameObject2.SetActive(value: true);
					GameObject gameObject3 = _statusLabel.gameObject;
					gameObject3.SetActive(value: true);
				}
				else
				{
					_ = currentState__BackingField;
					_ = -1;
					reference = ref *(bool*)typeof(NormalStateType);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Boolean&)+C]");
					_ = 0;
					string text2 = ((Enum)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).ToString();
					string text3 = "No avilable handler for case " + text2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				object obj2 = default;
				if (obj2 != null)
				{
					TopRunRewardHelper.RefreshPendingResults();
				}
			}
			return;
		}
		reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime officialTournamentEnd = default;
		string text4 = TournamentTimeLeft(officialTournamentEnd, _statusLabel, out reference);
		string text5 = string.Empty + text4;
		_numberLabel.text = text5;
		_numberLabel.pivot = UIWidget.Pivot.Right;
		UIAnchor component = _numberLabel.GetComponent<UIAnchor>();
		GameObject container = _statusLabel.gameObject;
		component.container = container;
		component.side = UIAnchor.Side.Left;
		Vector2 pixelOffset;
		if (reference)
		{
			_numberLabel.pivot = UIWidget.Pivot.Left;
			pixelOffset = (Vector2)(-1031536640);
		}
		else
		{
			pixelOffset = (Vector2)(-1073741824);
		}
		component.pixelOffset = pixelOffset;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime utcNow = CDateTime.UtcNow;
		DateTime dateTime = default;
		if (utcNow > dateTime)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if ((nint)obj3 <= 0)
			{
				SetOverState(currentTournament);
			}
			else
			{
				SetWaitingForResultsState(currentTournament);
			}
		}
	}

	private unsafe void SetOngoingState(ITournament tournament)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_00f3: Expected VT, but got I8
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Ref, but got Unknown
		//IL_021e: Expected VT, but got I4
		//IL_0210: Expected VT, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		currentState__BackingField = NormalStateType.Ongoing;
		GameObject gameObject = _nextSoonLabel.gameObject;
		gameObject.SetActive(value: false);
		string text = Strings.Get(StringID.TOPRUN_STATE_WEEK);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num = obj + 8;
		string text2 = ((int*)num)->ToString();
		string text3 = text + " " + text2;
		_weekLabel.text = text3;
		GameObject gameObject2 = _statusLabel.gameObject;
		gameObject2.SetActive(value: true);
		_statusLabel.pivot = UIWidget.Pivot.Right;
		UIAnchor component = _statusLabel.GetComponent<UIAnchor>();
		GameObject container = _background.gameObject;
		component.container = container;
		component.pixelOffset = (Vector2)(-4647714812210446336L);
		component.side = UIAnchor.Side.Right;
		_ = 0;
		GameObject gameObject3 = _numberLabel.gameObject;
		gameObject3.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime officialTournamentEnd = default;
		string text4 = TournamentTimeLeft(officialTournamentEnd, _statusLabel, out *(bool*)(obj + 15));
		string text5 = string.Empty + text4;
		_numberLabel.text = text5;
		_numberLabel.pivot = UIWidget.Pivot.Right;
		UIAnchor component2 = _numberLabel.GetComponent<UIAnchor>();
		GameObject container2 = _statusLabel.gameObject;
		component2.container = container2;
		component2.side = UIAnchor.Side.Left;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		Vector2 pixelOffset;
		if ((nint)0 != 0)
		{
			_numberLabel.pivot = UIWidget.Pivot.Left;
			pixelOffset = (Vector2)(-1031536640);
		}
		else
		{
			pixelOffset = (Vector2)(-1073741824);
		}
		component2.pixelOffset = pixelOffset;
		_ = 0;
	}

	private unsafe void SetWaitingForResultsState(ITournament tournament)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_0115: Expected VT, but got I8
		object obj2 = default;
		object obj = obj2 - 16;
		currentState__BackingField = NormalStateType.WaitingForResults;
		GameObject gameObject = _nextSoonLabel.gameObject;
		gameObject.SetActive(value: false);
		string text = Strings.Get(StringID.TOPRUN_STATE_WEEK);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num = obj + 12;
		string text2 = ((int*)num)->ToString();
		string text3 = text + " " + text2;
		_weekLabel.text = text3;
		GameObject gameObject2 = _statusLabel.gameObject;
		gameObject2.SetActive(value: true);
		string text4 = Strings.Get(StringID.TOPRUN_STATE_WAIT_FOR_RESULTS);
		_statusLabel.text = text4;
		_statusLabel.pivot = UIWidget.Pivot.Right;
		UIAnchor component = _statusLabel.GetComponent<UIAnchor>();
		GameObject container = _background.gameObject;
		component.container = container;
		component.pixelOffset = (Vector2)(-4647714812210446336L);
		component.side = UIAnchor.Side.Right;
		GameObject gameObject3 = _numberLabel.gameObject;
		gameObject3.SetActive(value: false);
	}

	private unsafe void SetOverState(ITournament tournament)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected Ref, but got Unknown
		//IL_00f9: Expected VT, but got I8
		//IL_0178: Invalid comparison between I4 and F8
		//IL_021b: Expected VT, but got I8
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		currentState__BackingField = NormalStateType.Over;
		GameObject gameObject = _nextSoonLabel.gameObject;
		gameObject.SetActive(value: false);
		string text = Strings.Get(StringID.TOPRUN_STATE_WEEK);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		int num = obj + 12;
		string text2 = ((int*)num)->ToString();
		string text3 = text + " " + text2;
		_weekLabel.text = text3;
		GameObject gameObject2 = _numberLabel.gameObject;
		gameObject2.SetActive(value: true);
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime nextTournamentStartTime = default;
		string text4 = TimeUntilNextTournament(nextTournamentStartTime, out *(bool*)(obj + 31));
		_numberLabel.text = text4;
		_numberLabel.pivot = UIWidget.Pivot.Left;
		UIAnchor component = _numberLabel.GetComponent<UIAnchor>();
		GameObject container = _background.gameObject;
		component.container = container;
		component.pixelOffset = (Vector2)(-4647714812182659072L);
		component.side = UIAnchor.Side.Right;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime utcNow = CDateTime.UtcNow;
		DateTime dateTime = default;
		TimeSpan timeSpan = dateTime - utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1F]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			double num2 = 0.0 * 2.7777777777777777E-11;
			if (!((double)hoursThreshold < num2))
			{
				string text5 = Strings.Get(StringID.TOPRUN_STATE_NEXT_IN);
				_statusLabel.text = text5;
				_statusLabel.pivot = UIWidget.Pivot.Right;
				UIAnchor component2 = _statusLabel.GetComponent<UIAnchor>();
				GameObject container2 = _background.gameObject;
				component2.container = container2;
				component2.pixelOffset = (Vector2)(-4647714812181872640L);
				component2.side = UIAnchor.Side.Right;
				return;
			}
		}
		SetNextTournamentSoon();
	}

	private void SetNextTournamentSoon()
	{
		GameObject gameObject = _numberLabel.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = _statusLabel.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = _nextSoonLabel.gameObject;
		gameObject3.SetActive(value: true);
		string text = Strings.Get(StringID.TOPRUN_STATE_NEXT_SOON);
		_nextSoonLabel.text = text;
	}

	private unsafe string TournamentTimeLeft(DateTime officialTournamentEnd, UILabel statusLabel, out bool lessThanAdayLeft)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Expected I, but got VT
		//IL_0086: Expected Obj, but got I8
		//IL_0149: Expected Obj, but got I8
		//IL_022d: Expected VT, but got I
		//IL_00f6: Expected Obj, but got I8
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected I4, but got Unknown
		//IL_01b6: Expected Obj, but got I8
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected I4, but got Unknown
		object obj = default;
		TopRunNormalStateHelper topRunNormalStateHelper = (TopRunNormalStateHelper)(obj - 16);
		_ = 0;
		DateTime utcNow = CDateTime.UtcNow;
		TimeSpan timeSpan = officialTournamentEnd - utcNow;
		((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr = (IntPtr)timeSpan;
		DateTime utcNow2 = CDateTime.UtcNow;
		ref bool reference;
		if (utcNow2 > officialTournamentEnd)
		{
			reference = ref *(bool*)null;
			return "00:00:00";
		}
		object obj2 = (nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr / 864000000000L;
		if ((nint)obj2 >= 2)
		{
			reference = ref *(bool*)null;
			string text = Strings.Get(StringID.TOPRUN_STATE_DAYS_LEFT);
			statusLabel.text = text;
			object obj3 = (nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr / 864000000000L;
			int num = topRunNormalStateHelper + 4;
			string text2 = ((int*)num)->ToString();
			return string.Empty + text2;
		}
		object obj4 = (nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr / 864000000000L;
		if ((nint)obj4 == 1)
		{
			reference = ref *(bool*)null;
			string text3 = Strings.Get(StringID.TOPRUN_STATE_DAYS_LEFT_SINGLE);
			statusLabel.text = text3;
			object obj5 = (nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr / 864000000000L;
			int num2 = topRunNormalStateHelper + 4;
			string text4 = ((int*)num2)->ToString();
			return string.Empty + text4;
		}
		reference = ref *(bool*)1;
		string text5 = Strings.Get(StringID.TOPRUN_STATE_TIME_LEFT);
		statusLabel.text = text5;
		return topRunNormalStateHelper.GetTimeLeftInHHMMSS((TimeSpan)(nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr);
	}

	private unsafe string TimeUntilNextTournament(DateTime nextTournamentStartTime, out bool pastNextTournamentStart)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Expected I, but got VT
		//IL_0037: Expected Obj, but got I8
		//IL_00e3: Expected VT, but got I
		object obj = default;
		TopRunNormalStateHelper topRunNormalStateHelper = (TopRunNormalStateHelper)(obj - 16);
		DateTime utcNow = CDateTime.UtcNow;
		TimeSpan timeSpan = nextTournamentStartTime - utcNow;
		((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr = (IntPtr)timeSpan;
		object obj2 = (nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr / 864000000000L;
		ref bool reference;
		if ((nint)obj2 >= 100)
		{
			reference = ref *(bool*)1;
			return string.Empty;
		}
		DateTime utcNow2 = CDateTime.UtcNow;
		if (utcNow2 > nextTournamentStartTime)
		{
			reference = ref *(bool*)1;
			return "00:00:00";
		}
		reference = ref *(bool*)null;
		return topRunNormalStateHelper.GetTimeLeftInHHMMSS((TimeSpan)(nint)((UnityEngine.Object)topRunNormalStateHelper).m_CachedPtr);
	}

	private unsafe string GetTimeLeftInHHMMSS(TimeSpan timeSpan)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_03fc: Expected Obj, but got I8
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected Obj, but got Unknown
		//IL_0424: Expected Obj, but got I8
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019f: Expected I4, but got Obj
		//IL_0101: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_012a: Expected I4, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got I
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02f3: Expected I4, but got Obj
		//IL_0255: Expected Obj, but got I
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_027e: Expected I4, but got Obj
		object obj = default;
		int num = obj - 16;
		_ = 0;
		((int*)num)->m_value = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
		object obj2 = 0 / 864000000000L;
		object obj3 = obj2 * 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
		object obj4 = 0 / 36000000000L;
		object obj5 = obj4 / 24;
		object obj6 = obj5 * 24;
		object obj7 = obj4 - obj6;
		object obj8 = obj3 + obj7;
		if ((nint)obj8 <= 9)
		{
			int num2 = num + 4;
			string text = ((int*)num2)->ToString();
			string text2 = "0" + text;
		}
		else
		{
			int num3 = num + 4;
			string text3 = ((int*)num3)->ToString();
			string text2 = string.Empty + text3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
		object obj9 = (nint)0 / (nint)600000000;
		object obj10 = obj9 / 60;
		object obj11 = obj10 * 60;
		object obj12 = obj9 - obj11;
		if ((nint)obj12 <= 9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
			object obj13 = (nint)0 / (nint)600000000;
			object obj14 = obj13 / 60;
			object obj15 = obj14 * 60;
			int value = obj13 - obj15;
			((int*)num)->m_value = value;
			string text4 = ((int*)num)->ToString();
			string text5 = "0" + text4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
			object obj16 = (nint)0 / (nint)600000000;
			object obj17 = obj16 / 60;
			object obj18 = obj17 * 60;
			int value2 = obj16 - obj18;
			((int*)num)->m_value = value2;
			string text6 = ((int*)num)->ToString();
			string text5 = string.Empty + text6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
		object obj19 = (nint)0 / (nint)10000000;
		object obj20 = obj19 / 60;
		object obj21 = obj20 * 60;
		object obj22 = obj19 - obj21;
		if ((nint)obj22 <= 9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
			object obj23 = (nint)0 / (nint)10000000;
			object obj24 = obj23 / 60;
			object obj25 = obj24 * 60;
			int value3 = obj23 - obj25;
			((int*)num)->m_value = value3;
			string text7 = ((int*)num)->ToString();
			string text8 = "0" + text7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Int32)+8]");
			object obj26 = (nint)0 / (nint)10000000;
			object obj27 = obj26 / 60;
			object obj28 = obj27 * 60;
			int value4 = obj26 - obj28;
			((int*)num)->m_value = value4;
			string text9 = ((int*)num)->ToString();
			string text8 = string.Empty + text9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}
}
