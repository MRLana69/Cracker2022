using Cpp2ILInjected;
using UnityEngine;

public class PanelPixelFix : MonoBehaviour
{
	private UIPanel panel;

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected VT, but got Unknown
		//IL_0108: Expected F4, but got I
		//IL_0103: Expected native int or pointer, but got VT
		//IL_0127: Expected F4, but got I
		//IL_0122: Expected native int or pointer, but got VT
		object obj = default;
		Vector4 vector = (Vector4)(obj - 80);
		if (panel != null)
		{
			Transform cachedTransform = panel.cachedTransform;
			Vector3 localPosition = cachedTransform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Transform cachedTransform2 = panel.cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+30]");
			_ = 0;
			Vector3 localPosition2 = (Vector3)(vector + 16);
			cachedTransform2.localPosition = localPosition2;
			UIPanel uIPanel = panel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+28]");
			((Vector4*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+20]");
			((Vector4*)(nint)vector)->x = 0f;
			panel.baseClipRegion = vector;
		}
	}
}
