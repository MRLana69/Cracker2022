using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResumeButtonHelper : MonoBehaviour
{
	private sealed class _003CEnableButtonWhenReady_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ResumeButtonHelper _003C_003E4__this;

		private float _003CstartTime_003E5__2;

		private float _003CtimeWaited_003E5__3;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					if (_003CtimeWaited_003E5__3 < 1f)
					{
						goto IL_0097;
					}
					_003C_003E4__this.EnableButton();
				}
				return false;
			}
			_003C_003E1__state = -1;
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			_003CtimeWaited_003E5__3 = 0f;
			_003CstartTime_003E5__2 = realtimeSinceStartup;
			goto IL_0097;
			IL_0097:
			float realtimeSinceStartup2 = Time.realtimeSinceStartup;
			float num = realtimeSinceStartup2 - _003CstartTime_003E5__2;
			_003CtimeWaited_003E5__3 = num;
			object obj = default;
			_003C_003E2__current = obj;
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

	private const float MIN_WAIT_TIME = 1f;

	private const float MAX_WAIT_TIME = 5f;

	private TMP_Text label;

	private Image button;

	private UIButtonOverlayOff _cachedOverlayHelper;

	private bool buttonEnabled = true;

	private Sprite disable;

	private Sprite enable;

	public bool isButtonEnabled => buttonEnabled;

	private void OnApplicationPause(bool pause)
	{
		DisableButton();
		if (!pause)
		{
			IEnumerator routine = EnableButtonWhenReady();
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator EnableButtonWhenReady()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void EnableButton()
	{
		//IL_0035: Expected I, but got Obj
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		if (~(buttonEnabled ? 1u : 0u) != 0)
		{
			buttonEnabled = true;
			TMP_Text tMP_Text = label;
			string text = Strings.Get(StringID.RESUME_BUTTON_HELPER_RESUME);
			nint num = (nint)tMP_Text;
			object obj = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v43 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			button.sprite = enable;
		}
	}

	public void DisableButton()
	{
		//IL_0035: Expected I, but got Obj
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		if (~(buttonEnabled ? 1u : 0u) == 0)
		{
			buttonEnabled = false;
			TMP_Text tMP_Text = label;
			string text = Strings.Get(StringID.RESUME_BUTTON_HELPER_WAIT);
			nint num = (nint)tMP_Text;
			object obj = tMP_Text + 528;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S2_v4 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
			button.sprite = disable;
		}
	}
}
