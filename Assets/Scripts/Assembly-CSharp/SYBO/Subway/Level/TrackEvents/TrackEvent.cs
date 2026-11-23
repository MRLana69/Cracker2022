using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public abstract class TrackEvent : MonoBehaviour
{
	private float _probability = 1f;

	protected Transform _transform;

	private TrackObject _trackObject;

	protected bool _launched;

	private Action m_Launching;

	private Action m_Stopped;

	public event Action Launching
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_Launching;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_Launching;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public event Action Stopped
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_Stopped;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_Stopped;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	protected virtual void Initialize()
	{
		//IL_001c: Expected I, but got Obj
		//IL_004c: Expected I, but got Obj
		Transform transform = base.transform;
		_transform = transform;
		TrackObject component = GetComponent<TrackObject>();
		_trackObject = component;
		NullReferenceException ex = new NullReferenceException();
		Action action = default;
		action._002Ector(this, (IntPtr)ex);
		_trackObject.OnActivate += action;
		NullReferenceException ex2 = new NullReferenceException();
		Action action2 = default;
		action2._002Ector(this, (IntPtr)ex2);
		_trackObject.OnDeactivate += action2;
	}

	private void Start()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SYBO.Subway.Level.TrackEvents.TrackEvent>)+DC] (should have been resolved before IL gen)");
	}

	protected virtual void OnDestroy()
	{
		//IL_0021: Expected I, but got Obj
		//IL_0051: Expected I, but got Obj
		if ((bool)_trackObject)
		{
			NullReferenceException ex = new NullReferenceException();
			Action action = default;
			action._002Ector(this, (IntPtr)ex);
			_trackObject.OnActivate -= action;
			NullReferenceException ex2 = new NullReferenceException();
			Action action2 = default;
			action2._002Ector(this, (IntPtr)ex2);
			_trackObject.OnDeactivate -= action2;
		}
	}

	protected abstract void Launch();

	protected void EvaluateAndLaunchEvent()
	{
		//IL_0080: Expected I, but got Obj
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		if (_launched)
		{
			return;
		}
		float value = UnityEngine.Random.value;
		if (!(_probability < value))
		{
			Action launching = this.m_Launching;
			if (this.m_Launching != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			_launched = true;
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S1_v7 (Il2CppClass<SYBO.Subway.Level.TrackEvents.TrackEvent>)+EC] (should have been resolved before IL gen)");
		}
	}

	protected virtual void TrackObject_OnActivate()
	{
		EvaluateAndLaunchEvent();
	}

	protected virtual void TrackObject_OnDeactivate()
	{
		_launched = false;
		Action stopped = this.m_Stopped;
		if (this.m_Stopped != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v4.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
