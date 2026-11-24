using System;
using Cpp2ILInjected;
using UnityEngine;

public class DoubleCoinsButton : MonoBehaviour
{
	private UILabel _doubleCoinsLabel;

	private Color _notOwnedLabelColor;

	private bool _switch;

	private UISprite _overlaySprite;

	private bool _notOwnedOverlayActive;

	private bool _ownedOverlayActive;

	private Color _notOwnedOverlayColor;

	private Color _ownedOverlayColor;

	private UISprite _backgroundSprite;

	private Color _notOwnedBackgroundColor;

	private Color _ownedBackgroundColor;

	private Animation _animation;

	private GameObject _animationSprite;

	private bool _notOwnedAnimationActive;

	private bool _ownedAnimationActive;

	private GameObject _ownedCheck;

	private Collider _collider;

	private bool owned;

	private void Awake()
	{
		//IL_007f: Expected VT, but got F4
		int sleepTimeout = Screen.sleepTimeout;
		if (sleepTimeout > 1024)
		{
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)2;
		}
		else
		{
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
		_ = 1;
		int sleepTimeout2 = Screen.sleepTimeout;
		bool flag = sleepTimeout2 > 480;
		_notOwnedLabelColor = (Color)264f;
	}

	public void ChangeState(bool owned)
	{
	}

	private void Update()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("DOUBLE_COINS_TITLE");
		_doubleCoinsLabel.fontSize = (int)text;
	}

	public DoubleCoinsButton()
	{
		//IL_008f: Expected Obj, but got I4
		if (~(_switch ? 1u : 0u) == 0)
		{
			bool flag = _switch;
			bool flag2 = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			_switch = flag2;
			bool flag3 = owned;
			bool flag4 = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
			owned = flag4;
			bool flag5 = owned;
			((EventButtonBreadcrumb)this).PopupWasShown((string)flag5);
		}
	}
}
