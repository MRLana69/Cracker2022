using System;
using Cpp2ILInjected;
using Kiloo;
using TopRun;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

public class UITopRunTimer : MonoBehaviour
{
	private UILabel _currentTopRunWeek;

	private UILabel _timerLabel;

	private PauseScreen _pauseScreen;

	private Layout _timerLayout;

	private bool _lessThanAdayLeft;

	private int _totalSeconds;

	private IManager _tournamentManager;

	private ITournament _currentTournament;

	public void DoTimer()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		Color black = Color.black;
		object obj3 = obj2 + 32;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		object obj4 = this + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+8]");
		_ = 0;
		Color grey = Color.grey;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 32;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+8]");
		_ = 0;
		CancelInvoke();
	}

	private void SetTextTopRunTimerLabels()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		object obj = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj2 = default;
		obj = obj2;
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			if (obj3 != null)
			{
				Update();
			}
		}
	}

	private unsafe void Update()
	{
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected VT, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_0518: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0547: Expected Obj, but got VT
		//IL_0554: Expected I8, but got Obj
		//IL_054f: Expected native int or pointer, but got VT
		//IL_0569: Expected Ref, but got VT
		//IL_0575: Expected Obj, but got I8
		//IL_00f7: Expected Obj, but got VT
		//IL_010c: Expected I8, but got Obj
		//IL_0107: Expected native int or pointer, but got VT
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_00b0: Expected I, but got Obj
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_0382: Expected I, but got Obj
		//IL_0398: Expected Obj, but got I
		//IL_0258: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I
		//IL_05aa: Expected I4, but got Obj
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_01be: Expected I, but got Obj
		//IL_0411: Expected I4, but got Obj
		//IL_03c3: Expected I, but got Obj
		//IL_02e7: Expected I4, but got Obj
		//IL_0299: Expected I, but got Obj
		//IL_0615: Expected I, but got Obj
		//IL_062b: Expected Obj, but got I
		//IL_0434: Expected I, but got Obj
		//IL_04aa: Expected I4, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 48);
		DateTime dateTime = (DateTime)(obj + 40);
		object obj2 = obj + 32;
		object obj3 = obj + 16;
		object obj4 = obj + 8;
		object obj5 = obj + 24;
		obj5 = 0;
		if (_tournamentManager == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		if (obj6 == null)
		{
			return;
		}
		object obj7 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj8 = default;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v33 (Il2CppClass<System.DateTime>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v86 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = default;
		obj2 = obj10;
		obj3 = today;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
		formatProvider = (IFormatProvider)obj3;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj5 = num3;
		DateTime today2 = CDateTime.Today;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		obj4 = today2;
		object obj11 = default;
		obj = obj11;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		formatProvider = (IFormatProvider)obj;
		long num4 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
		object obj12 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		if (num4 > (long)obj12)
		{
			_lessThanAdayLeft = false;
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v93 (Il2CppClass<Strings>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v101 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("TOPRUN_STATE_NEXT_SOON");
			_timerLabel.fontSize = (int)text;
			_timerLabel.fontStyle = (FontStyle)15;
		}
		else
		{
			object obj14 = obj5 / 864000000000L;
			if ((nint)obj14 >= 2)
			{
				_lessThanAdayLeft = false;
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v78 (Il2CppClass<Strings>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num8 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v87 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string format = Strings.GetDefault("TOPRUN_STATE_DAYS_LEFT_FORMAT");
				object obj16 = obj5 / 864000000000L;
				formatProvider = (IFormatProvider)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object[] args = default;
				string text2 = string.Format(format, args);
				_timerLabel.fontSize = (int)text2;
				_timerLabel.fontStyle = (FontStyle)24;
			}
			else
			{
				object obj17 = obj5 / 864000000000L;
				if ((nint)obj17 != 1)
				{
					_timerLabel.fontStyle = (FontStyle)24;
					_lessThanAdayLeft = true;
					this._002Ector();
				}
				else
				{
					_lessThanAdayLeft = false;
					nint num9 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v60 (Il2CppClass<Strings>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num10 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S1_v69 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string format2 = Strings.GetDefault("TOPRUN_STATE_DAYS_LEFT_SINGLE_FORMAT");
					object obj19 = obj5 / 864000000000L;
					formatProvider = (IFormatProvider)obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] args2 = default;
					string text3 = string.Format(format2, args2);
					_timerLabel.fontSize = (int)text3;
					_timerLabel.fontStyle = (FontStyle)24;
				}
			}
		}
		nint num11 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v41 (Il2CppClass<Strings>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num12 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v50 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format3 = Strings.GetDefault("TOPRUN_WEEK_TITLE");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj21 = default;
		formatProvider = (IFormatProvider)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args3 = default;
		string text4 = string.Format(format3, args3);
		_currentTopRunWeek.fontSize = (int)text4;
		((RewardForVideoButton)(object)_timerLayout).Init((VideoButtonPayload)null);
	}

	public unsafe UITopRunTimer()
	{
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected Obj, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected VT, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got I4
		//IL_002b: Expected I, but got Obj
		//IL_0041: Expected Obj, but got I
		//IL_03a6: Expected Obj, but got VT
		//IL_03b3: Expected I8, but got Obj
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_03c8: Expected Ref, but got VT
		//IL_03d4: Expected Obj, but got I8
		//IL_006c: Expected I, but got Obj
		//IL_00b4: Expected F8, but got I4
		//IL_041c: Invalid comparison between I4 and F8
		//IL_00f1: Expected F8, but got I4
		//IL_012e: Expected F8, but got I4
		//IL_013d: Expected I4, but got F8
		//IL_029d: Expected I, but got Obj
		//IL_02b3: Expected Obj, but got I
		//IL_045c: Expected I4, but got Obj
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01ec: Expected I8, but got Obj
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_02de: Expected I, but got Obj
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_027f: Expected I4, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 32);
		DateTime dateTime = (DateTime)(obj + 24);
		object obj2 = obj + 8;
		object obj3 = obj + 40;
		object obj4 = obj + 16;
		obj4 = 0;
		if (~(_lessThanAdayLeft ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v27 (Il2CppClass<System.DateTime>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v52 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = default;
		obj2 = obj6;
		obj = today;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
		formatProvider = (IFormatProvider)obj;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj4 = num3;
		double num4 = (double)obj4 * 1E-07;
		if (num4 != num4)
		{
			num4 = -2147483648.0;
		}
		else if (!(num4 < 2147483648.0))
		{
			num4 = -2147483648.0;
		}
		else if (!(num4 > -2147483649.0))
		{
			num4 = -2147483648.0;
		}
		if ((double)_totalSeconds == num4)
		{
			return;
		}
		_totalSeconds = (int)num4;
		if ((nint)obj4 >= 1)
		{
			object obj7 = obj4 / 36000000000L;
			object obj8 = obj7 / 24;
			object obj9 = obj8 * 24;
			object obj10 = obj7 - obj9;
			formatProvider = (IFormatProvider)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj11 = obj4 / 600000000;
			object obj12 = obj11 / 60;
			object obj13 = obj12 * 60;
			ulong dateData = (ulong)(obj11 - obj13);
			((DateTime*)(nint)dateTime)->dateData = dateData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj14 = obj4 / 10000000;
			object obj15 = obj14 / 60;
			object obj16 = obj15 * 60;
			object obj17 = obj14 - obj16;
			obj3 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			object arg2 = default;
			string text = string.Format((IFormatProvider)(object)"{0:00}:{1:00}:{2:00}", format, arg, arg2);
			_timerLabel.fontSize = (int)text;
			return;
		}
		_lessThanAdayLeft = false;
		nint num5 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v30 (Il2CppClass<Strings>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num6 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v39 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("TOPRUN_STATE_NEXT_SOON");
		_timerLabel.fontSize = (int)text2;
		_timerLabel.fontStyle = (FontStyle)15;
		((RewardForVideoButton)(object)_timerLayout).Init((VideoButtonPayload)null);
	}
}
