using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Kiloo;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.Utility;
using UI.Pages;
using UI.Popups.LimitedBoardPopupInternal;
using UI.Popups.LimitedCharacterPopupInternal;
using UnityEngine;

namespace UI.Popups.LanguageSelectionPopupInternal;

public class LanguageCellController : MonoBehaviour
{
	private const string SPRITENAME_SELECTED = "icon_character_selected";

	private readonly Color32 _normalTextColor;

	private readonly Color32 _selectedTextColor;

	private UILabel _languageLabel;

	private UISprite _statusSprite;

	private Locale locale__BackingField;

	public Locale locale
	{
		get
		{
			//IL_016b: Expected I, but got Obj
			//IL_0181: Expected Obj, but got I
			//IL_0233: Expected I, but got Obj
			//IL_0249: Expected Obj, but got I
			//IL_01b0: Expected Obj, but got I4
			//IL_01c2: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_00b7: Expected I, but got Obj
			//IL_00cd: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_01d8: Expected Obj, but got I4
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected Obj, but got Unknown
			//IL_0153: Expected Obj, but got I4
			//IL_00f8: Expected I, but got Obj
			nint num = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			LimitedBoardPopupManager instance = LimitedBoardPopupManager.instance;
			bool flag = ((LimitedCharacterPopupManager)(object)instance).CurrentlyShownCharacterMatchesEventItem();
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v17 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			bool isShowingPopup = ((UIScreenController)flag2).isShowingPopup;
			bool flag3 = (string)isShowingPopup != "LimitedCharacterPopup";
			int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)this).currentlyShownThemeIndex;
			nint num5 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S2_v8 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v13 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = flag | flag3;
			bool flag4 = BoardManager.HasAllThemesBeenSeen((Boards.BoardId)currentlyShownThemeIndex);
			object obj5 = obj4 | flag4;
			if (obj5 != null)
			{
				return null;
			}
			bool flag5 = ((LimitedBoardPopupManager)(object)this).ShouldButtonBeVisible();
			return (Locale)flag5;
		}
		private set
		{
			//IL_0010: Expected VT, but got I4
			if ((string)(object)value != "LimitedBoardPopup")
			{
				_normalTextColor = (Color32)0;
				((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
			}
		}
	}

	public void UpdateContent(Locale newLocale)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 28;
		obj = newLocale;
	}

	public unsafe LanguageCellController()
	{
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03b4: Expected Obj, but got I4
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03cb: Expected Obj, but got I4
		//IL_03e3: Expected I, but got Obj
		//IL_03f9: Expected Obj, but got I
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected VT, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got VT
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_011f: Expected Obj, but got I4
		//IL_00fe: Expected Obj, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected Obj, but got Unknown
		//IL_0231: Expected Obj, but got VT
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_0140: Expected I, but got Obj
		//IL_0156: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got VT
		//IL_04b1: Expected I8, but got Obj
		//IL_04ac: Expected native int or pointer, but got VT
		//IL_04c6: Expected Ref, but got VT
		//IL_04d2: Expected Obj, but got I8
		//IL_04f4: Expected I, but got Obj
		//IL_050a: Expected Obj, but got I
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_0181: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_01ce: Expected I, but got Obj
		//IL_0591: Expected Obj, but got VT
		//IL_05a6: Expected I8, but got Obj
		//IL_05a1: Expected native int or pointer, but got VT
		//IL_05bb: Expected Ref, but got VT
		//IL_05c7: Expected Obj, but got I8
		//IL_05e9: Expected I, but got Obj
		//IL_05ff: Expected Obj, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0310: Expected I, but got Obj
		//IL_035d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 40;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		int currentlyShownThemeIndex = ((LimitedBoardPopupManager)(object)this).currentlyShownThemeIndex;
		nint num = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v86 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime dateTime = (DateTime)(obj2 - -64);
		object obj5 = obj2 + 48;
		object obj6 = obj2 + 32;
		TimeSpan timeSpan = BoardManager.BoardExpirationTimespan((Boards.BoardId)currentlyShownThemeIndex);
		int currentlyShownThemeIndex2 = ((LimitedBoardPopupManager)(object)this).currentlyShownThemeIndex;
		DateTime dateTime2 = BoardManager.BoardStartAvailabilityDate((Boards.BoardId)currentlyShownThemeIndex2);
		DateTime utcNow = CDateTime.UtcNow;
		obj = utcNow;
		CoroutineUtil.StopCoroutine((Coroutine)(object)_statusSprite);
		CoroutineUtil.StopCoroutine((Coroutine)(object)locale__BackingField);
		object obj7 = obj2 + 56;
		obj7 = timeSpan;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 72);
		formatProvider = (IFormatProvider)obj7;
		object obj8 = obj & 0x3FFFFFFFFFFFFFFFL;
		object obj9 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		object obj10;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
		{
			obj10 = 1;
		}
		else
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			object obj11 = (flag ? 1u : 0u) << 31;
			obj10 = obj11 >> 31;
		}
		if ((nint)obj10 <= -1)
		{
			nint num3 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v90 (Il2CppClass<System.DateTime>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num4 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v118 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj5 = timeSpan;
			obj6 = obj;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
			formatProvider = (IFormatProvider)obj6;
			long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj3 = num5;
			double num6 = (double)obj3 * 1E-07;
			nint num7 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v103 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num8 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v112 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj14 = this + 24;
			IEnumerator enumerator = ((PageTop)null).DelayCoroutine((float)num6, LimitedBoardPopupManager.OnLimitedBoardStartedHandler);
			obj14 = enumerator;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_statusSprite);
		}
		object obj15 = obj2 + 8;
		object obj16 = obj2 + 24;
		obj16 = dateTime2;
		formatProvider = (IFormatProvider)obj16;
		object obj17 = obj & 0x3FFFFFFFFFFFFFFFL;
		object obj18 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		object obj19;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18))
		{
			obj19 = 1;
		}
		else
		{
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj18);
			object obj20 = (flag2 ? 1u : 0u) << 31;
			obj19 = obj20 >> 31;
		}
		if ((nint)obj19 >= 0)
		{
			return;
		}
		nint num9 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v50 (Il2CppClass<System.DateTime>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num10 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v78 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj15 = dateTime2;
		obj2 = obj;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj15;
		formatProvider = (IFormatProvider)obj2;
		long num11 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj3 = num11;
		double num12 = (double)obj3 * 1E-07;
		nint num13 = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v63 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num14 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v72 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj23 = this + 28;
		IEnumerator enumerator2 = ((PageTop)null).DelayCoroutine((float)num12, LimitedBoardPopupManager.OnLimitedBoardExpiredHandler);
		obj23 = enumerator2;
		Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)locale__BackingField);
	}
}
