using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Analytics;
using SYBO.Subway.Promotion;
using UnityEngine;

namespace SYBO.Common;

public class CollisionNotifier : MonoBehaviour
{
	private bool _initialized;

	private Collider _collider;

	private Action<Collider> m_TriggerEnter;

	private Action<Collider> m_TriggerExit;

	public List<Collider> CollisionsEnterThisFrame;

	public List<Collider> CollisionsExitThisFrame;

	public Collider Collider
	{
		get
		{
			//IL_0018: Expected Obj, but got I4
			DateTime startTime = ((BoardPromotion)(object)this).StartTime;
			return (Collider)((TimeZoneInfo)(object)this).IsInvalidTime(startTime);
		}
	}

	public event Action<Collider> TriggerEnter
	{
		add
		{
			//IL_000b: Expected Obj, but got I4
			//IL_0015: Expected I, but got Obj
			_collider = (Collider)(-1);
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)value;
			Awake();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_TriggerEnter;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public event Action<Collider> TriggerExit
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_TriggerEnter;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 20;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_TriggerExit;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 24;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	private void Awake()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AnalyticsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime eventTime = AnalyticsEvent.GetEventTime();
		_collider = (Collider)eventTime;
	}

	private void Initialize()
	{
		ClearFrame();
	}

	private void OnTriggerEnter(Collider other)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_TriggerExit;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)other);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 24;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		CollisionsEnterThisFrame.Add(other);
		if (this.m_TriggerEnter != null)
		{
			this.m_TriggerEnter(other);
		}
	}

	public void ClearFrame()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			object obj = this + 16;
			Collider component = GetComponent<Collider>();
			obj = component;
			_initialized = true;
		}
	}

	public CollisionNotifier()
	{
		throw new IndexOutOfRangeException();
	}
}
