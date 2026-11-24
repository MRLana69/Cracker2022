using System;
using Cpp2ILInjected;
using Data.Managers;
using Info;
using SYBO.Components.Analytics;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace SYBO.Subway.Promotion;

public class BoardPromotion : PromotionDefinition
{
	private Boards.BoardId _boardId;

	private Color _backgroundColor;

	private Color _flashColor;

	private Color _beamColor;

	public Boards.BoardId BoardId
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
			Boards.BoardId result = default;
			return result;
		}
	}

	public Color BackgroundColor
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Expected Obj, but got Unknown
			//IL_03b1: Expected Obj, but got I4
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Expected Obj, but got Unknown
			//IL_03e3: Expected I4, but got VT
			//IL_03f5: Expected I, but got Obj
			//IL_040b: Expected Obj, but got I
			//IL_0432: Expected Obj, but got I4
			//IL_007f: Expected Obj, but got I4
			//IL_0021: Expected I, but got Obj
			//IL_006d: Expected VT, but got I4
			//IL_006d: Expected Obj, but got VT
			//IL_0390: Expected Obj, but got VT
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Expected Obj, but got Unknown
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Expected Obj, but got Unknown
			//IL_04cb: Expected Obj, but got I4
			//IL_0203: Expected Obj, but got I
			//IL_0107: Expected Obj, but got I4
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Expected Obj, but got Unknown
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 32;
			object obj3 = obj2 + 16;
			obj3 = 0;
			object obj4 = obj2 + 8;
			obj4 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+D4]");
			Color color = default;
			bool flag = ((ConstrainingRouteBuilder)(object)this).IsConstrainingRange((int)color, 0);
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v131 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag).FindKernel(null) != 0)
			{
				RouteChunk chunkContainingPoint = ((RouteBuilder)color).GetChunkContainingPoint((Vector3)flag);
				goto IL_0453;
			}
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj7 = default;
				object obj9 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj7 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj8;
					if (obj3 != null)
					{
						obj8 = 1;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						obj8 = obj9 & 1;
					}
					obj3 = obj8;
				}
				object obj10 = obj4 + 4;
				object obj11 = obj10 + 1;
				obj10 = obj11;
				object obj12 = obj11 << 2;
				object obj13 = obj4 + obj12;
				obj13 = 115;
				object obj14 = default;
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+4]");
					object obj15 = (nint)0 << 2;
					object obj16 = obj4 + obj15;
					if ((nint)obj16 == 115)
					{
						object obj17 = obj4 + 4;
						if ((nint)obj17 > -1)
						{
							object obj18 = obj17 + -1;
							obj17 = obj18;
						}
						goto IL_052b;
					}
				}
				object obj19 = default;
				if (obj19 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			goto IL_052b;
			IL_0453:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Promotion.BoardPromotion)+58]");
			if ((nint)0 == 3)
			{
				((RouteBuilder)color).DespawnAllRouteChunks();
			}
			return color;
			IL_052b:
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			goto IL_0453;
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
			object obj = this + 32;
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
			object obj = this - -64;
			Color color = default;
			((Color*)(nint)color)->r = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
	}

	public override DateTime StartTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected VT, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AnalyticsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AnalyticsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Analytics.AnalyticsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime eventTime = AnalyticsEvent.GetEventTime();
			return eventTime - base._promotionId;
		}
	}

	public override DateTime ExpireTime
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			Boards.Board board = Boards.boardData.get_Item(_boardId);
			return board.defaultStartDate;
		}
	}

	public override string TitleId
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)_boardId;
		}
	}

	public override string SubtitleId
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			Boards.Board board = Boards.boardData.get_Item(_boardId);
			return board.name;
		}
	}

	public override string PopupId
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
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
			Boards.Board board = Boards.boardData.get_Item(_boardId);
			return board.limitedDescription;
		}
	}

	protected override bool IsActiveCheck
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"BoardPromotionPopup" != 0;
		}
	}

	public override string GetPurchaseFailureFlurryEventValue()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected Obj, but got I4
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
		bool flag = BoardManager.HasAllThemesBeenSeen(_boardId);
		return (string)((flag ? 1 : 0) ^ 1);
	}

	public override string GetPurchaseSuccessFlurryEventValue()
	{
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v26 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		object obj2 = board.unlockType - 2;
		string result;
		if (board.unlockType != PurchaseData.UnlockType.Coins)
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
		//IL_017d: Expected Obj, but got I4
		//IL_00ef: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_0090: Expected I4, but got Obj
		//IL_010b: Expected I4, but got Obj
		//IL_00fd: Expected I4, but got Obj
		//IL_00e1: Expected I4, but got Obj
		nint num = (nint)typeof(Boards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<Info.Boards>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Boards);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v26 (Il2CppClass<Info.Boards>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.Board board = Boards.boardData.get_Item(_boardId);
		object obj2 = board.unlockType - 2;
		bool result;
		if (board.unlockType != PurchaseData.UnlockType.Coins)
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

	public BoardPromotion()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		if ((nint)base._stickerTexture == (base._isEnabled ? 1 : 0))
		{
			string promotionId = base._promotionId;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v18 (System.String)+14]");
			if ((nint)0 > (nint)0)
			{
				object obj = this + 20;
				obj = base._promotionId;
				return;
			}
		}
		if ((object)base._stickerTexture == base._promotionId)
		{
			object obj2 = this + 20;
			obj2 = base._isEnabled;
		}
	}
}
