using System;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterPassTrigger : TrackEventTrigger
{
	private Transform _transform;

	private BoxCollider _collider;

	private EventHandler m_Triggered;

	public float EndPosition
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_005d: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			Vector3 position = _transform.position;
			Vector3 center = _collider.center;
			Vector3 size = _collider.size;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj3 = num + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			float num2 = 0f * 0.5f;
			return (float)obj3 + num2;
		}
	}

	public event EventHandler Triggered
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 20;
			Delegate obj2 = this.m_Triggered;
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
			object obj = this + 20;
			Delegate obj2 = this.m_Triggered;
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

	private void Awake()
	{
		Transform transform = base.transform;
		_transform = transform;
		Collider component = GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		BoxCollider collider = default;
		_collider = collider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			EventHandler triggered = this.m_Triggered;
			if (this.m_Triggered != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	protected unsafe void OnDrawGizmosSelected()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004f: Expected Obj, but got I
		//IL_006c: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_00bd: Expected F4, but got I
		//IL_00b8: Expected native int or pointer, but got VT
		//IL_00f6: Expected F4, but got I
		//IL_00f1: Expected native int or pointer, but got VT
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Collider component = GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Transform transform = base.transform;
		Vector3 position = transform.position;
		BoxCollider boxCollider = default;
		Vector3 center = boxCollider.center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		object obj2 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
		object obj3 = num2 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		object obj4 = num3 + 0;
		Vector3 size = boxCollider.size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		((Vector3*)(nint)vector)->x = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Vector3 center2 = vector + 16;
		Gizmos.DrawWireCube(center2, vector);
	}
}
