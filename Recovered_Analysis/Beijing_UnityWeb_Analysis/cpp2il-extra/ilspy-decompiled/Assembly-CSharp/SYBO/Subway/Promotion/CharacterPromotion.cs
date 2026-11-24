using System;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using SYBO.Subway.Info;
using SYBO.Subway.Placeholders;
using UnityEngine;

namespace SYBO.Subway.Promotion;

public class CharacterPromotion : PromotionDefinition
{
	private string _characterIdStr;

	private AnimationClip[] _characterAnimations;

	private bool _useSpecialAssets;

	private int _themeIndex;

	private Color _backgroundColor;

	private Color _flashColor;

	private Color _beamColor;

	private Vector2 _stickerPosition;

	private Vector2 _stickerScale;

	public SYBO.Subway.Info.Characters.CharacterId CharacterId
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009e: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BoardManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Data.Managers.BoardManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BoardManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<Data.Managers.BoardManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = BoardManager.HasAllThemesBeenSeen((Boards.BoardId)_characterIdStr);
			return (SYBO.Subway.Info.Characters.CharacterId)((flag ? 1 : 0) ^ 1);
		}
	}

	public unsafe AnimationClip[] CharacterAnimations
	{
		get
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected I, but got Unknown
			//IL_0127: Expected I, but got Obj
			//IL_0142: Expected I, but got Obj
			//IL_0158: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object typeFromHandle = typeof(SYBO.Subway.Info.Characters.CharacterId);
			nint num3 = (nint)(typeFromHandle + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
			Type enumType = Type.internal_from_handle((IntPtr)num3);
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v2 (Il2CppClass<System.Enum>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v7 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Enum.GetName(enumType, _characterIdStr);
			throw new NullReferenceException();
		}
	}

	public bool UseSpecialAssets
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_characterAnimations != 0;
		}
	}

	public int ThemeIndex => _useSpecialAssets ? 1 : 0;

	public unsafe Color BackgroundColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 48;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color BeamColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 44;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Color FlashColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			//IL_002d: Expected F4, but got I
			//IL_0028: Expected native int or pointer, but got VT
			object obj = this + 76;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public unsafe Vector2 StickerPosition
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got Obj
			//IL_0013: Expected native int or pointer, but got VT
			object obj = this + 60;
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			_ = 0;
			return vector;
		}
	}

	public unsafe Vector2 StickerScale
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)_stickerPosition;
			return vector;
		}
	}

	public override string TitleId
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)_themeIndex;
		}
	}

	public override string SubtitleId
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SYBO.Subway.Info.Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AnimationClip[] characterAnimations = CharacterAnimations;
			SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
			return model.name;
		}
	}

	public override string PopupId
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SYBO.Subway.Info.Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AnimationClip[] characterAnimations = CharacterAnimations;
			SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
			return model.characterLimitedDescription;
		}
	}

	public override DateTime StartTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a3: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Boards>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Boards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.Boards>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Boards.Board board = Boards.boardData.get_Item((Boards.BoardId)_characterIdStr);
			return board.defaultExpirationTime;
		}
	}

	public override DateTime ExpireTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SYBO.Subway.Info.Characters);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AnimationClip[] characterAnimations = CharacterAnimations;
			SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
			return model.defaultStartDate;
		}
	}

	protected override bool IsActiveCheck
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"CharacterPromotionPopup" != 0;
		}
	}

	public override string GetPurchaseFailureFlurryEventValue()
	{
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00a6: Expected I4, but got Obj
		//IL_00b8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		AnimationClip[] characterAnimations = CharacterAnimations;
		nint num = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v10 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CharacterManager.IsCollectionComplete((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
		return (string)((flag ? 1 : 0) ^ 1);
	}

	public override string GetPurchaseSuccessFlurryEventValue()
	{
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_016e: Expected I4, but got Obj
		//IL_0185: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SYBO.Subway.Info.Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v26 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnimationClip[] characterAnimations = CharacterAnimations;
		SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
		object obj2 = model.unlockType - 2;
		string result;
		if (model.unlockType != PurchaseData.UnlockType.Coins)
		{
			bool flag = (nint)obj2 == 1;
			result = "";
			if (!flag)
			{
				bool flag2 = (nint)obj2 == 2;
				result = "";
				if (!flag2)
				{
					if ((nint)obj2 == 3)
					{
						result = "not enough keys";
					}
					else
					{
						result = (((nint)obj2 == 4) ? "bought using iap fail" : "");
					}
				}
			}
		}
		else
		{
			result = "not enough coins";
		}
		return result;
	}

	public override bool ShouldTrackPopupCloseFlurryEvent()
	{
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_016e: Expected I4, but got Obj
		//IL_0185: Expected Obj, but got I4
		//IL_00ef: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		//IL_010b: Expected I4, but got Obj
		//IL_00fd: Expected I4, but got Obj
		//IL_00e1: Expected I4, but got Obj
		nint num = (nint)typeof(SYBO.Subway.Info.Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SYBO.Subway.Info.Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v26 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AnimationClip[] characterAnimations = CharacterAnimations;
		SYBO.Subway.Info.Characters.Model model = SYBO.Subway.Info.Characters.characterData.get_Item((SYBO.Subway.Info.Characters.CharacterId)characterAnimations);
		object obj2 = model.unlockType - 2;
		bool result;
		if (model.unlockType != PurchaseData.UnlockType.Coins)
		{
			bool flag = (nint)obj2 == 1;
			result = (byte)(int)"" != 0;
			if (!flag)
			{
				bool flag2 = (nint)obj2 == 2;
				result = (byte)(int)"" != 0;
				if (!flag2)
				{
					if ((nint)obj2 == 3)
					{
						result = (byte)(int)"bought using keys" != 0;
					}
					else
					{
						result = (byte)(((nint)obj2 == 4) ? ((int)"bought using iap") : ((int)"")) != 0;
					}
				}
			}
		}
		else
		{
			result = (byte)(int)"bought using coins" != 0;
		}
		return result;
	}

	public CharacterPromotion()
	{
		((SelectionPlaceholderLifecycle)(object)this).Initialize();
	}
}
