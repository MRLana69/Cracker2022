using System;
using Cpp2ILInjected;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.Timer;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.Generic;

public class TimerHelper : MonoBehaviour
{
	private UISprite _background;

	private UISprite _animatedClock;

	private UISprite _clockFrame;

	private UILabel _timerTime;

	private HorizontalLayout _timerLayout;

	private TimeSpinner _timerSpinner;

	private DateTime _endTime;

	private int _lastTimerLength;

	private Timer _refreshTimer;

	private bool _timerIsRunning;

	private string _timerText;

	private Action m_onTimerEnded;

	public event Action onTimerEnded
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			object obj = this - -64;
			Delegate obj2 = (Delegate)obj;
			object obj5 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj4 = this - -64;
				if (obj4 == obj2)
				{
					obj4 = obj5;
				}
				if (obj4 != obj2)
				{
					obj2 = (Delegate)obj4;
					continue;
				}
				break;
			}
		}
	}

	public void StartTimer(TimeSpan timeSpan)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void StartTimer(DateTime endTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public void StopTimer()
	{
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00ee: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		UISprite background = _background;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!((UnityEngine.Object)((UIBasicSprite)background).mInvert != null))
		{
			UISprite background2 = _background;
			bool mInvert = ((UIBasicSprite)background2).mInvert;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v11 (System.Boolean)+F4]");
			int sortingOrder = (int)((nint)0 + (nint)1);
			((UIPanel)(object)_background).sortingOrder = sortingOrder;
		}
	}

	public unsafe void SetAlignment(HorizontalAlignment alignment)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008e: Expected VT, but got Obj
		//IL_00b6: Expected I, but got Obj
		//IL_00cc: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got VT
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0117: Expected Obj, but got VT
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected VT, but got Unknown
		//IL_0132: Expected I8, but got Obj
		//IL_012d: Expected native int or pointer, but got VT
		//IL_0147: Expected Ref, but got VT
		//IL_0153: Expected Obj, but got I8
		//IL_0165: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = ((HorizontalAlignment*)(int)alignment)->value__;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		formatProvider = (IFormatProvider)obj;
		_endTime = (DateTime)formatProvider;
		StopInternalTimer();
		_timerIsRunning = true;
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v36 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 16;
		obj4 = _endTime;
		object obj5 = obj2 + 8;
		obj5 = today;
		DateTime dateTime = (DateTime)(obj2 + 32);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
		formatProvider = (IFormatProvider)obj5;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj2 = num3;
		formatProvider = (IFormatProvider)obj2;
		((TimeSpinner)this).Animate((byte)(int)formatProvider != 0);
		this._002Ector();
	}

	public void SetTimerColors(Color contentColor, Color backgroundColor)
	{
		//IL_000f: Expected I4, but got VT
		//IL_0018: Expected Obj, but got VT
		_background.height = (int)contentColor;
		Color color = ((UIWidget)backgroundColor).color;
	}

	public void SetTimerText(string text)
	{
		//IL_00a3: Expected I4, but got Obj
		UIWidget component = GetComponent<UIWidget>();
		HorizontalLayout timerLayout = _timerLayout;
		timerLayout.alignment = (HorizontalAlignment)text;
		int depth;
		if (text == null)
		{
			depth = 4;
		}
		else if ((nint)text == 1)
		{
			depth = 3;
		}
		else
		{
			depth = (int)(((nint)text == 2) ? UIWidget.Pivot.Right : component.mPivot);
		}
		UIWidget component2 = _timerLayout.GetComponent<UIWidget>();
		component.depth = depth;
		component2.depth = depth;
		this._002Ector();
	}

	public void HideIcon()
	{
		if (~(_timerIsRunning ? 1u : 0u) == 0)
		{
			_timerIsRunning = false;
			OnEnable();
		}
		((RewardForVideoButton)this).OnCachedVideo((string)null, false);
	}

	public void ShowIcon()
	{
		string text = _clockFrame.tag;
		((GameObject)(object)text).tag = null;
		this._002Ector();
	}

	private void StartInternalTimer()
	{
		//IL_001d: Expected Obj, but got I4
		string text = _clockFrame.tag;
		((GameObject)(object)text).tag = (string)1;
		this._002Ector();
	}

	private unsafe void StopInternalTimer()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		if (_refreshTimer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 1f;
			_ = 0;
			object obj = this + 52;
			object obj2 = default;
			obj = obj2;
		}
		Timer refreshTimer = _refreshTimer;
		if (~(((BaseTimer)refreshTimer)._running ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(TimerHelper.TimerRefreshed);
		object obj3 = action + 16;
		obj3 = this;
		_refreshTimer.intervalElapsed -= action;
	}

	private void OnEnable()
	{
		if (_refreshTimer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private void OnDisable()
	{
		if (~(_timerIsRunning ? 1u : 0u) == 0)
		{
			StopInternalTimer();
		}
	}

	private void TimerRefreshed()
	{
		OnEnable();
	}

	private void RefreshTimerLabels(TimeSpan expireTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private unsafe void AlignBackground()
	{
		//IL_0123: Expected I, but got Obj
		//IL_0139: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got VT
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got VT
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected VT, but got Unknown
		//IL_019f: Expected I8, but got Obj
		//IL_019a: Expected native int or pointer, but got VT
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d0: Expected Ref, but got VT
		//IL_01dc: Expected Obj, but got I8
		//IL_01ee: Expected I4, but got Obj
		//IL_01fc: Expected I, but got Obj
		//IL_0212: Expected Obj, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0245: Expected Obj, but got I8
		//IL_024e: Expected Obj, but got VT
		//IL_025b: Expected I8, but got Obj
		//IL_0256: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00ed: Expected I4, but got Obj
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v57 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		obj2 = _endTime;
		object obj4 = obj3 + 24;
		obj4 = today;
		DateTime dateTime = (DateTime)(obj3 + 40);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
		IFormatProvider formatProvider = (IFormatProvider)(obj3 + 48);
		formatProvider = (IFormatProvider)obj4;
		object obj5 = obj3 + 16;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj5 = num3;
		formatProvider = (IFormatProvider)obj5;
		((TimeSpinner)this).Animate((byte)(int)formatProvider != 0);
		nint num4 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v30 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num5 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v51 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj3 + 8;
		obj7 = num3;
		obj3 = TimeSpan.Zero;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj7;
		formatProvider = (IFormatProvider)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3FB");
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(TimerHelper.TimerRefreshed);
			object obj9 = action + 16;
			obj9 = this;
			FrameTimer.ExecuteWithDelay((int)_refreshTimer, action);
			object t = this - -64;
			TransformExtensions.Reset((Transform)t);
		}
	}

	private unsafe void AnimateClock(bool animate, bool timeExpired = false)
	{
		UIWidget.Pivot pivot = default;
		((UIWidget.Pivot*)(int)pivot)->value__ = (((bool*)(timeExpired ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [timeExpired @ L2 (System.Boolean)+8]");
		_ = 0;
		_background.rawPivot = pivot;
		((UIWidget.Pivot*)(int)pivot)->value__ = (((bool*)(animate ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animate @ L1 (System.Boolean)+8]");
		_ = 0;
		_animatedClock.rawPivot = pivot;
		((UIWidget.Pivot*)(int)pivot)->value__ = (((bool*)(animate ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animate @ L1 (System.Boolean)+8]");
		_ = 0;
		_clockFrame.rawPivot = pivot;
		((UIWidget.Pivot*)(int)pivot)->value__ = (((bool*)(animate ? 1 : 0))->m_value ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [animate @ L1 (System.Boolean)+8]");
		_ = 0;
		_timerTime.rawPivot = pivot;
	}

	public TimerHelper()
	{
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_02cd: Expected Obj, but got I4
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_021e: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_0130: Expected Obj, but got F4
		//IL_0249: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got F4
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		((RewardForVideoButton)(object)_timerLayout).Init((VideoButtonPayload)1);
		UILabel timerTime = _timerTime;
		string mText = timerTime.mText;
		_lastTimerLength = mText.m_stringLength;
		HorizontalLayout timerLayout = _timerLayout;
		if (timerLayout.alignment != HorizontalAlignment.Center)
		{
			if (timerLayout.alignment != HorizontalAlignment.Left)
			{
				if (timerLayout.alignment == HorizontalAlignment.Right)
				{
					GameObject gameObject = _timerLayout.gameObject;
					HorizontalLayout timerLayout2 = _timerLayout;
					obj = 0;
					_ = 0;
					float num = timerLayout2.autosizeWidgetMargin * -0.5f;
					obj = num;
					_ = 0f;
					_ = 0f;
					transform = (Transform)obj;
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					Vector3 eulerAngles = transform.eulerAngles;
				}
			}
			else
			{
				GameObject gameObject2 = _timerLayout.gameObject;
				HorizontalLayout timerLayout3 = _timerLayout;
				obj = 0;
				_ = 0;
				float num2 = timerLayout3.autosizeWidgetMargin * 0.5f;
				obj = num2;
				_ = 0f;
				_ = 0f;
				transform = (Transform)obj;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles2 = transform.eulerAngles;
			}
		}
		else
		{
			GameObject gameObject3 = _timerLayout.gameObject;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v21 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v29 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles3 = transform.eulerAngles;
		}
		UIWidget component = GetComponent<UIWidget>();
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			UIWidget component2 = _background.GetComponent<UIWidget>();
			component.height = component2.mWidth;
		}
	}
}
