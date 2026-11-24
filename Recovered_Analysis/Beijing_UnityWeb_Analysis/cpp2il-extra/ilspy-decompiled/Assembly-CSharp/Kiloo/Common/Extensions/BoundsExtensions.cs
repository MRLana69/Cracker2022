using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class BoundsExtensions
{
	public static void SetWidth(Bounds bound, float width)
	{
	}

	public static void SetHeight(Bounds bound, float height)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got F4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		float num = height * 0.5f;
		obj = num;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A8");
	}

	public static int GetWidth(Bounds bound)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		object obj = bound / 100;
		object obj2 = obj - 1;
		if ((nint)obj != 1)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						if ((nint)obj2 == 4)
						{
							return 5;
						}
						return 0;
					}
					return 4;
				}
				return 3;
			}
			return 2;
		}
		return 1;
	}

	public static int GetHeight(Bounds bound)
	{
		//IL_0053: Invalid comparison between Obj and F4
		//IL_008c: Invalid comparison between Obj and F4
		//IL_0045: Expected Obj, but got I4
		//IL_00ca: Expected I4, but got Obj
		//IL_007e: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		object obj2 = default;
		object obj = obj2;
		if (obj2 != obj2)
		{
			obj = int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2.1474836E+09f))
		{
			obj = int.MinValue;
		}
		else if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)(-2.1474836E+09f)))
		{
			obj = int.MinValue;
		}
		return obj << 1;
	}
}
