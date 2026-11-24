using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class TrackObject : MonoBehaviour
{
	private bool _debugActivateOnStart;

	private bool _initialized;

	private Transform _transform;

	private bool _active;

	private TrackObject[] _childTrackObjects;

	private Action m_OnActivate;

	private Action m_OnDeactivate;

	private bool _propagateActivationStateToChildren;

	public Transform Transform
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Transform)_debugActivateOnStart;
		}
	}

	public bool Active
	{
		get
		{
			//IL_000d: Expected I4, but got Obj
			ActivateChildren();
			return (byte)(int)_transform != 0;
		}
	}

	public bool PropagateActivationStateToChildren
	{
		get
		{
			return _active;
		}
		set
		{
			//IL_0066: Expected Obj, but got I4
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnDeactivate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public event Action OnActivate
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 12;
			obj = value;
			((RandomizeOffset)this)._002Ector();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnActivate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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

	public event Action OnDeactivate
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnActivate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 28;
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
			Delegate obj = this.m_OnDeactivate;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 32;
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

	public void Hack_PropagateActivationStateToChildrenImmediately()
	{
		CancelInvoke();
	}

	private void Awake()
	{
		//IL_0012: Expected Obj, but got I4
		((Tunnel)this).OnTriggerEnter((Collider)null);
		((Tunnel)this).OnTriggerEnter((Collider)1);
	}

	private void Start()
	{
		ActivateChildren();
	}

	private void InitializeCheck()
	{
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Lightmapping.RequestLightsDelegate requestLightsDelegate = Lightmapping.GetDelegate();
		if (requestLightsDelegate != null && ~(_debugActivateOnStart ? 1u : 0u) == 0)
		{
			_propagateActivationStateToChildren = true;
			string text = tag;
			string text2 = ((GameObject)(object)text).tag;
			if (text2 != null && ~(_active ? 1u : 0u) != 0)
			{
				Deactivate();
			}
		}
	}

	private void ActivateChildren()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			object obj = this + 16;
			GameObject gameObject = base.gameObject;
			obj = gameObject;
			_initialized = true;
		}
	}

	private void DeactivateChildren()
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		object obj = this + 24;
		TrackObject[] componentsInChildren = GetComponentsInChildren<TrackObject>(includeInactive: true);
		obj = componentsInChildren;
		object obj2 = 0;
		while (true)
		{
			TrackObject[] childTrackObjects = _childTrackObjects;
			if ((nint)obj2 >= childTrackObjects.Length)
			{
				break;
			}
			object obj3 = _childTrackObjects + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj5).FindKernel((string)(object)this) != 0)
			{
				object obj7 = _childTrackObjects + 16;
				object obj8 = obj2 << 2;
				object obj9 = obj7 + obj8;
				((TrackObject)obj9).Deactivate();
			}
			object obj10 = obj2 + 1;
			obj2 = obj10;
		}
	}

	public void Activate()
	{
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_007f: Expected I, but got Obj
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		object obj = this + 24;
		TrackObject[] componentsInChildren = GetComponentsInChildren<TrackObject>(includeInactive: true);
		obj = componentsInChildren;
		object obj2 = 0;
		while (true)
		{
			TrackObject[] childTrackObjects = _childTrackObjects;
			if ((nint)obj2 >= childTrackObjects.Length)
			{
				break;
			}
			object obj3 = _childTrackObjects + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj5).FindKernel((string)(object)this) != 0)
			{
				object obj7 = _childTrackObjects + 16;
				object obj8 = obj2 << 2;
				object obj9 = obj7 + obj8;
				((TrackObject)obj9)._002Ector();
			}
			object obj10 = obj2 + 1;
			obj2 = obj10;
		}
	}

	public void Deactivate()
	{
		if (~(_active ? 1u : 0u) != 0)
		{
			if (this.m_OnActivate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			if (~(_propagateActivationStateToChildren ? 1u : 0u) == 0)
			{
				DeactivateChildren();
			}
			_active = true;
		}
	}

	public TrackObject()
	{
		if (~(_active ? 1u : 0u) == 0)
		{
			_active = false;
			if (this.m_OnDeactivate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			if (~(_propagateActivationStateToChildren ? 1u : 0u) == 0)
			{
				Activate();
			}
		}
	}
}
