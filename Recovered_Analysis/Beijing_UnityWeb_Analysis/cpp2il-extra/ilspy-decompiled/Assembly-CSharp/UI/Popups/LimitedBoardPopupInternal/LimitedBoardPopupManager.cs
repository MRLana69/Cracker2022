using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using Kiloo;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UI.Popups.LanguageSelectionPopupInternal;
using UI.Popups.LimitedCharacterPopupInternal;
using UnityEngine;

namespace UI.Popups.LimitedBoardPopupInternal;

public class LimitedBoardPopupManager
{
	private sealed class _003CTimer_003Ed__28(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public float timeLeft;

		public Action handler;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Expected Obj, but got Unknown
				//IL_00a0: Expected Obj, but got I4
				//IL_00b4: Expected Obj, but got I4
				//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cf: Expected Obj, but got Unknown
				//IL_00d8: Expected Obj, but got I4
				//IL_00ec: Expected Obj, but got I4
				//IL_017b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0180: Expected Obj, but got Unknown
				//IL_0189: Expected Obj, but got I4
				//IL_019d: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								return null;
							}
							_003C_003E1__state = -1;
						}
						else
						{
							_003C_003E1__state = -1;
							_003CstartPoint_003E5__2 = 0f;
						}
						if (_003CstartPoint_003E5__2 < timeLeft)
						{
							float aspectRatio = Utils.GetAspectRatio();
							float num = _003CstartPoint_003E5__2 + aspectRatio;
							_003CstartPoint_003E5__2 = num;
							object obj = this + 12;
							obj = 0;
							_003C_003E1__state = 3;
							return 1;
						}
						if (handler != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						return null;
					}
					_003C_003E1__state = -1;
					object obj2 = this + 12;
					obj2 = 0;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				object obj3 = this + 12;
				obj3 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static Action m_OnLimitedBoardStartedHandler;

	private static Action m_OnLimitedBoardExpiredHandler;

	private const Boards.BoardId CURRENT_BOARD_TYPE = Boards.BoardId.normal;

	private bool _overwrittenBoardForNextShowing;

	private Boards.BoardId _overwrittenBoard;

	private int currentlyShownThemeIndex__BackingField;

	private static LimitedBoardPopupManager _instance;

	private bool _isInitialized;

	private IEnumerator _startTimerCoroutine;

	private IEnumerator _endTimerCoroutine;

	public Boards.BoardId currentBoardId
	{
		get
		{
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected Obj, but got Unknown
			//IL_014d: Expected Obj, but got I4
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected Obj, but got Unknown
			//IL_0164: Expected Obj, but got I4
			//IL_016d: Expected Obj, but got I4
			//IL_017b: Expected I, but got Obj
			//IL_0191: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			obj = 0;
			object obj3 = obj2 + 8;
			obj3 = 0;
			obj2 = 0;
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v51 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj5 = default;
				if ((nint)obj5 == 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
					_ = 1;
					object obj6 = default;
					obj3 = obj6;
					if (obj != null)
					{
						obj2 = obj3;
						bool isInstanced = UIScreenController.IsInstanced;
						object obj7 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v41 (System.Boolean)+84]");
						bool flag = obj7 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						bool flag2 = (nint)0 != 0;
						return (flag & flag2) ? Boards.BoardId.bouncer : Boards.BoardId.normal;
					}
					return Boards.BoardId.normal;
				}
				return Boards.BoardId.normal;
			}
			return Boards.BoardId.normal;
		}
	}

	public int currentlyShownThemeIndex
	{
		get
		{
			//IL_0022: Expected I, but got Obj
			//IL_0038: Expected Obj, but got I
			//IL_0063: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			//IL_00c6: Expected Obj, but got I
			//IL_00f1: Expected I, but got Obj
			if (~(_overwrittenBoardForNextShowing ? 1u : 0u) == 0)
			{
				return (int)_overwrittenBoard;
			}
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v31 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_LIMITED_BOARD_POPUP ? 1u : 0u) == 0)
			{
				nint num3 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18 (Il2CppClass<Globals>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25 (Il2CppClass<Globals>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				return (int)Globals.debugLimitedBoardPopupId;
			}
			return 0;
		}
		set
		{
			_overwrittenBoard = (Boards.BoardId)value;
			_overwrittenBoardForNextShowing = true;
		}
	}

	public static LimitedBoardPopupManager instance
	{
		get
		{
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0210: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0130: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_01c6: Expected Obj, but got I
			//IL_00c7: Expected I, but got Obj
			//IL_00f7: Expected I, but got Obj
			//IL_011d: Expected I, but got Obj
			nint num = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (LimitedCharacterPopupManager._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				LimitedCharacterPopupManager limitedCharacterPopupManager = default;
				limitedCharacterPopupManager.Initialize();
				nint num3 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 == null;
				nint num4 = (nint)typeof(LimitedCharacterPopupManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(LimitedCharacterPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(LimitedCharacterPopupManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(LimitedCharacterPopupManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				obj3 = limitedCharacterPopupManager;
			}
			nint num6 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (LimitedBoardPopupManager)(object)LimitedCharacterPopupManager._instance;
		}
	}

	public unsafe static event Action OnLimitedBoardStartedHandler
	{
		add
		{
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b1: Expected Obj, but got Unknown
			//IL_03ba: Expected Obj, but got I4
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c8: Expected Obj, but got Unknown
			//IL_03d1: Expected Obj, but got I4
			//IL_03e9: Expected I, but got Obj
			//IL_03ff: Expected Obj, but got I
			//IL_0425: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Expected VT, but got Unknown
			//IL_0433: Unknown result type (might be due to invalid IL or missing references)
			//IL_0438: Expected Obj, but got Unknown
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Expected Obj, but got Unknown
			//IL_0063: Expected Obj, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			//IL_009a: Expected Obj, but got VT
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected Obj, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Obj, but got Unknown
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_0125: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I4
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Expected Obj, but got Unknown
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Expected Obj, but got Unknown
			//IL_0237: Expected Obj, but got VT
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected Obj, but got Unknown
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected Obj, but got Unknown
			//IL_02b4: Expected Obj, but got I4
			//IL_0146: Expected I, but got Obj
			//IL_015c: Expected Obj, but got I
			//IL_0293: Expected Obj, but got I4
			//IL_04a2: Expected Obj, but got VT
			//IL_04b7: Expected I8, but got Obj
			//IL_04b2: Expected native int or pointer, but got VT
			//IL_04cc: Expected Ref, but got VT
			//IL_04d8: Expected Obj, but got I8
			//IL_04fa: Expected I, but got Obj
			//IL_0510: Expected Obj, but got I
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Expected Obj, but got Unknown
			//IL_0187: Expected I, but got Obj
			//IL_02d5: Expected I, but got Obj
			//IL_02eb: Expected Obj, but got I
			//IL_01d4: Expected I, but got Obj
			//IL_059d: Expected Obj, but got VT
			//IL_05b2: Expected I8, but got Obj
			//IL_05ad: Expected native int or pointer, but got VT
			//IL_05c7: Expected Ref, but got VT
			//IL_05d3: Expected Obj, but got I8
			//IL_05f5: Expected I, but got Obj
			//IL_060b: Expected Obj, but got I
			//IL_0631: Unknown result type (might be due to invalid IL or missing references)
			//IL_0636: Expected Obj, but got Unknown
			//IL_065f: Expected Obj, but got I
			//IL_0316: Expected I, but got Obj
			//IL_0363: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 40;
			obj = 0;
			object obj3 = obj2 + 16;
			obj3 = 0;
			int currentThemeIndex = ((LimitedCharacterPopupManager)null).currentThemeIndex;
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v86 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime dateTime = (DateTime)(obj2 - -64);
			object obj5 = obj2 + 48;
			object obj6 = obj2 + 32;
			TimeSpan timeSpan = CharacterManager.CharacterExpirationTimespan((Characters.CharacterId)currentThemeIndex);
			int currentThemeIndex2 = ((LimitedCharacterPopupManager)null).currentThemeIndex;
			DateTime dateTime2 = CharacterManager.CharacterStartAvailabilityDate((Characters.CharacterId)currentThemeIndex2);
			DateTime utcNow = CDateTime.UtcNow;
			obj = utcNow;
			CoroutineUtil.StopCoroutine((Coroutine)((Delegate)value).m_target);
			CoroutineUtil.StopCoroutine((Coroutine)(nint)((Delegate)value).method);
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
				nint num7 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v103 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num8 = (nint)typeof(LimitedCharacterPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v112 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj14 = value + 16;
				IEnumerator enumerator = ((LimitedBoardPopupManager)null).Timer((float)num6, LimitedCharacterPopupManager.OnLimitedCharacterStartedHandler);
				obj14 = enumerator;
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])((Delegate)value).m_target);
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
			nint num13 = (nint)typeof(LimitedCharacterPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v63 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num14 = (nint)typeof(LimitedCharacterPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v72 (Il2CppClass<UI.Popups.LimitedCharacterPopupInternal.LimitedCharacterPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj23 = value + 20;
			IEnumerator enumerator2 = ((LimitedBoardPopupManager)null).Timer((float)num12, LimitedCharacterPopupManager.OnLimitedCharacterExpiredHandler);
			obj23 = enumerator2;
			Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(nint)((Delegate)value).method);
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onLimitedBoardStartedHandler = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
			Action onLimitedBoardStartedHandler2 = default;
			while (true)
			{
				Delegate obj2 = onLimitedBoardStartedHandler.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(LimitedBoardPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler == onLimitedBoardStartedHandler)
				{
					LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler = onLimitedBoardStartedHandler2;
				}
				if ((object)LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler != onLimitedBoardStartedHandler)
				{
					onLimitedBoardStartedHandler = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
					continue;
				}
				break;
			}
		}
	}

	public static event Action OnLimitedBoardExpiredHandler
	{
		add
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate onLimitedBoardStartedHandler = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
			Action onLimitedBoardStartedHandler2 = default;
			while (true)
			{
				Delegate obj2 = onLimitedBoardStartedHandler.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(LimitedBoardPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler == onLimitedBoardStartedHandler)
				{
					LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler = onLimitedBoardStartedHandler2;
				}
				if ((object)LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler != onLimitedBoardStartedHandler)
				{
					onLimitedBoardStartedHandler = LimitedBoardPopupManager.m_OnLimitedBoardStartedHandler;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(LimitedBoardPopupManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(LimitedBoardPopupManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(LimitedBoardPopupManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(LimitedBoardPopupManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public void OverrideNextShowingWithBoard(Boards.BoardId board)
	{
		_overwrittenBoardForNextShowing = (byte)board != 0;
	}

	private LimitedBoardPopupManager()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LimitedBoardPopupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = LimitedBoardPopupManager.m_OnLimitedBoardExpiredHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(LimitedBoardPopupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(LimitedBoardPopupManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(LimitedBoardPopupManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(LimitedBoardPopupManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(LimitedBoardPopupManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Popups.LimitedBoardPopupInternal.LimitedBoardPopupManager>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private void Initialize()
	{
		if (~(_isInitialized ? 1u : 0u) != 0)
		{
			StartTimer();
		}
	}

	private void OnPopupClosed(string s)
	{
		//IL_000a: Expected I4, but got Obj
		currentlyShownThemeIndex__BackingField = (int)s;
	}

	public bool IsBoardAvailable()
	{
		return (byte)currentlyShownThemeIndex__BackingField != 0;
	}

	public bool ShouldButtonBeVisible()
	{
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_026c: Expected I, but got Obj
		//IL_0282: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected Obj, but got Unknown
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0109: Expected Obj, but got VT
		//IL_0111: Expected Obj, but got VT
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_00b9: Expected I, but got Obj
		//IL_018e: Expected Obj, but got I4
		//IL_016d: Expected Obj, but got I4
		//IL_01a9: Expected Obj, but got VT
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Globals>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v58 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		object obj5 = obj2 + 8;
		if (~(Globals.DEBUG_LIMITED_BOARD_POPUP_IGNORE_EXPIRE ? 1u : 0u) == 0)
		{
			return true;
		}
		int boardId = currentlyShownThemeIndex;
		nint num3 = (nint)typeof(BoardManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v12 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v45 (Il2CppClass<Data.Managers.BoardManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime dateTime = BoardManager.BoardStartAvailabilityDate((Boards.BoardId)boardId);
		int boardId2 = currentlyShownThemeIndex;
		TimeSpan timeSpan = BoardManager.BoardExpirationTimespan((Boards.BoardId)boardId2);
		DateTime utcNow = CDateTime.UtcNow;
		obj = utcNow;
		obj5 = timeSpan;
		obj4 = obj5;
		object obj7 = obj & 0x3FFFFFFFFFFFFFFFL;
		object obj8 = obj4 & 0x3FFFFFFFFFFFFFFFL;
		object obj9;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			obj9 = 1;
		}
		else
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj10 = (flag ? 1u : 0u) << 31;
			obj9 = obj10 >> 31;
		}
		if ((nint)obj9 > 0)
		{
			obj2 = dateTime;
			obj4 = obj2;
			object obj11 = obj & 0x3FFFFFFFFFFFFFFFL;
			object obj12 = obj4 & 0x3FFFFFFFFFFFFFFFL;
			object obj13;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				obj13 = 1;
			}
			else
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12);
				object obj14 = (flag2 ? 1u : 0u) << 31;
				obj13 = obj14 >> 31;
			}
			return (nint)obj13 < 0;
		}
		return false;
	}

	private unsafe void StartTimer()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(LimitedBoardPopupManager.StartTimer);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v33 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnPopupClosed -= action2;
		((LanguageCellController)this)._002Ector();
		_isInitialized = true;
	}

	private IEnumerator Timer(float timeLeft, Action handler)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = handler;
		return enumerator;
	}
}
