using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class SaveMePopupNavigation : MonoBehaviour
{
	private sealed class _003CInit_003Ed__3(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SaveMePopupNavigation _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_0048: Expected Obj, but got I4
				//IL_005c: Expected Obj, but got I4
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Expected Obj, but got Unknown
				SaveMePopupNavigation saveMePopupNavigation = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						UITexture uITexture = saveMePopupNavigation._buttonHighlight.get_Item(1);
						string tag = uITexture.tag;
						string tag2 = ((GameObject)(object)tag).tag;
						UITexture uITexture2 = saveMePopupNavigation._buttonHighlight.get_Item(0);
						string tag3 = (string)(tag2 ^ 1);
						uITexture2.tag = tag3;
						UITexture uITexture3 = saveMePopupNavigation._buttonHighlight.get_Item(1);
						uITexture3.tag = tag2;
						UIButtonOverlayOff uIButtonOverlayOff = saveMePopupNavigation.buttons.get_Item(1);
						BoxCollider component = uIButtonOverlayOff.GetComponent<BoxCollider>();
						component.isTrigger = true;
						int selectedButton = ((tag2 == null) ? 1 : 2);
						saveMePopupNavigation._selectedButton = selectedButton;
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

	public List<UIButtonOverlayOff> buttons;

	private List<UITexture> _buttonHighlight;

	private int _selectedButton;

	private IEnumerator Init()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = ((UnityEngine.Object)this).m_CachedPtr != (IntPtr)0;
		return (IEnumerator)flag;
	}

	private void Update()
	{
		//IL_000b: Expected I4, but got F4
		_selectedButton = 45;
		CancelInvoke();
	}

	public SaveMePopupNavigation()
	{
		//IL_012c: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		//IL_0159: Expected Obj, but got I4
		if (!Input.GetKeyDown((string)13) && !Input.GetKeyDown((string)32))
		{
			return;
		}
		bool isInitialized = AdSystemManager.isInitialized;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (System.Boolean)+E]");
		if ((nint)0 != 0)
		{
			return;
		}
		UIButtonOverlayOff uIButtonOverlayOff = buttons.get_Item(1);
		string text = uIButtonOverlayOff.tag;
		string text2 = ((GameObject)(object)text).tag;
		int selectedButton = ((text2 == null) ? 1 : 2);
		_selectedButton = selectedButton;
		object obj = _selectedButton - 1;
		if (_selectedButton != 1)
		{
			if ((nint)obj == 1)
			{
				SaveMePopup component = GetComponent<SaveMePopup>();
				component.OnSpendKeysClicked();
			}
		}
		else
		{
			SaveMePopup component2 = GetComponent<SaveMePopup>();
			component2.ReviveWithKeys();
		}
	}
}
