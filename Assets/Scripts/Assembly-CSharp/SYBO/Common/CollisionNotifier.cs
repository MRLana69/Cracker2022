using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common;

public class CollisionNotifier : MonoBehaviour
{
	private bool _initialized;

	private Collider _collider;

	public List<Collider> CollisionsEnterThisFrame;

	public List<Collider> CollisionsExitThisFrame;

	private Action<Collider> m_TriggerEnter;

	private Action<Collider> m_TriggerExit;

	public Collider Collider
	{
		get
		{
			Initialize();
			return _collider;
		}
	}

	public event Action<Collider> TriggerEnter
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 28;
			Delegate obj2 = this.m_TriggerEnter;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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
			Delegate obj2 = this.m_TriggerEnter;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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

	public event Action<Collider> TriggerExit
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 32;
			Delegate obj2 = this.m_TriggerExit;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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
			Delegate obj2 = this.m_TriggerExit;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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

	private void Awake()
	{
		Initialize();
	}

	private void Initialize()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Collider component = GetComponent<Collider>();
			_collider = component;
			_initialized = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		CollisionsEnterThisFrame.Add(other);
		Action<Collider> triggerEnter = this.m_TriggerEnter;
		if (this.m_TriggerEnter != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S0_v8 (System.Action`1<UnityEngine.Collider>)+C] (should have been resolved before IL gen)");
		}
	}

	private void OnTriggerExit(Collider other)
	{
		CollisionsExitThisFrame.Add(other);
		Action<Collider> triggerExit = this.m_TriggerExit;
		if (this.m_TriggerExit != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S0_v8 (System.Action`1<UnityEngine.Collider>)+C] (should have been resolved before IL gen)");
		}
	}

	public void ClearFrame()
	{
		((List<T>)(object)CollisionsEnterThisFrame).Clear();
		((List<T>)(object)CollisionsExitThisFrame).Clear();
	}

	public CollisionNotifier()
	{
		List<Collider> list = default;
		list._002Ector();
		CollisionsEnterThisFrame = list;
		List<Collider> list2 = default;
		list2._002Ector();
		CollisionsExitThisFrame = list2;
		base._002Ector();
	}
}
