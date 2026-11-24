using System;
using Cpp2ILInjected;
using SYBO.Components.Singletons;

namespace SYBO.Components.Json;

public class EnumAsStringAttribute : Attribute
{
	public EnumAsStringAttribute()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Singleton<SampleSingleton1Runtime>);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Singletons.SampleSingleton1Runtime>>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Singleton<SampleSingleton1Runtime>);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Singletons.SampleSingleton1Runtime>>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
