using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AppRefresh;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Ionic.Zlib;
using Missions;
using SYBO.Common.Utilities;
using SYBO.Components.Analytics;
using SYBO.Subway.Info;
using UI.Screens;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.UI;

public class SSEventsManagerController
{
	private sealed class _003CTimerToEventStart_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public long timeLeft;

		public SSEventsManagerController _003C_003E4__this;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_006a: Invalid comparison between F4 and I8
				//IL_00f2: Expected I, but got Obj
				//IL_0108: Expected Obj, but got I
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Expected Obj, but got Unknown
				//IL_00c1: Expected Obj, but got I4
				//IL_00d5: Expected Obj, but got I4
				//IL_0133: Expected I, but got Obj
				//IL_017f: Expected F8, but got I8
				//IL_035c: Expected I, but got Obj
				//IL_0372: Expected Obj, but got I
				//IL_01c0: Expected F8, but got I8
				//IL_0201: Expected F8, but got I8
				//IL_0214: Expected I, but got Obj
				//IL_0261: Expected I, but got Obj
				//IL_0277: Expected Obj, but got I
				//IL_02a2: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
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
				if (_003CstartPoint_003E5__2 < (float)timeLeft)
				{
					float aspectRatio = Utils.GetAspectRatio();
					float num = _003CstartPoint_003E5__2 + aspectRatio;
					_003CstartPoint_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				double num2 = ((SYBO.Components.Analytics.SyboRandom)null).NextDouble();
				nint num3 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v17 (Il2CppClass<Data.Save.EventsSave>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(EventsSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v63 (Il2CppClass<Data.Save.EventsSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (num2 != num2)
				{
					num2 = -9.223372036854776E+18;
				}
				else if (!(num2 < 9.223372036854776E+18))
				{
					num2 = -9.223372036854776E+18;
				}
				else if (!(num2 > -9.223372036854776E+18))
				{
					num2 = -9.223372036854776E+18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9226");
				_003C_003E4__this._002Ector();
				nint num5 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v26 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v49 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (SSEventsManagerController.m_OnSSEventStartedHandler != null)
				{
					nint num7 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v36 (Il2CppClass<SSEventsManagerController>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(SSEventsManagerController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v43 (Il2CppClass<SSEventsManagerController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CTimerToEventStart_003Ed__37(int _003C_003E1__state)
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			this._003C_003E1__state = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_000f: Expected Obj, but got I4
			//IL_002b: Expected I4, but got Obj
			object obj = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			return (byte)(int)$"[LetterCollectedEventArgs: l={args}" != 0;
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

	private sealed class _003CTimerToEventFinish_003Ed__38(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public long timeLeft;

		public SSEventsManagerController _003C_003E4__this;

		private float _003CstartPoint_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_006a: Invalid comparison between F4 and I8
				//IL_00f3: Expected I, but got Obj
				//IL_0109: Expected Obj, but got I
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b8: Expected Obj, but got Unknown
				//IL_00c1: Expected Obj, but got I4
				//IL_00d5: Expected Obj, but got I4
				//IL_0134: Expected I, but got Obj
				//IL_0181: Expected I, but got Obj
				//IL_0197: Expected Obj, but got I
				//IL_01c2: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
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
				if (_003CstartPoint_003E5__2 < (float)timeLeft)
				{
					float aspectRatio = Utils.GetAspectRatio();
					float num = _003CstartPoint_003E5__2 + aspectRatio;
					_003CstartPoint_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				_003C_003E4__this._002Ector();
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v39 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (SSEventsManagerController.m_OnSSEventFinishedHandler != null)
				{
					nint num4 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v26 (Il2CppClass<SSEventsManagerController>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num5 = (nint)typeof(SSEventsManagerController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v33 (Il2CppClass<SSEventsManagerController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
				return null;
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

	public static bool HasLoggedRouteEventWarning;

	public const string ONLINE_SETTING_EVENT_ID = "event_id";

	public const string ONLINE_SETTING_EVENT_START = "event_start";

	public const string ONLINE_SETTING_EVENT_END = "event_end";

	public const string ONLINE_SETTING_EVENT_VALUE = "event_value";

	public const string ONLINE_SETTING_EVENT_TYPE = "event_type";

	public const string ONLINE_SETTING_TITLE_FIRST = "event_popup_title_first";

	public const string ONLINE_SETTING_TITLE_SECOND = "event_popup_title_second";

	public const string ONLINE_SETTING_DESCRIPTION_FIRST = "event_popup_description_first";

	public const string ONLINE_SETTING_DESCRIPTION_SECOND = "event_popup_description_second";

	public const string ONLINE_SETTING_EVENT_CATEGORY = "event_category";

	public const string ONLINE_SETTING_EVENT_RIBBON_TEXT = "event_ribbon_text";

	public const string ONLINE_SETTING_EVENT_MEGA_JACKPOT_MB_VALUE = "event_jackpot_mysterybox_value";

	public const string ONLINE_SETTING_EVENT_MEGA_JACKPOT_SMB_VALUE = "event_jackpot_supermysterybox_value";

	private IEventManager _currentEventManager;

	private static GameObject _eventTimerGameObject;

	private static MonoBehaviour _eventTimerMono;

	private bool _isInitialized;

	private static Action m_OnSSEventStartedHandler;

	private static Action m_OnSSEventFinishedHandler;

	private static Action m_OnSSEventChangedHandler;

	private static SSEventsManagerController _instance;

	public static SSEventsManagerController instance
	{
		get
		{
			//IL_0069: Expected I, but got Obj
			//IL_007f: Expected Obj, but got I
			//IL_00b3: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			int currentOutfitIndex = PlayerSave.currentOutfitIndex;
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v10 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = currentOutfitIndex >= SaveMeManager.NUMBER_OF_RUNS_BEFORE_SAVE_ME_FUNCTIONALITY;
			return (SSEventsManagerController)flag;
		}
	}

	public static event Action OnSSEventStartedHandler
	{
		add
		{
			((Delegate)value).method_ptr = (IntPtr)1;
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
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SSEventsManagerController.m_OnSSEventStartedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SSEventsManagerController);
				if (!flag)
				{
					nint num5 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SSEventsManagerController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SSEventsManagerController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
				object obj5 = (nint)0 + (nint)12;
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

	public static event Action OnSSEventFinishedHandler
	{
		add
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
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SSEventsManagerController.m_OnSSEventStartedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SSEventsManagerController);
				if (!flag)
				{
					nint num5 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SSEventsManagerController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SSEventsManagerController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
				object obj5 = (nint)0 + (nint)12;
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
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SSEventsManagerController.m_OnSSEventFinishedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SSEventsManagerController);
				if (!flag)
				{
					nint num5 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SSEventsManagerController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SSEventsManagerController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
				object obj5 = (nint)0 + (nint)16;
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

	public static event Action OnSSEventChangedHandler
	{
		add
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
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SSEventsManagerController.m_OnSSEventFinishedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SSEventsManagerController);
				if (!flag)
				{
					nint num5 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SSEventsManagerController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SSEventsManagerController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
				object obj5 = (nint)0 + (nint)16;
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
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SSEventsManagerController.m_OnSSEventChangedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SSEventsManagerController);
				if (!flag)
				{
					nint num5 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SSEventsManagerController);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SSEventsManagerController);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
				object obj5 = (nint)0 + (nint)20;
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

	public void Initialize()
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
		nint num = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = SSEventsManagerController.m_OnSSEventChangedHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(SSEventsManagerController);
			if (!flag)
			{
				nint num5 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SSEventsManagerController>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(SSEventsManagerController);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(SSEventsManagerController);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
			object obj5 = (nint)0 + (nint)20;
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

	private void OnHasRefreshed(RefreshType refreshType)
	{
		//IL_0724: Expected I, but got Obj
		//IL_073a: Expected Obj, but got I
		//IL_0015: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0382: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_03cf: Expected I, but got Obj
		//IL_03e5: Expected Obj, but got I
		//IL_0494: Expected Obj, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04c5: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I4
		//IL_0410: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I
		//IL_0151: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_0100: Expected Obj, but got I4
		//IL_0513: Expected Obj, but got I
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected Obj, but got Unknown
		//IL_053e: Expected Obj, but got I
		//IL_0550: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_0192: Expected I, but got Obj
		//IL_021c: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_057d: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got I
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05cb: Expected Obj, but got I4
		//IL_05e1: Expected Obj, but got I4
		//IL_05fb: Expected I, but got Obj
		//IL_0611: Expected Obj, but got I
		//IL_0637: Expected Obj, but got I4
		//IL_0645: Expected I, but got Obj
		//IL_065b: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected Obj, but got Unknown
		//IL_06b7: Expected Obj, but got I
		//IL_06c9: Expected Obj, but got I
		//IL_02aa: Expected I, but got Obj
		//IL_034b: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_02f7: Expected I, but got Obj
		//IL_0364: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v11+8]");
			string characterDisplayName = ((CharacterNameEventManager)this).GetCharacterDisplayName(Characters.CharacterId.slick);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
			object obj2 = 0;
			object obj3 = characterDisplayName.m_firstChar - 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v40+C]");
			_0021_00211[] array;
			if (0 < (nint)obj3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v104+C]");
				if ((nint)0 > (nint)(-1))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v35+C]");
					int startIndex = (int)((nint)0 + (nint)1);
					int num = Array.IndexOf((char[])(object)characterDisplayName, (char)refreshType, startIndex);
					array = (_0021_00211[])num;
				}
				else
				{
					array = (_0021_00211[])(object)Array.ConvertAll<TInput, TOutput>((TInput[])(object)characterDisplayName, (Converter<TInput, TOutput>)refreshType);
				}
			}
			else
			{
				array = (_0021_00211[])(-1);
			}
			bool flag = (nint)array > -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
			object obj6 = 0;
			_0021_00211[] array2 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v9+C]");
			object obj7 = array2 - 0;
			bool flag2 = (nint)obj7 == 1;
			object obj8 = flag & flag2;
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
				object obj9 = 0;
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v49 (Il2CppClass<UIScreenController>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num3 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v98 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				text.m_stringLength = 14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S2_v14+C]");
				_ = 0;
				object obj12 = text + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S3_v8+8]");
				string text2 = ((CharacterNameEventManager)this).FilterCharacterName((string)0);
				obj12 = text2;
				((UIScreenController)flag3)._QueueMessage(text);
				if (((CharacterNameEventManager)this).IsFirstCharacterSelected())
				{
					nint num4 = (nint)typeof(MysteryBox);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v60 (Il2CppClass<MysteryBox>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num5 = (nint)typeof(MysteryBox);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v94 (Il2CppClass<MysteryBox>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int megaJackpotAmount = MysteryBox.GetMegaJackpotAmount(MysteryBox.Type.Super);
					_ = 13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S1_v37+10]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S2_v22+18]");
					object obj17 = num6 + 0;
					object obj18 = obj17 + 1;
					object obj19 = megaJackpotAmount + 84;
					int hashCode = ((StringComparer)null).GetHashCode((object)characterDisplayName);
					obj19 = hashCode;
					_ = 9;
					_ = -1;
					nint num7 = (nint)typeof(RewardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v72 (Il2CppClass<RewardManager>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num8 = (nint)typeof(RewardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v90 (Il2CppClass<RewardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					RewardManager.AddMysteryBoxToUnlock((CelebrationReward)megaJackpotAmount);
					nint num9 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v78 (Il2CppClass<UIScreenController>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num10 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v86 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag4 = UIScreenController.ShouldShowOnlineScreen();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					string text3 = default;
					text3.m_stringLength = 15;
					object obj22 = text3 + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S3_v13+8]");
					string text4 = ((CharacterNameEventManager)this).FilterCharacterName((string)0);
					obj22 = text4;
					((UIScreenController)flag4)._QueueMessage(text3);
					((NewMonoBehaviour)31)._002Ector();
					((NewMonoBehaviour)34)._002Ector();
				}
				((CharacterNameEventManager)this).SkipCurrentCharacter();
			}
		}
		nint num11 = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v9 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num12 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v31 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (CharacterNameEventManager.OnLetterCollected == null)
		{
			return;
		}
		nint num13 = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v18 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num14 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v25 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_003CTimerToEventStart_003Ed__37 obj26 = default;
		obj26._002Ector((int)refreshType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	public IEventManager GetActiveEventManager(SSEventType desiredEventType = SSEventType.None)
	{
		//IL_00ca: Expected Obj, but got I4
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_00a0: Expected I4, but got Obj
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		object obj = 0;
		nint num = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<CharacterNameEventManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(CharacterNameEventManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v28 (Il2CppClass<CharacterNameEventManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = CharacterNameEventManager.FILTERED_CHARACTERS + 12;
		object obj4 = default;
		string text = default;
		int startIndex = default;
		object obj8 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			object obj5 = CharacterNameEventManager.FILTERED_CHARACTERS + 16;
			object obj6 = obj4 << 1;
			object obj7 = obj5 + obj6;
			obj = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			text = text.Remove(startIndex, (int)"");
			obj4 = obj8 + 1;
		}
		return (IEventManager)(object)text;
	}

	public unsafe T GetTypeOfActiveEventManager<T>()
	{
		//IL_050e: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I4
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I4
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected Obj, but got Unknown
		//IL_04b3: Expected Obj, but got I
		//IL_04c3: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected Obj, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I4
		//IL_0118: Expected VT, but got I4
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected Obj, but got Unknown
		//IL_056f: Expected Obj, but got I
		//IL_057a: Expected Obj, but got I4
		//IL_0583: Expected VT, but got I4
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0487: Expected Obj, but got I
		//IL_0493: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I4
		//IL_0163: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_0427: Expected VT, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I
		//IL_02ee: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I4
		//IL_0316: Expected Obj, but got I
		//IL_0326: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_054f: Expected VT, but got Obj
		//IL_0399: Expected Obj, but got I
		//IL_03a9: Expected Obj, but got I
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03e7: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+10]");
		object obj = 0;
		if (_currentEventManager != null)
		{
			if ((nint)_currentEventManager != 1)
			{
				if ((nint)_currentEventManager == 2)
				{
					_currentEventManager = (IEventManager)(-1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+10]");
					bool flag = (nint)0 != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+20]");
					string text = WWW.EscapeURL((string)0);
					nint num = default;
					object obj10;
					if (flag)
					{
						object obj2 = num + 12;
						object obj3 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v71+60]");
						object obj4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v72+4]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						object obj6 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v57+60]");
						object obj7 = 0;
						object obj8 = obj5 & 0x3FFF;
						object obj9 = obj8 + 6161;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v196 @ S2_v23 (should have been resolved before IL gen)");
						obj10 = obj2;
					}
					else
					{
						object obj11 = num + 12;
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v44+60]");
						object obj13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
						object obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v49+60]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
						obj10 = obj11;
					}
					object obj16 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S3_v11+60]");
					object obj17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S3_v12+C]");
					object obj18 = 0;
					object obj19 = obj18 & 0x1FFF;
					object obj20 = obj19 + 30963;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v221 @ S4_v10 (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+8]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
					int num3 = ((Dictionary<string, int>)num2).get_Item((string)0);
					object obj21 = num3 - 1;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S4_v12 (Il2CppMethodInfo)+C]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S4_v13+60]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S4_v14+48]");
					object obj24 = 0;
					object obj25 = obj24 & 0x7FF;
					object obj26 = obj25 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S5_v10 (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+1C]");
					if ((nint)0 != 0)
					{
						object obj27 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S2_v13+60]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S2_v14+10]");
						object obj29 = 0;
						object obj30 = obj29 & 0x3FFF;
						object obj31 = obj30 + 6161;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v266 @ S3_v19 (should have been resolved before IL gen)");
						object obj32 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S2_v17+60]");
						object obj33 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S2_v18+14]");
						object obj34 = 0;
						object obj35 = obj34 & 0x3FFF;
						object obj36 = obj35 + 97173;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v278 @ S3_v23 (should have been resolved before IL gen)");
					}
					return (T)null;
				}
				return (T)null;
			}
			_currentEventManager = (IEventManager)(-1);
		}
		else
		{
			_currentEventManager = (IEventManager)(-1);
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v25 (Il2CppClass<Globals>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v40 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_ENABLE_LOADING_DELAY ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0.5f;
				object obj38 = this + 12;
				object obj39 = default;
				obj38 = obj39;
				_currentEventManager = (IEventManager)1;
				return (T)1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+10]");
		if ((nint)0 != 0)
		{
			object obj40 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+14]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+18]");
			bool flag2 = UnityEngine.UI.SetPropertyUtility.SetClass<T>(ref *(T*)num7, (T)0);
			obj40 = flag2;
		}
		else
		{
			object obj41 = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v4+60]");
			object obj43 = 0;
			object obj44 = obj43;
			object obj45 = obj44 & 0x1FFF;
			object obj46 = obj45 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v101 @ S4_v6 (should have been resolved before IL gen)");
			object obj47 = default;
			obj41 = obj47;
		}
		object obj48 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+20]");
		obj48 = 0;
		_currentEventManager = (IEventManager)2;
		return (T)1;
	}

	public unsafe void RestoreBoardAfterEventIfNeeded()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_0297: Expected I, but got Obj
		//IL_02ad: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0121: Expected I, but got Obj
		//IL_016e: Expected I, but got Obj
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v60 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(SSEventsManagerController.StartEventTimer);
		object obj2 = action + 16;
		obj2 = this;
		((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(SSEventsManagerController.StartEventTimer);
		object obj3 = action2 + 16;
		obj3 = this;
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v23 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v56 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnApplicationResumed -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(SSEventsManagerController.StartEventTimer);
		object obj5 = action3 + 16;
		obj5 = this;
		nint num5 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v35 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v52 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AgeRestriction.restrictionChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Action<RefreshType> action4 = default;
		object obj7 = action4 + 16;
		obj7 = this;
		AppRefreshHandler.hasRefreshed -= action4;
		SetCurrentEventManager();
		_isInitialized = true;
	}

	public long TimeLeftInSeconds()
	{
		//IL_000d: Expected I8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+10]");
		return 0L;
	}

	public unsafe void CurrentEventHasBeenTriedNow()
	{
		//IL_0417: Expected Obj, but got I4
		//IL_0425: Expected I, but got Obj
		//IL_043b: Expected Obj, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected I, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I8
		//IL_0161: Expected I, but got Obj
		//IL_0177: Expected Obj, but got I
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_01a2: Expected I, but got Obj
		//IL_00fd: Expected I, but got Obj
		//IL_0669: Expected I, but got Obj
		//IL_067f: Expected Obj, but got I
		//IL_0219: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_03cf: Expected I, but got Obj
		//IL_0514: Expected I, but got Obj
		//IL_052f: Expected I, but got Obj
		//IL_0545: Expected Obj, but got I
		//IL_0579: Expected I, but got Obj
		//IL_058f: Expected Obj, but got I
		//IL_025a: Expected I, but got Obj
		//IL_05b9: Expected Obj, but got I4
		//IL_02a7: Expected I, but got Obj
		//IL_02f4: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v125 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)(obj + 12);
		object obj3 = obj + 8;
		if (InventorySave.keys == 0)
		{
			return;
		}
		long currentEventID = GetCurrentEventID();
		obj = currentEventID;
		bool flag = (((nint)obj >= 0) ? ((nint)obj > 0) : true);
		if ((flag ? 1 : 0) >= (true ? 1 : 0))
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v111 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v118 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long lastTimeAnEventHasBeenTried = EventsSave.lastTimeAnEventHasBeenTried;
			long num6 = ((SSEventsManagerController)null).EndTimestampForCurrentEventType();
			if (lastTimeAnEventHasBeenTried == num6)
			{
				return;
			}
		}
		Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
		Dictionary<AwardId, bool> awardIsNew = PlayerSave.awardIsNew;
		nint num7 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v34 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v106 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2;
		if (EventsSave.shouldRestoreItemAfterEvent)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v39 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			nint num9 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v56 (Il2CppClass<System.Type>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v98 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = typeof(Boards.BoardId);
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type enumType = Type.internal_from_handle((IntPtr)num3);
			nint num11 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v65 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v94 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool shouldRestoreItemAfterEvent = EventsSave.shouldRestoreItemAfterEvent;
			nint num13 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v72 (Il2CppClass<System.Enum>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v90 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string name = Enum.GetName(enumType, shouldRestoreItemAfterEvent);
			throw new NullReferenceException();
		}
		nint num15 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v44 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num16 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v49 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((EventsSave)null)._002Ector();
	}

	public unsafe bool HasTheCurrentEventBeenTried()
	{
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Boards.BoardId eventValue = ((SpecialPowerBoardEventManager)this).GetEventValue<Boards.BoardId>(out reference);
		if (reference)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SSEventsManagerController)+10]");
			if ((nint)0 > (nint)0)
			{
				nint num = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v28 (Il2CppClass<Data.Managers.BoardManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = BoardManager.HasAllThemesBeenSeen(eventValue);
				return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			return false;
		}
		return false;
	}

	public bool DoesCharacterMatchCurrentEvent(Characters.CharacterId characterId)
	{
		//IL_0067: Expected I4, but got Obj
		//IL_00ce: Expected I4, but got Obj
		bool result;
		if (_currentEventManager != null)
		{
			if (characterId == Characters.CharacterId.slick)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj = default;
				bool flag = obj == null;
				result = false;
				if (!flag)
				{
					result = (byte)(int)_currentEventManager != 0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj2 = default;
				if ((nint)obj2 == (nint)characterId)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj3 = default;
					result = ((obj3 != null) ? ((byte)(int)_currentEventManager != 0) : false);
				}
				else
				{
					result = false;
				}
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	private void StartEventTimer()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		if (_currentEventManager == null)
		{
			return;
		}
		long num = ((SSEventsManagerController)null).StartTimestampForCurrentEventType();
		nint num2 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v5 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v10 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9224");
	}

	private IEnumerator TimerToEventStart(long timeLeft)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator TimerToEventFinish(long timeLeft)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 24;
		obj = this;
		return enumerator;
	}

	private long GetCurrentEventID()
	{
		//IL_014e: Expected I8, but got I4
		//IL_0140: Expected I8, but got I4
		//IL_0132: Expected I8, but got I4
		//IL_0095: Expected F8, but got I8
		//IL_00d6: Expected F8, but got I8
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected I8, but got Unknown
		//IL_0117: Expected F8, but got I8
		double num = ((SYBO.Components.Analytics.SyboRandom)null).NextDouble();
		if (_currentEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			if (obj != null)
			{
				long num2 = ((SSEventsManagerController)null).StartTimestampForCurrentEventType();
				if (num2 <= 0)
				{
					return 0L;
				}
				double num3;
				if (num != num)
				{
					num3 = -9.223372036854776E+18;
				}
				else if (num < 9.223372036854776E+18)
				{
					num3 = ((num > -9.223372036854776E+18) ? num : (-9.223372036854776E+18));
				}
				else
				{
					num3 = -9.223372036854776E+18;
				}
				return (long)(num2 - num3);
			}
			return 0L;
		}
		return 0L;
	}

	private unsafe long EndTimestampForCurrentEventType()
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected I4, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_00ee: Expected I4, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_01b9: Expected I8, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01d0: Expected I8, but got I4
		IFormatProvider formatProvider = default;
		bool flag = (byte)(formatProvider + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v53 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long result = default;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v42 (Il2CppClass<EventTesterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v49 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			long totalIn = ((DeflateStream)isInitialized).TotalIn;
			result = totalIn;
		}
		else
		{
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_id", flag))
			{
				formatProvider = (IFormatProvider)0;
				bool flag2 = (((bool*)(flag ? 1 : 0))->m_value ? ((long*)1) : ((long*)null))->System_002EIConvertible_002EToBoolean(formatProvider);
				bool flag3 = !flag2;
				bool flag4 = !flag3;
				result = (long)formatProvider;
				if (!flag4)
				{
					result = 0L;
				}
			}
		}
		return result;
	}

	private unsafe long StartTimestampForCurrentEventType()
	{
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected I4, but got Unknown
		//IL_01fa: Expected Obj, but got I4
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_00ee: Expected I4, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_013d: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I4
		//IL_0185: Expected Obj, but got I4
		//IL_01b9: Expected I8, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_01d0: Expected I8, but got I4
		IFormatProvider formatProvider = default;
		bool flag = (byte)(formatProvider + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v53 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long result = default;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v42 (Il2CppClass<EventTesterManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v49 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			long eventStartTime = ((EventTesterManager)isInitialized).GetEventStartTime();
			result = eventStartTime;
		}
		else
		{
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)string.Empty != 0;
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v37 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"event_end", flag))
			{
				formatProvider = (IFormatProvider)0;
				bool flag2 = (((bool*)(flag ? 1 : 0))->m_value ? ((long*)1) : ((long*)null))->System_002EIConvertible_002EToBoolean(formatProvider);
				bool flag3 = !flag2;
				bool flag4 = !flag3;
				result = (long)formatProvider;
				if (!flag4)
				{
					result = 0L;
				}
			}
		}
		return result;
	}

	private double GetUnixCurrentTimestamp()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0.0;
	}

	private bool IsAnyEventEnabled()
	{
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long lastTimeAnEventWasStarted = EventsSave.lastTimeAnEventWasStarted;
		if (_currentEventManager != null)
		{
			long num3 = ((SSEventsManagerController)null).StartTimestampForCurrentEventType();
			return lastTimeAnEventWasStarted == num3;
		}
		return false;
	}

	private SSEventType GetEnabledEventType()
	{
		//IL_0053: Invalid comparison between F8 and I8
		//IL_0086: Invalid comparison between F8 and I8
		//IL_00ad: Invalid comparison between F8 and I8
		long num = ((SSEventsManagerController)null).StartTimestampForCurrentEventType();
		SSEventType result;
		if (num > 0)
		{
			long eventID = ((SuperMysteryBoxEventManager)null).GetEventID();
			double num2 = ((SYBO.Components.Analytics.SyboRandom)null).NextDouble();
			bool flag = num2 < (double)num;
			bool flag2 = eventID < 1;
			result = (flag ? SSEventType.SpecialPowerBoard : SSEventType.None);
			if (!flag2)
			{
				if (num2 > (double)eventID)
				{
					bool flag3 = num2 < (double)num;
					result = (flag3 ? SSEventType.SpecialPowerBoard : SSEventType.None);
				}
				else
				{
					result = SSEventType.None;
				}
			}
		}
		else
		{
			result = SSEventType.None;
		}
		return result;
	}

	private void SetCurrentEventManager()
	{
		//IL_0714: Expected Obj, but got I4
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected Obj, but got Unknown
		//IL_0734: Expected Obj, but got I8
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected Obj, but got Unknown
		//IL_003c: Expected F8, but got I8
		//IL_0763: Expected Obj, but got F8
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0771: Expected Obj, but got Unknown
		//IL_077a: Expected Obj, but got I4
		//IL_0788: Expected I, but got Obj
		//IL_079e: Expected Obj, but got I
		//IL_007d: Expected F8, but got I8
		//IL_0a1d: Expected I, but got Obj
		//IL_0a33: Expected Obj, but got I
		//IL_00be: Expected F8, but got I8
		//IL_00d1: Expected I, but got Obj
		//IL_0250: Expected I4, but got Obj
		//IL_011e: Expected I, but got Obj
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_0812: Expected Obj, but got I
		//IL_07c9: Expected I, but got Obj
		//IL_07df: Expected Obj, but got I
		//IL_03f6: Expected I, but got Obj
		//IL_040c: Expected Obj, but got I
		//IL_02b2: Expected I, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_089d: Expected I, but got Obj
		//IL_08b3: Expected Obj, but got I
		//IL_08dc: Expected VT, but got I4
		//IL_08dc: Expected Obj, but got I4
		//IL_031b: Expected I, but got Obj
		//IL_0331: Expected Obj, but got I
		//IL_01f9: Expected I, but got Obj
		//IL_0484: Expected I, but got Obj
		//IL_049a: Expected Obj, but got I
		//IL_0437: Expected I, but got Obj
		//IL_084e: Expected I, but got Obj
		//IL_0864: Expected Obj, but got I
		//IL_0308: Expected I, but got Obj
		//IL_08f2: Expected Obj, but got I8
		//IL_035c: Expected I, but got Obj
		//IL_04c5: Expected I, but got Obj
		//IL_03a9: Expected I, but got Obj
		//IL_0a7c: Expected I, but got Obj
		//IL_0a92: Expected Obj, but got I
		//IL_0979: Expected I8, but got Obj
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected Obj, but got Unknown
		//IL_0595: Expected I, but got Obj
		//IL_068b: Expected I, but got Obj
		//IL_06a1: Expected Obj, but got I
		//IL_09f4: Expected I8, but got Obj
		//IL_09f4: Expected I4, but got Obj
		//IL_06cc: Expected I, but got Obj
		object obj = 0;
		object obj2 = obj + 24;
		long num = ((SSEventsManagerController)null).StartTimestampForCurrentEventType();
		obj2 = num;
		long eventID = ((SuperMysteryBoxEventManager)null).GetEventID();
		object obj3 = obj + 16;
		double num2 = ((SYBO.Components.Analytics.SyboRandom)null).NextDouble();
		if (num2 != num2)
		{
			num2 = -9.223372036854776E+18;
		}
		else if (!(num2 < 9.223372036854776E+18))
		{
			num2 = -9.223372036854776E+18;
		}
		else if (!(num2 > -9.223372036854776E+18))
		{
			num2 = -9.223372036854776E+18;
		}
		obj3 = num2;
		object obj4 = obj + 8;
		obj4 = 0;
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v18 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v178 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v92 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_eventTimerGameObject).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v165 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v172 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v83 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(_eventTimerGameObject);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"EventTimers";
		nint num11 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v31 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		bool flag = obj9 == null;
		nint num12 = (nint)typeof(SSEventsManagerController);
		if (!flag)
		{
			nint num13 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v158 (Il2CppClass<SSEventsManagerController>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num12 = (nint)typeof(SSEventsManagerController);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num12 = (nint)typeof(SSEventsManagerController);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ L1_v5 (Il2CppClass<SSEventsManagerController>)+5C]");
		object obj10 = (nint)0 + (nint)4;
		obj10 = gameObject;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			nint num14 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v145 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num15 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v152 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)_eventTimerGameObject).Exec();
		}
		nint num18 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v42 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num19 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v138 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NewMonoBehaviour newMonoBehaviour = _eventTimerGameObject.AddComponent<NewMonoBehaviour>();
		nint num20 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v51 (Il2CppClass<SSEventsManagerController>)+5C]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = newMonoBehaviour;
		int layer = _eventTimerGameObject.layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.DynamicManagers, (Vector3)0);
		nint num21 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v60 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num22 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v134 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long lastTimeEventPopupWasForceShown = EventsSave.lastTimeEventPopupWasForceShown;
		obj = lastTimeEventPopupWasForceShown;
		bool flag4 = (((long)obj >= eventID) ? ((long)obj > eventID) : true);
		if ((flag4 ? 1 : 0) <= -1)
		{
			bool flag5 = (((long)obj3 >= eventID) ? ((long)obj3 > eventID) : true);
			if ((flag5 ? 1 : 0) <= -1)
			{
				object obj16 = eventID - obj3;
				obj4 = obj16;
			}
			nint num23 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v113 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num24 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v121 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator routine = TimerToEventFinish((long)obj4);
			Coroutine coroutine = _eventTimerMono.StartCoroutine_Auto(routine);
		}
		bool flag6 = (((nint)obj2 >= 0) ? ((nint)obj2 > 0) : true);
		if ((flag6 ? 1 : 0) >= (true ? 1 : 0))
		{
			object obj18 = obj2 - obj3;
			obj4 = obj18;
			bool flag7 = (((nint)obj4 >= 0) ? ((nint)obj4 > 0) : true);
			if ((flag7 ? 1 : 0) >= (true ? 1 : 0))
			{
				nint num25 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v86 (Il2CppClass<SSEventsManagerController>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num26 = (nint)typeof(SSEventsManagerController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v94 (Il2CppClass<SSEventsManagerController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SuperMysteryBoxEventManager routine2 = SuperMysteryBoxEventManager.Create((SSEventType)this, (long)obj4);
				Coroutine coroutine2 = _eventTimerMono.StartCoroutine_Auto((IEnumerator)routine2);
			}
		}
		this._002Ector();
	}

	private SSEventsManagerController()
	{
		//IL_05bd: Expected I, but got Obj
		//IL_05d3: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_013f: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I4
		//IL_00f2: Expected I, but got Obj
		//IL_0400: Expected I, but got Obj
		//IL_0416: Expected Obj, but got I
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I4
		//IL_0441: Expected I, but got Obj
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_048e: Expected I, but got Obj
		//IL_04a4: Expected Obj, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e8: Expected Obj, but got I4
		//IL_04cf: Expected I, but got Obj
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_02d9: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_031a: Expected I, but got Obj
		if (_currentEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		SSEventType eventType = ((SuperMysteryBoxEventManager)null).GetEventType();
		long num = ((SSEventsManagerController)null).EndTimestampForCurrentEventType();
		if (_currentEventManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
			object obj = default;
			if ((long)obj == num)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj2 = default;
				if ((nint)eventType == (nint)obj2)
				{
					goto IL_03f2;
				}
			}
		}
		if (eventType != SSEventType.CharacterName)
		{
			nint num2 = (nint)typeof(AwardsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v57 (Il2CppClass<Missions.AwardsData>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(AwardsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v60 (Il2CppClass<Missions.AwardsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		nint num4 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v20 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num5 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v52 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.shouldDisplayPopup)
		{
			return;
		}
		object obj5 = eventType - 1;
		if (eventType != SSEventType.SpecialPowerBoard)
		{
			if ((nint)obj5 != 1)
			{
				if ((nint)obj5 == 2)
				{
					goto IL_03d4;
				}
				if ((nint)obj5 != 3)
				{
					if ((nint)obj5 != 4)
					{
						if ((nint)obj5 == 5)
						{
							goto IL_03d4;
						}
						if ((nint)obj5 != 6)
						{
							if ((nint)obj5 != 7)
							{
								goto IL_03d4;
							}
							nint num6 = (nint)typeof(CharacterNameEventManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v42 (Il2CppClass<CharacterNameEventManager>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num7 = (nint)typeof(CharacterNameEventManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v48 (Il2CppClass<CharacterNameEventManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj7 = this + 8;
							ExpiredLimitedBoardEventManager expiredLimitedBoardEventManager = ExpiredLimitedBoardEventManager.Create(eventType, num);
							obj7 = expiredLimitedBoardEventManager;
						}
						else
						{
							object obj8 = this + 8;
							CharacterNameEventManager characterNameEventManager = CharacterNameEventManager.Create(eventType, num);
							obj8 = characterNameEventManager;
						}
					}
					else
					{
						object obj9 = this + 8;
						SpecialPowerBoardEventManager specialPowerBoardEventManager = SpecialPowerBoardEventManager.Create(eventType, num);
						obj9 = specialPowerBoardEventManager;
					}
				}
				else
				{
					object obj10 = this + 8;
					CharacterDayEventManager characterDayEventManager = CharacterDayEventManager.Create(eventType, num);
					obj10 = characterDayEventManager;
				}
			}
			else
			{
				object obj11 = this + 8;
				IEnumerator enumerator = ((BoardBundlePopupManager)eventType).StartTimer(num);
				obj11 = enumerator;
			}
		}
		else
		{
			object obj12 = this + 8;
			IEnumerator enumerator2 = ((SSEventsManagerController)eventType).TimerToEventStart(num);
			obj12 = enumerator2;
		}
		goto IL_03f2;
		IL_03f2:
		nint num8 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v66 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num9 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v87 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (SSEventsManagerController.m_OnSSEventChangedHandler == null)
		{
			return;
		}
		nint num10 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v74 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num11 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v81 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		return;
		IL_03d4:
		object obj15 = this + 8;
		obj15 = 0;
		goto IL_03f2;
	}

	static SSEventsManagerController()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 32;
		nint num = (nint)typeof(CharacterNameEventManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<CharacterNameEventManager>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = obj2;
	}
}
