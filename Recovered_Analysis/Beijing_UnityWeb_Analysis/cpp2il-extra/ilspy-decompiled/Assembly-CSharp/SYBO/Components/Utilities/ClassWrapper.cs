using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class ClassWrapper<T> : IEquatable<ClassWrapper<T>> where T : IEquatable<T>
{
	public T Value;

	public bool Equals(ClassWrapper<T> other)
	{
		//IL_00bd: Expected Obj, but got I4
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_00af: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0072: Expected Obj, but got I
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		object obj = 0;
		GameObject gameObject = ((Component)(object)other).gameObject;
		Transform transform = ((SpawnPool)this).Spawn(gameObject);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)transform).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12+4]");
			object obj4 = 0;
			object obj5 = obj4 & 0x3FFF;
			object obj6 = obj5 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S2_v8 (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (byte)(int)obj != 0;
	}

	public override int GetHashCode()
	{
		//IL_0018: Expected Obj, but got I
		bool isCurrentPromotionActive = ((PromotionManager)this).IsCurrentPromotionActive;
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		int result = default;
		return result;
	}

	public ClassWrapper()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
