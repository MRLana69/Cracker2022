using Cpp2ILInjected;
using UnityEngine;

public class AnimatedColor : MonoBehaviour
{
	public Color color = (Color)4575657222473777152L;

	private UIWidget mWidget;

	private void OnEnable()
	{
		UIWidget component = GetComponent<UIWidget>();
		mWidget = component;
		LateUpdate();
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0023: Expected F4, but got I
		//IL_001e: Expected native int or pointer, but got VT
		//IL_0032: Expected F4, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AnimatedColor)+14]");
		((Color*)(nint)color)->b = 0f;
		((Color*)(nint)color)->r = (float)this.color;
		mWidget.color = color;
	}

	public AnimatedColor()
	{
		//IL_000f: Expected VT, but got I8
		_ = 4575657222473777152L;
		base._002Ector();
	}
}
