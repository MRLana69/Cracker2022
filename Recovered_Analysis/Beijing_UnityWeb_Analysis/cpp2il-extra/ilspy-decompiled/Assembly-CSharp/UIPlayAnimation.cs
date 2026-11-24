using System;
using System.Collections;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class UIPlayAnimation : MonoBehaviour
{
	public static UIPlayAnimation current;

	public Animation target;

	public Animator animator;

	public string clipName;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool clearSelection;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public List<EventDelegate> onFinished;

	private GameObject eventReceiver;

	private string callWhenFinished;

	private bool mStarted;

	private bool mActivated;

	private bool dragHighlight;

	private bool dualState
	{
		get
		{
			//IL_016d: Expected I, but got Obj
			//IL_0183: Expected Obj, but got I
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_005c: Expected I4, but got Obj
			//IL_00df: Expected I, but got Obj
			//IL_00f5: Expected Obj, but got I
			//IL_01eb: Expected I4, but got Obj
			//IL_0120: Expected I, but got Obj
			nint num = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UIKeyNavigation>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIKeyNavigation);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v22 (Il2CppClass<UIKeyNavigation>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			UILabel uILabel = (UILabel)(obj2 + 12);
			GameObject left = ((UIKeyNavigation)(object)clipName).GetLeft();
			if ((object)left != null)
			{
				return (byte)(int)clipName != 0;
			}
			if ((nint)target == 2)
			{
				return false;
			}
			if ((nint)target == 3)
			{
				return false;
			}
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 left2 = Vector3.left;
			uILabel = (UILabel)obj2;
			UILabel uILabel2 = uILabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)uILabel2).m_CachedPtr = (IntPtr)0;
			IEnumerator enumerator = ((CelebrationPopup)this).AnimateAlpha(uILabel, 2f, 1f);
			return (byte)(int)enumerator != 0;
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	private void Start()
	{
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_021a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		//IL_00d3: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I
		//IL_0114: Expected I, but got Obj
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_017b: Expected Obj, but got I4
		UIButton component = GetComponent<UIButton>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			bool flag = component.dragHighlight;
			dragHighlight = flag;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v15 (Il2CppClass<EventDelegate>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v24 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Localization.LoadAndSelect((string)(object)onFinished))
		{
			object obj4 = this + 48;
			obj4 = 0;
			object obj5 = this + 52;
			obj5 = 0;
		}
	}

	private void OnEnable()
	{
		//IL_02dc: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got I
		//IL_031d: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_019b: Expected I, but got Obj
		//IL_01b1: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_03b1: Expected I, but got Obj
		//IL_03c7: Expected Obj, but got I
		//IL_01dc: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_024b: Expected I, but got Obj
		mStarted = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (target != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (animator != null)
			{
				object obj3 = this + 16;
				_0021_00210[] componentsInChildren = (_0021_00210[])(object)((Component)this).GetComponentsInChildren<T>();
				obj3 = componentsInChildren;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)animator).FindKernel((string)null) != 0)
		{
			if (animator.isActiveAndEnabled)
			{
				animator.tag = null;
			}
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (target != null)
		{
			object obj6 = this + 12;
			Animation componentInChildren = GetComponentInChildren<Animation>();
			obj6 = componentInChildren;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)target).FindKernel((string)null) != 0 && target.isActiveAndEnabled)
		{
			target.tag = null;
		}
	}

	private unsafe void OnDisable()
	{
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0572: Expected I, but got Obj
		//IL_0588: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0483: Expected I4, but got Obj
		//IL_0491: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		//IL_0354: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03e0: Expected I, but got Obj
		//IL_03f6: Expected Obj, but got I
		//IL_0502: Expected I, but got Obj
		//IL_0518: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_0421: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0279: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		//IL_05c6: Expected I, but got Obj
		//IL_05dc: Expected Obj, but got I
		//IL_02ba: Expected I, but got Obj
		//IL_0307: Expected I, but got Obj
		if (~(mStarted ? 1u : 0u) == 0)
		{
			string text = tag;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v112 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v117 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera = UICamera.FindCameraForLayer((int)text);
			OnPress((byte)(int)uICamera != 0);
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v103 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouch != null)
		{
			if (trigger == Trigger.OnPress || trigger == Trigger.OnPressTrue)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v74 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v94 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
				string text2 = tag;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v85 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v90 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = currentTouch.pressed != (UnityEngine.Object)(object)text2;
				mActivated = flag;
			}
			if (trigger == Trigger.OnHover || trigger == Trigger.OnHoverTrue)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v43 (Il2CppClass<UICamera>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v63 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
				string text3 = tag;
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = currentTouch2.current != (UnityEngine.Object)(object)text3;
				mActivated = flag2;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventDelegate.Callback callback = default;
		((Delegate)callback).method_ptr = method_ptr;
		((Delegate)callback).method = (nint)__ldftn(UIPlayAnimation.OnToggle);
		object obj8 = callback + 16;
		obj8 = this;
		nint num15 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v17 (Il2CppClass<EventDelegate>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num16 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S1_v22 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = EventDelegate.Remove(component.onChange, callback);
	}

	private void OnHover(bool isOver)
	{
		//IL_0726: Expected I, but got Obj
		//IL_073c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0138: Expected I, but got Obj
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_07cb: Expected Obj, but got I4
		//IL_0597: Expected Obj, but got I4
		//IL_01c6: Expected I, but got Obj
		//IL_09be: Expected I, but got Obj
		//IL_09d4: Expected Obj, but got I
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_07f7: Expected Obj, but got I4
		//IL_05aa: Expected I, but got Obj
		//IL_0837: Expected I, but got Obj
		//IL_084d: Expected Obj, but got I
		//IL_0254: Expected I, but got Obj
		//IL_05f7: Expected I, but got Obj
		//IL_060d: Expected Obj, but got I
		//IL_02a1: Expected I, but got Obj
		//IL_02b7: Expected Obj, but got I
		//IL_0a2e: Expected I, but got Obj
		//IL_0a44: Expected Obj, but got I
		//IL_046a: Expected I, but got Obj
		//IL_0879: Expected Obj, but got I4
		//IL_0685: Expected I, but got Obj
		//IL_069b: Expected Obj, but got I
		//IL_0638: Expected I, but got Obj
		//IL_0b74: Expected I4, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_0a6f: Expected I, but got Obj
		//IL_0a85: Expected Obj, but got I
		//IL_04ce: Expected I, but got Obj
		//IL_0339: Expected I, but got Obj
		//IL_034f: Expected Obj, but got I
		//IL_06c6: Expected I, but got Obj
		//IL_0b8c: Expected Obj, but got I4
		//IL_08c2: Expected I4, but got Obj
		//IL_0588: Expected Obj, but got I4
		//IL_0532: Expected I, but got Obj
		//IL_08de: Expected I, but got Obj
		//IL_08f4: Expected Obj, but got I
		//IL_037a: Expected I, but got Obj
		//IL_091b: Expected Obj, but got I4
		//IL_0932: Expected Obj, but got I4
		//IL_094e: Expected I, but got Obj
		//IL_0964: Expected Obj, but got I
		//IL_03de: Expected I, but got Obj
		//IL_0428: Expected I, but got Obj
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v215 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string[]> dictionary = Localization.dictionary;
		if (dictionary != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v209 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int renderedFrameCount = Time.renderedFrameCount;
		if (UIKeyNavigation.mLastFrame == renderedFrameCount)
		{
			return;
		}
		int renderedFrameCount2 = Time.renderedFrameCount;
		nint num5 = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v26 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v203 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIKeyNavigation.mLastFrame = renderedFrameCount2;
		if ((isOver ? 1 : 0) != 9)
		{
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v199 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject2;
		if ((UnityEngine.Object)ifDisabledOnPlay != null)
		{
			nint num9 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v82 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v193 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UICamera.GetKey.EndInvoke((IAsyncResult)304))
			{
				nint num11 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v138 (Il2CppClass<UICamera>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num12 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v187 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!UICamera.GetKey.EndInvoke((IAsyncResult)303))
				{
					GameObject up = ((UIKeyNavigation)this).GetUp();
					nint num13 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v150 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num14 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v183 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = up != null;
					bool flag2 = !flag;
					bool flag3 = (byte)(int)up != 0;
					if (!flag2)
					{
						bool flag4 = dualState;
						flag3 = flag4;
					}
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S0_v158 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num16 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ S0_v178 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag5 = (UnityEngine.Object)flag3 != null;
					bool flag6 = !flag5;
					GameObject gameObject = (GameObject)flag3;
					if (!flag6)
					{
						GameObject down = ((UIKeyNavigation)this).GetDown();
						gameObject = down;
					}
					nint num17 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v166 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num18 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v173 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag7 = gameObject != null;
					bool flag8 = !flag7;
					gameObject2 = gameObject;
					if (!flag8)
					{
						gameObject2 = ((UIKeyNavigation)this).GetRight();
					}
					goto IL_09b0;
				}
			}
			GameObject right = ((UIKeyNavigation)this).GetRight();
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v133 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag9 = right != null;
			bool flag10 = !flag9;
			GameObject gameObject3 = right;
			if (!flag10)
			{
				GameObject down2 = ((UIKeyNavigation)this).GetDown();
				gameObject3 = down2;
			}
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v103 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num22 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag11 = gameObject3 != null;
			bool flag12 = !flag11;
			bool flag13 = (byte)(int)gameObject3 != 0;
			if (!flag12)
			{
				bool flag14 = dualState;
				flag13 = flag14;
			}
			nint num23 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num24 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v121 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gameObject2 = ((!((UnityEngine.Object)flag13 != null)) ? ((GameObject)flag13) : ((UIKeyNavigation)this).GetUp());
		}
		else
		{
			gameObject2 = (GameObject)ifDisabledOnPlay;
		}
		goto IL_09b0;
		IL_09b0:
		nint num25 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num26 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v76 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)gameObject2).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num27 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v52 (Il2CppClass<UICamera>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num28 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S0_v72 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.currentKey = (KeyCode)2;
		UICamera.controllerNavigationObject = gameObject2;
		UIInput component = gameObject2.GetComponent<UIInput>();
		nint num29 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v61 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num30 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			component.cursorPosition = 1;
		}
	}

	private void OnPress(bool isPressed)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (trigger != Trigger.OnHover)
		{
			bool flag = trigger == Trigger.OnHoverTrue;
			object obj = flag & isPressed;
			if (obj == null)
			{
				bool flag2 = trigger != Trigger.OnHoverFalse;
				object obj2 = flag2 | isPressed;
				if (obj2 != null)
				{
					return;
				}
			}
		}
		bool isOver = trigger == Trigger.OnPress || trigger == Trigger.OnHover;
		((UIPlayTween)this).CustomHoverListener((GameObject)isPressed, isOver);
	}

	private void OnClick()
	{
		//IL_0134: Expected I, but got Obj
		//IL_014a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_009b: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I
		//IL_00dc: Expected I, but got Obj
		UIToggle component = GetComponent<UIToggle>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		EventDelegate eventDelegate = default;
		eventDelegate.mTarget = (MonoBehaviour)num3;
		eventDelegate.oneShot = false;
		object obj2 = eventDelegate + 16;
		obj2 = this;
		nint num4 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v14 (Il2CppClass<EventDelegate>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v19 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = EventDelegate.Remove(component.onChange, eventDelegate);
	}

	private void OnDoubleClick()
	{
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I4
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -2)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID != -3 && isActiveAndEnabled && trigger == Trigger.OnClick)
		{
			((UIPlayTween)this).CustomHoverListener((GameObject)1, false);
		}
	}

	private void OnSelect(bool isSelected)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I4
		//IL_029b: Expected Obj, but got I4
		//IL_01b5: Expected Obj, but got I4
		if (!isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v46 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -2)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v40 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -3)
		{
			return;
		}
		if (trigger != Trigger.OnPress)
		{
			bool flag = trigger == Trigger.OnPressTrue;
			object obj3 = flag & isSelected;
			if (obj3 == null)
			{
				bool flag2 = trigger != Trigger.OnPressFalse;
				object obj4 = flag2 | isSelected;
				if (obj4 != null)
				{
					return;
				}
			}
		}
		bool isOver = trigger == Trigger.OnPress || trigger == Trigger.OnHover;
		((UIPlayTween)this).CustomHoverListener((GameObject)isSelected, isOver);
	}

	private void OnToggle()
	{
		//IL_0150: Expected I, but got Obj
		//IL_0166: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I4
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID == -2)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouchID != -3 && isActiveAndEnabled && trigger == Trigger.OnDoubleClick)
		{
			((UIPlayTween)this).CustomHoverListener((GameObject)1, false);
		}
	}

	private void OnDragOver()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03a7: Expected I, but got Obj
		//IL_03bd: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_04e4: Expected I, but got Obj
		//IL_04fa: Expected Obj, but got I
		//IL_034d: Expected Obj, but got I4
		//IL_02cb: Expected I, but got Obj
		//IL_0329: Expected Obj, but got I4
		//IL_0145: Expected I, but got Obj
		//IL_015b: Expected Obj, but got I
		//IL_0219: Expected I, but got Obj
		//IL_022f: Expected Obj, but got I
		//IL_0186: Expected I, but got Obj
		//IL_025a: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		nint num = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UIToggle>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v81 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UIToggle.current != null)
		{
			return;
		}
		if (trigger != Trigger.OnActivate)
		{
			if (trigger == Trigger.OnActivateTrue)
			{
				nint num5 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v62 (Il2CppClass<UIToggle>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v75 (Il2CppClass<UIToggle>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIToggle uIToggle = UIToggle.current;
				if ((~(uIToggle.mStarted ? 1u : 0u) != 0) ? uIToggle.startsActive : uIToggle.mIsActive)
				{
					goto IL_04d6;
				}
			}
			if (trigger != Trigger.OnActivateFalse)
			{
				return;
			}
			nint num7 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v42 (Il2CppClass<UIToggle>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v55 (Il2CppClass<UIToggle>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIToggle uIToggle2 = UIToggle.current;
			if ((~(uIToggle2.mStarted ? 1u : 0u) != 0) ? uIToggle2.startsActive : uIToggle2.mIsActive)
			{
				return;
			}
		}
		goto IL_04d6;
		IL_04d6:
		nint num9 = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v23 (Il2CppClass<UIToggle>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v28 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIToggle uIToggle3 = UIToggle.current;
		GameObject go;
		if (~(uIToggle3.mStarted ? 1u : 0u) == 0)
		{
			bool mIsActive = uIToggle3.mIsActive;
			go = (GameObject)mIsActive;
		}
		else
		{
			bool startsActive = uIToggle3.startsActive;
			go = (GameObject)startsActive;
		}
		bool isOver = trigger == Trigger.OnPress || trigger == Trigger.OnHover;
		((UIPlayTween)this).CustomHoverListener(go, isOver);
	}

	private void OnDragOut()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_00ef: Expected I, but got Obj
		//IL_013e: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		if (!isActiveAndEnabled || (trigger != Trigger.OnPress && trigger != Trigger.OnHover))
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v13 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		string text = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S2_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (currentTouch.dragged != (UnityEngine.Object)(object)text)
		{
			((UIPlayTween)this).CustomHoverListener((GameObject)1, true);
		}
		else if (~(dragHighlight ? 1u : 0u) == 0 && trigger == Trigger.OnPress)
		{
			((UIPlayTween)this).CustomHoverListener((GameObject)1, true);
		}
	}

	private void OnDrop(GameObject go)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (trigger != Trigger.OnSelect)
		{
			bool flag = trigger == Trigger.OnSelectTrue;
			object obj = flag & go;
			if (obj == null)
			{
				bool flag2 = trigger != Trigger.OnSelectFalse;
				object obj2 = flag2 | go;
				if (obj2 != null)
				{
					return;
				}
			}
		}
		bool isOver = trigger == Trigger.OnPress || trigger == Trigger.OnHover;
		((UIPlayTween)this).CustomHoverListener(go, isOver);
	}

	public void Play(bool forward)
	{
		//IL_003d: Expected I, but got Obj
		//IL_0053: Expected Obj, but got I
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_007e: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		if (!isActiveAndEnabled || trigger != Trigger.OnPress)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v22 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		string text = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)currentTouch.dragged).FindKernel(text) != 0)
		{
			((UIPlayTween)this).CustomHoverListener((GameObject)null, true);
		}
	}

	public void Play(bool forward, bool onlyIfDifferent)
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)forward).FindKernel(null) != 0)
		{
			GameObject parentInternal = gameObject;
			((Transform)forward).parentInternal = (Transform)(object)parentInternal;
			bool isEnabled = ((UIImageButton)this).isEnabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	public void PlayForward()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_00a2: Expected I, but got Obj
		//IL_00ef: Expected I, but got Obj
		if (!isActiveAndEnabled || (trigger != Trigger.OnPress && trigger != Trigger.OnHover))
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v13 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
		string text = tag;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S2_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)controllerNavigationObject).FindKernel(text) != 0)
		{
			((UIPlayTween)this).CustomHoverListener((GameObject)null, true);
		}
	}

	public void PlayReverse()
	{
		((UIPlaySound)this).OnHover(true);
	}

	private void OnFinished()
	{
		((UIPlaySound)this).OnHover(false);
	}

	public unsafe UIPlayAnimation()
	{
		//IL_028d: Expected I, but got Obj
		//IL_02a3: Expected Obj, but got I
		//IL_03bc: Expected I, but got Obj
		//IL_03d2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_02d5: Expected I, but got Obj
		//IL_02eb: Expected Obj, but got I
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected Obj, but got Unknown
		//IL_0349: Expected Obj, but got I4
		//IL_0357: Expected I, but got Obj
		//IL_036d: Expected Obj, but got I
		//IL_0188: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_022d: Expected I4, but got Obj
		//IL_0228: Expected native int or pointer, but got Obj
		nint num = (nint)typeof(UIPlayAnimation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPlayAnimation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPlayAnimation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v59 (Il2CppClass<UIPlayAnimation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(current != null))
		{
			return;
		}
		nint num5 = (nint)typeof(UIPlayAnimation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<UIPlayAnimation>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIPlayAnimation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v53 (Il2CppClass<UIPlayAnimation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		current = this;
		nint num7 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v13 (Il2CppClass<EventDelegate>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v35 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.dictionary = (Dictionary<string, string[]>)(object)onFinished;
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) != 0)
		{
			string text = callWhenFinished;
			if (callWhenFinished != null && text.m_stringLength != 0)
			{
				*(RangeInt*)(nint)eventReceiver = new RangeInt((int)callWhenFinished, 1);
			}
		}
		object obj6 = this + 48;
		obj6 = 0;
		nint num11 = (nint)typeof(UIPlayAnimation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v31 (Il2CppClass<UIPlayAnimation>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UIPlayAnimation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v37 (Il2CppClass<UIPlayAnimation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		current = null;
	}

	static UIPlayAnimation()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		BetterList<UIKeyNavigation> list = default;
		UIKeyNavigation.list = list;
		UIKeyNavigation.mLastFrame = 0;
	}
}
