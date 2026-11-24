using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

[StructLayout((LayoutKind)0, Size = 8)]
public struct Mission
{
	public MissionType type;

	public int goal;

	public unsafe Mission(MissionType type, int goal)
	{
		//IL_0409: Expected Obj, but got I4
		//IL_0409: Expected Obj, but got I
		//IL_041e: Expected Obj, but got I
		//IL_042f: Expected Obj, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I
		//IL_0035: Expected VT, but got Obj
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_006a: Expected VT, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_043e: Expected Obj, but got Ref
		//IL_014b: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_0209: Expected Obj, but got I
		//IL_0268: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Mission)+18]");
		((Component)0).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Mission)+10]");
		((UILabel)0).fontSize = (int)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Mission)+10]");
		GameObject gameObject = ((Component)0).gameObject;
		object obj = default;
		Transform transform = (Transform)(obj + 24);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Mission)+10]");
		GameObject gameObject2 = ((Component)0).gameObject;
		transform.localPosition = (Vector3)gameObject2;
		Transform transform2 = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Mission)+10]");
		GameObject gameObject3 = ((Component)0).gameObject;
		transform2.localPosition = (Vector3)gameObject3;
		obj = 0;
		_ = 0;
		obj = transform;
		_ = 141f;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		Transform transform3 = (Transform)(obj + 36);
		transform3 = (Transform)obj;
		Transform transform4 = transform3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform3.eulerAngles;
		object obj2 = goal + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [goal @ L2 (System.Int32)+C]");
		int num = UnityEngine.Random.RandomRangeInt(0, 0);
		int num2 = num << 2;
		object obj3 = obj2 + num2;
		object obj4 = obj3;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+8]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v24+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+C]");
				bool flag2;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v28+8]");
					flag2 = (nint)0 == 0;
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+10]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+10]");
					bool flag3;
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v32+8]");
						flag3 = (nint)0 == 0;
					}
					else
					{
						flag3 = true;
					}
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+14]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v18+14]");
						bool flag4;
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v36+8]");
							flag4 = (nint)0 == 0;
						}
						else
						{
							flag4 = true;
						}
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							throw new ArrayTypeMismatchException();
						}
					}
				}
			}
		}
		((LoadLevelCtrl)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)).MarkProgress();
	}
}
