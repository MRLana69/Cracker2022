using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UI.Screens;
using UnityEngine;
using UnityEngine.UI;

public class ContactSupportPopUp : UIScreen
{
	private sealed class _003CDelayContactSupport_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected Obj, but got I4
				//IL_005c: Expected Obj, but got I4
				//IL_0076: Expected I4, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Application.targetFrameRate = (int)"http://kiloo.com/support/subway-surfers/";
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILabel _title;

	private UILabel _description;

	private UILabel _subDescription;

	private UILabel _yesLabel;

	private UILabel _noLabel;

	public override void Init()
	{
		//IL_000b: Expected Obj, but got I4
		_footerPrefab = (GameObject)1;
	}

	public void ClosePopup()
	{
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_012c: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00a5: Expected I4, but got Obj
		//IL_00c7: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v23 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CONTACT_SUPPORT_POPUP_TITLE");
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault("CONTACT_SUPPORT_POPUP_DESCRIPTION");
		_description.fontSize = (int)text2;
		string text3 = Strings.GetDefault("CONTACT_SUPPORT_POPUP_DESCRIPTION_SUB");
		_subDescription.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CONTACT_SUPPORT_POPUP_YES");
		_yesLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("CONTACT_SUPPORT_POPUP_NO");
		_noLabel.fontSize = (int)text5;
	}

	public void ContactSupport()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	private IEnumerator DelayContactSupport()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_001e: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		object obj = 0;
		object obj7 = default;
		object obj8 = default;
		while (true)
		{
			IntPtr cachedPtr = ((UnityEngine.Object)this).m_CachedPtr;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v3 (System.IntPtr)+C]");
			if ((nint)obj2 >= 0)
			{
				break;
			}
			object obj3 = (nint)((UnityEngine.Object)this).m_CachedPtr + 16;
			object obj4 = obj << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v19+C]");
			obj7 = obj8 + 0;
			object obj9 = obj + 1;
			obj = obj9;
		}
		float num = ScrollRect.RubberDelta(0f, 1f);
		float num2 = num * (float)obj7;
		float num3 = 0f;
		object obj11 = default;
		IEnumerator result;
		object obj15 = default;
		while (true)
		{
			IntPtr cachedPtr2 = ((UnityEngine.Object)this).m_CachedPtr;
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v9 (System.IntPtr)+C]");
			if ((nint)obj10 >= 0)
			{
				result = null;
				break;
			}
			object obj12 = (nint)((UnityEngine.Object)this).m_CachedPtr + 16;
			object obj13 = obj11 << 2;
			object obj14 = obj12 + obj13;
			IEnumerator enumerator = (IEnumerator)obj14;
			float num4 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S2_v9 (System.Collections.IEnumerator)+C]");
			float num5 = num4 + 0f;
			bool flag = !(num2 > num5);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			result = enumerator;
			if (flag3)
			{
				break;
			}
			obj11 = obj15 + 1;
			num3 = num5;
		}
		return result;
	}

	private void Update()
	{
		//IL_0065: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool isCountdownActive = ((CountdownPopupManager)null).IsCountdownActive;
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])isCountdownActive);
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v15 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).ClosePopup((GameObject)(object)screenName);
	}

	public ContactSupportPopUp()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			ContactSupport();
		}
	}
}
