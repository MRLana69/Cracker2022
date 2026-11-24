using System;
using Cpp2ILInjected;
using UnityEngine;

public class SaveMeAnimateClock : MonoBehaviour
{
	public UISprite clockSprite;

	public void FillSpriteAmount(float amount)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0152: Expected Obj, but got I4
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I4
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0073: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_0101: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 88;
		obj = 0;
		_ = 0;
		object obj3 = obj2 - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 48;
		Vector3 one = Vector3.one;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21+8]");
		_ = 0;
		GameObject gameObject = base.gameObject;
		Transform transform = (Transform)(obj2 + 100);
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		object obj6 = obj2 + 24;
		GameObject gameObject2 = base.gameObject;
		Vector2 pivotOffset = NGUIMath.GetPivotOffset((UIWidget.Pivot)gameObject2);
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+10]");
		_ = 0;
		object obj7 = obj2 + 12;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F49A");
		float num3 = (float)obj2 * 0.5f;
		float num4 = (float)obj7 - num3;
		float num5 = num4 + amount;
		obj = num5;
		GameObject gameObject3 = base.gameObject;
		transform = (Transform)obj;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform.eulerAngles;
	}

	public SaveMeAnimateClock()
	{
		_ = 1;
		CancelInvoke();
	}
}
