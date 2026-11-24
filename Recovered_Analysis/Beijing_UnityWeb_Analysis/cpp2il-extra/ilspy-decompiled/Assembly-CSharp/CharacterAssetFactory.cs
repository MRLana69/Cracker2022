using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class CharacterAssetFactory : MonoBehaviour
{
	public static void GetAssetPrefab(string name, bool asynchronous, Action<CharacterAssetsBundle> onSucces)
	{
		//IL_0166: Expected VT, but got Obj
		//IL_0173: Expected I4, but got Obj
		//IL_0173: Expected I4, but got VT
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_018e: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_003b: Expected I4, but got Obj
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00ec: Expected Obj, but got I4
		//IL_0110: Expected Obj, but got I
		//IL_0120: Expected Obj, but got I
		//IL_0130: Expected Obj, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected Obj, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected Obj, but got Unknown
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		string materialPath = CharacterMaterial.GetMaterialPath((CharacterMaterial.CharacterMaterialShaderType)val, (DeviceInfo.PerformanceLevel)onSucces);
		object obj = materialPath + 12;
		object obj2 = 0;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = materialPath + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			Dictionary<string, int> dictionary = ((AssetBundleVersionControl)(object)name).ReadAssetBundleManifest((byte)(int)obj5 != 0);
			if ((nint)dictionary != -1)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v9 (Il2CppMethodInfo)+C]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S2_v10+60]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v11+44]");
				object obj8 = 0;
				object obj9 = obj8 & 0x1FFF;
				object obj10 = obj9 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S3_v7 (should have been resolved before IL gen)");
				bool flag = (nint)obj11 <= -1;
				bool flag2 = !flag;
				object obj12 = 22691;
				if (!flag2)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S4_v6 (Il2CppMethodInfo)+C]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S4_v7+60]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S4_v8+48]");
					obj12 = 0;
					object obj15 = obj12 & 0x7FF;
					object obj16 = obj15 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29 @ S5_v2 (should have been resolved before IL gen)");
				}
			}
			object obj17 = obj2 + 1;
			obj2 = obj17;
		}
	}

	public CharacterAssetFactory()
	{
		CancelInvoke();
	}
}
