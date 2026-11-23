using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class RandomizeOffset : MonoBehaviour
{
	[Serializable]
	public class RandomOffsetsData
	{
		public bool left = true;

		public bool mid;

		public bool right = true;
	}

	private RandomOffsetsData randomOffsets;

	public static readonly string RandomOffsetsFieldName = "randomOffsets";

	private List<float> _offsets;

	public RandomOffsetsData RandomOffsets => randomOffsets;

	private void OnEnable()
	{
		ChooseRandomOffset();
	}

	public unsafe void ChooseRandomOffset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_017f: Expected Obj, but got I
		//IL_0132: Expected F4, but got I
		//IL_012d: Expected native int or pointer, but got VT
		//IL_014c: Expected F4, but got I
		//IL_0147: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		List<float> offsets = _offsets;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (System.Collections.Generic.List`1<System.Single>)+10]");
		object obj2 = (nint)0 + (nint)1;
		_ = 0;
		RandomOffsetsData randomOffsetsData = randomOffsets;
		bool flag = (byte)(~(randomOffsetsData.left ? 1u : 0u)) != 0;
		RandomOffsetsData randomOffsetsData2 = randomOffsetsData;
		if (!flag)
		{
			_offsets.Add(-20f);
			randomOffsetsData2 = randomOffsets;
		}
		RandomOffsetsData randomOffsetsData3;
		if (~(randomOffsetsData2.mid ? 1u : 0u) == 0)
		{
			_offsets.Add(0f);
			randomOffsetsData3 = randomOffsets;
		}
		else
		{
			randomOffsetsData3 = randomOffsetsData2;
		}
		if (~(randomOffsetsData3.right ? 1u : 0u) == 0)
		{
			_offsets.Add(20f);
		}
		List<float> offsets2 = _offsets;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27 (System.Collections.Generic.List`1<System.Single>)+C]");
		if ((nint)0 >= (nint)1)
		{
			Transform transform = base.transform;
			Vector3 localPosition = transform.localPosition;
			List<float> offsets3 = _offsets;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v38 (System.Collections.Generic.List`1<System.Single>)+C]");
			int index = UnityEngine.Random.Range(0, 0);
			float num = offsets3.get_Item(index);
			Transform transform2 = base.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform2.localPosition = vector;
		}
	}

	public void SetRandomOffsetsData(RandomOffsetsData newRandomOffsetsData)
	{
		randomOffsets = newRandomOffsetsData;
		ChooseRandomOffset();
	}

	public RandomizeOffset()
	{
		List<float> list = default;
		list._002Ector(3);
		_offsets = list;
		base._002Ector();
	}
}
