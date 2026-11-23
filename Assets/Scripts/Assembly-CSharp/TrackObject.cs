using System;
using Cpp2ILInjected;
using UnityEngine;

public class TrackObject : MonoBehaviour
{
	private bool _debugActivateOnStart;

	private bool _initialized;

	private Transform _transform;

	private bool _active;

	private TrackObject[] _childTrackObjects;

	private bool _propagateActivationStateToChildren;

	private Action m_OnActivate;

	private Action m_OnDeactivate;

	public Transform Transform
	{
		get
		{
			InitializeCheck();
			return _transform;
		}
	}

	public bool Active => _active;

	public bool PropagateActivationStateToChildren
	{
		get
		{
			return _propagateActivationStateToChildren;
		}
		set
		{
			if (_propagateActivationStateToChildren != value)
			{
				_propagateActivationStateToChildren = value;
				if (~(_active ? 1u : 0u) == 0 && value)
				{
					ActivateChildren();
				}
			}
		}
	}

	public event Action OnActivate
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_OnActivate;
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
			Delegate obj2 = this.m_OnActivate;
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

	public event Action OnDeactivate
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 36;
			Delegate obj2 = this.m_OnDeactivate;
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
			object obj = this + 36;
			Delegate obj2 = this.m_OnDeactivate;
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

	public void Hack_PropagateActivationStateToChildrenImmediately()
	{
		PropagateActivationStateToChildren = false;
		PropagateActivationStateToChildren = true;
	}

	private void Awake()
	{
		InitializeCheck();
	}

	private void Start()
	{
		if (Debug.isDebugBuild && ~(_debugActivateOnStart ? 1u : 0u) == 0)
		{
			_propagateActivationStateToChildren = true;
			GameObject gameObject = base.gameObject;
			if (gameObject.activeInHierarchy && !_active)
			{
				Activate();
			}
		}
	}

	private void InitializeCheck()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Transform transform = base.transform;
			_transform = transform;
			_initialized = true;
		}
	}

	private void ActivateChildren()
	{
		//IL_00c5: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I
		TrackObject[] componentsInChildren = GetComponentsInChildren<TrackObject>(includeInactive: true);
		_childTrackObjects = componentsInChildren;
		object obj = 0;
		while (true)
		{
			TrackObject[] childTrackObjects = _childTrackObjects;
			if (childTrackObjects.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)childTrackObjects + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v13+10]");
				if ((UnityEngine.Object)0 != this)
				{
					object obj4 = obj << 2;
					object obj5 = (object)_childTrackObjects + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24+10]");
					((TrackObject)0).Activate();
				}
				object obj6 = obj + 1;
				obj = obj6;
				continue;
			}
			break;
		}
	}

	private void DeactivateChildren()
	{
		//IL_00c5: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I
		TrackObject[] componentsInChildren = GetComponentsInChildren<TrackObject>(includeInactive: true);
		_childTrackObjects = componentsInChildren;
		object obj = 0;
		while (true)
		{
			TrackObject[] childTrackObjects = _childTrackObjects;
			if (childTrackObjects.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)childTrackObjects + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v13+10]");
				if ((UnityEngine.Object)0 != this)
				{
					object obj4 = obj << 2;
					object obj5 = (object)_childTrackObjects + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v24+10]");
					((TrackObject)0).Deactivate();
				}
				object obj6 = obj + 1;
				obj = obj6;
				continue;
			}
			break;
		}
	}

	public void Activate()
	{
		if (~(_active ? 1u : 0u) != 0)
		{
			Action onActivate = this.m_OnActivate;
			if (this.m_OnActivate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			if (~(_propagateActivationStateToChildren ? 1u : 0u) == 0)
			{
				ActivateChildren();
			}
			_active = true;
		}
	}

	public void Deactivate()
	{
		if (~(_active ? 1u : 0u) == 0)
		{
			_active = false;
			Action onDeactivate = this.m_OnDeactivate;
			if (this.m_OnDeactivate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v7.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			if (~(_propagateActivationStateToChildren ? 1u : 0u) == 0)
			{
				DeactivateChildren();
			}
		}
	}
}
