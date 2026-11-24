using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

namespace Info;

[Serializable]
public class OutfitSet
{
	public Outfit[] outfitList;

	public Characters.CharacterId characterId;

	public bool HasOutfitWithName(string outfitName)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0140: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected I4, but got Unknown
		//IL_00eb: Expected Obj, but got I4
		//IL_00f7: Expected I4, but got Obj
		if (outfitName != null)
		{
			nint num = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v9 (Il2CppClass<Info.Outfits>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Outfits);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v26 (Il2CppClass<Info.Outfits>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Outfits.HasCharacter((Characters.CharacterId)this);
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (System.Boolean)+C]");
				if (0 < (nint)outfitName)
				{
					return false;
				}
				int index = outfitName - 1;
				Outfit outfit = ((List<Outfit>)flag).get_Item(index);
				return (byte)(int)outfit != 0;
			}
			return false;
		}
		return false;
	}

	public OutfitSet()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}
}
