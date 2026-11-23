using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class GUIUtil
{
	public static float ScaleGUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected VT, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 224;
		int width = Screen.width;
		_ = 1065353216;
		_ = 1065353216;
		float result = (float)width / 320f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		Vector3 vector = (Vector3)(obj - -64);
		Matrix4x4 matrix4x = Matrix4x4.Scale(vector);
		object obj3 = obj + 160;
		object obj4 = obj + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		object obj5 = obj + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22A");
		Matrix4x4 matrix = default;
		GUI.matrix = matrix;
		return result;
	}
}
