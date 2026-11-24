using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class UISavedOption : MonoBehaviour
{
	public string keyName;

	private UIPopupList mList;

	private UIToggle mCheck;

	private UIProgressBar mSlider;

	private string key
	{
		get
		{
			//IL_005d: Expected Obj, but got I4
			//IL_0039: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISavedOption)+20]");
			if ((nint)0 == 1)
			{
				return (string)1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UISavedOption)+20]");
			bool flag = (nint)0 == 3;
			return (string)flag;
		}
	}

	private void Awake()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		_ = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list = default;
		list._002Ector();
		object obj = this + 60;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void OnEnable()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		object obj = this + 16;
		UIPopupList component = GetComponent<UIPopupList>();
		obj = component;
		object obj2 = this + 20;
		UIToggle component2 = GetComponent<UIToggle>();
		obj2 = component2;
		object obj3 = this + 24;
		UIProgressBar component3 = GetComponent<UIProgressBar>();
		obj3 = component3;
	}

	private unsafe void OnDisable()
	{
		//IL_04c6: Expected I, but got Obj
		//IL_04dc: Expected Obj, but got I
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00a9: Expected I, but got Obj
		//IL_00bf: Expected Obj, but got I
		//IL_0319: Expected I, but got Obj
		//IL_032f: Expected Obj, but got I
		//IL_01cf: Expected I, but got Obj
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0265: Expected I, but got Obj
		//IL_027b: Expected Obj, but got I
		//IL_00ea: Expected I, but got Obj
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected Obj, but got Unknown
		//IL_0663: Expected I, but got Obj
		//IL_0679: Expected Obj, but got I
		//IL_035a: Expected I, but got Obj
		//IL_05ca: Expected Obj, but got I4
		//IL_02a6: Expected I, but got Obj
		//IL_0454: Expected I, but got Obj
		//IL_03cd: Expected Obj, but got I4
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0415: Expected Obj, but got I4
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v65 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mList).FindKernel((string)null) != 0)
		{
			UIPopupList uIPopupList = mList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			EventDelegate.Callback callback = default;
			((Delegate)callback).method_ptr = method_ptr;
			((Delegate)callback).method = (nint)__ldftn(UISavedOption.SaveSelection);
			object obj2 = callback + 16;
			obj2 = this;
			nint num3 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v83 (Il2CppClass<EventDelegate>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v93 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = EventDelegate.Remove(uIPopupList.onChange, callback);
			UIPanel panel = ((UIScrollView)this).panel;
			bool flag2;
			if (PlayerPrefs.HasKey((string)(object)panel))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v56 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			}
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mCheck).FindKernel((string)null) != 0)
		{
			UIToggle uIToggle = mCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			EventDelegate.Callback callback2 = default;
			((Delegate)callback2).method_ptr = method_ptr2;
			((Delegate)callback2).method = (nint)__ldftn(UISavedOption.SaveState);
			object obj5 = callback2 + 16;
			obj5 = this;
			nint num7 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v59 (Il2CppClass<EventDelegate>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v68 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = EventDelegate.Remove(uIToggle.onChange, callback2);
			UIPanel panel2 = ((UIScrollView)this).panel;
			UIToggle uIToggle2 = mCheck;
			bool startsActive = uIToggle2.startsActive;
			string text = PlayerPrefs.GetString((string)(object)panel2, (string)startsActive);
			bool isChecked = text != null;
			mCheck.isChecked = isChecked;
			return;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSlider).FindKernel((string)null) == 0)
		{
			UIPanel panel3 = ((UIScrollView)this).panel;
			bool flag4 = PlayerPrefs.HasKey((string)(object)panel3);
			UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(includeInactive: true);
			object obj8 = 0;
			while ((nint)obj8 < componentsInChildren.Length)
			{
				object obj9 = componentsInChildren + 16;
				object obj10 = obj8 << 2;
				object obj11 = obj9 + obj10;
				UnityEngine.Object obj12 = UnityEngine.Object.Instantiate((UnityEngine.Object)obj11);
				bool isChecked2 = (string)(object)obj12 != (string)flag4;
				((UIToggle)obj11).isChecked = isChecked2;
				object obj13 = obj8 + 1;
				obj8 = obj13;
			}
			return;
		}
		UIProgressBar uIProgressBar = mSlider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		EventDelegate.Callback callback3 = default;
		((Delegate)callback3).method_ptr = method_ptr3;
		((Delegate)callback3).method = (nint)__ldftn(UISavedOption.SaveProgress);
		object obj14 = callback3 + 16;
		obj14 = this;
		nint num11 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v24 (Il2CppClass<EventDelegate>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num12 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v32 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = EventDelegate.Remove(uIProgressBar.onChange, callback3);
		UIPanel panel4 = ((UIScrollView)this).panel;
		float alpha = mSlider.alpha;
		float alpha2 = ((Slider)(object)panel4).ClampValue(alpha);
		mSlider.alpha = alpha2;
	}

	public void SaveSelection()
	{
		//IL_04ef: Expected I, but got Obj
		//IL_0505: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0079: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_0294: Expected I, but got Obj
		//IL_02aa: Expected Obj, but got I
		//IL_0174: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected Obj, but got Unknown
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_00e6: Expected I, but got Obj
		//IL_03ff: Expected Obj, but got I4
		//IL_02d5: Expected I, but got Obj
		//IL_033b: Expected Obj, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_0247: Expected I, but got Obj
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected Obj, but got Unknown
		//IL_03a8: Expected I, but got Obj
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mCheck).FindKernel((string)null) != 0)
		{
			UIToggle uIToggle = mCheck;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			EventDelegate eventDelegate = default;
			eventDelegate.mTarget = (MonoBehaviour)num3;
			eventDelegate.oneShot = false;
			object obj2 = eventDelegate + 16;
			obj2 = this;
			nint num4 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v77 (Il2CppClass<EventDelegate>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v82 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = EventDelegate.Remove(uIToggle.onChange, eventDelegate);
			return;
		}
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mList).FindKernel((string)null) != 0)
		{
			UIPopupList uIPopupList = mList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num8 = 0;
			EventDelegate eventDelegate2 = default;
			eventDelegate2.mTarget = (MonoBehaviour)num8;
			eventDelegate2.oneShot = false;
			object obj5 = eventDelegate2 + 16;
			obj5 = this;
			nint num9 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v57 (Il2CppClass<EventDelegate>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v62 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = EventDelegate.Remove(uIPopupList.onChange, eventDelegate2);
			return;
		}
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mSlider).FindKernel((string)null) != 0)
		{
			UIProgressBar uIProgressBar = mSlider;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			EventDelegate eventDelegate3 = default;
			eventDelegate3.mTarget = (MonoBehaviour)num13;
			eventDelegate3.oneShot = false;
			object obj8 = eventDelegate3 + 16;
			obj8 = this;
			nint num14 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v37 (Il2CppClass<EventDelegate>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num15 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v42 (Il2CppClass<EventDelegate>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = EventDelegate.Remove(uIProgressBar.onChange, eventDelegate3);
			return;
		}
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(includeInactive: true);
		object obj10 = 0;
		while ((nint)obj10 < componentsInChildren.Length)
		{
			object obj11 = componentsInChildren + 16;
			object obj12 = obj10 << 2;
			object obj13 = obj11 + obj12;
			UnityEngine.Object original = (UnityEngine.Object)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v31 (UnityEngine.Object)+42]");
			bool flag4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v31 (UnityEngine.Object)+41]");
				flag4 = (nint)0 != 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v31 (UnityEngine.Object)+24]");
				flag4 = (nint)0 != 0;
			}
			if (!flag4)
			{
				object obj14 = obj10 + 1;
				obj10 = obj14;
				continue;
			}
			UIPanel panel = ((UIScrollView)this).panel;
			UnityEngine.Object tooltip = UnityEngine.Object.Instantiate(original);
			((TooltipAttribute)(object)panel)._002Ector((string)(object)tooltip);
			break;
		}
	}

	public void SaveState()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		UIPanel panel = ((UIScrollView)this).panel;
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v10 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string tooltip = default;
		((TooltipAttribute)(object)panel)._002Ector(tooltip);
	}

	public void SaveProgress()
	{
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I4
		UIPanel panel = ((UIScrollView)this).panel;
		nint num = (nint)typeof(UIToggle);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UIToggle>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIToggle);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v20 (Il2CppClass<UIToggle>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIToggle current = UIToggle.current;
		bool flag = ((~(current.mStarted ? 1u : 0u) != 0) ? current.startsActive : current.mIsActive);
		PlayerPrefs.SetString((string)(object)panel, (string)flag);
	}

	public UISavedOption()
	{
		((SpaceAttribute)(object)((UIScrollView)this).panel)._002Ector(UIProgressBar.current.alpha);
	}
}
