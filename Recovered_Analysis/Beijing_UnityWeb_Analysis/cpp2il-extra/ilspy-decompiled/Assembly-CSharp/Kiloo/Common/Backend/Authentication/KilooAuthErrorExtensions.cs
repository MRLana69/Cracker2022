using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;

namespace Kiloo.Common.Backend.Authentication;

public static class KilooAuthErrorExtensions
{
	public static KilooAuthError KilooAuthError(Error error)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00b3: Expected Obj, but got I
		bool allowAnonymous = ((KilooAuth)(object)error).allowAnonymous;
		if ((allowAnonymous ? 1 : 0) == 2)
		{
			object obj = error + 32;
			object obj2 = obj;
			bool flag;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				return Kiloo.Common.Backend.Authentication.KilooAuthError.Unknown;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Func<KeyValuePair<string, IKilooAuthPlatform>, bool> func = default;
			object obj3 = func + 16;
			obj3 = error;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [error @ L0 (Kiloo.Common.Backend.Error)+1C]");
			return Enumerable.All((IEnumerable<KeyValuePair<string, IKilooAuthPlatform>>)0, func) ? Kiloo.Common.Backend.Authentication.KilooAuthError.NoPlatformsLoggedIn : Kiloo.Common.Backend.Authentication.KilooAuthError.Unknown;
		}
		return Kiloo.Common.Backend.Authentication.KilooAuthError.Unknown;
	}

	public unsafe static int GetErrorCode(KilooAuthError error)
	{
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected I, but got Unknown
		//IL_015b: Expected I, but got Obj
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v25 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(KilooAuthError);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type type = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [error @ L0 (Kiloo.Common.Backend.Authentication.KilooAuthError)+C]");
		((IntPtr*)num3)->m_value = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v5 (Il2CppClass<System.Enum>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v10 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Enum flags = default;
		if (((Enum)(object)type).InternalHasFlag(flags))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [error @ L0 (Kiloo.Common.Backend.Authentication.KilooAuthError)+C]");
			return 0;
		}
		return 0;
	}
}
