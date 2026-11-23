using Cpp2ILInjected;
using UnityEngine;

public class GenericResolutionSwitchHelper : MonoBehaviour
{
	public string highResName;

	private bool _inited;

	private void Start()
	{
		if (~(_inited ? 1u : 0u) != 0)
		{
			Init();
		}
	}

	private unsafe void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected VT, but got Unknown
		//IL_0115: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I
		//IL_018c: Expected F4, but got I
		//IL_0187: Expected native int or pointer, but got VT
		//IL_01ab: Expected F4, but got I
		//IL_01a6: Expected native int or pointer, but got VT
		//IL_0246: Expected Obj, but got I
		//IL_0299: Expected Obj, but got I
		//IL_031d: Expected Obj, but got I
		//IL_0370: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		TweenTransform component4;
		do
		{
			_inited = true;
			DeviceInfo instance = DeviceInfo.Instance;
			if (~(instance.isHighres__BackingField ? 1u : 0u) == 0)
			{
				UISprite component = GetComponent<UISprite>();
				component.spriteName = highResName;
				Transform transform = base.transform;
				Transform parent = transform.parent;
				_ = 1065353216;
				_ = 1065353216;
				_ = 4539628425446424576L;
				_ = 4539628425446424576L;
				Vector3 localScale = vector + 16;
				parent.localScale = localScale;
				int width = ((UIWidget)component).mWidth << 1;
				component.width = width;
				int height = ((UIWidget)component).mHeight << 1;
				component.height = height;
				Transform transform2 = base.transform;
				Transform transform3 = base.transform;
				Vector3 localPosition = transform3.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				object obj2 = num + 0;
				Transform transform4 = base.transform;
				Vector3 localPosition2 = transform4.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+34]");
				object obj3 = num2 + 0;
				Transform transform5 = base.transform;
				Vector3 localPosition3 = transform5.localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				transform2.localPosition = vector;
				Transform transform6 = base.transform;
				GameObject gameObject = transform6.gameObject;
				TweenScale component2 = gameObject.GetComponent<TweenScale>();
				if (component2 != null)
				{
					Vector3 vector2 = component2.from + component2.from;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (TweenScale)+54]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (TweenScale)+54]");
					object obj4 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (TweenScale)+58]");
					_ = 0;
					component2.from = vector2;
					Vector3 to = component2.to + component2.to;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (TweenScale)+60]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (TweenScale)+60]");
					object obj5 = num4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (TweenScale)+64]");
					_ = 0;
					component2.to = to;
				}
				Transform transform7 = base.transform;
				GameObject gameObject2 = transform7.gameObject;
				TweenPosition component3 = gameObject2.GetComponent<TweenPosition>();
				if (component3 != null)
				{
					Vector3 vector3 = component3.from + component3.from;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v61 (TweenPosition)+54]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v61 (TweenPosition)+54]");
					object obj6 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v61 (TweenPosition)+58]");
					_ = 0;
					component3.from = vector3;
					Vector3 to2 = component3.to + component3.to;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v61 (TweenPosition)+60]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v61 (TweenPosition)+60]");
					object obj7 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v61 (TweenPosition)+64]");
					_ = 0;
					component3.to = to2;
				}
				Transform transform8 = base.transform;
				GameObject gameObject3 = transform8.gameObject;
				component4 = gameObject3.GetComponent<TweenTransform>();
				continue;
			}
			break;
		}
		while (component4 != null);
	}
}
