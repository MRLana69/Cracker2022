using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SaveMePopup : UIScreen
{
	private sealed class _003CstartClockAnimation_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SaveMePopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			SaveMePopup saveMePopup = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					bool flag = saveMePopup.timeLeft > -0.2f;
					num = saveMePopup.timeLeft;
					if (flag)
					{
						goto IL_00e5;
					}
					if (!saveMePopup.close)
					{
						UIScreenController instance = UIScreenController.Instance;
						instance.CloseActivePopups("SaveMePopup");
						Revive instance2 = Revive.Instance;
						instance2.SendSkipRevive();
						SaveMeManager.ResetSaveMeForNewRun();
					}
				}
				return false;
			}
			_003C_003E1__state = -1;
			saveMePopup.timeLeft = 3f;
			num = 3f;
			goto IL_00e5;
			IL_00e5:
			float num2 = num / 3f;
			float num3 = Math.Min(num2, 1f);
			bool flag2 = num2 < 0f;
			float amount = 0f;
			if (!flag2)
			{
				amount = num3;
			}
			saveMePopup.saveMeAnimateClock.FillSpriteAmount(amount);
			float deltaTime = Time.deltaTime;
			float timeLeft = saveMePopup.timeLeft - deltaTime;
			saveMePopup.timeLeft = timeLeft;
			_003C_003E2__current = null;
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

	public SaveMeAnimateClock saveMeAnimateClock;

	private float timeLeft;

	private Button CloseButton;

	private UIPopupIn UIPopupIn;

	private bool close;

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SaveMePopup>)+104] (should have been resolved before IL gen)");
		close = false;
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
	}

	private void GetComponent()
	{
		if (UIPopupIn == null)
		{
			UIPopupIn componentInChildren = GetComponentInChildren<UIPopupIn>();
			UIPopupIn = componentInChildren;
		}
	}

	private void ShowPopUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.IN);
	}

	public void HidePupUp()
	{
		GetComponent();
		UIPopupIn.PlayAnim(UIPopupIn.TYPE.OUT);
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void OnEnable()
	{
		IEnumerator routine = startClockAnimation();
		Coroutine coroutine = StartCoroutine(routine);
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		UIScreen screenFromCache = instance.GetScreenFromCache(topScreenName);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		if (obj != null)
		{
			((IngameScreen)obj).SetPauseButtonVisibility(false);
		}
	}

	private unsafe void Start()
	{
		Button closeButton = CloseButton;
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(SaveMePopup._003CStart_003Eb__12_0));
		closeButton.m_OnClick.AddListener(unityAction);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(SaveMePopup._003CStart_003Eb__12_1));
		OutConplete.AddListener(unityAction2);
	}

	public float getAnimationTimeLeft()
	{
		return timeLeft;
	}

	public float getAnimationDuration()
	{
		return 3f;
	}

	private IEnumerator startClockAnimation()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void _003CStart_003Eb__12_0()
	{
		if (~(close ? 1u : 0u) != 0)
		{
			close = true;
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("SaveMePopup");
			Revive instance2 = Revive.Instance;
			instance2.SendSkipRevive();
			SaveMeManager.ResetSaveMeForNewRun();
		}
	}

	private void _003CStart_003Eb__12_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<SaveMePopup>)+EC] (should have been resolved before IL gen)");
	}
}
