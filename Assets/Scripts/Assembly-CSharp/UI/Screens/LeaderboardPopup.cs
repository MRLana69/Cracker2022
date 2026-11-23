using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UI.Screens;

public class LeaderboardPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static UnityAction _003C_003E9__5_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal void _003CAwake_003Eb__5_0()
		{
			UIScreenController instance = UIScreenController.Instance;
			instance.CloseActivePopups("LeaderboardPopup");
		}
	}

	private sealed class _003CScrollOnTop_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public LeaderboardPopup _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0093: Expected I, but got Obj
			//IL_00bc: Expected I, but got Obj
			//IL_00ce: Expected I, but got Obj
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Canvas.ForceUpdateCanvases();
					ScrollRect componentInChildren = _003C_003E4__this.GetComponentInChildren<ScrollRect>();
					VerticalLayoutGroup component = componentInChildren.m_Content.GetComponent<VerticalLayoutGroup>();
					nint num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S1_v13 (Il2CppClass<UnityEngine.UI.VerticalLayoutGroup>)+1A4] (should have been resolved before IL gen)");
					ContentSizeFitter component2 = componentInChildren.m_Content.GetComponent<ContentSizeFitter>();
					nint num2 = (nint)component2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v91 @ S1_v18 (Il2CppClass<UnityEngine.UI.ContentSizeFitter>)+15C] (should have been resolved before IL gen)");
					nint num3 = (nint)componentInChildren;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S3_v3 (Il2CppClass<UnityEngine.UI.ScrollRect>)+244] (should have been resolved before IL gen)");
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 0.15f;
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

	public LeaderboardCell LeaderboardCellPrefab;

	public Transform contentList;

	private Button CloseButton;

	private int page = 1;

	private GameObject Notification;

	private UIPopupIn UIPopupIn;

	private unsafe void Awake()
	{
		Button closeButton = CloseButton;
		bool flag = _003C_003Ec._003C_003E9__5_0 == null;
		bool flag2 = !flag;
		UnityAction call = _003C_003Ec._003C_003E9__5_0;
		if (!flag2)
		{
			UnityAction unityAction = default;
			unityAction._002Ector(_003C_003Ec._003C_003E9, (nint)__ldftn(_003C_003Ec._003CAwake_003Eb__5_0));
			_003C_003Ec._003C_003E9__5_0 = unityAction;
			call = unityAction;
		}
		closeButton.m_OnClick.AddListener(call);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(LeaderboardPopup._003CAwake_003Eb__5_1));
		OutConplete.AddListener(unityAction2);
	}

	public override void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02d3: Expected I, but got Obj
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got I
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v5 (Il2CppClass<UI.Screens.LeaderboardPopup>)+104] (should have been resolved before IL gen)");
		page = 1;
		IEnumerator enumerator = contentList.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 == obj7;
			bool flag2 = !flag;
			object obj8 = obj9;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @25E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		((LeaderboardPopup)0).SetNewDataList();
	}

	public override void Show()
	{
		base.Show();
		ShowPopUp();
		IEnumerator routine = ScrollOnTop();
		Coroutine coroutine = StartCoroutine(routine);
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

	private void SetNewDataList()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		_ = 0;
		PlayerInfo instance2 = PlayerInfo.Instance;
		string userName = instance2.UserName;
		throw new ArgumentException();
	}

	private IEnumerator ScrollOnTop()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public override void Hide()
	{
		base.Hide();
	}

	private void _003CAwake_003Eb__5_1()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.LeaderboardPopup>)+EC] (should have been resolved before IL gen)");
	}
}
