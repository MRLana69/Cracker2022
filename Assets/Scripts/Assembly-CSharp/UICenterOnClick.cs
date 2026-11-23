using Cpp2ILInjected;
using UnityEngine;

public class UICenterOnClick : MonoBehaviour
{
	private unsafe void OnClick()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected VT, but got Unknown
		//IL_028c: Expected Obj, but got I
		//IL_0258: Expected Obj, but got I
		//IL_03a4: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I4
		//IL_022b: Invalid comparison between VT and F4
		//IL_034b: Expected Obj, but got I
		//IL_0317: Expected Obj, but got I
		//IL_042f: Expected F4, but got I
		//IL_042a: Expected native int or pointer, but got VT
		//IL_044e: Expected F4, but got I
		//IL_0449: Expected native int or pointer, but got VT
		//IL_02ea: Invalid comparison between I and F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		GameObject go = gameObject;
		UICenterOnChild uICenterOnChild = NGUITools.FindInParents<UICenterOnChild>(go);
		GameObject go2 = gameObject;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>(go2);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				Transform target = base.transform;
				uICenterOnChild.CenterOn(target);
			}
			return;
		}
		if (!(uIPanel != null) || uIPanel.mClipping == UIDrawCall.Clipping.None)
		{
			return;
		}
		UIScrollView component = uIPanel.GetComponent<UIScrollView>();
		Transform cachedTransform = uIPanel.cachedTransform;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 position2 = vector + 16;
		Vector3 vector2 = cachedTransform.InverseTransformPoint(position2);
		bool flag = component.movement == UIScrollView.Movement.Horizontal;
		bool flag2 = true;
		bool flag4;
		if (!flag)
		{
			if (component.movement != UIScrollView.Movement.Vertical)
			{
				bool flag3 = component.movement == UIScrollView.Movement.Unrestricted;
				flag2 = true;
				if (flag3)
				{
					goto IL_036d;
				}
				if (component.movement == UIScrollView.Movement.Custom)
				{
					flag4 = component.customMovement != (Vector2)(object)0f;
					goto IL_037a;
				}
			}
			flag2 = false;
		}
		goto IL_036d;
		IL_036d:
		flag4 = flag2;
		goto IL_037a;
		IL_03ef:
		bool flag5;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj2 = -0;
		}
		else
		{
			Transform cachedTransform2 = uIPanel.cachedTransform;
			Vector3 localPosition = cachedTransform2.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+44]");
			object obj2 = 0;
		}
		GameObject cachedGameObject = uIPanel.cachedGameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		SpringPanel springPanel = SpringPanel.Begin(cachedGameObject, vector, 6f);
		return;
		IL_037a:
		if (flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj3 = -0;
		}
		else
		{
			Transform cachedTransform3 = uIPanel.cachedTransform;
			Vector3 localPosition2 = cachedTransform3.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			object obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		object obj4 = -0;
		object obj5 = component.movement - 1;
		bool flag6 = component.movement == UIScrollView.Movement.Vertical;
		bool flag7 = true;
		if (!flag6)
		{
			bool flag8 = (nint)obj5 == 1;
			flag7 = true;
			if (!flag8)
			{
				if ((nint)obj5 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v32 (UIScrollView)+34]");
					flag5 = 0f != 0f;
					goto IL_03ef;
				}
				flag7 = false;
			}
		}
		flag5 = flag7;
		goto IL_03ef;
	}
}
