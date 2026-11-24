using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ABTest;
using AppRefresh;
using Authentication;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Backend;
using Kiloo.Common.HTTP;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Missions;
using Onboarding;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.Cameras;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using SYBO.Subway.UI;
using TopRun;
using UI.Breadcrumbs;
using UI.Screens;
using UI.SlideIns;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using WordHunt;

public class HouseKeeper : MonoBehaviour
{
	public delegate void OnLateUpdate();

	private sealed class _003CStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HouseKeeper _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004d: Expected Obj, but got I4
				//IL_0064: Expected I, but got Obj
				//IL_007a: Expected Obj, but got I
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				//IL_012d: Expected Obj, but got Unknown
				//IL_0165: Expected Obj, but got I4
				//IL_00a5: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				int numberOfDaysSinceLastPlay = ((HouseKeeper)null).GetNumberOfDaysSinceLastPlay();
				Coroutine coroutine = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)numberOfDaysSinceLastPlay);
				nint num = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v14 (Il2CppClass<HouseKeeper>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj2 = this + 12;
				Achievements instance = Achievements.Instance;
				Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto((IEnumerator)instance);
				obj2 = coroutine2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CStart_003Ed__17(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_037a: Expected Obj, but got I
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01c4: Expected Obj, but got I
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected Obj, but got Unknown
			//IL_0190: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_0257: Expected Obj, but got I
			//IL_02b1: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper+<Start>d__17)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper+<Start>d__17)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper+<Start>d__17)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj20 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v104 @ S2_v14 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FFF;
						object obj16 = obj15 + 46824;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v111 @ S1_v33 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj17 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v59+9C]");
						object obj18 = (nint)0 & (nint)0x100;
						flag2 = obj18 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && _003C_003E2__current != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19+2B]");
						object obj19 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj19 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B8");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B9");
							}
						}
						else if (obj20 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v14+8]");
				object obj21 = (nint)0 & (nint)0x3FFF;
				object obj22 = obj21 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S2_v6 (should have been resolved before IL gen)");
			}
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

	private sealed class _003CInitAuthAndCloudSave_003Ed__18(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0080: Expected I, but got Obj
				//IL_0096: Expected Obj, but got I
				//IL_0377: Unknown result type (might be due to invalid IL or missing references)
				//IL_037c: Expected Obj, but got Unknown
				//IL_038d: Expected Obj, but got I4
				//IL_03a1: Expected Obj, but got I4
				//IL_00c1: Expected I, but got Obj
				//IL_01cd: Expected I, but got Obj
				//IL_01e3: Expected Obj, but got I
				//IL_03f5: Expected I, but got Obj
				//IL_040b: Expected Obj, but got I
				//IL_013f: Expected I, but got Obj
				//IL_0155: Expected Obj, but got I
				//IL_02b3: Expected I, but got Obj
				//IL_02c9: Expected Obj, but got I
				//IL_0438: Unknown result type (might be due to invalid IL or missing references)
				//IL_043d: Expected Obj, but got Unknown
				//IL_0463: Expected Obj, but got I4
				//IL_020e: Expected I, but got Obj
				//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c0: Expected Obj, but got Unknown
				//IL_03c9: Expected Obj, but got I4
				//IL_03dd: Expected Obj, but got I4
				//IL_025b: Expected I, but got Obj
				//IL_0180: Expected I, but got Obj
				//IL_02f4: Expected I, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								return null;
							}
							return null;
						}
						_003C_003E1__state = -1;
						nint num = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v71 (Il2CppClass<HouseKeeper>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(HouseKeeper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v78 (Il2CppClass<HouseKeeper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						waitForCloudSave = false;
						return null;
					}
					_003C_003E1__state = -1;
					string savedKilooTag = SaveManager.GetSavedKilooTag();
					if (savedKilooTag != null)
					{
						nint num3 = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v53 (Il2CppClass<HouseKeeper>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(HouseKeeper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v63 (Il2CppClass<HouseKeeper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						waitForCloudSave = false;
						object obj3 = this + 12;
						obj3 = 0;
						_003C_003E1__state = 3;
						return 1;
					}
					nint num5 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<Cloud.CloudSave>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num6 = (nint)typeof(CloudSave);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v48 (Il2CppClass<Cloud.CloudSave>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CloudSave.Commit();
					nint num7 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v32 (Il2CppClass<HouseKeeper>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v42 (Il2CppClass<HouseKeeper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					waitForCloudSave = true;
					object obj6 = this + 12;
					IEnumerator enumerator = CloudSave.Update_Routine((Action)null);
					obj6 = enumerator;
					_003C_003E1__state = 2;
					return 1;
				}
				_003C_003E1__state = -1;
				nint num9 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num10 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v18 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj8 = this + 12;
				bool refreshInProgress = AppRefreshHandler.refreshInProgress;
				obj8 = refreshInProgress;
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

	private sealed class _003COnSecondFrameEnded_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0182: Expected Obj, but got Unknown
				//IL_018b: Expected Obj, but got I4
				//IL_01e6: Expected Obj, but got I4
				//IL_0150: Unknown result type (might be due to invalid IL or missing references)
				//IL_0155: Expected Obj, but got Unknown
				//IL_006b: Expected I, but got Obj
				//IL_0081: Expected Obj, but got I
				//IL_00ac: Expected I, but got Obj
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						nint num = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v22 (Il2CppClass<HouseKeeper>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(HouseKeeper);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v32 (Il2CppClass<HouseKeeper>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (HouseKeeper.m_secondFrameEnded != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				bool isSupported = TouchScreenKeyboard.isSupported;
				if ((isSupported ? 1 : 0) > (true ? 1 : 0))
				{
					object obj2 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj3 = default;
					obj2 = obj3;
					_003C_003E1__state = 2;
				}
				else
				{
					object obj4 = this + 12;
					obj4 = 0;
					_003C_003E1__state = 1;
				}
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

	private static OnLateUpdate m_onLateUpdate;

	private const string APPLICATION_AUTHENTICITY_KEY = "applicationAuthenticity";

	private const string SFX_BEFORE_APPLICATION_LOSTFOCUS = "sfxBeforeLostFocus";

	private const string MUSIC_BEFORE_APPLICATION_LOSTFOCUS = "musicBeforeLostFocus";

	private const string RTL_ALIGNED_LANGUAGES_REGEX = "\\p{IsArabic}|\\p{IsHebrew}|\\p{IsSyriac}|\\p{IsThaana}";

	private static Action m_secondFrameEnded;

	public static bool waitForCloudSave;

	private bool _hasAddedAgeRestrictionEventListener;

	private static bool _onlineServicesInitialized;

	private int[] _dailyKeysBrackets;

	private int[] _consumableHoverboardBrackets;

	private int[] _headstartBrackets;

	private int[] _scoreBoosterBrackets;

	private const string ANDROID_IN_APP_BILLING_GAMEOBJECT_NAME = "InAppBillingAndroidGameObject";

	private static Action<bool> delegateFacebookPayoutPopupAction;

	private const float MIN_REFRESH_INTERVAL = 3600f;

	private const string REFRESH_INTERVAL_KEY = "refreshinterval";

	private static float _onlineSettingsLastDownloadTime;

	public static event OnLateUpdate onLateUpdate
	{
		add
		{
			//IL_000e: Expected I, but got F4
			//IL_001c: Expected I, but got F4
			//IL_002a: Expected I, but got F4
			//IL_0038: Expected Obj, but got F4
			//IL_0046: Expected Obj, but got F4
			//IL_0054: Expected Obj, but got F4
			//IL_0062: Expected I4, but got F4
			((Delegate)value).delegate_trampoline = (IntPtr)10f;
			((Delegate)value).extra_arg = (IntPtr)50f;
			((Delegate)value).method_code = (IntPtr)0.7f;
			((Delegate)value).method_info = (MethodInfo)1.5f;
			((Delegate)value).original_method_info = (MethodInfo)0.3f;
			((Delegate)value).data = (System.DelegateData)0.1f;
			((Delegate)value).method_is_virtual = true;
			_ = -1;
			_ = 0.9f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = HouseKeeper.m_onLateUpdate;
			OnLateUpdate onLateUpdate = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<HouseKeeper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)HouseKeeper.m_onLateUpdate == obj2)
				{
					HouseKeeper.m_onLateUpdate = onLateUpdate;
				}
				if ((object)HouseKeeper.m_onLateUpdate != obj2)
				{
					obj2 = HouseKeeper.m_onLateUpdate;
					continue;
				}
				break;
			}
		}
	}

	public static event Action secondFrameEnded
	{
		add
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (HouseKeeper.m_onLateUpdate != null)
			{
				nint num3 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v31 (Il2CppClass<HouseKeeper>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v38 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			nint num5 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v15 (Il2CppClass<Globals>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v24 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_TEST_FPS_SPIKES ? 1u : 0u) == 0)
			{
				((HouseKeeper)null).AddFpsCounter();
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
			nint num = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = HouseKeeper.m_secondFrameEnded;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<HouseKeeper>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(HouseKeeper);
				if (!flag)
				{
					nint num5 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<HouseKeeper>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(HouseKeeper);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(HouseKeeper);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<HouseKeeper>)+5C]");
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

	private void Awake()
	{
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = HouseKeeper.m_onLateUpdate;
		OnLateUpdate onLateUpdate = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<HouseKeeper>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((object)HouseKeeper.m_onLateUpdate == obj2)
			{
				HouseKeeper.m_onLateUpdate = onLateUpdate;
			}
			if ((object)HouseKeeper.m_onLateUpdate != obj2)
			{
				obj2 = HouseKeeper.m_onLateUpdate;
				continue;
			}
			break;
		}
	}

	private unsafe void OnProductPlacementDownloaded()
	{
		//IL_0351: Expected VT, but got Obj
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03b3: Expected Obj, but got I
		//IL_0034: Expected I, but got Obj
		//IL_004a: Expected Obj, but got I
		//IL_03d7: Expected Obj, but got I4
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_0075: Expected I, but got Obj
		//IL_03f5: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_043b: Expected I, but got Obj
		//IL_0451: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected I4, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0150: Expected I, but got Obj
		//IL_02c7: Expected I, but got Obj
		//IL_02dd: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0308: Expected I, but got Obj
		//IL_04c5: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got VT
		//IL_027f: Expected I4, but got Obj
		//IL_022b: Expected I, but got Obj
		//IL_029e: Expected Obj, but got VT
		//IL_02ab: Expected I4, but got Obj
		//IL_02b4: Expected Obj, but got I4
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(HouseKeeper.OnProductPlacementDownloaded);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = val + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (T)+1C]");
		Delegate obj4 = ((Delegate)0).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
		string text = tag;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)text).Exec();
		bool isInitialized = AdSystemManager.isInitialized;
		((PokiUnitySDK)isInitialized).gameLoadingStart();
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v25 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v88 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.OnAuthenticated();
		((HouseKeeper)null).LateUpdate();
		nint num5 = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v32 (Il2CppClass<Layers>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v84 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Layers._002Ecctor();
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v80 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = default;
		int num9 = obj10 + 16;
		object obj11 = obj10 + 8;
		Breadcrumb.BreadcrumbSave breadcrumbs = UserSave.breadcrumbs;
		if (breadcrumbs == null)
		{
			nint num10 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v64 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num11 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v76 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UserSave.breadcrumbs = (Breadcrumb.BreadcrumbSave)1;
			OnboardingSave.shouldShowFacebookPopup = false;
			DateTime today = CDateTime.Today;
			obj11 = today;
			((int*)num9)->m_value = (int)obj11;
			UserSave.numberOfBreadCrumbsShownOnFrontPage = num9;
			DateTime today2 = CDateTime.Today;
			obj10 = today2;
			((int*)num9)->m_value = (int)obj10;
			UserSave.firstInstalledVersion = (string)num9;
		}
		nint num12 = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v51 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num13 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v59 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		((AwardsManager)(object)instance).InitAwardsIfNeeded();
		((HouseKeeper)null).HookUpListenersToOnlineSettings();
	}

	private void OnAppHasRefreshed(RefreshType refreshType)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		object obj = refreshType & RefreshType.UI;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+88]");
		object obj2 = (nint)0 + (nint)12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+88]");
			object obj4 = (nint)0 + (nint)16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			string text = ((Component)obj6).tag;
			((GameObject)(object)text).tag = (string)refreshType;
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
	}

	private void InitLocale()
	{
	}

	private void LateUpdate()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_00ea: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		RefreshOnlineSettingsAndInappsIfNeeded();
		X509Certificate2Collection x509Certificate2Collection = TrustedRoots.LoadTrusted();
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Strings.OnRefresh((RefreshType)x509Certificate2Collection);
		Strings.StringsLanguage language = Strings.language;
		((KindlePurchaseProviderCallbackListener)(object)language)._002Ector();
	}

	private IEnumerator Start()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	public unsafe static IEnumerator InitAuthAndCloudSave()
	{
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected I, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01d6: Expected I, but got Obj
		//IL_01f1: Expected I, but got Obj
		//IL_0207: Expected Obj, but got I
		//IL_0249: Expected I, but got Obj
		//IL_025f: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(FollowingGuard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<FollowingGuard>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<FollowingGuard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 4);
		bool flag = (object)FollowingGuard.instance == null;
		bool flag2 = !flag;
		IEnumerator result = (IEnumerator)FollowingGuard.instance;
		if (!flag2)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v25 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v49 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = typeof(FollowingGuard);
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Type type = Type.internal_from_handle((IntPtr)num3);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = ((UnityEngine.Object)(object)type).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num8 = (nint)typeof(FollowingGuard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v36 (Il2CppClass<FollowingGuard>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(FollowingGuard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<FollowingGuard>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IEnumerator enumerator = default;
			FollowingGuard.instance = (FollowingGuard)enumerator;
			result = enumerator;
		}
		return result;
	}

	private IEnumerator OnSecondFrameEnded()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void DebugSimulateFpsSpikes()
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
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = HouseKeeper.m_secondFrameEnded;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<HouseKeeper>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(HouseKeeper);
			if (!flag)
			{
				nint num5 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<HouseKeeper>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(HouseKeeper);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(HouseKeeper);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<HouseKeeper>)+5C]");
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

	private void AddFpsCounter()
	{
		//IL_0121: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_008e: Expected F4, but got I4
		//IL_018c: Invalid comparison between F4 and I4
		//IL_00c7: Expected F4, but got I4
		//IL_0100: Expected F4, but got I4
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_TEST_FPS_SPIKES ? 1u : 0u) != 0)
		{
			return;
		}
		float num3 = NetworkServer.maxDelay;
		if (num3 != num3)
		{
			num3 = -2.1474836E+09f;
		}
		else if (!(num3 < 2.1474836E+09f))
		{
			num3 = -2.1474836E+09f;
		}
		else if (!(num3 > -2.1474836E+09f))
		{
			num3 = -2.1474836E+09f;
		}
		float num4 = num3 / 5f;
		float num5 = num4 * 5f;
		float num6 = num3 - num5;
		if (num6 == 0f)
		{
			float maxDelay = NetworkServer.maxDelay;
			float num7;
			float maxDelay2;
			do
			{
				num7 = maxDelay + 0.5f;
				maxDelay2 = NetworkServer.maxDelay;
			}
			while (num7 > maxDelay2);
		}
	}

	private void LogApplicationAuthenticity()
	{
		//IL_00ac: Expected I4, but got Obj
		//IL_00ba: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"FpsCounter";
		UnityEngine.Object.DestroyImmediate(gameObject, (byte)(int)"FpsCounter" != 0);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
		InRunAverageFPSCounter inRunAverageFPSCounter = gameObject.AddComponent<InRunAverageFPSCounter>();
		inRunAverageFPSCounter.SubscribeToGameInstanceEvents();
	}

	private unsafe void HookUpListenersToOnlineSettings()
	{
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		if (((LODParameters*)"applicationAuthenticity")->GetHashCode() != 0)
		{
			return;
		}
		if (Application.isEditor)
		{
			bool genuineCheckAvailable = Application.genuineCheckAvailable;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((TooltipAttribute)(object)"applicationAuthenticity")._002Ector("set");
	}

	private unsafe void OnOnlineSettingsSetupFinished()
	{
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Info.OnlineSettings>)+74]");
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
		((Delegate)action).method = (nint)__ldftn(HouseKeeper.OnOnlineSettingsSetupFinished);
		object obj2 = action + 16;
		obj2 = this;
		((OnlineSettings)(object)saveDataPath).RemoveOnFinishedDownloadingOnlineSettingsHandler(action);
		string saveDataPath2 = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Delegate obj3 = default;
		obj3.method_ptr = method_ptr2;
		obj3.method = (nint)__ldftn(HouseKeeper.OnOnlineSettingsDownloadedWithResult);
		object obj4 = obj3 + 16;
		obj4 = this;
		object obj5 = saveDataPath2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v13 (System.String)+18]");
		Delegate obj6 = ((Delegate)0).CombineImpl(obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj7 = default;
		obj5 = obj7;
	}

	private void OnOnlineSettingsDownloadedWithResult(bool result)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = result;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Enum obj3 = default;
		IFormatProvider provider = default;
		if (!obj3.System_002EIConvertible_002EToBoolean(provider))
		{
			return;
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Flurry>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v22 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Flurry._002Ecctor();
	}

	private void InitializeAdsSystem()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.shouldDisplayPopup)
		{
			/*Error: End of method reached without returning.*/;
		}
	}

	public static void InitOnlineServicesIfNeeded()
	{
	}

	private void RefreshTopRun()
	{
		OfferWallManager instance = OfferWallManager.instance;
		((AdSystemManager)(object)instance).SkipVideoAd();
	}

	private void RegisterAllBundlesDownloaded()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			return;
		}
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<HouseKeeper>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v15 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
	}

	private unsafe void RegisterLocalNotificationStatus()
	{
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected I4, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0326: Expected Obj, but got I4
		//IL_0039: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_036c: Expected Obj, but got VT
		//IL_0379: Expected I4, but got Obj
		//IL_03c6: Expected I, but got Obj
		//IL_03dc: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		//IL_04e6: Expected Obj, but got VT
		//IL_04f3: Expected I4, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_02b4: Expected I, but got Obj
		//IL_0410: Expected I, but got Obj
		//IL_0426: Expected Obj, but got I
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_0108: Expected I, but got Obj
		//IL_04b0: Expected Obj, but got I4
		//IL_0155: Expected I, but got Obj
		//IL_01ef: Expected I4, but got Obj
		//IL_01a2: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_0267: Expected I, but got Obj
		object obj = default;
		MissionType missionType = (MissionType)(obj + 16);
		object obj2 = obj + 8;
		object obj3 = obj + 24;
		obj3 = 0;
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 7)
		{
			return;
		}
		string dataPath2 = Application.dataPath;
		if (dataPath2 == null)
		{
			return;
		}
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v22 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v89 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime firstInstallDate = UserSave.firstInstallDate;
		obj2 = firstInstallDate;
		((MissionType*)(int)missionType)->value__ = (int)obj2;
		if (((Achievements)null).GetAchievementIndexInArray(missionType) == 0)
		{
			nint num3 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v47 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v85 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
			nint num5 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v23 (Il2CppClass<Utils>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v40 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Utils.IsEnum((Type)(object)unfilteredLocale);
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v55 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v81 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int latestAvailableAssetBundlesVersion = UserSave.latestAvailableAssetBundlesVersion;
			int num9 = latestAvailableAssetBundlesVersion & 1;
			obj3 = num9;
			((MissionType*)(int)missionType)->value__ = num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string text = $"All Bundles Downloaded {args} in Country";
			string text2 = string.ConcatArray((string[])(object)"All Bundles Downloaded?;", (int)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
			string text3 = default;
			object obj8 = ((IConvertible)text3).ToType((Type)(object)";", (IFormatProvider)flag);
			nint num10 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v74 (Il2CppClass<Flurry>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num11 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v77 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		DateTime today = CDateTime.Today;
		nint num12 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v35 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num13 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v42 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = today;
		((MissionType*)(int)missionType)->value__ = (int)obj;
		UserSave.lastPurchasedBundle = (InAppData.BundleTier)missionType;
	}

	private void RegisterReminderStatus()
	{
	}

	private void RegisterDailyActiveCharacter()
	{
		//IL_00a8: Expected Obj, but got I4
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I4
		//IL_0121: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Info.Settings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Upgrades.CountUpgradeTiers();
		int num4 = num3 & 1;
		obj = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E241");
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterDailyActiveBoard()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_000d: Expected Obj, but got I4
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		obj = currentBoardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		obj2 = currentCharacterId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		string text = text2 + "_Theme" + text3;
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v15 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterDailyCoinsAmount()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_046b: Expected Obj, but got I4
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_0482: Expected Obj, but got I4
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected Obj, but got Unknown
		//IL_04b5: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		obj3 = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		Boards.BoardId previousBoardId = PlayerSave.previousBoardId;
		obj3 = previousBoardId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void RegisterDailyKeysAmount()
	{
		//IL_010e: Expected Obj, but got I4
		//IL_01a3: Expected I, but got Obj
		//IL_01b9: Expected Obj, but got I
		//IL_0125: Expected I, but got Obj
		//IL_003f: Expected Obj, but got I4
		//IL_00f1: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		int unrewardedCoins = InventorySave.unrewardedCoins;
		if (unrewardedCoins > 10000)
		{
			if (unrewardedCoins <= 100000)
			{
				string bracketForValue = ((HouseKeeper)null).GetBracketForValue(unrewardedCoins, (int[])10000);
			}
			else if (unrewardedCoins <= 1000000)
			{
				string bracketForValue2 = ((HouseKeeper)null).GetBracketForValue(unrewardedCoins, (int[])100000);
			}
			else if (unrewardedCoins > 3000000)
			{
				object obj = 3000000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text2 = default;
				string text = text2 + "+";
			}
			else
			{
				string bracketForValue3 = ((HouseKeeper)null).GetBracketForValue(unrewardedCoins, (int[])500000);
			}
		}
		else
		{
			string bracketForValue4 = ((HouseKeeper)null).GetBracketForValue(unrewardedCoins, (int[])1000);
		}
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterFacebookStatus()
	{
		//IL_006b: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int coins = InventorySave.coins;
		string text = FormatMessageWithNameIfPossible(null, (string)coins, (object[])(object)_dailyKeysBrackets);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v8 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private string RoundUpToTargetValue(int total, int factor)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		if (total != 0)
		{
			object obj = total + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [total @ L1 (System.Int32)+C]");
			int num = UnityEngine.Random.RandomRangeInt(0, 0);
			int num2 = num << 2;
			object original = obj + num2;
			UnityEngine.Object obj2 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
			throw new ArrayTypeMismatchException();
		}
		throw new ArrayTypeMismatchException();
	}

	private void RegisterDevicePerformanceLevel()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f3: Expected Obj, but got I4
		//IL_0105: Expected I, but got Obj
		//IL_011b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterOwnedCharactersAndOutfits()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v18 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe void IncrementTypeOfOwnedCharacter(Characters.CharacterId character, ref int regularCharactersOwned, ref int limitedCharactersOwned, ref int tokenCharactersOwned, ref int facebookCharactersOwned)
	{
		//IL_09cc: Expected I, but got Obj
		//IL_09e2: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got Ref
		//IL_02b6: Expected Obj, but got I
		//IL_01cf: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got Ref
		//IL_0aea: Expected VT, but got Ref
		//IL_0aea: Expected VT, but got Ref
		//IL_0aea: Expected VT, but got I4
		//IL_0aea: Expected Obj, but got I
		//IL_0afb: Expected F4, but got Obj
		//IL_0af6: Expected native int or pointer, but got F4
		//IL_02da: Expected Obj, but got I
		//IL_126a: Unknown result type (might be due to invalid IL or missing references)
		//IL_126f: Expected Obj, but got Unknown
		//IL_0220: Expected Obj, but got I4
		//IL_0b5b: Expected VT, but got Ref
		//IL_0b5b: Expected VT, but got Ref
		//IL_0b5b: Expected VT, but got I4
		//IL_0b5b: Expected Obj, but got I
		//IL_0b6c: Expected F4, but got Obj
		//IL_0b67: Expected native int or pointer, but got F4
		//IL_011b: Expected Obj, but got I
		//IL_0131: Expected Obj, but got Ref
		//IL_02fe: Expected Obj, but got I
		//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected Obj, but got Unknown
		//IL_0bcc: Expected VT, but got Ref
		//IL_0bcc: Expected VT, but got Ref
		//IL_0bcc: Expected VT, but got I4
		//IL_0bcc: Expected Obj, but got I
		//IL_0bdd: Expected F4, but got Obj
		//IL_0bd8: Expected native int or pointer, but got F4
		//IL_0233: Expected Obj, but got Ref
		//IL_0191: Expected Obj, but got I
		//IL_0322: Expected Obj, but got I
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0c3d: Expected VT, but got Ref
		//IL_0c3d: Expected VT, but got Ref
		//IL_0c3d: Expected VT, but got I4
		//IL_0c3d: Expected Obj, but got I
		//IL_0c4e: Expected F4, but got Obj
		//IL_0c49: Expected native int or pointer, but got F4
		//IL_0346: Expected Obj, but got I
		//IL_0cae: Expected VT, but got Ref
		//IL_0cae: Expected VT, but got Ref
		//IL_0cae: Expected VT, but got I4
		//IL_0cae: Expected Obj, but got I
		//IL_0cbf: Expected F4, but got Obj
		//IL_0cba: Expected native int or pointer, but got F4
		//IL_036a: Expected Obj, but got I
		//IL_0d1f: Expected VT, but got Ref
		//IL_0d1f: Expected VT, but got Ref
		//IL_0d1f: Expected VT, but got I4
		//IL_0d1f: Expected Obj, but got I
		//IL_0d30: Expected F4, but got Obj
		//IL_0d2b: Expected native int or pointer, but got F4
		//IL_038e: Expected Obj, but got I
		//IL_0d90: Expected VT, but got Ref
		//IL_0d90: Expected VT, but got Ref
		//IL_0d90: Expected VT, but got I4
		//IL_0d90: Expected Obj, but got I
		//IL_0da1: Expected F4, but got Obj
		//IL_0d9c: Expected native int or pointer, but got F4
		//IL_0dc6: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I
		//IL_0e0d: Expected VT, but got Ref
		//IL_0e0d: Expected VT, but got Ref
		//IL_0e0d: Expected VT, but got I4
		//IL_0e0d: Expected Obj, but got I
		//IL_0e1e: Expected F4, but got Obj
		//IL_0e19: Expected native int or pointer, but got F4
		//IL_0e43: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_03e2: Expected Obj, but got I
		//IL_0e8a: Expected VT, but got Ref
		//IL_0e8a: Expected VT, but got Ref
		//IL_0e8a: Expected VT, but got I4
		//IL_0e8a: Expected Obj, but got I
		//IL_0e9b: Expected F4, but got Obj
		//IL_0e96: Expected native int or pointer, but got F4
		//IL_0ec0: Expected Obj, but got I
		//IL_03cd: Expected Obj, but got I
		//IL_040c: Expected Obj, but got I
		//IL_0f07: Expected VT, but got Ref
		//IL_0f07: Expected VT, but got Ref
		//IL_0f07: Expected VT, but got I4
		//IL_0f07: Expected Obj, but got I
		//IL_0f18: Expected F4, but got Obj
		//IL_0f13: Expected native int or pointer, but got F4
		//IL_0f3d: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I
		//IL_0f84: Expected VT, but got Ref
		//IL_0f84: Expected VT, but got Ref
		//IL_0f84: Expected VT, but got I4
		//IL_0f84: Expected Obj, but got I
		//IL_0f95: Expected F4, but got Obj
		//IL_0f90: Expected native int or pointer, but got F4
		//IL_0fa5: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I
		//IL_0460: Expected Obj, but got I
		//IL_0fec: Expected VT, but got Ref
		//IL_0fec: Expected VT, but got Ref
		//IL_0fec: Expected VT, but got I4
		//IL_0fec: Expected Obj, but got I
		//IL_1015: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I
		//IL_048a: Expected Obj, but got I
		//IL_105c: Expected VT, but got Ref
		//IL_105c: Expected VT, but got Ref
		//IL_105c: Expected VT, but got I4
		//IL_105c: Expected Obj, but got I
		//IL_106d: Expected F4, but got Obj
		//IL_1068: Expected native int or pointer, but got F4
		//IL_107b: Expected I, but got Obj
		//IL_1091: Expected Obj, but got I
		//IL_0475: Expected Obj, but got I
		//IL_10b8: Expected Obj, but got Ref
		//IL_0511: Expected I, but got Obj
		//IL_0527: Expected Obj, but got I
		//IL_049d: Expected I, but got Obj
		//IL_10e5: Expected Obj, but got I4
		//IL_04e7: Expected Obj, but got I4
		//IL_04fe: Expected I4, but got Obj
		//IL_04fe: Expected Obj, but got I4
		//IL_04fe: Expected Obj, but got Ref
		//IL_0552: Expected I, but got Obj
		//IL_0597: Expected Obj, but got I4
		//IL_05a8: Expected F4, but got Obj
		//IL_05a3: Expected native int or pointer, but got F4
		//IL_113f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1144: Expected Obj, but got Unknown
		//IL_114d: Expected Obj, but got I4
		//IL_0603: Expected Obj, but got I
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_0666: Expected Obj, but got I4
		//IL_0677: Expected Obj, but got I
		//IL_1182: Unknown result type (might be due to invalid IL or missing references)
		//IL_1187: Expected Obj, but got Unknown
		//IL_1190: Expected Obj, but got I4
		//IL_0777: Expected Obj, but got I
		//IL_0696: Expected Obj, but got I4
		//IL_06a8: Expected Obj, but got VT
		//IL_06d8: Expected Obj, but got I4
		//IL_06e9: Expected Obj, but got I
		//IL_0703: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got VT
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected Obj, but got Unknown
		//IL_088e: Expected Obj, but got I
		//IL_0794: Unknown result type (might be due to invalid IL or missing references)
		//IL_0799: Expected Obj, but got Unknown
		//IL_07da: Expected Obj, but got I4
		//IL_07eb: Expected Obj, but got I
		//IL_11c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ca: Expected Obj, but got Unknown
		//IL_11d3: Expected Obj, but got I4
		//IL_0879: Expected Obj, but got I
		//IL_080a: Expected Obj, but got I4
		//IL_081c: Expected Obj, but got VT
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected Obj, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected Obj, but got Unknown
		//IL_08e2: Expected Obj, but got I4
		//IL_08f3: Expected Obj, but got I
		//IL_0912: Expected Obj, but got I4
		//IL_0924: Expected Obj, but got VT
		//IL_0954: Expected Obj, but got I4
		//IL_0965: Expected Obj, but got I
		//IL_097f: Expected Obj, but got I4
		//IL_0991: Expected Obj, but got VT
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b1: Expected Obj, but got Unknown
		nint num = (nint)typeof(CharacterRendering);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterRendering);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v239 (Il2CppClass<SYBO.Subway.Characters.CharacterRendering>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterCamera instance = CharacterCamera.Instance;
		int[] headstartBrackets = _headstartBrackets;
		int[] scoreBoosterBrackets = _scoreBoosterBrackets;
		if (headstartBrackets.Length != scoreBoosterBrackets.Length)
		{
			SDebug.LogFormat("Lists of hoverboard jumps and hoverboard hangtime animations does not have the same length", (object[])(object)this);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+38]");
		object obj2 = (nint)0 + (nint)12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v24+C]");
		object obj6 = default;
		if ((nint)0 < (nint)2)
		{
			if ((nint)obj2 == 1)
			{
				object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref facebookCharactersOwned, 3));
				object obj5 = obj6;
				object obj7 = default;
				object obj14 = default;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+38]");
					object obj8 = (nint)0 + (nint)16;
					object obj9 = obj8;
					object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref facebookCharactersOwned, 4));
					object obj11 = obj7 << 2;
					object obj12 = obj10 + obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v227+8]");
					if (0 == (nint)obj12)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+38]");
						object obj13 = (nint)0 + (nint)16;
						obj5 = obj13;
					}
					obj7 = obj14 + 1;
				}
			}
			else
			{
				object obj5 = obj6;
			}
		}
		else
		{
			object obj15 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref facebookCharactersOwned, 3));
			object obj5 = obj6;
			object obj16 = default;
			object obj26 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+38]");
				object obj17 = (nint)0 + (nint)16;
				object obj18 = obj16 << 2;
				object obj19 = obj17 + obj18;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v195+C]");
				if ((nint)0 != 0)
				{
					object obj21 = 0;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
					{
						object obj22 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref facebookCharactersOwned, 4));
						object obj23 = obj21 << 2;
						object obj24 = obj22 + obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v195+8]");
						if (0 == (nint)obj24)
						{
							obj5 = obj20;
						}
						object obj25 = obj21 + 1;
						obj21 = obj25;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v195+8]");
				if ((nint)0 == 0)
				{
					obj5 = obj20;
				}
				obj16 = obj26 + 1;
			}
		}
		float num3 = instance._previousCameraEndYPosition + 16f;
		int[] dailyKeysBrackets = _dailyKeysBrackets;
		GameObject objectToPosition;
		if (dailyKeysBrackets.Length != 0)
		{
			objectToPosition = (GameObject)(object)_dailyKeysBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+14]");
			objectToPosition = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+14]");
		IEnumerator enumerator = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num3)->m_value = (float)enumerator;
		float num4 = instance._previousCameraEndYPosition + 20f;
		int[] consumableHoverboardBrackets = _consumableHoverboardBrackets;
		GameObject objectToPosition2;
		if (consumableHoverboardBrackets.Length != 0)
		{
			objectToPosition2 = (GameObject)(object)_consumableHoverboardBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+18]");
			objectToPosition2 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+18]");
		IEnumerator enumerator2 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition2, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num4)->m_value = (float)enumerator2;
		float num5 = instance._previousCameraEndYPosition + 24f;
		int[] consumableHoverboardBrackets2 = _consumableHoverboardBrackets;
		GameObject objectToPosition3;
		if (consumableHoverboardBrackets2.Length != 0)
		{
			objectToPosition3 = (GameObject)(object)_consumableHoverboardBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+18]");
			objectToPosition3 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+18]");
		IEnumerator enumerator3 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition3, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num5)->m_value = (float)enumerator3;
		float num6 = instance._previousCameraEndYPosition + 28f;
		int[] consumableHoverboardBrackets3 = _consumableHoverboardBrackets;
		GameObject objectToPosition4;
		if (consumableHoverboardBrackets3.Length != 0)
		{
			objectToPosition4 = (GameObject)(object)_consumableHoverboardBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+18]");
			objectToPosition4 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+18]");
		IEnumerator enumerator4 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition4, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num6)->m_value = (float)enumerator4;
		float num7 = instance._previousCameraEndYPosition + 32f;
		int[] headstartBrackets2 = _headstartBrackets;
		GameObject objectToPosition5;
		if (headstartBrackets2.Length != 0)
		{
			objectToPosition5 = (GameObject)(object)_headstartBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+1C]");
			objectToPosition5 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+1C]");
		IEnumerator enumerator5 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition5, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num7)->m_value = (float)enumerator5;
		float num8 = instance._previousCameraEndYPosition + 36f;
		int[] headstartBrackets3 = _headstartBrackets;
		GameObject objectToPosition6;
		if (headstartBrackets3.Length != 0)
		{
			objectToPosition6 = (GameObject)(object)_headstartBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+1C]");
			objectToPosition6 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+1C]");
		IEnumerator enumerator6 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition6, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num8)->m_value = (float)enumerator6;
		float num9 = instance._previousCameraEndYPosition + 44f;
		int[] scoreBoosterBrackets2 = _scoreBoosterBrackets;
		GameObject objectToPosition7;
		if (scoreBoosterBrackets2.Length != 0)
		{
			objectToPosition7 = (GameObject)(object)_scoreBoosterBrackets;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+20]");
			objectToPosition7 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+20]");
		IEnumerator enumerator7 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition7, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num9)->m_value = (float)enumerator7;
		float num10 = instance._previousCameraEndYPosition + 56f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+20]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S3_v31+C]");
		GameObject objectToPosition8;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+20]");
			objectToPosition8 = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+24]");
			objectToPosition8 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+24]");
		IEnumerator enumerator8 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition8, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num10)->m_value = (float)enumerator8;
		float num11 = instance._previousCameraEndYPosition + 60f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+24]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S3_v35+C]");
		GameObject objectToPosition9;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+24]");
			objectToPosition9 = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+28]");
			objectToPosition9 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+28]");
		IEnumerator enumerator9 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition9, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num11)->m_value = (float)enumerator9;
		float num12 = instance._previousCameraEndYPosition - -64f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+28]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S3_v39+C]");
		GameObject objectToPosition10;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+28]");
			objectToPosition10 = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+2C]");
			objectToPosition10 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+2C]");
		IEnumerator enumerator10 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition10, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num12)->m_value = (float)enumerator10;
		float num13 = instance._previousCameraEndYPosition + 80f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+2C]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S3_v43+C]");
		GameObject objectToPosition11;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+2C]");
			objectToPosition11 = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+30]");
			objectToPosition11 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+30]");
		IEnumerator enumerator11 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition11, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num13)->m_value = (float)enumerator11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+30]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S2_v26+C]");
		GameObject objectToPosition12;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+30]");
			objectToPosition12 = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+34]");
			objectToPosition12 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+34]");
		IEnumerator enumerator12 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition12, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		float num14 = instance._previousCameraEndYPosition + 84f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+34]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S3_v48+C]");
		GameObject objectToPosition13;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+34]");
			objectToPosition13 = (GameObject)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [limitedCharactersOwned @ L3 (System.Int32&)+38]");
			objectToPosition13 = (GameObject)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+38]");
		IEnumerator enumerator13 = ((SSEventsPopup)this).DelayPositioning((UISprite)0, objectToPosition13, (Vector3)character, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned), (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref tokenCharactersOwned));
		((float*)(nint)num14)->m_value = (float)enumerator13;
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S0_v67 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v183 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned)).FindKernel(null) != 0)
		{
			UnityEngine.Object obj34 = UnityEngine.Object.Instantiate((UnityEngine.Object)_hasAddedAgeRestrictionEventListener);
			((AnimationState)System.Runtime.CompilerServices.Unsafe.AsPointer(ref regularCharactersOwned)).AddMixingTransform((Transform)_hasAddedAgeRestrictionEventListener, (byte)(int)obj34 != 0);
		}
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj35 = (nint)0 & (nint)0x200;
		if (obj35 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)_hasAddedAgeRestrictionEventListener).FindKernel(null) != 0)
		{
			float num19 = instance._previousCameraEndYPosition + 184f;
			UnityEngine.Object obj36 = UnityEngine.Object.Instantiate((UnityEngine.Object)_hasAddedAgeRestrictionEventListener);
			((float*)(nint)num19)->m_value = (float)obj36;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+3C]");
		if ((nint)0 == 0)
		{
			_ = 1;
			_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)instance).GetComponentsInChildren<T>();
			((RunnerAnimPlayer)(object)componentsInChildren)._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+1C]");
			int[] array;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+1C]");
				array = (int[])0;
			}
			else
			{
				array = _headstartBrackets;
			}
			object obj37 = array + 12;
			object obj38 = 0;
			int num20 = default;
			int num21 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj37))
			{
				object obj39 = array + 16;
				object obj40 = obj38 << 2;
				object obj41 = obj39 + obj40;
				object obj42 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 1;
				object obj43 = num20 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v156+8]");
				UnityEngine.Object obj44 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				obj43 = obj44;
				object obj45 = num20 + 24;
				obj45 = componentsInChildren[17];
				((AnimationSoundPlayer)(object)componentsInChildren).PlayKeyframeAnimation(num20);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 2;
				object obj46 = num21 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ S0_v156+8]");
				UnityEngine.Object obj47 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				obj46 = obj47;
				object obj48 = num21 + 24;
				obj48 = componentsInChildren[19];
				((AnimationSoundPlayer)(object)componentsInChildren).PlayKeyframeAnimation(num21);
				object obj49 = obj38 + 1;
				obj38 = obj49;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+18]");
			int[] array2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+18]");
				array2 = (int[])0;
			}
			else
			{
				array2 = _consumableHoverboardBrackets;
			}
			object obj50 = array2 + 12;
			object obj51 = 0;
			int num22 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50))
			{
				object obj52 = array2 + 16;
				object obj53 = obj51 << 2;
				object obj54 = obj52 + obj53;
				object obj55 = obj54;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0;
				object obj56 = num22 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S0_v138+8]");
				UnityEngine.Object obj57 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				obj56 = obj57;
				object obj58 = num22 + 24;
				obj58 = componentsInChildren[17];
				((AnimationSoundPlayer)(object)componentsInChildren).PlayKeyframeAnimation(num22);
				object obj59 = obj51 + 1;
				obj51 = obj59;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+24]");
			object obj60;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ L6_v9+24]");
				obj60 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (HouseKeeper)+20]");
				obj60 = 0;
			}
			object obj61 = obj60 + 12;
			object obj62 = 0;
			int num23 = default;
			int num24 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj62) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj61))
			{
				object obj63 = obj60 + 16;
				object obj64 = obj62 << 2;
				object obj65 = obj63 + obj64;
				object obj66 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0;
				object obj67 = num23 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v112+8]");
				UnityEngine.Object obj68 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				obj67 = obj68;
				object obj69 = num23 + 24;
				obj69 = componentsInChildren[16];
				((AnimationSoundPlayer)(object)componentsInChildren).PlayKeyframeAnimation(num23);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 4;
				object obj70 = num24 + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v112+8]");
				UnityEngine.Object obj71 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
				obj70 = obj71;
				object obj72 = num24 + 24;
				obj72 = componentsInChildren[18];
				((AnimationSoundPlayer)(object)componentsInChildren).PlayKeyframeAnimation(num24);
				object obj73 = obj62 + 1;
				obj62 = obj73;
			}
		}
	}

	private unsafe void IncrementOwnedOutfits(Characters.CharacterId character, ref int outfitsOwned)
	{
		//IL_007f: Expected Obj, but got Ref
		//IL_0090: Expected VT, but got Obj
		//IL_0090: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005b: Expected Obj, but got Ref
		//IL_0070: Expected I4, but got Obj
		//IL_0070: Expected Obj, but got Ref
		//IL_0070: Expected Obj, but got I4
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref outfitsOwned));
		CollisionFlags collisionFlags = ((CharacterController)character).Move((Vector3)obj);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)collisionFlags != null)
		{
			UnityEngine.Object obj3 = UnityEngine.Object.Instantiate((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref outfitsOwned));
			((AnimationState)character).AddMixingTransform((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref outfitsOwned), (byte)(int)obj3 != 0);
		}
	}

	public void RegisterOwnedHoverboardsAndAbilities()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_043b: Expected Obj, but got I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected Obj, but got Unknown
		//IL_0474: Expected Obj, but got I4
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_048b: Expected Obj, but got I4
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04b9: Expected Obj, but got I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04d0: Expected Obj, but got I4
		//IL_04de: Expected I, but got Obj
		//IL_04f4: Expected Obj, but got I
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected Obj, but got Unknown
		//IL_00f7: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 72;
		obj5 = 0;
		object obj6 = obj2 + 68;
		obj6 = 0;
		object obj7 = obj2 - -64;
		obj7 = 0;
		object obj8 = obj2 + 60;
		obj8 = 0;
		object obj9 = obj2 + 56;
		obj9 = 0;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v155 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 12;
		object obj12 = obj2 + 8;
		object obj13 = obj2 + 4;
		object obj14 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v39+8]");
		_ = 0;
		object obj15 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj15 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj16 = obj4 + 4;
		object obj17 = obj16 + 1;
		obj16 = obj17;
		object obj18 = obj17 << 2;
		object obj19 = obj4 + obj18;
		obj19 = 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj4 + obj20;
			if ((nint)obj21 == 88)
			{
				object obj22 = obj4 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_05b1;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05b1;
		IL_05b1:
		object obj25 = obj6 + obj5;
		object obj26 = obj7 + obj25;
		object obj27 = obj8 + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		obj14 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}

	private void RegisterOwnedConsumableHoverboards()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected Obj, but got Unknown
		//IL_0b03: Expected Obj, but got I4
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected Obj, but got Unknown
		//IL_0b20: Expected Obj, but got I4
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected Obj, but got Unknown
		//IL_0b43: Expected Obj, but got I4
		//IL_0b4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b51: Expected Obj, but got Unknown
		//IL_0b5a: Expected Obj, but got I4
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected Obj, but got Unknown
		//IL_0b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8a: Expected Obj, but got Unknown
		//IL_0b93: Expected Obj, but got I4
		//IL_0ba1: Expected I, but got Obj
		//IL_0bb7: Expected Obj, but got I
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected Obj, but got Unknown
		//IL_0d8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected Obj, but got Unknown
		//IL_0dbc: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected Obj, but got Unknown
		//IL_0c1c: Expected Obj, but got I4
		//IL_0c25: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0dcf: Expected I, but got Obj
		//IL_0de5: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_0430: Expected I, but got Obj
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected Obj, but got Unknown
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected Obj, but got Unknown
		//IL_0861: Expected Obj, but got I4
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0186: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_08e1: Expected Obj, but got I
		//IL_04c0: Expected I, but got Obj
		//IL_04d6: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_0917: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected Obj, but got Unknown
		//IL_0501: Expected I, but got Obj
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected Obj, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected Obj, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected Obj, but got Unknown
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected Obj, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Expected Obj, but got Unknown
		//IL_0cf3: Expected Obj, but got I4
		//IL_05a3: Expected I, but got Obj
		//IL_05b9: Expected Obj, but got I
		//IL_0713: Expected Obj, but got I
		//IL_05e4: Expected I, but got Obj
		//IL_07a8: Expected Obj, but got I4
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Expected Obj, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 + 104;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 80;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 - -64;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 56;
		obj7 = obj;
		_ = -1;
		object obj8 = obj2 + 120;
		obj8 = 0;
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v29 (Il2CppClass<Info.Boards>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v394 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 40;
		object obj11 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = 0;
		object obj13 = default;
		object obj15 = default;
		object obj17 = default;
		object obj20 = default;
		object obj21 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v328 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num4 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v386 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj15 == null)
			{
				continue;
			}
			nint num5 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S0_v337 (Il2CppClass<Info.Boards>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num6 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v377 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj17 == null)
			{
				continue;
			}
			nint num7 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v350 (Il2CppClass<Info.Boards>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num8 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v368 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v361+25]");
			if ((nint)0 == 0)
			{
				object obj19 = obj12 + 1;
				obj12 = obj19;
			}
			else
			{
				obj20 = obj21 + 1;
			}
		}
		object obj22 = obj7 + 4;
		object obj23 = obj22 + 1;
		obj22 = obj23;
		object obj24 = obj23 << 2;
		object obj25 = obj7 + obj24;
		obj25 = 108;
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
			object obj27 = (nint)0 << 2;
			object obj28 = obj7 + obj27;
			if ((nint)obj28 == 108)
			{
				object obj29 = obj7 + 4;
				if ((nint)obj29 > -1)
				{
					object obj30 = obj29 + -1;
					obj29 = obj30;
				}
				goto IL_0dc1;
			}
		}
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0dc1;
		IL_0dc1:
		nint num9 = (nint)typeof(HoverboardThemes);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v57 (Il2CppClass<HoverboardThemes>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num10 = (nint)typeof(HoverboardThemes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v282 (Il2CppClass<HoverboardThemes>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj32 = default;
		object obj34 = default;
		object obj36 = default;
		object obj47 = default;
		object obj49 = default;
		object obj50 = default;
		object obj51 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj32 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num11 = (nint)typeof(HoverboardThemes);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ S0_v164 (Il2CppClass<HoverboardThemes>)+BA]");
				object obj33 = (nint)0 & (nint)0x200;
				if (obj33 != null)
				{
					nint num12 = (nint)typeof(HoverboardThemes);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ S0_v273 (Il2CppClass<HoverboardThemes>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj6 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v34+8]");
				_ = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj34 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					nint num13 = (nint)typeof(BoardManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ S0_v257 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
					object obj35 = (nint)0 & (nint)0x200;
					if (obj35 != null)
					{
						nint num14 = (nint)typeof(BoardManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ S0_v266 (Il2CppClass<Data.Managers.BoardManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj36 != null)
					{
						object obj37 = obj8 + 1;
						obj8 = obj37;
					}
				}
				object obj38 = obj7 + 4;
				object obj39 = obj38 + 1;
				obj38 = obj39;
				object obj40 = obj39 << 2;
				object obj41 = obj7 + obj40;
				obj41 = 215;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
					object obj42 = (nint)0 << 2;
					object obj43 = obj7 + obj42;
					if ((nint)obj43 == 215)
					{
						object obj44 = obj7 + 4;
						if ((nint)obj44 > -1)
						{
							object obj45 = obj44 + -1;
							obj44 = obj45;
						}
						continue;
					}
				}
				if (obj26 == null)
				{
					obj26 = 0;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj46 = obj47;
				object obj48 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				if (obj46 != obj50)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				obj26 = obj51;
			}
			else
			{
				object obj52 = obj7 + 4;
				object obj53 = obj52 + 1;
				obj52 = obj53;
				object obj54 = obj53 << 2;
				object obj55 = obj7 + obj54;
				obj55 = 240;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24+4]");
				object obj56 = (nint)0 << 2;
				object obj57 = obj7 + obj56;
				if ((nint)obj57 == 240)
				{
					object obj58 = obj7 + 4;
					if ((nint)obj58 > -1)
					{
						object obj59 = obj58 + -1;
						obj58 = obj59;
					}
					goto IL_0e16;
				}
			}
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0e16;
			IL_0e16:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj60 = obj20 + obj12;
			obj2 = obj60;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void RegisterOwnedHeadstarts()
	{
		//IL_0070: Expected Obj, but got I4
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int tier = InventorySave.GetTier(UpgradeType.hoverboard);
		string text = FormatMessageWithNameIfPossible(null, (string)tier, (object[])(object)_consumableHoverboardBrackets);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v8 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterOwnedScoreBoosters()
	{
		//IL_0070: Expected Obj, but got I4
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int tier = InventorySave.GetTier(UpgradeType.headstart2000);
		string text = FormatMessageWithNameIfPossible(null, (string)tier, (object[])(object)_headstartBrackets);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v8 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterTotalAmountOfFinishedDiamondAwards()
	{
		//IL_0070: Expected Obj, but got I4
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		int tier = InventorySave.GetTier(UpgradeType.scorebooster);
		string text = FormatMessageWithNameIfPossible(null, (string)tier, (object[])(object)_scoreBoosterBrackets);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v8 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterTotalAmountOfFinishedGoldAwards()
	{
		//IL_00e9: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)4);
		obj = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterTotalAmountOfFinishedSilverAwards()
	{
		//IL_00e9: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)3);
		obj = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterBundleIdentifier()
	{
		//IL_00e9: Expected Obj, but got I4
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I4
		//IL_014e: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		bool flag = ((AwardsManager)(object)instance).ShouldInsertAwardToList((Award)2);
		obj = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void RegisterLocale()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string locale = DeviceUtility.GetLocale();
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private string GetBracketForValue(int value, int[] bracket)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = 1;
		while (true)
		{
			if ((nint)obj3 <= 10)
			{
				object obj4 = (object)bracket * obj3;
				if ((nint)obj4 >= value)
				{
					break;
				}
				object obj5 = obj3 + 1;
				obj3 = obj5;
				continue;
			}
			return "";
		}
		object obj6 = (object)bracket * obj3;
		object obj7 = obj6 - (object)bracket;
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string text2 = default;
		return text + " - " + text2;
	}

	private void RegisterFirstInstallDate()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void PostFlurryEventsOnceADay()
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got I4
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0314: Expected I, but got Obj
		//IL_032a: Expected Obj, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got VT
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got VT
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got VT
		//IL_02e5: Expected Obj, but got I8
		//IL_00ee: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v72 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastTimeAVideoForKeysWasSeen = UserSave.lastTimeAVideoForKeysWasSeen;
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v22 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v66 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 16;
		obj5 = lastTimeAVideoForKeysWasSeen;
		object obj6 = obj2 + 8;
		obj6 = DateTime.MinValue;
		object obj7 = obj2 + 32;
		obj7 = obj5;
		string text = (string)(obj2 + 40);
		text = (string)obj6;
		object obj8 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		object obj9 = text & 0x3FFFFFFFFFFFFFFFL;
		if (obj8 != obj9)
		{
			nint num5 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v53 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(TimeUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v62 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj2 = lastTimeAVideoForKeysWasSeen;
			text = (string)obj2;
			long num7 = TimeUtility.RFC1123StringToUnixTime(text);
			object obj11 = num7 * 1000;
			obj = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
		}
		nint num8 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<Flurry>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v48 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe void OnApplicationPause(bool pause)
	{
		//IL_01d6: Expected I, but got Obj
		//IL_01ec: Expected Obj, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_032e: Expected Obj, but got VT
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected I4, but got Unknown
		//IL_0349: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_026e: Expected I, but got Obj
		//IL_0284: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_02b8: Expected I, but got Obj
		//IL_02ce: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got VT
		//IL_0300: Expected I4, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v57 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 8;
		DateTime lastPlayDate = UserSave.lastPlayDate;
		obj2 = lastPlayDate;
		MissionType missionType = (MissionType)(obj3 + 16);
		((MissionType*)(int)missionType)->value__ = (int)obj2;
		if (((Achievements)null).GetAchievementIndexInArray(missionType) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v53 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
		nint num5 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v14 (Il2CppClass<Utils>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v25 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Utils.IsEnum((Type)(object)unfilteredLocale);
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v31 (Il2CppClass<Flurry>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v49 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime today = CDateTime.Today;
		nint num9 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v38 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v45 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = today;
		((MissionType*)(int)missionType)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @934B");
	}

	private unsafe void OnApplicationQuit()
	{
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I4
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		//IL_0394: Expected Obj, but got VT
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected I4, but got Unknown
		//IL_03af: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00f9: Expected I, but got Obj
		//IL_010f: Expected Obj, but got I
		//IL_031e: Expected I, but got Obj
		//IL_0334: Expected Obj, but got I
		//IL_013a: Expected I, but got Obj
		//IL_0359: Expected Obj, but got VT
		//IL_0366: Expected I4, but got Obj
		//IL_022d: Expected I, but got Obj
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_01e0: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v80 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		DateTime lastQuitDate = UserSave.lastQuitDate;
		obj4 = lastQuitDate;
		MissionType missionType = (MissionType)(obj2 + 16);
		((MissionType*)(int)missionType)->value__ = (int)obj4;
		if (((Achievements)null).GetAchievementIndexInArray(missionType) != 0)
		{
			return;
		}
		((HouseKeeper)null).RegisterDailyActiveCharacter();
		RegisterDailyKeysAmount();
		RegisterFacebookStatus();
		((HouseKeeper)null).RegisterDailyActiveBoard();
		((HouseKeeper)null).RegisterDailyCoinsAmount();
		((HouseKeeper)null).RegisterDevicePerformanceLevel();
		((HouseKeeper)null).RegisterOwnedCharactersAndOutfits();
		RegisterOwnedHoverboardsAndAbilities();
		((HouseKeeper)null).RegisterOwnedConsumableHoverboards();
		RegisterOwnedHeadstarts();
		RegisterOwnedScoreBoosters();
		((HouseKeeper)null).RegisterTotalAmountOfFinishedGoldAwards();
		((HouseKeeper)null).RegisterTotalAmountOfFinishedSilverAwards();
		((HouseKeeper)null).RegisterBundleIdentifier();
		RegisterTotalAmountOfFinishedDiamondAwards();
		((HouseKeeper)null).PostFlurryEventsOnceADay();
		((HouseKeeper)null).RegisterLocale();
		((HouseKeeper)null).RegisterFirstInstallDate();
		nint num3 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v43 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v76 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		StorageSizeLogging.InitDevicePaths();
		string localNotificationMessage = ((HouseKeeper)null).GetLocalNotificationMessage();
		obj = localNotificationMessage;
		if ((nint)localNotificationMessage >= 1)
		{
			NumberFormatInfo currentInfo = NumberFormatInfo.CurrentInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D55B");
			nint num5 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v69 (Il2CppClass<Flurry>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v72 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		DateTime today = CDateTime.Today;
		nint num7 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v55 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v62 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = today;
		((MissionType*)(int)missionType)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @934D");
	}

	private int GetNumberOfDaysSinceLastPlay()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int result = default;
		return result;
	}

	private bool IsDateToday(DateTime lastDate)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got VT
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj = lastDate;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v5+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		object obj5 = default;
		obj2 = obj5;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	private void CancellAllLocalNotifications()
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		ScheduleDailyWordNotificationIfNecessary();
		((HouseKeeper)null).RegisterLocalNotificationStatus();
		nint num = (nint)typeof(OnboardingTracking);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<Onboarding.OnboardingTracking>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnboardingTracking);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v33 (Il2CppClass<Onboarding.OnboardingTracking>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnboardingTracking._002Ecctor();
		nint num3 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v29 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		nint num5 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v20 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSave.OnProccessUnsuccessful();
	}

	private void ScheduleLocalNotificationsIfNecessary()
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!DeviceUtility.GetIOSOtherAudioPlaying())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A44");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
	}

	private unsafe void ScheduleDailyWordNotificationIfNecessary()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected I4, but got Unknown
		//IL_0342: Expected I, but got Obj
		//IL_0358: Expected Obj, but got I
		//IL_03d2: Expected I, but got Obj
		//IL_03e8: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_02ae: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_0304: Expected I4, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_0147: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		bool flag = (byte)(obj2 + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v120 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		object obj5 = default;
		if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"enable_local_notifications", flag))
		{
			nint num3 = (nint)typeof(bool);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v45 (Il2CppClass<System.Boolean>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(bool);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v110 (Il2CppClass<System.Boolean>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj6 = default;
			obj5 = ((obj6 == null) ? ((object)13) : ((object)0));
		}
		nint num5 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v25 (Il2CppClass<Info.Settings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v38 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = obj5 & 0xF;
		bool flag2 = obj8 == null;
		int num7 = Upgrades.CountUpgradeTiers();
		if (((flag2 ? 1u : 0u) & (uint)num7) != 0)
		{
			ScheduleTopRunNotificationIfNecessary();
			ScheduleDailyVideoNotificationIfNecessary();
			TriggerActionForFacebookPayout((byte)(int)this != 0);
		}
	}

	private unsafe void ScheduleTopRunNotificationIfNecessary()
	{
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected Obj, but got Unknown
		//IL_079c: Expected Obj, but got I4
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected Obj, but got Unknown
		//IL_07b3: Expected Obj, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_07ca: Expected Obj, but got I4
		//IL_07d8: Expected I, but got Obj
		//IL_07ee: Expected Obj, but got I
		//IL_0cd0: Expected I, but got Obj
		//IL_0ce6: Expected Obj, but got I
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_0819: Expected Obj, but got Unknown
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_0830: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected Obj, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected Obj, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0851: Expected Obj, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected Obj, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087b: Expected Obj, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected Obj, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected Obj, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected Obj, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected Obj, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected Obj, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected Obj, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected Obj, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected Obj, but got Unknown
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Expected Obj, but got Unknown
		//IL_090f: Expected Obj, but got VT
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected Obj, but got Unknown
		//IL_0926: Expected Obj, but got VT
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected VT, but got Unknown
		//IL_0941: Expected I8, but got Obj
		//IL_093c: Expected native int or pointer, but got VT
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_098f: Expected Obj, but got VT
		//IL_09af: Expected I, but got Obj
		//IL_09c5: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_018a: Expected Obj, but got VT
		//IL_0197: Expected I8, but got Obj
		//IL_0192: Expected native int or pointer, but got VT
		//IL_01ac: Expected Ref, but got VT
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_01ff: Expected I, but got Obj
		//IL_024f: Expected Obj, but got VT
		//IL_0257: Expected Obj, but got VT
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_053a: Expected I, but got Obj
		//IL_0550: Expected Obj, but got I
		//IL_0c1e: Expected Obj, but got VT
		//IL_0c26: Expected Obj, but got I8
		//IL_0c33: Expected I8, but got Obj
		//IL_0c2e: Expected native int or pointer, but got VT
		//IL_041e: Expected I, but got Obj
		//IL_0434: Expected Obj, but got I
		//IL_06a9: Expected I, but got Obj
		//IL_0b9d: Expected Obj, but got VT
		//IL_0ba5: Expected Obj, but got I8
		//IL_0bb2: Expected I8, but got Obj
		//IL_0bad: Expected native int or pointer, but got VT
		//IL_0b20: Expected Obj, but got VT
		//IL_0b28: Expected Obj, but got VT
		//IL_0b35: Expected I8, but got Obj
		//IL_0b30: Expected native int or pointer, but got VT
		//IL_033e: Expected I, but got Obj
		//IL_0354: Expected Obj, but got I
		//IL_06f6: Expected I, but got Obj
		//IL_070c: Expected Obj, but got I
		//IL_05aa: Expected I, but got Obj
		//IL_045f: Expected I, but got Obj
		//IL_0a5d: Expected I, but got Obj
		//IL_0a73: Expected Obj, but got I
		//IL_0c75: Expected Obj, but got VT
		//IL_0c7d: Expected Obj, but got I8
		//IL_0c8a: Expected I8, but got Obj
		//IL_0c85: Expected native int or pointer, but got VT
		//IL_05f7: Expected I, but got Obj
		//IL_060d: Expected Obj, but got I
		//IL_04ac: Expected I, but got Obj
		//IL_04c2: Expected Obj, but got I
		//IL_0aa0: Expected Obj, but got VT
		//IL_0aad: Expected I8, but got Obj
		//IL_0aa8: Expected native int or pointer, but got VT
		//IL_0ae1: Expected Obj, but got VT
		//IL_0aee: Expected I8, but got Obj
		//IL_0ae9: Expected native int or pointer, but got VT
		//IL_037f: Expected I, but got Obj
		//IL_0737: Expected I, but got Obj
		//IL_0be9: Expected Obj, but got I8
		//IL_0bf2: Expected Obj, but got VT
		//IL_0bff: Expected I8, but got Obj
		//IL_0bfa: Expected native int or pointer, but got VT
		//IL_0b7e: Expected Obj, but got VT
		//IL_03cc: Expected I, but got Obj
		//IL_0638: Expected I, but got Obj
		//IL_04ed: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		WordHuntManager wordHuntManager = (WordHuntManager)(obj2 + 192);
		wordHuntManager = (WordHuntManager)0;
		object obj3 = obj2 + 24;
		obj3 = 0;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v279 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime wordHuntExpireDeviceTime = EventsSave.wordHuntExpireDeviceTime;
		nint num3 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v273 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 152;
		object obj7 = obj2 + 144;
		object obj8 = obj2 + 136;
		object obj9 = obj2 + 128;
		object obj10 = obj2 + 120;
		object obj11 = obj2 + 112;
		object obj12 = obj2 + 104;
		object obj13 = obj2 + 96;
		object obj14 = obj2 + 88;
		object obj15 = obj2 + 80;
		object obj16 = obj2 + 72;
		object obj17 = obj2 - -64;
		object obj18 = obj2 + 56;
		object obj19 = obj2 + 40;
		object obj20 = obj2 + 32;
		object obj21 = obj2 + 16;
		object obj22 = obj2 + 8;
		object obj23 = obj2 + 168;
		obj23 = wordHuntExpireDeviceTime;
		object obj24 = obj2 + 160;
		obj24 = TimeSpan.Zero;
		DateTime dateTime = (DateTime)(obj2 + 176);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj23;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 184);
		formatProvider = (IFormatProvider)obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FD");
		object obj25 = default;
		if (obj25 == null)
		{
			return;
		}
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v76 (Il2CppClass<System.DateTime>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S0_v269 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime defaultLocalFileTime = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
		object obj27 = default;
		obj = obj27;
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v83 (Il2CppClass<Strings>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v265 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
		string[] achievementIds = ((Achievements)null).achievementIds;
		DateTime utcNow = CDateTime.UtcNow;
		obj6 = obj;
		obj7 = utcNow;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj6;
		formatProvider = (IFormatProvider)obj7;
		long num9 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		nint num10 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v103 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num11 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v261 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string dailyWordOffline = wordHuntManager.GetDailyWordOffline();
		if ((nint)dailyWordOffline <= 0)
		{
			return;
		}
		DateTime utcNow2 = CDateTime.UtcNow;
		obj3 = utcNow2;
		obj8 = wordHuntExpireDeviceTime;
		formatProvider = (IFormatProvider)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC94");
		object obj30 = default;
		obj3 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9F");
		object obj31 = default;
		obj3 = obj31;
		object obj32 = obj3 & 0x3FFFFFFFFFFFFFFFL;
		object obj33 = obj32 / 36000000000L;
		object obj34 = obj33 / 24;
		object obj35 = obj34 * 24;
		object obj36 = obj33 - obj35;
		bool flag = (nint)obj36 == 17;
		bool flag2 = wordHuntManager == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num12 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v228 (Il2CppClass<System.TimeSpan>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				if (obj37 != null)
				{
					nint num13 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v257 (Il2CppClass<System.TimeSpan>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TimeSpan timeSpan = TimeSpan.FromHours(1.0);
				nint num14 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v235 (Il2CppClass<System.DateTime>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num15 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v253 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj9 = obj;
				obj10 = timeSpan;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj9;
				formatProvider = (IFormatProvider)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
				TimeSpan timeSpan2 = TimeSpan.FromMilliseconds(1.0);
				object obj39 = default;
				obj11 = obj39;
				obj12 = timeSpan2;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj11;
				formatProvider = (IFormatProvider)obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF2");
				return;
			}
			nint num16 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v195 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num17 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v221 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TimeSpan timeSpan3 = TimeSpan.FromMilliseconds(1.0);
			obj13 = wordHuntExpireDeviceTime;
			obj14 = timeSpan3;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj13;
			formatProvider = (IFormatProvider)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FD");
			object obj41 = default;
			if (obj41 == null)
			{
				return;
			}
			nint num18 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v209 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj42 = (nint)0 & (nint)0x200;
			if (obj42 != null)
			{
				nint num19 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S0_v217 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TimeSpan timeSpan4 = TimeSpan.FromMilliseconds(1.0);
			obj15 = timeSpan4;
			formatProvider = (IFormatProvider)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCD8");
			return;
		}
		nint num20 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v122 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj43 = (nint)0 & (nint)0x200;
		bool flag3 = obj43 == null;
		if (flag2)
		{
			if (!flag3)
			{
				nint num21 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v188 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj20 = wordHuntExpireDeviceTime;
			obj21 = num9;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj20;
			formatProvider = (IFormatProvider)obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FD");
			object obj44 = default;
			if (obj44 == null)
			{
				return;
			}
			nint num22 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v169 (Il2CppClass<System.TimeSpan>)+BA]");
			object obj45 = (nint)0 & (nint)0x200;
			if (obj45 != null)
			{
				nint num23 = (nint)typeof(TimeSpan);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v182 (Il2CppClass<System.TimeSpan>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj22 = num9;
			obj2 = TimeSpan.Zero;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj22;
			formatProvider = (IFormatProvider)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FD");
			return;
		}
		if (!flag3)
		{
			nint num24 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v154 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj16 = wordHuntExpireDeviceTime;
		obj17 = num9;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj16;
		formatProvider = (IFormatProvider)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FB");
		object obj46 = default;
		if (obj46 != null)
		{
			return;
		}
		nint num25 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v138 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj47 = (nint)0 & (nint)0x200;
		if (obj47 != null)
		{
			nint num26 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v150 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj18 = wordHuntExpireDeviceTime;
		obj19 = num9;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj18;
		formatProvider = (IFormatProvider)obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FD");
		object obj48 = default;
		if (obj48 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		}
	}

	private void ScheduleDailyVideoNotificationIfNecessary()
	{
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected Obj, but got Unknown
		//IL_0958: Expected Obj, but got I4
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_0966: Expected Obj, but got Unknown
		//IL_096f: Expected Obj, but got I4
		//IL_0987: Expected I, but got Obj
		//IL_099d: Expected Obj, but got I
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected Obj, but got Unknown
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d6: Expected Obj, but got Unknown
		//IL_09df: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e4: Expected Obj, but got Unknown
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected Obj, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got Unknown
		//IL_0a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected Obj, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2a: Expected Obj, but got Unknown
		//IL_0a33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected Obj, but got Unknown
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Obj, but got Unknown
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Expected Obj, but got Unknown
		//IL_0a5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a62: Expected Obj, but got Unknown
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected Obj, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7e: Expected Obj, but got Unknown
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected Obj, but got Unknown
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected Obj, but got Unknown
		//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa8: Expected Obj, but got Unknown
		//IL_0ab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected Obj, but got Unknown
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Expected Obj, but got Unknown
		//IL_0acd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected Obj, but got Unknown
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected Obj, but got Unknown
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Expected Obj, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_0b05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected Obj, but got Unknown
		//IL_0b1b: Expected Obj, but got VT
		//IL_005a: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_007a: Expected Obj, but got VT
		//IL_00ac: Expected Obj, but got VT
		//IL_0133: Expected Obj, but got I4
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0b7d: Expected I, but got Obj
		//IL_0b93: Expected Obj, but got I
		//IL_0bc3: Expected I4, but got Obj
		//IL_018c: Expected I, but got Obj
		//IL_0228: Expected Obj, but got VT
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_01d9: Expected I, but got Obj
		//IL_05ae: Expected I, but got Obj
		//IL_05c4: Expected Obj, but got I
		//IL_0db3: Expected Obj, but got VT
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0def: Expected Obj, but got Unknown
		//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected Obj, but got Unknown
		//IL_0291: Expected I, but got Obj
		//IL_02a7: Expected Obj, but got I
		//IL_05ef: Expected I, but got Obj
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected Obj, but got Unknown
		//IL_0c1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c23: Expected Obj, but got Unknown
		//IL_063c: Expected I, but got Obj
		//IL_0652: Expected Obj, but got I
		//IL_1008: Expected I, but got Obj
		//IL_101e: Expected Obj, but got I
		//IL_02d2: Expected I, but got Obj
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected Obj, but got Unknown
		//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected Obj, but got Unknown
		//IL_0cf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfb: Expected Obj, but got Unknown
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected Obj, but got Unknown
		//IL_031f: Expected I, but got Obj
		//IL_0335: Expected Obj, but got I
		//IL_1049: Expected I, but got Obj
		//IL_105f: Expected Obj, but got I
		//IL_067d: Expected I, but got Obj
		//IL_043b: Expected I, but got Obj
		//IL_0c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7c: Expected Obj, but got Unknown
		//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8e: Expected Obj, but got Unknown
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected Obj, but got Unknown
		//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f55: Expected Obj, but got Unknown
		//IL_06ca: Expected I, but got Obj
		//IL_06e0: Expected Obj, but got I
		//IL_0488: Expected I, but got Obj
		//IL_049e: Expected Obj, but got I
		//IL_0360: Expected I, but got Obj
		//IL_07e6: Expected I, but got Obj
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected Obj, but got Unknown
		//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed7: Expected Obj, but got Unknown
		//IL_0d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Expected Obj, but got Unknown
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected Obj, but got Unknown
		//IL_03ad: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_0833: Expected I, but got Obj
		//IL_0849: Expected Obj, but got I
		//IL_070b: Expected I, but got Obj
		//IL_04c9: Expected I, but got Obj
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected Obj, but got Unknown
		//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc0: Expected Obj, but got Unknown
		//IL_0758: Expected I, but got Obj
		//IL_076e: Expected Obj, but got I
		//IL_0516: Expected I, but got Obj
		//IL_052c: Expected Obj, but got I
		//IL_03ee: Expected I, but got Obj
		//IL_0874: Expected I, but got Obj
		//IL_08c1: Expected I, but got Obj
		//IL_08d7: Expected Obj, but got I
		//IL_0799: Expected I, but got Obj
		//IL_0557: Expected I, but got Obj
		//IL_0902: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 56;
		obj = 0;
		object obj3 = obj2 + 32;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v353 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 208;
		object obj6 = obj2 + 200;
		object obj7 = obj2 + 16;
		object obj8 = obj2 + 192;
		object obj9 = obj2 + 184;
		object obj10 = obj2 + 176;
		object obj11 = obj2 + 168;
		object obj12 = obj2 + 160;
		object obj13 = obj2 + 152;
		object obj14 = obj2 + 144;
		object obj15 = obj2 + 136;
		object obj16 = obj2 + 128;
		object obj17 = obj2 + 120;
		object obj18 = obj2 + 112;
		object obj19 = obj2 + 104;
		object obj20 = obj2 + 96;
		object obj21 = obj2 + 88;
		object obj22 = obj2 + 80;
		object obj23 = obj2 + 72;
		object obj24 = obj2 - -64;
		object obj25 = obj2 + 48;
		object obj26 = obj2 + 40;
		object obj27 = obj2 + 24;
		object obj28 = obj2 + 8;
		DateTime defaultLocalFileTime = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
		DateTime defaultLocalFileTime2 = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
		DateTime defaultLocalFileTime3 = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		object obj29 = default;
		obj = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
		DateTime defaultLocalFileTime4 = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		object obj30 = default;
		obj = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC9B");
		object obj31 = default;
		if (obj31 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj32 = default;
		if (obj32 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750E");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3CD");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v93 (Il2CppClass<System.DateTime>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v349 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj34 = default;
		obj8 = obj34;
		obj9 = obj7;
		obj6 = obj8;
		obj5 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF2");
		object obj35 = default;
		obj3 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		nint num5 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v106 (Il2CppClass<HouseKeeper>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num6 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S0_v345 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool triggeredViaMysteryPowerup = default;
		ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_TOPRUN_ENDING").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_TOPRUN_ENDING_PERSONAL", triggeredViaMysteryPowerup);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		DateTime defaultLocalFileTime5 = File.DefaultLocalFileTime;
		object obj37 = default;
		obj10 = obj37;
		obj11 = defaultLocalFileTime5;
		obj6 = obj10;
		obj5 = obj11;
		object obj38 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj39 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		if (obj38 == obj39)
		{
			nint num7 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v249 (Il2CppClass<System.DateTime>)+BA]");
			object obj40 = (nint)0 & (nint)0x200;
			if (obj40 != null)
			{
				nint num8 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v341 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj41 = default;
			obj12 = obj41;
			obj13 = obj3;
			obj6 = obj12;
			obj5 = obj13;
			object obj42 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			object obj43 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj42) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj43))
			{
				nint num9 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v313 (Il2CppClass<System.DateTime>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num10 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ S0_v337 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj14 = obj3;
				object obj45 = default;
				obj15 = obj45;
				obj6 = obj14;
				obj5 = obj15;
				object obj46 = obj6 & 0x3FFFFFFFFFFFFFFFL;
				object obj47 = obj5 & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj46) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj47))
				{
					nint num11 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v326 (Il2CppClass<Strings>)+BA]");
					object obj48 = (nint)0 & (nint)0x200;
					if (obj48 != null)
					{
						nint num12 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S0_v333 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
					return;
				}
			}
			nint num13 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v265 (Il2CppClass<System.DateTime>)+BA]");
			object obj49 = (nint)0 & (nint)0x200;
			if (obj49 != null)
			{
				nint num14 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v306 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj16 = obj3;
			obj17 = obj41;
			obj6 = obj16;
			obj5 = obj17;
			object obj50 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			object obj51 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj50) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj51))
			{
				return;
			}
			nint num15 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ S0_v278 (Il2CppClass<System.DateTime>)+BA]");
			object obj52 = (nint)0 & (nint)0x200;
			if (obj52 != null)
			{
				nint num16 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ S0_v302 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj18 = obj41;
			obj19 = obj34;
			obj6 = obj18;
			obj5 = obj19;
			object obj53 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			object obj54 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj53) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54))
			{
				return;
			}
			nint num17 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S0_v291 (Il2CppClass<Strings>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			if (obj55 != null)
			{
				nint num18 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v298 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num19 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v128 (Il2CppClass<System.DateTime>)+BA]");
		object obj56 = (nint)0 & (nint)0x200;
		if (obj56 != null)
		{
			nint num20 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v242 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime defaultLocalFileTime6 = File.DefaultLocalFileTime;
		obj = defaultLocalFileTime6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		object obj57 = default;
		obj20 = obj57;
		object obj58 = default;
		obj21 = obj58;
		obj6 = obj20;
		obj5 = obj21;
		object obj59 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj60 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		if (obj59 != obj60)
		{
			return;
		}
		nint num21 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S0_v146 (Il2CppClass<System.DateTime>)+BA]");
		object obj61 = (nint)0 & (nint)0x200;
		if (obj61 != null)
		{
			nint num22 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v238 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj62 = default;
		obj22 = obj62;
		obj23 = obj3;
		obj6 = obj22;
		obj5 = obj23;
		object obj63 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj64 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj63) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj64))
		{
			nint num23 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S0_v210 (Il2CppClass<System.DateTime>)+BA]");
			object obj65 = (nint)0 & (nint)0x200;
			if (obj65 != null)
			{
				nint num24 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S0_v234 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj24 = obj3;
			object obj66 = default;
			obj25 = obj66;
			obj6 = obj24;
			obj5 = obj25;
			object obj67 = obj6 & 0x3FFFFFFFFFFFFFFFL;
			object obj68 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj67) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj68))
			{
				nint num25 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S0_v223 (Il2CppClass<Strings>)+BA]");
				object obj69 = (nint)0 & (nint)0x200;
				if (obj69 != null)
				{
					nint num26 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S0_v230 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
				return;
			}
		}
		nint num27 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ S0_v162 (Il2CppClass<System.DateTime>)+BA]");
		object obj70 = (nint)0 & (nint)0x200;
		if (obj70 != null)
		{
			nint num28 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v654 @ S0_v203 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj26 = obj3;
		obj27 = obj62;
		obj6 = obj26;
		obj5 = obj27;
		object obj71 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj72 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj72))
		{
			return;
		}
		nint num29 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ S0_v175 (Il2CppClass<System.DateTime>)+BA]");
		object obj73 = (nint)0 & (nint)0x200;
		if (obj73 != null)
		{
			nint num30 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S0_v199 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj28 = obj62;
		obj2 = obj34;
		obj6 = obj28;
		obj5 = obj2;
		object obj74 = obj6 & 0x3FFFFFFFFFFFFFFFL;
		object obj75 = obj5 & 0x3FFFFFFFFFFFFFFFL;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj74) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj75))
		{
			return;
		}
		nint num31 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S0_v188 (Il2CppClass<Strings>)+BA]");
		object obj76 = (nint)0 & (nint)0x200;
		if (obj76 != null)
		{
			nint num32 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S0_v195 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4 = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
	}

	private void ScheduleNotification(DateTime time, string title, string message)
	{
		//IL_000a: Expected Obj, but got VT
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		_headstartBrackets = (int[])time;
		object obj = this + 16;
		obj = title;
		object obj2 = this + 8;
		obj2 = message;
	}

	private unsafe string GetLocalNotificationMessage()
	{
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_022e: Expected Obj, but got I4
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_025c: Expected Obj, but got I4
		//IL_026a: Expected I, but got Obj
		//IL_0280: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got VT
		//IL_03fb: Expected Obj, but got VT
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected VT, but got Unknown
		//IL_02f2: Expected I8, but got Obj
		//IL_02ed: Expected native int or pointer, but got VT
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0375: Expected I8, but got Obj
		//IL_0370: Expected native int or pointer, but got VT
		//IL_038a: Expected Ref, but got VT
		//IL_0396: Expected Obj, but got I8
		//IL_0139: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I4
		//IL_0208: Expected Obj, but got F8
		//IL_01be: Expected Obj, but got I4
		//IL_01fb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		object obj3 = obj2 + 40;
		obj3 = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v81 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime lastQuitDate = UserSave.lastQuitDate;
		obj = lastQuitDate;
		DateTime today = CDateTime.Today;
		obj3 = today;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<System.DateTime>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v77 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 8;
		object obj8 = obj2 + 32;
		object obj9 = default;
		obj8 = obj9;
		object obj10 = obj2 + 16;
		object obj11 = default;
		obj10 = obj11;
		DateTime dateTime = (DateTime)(obj2 + 56);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj8;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 - -64);
		formatProvider = (IFormatProvider)obj10;
		long num5 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
		object obj12 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
		if (num5 > (long)obj12)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v51 (Il2CppClass<System.DateTime>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num7 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v73 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj7 = obj3;
			obj2 = obj;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj7;
			formatProvider = (IFormatProvider)obj2;
			long num8 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
			obj4 = num8;
			double num9 = (double)obj4 * 1.1574074074074074E-12;
			if (num9 != num9)
			{
				return (string)int.MinValue;
			}
			if (!(num9 < 2147483648.0))
			{
				return (string)int.MinValue;
			}
			if (!(num9 > -2147483649.0))
			{
				return (string)int.MinValue;
			}
			return (string)num9;
		}
		return null;
	}

	public static string FormatMessageWithNameIfPossible(string unidentifiedMessageID, string identifiedMessageID, object[] extraFormatArgs)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0205: Expected Obj, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		//IL_01b2: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = identifiedMessageID;
		obj2 = 0;
		object obj3 = extraFormatArgs + 16;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref identifiedMessageID))
		{
			object obj4 = extraFormatArgs + 12;
			object obj5 = 1;
			IFormatProvider formatProvider;
			IFormatProvider formatProvider2 = default;
			string text;
			string text2 = default;
			while (true)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
				{
					object obj6 = extraFormatArgs + 16;
					object obj7 = obj5 << 2;
					object obj8 = obj6 + obj7;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref identifiedMessageID))
					{
						object obj9 = obj5 + 1;
						obj5 = obj9;
						continue;
					}
					object obj10 = obj5 << 2;
					object obj11 = (object)extraFormatArgs + obj10;
					object obj12 = obj11 + 12;
					object obj13 = obj12 + 1;
					obj2 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					object obj14 = extraFormatArgs + 16;
					object obj15 = obj5 << 2;
					object obj16 = obj14 + obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					formatProvider = formatProvider2;
					text = text2;
					break;
				}
				formatProvider = (IFormatProvider)(object)string.Empty;
				text = string.Empty;
				break;
			}
			bool flag;
			if (formatProvider != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L0_v3 (System.IFormatProvider)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				object obj17 = obj4 << 2;
				object obj18 = (object)extraFormatArgs + obj17;
				object obj19 = obj18 + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
				string[] values = default;
				return string.ConcatArray(values, (int)"+");
			}
			return (string)((IConvertible)text).ToType((Type)(object)"-", formatProvider);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		string result = default;
		return result;
	}

	private static void MakeIOSNativeLog(string logMessage, string stackTrace, LogType type)
	{
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_01e8: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I4
		//IL_0094: Expected Obj, but got I4
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_0135: Expected Obj, but got I4
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Outfits>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v42 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Outfits.HasCharacter((Characters.CharacterId)stackTrace))
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (System.Boolean)+C]");
		if ((nint)0 <= (nint)0)
		{
			return;
		}
		object obj2 = 0;
		UserData userData = (UserData)1;
		while (true)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (System.Boolean)+C]");
			if ((nint)obj3 >= 0)
			{
				break;
			}
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v26 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((UserData)(object)stackTrace).StrictlyBetterThan(userData))
			{
				object obj5 = type + 1;
				string text = (string)obj5;
			}
			UserData userData2 = (UserData)(userData + 1);
			object obj6 = obj2 + 1;
			obj2 = obj6;
			userData = userData2;
		}
	}

	private void OnFriendsConsolidated(bool success)
	{
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_032e: Expected I, but got Obj
		//IL_0344: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I4
		//IL_038b: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I
		//IL_01c6: Expected I, but got Obj
		//IL_0213: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0260: Expected I, but got Obj
		//IL_02e3: Expected I, but got Obj
		//IL_02f9: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		if (success)
		{
			nint num = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v40 (Il2CppClass<Flurry>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v67 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			OnApplicationQuit();
			ScheduleDailyWordNotificationIfNecessary();
			((HouseKeeper)null).RegisterLocalNotificationStatus();
			nint num3 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v48 (Il2CppClass<Data.Save.SaveManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SaveManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v63 (Il2CppClass<Data.Save.SaveManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SaveManager.Load();
			nint num5 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v54 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v59 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CloudSave.OnProccessUnsuccessful();
			return;
		}
		bool isInitialized = ABTestManager.isInitialized;
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v10 (Il2CppClass<Flurry>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v35 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num9 = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v31 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		char newDailyLetter = WordHuntManager.GetNewDailyLetter();
		((WordHuntManager)newDailyLetter).DownloadDailyIfExpired();
		nint num11 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v22 (Il2CppClass<HouseKeeper>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v27 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HouseKeeper._002Ecctor();
	}

	private static void TriggerActionForFacebookPayout(bool isLoggedInToFacebook)
	{
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_050c: Expected Obj, but got I4
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_0538: Expected Obj, but got I8
		//IL_0541: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected Obj, but got Unknown
		//IL_000d: Expected Obj, but got VT
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got VT
		//IL_005f: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_0565: Expected Obj, but got VT
		//IL_057d: Expected I, but got Obj
		//IL_0593: Expected Obj, but got I
		//IL_05c3: Expected I4, but got Obj
		//IL_00a0: Expected I, but got Obj
		//IL_013a: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected Obj, but got Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected Obj, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected Obj, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected Obj, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0660: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected Obj, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_0474: Expected I, but got Obj
		//IL_048a: Expected Obj, but got I
		//IL_017b: Expected I, but got Obj
		//IL_04b5: Expected I, but got Obj
		//IL_01e1: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected Obj, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected Obj, but got Unknown
		//IL_0222: Expected I, but got Obj
		//IL_0288: Expected I, but got Obj
		//IL_029e: Expected Obj, but got I
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0750: Expected Obj, but got Unknown
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0762: Expected Obj, but got Unknown
		//IL_03c0: Expected Obj, but got I8
		//IL_02c9: Expected I, but got Obj
		//IL_03dd: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I
		//IL_032f: Expected I, but got Obj
		//IL_0345: Expected Obj, but got I
		//IL_041e: Expected I, but got Obj
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected Obj, but got Unknown
		//IL_0370: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		object obj3 = obj2 + 80;
		SlideInData instance = SlideInData.instance;
		long boardBundleStartTimestamp = ((BoardBundlePopupManager)(object)instance).GetBoardBundleStartTimestamp();
		obj3 = boardBundleStartTimestamp;
		object obj4 = obj2 + 16;
		DateTime utcNow = CDateTime.UtcNow;
		obj4 = utcNow;
		object obj5 = obj2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
		object obj6 = default;
		obj5 = obj6;
		object obj7 = obj2 + 56;
		DateTime utcNow2 = CDateTime.UtcNow;
		obj7 = utcNow2;
		nint num = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v19 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v170 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime welcomePackStartTime = UserSave.welcomePackStartTime;
		obj = welcomePackStartTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
		nint num3 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v28 (Il2CppClass<HouseKeeper>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num4 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v166 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool triggeredViaMysteryPowerup = default;
		ActivePowerup activePowerup = ((GameStats)(object)"LOCAL_NOTIFICATION_MESSAGE_DAILY_VIDEO").TriggerPowerup((UpgradeType)"LOCAL_NOTIFICATION_MESSAGE_DAILY_VIDEO_PERSONAL", triggeredViaMysteryPowerup);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v40 (Il2CppClass<System.DateTime>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v162 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj11 = obj2 + 72;
		object obj12 = obj2 + 48;
		object obj13 = obj2 + 40;
		object obj14 = obj2 + 24;
		object obj15 = obj2 + 8;
		object obj16 = obj2 + 96;
		object obj17 = default;
		obj16 = obj17;
		object obj18 = obj2 + 88;
		object obj19 = default;
		obj18 = obj19;
		object obj20 = obj2 + 104;
		obj20 = obj16;
		object obj21 = obj2 + 112;
		obj21 = obj18;
		object obj22 = obj20 & 0x3FFFFFFFFFFFFFFFL;
		object obj23 = obj21 & 0x3FFFFFFFFFFFFFFFL;
		if (obj22 != obj23)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
			nint num7 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v88 (Il2CppClass<System.DateTime>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num8 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v158 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj25 = default;
			obj11 = obj25;
			object obj26 = default;
			obj12 = obj26;
			obj20 = obj11;
			obj21 = obj12;
			object obj27 = obj20 & 0x3FFFFFFFFFFFFFFFL;
			object obj28 = obj21 & 0x3FFFFFFFFFFFFFFFL;
			if (obj27 != obj28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
				nint num9 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v105 (Il2CppClass<System.DateTime>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num10 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v154 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj30 = default;
				obj13 = obj30;
				object obj31 = default;
				obj14 = obj31;
				obj20 = obj13;
				obj21 = obj14;
				object obj32 = obj20 & 0x3FFFFFFFFFFFFFFFL;
				object obj33 = obj21 & 0x3FFFFFFFFFFFFFFFL;
				if (obj32 != obj33)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
					nint num11 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v138 (Il2CppClass<System.DateTime>)+BA]");
					object obj34 = (nint)0 & (nint)0x200;
					if (obj34 != null)
					{
						nint num12 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v150 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj35 = default;
					obj15 = obj35;
					object obj36 = default;
					obj2 = obj36;
					obj20 = obj15;
					obj21 = obj2;
					object obj37 = obj20 & 0x3FFFFFFFFFFFFFFFL;
					object obj38 = obj21 & 0x3FFFFFFFFFFFFFFFL;
					if (obj37 != obj38)
					{
						return;
					}
				}
				long num13 = RewardManager.GenerateRewardUid();
				obj4 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC99");
				nint num14 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v122 (Il2CppClass<Strings>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num15 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v129 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
				return;
			}
		}
		long num16 = RewardManager.GenerateRewardUid();
		nint num17 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v72 (Il2CppClass<Strings>)+BA]");
		object obj40 = (nint)0 & (nint)0x200;
		if (obj40 != null)
		{
			nint num18 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v79 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("LOCAL_NOTIFICATION_TITLE");
	}

	private static void QueueFacebookPayoutPopupIfNeeded(bool isLoggedInToFacebook)
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (delegateFacebookPayoutPopupAction != null)
		{
			delegateFacebookPayoutPopupAction(isLoggedInToFacebook);
		}
	}

	public static void SetFacebookPayoutAction(Action<bool> action)
	{
		//IL_0218: Expected I, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0264: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I4
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_013d: Expected I, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_01cb: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v53 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4;
		if (MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v39 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v49 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v44 (System.Boolean)+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v45+8]");
			bool flag = (nint)0 != 0;
			obj4 = (flag ? 1 : 0) ^ 1;
		}
		else
		{
			obj4 = 0;
		}
		object obj5 = action & 1;
		object obj6 = obj4 & obj5;
		if (obj6 == null)
		{
			return;
		}
		nint num5 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v16 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v33 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UserSave.allAssetBundlesDownloaded)
		{
			return;
		}
		nint num7 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num8 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController._002Ecctor();
	}

	public static void SetFacebookPayoutActionToDefault()
	{
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0221: Expected Obj, but got I4
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_027f: Expected I, but got Obj
		//IL_0295: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_02c5: Expected I, but got Obj
		//IL_02db: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v61 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_onlineServicesInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v57 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78F0");
		((Request)6).timeout = 2419200f;
		nint num5 = (nint)typeof(KilooWebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(KilooWebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v53 (Il2CppClass<Kiloo.Common.Backend.KilooWebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KilooWebClient.AddTags((string[])(object)"subway_surfers");
		TopRunRoot.ClearSavedData();
		nint num7 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v31 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v49 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		OnlineSettingsManager.DownloadNow();
		nint num9 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v37 (Il2CppClass<HouseKeeper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v43 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_onlineServicesInitialized = true;
	}

	public static void SaveAudioOptionsBeforeVideoAds(bool sfxEnabled, bool musicEnabled)
	{
		//IL_01af: Expected I, but got Obj
		//IL_01c5: Expected Obj, but got I
		//IL_027d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_021a: Expected I, but got Obj
		//IL_0230: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02b1: Expected I, but got Obj
		//IL_02c7: Expected Obj, but got I
		//IL_01f9: Expected Obj, but got I4
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected I4, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I4
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v52 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		bool flag = ((SocialManager)facebookDialogsSupported).HasFacebookAccessToken();
		bool flag2;
		if (flag)
		{
			nint num3 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v40 (Il2CppClass<Data.Save.UserSave>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UserSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v48 (Il2CppClass<Data.Save.UserSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool allAssetBundlesDownloaded = UserSave.allAssetBundlesDownloaded;
			object obj3 = (allAssetBundlesDownloaded ? 1 : 0) ^ 1;
			flag2 = (byte)(obj3 & 1) != 0;
		}
		else
		{
			flag2 = false;
		}
		nint num5 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v34 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		QueueFacebookPayoutPopupIfNeeded(flag);
		nint num7 = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v21 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v30 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SaveManager.Load();
		if (flag2)
		{
			((SocialManager)facebookDialogsSupported).pausePhotoDownloading = flag2;
		}
		((HouseKeeper)null).RegisterAllBundlesDownloaded();
	}

	public static void DeleteSoundOptionBeforeVideoAds()
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_009d: Expected Obj, but got I4
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_00de: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		nint num2 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num3 = (nint)typeof(HouseKeeper);
		if (!flag)
		{
			nint num4 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v22 (Il2CppClass<HouseKeeper>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num3 = (nint)typeof(HouseKeeper);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num3 = (nint)typeof(HouseKeeper);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v3 (Il2CppClass<HouseKeeper>)+5C]");
		object obj4 = (nint)0 + (nint)12;
		obj4 = obj2;
	}

	public unsafe static void TryRestoreSoundOptionAfterLostFocusIfNeeded()
	{
		if (((LODParameters*)"sfxBeforeLostFocus")->GetHashCode() != 0)
		{
			((PropertyAttribute)(object)"sfxBeforeLostFocus")._002Ector();
		}
		if (((LODParameters*)"musicBeforeLostFocus")->GetHashCode() != 0)
		{
			((PropertyAttribute)(object)"musicBeforeLostFocus")._002Ector();
		}
	}

	private void VerifyCharactersAndBoardsAmount()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<HouseKeeper>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(HouseKeeper);
		if (!flag)
		{
			nint num3 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<HouseKeeper>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(HouseKeeper);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(HouseKeeper);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<HouseKeeper>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = this;
	}

	public unsafe static void RefreshOnlineSettingsAndInappsIfNeeded()
	{
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_0014: Expected Obj, but got I4
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_00e0: Expected Obj, but got I4
		//IL_00f2: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_01c1: Expected I, but got Obj
		//IL_0067: Expected I, but got Obj
		//IL_0133: Expected I, but got Obj
		if (((LODParameters*)"sfxBeforeLostFocus")->GetHashCode() != 0)
		{
			string text = PlayerPrefs.GetString("sfxBeforeLostFocus", (string)1);
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v21 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v27 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool optionMusic = text != null;
			Settings.optionMusic = optionMusic;
		}
		if (((LODParameters*)"musicBeforeLostFocus")->GetHashCode() != 0)
		{
			string text2 = PlayerPrefs.GetString("musicBeforeLostFocus", (string)1);
			nint num3 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v9 (Il2CppClass<Info.Settings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v15 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool optionTopRunChallengers = text2 != null;
			Settings.optionTopRunChallengers = optionTopRunChallengers;
		}
		nint num5 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v14 (Il2CppClass<HouseKeeper>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		TryRestoreSoundOptionAfterLostFocusIfNeeded();
	}

	private void OnOpenedThroughNotification(Notification notification)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		string value = (string)(this & 1);
		PlayerPrefs.SetString("sfxBeforeLostFocus", value);
		string value2 = (string)(notification & 1);
		PlayerPrefs.SetString("musicBeforeLostFocus", value2);
	}

	private void LogApplicationWasLaunchedFromNotification(string message, string type = "", string jobID = "")
	{
	}

	private unsafe static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_00ec: Expected I4, but got Obj
		//IL_001b: Expected Obj, but got I
		//IL_0150: Expected I4, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ L1 (System.String)+10]");
		int missionIndexInSet = default;
		int missionSet;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ L1 (System.String)+10]");
			object obj = ((Dictionary<string, object>)0).get_Item("type");
			string text2;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ L1 (System.String)+10]");
				object obj2 = ((Dictionary<string, object>)0).get_Item("type");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				string text = default;
				if (text != "job")
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ L1 (System.String)+10]");
					object obj3 = ((Dictionary<string, object>)0).get_Item("jobid");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				}
				else
				{
					missionIndexInSet = 0;
				}
				text2 = text;
			}
			else
			{
				text2 = "";
				missionIndexInSet = 0;
			}
			missionSet = (int)text2;
		}
		else
		{
			missionSet = (int)"";
			missionIndexInSet = 0;
		}
		*(MissionIndicator*)null = new MissionIndicator(((string)(object)context).m_firstChar, missionSet, missionIndexInSet);
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	unsafe static HouseKeeper()
	{
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected I4, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_06f2: Expected Obj, but got F4
		//IL_0700: Expected I, but got Obj
		//IL_0716: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0762: Expected I, but got Obj
		//IL_0778: Expected Obj, but got I
		//IL_013a: Invalid comparison between Obj and F4
		//IL_0161: Expected F4, but got Obj
		//IL_0523: Expected I, but got Obj
		//IL_0539: Expected Obj, but got I
		//IL_0243: Expected I, but got Obj
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_0299: Expected I, but got Obj
		//IL_02af: Expected Obj, but got I
		//IL_0178: Expected Obj, but got F4
		//IL_0564: Expected I, but got Obj
		//IL_0800: Expected I, but got Obj
		//IL_0816: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		//IL_05b1: Expected I, but got Obj
		//IL_05c7: Expected Obj, but got I
		//IL_02da: Expected I, but got Obj
		//IL_0402: Expected I, but got Obj
		//IL_0418: Expected Obj, but got I
		//IL_0327: Expected I, but got Obj
		//IL_01e8: Expected I, but got Obj
		//IL_05f2: Expected I, but got Obj
		//IL_0374: Expected I, but got Obj
		//IL_038a: Expected Obj, but got I
		//IL_063f: Expected I, but got Obj
		//IL_0655: Expected Obj, but got I
		//IL_0443: Expected I, but got Obj
		//IL_0490: Expected I, but got Obj
		//IL_04a6: Expected Obj, but got I
		//IL_03b5: Expected I, but got Obj
		//IL_0680: Expected I, but got Obj
		//IL_04d1: Expected I, but got Obj
		object obj = default;
		bool flag = (byte)(obj + 8) != 0;
		((bool*)(flag ? 1 : 0))->m_value = false;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 4);
		formatProvider = (IFormatProvider)0f;
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v146 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		float num5;
		if (((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)"refreshinterval", flag))
		{
			if (!(((bool*)(flag ? 1 : 0))->m_value ? ((float*)1) : ((float*)null))->System_002EIConvertible_002EToBoolean(formatProvider))
			{
				string text = string.ConcatArray((string[])(object)"Failed to parse Onlinesettings refresh interval from: ", ((bool*)(flag ? 1 : 0))->m_value ? 1 : 0);
				nint num3 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v60 (Il2CppClass<HouseKeeper>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v65 (Il2CppClass<HouseKeeper>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				num5 = 3600f;
			}
			else
			{
				bool flag2 = System.Runtime.CompilerServices.Unsafe.As<IFormatProvider, UIntPtr>(ref formatProvider) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)10f);
				bool flag3 = !flag2;
				bool flag4 = !flag3;
				num5 = (float)formatProvider;
				if (!flag4)
				{
					obj = 3600f;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					string text3 = default;
					string text2 = "OnlineSettings refresh interval too small: " + text3;
					nint num6 = (nint)typeof(HouseKeeper);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v48 (Il2CppClass<HouseKeeper>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num7 = (nint)typeof(HouseKeeper);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v53 (Il2CppClass<HouseKeeper>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
					num5 = 3600f;
				}
			}
		}
		else
		{
			num5 = 3600f;
		}
		float maxDelay = NetworkServer.maxDelay;
		nint num8 = (nint)typeof(HouseKeeper);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v12 (Il2CppClass<HouseKeeper>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v35 (Il2CppClass<HouseKeeper>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num10 = _onlineSettingsLastDownloadTime + num5;
		if (maxDelay > num10)
		{
			float maxDelay2 = NetworkServer.maxDelay;
			nint num11 = (nint)typeof(HouseKeeper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v64 (Il2CppClass<HouseKeeper>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(HouseKeeper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v118 (Il2CppClass<HouseKeeper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			_onlineSettingsLastDownloadTime = maxDelay2;
			nint num13 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v71 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v114 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath2 = OnlineSettings.GetSaveDataPath();
			if (saveDataPath2.m_firstChar == '\0')
			{
				nint num15 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v104 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num16 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v110 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath3 = OnlineSettings.GetSaveDataPath();
				((OnlineSettings)(object)saveDataPath3).LoadFromFile();
			}
			nint num17 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v81 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v99 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			InAppManager instance = InAppManager.instance;
			if ((object)instance == null)
			{
				return;
			}
			nint num19 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v89 (Il2CppClass<InApp.InAppManager>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(InAppManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v95 (Il2CppClass<InApp.InAppManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
			((InAppManager)(object)activeInAppOffers).PlayPurchaseSucessSound();
			return;
		}
		nint num21 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v27 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num22 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v57 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		InAppManager instance2 = InAppManager.instance;
		if ((object)instance2 == null)
		{
			return;
		}
		nint num23 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v34 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num24 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v53 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers2 = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v39 (System.Collections.Generic.Dictionary`2<System.String, InApp.InAppItemModel>)+38]");
		if ((nint)0 != 0)
		{
			return;
		}
		nint num25 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v43 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num26 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v49 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, InAppItemModel> activeInAppOffers3 = InAppManager.GetActiveInAppOffers();
		((InAppManager)(object)activeInAppOffers3).PlayPurchaseSucessSound();
	}
}
