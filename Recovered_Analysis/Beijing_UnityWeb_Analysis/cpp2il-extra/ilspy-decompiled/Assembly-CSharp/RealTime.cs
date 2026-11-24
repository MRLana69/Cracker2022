using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class RealTime : MonoBehaviour
{
	public static float time
	{
		get
		{
			//IL_013b: Expected I, but got Obj
			//IL_0151: Expected Obj, but got I
			//IL_01d0: Expected I, but got Obj
			//IL_01e6: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(NGUITools.mLoaded ? 1u : 0u) != 0)
			{
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v30 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v42 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUITools.mLoaded = true;
				float mGlobalVolume = ((Slider)(object)"Sound").ClampValue(1f);
				NGUITools.mGlobalVolume = mGlobalVolume;
			}
			nint num5 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v16 (Il2CppClass<NGUITools>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v23 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return NGUITools.mGlobalVolume;
		}
	}

	public static float deltaTime => Time.unscaledDeltaTime;

	public RealTime()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		object obj = this + 16;
		obj = 0;
		object obj2 = this + 20;
		obj2 = 0;
	}
}
