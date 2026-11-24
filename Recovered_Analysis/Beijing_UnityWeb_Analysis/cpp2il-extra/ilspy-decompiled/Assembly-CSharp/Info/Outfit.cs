using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

namespace Info;

[Serializable]
public class Outfit
{
	public Color32 buttonBgColor;

	public Color32 buttonIconColor;

	public PurchaseData.UnlockType unlockType;

	public int uiPriority;

	public bool isNewInThisUpdate;

	public int price;

	public string title;

	public Outfit Clone()
	{
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_00bd: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Outfits>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (Outfits.HasCharacter((Characters.CharacterId)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11 (System.Boolean)+C]");
			return (Outfit)0;
		}
		return null;
	}

	public void Copy(Outfit copyFrom)
	{
	}
}
