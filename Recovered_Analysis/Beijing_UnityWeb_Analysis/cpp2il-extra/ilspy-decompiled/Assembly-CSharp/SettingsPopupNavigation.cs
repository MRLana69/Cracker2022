using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using UI.Popups.SettingsPopupInternal;
using UI.Screens.BoardScreenInternal;
using UnityEngine;

public class SettingsPopupNavigation : MonoBehaviour
{
	private sealed class _003CWaitAndCall_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

		public SettingsPopupNavigation _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0062: Expected Obj, but got I4
				//IL_0076: Expected Obj, but got I4
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a0: Expected Obj, but got Unknown
				//IL_00a9: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						object obj = _003C_003E4__this + 24;
						obj = 0;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj2 = this + 12;
				obj2 = 0;
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

	private List<UIButtonOverlayOff> _buttons;

	private List<UITexture> _buttonHighlight;

	private int _selectedButton;

	private IEnumerator _enumerator;

	private void OnEnable()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		_selectedButton = 2;
		CancelInvoke();
	}

	private void Start()
	{
		List<UITexture> buttonHighlight = _buttonHighlight;
		if (buttonHighlight._size > 0)
		{
			DelayedInit();
		}
	}

	private void Init()
	{
		DelayedInit();
	}

	private IEnumerator WaitAndCall(Action callback)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_007f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SettingsPopupNavigation)+20]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SettingsPopupNavigation)+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S2_v2+8C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+84]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S2_v3+10]");
		bool flag = ((HoverboardOverlayHelper)num).BoardHasFreeThemes(Boards.BoardId.normal);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v4 (System.Boolean)+C]");
		object obj4 = -1;
		bool flag2 = ((Delegate)callback).invoke_impl == (IntPtr)(nint)obj4;
		return (IEnumerator)flag2;
	}

	private void DelayedInit()
	{
		//IL_002b: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		int num2 = default;
		object obj = num2 + 16;
		obj = this;
		object obj2 = this + 24;
		int maxByteCount = ((ASCIIEncoding)(object)this).GetMaxByteCount(num2);
		obj2 = maxByteCount;
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_0286: Expected Obj, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_013c: Expected Obj, but got I4
		//IL_0337: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected Obj, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BDA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		_00210 item = default;
		((List<T>)(object)list).Add((T)item);
		object obj5 = this + 12;
		obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list2 = default;
		list2._002Ector();
		object obj6 = this + 16;
		obj6 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 118;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 118)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0304;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0304;
		IL_0304:
		this._002Ector();
		_selectedButton = 1;
		UITexture uITexture = _buttonHighlight.get_Item(0);
		uITexture.tag = (string)1;
	}

	private void ResetHighlights()
	{
		//IL_0077: Expected Obj, but got I4
		//IL_00ff: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I4
		//IL_01f8: Expected Obj, but got VT
		//IL_01a3: Expected Obj, but got I4
		//IL_0258: Expected Obj, but got I4
		//IL_0298: Expected Obj, but got I4
		if (_enumerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		}
		if (Input.GetMouseButtonUp(0))
		{
			int index = _selectedButton - 1;
			UITexture uITexture = _buttonHighlight.get_Item(index);
			uITexture.tag = null;
		}
		if (Input.GetKeyDown((string)274))
		{
			this._002Ector();
			List<UIButtonOverlayOff> buttons = _buttons;
			int selectedButton = ((_selectedButton >= buttons._size) ? 1 : (_selectedButton + 1));
			_selectedButton = selectedButton;
			int index2 = _selectedButton - 1;
			UITexture uITexture2 = _buttonHighlight.get_Item(index2);
			uITexture2.tag = (string)1;
		}
		if (Input.GetKeyDown((string)273))
		{
			this._002Ector();
			int selectedButton2;
			if (_selectedButton < 2)
			{
				List<UIButtonOverlayOff> buttons2 = _buttons;
				selectedButton2 = buttons2._size;
			}
			else
			{
				selectedButton2 = _selectedButton - 1;
			}
			_selectedButton = selectedButton2;
			int index3 = _selectedButton - 1;
			UITexture uITexture3 = _buttonHighlight.get_Item(index3);
			uITexture3.tag = (string)1;
		}
		if (Input.GetKeyDown((string)32) || Input.GetKeyDown((string)13))
		{
			int index4 = _selectedButton - 1;
			UIButtonOverlayOff uIButtonOverlayOff = _buttons.get_Item(index4);
			_0021_00210 componentInChildren = (_0021_00210)((Component)uIButtonOverlayOff).GetComponentInChildren<T>();
			((SettingsButton)componentInChildren).SetupButton();
		}
	}

	public SettingsPopupNavigation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 52)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
