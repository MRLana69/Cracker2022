using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using UI.Screens;
using UnityEngine;

public class ContactSupportPopUp : UIScreen
{
	private sealed class _003CDelayContactSupport_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0038: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Application.OpenURL("http://kiloo.com/support/subway-surfers/");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private UILabel _title;

	private UILabel _description;

	private UILabel _subDescription;

	private UILabel _yesLabel;

	private UILabel _noLabel;

	private void Awake()
	{
		string text = Strings.Get(StringID.CONTACT_SUPPORT_POPUP_TITLE);
		_title.text = text;
		string text2 = Strings.Get(StringID.CONTACT_SUPPORT_POPUP_DESCRIPTION);
		_description.text = text2;
		string text3 = Strings.Get(StringID.CONTACT_SUPPORT_POPUP_DESCRIPTION_SUB);
		_subDescription.text = text3;
		string text4 = Strings.Get(StringID.CONTACT_SUPPORT_POPUP_YES);
		_yesLabel.text = text4;
		string text5 = Strings.Get(StringID.CONTACT_SUPPORT_POPUP_NO);
		_noLabel.text = text5;
	}

	public void ClosePopup()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	public void ContactSupport()
	{
		IEnumerator coroutine = DelayContactSupport();
		Coroutine coroutine2 = CoroutineUtil.StartCoroutine(coroutine);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}

	private IEnumerator DelayContactSupport()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			ClosePopup();
		}
	}
}
