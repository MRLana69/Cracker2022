using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class RandomizeOffset : MonoBehaviour
{
	[Serializable]
	public class RandomOffsetsData
	{
		public bool left;

		public bool mid;

		public bool right;

		public RandomOffsetsData()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private RandomOffsetsData randomOffsets;

	public static readonly string RandomOffsetsFieldName;

	private List<float> _offsets;

	public RandomOffsetsData RandomOffsets
	{
		get
		{
			//IL_0075: Expected Obj, but got I4
			bool flag = IsInvoking();
			bool flag2 = (flag ? 1 : 0) == -1;
			bool flag3 = !flag2;
			bool flag4 = flag;
			if (!flag3)
			{
				object msg = ((IConvertible)"Could not find layer '").ToType((Type)(object)this, (IFormatProvider)(object)"'.");
				SDebug.LogFormat((string)msg, null);
				flag4 = true;
			}
			return (RandomOffsetsData)flag4;
		}
	}

	private void OnEnable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v25 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		_ = 1f;
		_ = 1f;
		_ = 1f;
		CancelInvoke();
	}

	public void ChooseRandomOffset()
	{
		this._002Ector();
	}

	public void SetRandomOffsetsData(RandomOffsetsData newRandomOffsetsData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		transform = (Transform)(object)newRandomOffsetsData;
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)(newRandomOffsetsData.left ? 1 : 0);
		object obj2 = this + 48;
		obj2 = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		GameObject gameObject = base.gameObject;
		object obj3 = this + 48;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2+8]");
		_ = 0;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	public RandomizeOffset()
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019b: Expected Obj, but got I4
		Transform transform = default;
		object obj = transform + 12;
		obj = 0;
		_ = 0;
		throw new IndexOutOfRangeException();
	}
}
