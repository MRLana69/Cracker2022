using System;
using Cpp2ILInjected;
using UnityEngine;

public class pMath
{
	public static float Bell(float x)
	{
		if (x > 0f)
		{
			return 1f;
		}
		if (x < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	public static float Lerp(float xFrom, float xTo, float x, float yFrom, float yTo)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public static float Square(float x)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float value = x - 0.5f;
		float num3 = Math.Abs(value);
		float num4 = num3 * 2f;
		float value2 = 1f - num4;
		return Mathf.InverseLerp(0f, 1f, value2);
	}

	public pMath()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
