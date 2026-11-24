using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using SYBO.Subway.Promotion;
using TopRun.Internal;
using UnityEngine;

namespace UI.Screens;

public class PromotionManager
{
	private sealed class _003CStartTimer_003Ed__22(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PromotionManager _003C_003E4__this;

		public long endTime;

		private long _003CcurrentTime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0048: Expected I8, but got VT
				//IL_00e1: Expected I, but got Obj
				//IL_00f7: Expected Obj, but got I
				//IL_00a6: Expected I8, but got VT
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Expected Obj, but got Unknown
				//IL_00ba: Expected Obj, but got I4
				//IL_00ce: Expected Obj, but got I4
				//IL_0122: Expected I, but got Obj
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
					DateTime randomisedPlayerIdExpiry = ((Manager)null).GetRandomisedPlayerIdExpiry();
					_003CcurrentTime_003E5__2 = (long)randomisedPlayerIdExpiry;
				}
				if (_003CcurrentTime_003E5__2 < endTime)
				{
					DateTime randomisedPlayerIdExpiry2 = ((Manager)null).GetRandomisedPlayerIdExpiry();
					_003CcurrentTime_003E5__2 = (long)randomisedPlayerIdExpiry2;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v15 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(PromotionManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TransformExtensions.Reset((Transform)(object)PromotionManager.m_onPromotionStartedHandler);
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

	private sealed class _003CExpireTimer_003Ed__23(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public PromotionManager _003C_003E4__this;

		public long endTime;

		private long _003CcurrentTime_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0048: Expected I8, but got VT
				//IL_00e1: Expected I, but got Obj
				//IL_00f7: Expected Obj, but got I
				//IL_00a6: Expected I8, but got VT
				//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b1: Expected Obj, but got Unknown
				//IL_00ba: Expected Obj, but got I4
				//IL_00ce: Expected Obj, but got I4
				//IL_0122: Expected I, but got Obj
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
					DateTime randomisedPlayerIdExpiry = ((Manager)null).GetRandomisedPlayerIdExpiry();
					_003CcurrentTime_003E5__2 = (long)randomisedPlayerIdExpiry;
				}
				if (_003CcurrentTime_003E5__2 < endTime)
				{
					DateTime randomisedPlayerIdExpiry2 = ((Manager)null).GetRandomisedPlayerIdExpiry();
					_003CcurrentTime_003E5__2 = (long)randomisedPlayerIdExpiry2;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v15 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(PromotionManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v23 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TransformExtensions.Reset((Transform)(object)PromotionManager.m_onPromotionExpiredHandler);
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

	private const string PromotionFolder = "Promotions";

	private static Action m_onPromotionStartedHandler;

	private static Action m_onPromotionExpiredHandler;

	private IEnumerator _startTimerCoroutine;

	private IEnumerator _endTimerCoroutine;

	private bool promotionsLoaded;

	private PromotionDefinition currentPromotion;

	private static PromotionManager instance;

	public static PromotionManager Instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(LeaderboardScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LeaderboardScreenManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UI.Screens.LeaderboardScreenManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = LeaderboardScreenManager._instance != null;
			return (PromotionManager)flag;
		}
	}

	public bool IsCurrentPromotionActive
	{
		get
		{
			//IL_0037: Expected I4, but got Obj
			if (~(promotionsLoaded ? 1u : 0u) != 0)
			{
				OnPopupClosed(null);
			}
			return (byte)(int)currentPromotion != 0;
		}
	}

	public static event Action onPromotionStartedHandler
	{
		add
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			object obj = value + 124;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			obj = obj2;
			_ = 1f;
			_ = 0.1f;
			object obj3 = value + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj4 = default;
			obj3 = obj4;
			object obj5 = value + 196;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj6 = default;
			obj5 = obj6;
			((UpgradeScreen)(object)value).Start();
		}
		remove
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = PromotionManager.m_onPromotionStartedHandler;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(PromotionManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)PromotionManager.m_onPromotionStartedHandler == obj2)
				{
					PromotionManager.m_onPromotionStartedHandler = action;
				}
				if ((object)PromotionManager.m_onPromotionStartedHandler != obj2)
				{
					obj2 = PromotionManager.m_onPromotionStartedHandler;
					continue;
				}
				break;
			}
		}
	}

	public static event Action onPromotionExpiredHandler
	{
		add
		{
			//IL_00ca: Expected I, but got Obj
			//IL_00e0: Expected Obj, but got I
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = PromotionManager.m_onPromotionStartedHandler;
			Action action = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(PromotionManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((object)PromotionManager.m_onPromotionStartedHandler == obj2)
				{
					PromotionManager.m_onPromotionStartedHandler = action;
				}
				if ((object)PromotionManager.m_onPromotionStartedHandler != obj2)
				{
					obj2 = PromotionManager.m_onPromotionStartedHandler;
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
			nint num = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = PromotionManager.m_onPromotionExpiredHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(PromotionManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(PromotionManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(PromotionManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(PromotionManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.PromotionManager>)+5C]");
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

	private PromotionManager()
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
		nint num = (nint)typeof(PromotionManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = PromotionManager.m_onPromotionExpiredHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(PromotionManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<UI.Screens.PromotionManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(PromotionManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(PromotionManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<UI.Screens.PromotionManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(PromotionManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(PromotionManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<UI.Screens.PromotionManager>)+5C]");
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

	public PromotionDefinition TryGetCurrentPromotion()
	{
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_00f1: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_0094: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PromotionManager)+B0]");
		if ((UnityEngine.Object)0 != null)
		{
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Screens.PromotionManager)+B0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v10+14]");
		bool flag = (nint)0 != 0;
		return (PromotionDefinition)((flag ? 1 : 0) ^ 1);
	}

	public void LoadPromotion(bool forceReload = false)
	{
		if (!forceReload)
		{
			((PauseScreen)this).RefreshTopRun();
		}
	}

	public unsafe T TryGetCurrentPromotion<T>() where T : PromotionDefinition
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_0630: Expected Obj, but got I4
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected I, but got Unknown
		//IL_0671: Expected Obj, but got I
		//IL_068c: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01d3: Expected Obj, but got I4
		//IL_06c2: Expected I, but got Obj
		//IL_06d6: Expected Obj, but got I
		//IL_070b: Expected Obj, but got I
		//IL_0714: Expected Obj, but got I4
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_036e: Expected Obj, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I
		//IL_0319: Expected Obj, but got I
		//IL_03be: Expected Obj, but got I
		//IL_0099: Expected I, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_07fa: Expected I, but got Obj
		//IL_0810: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_0768: Expected Obj, but got I
		//IL_0775: Expected I, but got Obj
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_00da: Expected I, but got Obj
		//IL_052f: Expected I, but got Obj
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = obj;
		_ = -1;
		nint num = (nint)(obj2 + 40);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = (object)((IntPtr*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (System.IntPtr)+8]");
		_ = 0;
		nint num2 = default;
		object obj6 = num2 + 24;
		object obj7 = default;
		object obj11 = default;
		T result = default;
		T val = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj8 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v162 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v179 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj11 != null)
				{
					object obj12 = obj5 + 4;
					object obj13 = obj12 + 1;
					obj12 = obj13;
					object obj14 = obj13 << 2;
					object obj15 = obj5 + obj14;
					obj15 = 119;
					result = val;
					break;
				}
				continue;
			}
			object obj16 = obj5 + 4;
			object obj17 = obj16 + 1;
			obj16 = obj17;
			object obj18 = obj17 << 2;
			object obj19 = obj5 + obj18;
			obj19 = 75;
			break;
		}
		((IntPtr*)num)->m_value = (void*)(nint)typeof(List<UI.SlideIns.UISlideIn>.Enumerator);
		_ = -1;
		object obj20 = num + 8;
		obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		void* value = ((IntPtr*)num)->m_value;
		object obj21 = (object)((byte*)((IntPtr*)num)->m_value + 88);
		object obj22 = 0;
		object obj34 = default;
		while (true)
		{
			object obj23 = obj22 & 0xFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v40 (System.Void*)+B2]");
			if ((nint)obj23 < 0)
			{
				object obj24 = obj22 + 1;
				object obj25 = obj24 << 16;
				object obj26 = obj25 >> 16;
				object obj27 = obj22 & 0xFFFF;
				object obj28 = obj27 << 3;
				object obj29 = obj21 + obj28;
				if (obj29 != typeof(IDisposable))
				{
					obj22 = obj26;
					continue;
				}
				object obj30 = (object)((byte*)((IntPtr*)num)->m_value + 188);
				object obj31 = obj27 << 3;
				object obj32 = obj21 + obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S2_v41+4]");
				object obj33 = (nint)0 << 3;
				obj34 = obj30 + obj33;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11C74");
			break;
		}
		object obj35 = obj34 & 0x3FFF;
		object obj36 = obj35 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v303 @ S2_v15 (should have been resolved before IL gen)");
		object obj37 = num + 8;
		obj3 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S1_v41+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj38 = (nint)0 << 2;
			object obj39 = obj5 + obj38;
			if ((nint)obj39 == 119)
			{
				object obj40 = obj5 + 4;
				if ((nint)obj40 > -1)
				{
					object obj41 = obj40 + -1;
					obj40 = obj41;
				}
				return result;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj42 = (nint)0 << 2;
			object obj43 = obj5 + obj42;
			if ((nint)obj43 == 75)
			{
				object obj44 = obj5 + 4;
				if ((nint)obj44 > -1)
				{
					object obj45 = obj44 + -1;
					obj44 = obj45;
				}
				goto IL_07da;
			}
		}
		object obj46 = default;
		if (obj46 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_07da;
		IL_07da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj47 = obj6;
		nint num5 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v66 (Il2CppClass<System.Type>)+BA]");
		object obj48 = (nint)0 & (nint)0x200;
		if (obj48 != null)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v81 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v63+4]");
		obj2 = 0;
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num);
		throw new ArrayTypeMismatchException();
	}

	private void OnPopupClosed(string window)
	{
		//IL_0139: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_0032: Expected VT, but got Obj
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0081: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		bool flag = promotionsLoaded;
		object obj = (flag ? 1 : 0) ^ 1;
		object obj2 = obj | (object)window;
		if (obj2 == null)
		{
			return;
		}
		promotionsLoaded = false;
		object obj3 = this + 20;
		obj3 = 0;
		_0021_00210 val = (_0021_00210)Resources.GetBuiltinResource<T>("Promotions");
		object obj4 = val + 12;
		if (obj4 == null)
		{
			promotionsLoaded = true;
			return;
		}
		object obj5 = 0;
		object obj6 = obj4;
		object obj12 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj7 = val + 16;
			object obj8 = obj5 << 2;
			object obj9 = obj7 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v30+C]");
			if ((nint)0 == 0)
			{
				object obj10 = obj5 + 1;
				obj5 = obj10;
				obj6 = obj4;
				continue;
			}
			object obj11 = this + 20;
			obj11 = obj12;
			break;
		}
		promotionsLoaded = true;
	}

	public unsafe void OnPromotionPurchaseFailed()
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(PromotionManager.StartTimer);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
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
		((RunStartScreen)this).StartRun();
	}

	public void OnPromotionPurchaseSuccess()
	{
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		bool isCurrentPromotionActive = IsCurrentPromotionActive;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)isCurrentPromotionActive != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void StartTimer()
	{
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		bool isCurrentPromotionActive = IsCurrentPromotionActive;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)isCurrentPromotionActive != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private IEnumerator StartTimer(long endTime)
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

	private IEnumerator ExpireTimer(long endTime)
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

	private long GetCurrentTimestamp()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got VT
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		DateTime utcNow = CDateTime.UtcNow;
		nint num = (nint)typeof(TimeUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(TimeUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v20 (Il2CppClass<Kiloo.Common.Utility.TimeUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = utcNow;
		string text = (string)(obj2 + 8);
		text = (string)obj2;
		return TimeUtility.RFC1123StringToUnixTime(text);
	}

	unsafe static PromotionManager()
	{
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_068f: Expected Obj, but got I4
		//IL_069e: Expected Obj, but got F4
		//IL_06b8: Expected I, but got Obj
		//IL_06ce: Expected Obj, but got I
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected VT, but got Unknown
		//IL_0706: Expected F4, but got Obj
		//IL_0701: Expected native int or pointer, but got VT
		//IL_071b: Expected F4, but got I
		//IL_0716: Expected native int or pointer, but got VT
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected Obj, but got Unknown
		//IL_0749: Expected I, but got Obj
		//IL_0766: Expected F4, but got Obj
		//IL_0761: Expected native int or pointer, but got VT
		//IL_077b: Expected F4, but got I
		//IL_0776: Expected native int or pointer, but got VT
		//IL_0789: Expected VT, but got F4
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a1: Expected Obj, but got Unknown
		//IL_07aa: Expected Obj, but got I4
		//IL_07b9: Expected Obj, but got F4
		//IL_07d3: Expected I, but got Obj
		//IL_07e0: Expected F4, but got Obj
		//IL_07db: Expected native int or pointer, but got VT
		//IL_07f5: Expected F4, but got I
		//IL_07f0: Expected native int or pointer, but got VT
		//IL_080b: Expected Obj, but got I
		//IL_0818: Expected Obj, but got F4
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0839: Expected Obj, but got I4
		//IL_0848: Expected Obj, but got F4
		//IL_0861: Expected F4, but got Obj
		//IL_085c: Expected native int or pointer, but got VT
		//IL_0876: Expected F4, but got I
		//IL_0871: Expected native int or pointer, but got VT
		//IL_087f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected Obj, but got Unknown
		//IL_08a4: Expected I, but got Obj
		//IL_08b1: Expected F4, but got Obj
		//IL_08ac: Expected native int or pointer, but got VT
		//IL_08c6: Expected F4, but got I
		//IL_08c1: Expected native int or pointer, but got VT
		//IL_08dc: Expected Obj, but got I
		//IL_08e9: Expected Obj, but got F4
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I4
		//IL_0919: Expected Obj, but got F4
		//IL_0932: Expected F4, but got Obj
		//IL_092d: Expected native int or pointer, but got VT
		//IL_0947: Expected F4, but got I
		//IL_0942: Expected native int or pointer, but got VT
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_006d: Expected F4, but got Obj
		//IL_0068: Expected native int or pointer, but got VT
		//IL_0082: Expected F4, but got I
		//IL_007d: Expected native int or pointer, but got VT
		//IL_0098: Expected Obj, but got I
		//IL_00a5: Expected Obj, but got F4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I4
		//IL_00d5: Expected Obj, but got F4
		//IL_00ef: Expected I, but got Obj
		//IL_00fc: Expected F4, but got Obj
		//IL_00f7: Expected native int or pointer, but got VT
		//IL_0111: Expected F4, but got I
		//IL_010c: Expected native int or pointer, but got VT
		//IL_0127: Expected Obj, but got I
		//IL_0134: Expected Obj, but got F4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I4
		//IL_0164: Expected Obj, but got F4
		//IL_017d: Expected F4, but got Obj
		//IL_0178: Expected native int or pointer, but got VT
		//IL_0192: Expected F4, but got I
		//IL_018d: Expected native int or pointer, but got VT
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01c0: Expected I, but got Obj
		//IL_01cd: Expected F4, but got Obj
		//IL_01c8: Expected native int or pointer, but got VT
		//IL_01e2: Expected F4, but got I
		//IL_01dd: Expected native int or pointer, but got VT
		//IL_01f8: Expected Obj, but got I
		//IL_0205: Expected Obj, but got F4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected Obj, but got Unknown
		//IL_0226: Expected Obj, but got I4
		//IL_0235: Expected Obj, but got F4
		//IL_024e: Expected F4, but got Obj
		//IL_0249: Expected native int or pointer, but got VT
		//IL_0263: Expected F4, but got I
		//IL_025e: Expected native int or pointer, but got VT
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0296: Expected I, but got Obj
		//IL_02a3: Expected F4, but got Obj
		//IL_029e: Expected native int or pointer, but got VT
		//IL_02b8: Expected F4, but got I
		//IL_02b3: Expected native int or pointer, but got VT
		//IL_02ce: Expected Obj, but got I
		//IL_02db: Expected Obj, but got F4
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_02fc: Expected Obj, but got I4
		//IL_030b: Expected Obj, but got F4
		//IL_0325: Expected I, but got Obj
		//IL_0332: Expected F4, but got Obj
		//IL_032d: Expected native int or pointer, but got VT
		//IL_0347: Expected F4, but got I
		//IL_0342: Expected native int or pointer, but got VT
		//IL_035d: Expected Obj, but got I
		//IL_036a: Expected Obj, but got F4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_038b: Expected Obj, but got I4
		//IL_039a: Expected Obj, but got F4
		//IL_03b3: Expected F4, but got Obj
		//IL_03ae: Expected native int or pointer, but got VT
		//IL_03c8: Expected F4, but got I
		//IL_03c3: Expected native int or pointer, but got VT
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_03f6: Expected I, but got Obj
		//IL_0403: Expected F4, but got Obj
		//IL_03fe: Expected native int or pointer, but got VT
		//IL_0418: Expected F4, but got I
		//IL_0413: Expected native int or pointer, but got VT
		//IL_042e: Expected Obj, but got I
		//IL_043b: Expected Obj, but got F4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected Obj, but got Unknown
		//IL_045c: Expected Obj, but got I4
		//IL_046b: Expected Obj, but got F4
		//IL_0484: Expected F4, but got Obj
		//IL_047f: Expected native int or pointer, but got VT
		//IL_0499: Expected F4, but got I
		//IL_0494: Expected native int or pointer, but got VT
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected Obj, but got Unknown
		//IL_04cc: Expected I, but got Obj
		//IL_04d9: Expected F4, but got Obj
		//IL_04d4: Expected native int or pointer, but got VT
		//IL_04ee: Expected F4, but got I
		//IL_04e9: Expected native int or pointer, but got VT
		//IL_0504: Expected Obj, but got I
		//IL_0511: Expected Obj, but got F4
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0529: Expected Obj, but got Unknown
		//IL_0532: Expected Obj, but got I4
		//IL_0541: Expected Obj, but got F4
		//IL_055b: Expected I, but got Obj
		//IL_0568: Expected F4, but got Obj
		//IL_0563: Expected native int or pointer, but got VT
		//IL_057d: Expected F4, but got I
		//IL_0578: Expected native int or pointer, but got VT
		//IL_0593: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got F4
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05c1: Expected Obj, but got I4
		//IL_05d0: Expected Obj, but got F4
		//IL_05e9: Expected F4, but got Obj
		//IL_05e4: Expected native int or pointer, but got VT
		//IL_05fe: Expected F4, but got I
		//IL_05f9: Expected native int or pointer, but got VT
		//IL_061e: Expected I, but got Obj
		//IL_062b: Expected F4, but got Obj
		//IL_0626: Expected native int or pointer, but got VT
		//IL_0640: Expected F4, but got I
		//IL_063b: Expected native int or pointer, but got VT
		//IL_0656: Expected Obj, but got I
		//IL_0663: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 228;
		obj = 0;
		_ = 0;
		obj = -50f;
		_ = 30f;
		_ = 0f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v183 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 240);
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj4 = obj2 + 216;
		Vector3 vector3 = vector / 0.75f;
		nint num3 = (nint)typeof(PauseScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v25 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		nint num4 = 0;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v23+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		PauseScreen.DIAMOND_POSITION = (Vector3)vector.x;
		_ = vector.z;
		object obj5 = obj2 + 204;
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = -180f;
		_ = -15f;
		nint num5 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v32+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v38 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj6 = (nint)0 + (nint)12;
		obj6 = vector.x;
		_ = vector.z;
		object obj7 = obj2 + 192;
		obj7 = 0;
		_ = 0;
		obj7 = 13.8f;
		_ = 13.8f;
		_ = 13.8f;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v43+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		object obj8 = obj2 + 180;
		Vector3 vector7 = vector / 0.75f;
		nint num6 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v51+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v53 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj9 = (nint)0 + (nint)24;
		obj9 = vector.x;
		_ = vector.z;
		object obj10 = obj2 + 168;
		obj10 = 0;
		_ = 0;
		obj10 = 2f;
		_ = 32f;
		_ = 12f;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector9 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v58+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		object obj11 = obj2 + 156;
		Vector3 vector10 = vector / 0.75f;
		nint num7 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj11;
		Vector3 vector11 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v66+8]");
		((Vector3*)(nint)vector11)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v68 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj12 = (nint)0 + (nint)36;
		obj12 = vector.x;
		_ = vector.z;
		object obj13 = obj2 + 144;
		obj13 = 0;
		_ = 0;
		obj13 = 0f;
		_ = 180f;
		_ = 13f;
		nint num8 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj13;
		Vector3 vector12 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v73+8]");
		((Vector3*)(nint)vector12)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v79 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj14 = (nint)0 + (nint)48;
		obj14 = vector.x;
		_ = vector.z;
		object obj15 = obj2 + 132;
		obj15 = 0;
		_ = 0;
		obj15 = 11f;
		_ = 11f;
		_ = 11f;
		((Vector3*)(nint)vector)->x = (float)obj15;
		Vector3 vector13 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v84+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		object obj16 = obj2 + 120;
		Vector3 vector14 = vector / 0.75f;
		nint num9 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj16;
		Vector3 vector15 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v92+8]");
		((Vector3*)(nint)vector15)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v94 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj17 = (nint)0 + (nint)60;
		obj17 = vector.x;
		_ = vector.z;
		object obj18 = obj2 + 108;
		obj18 = 0;
		_ = 0;
		obj18 = 44f;
		_ = 20f;
		_ = 24f;
		((Vector3*)(nint)vector)->x = (float)obj18;
		Vector3 vector16 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S0_v99+8]");
		((Vector3*)(nint)vector16)->z = 0f;
		object obj19 = obj2 + 96;
		Vector3 vector17 = vector / 0.75f;
		nint num10 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj19;
		Vector3 vector18 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v107+8]");
		((Vector3*)(nint)vector18)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v109 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj20 = (nint)0 + (nint)72;
		obj20 = vector.x;
		_ = vector.z;
		object obj21 = obj2 + 84;
		obj21 = 0;
		_ = 0;
		obj21 = 0f;
		_ = 180f;
		_ = 22f;
		nint num11 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj21;
		Vector3 vector19 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v114+8]");
		((Vector3*)(nint)vector19)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v120 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj22 = (nint)0 + (nint)84;
		obj22 = vector.x;
		_ = vector.z;
		object obj23 = obj2 + 72;
		obj23 = 0;
		_ = 0;
		obj23 = 9.5f;
		_ = 9.5f;
		_ = 9.5f;
		((Vector3*)(nint)vector)->x = (float)obj23;
		Vector3 vector20 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S0_v125+8]");
		((Vector3*)(nint)vector20)->z = 0f;
		object obj24 = obj2 + 60;
		Vector3 vector21 = vector / 0.75f;
		nint num12 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj24;
		Vector3 vector22 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v133+8]");
		((Vector3*)(nint)vector22)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S0_v135 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj25 = (nint)0 + (nint)96;
		obj25 = vector.x;
		_ = vector.z;
		object obj26 = obj2 + 48;
		obj26 = 0;
		_ = 0;
		obj26 = 72f;
		_ = -5f;
		_ = 36f;
		((Vector3*)(nint)vector)->x = (float)obj26;
		Vector3 vector23 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S0_v140+8]");
		((Vector3*)(nint)vector23)->z = 0f;
		object obj27 = obj2 + 36;
		Vector3 vector24 = vector / 0.75f;
		nint num13 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj27;
		Vector3 vector25 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S0_v148+8]");
		((Vector3*)(nint)vector25)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v150 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj28 = (nint)0 + (nint)108;
		obj28 = vector.x;
		_ = vector.z;
		object obj29 = obj2 + 24;
		obj29 = 0;
		_ = 0;
		obj29 = 0f;
		_ = 180f;
		_ = 35f;
		nint num14 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj29;
		Vector3 vector26 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S0_v155+8]");
		((Vector3*)(nint)vector26)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v161 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj30 = (nint)0 + (nint)120;
		obj30 = vector.x;
		_ = vector.z;
		object obj31 = obj2 + 12;
		obj31 = 0;
		_ = 0;
		obj31 = 7.6f;
		_ = 7.6f;
		_ = 7.6f;
		((Vector3*)(nint)vector)->x = (float)obj31;
		Vector3 vector27 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S0_v166+8]");
		((Vector3*)(nint)vector27)->z = 0f;
		Vector3 vector28 = vector / 0.75f;
		nint num15 = (nint)typeof(PauseScreen);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector29 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector29)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v175 (Il2CppClass<UI.Screens.PauseScreen>)+5C]");
		object obj32 = (nint)0 + (nint)132;
		obj32 = vector.x;
		_ = vector.z;
		PauseScreen.pauseScreenIsShown = false;
	}
}
