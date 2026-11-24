using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.MessageCenter;
using UnityEngine;

public class FriendsFooterNavigation : MonoBehaviour
{
	public List<UIButtonChangeScreen> buttons;

	private List<UITexture> _buttonHighlight;

	private int _selectedButton;

	private void OnEnable()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	private void Start()
	{
		Update();
	}

	private void Init()
	{
		Update();
	}

	private void Update()
	{
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		List<UIButtonChangeScreen> list = buttons;
		if (list._size == 0)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v18 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x1FFF;
			object obj4 = obj3 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S3_v9 (should have been resolved before IL gen)");
			object obj6 = default;
			object obj5 = obj6 + 12;
			object obj7 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj8 = obj6 + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
				object obj11 = obj7 + 1;
				obj7 = obj11;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list2 = default;
		list2._002Ector();
		object obj12 = this + 16;
		obj12 = list2;
		int num2 = 0;
		while (num2 <= 1)
		{
			UIButtonChangeScreen uIButtonChangeScreen = buttons.get_Item(num2);
			GameObject gameObject = uIButtonChangeScreen.gameObject;
			bool flag = ((Transform)(object)gameObject).IsChildOf((Transform)(object)"High");
			UITexture component = ((Component)flag).GetComponent<UITexture>();
			_buttonHighlight.Add(component);
			int num3 = num2 + 1;
			num2 = num3;
		}
		UITexture uITexture = _buttonHighlight.get_Item(0);
		uITexture.tag = null;
		UITexture uITexture2 = _buttonHighlight.get_Item(1);
		uITexture2.tag = (string)1;
		_selectedButton = 2;
	}

	public FriendsFooterNavigation()
	{
		//IL_0041: Expected Obj, but got I4
		//IL_0365: Expected Obj, but got I4
		//IL_038c: Expected Obj, but got I4
		//IL_0280: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_0103: Expected Obj, but got I4
		//IL_020f: Expected Obj, but got I4
		if (Input.GetMouseButtonUp(0))
		{
			int index = _selectedButton - 1;
			UITexture uITexture = _buttonHighlight.get_Item(index);
			uITexture.tag = null;
		}
		if (Input.GetKeyDown((string)276))
		{
			int selectedButton = ((_selectedButton <= 1) ? 2 : (_selectedButton - 1));
			_selectedButton = selectedButton;
			int num = 0;
			while (num <= 1)
			{
				object obj = _selectedButton - 1;
				bool flag = num == (nint)obj;
				UITexture uITexture2 = _buttonHighlight.get_Item(num);
				if (flag)
				{
					uITexture2.tag = (string)1;
					UIButtonChangeScreen uIButtonChangeScreen = buttons.get_Item(num);
					BoxCollider component = uIButtonChangeScreen.GetComponent<BoxCollider>();
					component.isTrigger = true;
				}
				else
				{
					uITexture2.tag = null;
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		if (Input.GetKeyDown((string)275))
		{
			int selectedButton2 = ((_selectedButton >= 2) ? 1 : (_selectedButton + 1));
			_selectedButton = selectedButton2;
			int num3 = 0;
			while (num3 <= 1)
			{
				object obj2 = _selectedButton - 1;
				bool flag2 = num3 == (nint)obj2;
				UITexture uITexture3 = _buttonHighlight.get_Item(num3);
				if (flag2)
				{
					uITexture3.tag = (string)1;
					UIButtonChangeScreen uIButtonChangeScreen2 = buttons.get_Item(num3);
					BoxCollider component2 = uIButtonChangeScreen2.GetComponent<BoxCollider>();
					component2.isTrigger = true;
				}
				else
				{
					uITexture3.tag = null;
				}
				int num4 = num3 + 1;
				num3 = num4;
			}
		}
		if (Input.GetKeyDown((string)13) || Input.GetKeyDown((string)32))
		{
			int index2 = _selectedButton - 1;
			UIButtonChangeScreen uIButtonChangeScreen3 = buttons.get_Item(index2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}
}
