using Cpp2ILInjected;
using UnityEngine;

public class ScrollPanelPixelPerfect : MonoBehaviour
{
	private Transform _transform;

	private float _pixelFactor = 1f;

	private UIScrollView dragPanel;

	private void Start()
	{
		//IL_0037: Expected F4, but got I4
		Transform transform = base.transform;
		_transform = transform;
		UIRoot uIRoot = UIRoot.list.get_Item(0);
		int activeHeight = uIRoot.activeHeight;
		int height = Screen.height;
		int num = activeHeight / height;
		_pixelFactor = num;
		UIScrollView component = GetComponent<UIScrollView>();
		dragPanel = component;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		Vector3 localPosition = _transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
		float num = 0f * _pixelFactor;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		object obj3 = default;
		float num2 = (float)obj3 / _pixelFactor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
		float num3 = 0f - num2;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1BEF");
	}
}
