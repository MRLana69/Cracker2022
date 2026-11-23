using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

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
			//IL_002a: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			string text = keyName;
			object obj;
			if (keyName != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_0085;
				}
			}
			obj = 1;
			goto IL_0085;
			IL_0085:
			if (obj != null)
			{
				string text2 = name;
				return "NGUI State: " + text2;
			}
			return keyName;
		}
	}

	private void Awake()
	{
		UIPopupList component = GetComponent<UIPopupList>();
		mList = component;
		UIToggle component2 = GetComponent<UIToggle>();
		mCheck = component2;
		UIProgressBar component3 = GetComponent<UIProgressBar>();
		mSlider = component3;
	}

	private unsafe void OnEnable()
	{
		//IL_024b: Expected Obj, but got I4
		//IL_009d: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_027c: Expected Obj, but got I
		//IL_02ab: Expected Obj, but got I
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		string text2;
		object obj;
		if (mList != null)
		{
			UIPopupList uIPopupList = mList;
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (nint)__ldftn(UISavedOption.SaveSelection));
			EventDelegate eventDelegate = EventDelegate.Add(uIPopupList.onChange, callback);
			string text = key;
			text2 = PlayerPrefs.GetString(text);
			if (text2 != null)
			{
				obj = 0;
				if (text2._stringLength != 0)
				{
					goto IL_02ef;
				}
			}
			obj = 1;
			goto IL_02ef;
		}
		if (mCheck != null)
		{
			UIToggle uIToggle = mCheck;
			EventDelegate.Callback callback2 = default;
			callback2._002Ector(this, (nint)__ldftn(UISavedOption.SaveState));
			EventDelegate eventDelegate2 = EventDelegate.Add(uIToggle.onChange, callback2);
			string text3 = key;
			UIToggle uIToggle2 = mCheck;
			int num = PlayerPrefs.GetInt(text3, uIToggle2.startsActive ? 1 : 0);
			bool value = num != 0;
			mCheck.value = value;
			return;
		}
		if (mSlider != null)
		{
			UIProgressBar uIProgressBar = mSlider;
			EventDelegate.Callback callback3 = default;
			callback3._002Ector(this, (nint)__ldftn(UISavedOption.SaveProgress));
			EventDelegate eventDelegate3 = EventDelegate.Add(uIProgressBar.onChange, callback3);
			string text4 = key;
			float value2 = mSlider.value;
			float value3 = PlayerPrefs.GetFloat(text4, value2);
			mSlider.value = value3;
			return;
		}
		string text5 = key;
		string text6 = PlayerPrefs.GetString(text5);
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(includeInactive: true);
		object obj2 = 0;
		while ((nint)obj2 < componentsInChildren.Length)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)componentsInChildren + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v35+10]");
			string text7 = ((Object)0).name;
			bool value4 = text7 == text6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v35+10]");
			((UIToggle)0).value = value4;
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
		return;
		IL_02ef:
		if (obj == null)
		{
			mList.value = text2;
		}
	}

	private unsafe void OnDisable()
	{
		//IL_0124: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		EventDelegate.Callback callback2;
		List<EventDelegate> onChange;
		if (mCheck != null)
		{
			UIToggle uIToggle = mCheck;
			EventDelegate.Callback callback = default;
			callback._002Ector(this, (nint)__ldftn(UISavedOption.SaveState));
			callback2 = callback;
			onChange = uIToggle.onChange;
		}
		else if (mList != null)
		{
			UIPopupList uIPopupList = mList;
			EventDelegate.Callback callback3 = default;
			callback3._002Ector(this, (nint)__ldftn(UISavedOption.SaveSelection));
			callback2 = callback3;
			onChange = uIPopupList.onChange;
		}
		else
		{
			if (!(mSlider != null))
			{
				UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(includeInactive: true);
				object obj = 0;
				while ((nint)obj < componentsInChildren.Length)
				{
					object obj2 = obj << 2;
					object obj3 = (object)componentsInChildren + obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v11+10]");
					Object obj4 = (Object)0;
					object obj5 = 57;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S2_v12 (UnityEngine.Object)+3A]");
					if ((nint)0 == 0)
					{
						obj5 = 28;
					}
					object obj6 = obj5 + (object)obj4;
					if (obj6 == null)
					{
						object obj7 = obj + 1;
						obj = obj7;
						continue;
					}
					string text = key;
					string value = obj4.name;
					PlayerPrefs.SetString(text, value);
					break;
				}
				return;
			}
			UIProgressBar uIProgressBar = mSlider;
			EventDelegate.Callback callback4 = default;
			callback4._002Ector(this, (nint)__ldftn(UISavedOption.SaveProgress));
			callback2 = callback4;
			onChange = uIProgressBar.onChange;
		}
		bool flag = EventDelegate.Remove(onChange, callback2);
	}

	public void SaveSelection()
	{
		string text = key;
		UIPopupList current = UIPopupList.current;
		PlayerPrefs.SetString(text, current.mSelectedItem);
	}

	public void SaveState()
	{
		//IL_002f: Expected Obj, but got I4
		//IL_005c: Expected I4, but got Obj
		//IL_000e: Expected Obj, but got I4
		string text = key;
		UIToggle current = UIToggle.current;
		object obj = 57;
		if (!current.mStarted)
		{
			obj = 28;
		}
		object obj2 = obj + (object)current;
		PlayerPrefs.SetInt(text, (int)obj2);
	}

	public void SaveProgress()
	{
		string text = key;
		float value = UIProgressBar.current.value;
		PlayerPrefs.SetFloat(text, value);
	}
}
