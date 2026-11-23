using UnityEngine;

public class UIExclusiveContainerHelper : MonoBehaviour
{
	private UILabel messageLabel;

	private UISprite messageBackground;

	public unsafe void SetupExclusiveMessage(string message, Color backgroundColor, Color textColor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected VT, but got Unknown
		//IL_007d: Expected native int or pointer, but got VT
		//IL_008f: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 32);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		messageLabel.text = message;
		_ = backgroundColor.b;
		_ = backgroundColor.r;
		Color color2 = color + 16;
		messageBackground.color = color2;
		((Color*)(nint)color)->b = textColor.b;
		((Color*)(nint)color)->r = textColor.r;
		messageLabel.color = color;
	}

	public void Disable()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	public void Enable()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}
}
