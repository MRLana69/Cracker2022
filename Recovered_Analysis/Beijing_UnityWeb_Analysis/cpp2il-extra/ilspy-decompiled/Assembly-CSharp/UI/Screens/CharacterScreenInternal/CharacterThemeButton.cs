using System;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Info;
using UI.Screens.BoardScreenInternal;
using UnityEngine;

namespace UI.Screens.CharacterScreenInternal;

public class CharacterThemeButton : MonoBehaviour
{
	private UISprite _background;

	private UISprite _icon;

	private GameObject _giftBubble;

	private GameObject _newBubble;

	private GameObject _lockIcon;

	private int themeIndex__BackingField;

	private Action<int> m_OnPress;

	public int themeIndex
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_background;
		}
		private set
		{
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected Obj, but got Unknown
			//IL_017b: Expected Obj, but got I4
			//IL_0184: Expected Obj, but got I4
			//IL_0192: Expected I, but got Obj
			//IL_01a8: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected Obj, but got Unknown
			//IL_013a: Expected Obj, but got I4
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
			CharacterThemeButton characterThemeButton;
			if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj5 = default;
				object obj4 = obj5 - 3;
				if ((nint)obj5 == 3 || ((nint)obj4 != 1 && (nint)obj4 != 2 && (nint)obj4 != 3 && (nint)obj4 == 4))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @758F");
					if (obj != null)
					{
						characterThemeButton = (CharacterThemeButton)0;
						_ = 1;
						object obj6 = default;
						characterThemeButton = (CharacterThemeButton)obj6;
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			characterThemeButton = (CharacterThemeButton)obj2;
		}
	}

	public event Action<int> OnPress
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
				object obj3 = this + 36;
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

	public void SetOutfitColors(Color32 bgColor, Color32 iconColor, int index)
	{
		//IL_016c: Expected Obj, but got I
		//IL_017a: Expected Obj, but got VT
		//IL_0198: Invalid comparison between VT and I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_00ef: Expected I4, but got Obj
		//IL_00ef: Expected Obj, but got VT
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		object obj = (nint)((UnityEngine.Object)this).m_CachedPtr + 16;
		object obj2 = bgColor << 2;
		object obj3 = obj + obj2;
		CharacterScrollListSlot characterScrollListSlot = (CharacterScrollListSlot)obj3;
		if (iconColor != (Color32)(object)0)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (characterScrollListSlot.model != null)
			{
				if (characterScrollListSlot.request == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					CharacterOverlayHelper characterOverlayHelper = default;
					characterOverlayHelper.Init((int)characterScrollListSlot.characterId, (Characters.CharacterId)characterScrollListSlot.themeIndex, (Transform)bgColor, (byte)(int)this != 0);
					object obj5 = characterScrollListSlot + 32;
					obj5 = characterOverlayHelper;
				}
				CharacterModelRequest request = characterScrollListSlot.request;
				request._priority = index;
			}
		}
		else
		{
			if (characterScrollListSlot.request != null)
			{
				characterScrollListSlot.request.OnCharacterBundlesLoaded();
				object obj6 = characterScrollListSlot + 32;
				obj6 = 0;
			}
			characterScrollListSlot._002Ector();
		}
	}

	public void SetActiveBubbles(bool enableGiftBuble, bool enableNewBuble)
	{
		//IL_0075: Expected Obj, but got I4
		//IL_00a7: Expected I4, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_00b5: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I
		bool flag = ((HoverboardOverlayHelper)this).BoardHasFreeThemes(enableGiftBuble ? Boards.BoardId.bouncer : Boards.BoardId.normal);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (System.Boolean)+10]");
		if ((nint)0 == (enableGiftBuble ? 1 : 0))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (System.Boolean)+14]");
			if ((nint)0 == (enableNewBuble ? 1 : 0))
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (System.Boolean)+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (System.Boolean)+20]");
			((CharacterModelRequest)0).OnCharacterBundlesLoaded();
		}
		((CharacterScrollListSlot)flag)._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		bool index = enableGiftBuble;
		bool type = enableNewBuble;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v6 (System.Boolean)+C]");
		CharacterOverlayHelper characterOverlayHelper = default;
		characterOverlayHelper.Init(index ? 1 : 0, type ? Characters.CharacterId.tricky : Characters.CharacterId.slick, (Transform)0, (byte)(int)this != 0);
		object obj = (flag ? 1 : 0) + 32;
		obj = characterOverlayHelper;
	}

	public void SetLockIconEnabled(bool state)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnPress;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)state);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 36;
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
		_ = 1f;
		_ = 1f;
		CancelInvoke();
	}

	public CharacterThemeButton()
	{
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_newBubble).FindKernel((string)null) != 0 && _newBubble.activeInHierarchy)
		{
			_newBubble.tag = null;
		}
		if (this.m_OnPress != null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v5 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S3_v5 (should have been resolved before IL gen)");
		}
	}
}
