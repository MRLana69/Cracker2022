using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

namespace UI.Screens.BoardScreenInternal;

public class HoverboardThemeButton : MonoBehaviour
{
	public delegate void OnPressEvent(int index);

	public enum ThemeState
	{
		NotOwned,
		OwnedAndInactive,
		OwnedAndActive,
		NotPurchaseable
	}

	private UISprite _background;

	private UISprite _icon;

	private GameObject giftBuble;

	private GameObject newBuble;

	private GameObject selectedCircle;

	private GameObject ownedCircle;

	private GameObject _lockIcon;

	private HoverboardThemes.ThemeIdentifier _identifier = (HoverboardThemes.ThemeIdentifier)100;

	private int themeIndex__BackingField = 110;

	private OnPressEvent m_OnPress;

	public int themeIndex
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_background;
		}
		private set
		{
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected Obj, but got Unknown
			//IL_0198: Expected Obj, but got I4
			//IL_01a1: Expected Obj, but got I4
			//IL_01af: Expected I, but got Obj
			//IL_01c5: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_0157: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 8;
			obj = 0;
			obj2 = 0;
			nint num = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v39 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string flurryUserId = Flurry.flurryUserId;
			HoverboardThemeButton hoverboardThemeButton;
			if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj5 = default;
				object obj4 = obj5 - 1;
				if ((nint)obj5 == 1 || ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 != 3 && (nint)obj4 != 4 && (nint)obj4 == 5))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
					if (obj != null)
					{
						hoverboardThemeButton = (HoverboardThemeButton)0;
						_ = 1;
						object obj6 = default;
						hoverboardThemeButton = (HoverboardThemeButton)obj6;
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			hoverboardThemeButton = (HoverboardThemeButton)obj2;
		}
	}

	public event OnPressEvent OnPress
	{
		add
		{
			//IL_000a: Expected I4, but got Obj
			themeIndex__BackingField = (int)value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPress;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 48;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public HoverboardThemeButton()
	{
		//IL_000b: Expected I4, but got F4
		//IL_0016: Expected I4, but got F4
		CancelInvoke();
	}

	public void InitButton(string iconName, Color32 bgColor, Color32 iconColor, int index)
	{
		//IL_0012: Expected Obj, but got VT
		//IL_0012: Expected I4, but got VT
		//IL_0012: Expected I4, but got Obj
		((HoverboardOverlayHelper)this).Init((int)iconName, (Boards.BoardId)bgColor, (Transform)iconColor);
		((ScrollListCharacterUI)this).RefreshSelection((byte)index != 0);
	}

	public void SetActiveBubbles(bool enableGiftBuble, bool enableNewBuble)
	{
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)giftBuble).FindKernel((string)null) != 0)
		{
			giftBuble.tag = (string)enableGiftBuble;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)newBuble).FindKernel((string)null) != 0)
		{
			newBuble.tag = (string)enableNewBuble;
		}
	}

	public void SetCurrentState(ThemeState newState)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnPress;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)newState);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 48;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void ButtonPressed()
	{
		CancelInvoke();
		themeIndex__BackingField = 0;
	}
}
