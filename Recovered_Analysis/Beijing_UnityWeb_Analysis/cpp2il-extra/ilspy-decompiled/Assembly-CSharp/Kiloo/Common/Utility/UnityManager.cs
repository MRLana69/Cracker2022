using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

namespace Kiloo.Common.Utility;

public class UnityManager<T> : MonoBehaviour where T : UnityManager<T>
{
	private static T _instance;

	public static T instance
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_0038: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v5+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
			object obj4 = 0;
			object obj5 = obj3 & 0xFFF;
			object obj6 = obj5 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v7+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v13+60]");
			object obj9 = 0;
			object obj10 = obj8 & 0x3FFF;
			object obj11 = obj10 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S2_v5 (should have been resolved before IL gen)");
			SaveGame saveGame = default;
			return (T)(object)saveGame.debug_dataSerialized;
		}
	}
}
