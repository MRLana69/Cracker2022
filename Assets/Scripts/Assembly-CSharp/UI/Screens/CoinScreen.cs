using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens;

public class CoinScreen : UIScreen
{
	private sealed class _003CScrollOnTop_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public CoinScreen _003C_003E4__this;

		private ScrollRect _003CScrollRect_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_009a: Expected I, but got Obj
			//IL_00cd: Expected I, but got Obj
			//IL_013e: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 2)
					{
						_003C_003E1__state = -1;
						ScrollRect scrollRect = _003CScrollRect_003E5__2;
						GameObject gameObject = scrollRect.m_Content.gameObject;
						gameObject.SetActive(value: true);
					}
					return false;
				}
				_003C_003E1__state = -1;
				ScrollRect scrollRect2 = _003CScrollRect_003E5__2;
				nint num = (nint)scrollRect2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S3_v2 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
				object obj = default;
				_003C_003E2__current = obj;
				_003C_003E1__state = 2;
				return true;
			}
			_003C_003E1__state = -1;
			ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
			_003CScrollRect_003E5__2 = componentInChildren;
			Canvas.ForceUpdateCanvases();
			ScrollRect scrollRect3 = _003CScrollRect_003E5__2;
			VerticalLayoutGroup component = scrollRect3.m_Content.GetComponent<VerticalLayoutGroup>();
			nint num2 = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v9 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
			ScrollRect scrollRect4 = _003CScrollRect_003E5__2;
			ContentSizeFitter component2 = scrollRect4.m_Content.GetComponent<ContentSizeFitter>();
			nint num3 = (nint)component2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v102 @ S1_v14 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
			ScrollRect scrollRect5 = _003CScrollRect_003E5__2;
			GameObject gameObject2 = scrollRect5.m_Content.gameObject;
			gameObject2.SetActive(value: false);
			object obj2 = default;
			_003C_003E2__current = obj2;
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

	public GameObject StorePrefab;

	private GameObject content;

	private bool shouldShowEarners;

	private static bool _facebookLoginRunning;

	private static bool _shouldRefreshScreen;

	[NonSerialized]
	public int counterForElementsOnDisplay;

	private GameObject _go;

	private bool init;

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.CoinScreen>)+104] (should have been resolved before IL gen)");
		FillTable();
	}

	private unsafe void OnEnable()
	{
		InAppManager instance = InAppManager.instance;
		if (instance != null)
		{
			InAppManager instance2 = InAppManager.instance;
			InAppManager.OnProductRequestDone onProductRequestDone = default;
			onProductRequestDone._002Ector(this, (nint)__ldftn(CoinScreen.OnProductRequestDone));
			instance2.onProductRequestDone += onProductRequestDone;
		}
	}

	private unsafe void OnDisable()
	{
		InAppManager instance = InAppManager.instance;
		if (instance != null)
		{
			InAppManager instance2 = InAppManager.instance;
			InAppManager.OnProductRequestDone onProductRequestDone = default;
			onProductRequestDone._002Ector(this, (nint)__ldftn(CoinScreen.OnProductRequestDone));
			instance2.onProductRequestDone -= onProductRequestDone;
		}
	}

	private void Update()
	{
	}

	public override void Show()
	{
		base.Show();
		if (_footerHandler != null)
		{
			_footerHandler.HandleStickers();
		}
		CodeVoucherPopup.ShowInShopScreenIfNeeded();
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
	}

	public IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void RefreshCurrencyEarners()
	{
	}

	private void FillTable()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (~(init ? 1u : 0u) == 0)
		{
			return;
		}
		counterForElementsOnDisplay = 0;
		init = true;
		object obj3 = obj + 8;
		Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		object obj6 = default;
		GameObject go = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_035f;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_go = go;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											continue;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			object obj9 = obj10;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_035f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_035f:
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @142C");
			_shouldRefreshScreen = false;
			return;
		}
		_ = 0;
		object obj13 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
	}

	public static void FacebookLoginClicked()
	{
		throw new ArgumentException();
	}

	public unsafe static void OnFacebookLoginResult(bool loggedIn)
	{
		if (!loggedIn && ~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			_facebookLoginRunning = false;
			Action action = default;
			action._002Ector(null, (nint)(delegate*<void>)(&OnFailSlideInFinish));
			QueueFacebookFailSlideIn(action);
		}
	}

	private static void OnFailSlideInFinish()
	{
		FacebookStatusChanged(success: false);
	}

	private static void FacebookStatusChanged(bool success)
	{
		if (success)
		{
			bool flag = FacebookRewardsInfo.HasReceivedAllAvailableRewards();
			UIScreenController instance = UIScreenController.Instance;
			if (!flag)
			{
				instance.PushPopup("FacebookRewardsPopup");
			}
			else
			{
				UIScreenController.SlideIn slideIn = default;
				slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectSucceeded);
				instance.QueueSlideIn(slideIn);
			}
		}
		else if (~(_facebookLoginRunning ? 1u : 0u) == 0)
		{
			OnFacebookLoginResult(loggedIn: false);
		}
		HouseKeeper.SetFacebookPayoutActionToDefault();
		_shouldRefreshScreen = true;
		_facebookLoginRunning = false;
	}

	private static void QueueFacebookFailSlideIn(Action onFinishCallback)
	{
		UIScreenController instance = UIScreenController.Instance;
		UIScreenController.SlideIn slideIn = default;
		slideIn._002Ector(UIScreenController.SlideInType.Facebook, UISlideInFacebook.FacebookSlideInState.ConnectFailed, onFinishCallback);
		instance.QueueSlideIn(slideIn);
	}

	private void OnProductRequestDone()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.CoinScreen>)+E4] (should have been resolved before IL gen)");
	}
}
