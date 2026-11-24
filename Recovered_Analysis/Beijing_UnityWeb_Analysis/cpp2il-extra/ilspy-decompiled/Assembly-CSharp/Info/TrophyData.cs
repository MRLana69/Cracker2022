using Cpp2ILInjected;

namespace Info;

public class TrophyData
{
	public string name;

	public MysteryBox.Type obtainSource;

	public TrophyData()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected I4, but got Obj
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Trophies);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Trophies>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(Trophies);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Info.Trophies>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((NewMonoBehaviour)Trophies.ShouldSpawnTrophy((Trophies.Trophy)this))._002Ector();
	}
}
