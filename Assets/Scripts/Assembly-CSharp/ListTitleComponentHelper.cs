using Cpp2ILInjected;
using UnityEngine;

public class ListTitleComponentHelper : MonoBehaviour
{
	private UILabel label;

	private UIWidget outline;

	private Vector3 _outlinePosition;

	public unsafe void Setup(string text, Color color, float offsetFromLeft)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected VT, but got Unknown
		//IL_00a0: Expected VT, but got I
		//IL_00c8: Expected VT, but got F4
		//IL_00ec: Expected F4, but got I
		//IL_00e7: Expected native int or pointer, but got VT
		//IL_00fb: Expected F4, but got VT
		//IL_00f6: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		label.text = text;
		_ = color.b;
		_ = color.r;
		Color color2 = (Color)(vector + 16);
		label.color = color2;
		Transform transform = outline.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_outlinePosition = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		float num = (float)_outlinePosition + offsetFromLeft;
		_outlinePosition = (Vector3)num;
		Transform transform2 = outline.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (ListTitleComponentHelper)+1C]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_outlinePosition;
		transform2.localPosition = vector;
	}

	public ListTitleComponentHelper()
	{
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_outlinePosition = Vector3.zeroVector;
		base._002Ector();
	}
}
