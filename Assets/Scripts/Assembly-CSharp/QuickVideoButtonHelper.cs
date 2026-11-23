using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class QuickVideoButtonHelper : MonoBehaviour
{
	public enum State
	{
		Keys,
		Minibox
	}

	private sealed class _003CStartVideoWithDelay_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
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
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					VideoAdsManager instance = VideoAdsManager.instance;
					bool flag = instance.PlayVideoIfAvailable();
					UIScreenController instance2 = UIScreenController.Instance;
					if (!flag)
					{
						string message = Strings.Get(StringID.SLIDEIN_VIDEO_PLAY_ERROR);
						instance2.QueueErrorMessageSlidein(message);
						return false;
					}
					instance2.ShowVideoAdsOverlay();
				}
				return false;
			}
			_003C_003E1__state = -1;
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

	private UILabel keyLabel1;

	private UILabel keyLabel2;

	private UISprite keySprite;

	private UISprite miniboxSprite;

	private void OnEnable()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		throw new ArgumentException();
	}

	private void OnDisable()
	{
		VideoAdsManager instance = VideoAdsManager.instance;
		throw new ArgumentException();
	}

	private void OnClick()
	{
		IEnumerator routine = StartVideoWithDelay();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator StartVideoWithDelay()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void OnTakeoverEndedHandler(VideoAdProvider provider)
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		UIScreenController instance = UIScreenController.Instance;
		instance.HideVideoAdsOverlay();
	}

	public void SetState(State state)
	{
		bool flag = state == State.Keys;
		bool active = true;
		if (!flag)
		{
			if (state != State.Minibox)
			{
				return;
			}
			active = false;
		}
		GameObject gameObject = miniboxSprite.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = keyLabel1.gameObject;
		gameObject2.SetActive(active);
		GameObject gameObject3 = keyLabel2.gameObject;
		gameObject3.SetActive(active);
		GameObject gameObject4 = keySprite.gameObject;
		gameObject4.SetActive(active);
	}
}
