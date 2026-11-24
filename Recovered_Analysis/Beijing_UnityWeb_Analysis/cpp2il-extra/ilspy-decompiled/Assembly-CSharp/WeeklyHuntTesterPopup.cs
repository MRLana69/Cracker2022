using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Screens;
using WeeklyHunt;

public class WeeklyHuntTesterPopup : UIScreen
{
	private enum PeriodTiming
	{
		None,
		Beginning,
		FiveMinsToExpiry,
		ThirtySecsToExpiry
	}

	private enum ProgressStates
	{
		None,
		Zero,
		AlmostComplete,
		Complete
	}

	private SelectPopupButton _weekSelectPopupButton;

	private SelectPopupButton _timingSelectPopupButton;

	private SelectPopupButton _progressStatesPopupButton;

	private WeeklyHuntData.PrizePeriodId _selectedPeriod;

	private PeriodTiming _periodTiming;

	private ProgressStates _progressState;

	private void Start()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72D5");
	}

	public unsafe void OnWeekSelected()
	{
		//IL_02ff: Expected I, but got Obj
		//IL_0315: Expected Obj, but got I
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected I, but got Unknown
		//IL_03ec: Expected I, but got Obj
		//IL_0407: Expected I, but got Obj
		//IL_041d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_038e: Expected VT, but got I4
		//IL_039c: Expected VT, but got Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_018b: Expected I, but got Obj
		//IL_0123: Expected I, but got Obj
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_022b: Expected I4, but got Obj
		//IL_024b: Expected I, but got Obj
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_02eb: Expected I4, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v55 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = typeof(WeeklyHuntData.PrizePeriodId);
		nint num3 = (nint)(obj3 + 12);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type enumType = Type.internal_from_handle((IntPtr)num3);
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v11 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v69 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] source = Enum.InternalGetNames((System.RuntimeType)enumType);
		List<string> list = Enumerable.ToList(source);
		SelectPopupButton weekSelectPopupButton = _weekSelectPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(WeeklyHuntTesterPopup.OnWeekSelected);
		object obj5 = callback + 16;
		obj5 = this;
		nint num6 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v25 (Il2CppClass<EventDelegate>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num7 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v65 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(weekSelectPopupButton.onChange, callback);
		_00210 y = (_00210)(list._size - 1);
		int characterId = ((System.Collections.Generic.ObjectComparer<T>)(object)list).Compare((T)null, (T)y);
		((PurchaseHandler)(object)_weekSelectPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)characterId, (string)null);
		object obj7 = obj3 + 4;
		obj7 = typeof(PeriodTiming);
		((IntPtr*)num3)->m_value = (void*)(nint)obj7;
		Type enumType2 = Type.internal_from_handle((IntPtr)num3);
		string[] source2 = Enum.InternalGetNames((System.RuntimeType)enumType2);
		List<string> list2 = Enumerable.ToList(source2);
		SelectPopupButton timingSelectPopupButton = _timingSelectPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		EventDelegate.Callback callback2 = default;
		((Delegate)callback2).method_ptr = method_ptr2;
		((Delegate)callback2).method = (nint)__ldftn(WeeklyHuntTesterPopup.OnTimeSelected);
		object obj8 = callback2 + 16;
		obj8 = this;
		bool flag2 = EventDelegate.Remove(timingSelectPopupButton.onChange, callback2);
		((PurchaseHandler)(object)_timingSelectPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list2, (string)null);
		obj3 = typeof(ProgressStates);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type enumType3 = Type.internal_from_handle((IntPtr)num3);
		string[] source3 = Enum.InternalGetNames((System.RuntimeType)enumType3);
		List<string> list3 = Enumerable.ToList(source3);
		SelectPopupButton progressStatesPopupButton = _progressStatesPopupButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		EventDelegate.Callback callback3 = default;
		((Delegate)callback3).method_ptr = method_ptr3;
		((Delegate)callback3).method = (nint)__ldftn(WeeklyHuntTesterPopup.OnProgressSelected);
		object obj9 = callback3 + 16;
		obj9 = this;
		bool flag3 = EventDelegate.Remove(progressStatesPopupButton.onChange, callback3);
		((PurchaseHandler)(object)_progressStatesPopupButton).OnPurchaseCharacterWithInappSucceded((Characters.CharacterId)list3, (string)null);
	}

	public unsafe void OnTimeSelected()
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected I, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton weekSelectPopupButton = _weekSelectPopupButton;
		string text = weekSelectPopupButton.value__BackingField;
		if (weekSelectPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v41 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(WeeklyHuntData.PrizePeriodId);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type enumType = Type.internal_from_handle((IntPtr)num);
		SelectPopupButton weekSelectPopupButton2 = _weekSelectPopupButton;
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (Il2CppClass<System.Enum>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Enum.GetName(enumType, weekSelectPopupButton2.value__BackingField);
		throw new NullReferenceException();
	}

	public unsafe void OnProgressSelected()
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected I, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton timingSelectPopupButton = _timingSelectPopupButton;
		string text = timingSelectPopupButton.value__BackingField;
		if (timingSelectPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v41 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(PeriodTiming);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type enumType = Type.internal_from_handle((IntPtr)num);
		SelectPopupButton timingSelectPopupButton2 = _timingSelectPopupButton;
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (Il2CppClass<System.Enum>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Enum.GetName(enumType, timingSelectPopupButton2.value__BackingField);
		throw new NullReferenceException();
	}

	public unsafe void SaveAndClose()
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected I, but got Unknown
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_018d: Expected I, but got Obj
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 4);
		SelectPopupButton progressStatesPopupButton = _progressStatesPopupButton;
		string text = progressStatesPopupButton.value__BackingField;
		if (progressStatesPopupButton.value__BackingField == null || text.m_stringLength == 0)
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v41 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(ProgressStates);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type enumType = Type.internal_from_handle((IntPtr)num);
		SelectPopupButton progressStatesPopupButton2 = _progressStatesPopupButton;
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v32 (Il2CppClass<System.Enum>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Enum.GetName(enumType, progressStatesPopupButton2.value__BackingField);
		throw new NullReferenceException();
	}

	public void ResetWeeklyHunt()
	{
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0478: Expected I, but got Obj
		//IL_048e: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0521: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		//IL_036f: Expected I, but got Obj
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0206: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_0294: Expected I, but got Obj
		//IL_02e1: Expected I, but got Obj
		//IL_02f7: Expected Obj, but got I
		//IL_0322: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData.PrizePeriodId activePeriod = WeeklyHuntData.GetActivePeriod();
		if (_selectedPeriod != WeeklyHuntData.PrizePeriodId.None)
		{
			nint num3 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v46 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v56 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((_periodTiming == PeriodTiming.FiveMinsToExpiry) ? (-300) : 0);
			WeeklyHuntData.DebugSetProgress(progress: (_periodTiming != PeriodTiming.ThirtySecsToExpiry) ? num5 : (-30), period: (int)_selectedPeriod);
		}
		if (_progressState != ProgressStates.None)
		{
			WeeklyHuntData.WeeklyHuntPeriodData weeklyHuntPeriodData = ((Dictionary<int, WeeklyHuntData.WeeklyHuntPeriodData>)activePeriod).get_Item((int)_selectedPeriod);
			object obj3 = _progressState - 1;
			if (_progressState != ProgressStates.Zero)
			{
				if ((nint)obj3 != 1)
				{
					if ((nint)obj3 == 2)
					{
						nint num6 = (nint)typeof(WeeklyHuntData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v32 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num7 = (nint)typeof(WeeklyHuntData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v37 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						WeeklyHuntData.PrizeData prizeForPeriod = WeeklyHuntManager.GetPrizeForPeriod((WeeklyHuntData.PrizePeriodId)weeklyHuntPeriodData.itemsToCollect);
					}
				}
				else
				{
					nint num8 = (nint)typeof(WeeklyHuntData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v21 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num9 = (nint)typeof(WeeklyHuntData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v27 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					WeeklyHuntData.PrizePeriodId periodId = (WeeklyHuntData.PrizePeriodId)(weeklyHuntPeriodData.itemsToCollect - 1);
					WeeklyHuntData.PrizeData prizeForPeriod2 = WeeklyHuntManager.GetPrizeForPeriod(periodId);
				}
			}
			else
			{
				nint num10 = (nint)typeof(WeeklyHuntData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v11 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(WeeklyHuntData);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v16 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				WeeklyHuntData.PrizeData prizeForPeriod3 = WeeklyHuntManager.GetPrizeForPeriod(WeeklyHuntData.PrizePeriodId.None);
			}
		}
		nint num12 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v19 (Il2CppClass<UIScreenController>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num13 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v25 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}

	public WeeklyHuntTesterPopup()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WeeklyHuntData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(WeeklyHuntData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<WeeklyHunt.WeeklyHuntData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WeeklyHuntData._002Ecctor();
	}
}
