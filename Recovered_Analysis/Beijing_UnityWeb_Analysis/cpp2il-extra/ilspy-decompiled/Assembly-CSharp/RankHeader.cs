using Cpp2ILInjected;
using UnityEngine;

public class RankHeader : MonoBehaviour
{
	private UILabel _title;

	private UILabel _best;

	private UILabel _rankMedal;

	private UISprite _background;

	public unsafe void InitHeader(int rank, int bestScore)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0160: Expected Obj, but got I4
		//IL_0169: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I4
		//IL_0199: Expected F4, but got Obj
		//IL_0194: Expected native int or pointer, but got VT
		//IL_01b3: Expected F4, but got Obj
		//IL_01ae: Expected native int or pointer, but got VT
		//IL_01c8: Expected F4, but got I
		//IL_01c3: Expected native int or pointer, but got VT
		//IL_01d5: Expected I4, but got VT
		//IL_01d5: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_01f5: Expected Obj, but got I4
		//IL_021c: Expected F4, but got Obj
		//IL_0217: Expected native int or pointer, but got VT
		//IL_0096: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_00cf: Expected F4, but got Obj
		//IL_00ca: Expected native int or pointer, but got VT
		//IL_00e9: Expected F4, but got Obj
		//IL_00e4: Expected native int or pointer, but got VT
		//IL_00fe: Expected F4, but got I
		//IL_00f9: Expected native int or pointer, but got VT
		//IL_010b: Expected I4, but got VT
		//IL_010b: Expected Obj, but got I4
		//IL_023b: Expected F4, but got Obj
		//IL_0236: Expected native int or pointer, but got VT
		//IL_0250: Expected F4, but got I
		//IL_024b: Expected native int or pointer, but got VT
		//IL_0259: Expected Obj, but got VT
		//IL_0119: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_012b: Expected Obj, but got I4
		//IL_0152: Expected F4, but got Obj
		//IL_014d: Expected native int or pointer, but got VT
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj - -64);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 56;
		object obj5 = obj + 16;
		object obj6 = obj + 52;
		object obj7 = obj + 48;
		object obj8 = obj + 44;
		if (bestScore != 0)
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = 28;
			_ = 103;
			_ = -100;
			_ = -1;
			obj4 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)rank).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = 0;
			obj5 = 0;
			obj5 = -1;
			_ = -1;
			_ = -1;
			_ = -1;
			obj6 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		}
		else
		{
			obj2 = 0;
			obj2 = 0;
			obj2 = -1;
			_ = -1;
			_ = -1;
			_ = -1;
			obj7 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj7;
			Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			((UIWidget)rank).rawPivot = (UIWidget.Pivot)matrix4x;
			obj5 = 0;
			obj5 = 0;
			obj5 = 0;
			_ = 0;
			_ = 0;
			_ = -1;
			obj8 = obj5;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj8;
		}
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Vector2 effectDistance = ((UILabel)matrix4x).effectDistance;
	}

	private unsafe void setTextAndColours(int rank, int score)
	{
		//IL_000e: Expected Obj, but got I4
		((RenderTextureManager)this).CopyRenderTextureSettings(ref *(RenderTexture*)rank, (RenderTexture)score);
	}

	public RankHeader()
	{
		CancelInvoke();
	}
}
