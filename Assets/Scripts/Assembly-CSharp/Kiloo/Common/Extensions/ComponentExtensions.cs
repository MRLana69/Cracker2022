using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Extensions;

public static class ComponentExtensions
{
	public static T AddComponent<T>(Component component) where T : Component
	{
		GameObject gameObject = component.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.ComponentExtensions::AddComponent>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T GetOrAdd<T>(Component c) where T : Component
	{
		GameObject gameObject = c.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Kiloo.Common.Extensions.ComponentExtensions::GetOrAdd>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}
}
