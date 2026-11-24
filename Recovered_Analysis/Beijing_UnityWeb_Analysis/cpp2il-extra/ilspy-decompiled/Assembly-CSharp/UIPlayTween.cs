using System;
using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

public class UIPlayTween : MonoBehaviour
{
	public static UIPlayTween current;

	public GameObject tweenTarget;

	public int tweenGroup;

	public Trigger trigger;

	public Direction playDirection;

	public bool resetOnPlay;

	public bool resetIfDisabled;

	public EnableCondition ifDisabledOnPlay;

	public DisableCondition disableWhenFinished;

	public bool includeChildren;

	public List<EventDelegate> onFinished;

	private GameObject eventReceiver;

	private string callWhenFinished;

	private UITweener[] mTweens;

	private bool mStarted;

	private int mActive;

	private bool mActivated;

	private void Awake()
	{
		//IL_000b: Expected I4, but got F4
		//IL_0016: Expected I4, but got F4
		trigger = Trigger.OnHover;
		playDirection = Direction.Forward;
		CancelInvoke();
	}

	private void Start()
	{
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)eventReceiver).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v10 (Il2CppClass<EventDelegate>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v19 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Localization.LoadAndSelect((string)(object)onFinished))
		{
			object obj3 = this + 48;
			obj3 = 0;
			object obj4 = this + 52;
			obj4 = 0;
		}
	}

	private void OnEnable()
	{
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		mStarted = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (tweenTarget != null)
		{
			object obj2 = this + 12;
			string text = tag;
			obj2 = text;
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
		((Delegate)callback).method = (nint)__ldftn(UIPlayTween.OnToggle);
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

	private void OnDragOver()
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

	private void OnHover(bool isOver)
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		UnityEngine.Object ambigiousFont = ((UIPopupList)this).ambigiousFont;
		if ((object)ambigiousFont == null)
		{
			return;
		}
		if (isOver)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode currentKey = UICamera.currentKey;
			if (currentKey != (KeyCode)2)
			{
				return;
			}
		}
		((UIPlaySound)this).OnPress(isOver);
	}

	private unsafe void CustomHoverListener(GameObject go, bool isOver)
	{
		//IL_0513: Expected I, but got Obj
		//IL_0529: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_0551: Expected Obj, but got I4
		//IL_0620: Expected I, but got Obj
		//IL_0636: Expected Obj, but got I
		//IL_0168: Expected I, but got Obj
		//IL_017e: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_05aa: Expected I, but got Obj
		//IL_05c0: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0372: Expected Obj, but got I4
		//IL_02e0: Expected I, but got Obj
		//IL_05ea: Expected Obj, but got I4
		//IL_01a9: Expected I, but got Obj
		//IL_0389: Expected I, but got Obj
		//IL_039f: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I4
		//IL_034c: Expected I4, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_065d: Expected Obj, but got I4
		//IL_0243: Expected I, but got Obj
		//IL_0259: Expected Obj, but got I
		//IL_03ca: Expected I, but got Obj
		//IL_0284: Expected I, but got Obj
		//IL_043f: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I4
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0485: Expected I, but got Obj
		//IL_049b: Expected Obj, but got I
		//IL_0698: Expected Obj, but got I
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected Obj, but got Unknown
		//IL_04c6: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)tweenTarget))
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)tweenGroup))
			{
				return;
			}
		}
		if (isOver)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPlayTween)+39]");
			bool flag = (nint)0 != 0;
			object obj3 = flag ^ go;
			if (obj3 == null)
			{
				return;
			}
			object obj4 = go & 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIPlayTween)+21]");
		if ((nint)0 != 0)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v64 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v81 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int touchCount = UICamera.touchCount;
			string text = tag;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S2_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S2_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)touchCount != (UnityEngine.Object)(object)text)
			{
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v72 (Il2CppClass<UICamera>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num10 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v77 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UICamera.Raycast(null);
			}
		}
		Direction direction = (Direction)(0 - (resetOnPlay ? 1 : 0));
		bool flag2 = (object)go == null;
		Direction keepCharCount = direction;
		if (!flag2)
		{
			keepCharCount = (resetOnPlay ? Direction.Forward : Direction.Toggle);
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3;
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)tweenTarget))
		{
			ActiveAnimation activeAnimation = ActiveAnimation.Play((Animator)(object)tweenTarget, (string)trigger, keepCharCount, (EnableCondition)disableWhenFinished, includeChildren ? DisableCondition.DisableAfterForward : DisableCondition.DoNotDisable);
			flag3 = (byte)(int)activeAnimation != 0;
		}
		else
		{
			flag3 = NGUIText.WrapText((string)tweenGroup, out *(string*)(int)trigger, (byte)keepCharCount != 0, (byte)disableWhenFinished != 0, includeChildren);
		}
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)flag3).FindKernel(null) == 0)
		{
			return;
		}
		if (ifDisabledOnPlay != EnableCondition.DoNothing)
		{
			((ActiveAnimation)flag3).Start();
		}
		object obj10 = 0;
		TextAsset textAsset = default;
		while (true)
		{
			List<EventDelegate> list = onFinished;
			if ((nint)obj10 >= list._size)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			((UnityEngine.Object)textAsset).m_CachedPtr = cachedPtr;
			_ = 0;
			object obj11 = textAsset + 16;
			obj11 = this;
			nint num15 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S1_v31 (Il2CppClass<EventDelegate>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num16 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S1_v37 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v28 (System.Boolean)+C]");
			bool flag4 = Localization.LoadCSV((byte[])0, textAsset, true);
			object obj13 = obj10 + 1;
			obj10 = obj13;
		}
	}

	private void OnDragOut()
	{
		if (trigger == Trigger.OnHover)
		{
			OnPress(isPressed: true);
		}
	}

	private unsafe void OnPress(bool isPressed)
	{
		//IL_03a2: Expected Obj, but got I4
		//IL_0050: Expected Obj, but got I4
		//IL_0359: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00dd: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I
		//IL_03d7: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_016b: Expected I, but got Obj
		//IL_01b8: Expected I, but got Obj
		//IL_01ce: Expected Obj, but got I
		//IL_0245: Expected I4, but got Obj
		//IL_0245: Expected Obj, but got I4
		//IL_01f9: Expected I, but got Obj
		//IL_0274: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_04b9: Expected I, but got Obj
		//IL_04cf: Expected Obj, but got I
		//IL_02b5: Expected I, but got Obj
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
				bool flag2 = trigger == Trigger.OnHoverFalse;
				object obj2 = (isPressed ? 1 : 0) ^ 1;
				object obj3 = flag2 & obj2;
				if (obj3 == null)
				{
					return;
				}
			}
		}
		bool flag3 = mActivated;
		object obj4 = flag3 ^ isPressed;
		if (obj4 == null)
		{
			return;
		}
		if (isPressed)
		{
			goto IL_0337;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<UICamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v72 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4;
		UnityEngine.Object ambigiousFont;
		if (((ComputeShader)(object)controllerNavigationObject).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v37 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v68 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject controllerNavigationObject2 = UICamera.controllerNavigationObject;
			int layer = controllerNavigationObject2.layer;
			GameObject gameObject = base.gameObject;
			Transform child = ((Transform)layer).GetChild((int)gameObject);
			if ((object)child != null)
			{
				nint num7 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v48 (Il2CppClass<UICamera>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v62 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj9 = default;
				obj9.method_ptr = method_ptr;
				obj9.method = (nint)__ldftn(UIPlayTween.CustomHoverListener);
				object obj10 = obj9 + 16;
				obj10 = this;
				Delegate obj11 = ((Delegate)UICamera.onHover).CombineImpl(obj9);
				nint num9 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v57 (Il2CppClass<UICamera>)+5C]");
				object obj12 = (nint)0 + (nint)184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj13 = default;
				obj12 = obj13;
				if (!mActivated)
				{
					goto IL_0337;
				}
				return;
			}
			flag4 = false;
			ambigiousFont = null;
		}
		else
		{
			flag4 = false;
			ambigiousFont = null;
		}
		goto IL_04e3;
		IL_04e3:
		mActivated = flag4;
		((UIPopupList)this).ambigiousFont = ambigiousFont;
		return;
		IL_0337:
		bool flag5 = trigger == Trigger.OnHover;
		flag4 = flag5;
		ambigiousFont = (UnityEngine.Object)1;
		goto IL_04e3;
	}

	private void OnClick()
	{
		if (isActiveAndEnabled && ~(mActivated ? 1u : 0u) == 0)
		{
			mActivated = false;
			((UIPopupList)this).ambigiousFont = null;
		}
	}

	private void OnDoubleClick()
	{
		//IL_0058: Expected Obj, but got I4
		if (isActiveAndEnabled && trigger == Trigger.OnClick)
		{
			((UIPopupList)this).ambigiousFont = (UnityEngine.Object)1;
		}
	}

	private void OnSelect(bool isSelected)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (trigger != Trigger.OnPress)
		{
			bool flag = trigger == Trigger.OnPressTrue;
			object obj = flag & isSelected;
			if (obj == null)
			{
				bool flag2 = trigger == Trigger.OnPressFalse;
				object obj2 = (isSelected ? 1 : 0) ^ 1;
				object obj3 = flag2 & obj2;
				if (obj3 == null)
				{
					return;
				}
			}
		}
		bool flag3 = isSelected && trigger == Trigger.OnPress;
		mActivated = flag3;
		((UIPopupList)this).ambigiousFont = (UnityEngine.Object)isSelected;
	}

	private void OnToggle()
	{
		//IL_0058: Expected Obj, but got I4
		if (isActiveAndEnabled && trigger == Trigger.OnDoubleClick)
		{
			((UIPopupList)this).ambigiousFont = (UnityEngine.Object)1;
		}
	}

	private void Update()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0383: Expected I, but got Obj
		//IL_0399: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0492: Expected I, but got Obj
		//IL_04a8: Expected Obj, but got I
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v81 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v62 (Il2CppClass<UIToggle>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UIToggle);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v75 (Il2CppClass<UIToggle>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIToggle uIToggle = UIToggle.current;
				if ((~(uIToggle.mStarted ? 1u : 0u) != 0) ? uIToggle.startsActive : uIToggle.mIsActive)
				{
					goto IL_0484;
				}
			}
			if (trigger != Trigger.OnActivateFalse)
			{
				return;
			}
			nint num7 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v42 (Il2CppClass<UIToggle>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UIToggle);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v55 (Il2CppClass<UIToggle>)+74]");
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
		goto IL_0484;
		IL_0484:
		nint num9 = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v23 (Il2CppClass<UIToggle>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v28 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIToggle uIToggle3 = UIToggle.current;
		UnityEngine.Object ambigiousFont;
		if (~(uIToggle3.mStarted ? 1u : 0u) == 0)
		{
			bool mIsActive = uIToggle3.mIsActive;
			ambigiousFont = (UnityEngine.Object)mIsActive;
		}
		else
		{
			bool startsActive = uIToggle3.startsActive;
			ambigiousFont = (UnityEngine.Object)startsActive;
		}
		((UIPopupList)this).ambigiousFont = ambigiousFont;
	}

	public void Play(bool forward)
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0131: Expected Obj, but got I4
		//IL_00b5: Expected Obj, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (trigger != Trigger.OnSelect)
		{
			bool flag = trigger == Trigger.OnSelectTrue;
			object obj = flag & forward;
			if (obj == null)
			{
				bool flag2 = trigger == Trigger.OnSelectFalse;
				object obj2 = (forward ? 1 : 0) ^ 1;
				object obj3 = flag2 & obj2;
				if (obj3 == null)
				{
					return;
				}
			}
		}
		bool flag3 = forward && trigger == Trigger.OnSelect;
		mActivated = flag3;
		((UIPopupList)this).ambigiousFont = (UnityEngine.Object)forward;
	}

	private void OnFinished()
	{
		//IL_0037: Expected Obj, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		if (disableWhenFinished == DisableCondition.DoNotDisable || mTweens == null)
		{
			return;
		}
		UITweener[] array = mTweens;
		object obj = 1;
		object obj2 = default;
		object obj7 = default;
		while (true)
		{
			if ((nint)obj2 < array.Length)
			{
				object obj3 = mTweens + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				Behaviour behaviour = (Behaviour)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v27 (UnityEngine.Behaviour)+28]");
				if ((nint)0 == tweenGroup)
				{
					if (behaviour.isActiveAndEnabled)
					{
						break;
					}
					Sprite sprite2D = ((UI2DSprite)behaviour).sprite2D;
					bool flag = (nint)sprite2D == (nint)disableWhenFinished;
					object obj6 = obj & flag;
					obj = obj6;
				}
				obj2 = obj7 + 1;
				continue;
			}
			if (obj != null)
			{
				nint num = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v9 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v14 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.SetActiveChildren(tweenTarget, state: false);
			}
			object obj9 = this + 56;
			obj9 = 0;
			break;
		}
	}

	public unsafe UIPlayTween()
	{
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_0274: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_00e8: Expected I, but got Obj
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I4
		//IL_0135: Expected I, but got Obj
		//IL_01da: Expected I4, but got Obj
		//IL_01d5: Expected native int or pointer, but got Obj
		object obj = this - -64;
		object obj2 = this - -64;
		object obj3 = obj2 - 1;
		obj = obj3;
		if (obj3 != null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(current != null))
		{
			return;
		}
		current = this;
		nint num3 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v16 (Il2CppClass<EventDelegate>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v37 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Localization.dictionary = (Dictionary<string, string[]>)(object)onFinished;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
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
		object obj7 = this + 48;
		obj7 = 0;
		current = null;
	}
}
