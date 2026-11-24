using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities.Scriptables;

public abstract class ScriptablesAssetLoader<T, Loader> : AssetLoader<T, Loader> where T : ScriptableObject where Loader : AssetLoader<T, Loader>
{
	public T GetAsset(string name)
	{
		//IL_0013: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_00c4: Expected I, but got Obj
		//IL_013f: Expected Obj, but got I4
		if (name != null)
		{
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Object obj7 = default;
			if (obj7 != null)
			{
				return null;
			}
			bool isDestroyed = ((SingletonMonoBehaviour)obj7).IsDestroyed;
			bool isDestroyed2 = ((SingletonMonoBehaviour)(object)this).IsDestroyed;
			bool flag = isDestroyed == isDestroyed2;
			return (T)flag;
		}
		return null;
	}

	public G GetAsset<G>(string name) where G : T
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00ec: Expected Obj, but got I
		//IL_00fc: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S1_v3+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S1_v4+4]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v21 @ S2_v4 (should have been resolved before IL gen)");
		object obj10 = default;
		object obj9 = obj10 + 8;
		obj9 = name;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v15+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v16+10]");
		object obj15 = 0;
		object obj16 = obj15 & 0x1FFF;
		object obj17 = obj16 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S5_v4 (should have been resolved before IL gen)");
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S2_v7+60]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S2_v8+14]");
		object obj20 = 0;
		object obj21 = obj20 & 0x1FFF;
		object obj22 = obj21 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67 @ S3_v8 (should have been resolved before IL gen)");
		G result = default;
		return result;
	}

	protected ScriptablesAssetLoader()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S2_v2+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S3_v4 (should have been resolved before IL gen)");
	}
}
