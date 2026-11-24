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
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterPassTrigger)+9C]");
			return 0f;
		}
	}

	public event EventHandler Triggered
	{
		add
		{
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_Triggered;
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

	private void Awake()
	{
		CancelInvoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_Triggered;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)other);
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

	protected void OnDrawGizmosSelected()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		object obj = this + 12;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 16;
		Collider component = GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj3 = default;
		obj2 = obj3;
	}

	public unsafe CharacterPassTrigger()
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_0012: Expected VT, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected VT, but got Unknown
		//IL_010d: Expected F4, but got Obj
		//IL_0108: Expected native int or pointer, but got VT
		//IL_011f: Expected F4, but got I
		//IL_011a: Expected native int or pointer, but got VT
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected VT, but got Unknown
		//IL_013a: Expected F4, but got Obj
		//IL_0135: Expected native int or pointer, but got VT
		//IL_014c: Expected F4, but got I
		//IL_0147: Expected native int or pointer, but got VT
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0185: Expected F4, but got Obj
		//IL_0180: Expected native int or pointer, but got VT
		//IL_019a: Expected F4, but got I
		//IL_0195: Expected native int or pointer, but got VT
		//IL_01a7: Expected F4, but got Obj
		//IL_01a2: Expected native int or pointer, but got VT
		//IL_01b9: Expected F4, but got I
		//IL_01b4: Expected native int or pointer, but got VT
		//IL_0081: Expected I, but got Obj
		Collider component = GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		BoxCollider boxCollider = default;
		Transform transform = (Transform)(boxCollider + 36);
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		BoxCollider boxCollider2 = (BoxCollider)(boxCollider + 24);
		Vector3 vector = default;
		boxCollider2.center = vector;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector2 = (Vector3)(boxCollider + 48);
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector3 = (Vector3)(boxCollider + 60);
		((Vector3*)(nint)vector3)->x = (float)boxCollider2;
		((Vector3*)(nint)vector3)->z = (nint)((UnityEngine.Object)boxCollider2).m_CachedPtr;
		object obj2 = boxCollider + 12;
		Vector3 vector4 = vector2 - vector3;
		boxCollider.size = vector;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v27+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector3)->x = (float)boxCollider;
		((Vector3*)(nint)vector3)->z = (nint)((UnityEngine.Object)boxCollider).m_CachedPtr;
		Gizmos.DrawRay(vector2, vector3);
	}
}
