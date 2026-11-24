using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Events;

public class ValueChangedEventArgs : EventArgs
{
	private float _newValue;

	private float _oldValue;

	private float _deltaValue;

	public float NewValue
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Events.ValueChangedEventArgs)+14]");
			return 0f;
		}
	}

	public float OldValue => _newValue;

	public float DeltaValue => _oldValue;

	public ValueChangedEventArgs(float newValue, float oldValue, float deltaValue)
	{
		//IL_0011: Expected Obj, but got I
		//IL_001e: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got F4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Events.ValueChangedEventArgs)+28]");
		int layer = ((GameObject)0).layer;
		object obj = 0;
		_ = 0;
		obj = newValue;
		Transform transform = (Transform)(obj + 12);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}
}
