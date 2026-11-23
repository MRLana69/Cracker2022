using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Screens;

public class UIScreen : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<SCREEN> _003C_003E9__18_0;

		static _003C_003Ec()
		{
			_003C_003Ec obj = default;
			_003C_003E9 = obj;
		}

		internal bool _003CHide_003Eb__18_0(SCREEN item)
		{
			return false;
		}
	}

	private SCREEN screen;

	private bool addScreen = true;

	protected GameObject _footerPrefab;

	protected int _selectedFooterButton;

	protected UIFooterHandler _footerHandler;

	private bool _footerInited;

	public bool _isActive;

	[NonSerialized]
	public string screenName = string.Empty;

	public UnityEvent InComplete;

	public UnityEvent OutConplete;

	public bool isActive => _isActive;

	public string parentScreen
	{
		protected get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public virtual void Init()
	{
		//IL_0005: Expected I, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		nint num = (nint)this;
		object obj = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UI.Screens.UIScreen>)+104] (should have been resolved before IL gen)");
	}

	public virtual void Show()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		if (~(addScreen ? 1u : 0u) == 0)
		{
			UIScreenController instance = UIScreenController.Instance;
			UIScreenController instance2 = UIScreenController.Instance;
			instance.OldScreen = instance2.CurrenScreen;
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.CurrenScreen = screen;
			UIScreenController instance4 = UIScreenController.Instance;
			instance4.ListScreen.Add(screen);
		}
		_isActive = true;
		GameObject gameObject2 = base.gameObject;
		string text = gameObject2.name;
		if (!text.Contains("NotebookPanel2"))
		{
			GameObject gameObject3 = base.gameObject;
			string text2 = gameObject3.name;
			string text3 = "UI Screen " + text2;
			bool flag = text3 != string.Empty;
		}
		if (~(_footerInited ? 1u : 0u) != 0)
		{
			InitFooter();
			_footerInited = true;
		}
	}

	public virtual void Hide()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		if (~(addScreen ? 1u : 0u) == 0)
		{
			UIScreenController instance = UIScreenController.Instance;
			List<SCREEN> listScreen = instance.ListScreen;
			int num = 0;
			while (true)
			{
				int num2 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v15 (System.Collections.Generic.List`1<SCREEN>)+C]");
				if ((nint)num2 >= (nint)0)
				{
					break;
				}
				SCREEN sCREEN = listScreen.get_Item(num);
				if (sCREEN == screen)
				{
					listScreen.RemoveAt(num);
				}
				int num3 = num + 1;
				num = num3;
			}
			bool flag = _003C_003Ec._003C_003E9__18_0 == null;
			bool flag2 = !flag;
			Predicate<SCREEN> match = _003C_003Ec._003C_003E9__18_0;
			if (!flag2)
			{
				throw new ArgumentException();
			}
			int num4 = listScreen.RemoveAll(match);
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.ListScreen = listScreen;
			UIScreenController instance3 = UIScreenController.Instance;
		}
		_isActive = false;
	}

	public virtual void LoseFocus()
	{
	}

	public virtual void GainFocus()
	{
	}

	public virtual void AdjustToResolution()
	{
	}

	private void InitFooter()
	{
		//IL_0053: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		if (!(_footerPrefab != null))
		{
			return;
		}
		GameObject parent = base.gameObject;
		GameObject gameObject = NGUITools.AddChild(parent, _footerPrefab);
		UIFooterHandler component = gameObject.GetComponent<UIFooterHandler>();
		_footerHandler = component;
		object obj = _selectedFooterButton - 1;
		object obj2;
		if (_selectedFooterButton != 1)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					return;
				}
				UIFooterHandler footerHandler = _footerHandler;
				footerHandler.button3.GoToSelectedState();
				obj2 = _footerHandler + 24;
			}
			else
			{
				UIFooterHandler footerHandler2 = _footerHandler;
				footerHandler2.button2.GoToSelectedState();
				obj2 = _footerHandler + 20;
			}
		}
		else
		{
			UIFooterHandler footerHandler3 = _footerHandler;
			footerHandler3.button1.GoToSelectedState();
			obj2 = _footerHandler + 16;
		}
		object obj3 = obj2;
		_ = 1;
	}

	public static bool IsScreenHeightOutOfProportion()
	{
		int height = Screen.height;
		float num = (float)height * 1f;
		int width = Screen.width;
		float num2 = (float)width * 1f;
		float num3 = num / num2;
		return num3 > 1.5f;
	}

	protected GameObject InitializeCoinbox(UIWidget widgetAnchor, bool fundsEnabled, bool coinsEnabled, bool keysEnabled, float xOffset = 0f, float yOffset = 0f, float zOffset = 0f)
	{
		return null;
	}
}
