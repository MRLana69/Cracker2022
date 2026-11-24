using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Monetization.FlurryPlugin;
using Kiloo.Monetization.FlurryPlugin.Internal;
using UnityEngine;

namespace Kiloo.Serialization;

public static class KilooSerializerHTTPExtensions
{
	public unsafe static IRequest WithJsonContent(IRequest request, object jsonData)
	{
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected I, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_0116: Expected I, but got Obj
		//IL_012c: Expected Obj, but got I
		//IL_0282: Expected I, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0157: Expected I, but got Obj
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_01f8: Expected I, but got Obj
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_00ae: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj4 = default;
		object obj3 = obj4 + 12;
		object obj5 = 0;
		object obj9 = default;
		object obj11 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
			{
				object obj6 = obj4 + 16;
				object obj7 = obj5 << 2;
				object obj8 = obj6 + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				if (obj9 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					nint num2 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v27 (Il2CppClass<System.Type>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num3 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v37 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj2 = typeof(IEnumerable<>);
					((IntPtr*)num)->m_value = (void*)(nint)obj2;
					Type type = Type.internal_from_handle((IntPtr)num);
					if (obj11 == type)
					{
						break;
					}
				}
				object obj12 = obj5 + 1;
				obj5 = obj12;
				continue;
			}
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v23 (Il2CppClass<System.Type>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v31 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(object);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			return (IRequest)Type.internal_from_handle((IntPtr)num);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj14 = default;
		return (IRequest)(obj14 + 16);
	}

	public unsafe static bool TryParseJson<T>(IResponse response, out T result)
	{
		//IL_006f: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected I, but got Unknown
		//IL_00db: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v23 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type message = Type.internal_from_handle((IntPtr)num4);
		IAsyncResult asyncResult = ((FlurryAdsCallback)(object)response).BeginInvoke((string)(object)message, (AsyncCallback)System.Runtime.CompilerServices.Unsafe.AsPointer(ref result), (object)null);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		bool result2 = default;
		return result2;
	}

	public static T ParseJson<T>(IResponse response)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string msg = default;
		FlurryVideoAds.LogError(msg, (UnityEngine.Object)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		T result = default;
		return result;
	}
}
