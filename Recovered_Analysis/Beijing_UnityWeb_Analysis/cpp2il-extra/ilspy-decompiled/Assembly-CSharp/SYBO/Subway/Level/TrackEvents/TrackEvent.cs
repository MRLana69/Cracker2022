using System;
using Cpp2ILInjected;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public abstract class TrackEvent : MonoBehaviour
{
	private float _probability;

	protected Transform _transform;

	private TrackObject _trackObject;

	protected bool _launched = false;

	private Action m_Launching;

	private Action m_Stopped;

	public unsafe event Action Launching
	{
		add
		{
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected Obj, but got Unknown
			//IL_0039: Expected I, but got Obj
			//IL_004f: Expected Obj, but got I
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Expected Obj, but got Unknown
			//IL_022a: Expected I, but got Obj
			//IL_0240: Expected Obj, but got I
			//IL_007a: Expected I, but got Obj
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			//IL_00c7: Expected I, but got Obj
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			//IL_0192: Expected Obj, but got I
			//IL_019d: Expected Obj, but got I4
			((Activity)this).Run();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Transform parentInternal = default;
			_transform.parentInternal = parentInternal;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v12 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v50 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			object obj4 = obj5 + 16;
			Vector3 one = Vector3.one;
			Transform transform = (Transform)(obj5 + 32);
			transform = (Transform)obj4;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v17+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v23 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v46 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj5;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8685");
			Action stopped = default;
			this.m_Stopped = stopped;
			this.m_Launching = this.m_Stopped;
			object obj7 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj8 = default;
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(MovingObjectActivity.RouteChunk_OnDeactivate);
			object obj9 = action + 16;
			obj9 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.TrackEvent)+28]");
			((RouteChunk)0).OnDeactivate -= action;
			((PlaceholderLifecycle)_launched).Despawn();
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_Launching;
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

	public event Action Stopped
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_Launching;
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
			Delegate obj = this.m_Stopped;
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

	protected virtual void Initialize()
	{
		_ = 200f;
		_ = 400f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98B2");
	}

	private void Start()
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0028: Expected I, but got Obj
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_0081: Expected I, but got Obj
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		object obj = this + 16;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 20;
		TrackObject component = GetComponent<TrackObject>();
		obj2 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		Action action = default;
		((Delegate)action).method_ptr = (IntPtr)ex;
		((Delegate)action).method = (IntPtr)ex;
		object obj3 = action + 16;
		obj3 = this;
		_trackObject.OnActivate -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex2 = new NullReferenceException();
		Action action2 = default;
		((Delegate)action2).method_ptr = (IntPtr)ex2;
		((Delegate)action2).method = (IntPtr)ex2;
		object obj4 = action2 + 16;
		obj4 = this;
		_trackObject.OnDeactivate -= action2;
	}

	protected virtual void OnDestroy()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected abstract void Launch();

	protected void EvaluateAndLaunchEvent()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00d6: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)_trackObject))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = new NullReferenceException();
			Action action = default;
			((Delegate)action).method_ptr = (IntPtr)ex;
			((Delegate)action).method = (IntPtr)ex;
			object obj2 = action + 16;
			obj2 = this;
			_trackObject.OnDeactivate += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex2 = new NullReferenceException();
			bool flag = default;
			object obj3 = (flag ? 1 : 0) + 16;
			obj3 = this;
			_trackObject.PropagateActivationStateToChildren = flag;
		}
	}

	protected virtual void TrackObject_OnActivate()
	{
		if (~(_launched ? 1u : 0u) == 0)
		{
			return;
		}
		float time = Time.time;
		if (!(_probability < time))
		{
			if (this.m_Launching != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			_launched = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected virtual void TrackObject_OnDeactivate()
	{
		TrackObject_OnActivate();
	}

	protected TrackEvent()
	{
		if (this.m_Stopped != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
