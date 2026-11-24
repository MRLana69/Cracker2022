using Cpp2ILInjected;
using Missions;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInBrag : UISlideIn
{
	private UILabel _text;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0164: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_0071: Expected I4, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_012d: Expected I4, but got Obj
		//IL_013f: Expected Obj, but got I
		//IL_009d: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got I
		//IL_00c9: Expected I4, but got Obj
		//IL_00db: Expected Obj, but got I
		//IL_00f5: Expected I4, but got Obj
		//IL_010b: Expected Obj, but got I4
		//IL_010b: Expected Obj, but got I
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		object obj = slideIn.awardTierType - 1;
		if (slideIn.awardTierType != AwardTierType.Bronze)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj == 3)
					{
						((UISprite)(object)_text).fillCenter = (byte)(int)"icon_diamond_can" != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInBrag)+48]");
						((GameObject)0).tag = (string)1;
					}
				}
				else
				{
					((UISprite)(object)_text).fillCenter = (byte)(int)"icon_gold_can" != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInBrag)+48]");
					((GameObject)0).tag = null;
				}
			}
			else
			{
				((UISprite)(object)_text).fillCenter = (byte)(int)"icon_silver_can" != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInBrag)+48]");
				((GameObject)0).tag = null;
			}
		}
		else
		{
			((UISprite)(object)_text).fillCenter = (byte)(int)"icon_bronze_can" != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInBrag)+48]");
			((GameObject)0).tag = null;
		}
		object obj2 = this - -64;
		((UILabel)obj2).fontSize = (int)slideIn.stringValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInBrag)+44]");
		((RewardForVideoButton)0).Init(null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
