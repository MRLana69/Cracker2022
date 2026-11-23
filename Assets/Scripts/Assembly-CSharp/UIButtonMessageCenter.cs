using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonMessageCenter : UIBasicButton
{
	private GameObject target;

	public string functionName;

	protected override void Send()
	{
		//IL_0088: Expected Obj, but got I4
		//IL_006c: Expected Obj, but got I4
		//IL_01d2: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		if (!enabled)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		string text = functionName;
		object obj;
		if (functionName != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_019d;
			}
		}
		obj = 1;
		goto IL_019d;
		IL_019d:
		if (obj != null)
		{
			return;
		}
		if (target == null && MessageCenter.IsInstanced)
		{
			MessageCenter instance = MessageCenter.Instance;
			GameObject gameObject2 = instance.gameObject;
			target = gameObject2;
		}
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		object obj2 = 0;
		object obj6 = default;
		while (true)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v26+C]");
			if ((nint)obj3 < 0)
			{
				object obj4 = obj2 << 2;
				object obj5 = obj6 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v32+10]");
				GameObject gameObject3 = ((Component)0).gameObject;
				GameObject value = base.gameObject;
				gameObject3.SendMessage(functionName, value, SendMessageOptions.DontRequireReceiver);
				object obj7 = obj2 + 1;
				obj2 = obj7;
				continue;
			}
			break;
		}
	}

	public void SendButton()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UIButtonMessageCenter>)+F4] (should have been resolved before IL gen)");
	}
}
