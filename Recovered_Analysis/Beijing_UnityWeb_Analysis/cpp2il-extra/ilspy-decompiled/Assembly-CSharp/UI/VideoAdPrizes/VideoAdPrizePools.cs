using System.Collections.Generic;
using Cpp2ILInjected;

namespace UI.VideoAdPrizes;

public class VideoAdPrizePools
{
	public List<VideoAdPrize> introPrizePool;

	private List<VideoAdPrize> randomPrizePool;

	public List<VideoAdPrize> GetShuffledCloneOfRandomPrizePool(int seed)
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		object key;
		if (seed > 1)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v31 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = "CELEBRATION_POPUP_KEYS_AMOUNT";
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = "CELEBRATION_POPUP_KEY_AMOUNT";
		}
		string format = Strings.GetDefault((string)key);
		object obj2 = seed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		return (List<VideoAdPrize>)(object)string.Format(format, args);
	}
}
