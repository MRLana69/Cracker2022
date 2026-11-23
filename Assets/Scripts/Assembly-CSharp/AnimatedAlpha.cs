using Cpp2ILInjected;
using UnityEngine;

public class AnimatedAlpha : MonoBehaviour
{
	public float alpha = 1f;

	private UIWidget mWidget;

	private UIPanel mPanel;

	private void OnEnable()
	{
		UIWidget component = GetComponent<UIWidget>();
		mWidget = component;
		UIPanel component2 = GetComponent<UIPanel>();
		mPanel = component2;
		LateUpdate();
	}

	private void LateUpdate()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		if (mWidget != null)
		{
			UIWidget uIWidget = mWidget;
			object obj = uIWidget - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S2_v11+BC] (should have been resolved before IL gen)");
		}
		if (mPanel != null)
		{
			UIPanel uIPanel = mPanel;
			object obj2 = uIPanel - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S2_v7+BC] (should have been resolved before IL gen)");
		}
	}
}
