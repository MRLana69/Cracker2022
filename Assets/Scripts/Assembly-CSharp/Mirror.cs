using System;
using Cpp2ILInjected;
using UnityEngine;

public class Mirror : MonoBehaviour
{
	private Transform[] children;

	private TrackObject trackObject;

	private unsafe void Awake()
	{
		TrackObject trackObject = GetComponent<TrackObject>();
		if ((object)trackObject == null)
		{
			GameObject gameObject = base.gameObject;
			trackObject = gameObject.AddComponent<TrackObject>();
		}
		this.trackObject = trackObject;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(Mirror.OnActivate));
		this.trackObject.OnActivate += action;
		Transform transform = base.transform;
		int childCount = transform.childCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Transform[] array = default;
		children = array;
		int num = 0;
		Transform transform2 = base.transform;
		int childCount2 = transform2.childCount;
		if (childCount2 > num)
		{
			Transform transform3 = base.transform;
			Transform child = transform3.GetChild(num);
			throw new ArrayTypeMismatchException();
		}
	}

	public unsafe void OnActivate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0160: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0090: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00e8: Expected F4, but got I
		//IL_00e3: Expected native int or pointer, but got VT
		//IL_0102: Expected F4, but got I
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_0117: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		int num = UnityEngine.Random.Range(0, 2);
		int num2 = num << 1;
		object obj2 = num2 - 1;
		object obj3 = default;
		object obj11 = default;
		while (true)
		{
			Transform[] array = children;
			if (array.Length > (nint)obj3)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)array + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v19+10]");
				if ((UnityEngine.Object)0 != null)
				{
					object obj6 = obj3 << 2;
					object obj7 = (object)children + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v17+10]");
					Vector3 localPosition = ((Transform)0).localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					object obj8 = 0 * obj2;
					object obj9 = obj3 << 2;
					object obj10 = (object)children + obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
					((Vector3*)(nint)vector)->x = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v35+10]");
					((Transform)0).localPosition = vector;
				}
				obj3 = obj11 + 1;
				continue;
			}
			break;
		}
	}
}
