using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class Selector : MonoBehaviour
{
	private bool _initialized;

	protected Transform _transform;

	private Action<List<Selector>> m_PerformingSelection;

	public bool Initialized => _initialized;

	internal event Action<List<Selector>> PerformingSelection
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_PerformingSelection;
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
			object obj = this + 20;
			Delegate obj2 = this.m_PerformingSelection;
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

	protected virtual void Awake()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.Selector>)+EC] (should have been resolved before IL gen)");
		}
	}

	private void OnDisable()
	{
		int num = 0;
		while (true)
		{
			int childCount = _transform.childCount;
			if (childCount > num)
			{
				Transform child = _transform.GetChild(num);
				if (child != null)
				{
					Transform child2 = _transform.GetChild(num);
					GameObject gameObject = child2.gameObject;
					gameObject.SetActive(value: false);
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	protected virtual void Start()
	{
	}

	protected virtual void Initialize()
	{
		Transform transform = base.transform;
		_transform = transform;
		int num = 0;
		while (true)
		{
			int childCount = _transform.childCount;
			if (childCount <= num)
			{
				break;
			}
			Transform child = _transform.GetChild(num);
			if (child != null)
			{
				Transform child2 = _transform.GetChild(num);
				GameObject gameObject = child2.gameObject;
				gameObject.SetActive(value: false);
			}
			int num2 = num + 1;
			num = num2;
		}
		_initialized = true;
	}

	public virtual void PerformSelection(List<GameObject> objectsToVisit)
	{
		//IL_0029: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.Selector>)+EC] (should have been resolved before IL gen)");
		}
	}

	public void PerformSelection(List<GameObject> objectsToVisit, List<Selector> subSelectors)
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<SYBO.Subway.Level.Selector>)+F4] (should have been resolved before IL gen)");
		Action<List<Selector>> performingSelection = this.m_PerformingSelection;
		if (this.m_PerformingSelection != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S0_v3 (System.Action`1<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+C] (should have been resolved before IL gen)");
		}
	}

	protected void InitializeCheck()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.Selector>)+EC] (should have been resolved before IL gen)");
		}
	}
}
