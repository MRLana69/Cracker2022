using System;
using Cpp2ILInjected;
using InApp;
using Kiloo;
using UnityEngine;

public class UIDiscountTimer : MonoBehaviour
{
	private UILabel _timerLabel;

	private double endTimeDouble;

	private DateTime endTime;

	private TimeSpan timeLeft;

	private void Awake()
	{
		_ = -1;
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 12;
		UILabel component = GetComponent<UILabel>();
		obj = component;
	}

	private void Update()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got I4
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_00fe: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v25 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A292");
		double num3 = default;
		endTimeDouble = num3;
		object obj4 = obj2 + 8;
		obj4 = 0;
		throw new ArrayTypeMismatchException();
	}

	public unsafe UIDiscountTimer()
	{
		//IL_044c: Expected I, but got Obj
		//IL_0462: Expected Obj, but got I
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04b3: Expected Obj, but got VT
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04c9: Expected Obj, but got VT
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected VT, but got Unknown
		//IL_04e4: Expected I8, but got Obj
		//IL_04df: Expected native int or pointer, but got VT
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f2: Expected Obj, but got Unknown
		//IL_0507: Expected Ref, but got VT
		//IL_0513: Expected Obj, but got I8
		//IL_0525: Expected VT, but got Obj
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected Obj, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01eb: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_022c: Expected I, but got Obj
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_0601: Expected I8, but got Obj
		//IL_0609: Expected native int or pointer, but got VT
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected Obj, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_0679: Expected Obj, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_01bb: Expected I4, but got Obj
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v75 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 44;
		object obj4 = obj3 + 40;
		object obj5 = obj3 + 16;
		obj5 = endTime;
		object obj6 = obj3 + 8;
		obj6 = today;
		DateTime dateTime = (DateTime)(obj3 + 24);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj3 + 32);
		formatProvider = (IFormatProvider)obj6;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num3;
		formatProvider = (IFormatProvider)obj3;
		timeLeft = (TimeSpan)formatProvider;
		object obj7 = this + 32;
		if ((nint)obj7 < 1)
		{
			SendMessage("ForceEndDiscount", 1);
			return;
		}
		object obj8 = this + 32;
		object obj9 = obj8 / 864000000000L;
		if ((nint)obj9 < 1)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v90 (Il2CppClass<Strings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v98 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider = Strings.GetDefault("TIME_LEFT_HOURS");
			object obj11 = this + 32;
			object obj12 = obj11 / 36000000000L;
			object obj13 = obj12 / 24;
			object obj14 = obj13 * 24;
			object obj15 = obj12 - obj14;
			formatProvider = (IFormatProvider)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj16 = this + 32;
			object obj17 = obj16 / 600000000;
			object obj18 = obj17 / 60;
			object obj19 = obj18 * 60;
			ulong dateData = (ulong)(obj17 - obj19);
			((DateTime*)(nint)dateTime)->dateData = dateData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object obj20 = this + 32;
			object obj21 = obj20 / 10000000;
			object obj22 = obj21 / 60;
			object obj23 = obj22 * 60;
			object obj24 = obj21 - obj23;
			obj2 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			object arg2 = default;
			string text = string.Format((IFormatProvider)(object)provider, format, arg, arg2);
			_timerLabel.fontSize = (int)text;
			return;
		}
		object obj25 = this + 32;
		object obj26 = obj25 / 864000000000L;
		nint num6 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v37 (Il2CppClass<Strings>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v85 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string key = (((nint)obj26 != 1) ? "TIME_LEFT_DAYS_PLURAL" : "TIME_LEFT_DAYS_SINGULAR");
		string text2 = Strings.GetDefault(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj28 = this + 32;
		object obj29 = obj28 / 864000000000L;
		formatProvider = (IFormatProvider)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}
}
