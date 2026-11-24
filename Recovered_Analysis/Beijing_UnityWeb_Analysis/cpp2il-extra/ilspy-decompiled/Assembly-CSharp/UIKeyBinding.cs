using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.LocalizationManager;
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

	public string captionText
	{
		get
		{
			//IL_009b: Expected I, but got Obj
			//IL_00b1: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0067: Expected Obj, but got I4
			string text = tag;
			Collider component = ((GameObject)(object)text).GetComponent<Collider>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
			{
				bool isTrigger = component.isTrigger;
				return (string)isTrigger;
			}
			return null;
		}
	}

	public static bool IsBound(KeyCode key)
	{
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_015e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f6: Expected I4, but got Obj
		//IL_014d: Expected I4, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L0 (UnityEngine.KeyCode)+C]");
		Component target = ((PropertyReference)0).target;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L0 (UnityEngine.KeyCode)+10]");
		object values;
		string text;
		if ((nint)0 == 3)
		{
			values = "Alt+";
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L0 (UnityEngine.KeyCode)+10]");
			if ((nint)0 == 2)
			{
				values = "Control+";
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [key @ L0 (UnityEngine.KeyCode)+10]");
				if ((nint)0 != 1)
				{
					text = (string)(object)target;
					goto IL_0148;
				}
				values = "Shift+";
			}
		}
		string text2 = string.ConcatArray((string[])values, (int)target);
		text = text2;
		goto IL_0148;
		IL_0148:
		return (byte)(int)text != 0;
	}

	protected virtual void OnEnable()
	{
		_ = 1;
		CancelInvoke();
	}

	protected virtual void OnDisable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyBinding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIKeyBinding>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyBinding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIKeyBinding>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}

	protected virtual void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyBinding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIKeyBinding>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyBinding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIKeyBinding>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
	}

	protected virtual void OnSubmit()
	{
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00e6: Expected I, but got Obj
		UIInput component = GetComponent<UIInput>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)(object)component).FindKernel((string)null);
		int num4 = num3 & 1;
		mIsInput = (byte)num4 != 0;
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = new NullReferenceException();
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = (IntPtr)ex;
		((Delegate)callback).method = (IntPtr)ex;
		object obj2 = callback + 16;
		obj2 = this;
		nint num5 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v17 (Il2CppClass<EventDelegate>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v22 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(component.onSubmit, callback);
	}

	protected virtual bool IsModifierActive()
	{
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_01d8: Expected I, but got Obj
		//IL_01ee: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyBinding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIKeyBinding>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyBinding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<UIKeyBinding>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<UIKeyBinding> list = mList;
		int num3 = default;
		int num8 = default;
		while (true)
		{
			if (num3 >= list._size)
			{
				return false;
			}
			nint num4 = (nint)typeof(UIKeyBinding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v22 (Il2CppClass<UIKeyBinding>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UIKeyBinding);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v48 (Il2CppClass<UIKeyBinding>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIKeyBinding uIKeyBinding = mList.get_Item(num3);
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIKeyBinding).FindKernel((string)null) != 0 && (nint)uIKeyBinding.keyCode == (nint)this)
			{
				break;
			}
			num3 = num8 + 1;
		}
		return true;
	}

	public static bool IsModifierActive(Modifier modifier)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00a8: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyBinding);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UIKeyBinding>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyBinding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UIKeyBinding>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [modifier @ L0 (UIKeyBinding+Modifier)+10]");
		return (byte)(int)((UIKeyBinding)0).ToString() != 0;
	}

	protected virtual void Update()
	{
		//IL_0097: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BE6");
		object obj2 = default;
		if ((nint)obj2 == (nint)keyCode)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj3 = default;
			if (obj3 != null)
			{
				mIgnoreUp = true;
			}
		}
	}

	protected virtual void OnBindingPress(bool pressed)
	{
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I4
		KeyCode keyCode = this.keyCode;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (UnityEngine.KeyCode)+18C]");
		if ((UnityEngine.Object)0 != null)
		{
			return;
		}
		KeyCode keyCode2 = this.keyCode;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (UnityEngine.KeyCode)+18C]");
		string randomSprite = ((UIAtlas)0).GetRandomSprite((string)pressed);
		if (randomSprite != null)
		{
			((UISprite)this.keyCode).fillCenter = pressed;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIKeyBinding)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	protected virtual void OnBindingClick()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_0102: Expected Obj, but got I
		//IL_0606: Expected Obj, but got I4
		//IL_061a: Expected Obj, but got I4
		//IL_012d: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I4
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_074c: Expected Obj, but got I4
		//IL_0754: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected Obj, but got Unknown
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_02d4: Expected I, but got Obj
		//IL_0390: Expected I, but got Obj
		//IL_03a6: Expected Obj, but got I
		//IL_046f: Expected I, but got Obj
		//IL_0485: Expected Obj, but got I
		//IL_0520: Expected I, but got Obj
		//IL_0536: Expected Obj, but got I
		//IL_03d1: Expected I, but got Obj
		//IL_04b0: Expected I, but got Obj
		//IL_0561: Expected I, but got Obj
		if (keyCode != KeyCode.Numlock)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v128 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v135 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject genericEventHandler = UICamera.genericEventHandler;
			if ((object)genericEventHandler != null)
			{
				return;
			}
		}
		if (keyCode == KeyCode.None)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v15 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v121 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UICamera.GetKeyDown.EndInvoke((IAsyncResult)keyCode);
		bool flag2 = UICamera.GetKeyUp.EndInvoke((IAsyncResult)keyCode);
		if (flag)
		{
			mPress = true;
		}
		if (action == Action.PressAndClick || action == Action.All)
		{
			if (flag)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v102 (Il2CppClass<UICamera>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v111 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.currentTouchID = -1;
				Ray currentRay = UICamera.currentRay;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			bool flag3 = mPress;
			object obj5 = flag2 & flag3;
			if (obj5 != null)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v85 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v95 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.currentTouchID = -1;
				Ray currentRay2 = UICamera.currentRay;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
		if (action == Action.Select)
		{
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			bool flag4 = action != Action.All;
			object obj7 = (flag2 ? 1 : 0) ^ 1;
			object obj8 = flag4 | obj7;
			if (obj8 != null)
			{
				goto IL_06ce;
			}
		}
		if (~(mIsInput ? 1u : 0u) != 0)
		{
			if (~(mPress ? 1u : 0u) == 0)
			{
				string controllerNavigationObject = tag;
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v38 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S1_v43 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.controllerNavigationObject = (GameObject)(object)controllerNavigationObject;
			}
			goto IL_06ce;
		}
		if (~(mIgnoreUp ? 1u : 0u) != 0)
		{
			if (keyCode != KeyCode.Numlock)
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v63 (Il2CppClass<UICamera>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v69 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameObject genericEventHandler2 = UICamera.genericEventHandler;
				if ((object)genericEventHandler2 != null)
				{
					goto IL_070c;
				}
			}
			if (~(mPress ? 1u : 0u) == 0)
			{
				string touch = tag;
				nint num13 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v26 (Il2CppClass<UICamera>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ S1_v31 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.Raycast((UICamera.MouseOrTouch)(object)touch);
			}
		}
		goto IL_070c;
		IL_06ce:
		if (flag2)
		{
			mPress = false;
		}
		return;
		IL_070c:
		mIgnoreUp = false;
		goto IL_06ce;
	}

	public override string ToString()
	{
		//IL_007b: Expected Obj, but got I4
		//IL_02e2: Expected I, but got Obj
		//IL_02f8: Expected Obj, but got I
		//IL_0882: Expected Obj, but got I4
		//IL_03f9: Expected Obj, but got I4
		//IL_0323: Expected I, but got Obj
		//IL_01b8: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0370: Expected I, but got Obj
		//IL_0386: Expected Obj, but got I
		//IL_081f: Expected Obj, but got I4
		//IL_08b9: Expected Obj, but got I4
		//IL_02cf: Expected Obj, but got I4
		//IL_01f9: Expected I, but got Obj
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_03b1: Expected I, but got Obj
		//IL_0246: Expected I, but got Obj
		//IL_025c: Expected Obj, but got I
		//IL_07bc: Expected Obj, but got I4
		//IL_0856: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_00cf: Expected I, but got Obj
		//IL_040c: Expected I, but got Obj
		//IL_0422: Expected Obj, but got I
		//IL_0287: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_08e5: Expected Obj, but got I4
		//IL_07f3: Expected Obj, but got I4
		//IL_04a4: Expected I, but got Obj
		//IL_04ba: Expected Obj, but got I
		//IL_044d: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_0916: Expected Obj, but got I4
		//IL_053c: Expected I, but got Obj
		//IL_0552: Expected Obj, but got I
		//IL_04e5: Expected I, but got Obj
		//IL_0942: Expected Obj, but got I4
		//IL_05d4: Expected I, but got Obj
		//IL_05ea: Expected Obj, but got I
		//IL_057d: Expected I, but got Obj
		//IL_096e: Expected Obj, but got I4
		//IL_066c: Expected I, but got Obj
		//IL_0682: Expected Obj, but got I
		//IL_0615: Expected I, but got Obj
		//IL_099a: Expected Obj, but got I4
		//IL_0704: Expected I, but got Obj
		//IL_071a: Expected Obj, but got I
		//IL_06ad: Expected I, but got Obj
		//IL_09c6: Expected Obj, but got I4
		//IL_09d8: Expected Obj, but got I4
		//IL_0745: Expected I, but got Obj
		if ((object)this != null)
		{
			if ((nint)this != 1)
			{
				if ((nint)this != 2)
				{
					if ((nint)this != 3)
					{
						if ((nint)this != 4)
						{
							goto IL_0784;
						}
						nint num = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v113 (Il2CppClass<UICamera>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v203 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.GetKey.EndInvoke((IAsyncResult)308))
						{
							return null;
						}
						nint num3 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v123 (Il2CppClass<UICamera>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v196 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.GetKey.EndInvoke((IAsyncResult)307))
						{
							return null;
						}
						nint num5 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S0_v132 (Il2CppClass<UICamera>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num6 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v189 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.GetKey.EndInvoke((IAsyncResult)306))
						{
							return null;
						}
						nint num7 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v141 (Il2CppClass<UICamera>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v182 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.GetKey.EndInvoke((IAsyncResult)305))
						{
							return null;
						}
						nint num9 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ S0_v150 (Il2CppClass<UICamera>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num10 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v175 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.GetKey.EndInvoke((IAsyncResult)304))
						{
							return null;
						}
						nint num11 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v159 (Il2CppClass<UICamera>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num12 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v168 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						bool flag = UICamera.GetKey.EndInvoke((IAsyncResult)303);
						return (string)((flag ? 1 : 0) ^ 1);
					}
					nint num13 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v79 (Il2CppClass<UICamera>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num14 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v106 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!UICamera.GetKey.EndInvoke((IAsyncResult)308))
					{
						nint num15 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v91 (Il2CppClass<UICamera>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num16 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v100 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (!UICamera.GetKey.EndInvoke((IAsyncResult)307))
						{
							goto IL_0784;
						}
					}
					return (string)1;
				}
				nint num17 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v45 (Il2CppClass<UICamera>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num18 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v72 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UICamera.GetKey.EndInvoke((IAsyncResult)306))
				{
					nint num19 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v57 (Il2CppClass<UICamera>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num20 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v66 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!UICamera.GetKey.EndInvoke((IAsyncResult)305))
					{
						goto IL_0784;
					}
				}
				return (string)1;
			}
			nint num21 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num22 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v38 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UICamera.GetKey.EndInvoke((IAsyncResult)304))
			{
				nint num23 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v23 (Il2CppClass<UICamera>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num24 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v32 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UICamera.GetKey.EndInvoke((IAsyncResult)303))
				{
					goto IL_0784;
				}
			}
			return (string)1;
		}
		return (string)1;
		IL_0784:
		return null;
	}

	public static string GetString(KeyCode keyCode, Modifier modifier)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0038: Expected VT, but got I4
		//IL_0057: Expected VT, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		Transform transform = default;
		object obj = transform + 24;
		obj = 0;
		_ = 0;
		Transform transform2 = (Transform)(transform + 12);
		transform2.localPosition = (Vector3)modifier;
		obj = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		transform.localPosition = (Vector3)keyCode;
		object obj2 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D9CC");
		string result = default;
		return result;
	}

	public unsafe static bool GetKeyCode(string text, out KeyCode key, out Modifier modifier)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got Ref
		//IL_004f: Expected Obj, but got I4
		//IL_0057: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = text;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref key);
		object obj3 = (flag ? 1 : 0) + 28;
		obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref modifier);
		return flag;
	}

	public static Modifier GetActiveModifier()
	{
		LocaleData instance = LocaleData.instance;
		return ((Locale)(object)instance).IsValid() ? Modifier.Shift : Modifier.Any;
	}

	public UIKeyBinding()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00b0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		string text = tag;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v10 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UICamera)(object)text).ProcessTouch((byte)(int)"OnClick" != 0, false);
	}

	static UIKeyBinding()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<UIDragDropItem> draggedItems = default;
		UIDragDropItem.draggedItems = draggedItems;
	}
}
