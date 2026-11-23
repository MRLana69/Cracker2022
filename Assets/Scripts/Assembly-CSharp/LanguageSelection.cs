using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class LanguageSelection : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__2_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CStart_003Eb__2_0()
		{
			UIPopupList current = UIPopupList.current;
			Localization.language = current.mSelectedItem;
		}
	}

	private UIPopupList mList;

	private void Awake()
	{
		UIPopupList component = GetComponent<UIPopupList>();
		mList = component;
		Refresh();
	}

	private unsafe void Start()
	{
		UIPopupList uIPopupList = mList;
		bool flag = _003C_003Ec._003C_003E9__2_0 == null;
		bool flag2 = !flag;
		EventDelegate.Callback callback = _003C_003Ec._003C_003E9__2_0;
		if (!flag2)
		{
			EventDelegate.Callback callback2 = default;
			callback2._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CStart_003Eb__2_0));
			_003C_003Ec._003C_003E9__2_0 = callback2;
			callback = callback2;
		}
		EventDelegate eventDelegate = EventDelegate.Add(uIPopupList.onChange, callback);
	}

	public void Refresh()
	{
		//IL_0052: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		if (!(mList != null))
		{
			return;
		}
		string[] knownLanguages = Localization.knownLanguages;
		if (knownLanguages == null)
		{
			return;
		}
		mList.Clear();
		string[] knownLanguages2 = Localization.knownLanguages;
		object obj = 0;
		while (true)
		{
			UIPopupList uIPopupList = mList;
			if ((nint)obj >= knownLanguages2.Length)
			{
				break;
			}
			string[] knownLanguages3 = Localization.knownLanguages;
			object obj2 = obj << 2;
			object obj3 = (object)knownLanguages3 + obj2;
			List<string> items = uIPopupList.items;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v11+10]");
			items.Add((string)0);
			object obj4 = obj + 1;
			obj = obj4;
		}
		string language = Localization.language;
		mList.value = language;
	}
}
