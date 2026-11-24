using Cpp2ILInjected;
using UnityEngine;

public class AnimatedColor : MonoBehaviour
{
	public Color color;

	private UIWidget mWidget;

	private void OnEnable()
	{
		//IL_000b: Expected VT, but got F4
		color = (Color)1f;
		CancelInvoke();
	}

	private void LateUpdate()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 28;
		UIWidget component = GetComponent<UIWidget>();
		obj = component;
		this._002Ector();
	}

	public unsafe AnimatedColor()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_003b: Expected I4, but got Obj
		object obj = this + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S2_v2+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 16);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		mWidget.rawPivot = pivot;
	}
}
