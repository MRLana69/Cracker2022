using Cpp2ILInjected;
using UnityEngine;

public class UIButtonMessage : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		OnDoubleClick
	}

	public GameObject target;

	public string functionName;

	public Trigger trigger;

	public bool includeChildren;

	private bool mStarted;

	private void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void OnEnable()
	{
		mStarted = true;
	}

	private unsafe void OnHover(bool isOver)
	{
		//IL_035e: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		//IL_0104: Expected I4, but got Obj
		//IL_0124: Expected F4, but got Obj
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_0165: Expected I4, but got Obj
		//IL_0185: Expected F4, but got Obj
		//IL_0277: Expected I, but got Obj
		//IL_028d: Expected Obj, but got I
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01c6: Expected I4, but got Obj
		//IL_01e6: Expected F4, but got Obj
		//IL_02b8: Expected I, but got Obj
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_0327: Expected I4, but got Obj
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected Obj, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected Obj, but got Unknown
		//IL_0227: Expected I4, but got Obj
		//IL_0247: Expected F4, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		int num3 = obj2 + 16;
		if (((ComputeShader)(object)target).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonMessage)+6C]");
		object obj3 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonMessage)+6C]");
		TweenHeight tweenHeight;
		if ((nint)0 != 1)
		{
			if ((nint)obj3 != 1)
			{
				if ((nint)obj3 == 2)
				{
					object obj4 = this - -64;
					object obj5 = this + 48;
					obj2 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S3_v24+8]");
					_ = 0;
					((int*)num3)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					tweenHeight = TweenHeight.Begin((UIWidget)(object)target, (float)obj4, num3);
				}
				else
				{
					object obj6 = this - -64;
					object obj7 = this + 84;
					obj2 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S3_v34+8]");
					_ = 0;
					((int*)num3)->m_value = (int)obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					_ = 0;
					tweenHeight = TweenHeight.Begin((UIWidget)(object)target, (float)obj6, num3);
				}
			}
			else
			{
				object obj8 = this - -64;
				object obj9 = this + 32;
				obj2 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S3_v14+8]");
				_ = 0;
				((int*)num3)->m_value = (int)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				tweenHeight = TweenHeight.Begin((UIWidget)(object)target, (float)obj8, num3);
			}
		}
		else
		{
			object obj10 = this - -64;
			object obj11 = this + 16;
			obj2 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S3_v4+8]");
			_ = 0;
			((int*)num3)->m_value = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			tweenHeight = TweenHeight.Begin((UIWidget)(object)target, (float)obj10, num3);
		}
		if (!isOver)
		{
			return;
		}
		nint num4 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num5 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenHeight).FindKernel((string)null) != 0)
		{
			object obj13 = tweenHeight + 104;
			obj2 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S1_v17+8]");
			_ = 0;
			((int*)num3)->m_value = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			tweenHeight.height = num3;
			tweenHeight.tag = null;
		}
	}

	private void OnPress(bool isPressed)
	{
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (isPressed)
		{
			if (trigger != Trigger.OnMouseOver)
			{
				return;
			}
		}
		else if (trigger != Trigger.OnMouseOut)
		{
			return;
		}
		this._002Ector();
	}

	private void OnSelect(bool isSelected)
	{
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (isSelected)
		{
			if (trigger != Trigger.OnPress)
			{
				return;
			}
		}
		else if (trigger != Trigger.OnRelease)
		{
			return;
		}
		this._002Ector();
	}

	private void OnClick()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00c0: Expected I4, but got Obj
		//IL_00ce: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		if (~(mStarted ? 1u : 0u) != 0)
		{
			return;
		}
		string text = tag;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera uICamera = UICamera.FindCameraForLayer((int)text);
		OnPress((byte)(int)uICamera != 0);
	}

	private void OnDoubleClick()
	{
		if (isActiveAndEnabled && trigger == Trigger.OnClick)
		{
			this._002Ector();
		}
	}

	private void Send()
	{
		if (isActiveAndEnabled && trigger == Trigger.OnDoubleClick)
		{
			this._002Ector();
		}
	}

	public UIButtonMessage()
	{
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		string text = functionName;
		if (functionName == null || text.m_stringLength == 0)
		{
			return;
		}
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (target != null)
		{
			object obj2 = this + 12;
			string text2 = tag;
			obj2 = text2;
		}
		if (~(includeChildren ? 1u : 0u) != 0)
		{
			string parameter = tag;
			target.BroadcastMessage(functionName, parameter, SendMessageOptions.DontRequireReceiver);
			return;
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v6 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v101 @ S3_v5 (should have been resolved before IL gen)");
		object obj7 = 0;
		object obj10 = default;
		while (true)
		{
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v20+C]");
			if ((nint)obj8 < 0)
			{
				object obj9 = obj10 + 16;
				object obj11 = obj7 << 2;
				object obj12 = obj9 + obj11;
				string text3 = ((Component)obj12).tag;
				string parameter2 = tag;
				((GameObject)(object)text3).BroadcastMessage(functionName, (object)parameter2, SendMessageOptions.DontRequireReceiver);
				object obj13 = obj7 + 1;
				obj7 = obj13;
				continue;
			}
			break;
		}
	}
}
