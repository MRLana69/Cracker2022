using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIKeyBinding : MonoBehaviour
{
	public enum Action
	{
		PressAndClick,
		Select,
		All
	}

	public enum Modifier
	{
		Any,
		Shift,
		Control,
		Alt,
		None
	}

	private static List<UIKeyBinding> mList;

	public KeyCode keyCode;

	public Modifier modifier;

	public Action action;

	[NonSerialized]
	private bool mIgnoreUp;

	[NonSerialized]
	private bool mIsInput;

	[NonSerialized]
	private bool mPress;

	public static bool IsBound(KeyCode key)
	{
		List<UIKeyBinding> list = mList;
		int num = 0;
		bool flag;
		while (true)
		{
			flag = num < list._size;
			if (!flag)
			{
				break;
			}
			UIKeyBinding uIKeyBinding = mList.get_Item(num);
			if (uIKeyBinding != null && uIKeyBinding.keyCode == key)
			{
				break;
			}
			int num2 = num + 1;
			num = num2;
		}
		return flag;
	}

	protected virtual void OnEnable()
	{
		mList.Add(this);
	}

	protected virtual void OnDisable()
	{
		bool flag = mList.Remove(this);
	}

	protected virtual void Start()
	{
		//IL_0052: Expected I, but got Obj
		UIInput component = GetComponent<UIInput>();
		bool flag = component != null;
		mIsInput = flag;
		if (component != null)
		{
			NullReferenceException ex = new NullReferenceException();
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (IntPtr)ex);
			EventDelegate eventDelegate = EventDelegate.Add(component.onSubmit, callback);
		}
	}

	protected virtual void OnSubmit()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (UICamera.mCurrentKey == keyCode)
		{
			object obj = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S1_v8+BC] (should have been resolved before IL gen)");
			object obj2 = default;
			if (obj2 != null)
			{
				mIgnoreUp = true;
			}
		}
	}

	protected virtual bool IsModifierActive()
	{
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected I4, but got Unknown
		bool flag = modifier == Modifier.Any;
		bool result = true;
		if (!flag)
		{
			if (modifier != Modifier.Shift)
			{
				if (modifier != Modifier.Control)
				{
					if (modifier != Modifier.Alt)
					{
						if (modifier != Modifier.None)
						{
							goto IL_01aa;
						}
						UICamera.GetKeyStateFunc getKey = UICamera.GetKey;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v150.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						result = false;
						object obj = default;
						if (obj == null)
						{
							UICamera.GetKeyStateFunc getKey2 = UICamera.GetKey;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v177.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							result = false;
							object obj2 = default;
							if (obj2 == null)
							{
								UICamera.GetKeyStateFunc getKey3 = UICamera.GetKey;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
								result = false;
								object obj3 = default;
								if (obj3 == null)
								{
									UICamera.GetKeyStateFunc getKey4 = UICamera.GetKey;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
									result = false;
									object obj4 = default;
									if (obj4 == null)
									{
										UICamera.GetKeyStateFunc getKey5 = UICamera.GetKey;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v204.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
										result = false;
										object obj5 = default;
										if (obj5 == null)
										{
											UICamera.GetKeyStateFunc getKey6 = UICamera.GetKey;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
											object obj6 = default;
											bool flag2 = (byte)(obj6 ^ 1) != 0;
											result = flag2;
										}
									}
								}
							}
						}
					}
					else
					{
						UICamera.GetKeyStateFunc getKey7 = UICamera.GetKey;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v133.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						result = true;
						object obj7 = default;
						if (obj7 == null)
						{
							UICamera.GetKeyStateFunc getKey8 = UICamera.GetKey;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v169.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
							object obj8 = default;
							if (obj8 == null)
							{
								goto IL_01aa;
							}
							result = true;
						}
					}
				}
				else
				{
					UICamera.GetKeyStateFunc getKey9 = UICamera.GetKey;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					result = true;
					object obj9 = default;
					if (obj9 == null)
					{
						UICamera.GetKeyStateFunc getKey10 = UICamera.GetKey;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						object obj10 = default;
						if (obj10 == null)
						{
							goto IL_01aa;
						}
						result = true;
					}
				}
			}
			else
			{
				UICamera.GetKeyStateFunc getKey11 = UICamera.GetKey;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v112.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				result = true;
				object obj11 = default;
				if (obj11 == null)
				{
					UICamera.GetKeyStateFunc getKey12 = UICamera.GetKey;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v142.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					result = true;
					object obj12 = default;
					if (obj12 == null)
					{
						goto IL_01aa;
					}
				}
			}
		}
		return result;
		IL_01aa:
		return false;
	}

	protected virtual void Update()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected Obj, but got Unknown
		//IL_02d6: Expected Obj, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected Obj, but got Unknown
		//IL_0132: Expected I, but got Obj
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0161: Expected I, but got Obj
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_017b: Expected I, but got Obj
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		if (UICamera.inputHasFocus || keyCode == KeyCode.None)
		{
			return;
		}
		object obj = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v5+BC] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		UICamera.GetKeyStateFunc getKeyDown = UICamera.GetKeyDown;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		UICamera.GetKeyStateFunc getKeyUp = UICamera.GetKeyUp;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		object obj3 = default;
		if (obj3 != null)
		{
			mPress = true;
		}
		if (this.action == Action.PressAndClick)
		{
			goto IL_0100;
		}
		bool flag = this.action == Action.Select;
		Action action = this.action;
		if (!flag)
		{
			if (this.action == Action.All)
			{
				goto IL_0100;
			}
			action = this.action;
		}
		goto IL_02ba;
		IL_0100:
		if (obj3 != null)
		{
			UICamera.currentKey = keyCode;
			nint num = (nint)this;
			object obj4 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ S2_v22 (Il2CppClass<UIKeyBinding>)+10C] (should have been resolved before IL gen)");
		}
		object obj6 = default;
		object obj5 = mPress & obj6;
		if (obj5 != null)
		{
			UICamera.currentKey = keyCode;
			nint num2 = (nint)this;
			object obj7 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v194 @ S2_v15 (Il2CppClass<UIKeyBinding>)+10C] (should have been resolved before IL gen)");
			nint num3 = (nint)this;
			object obj8 = this + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ S1_v31 (Il2CppClass<UIKeyBinding>)+114] (should have been resolved before IL gen)");
		}
		action = this.action;
		goto IL_02ba;
		IL_02ba:
		object obj9 = obj6 ^ 1;
		object obj10 = action - 1;
		bool flag2 = (nint)obj10 > 1;
		object obj11 = obj9 | flag2;
		if (obj11 == null)
		{
			if (~(mIsInput ? 1u : 0u) == 0)
			{
				if (!mIgnoreUp && !UICamera.inputHasFocus && ~(mPress ? 1u : 0u) == 0)
				{
					GameObject selectedObject = gameObject;
					UICamera.selectedObject = selectedObject;
				}
				mIgnoreUp = false;
			}
			else if (~(mPress ? 1u : 0u) == 0)
			{
				GameObject hoveredObject = gameObject;
				UICamera.hoveredObject = hoveredObject;
			}
		}
		if (obj6 != null)
		{
			mPress = false;
		}
	}

	protected virtual void OnBindingPress(bool pressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		GameObject go = gameObject;
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object obj4 = default;
		UICamera.Notify(go, "OnPress", obj4);
	}

	protected virtual void OnBindingClick()
	{
		GameObject go = gameObject;
		UICamera.Notify(go, "OnClick", null);
	}

	static UIKeyBinding()
	{
		List<UIKeyBinding> list = default;
		list._002Ector();
		mList = list;
	}
}
