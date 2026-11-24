using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Data.Save.Internal;
using Info;
using UI.ScrollListSelectPopup;
using UI.SlideIns;
using UnityEngine;
using UnityEngine.Rendering;

public static class Utils
{
	private enum LocaleComponents
	{
		language,
		countryCode
	}

	private static int randomNumber;

	public static string stackTrace
	{
		get
		{
			//IL_014e: Expected I, but got Obj
			//IL_0164: Expected Obj, but got I
			//IL_01cc: Expected I, but got Obj
			//IL_01e2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_01be: Expected Obj, but got I4
			//IL_0073: Expected I, but got Obj
			//IL_0089: Expected Obj, but got I
			//IL_0101: Expected I, but got Obj
			//IL_00b4: Expected I, but got Obj
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v44 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (randomNumber == -1)
			{
				int num3 = UnityEngine.Random.RandomRangeInt(1, 10000);
				nint num4 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v32 (Il2CppClass<Utils>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v38 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				randomNumber = num3;
			}
			nint num6 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v16 (Il2CppClass<Utils>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v23 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)randomNumber;
		}
	}

	public static StringComparison stringComparison
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EventSource eventSource = default;
			eventSource._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			StringComparison result = default;
			return result;
		}
	}

	public static StringComparison stringComparisonIgnoreCase => StringComparison.InvariantCulture;

	public static StringComparer stringComparer
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (StringComparer)3;
		}
	}

	public static StringComparer stringComparerIgnoreCase
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.StringComparer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.StringComparer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A770");
			StringComparer result = default;
			return result;
		}
	}

	public static T FindObject<T>(MonoBehaviour obj) where T : class
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SlideInData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.SlideIns.SlideInData>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(SlideInData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UI.SlideIns.SlideInData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ScrollListSelectPopup instance = ScrollListSelectPopup.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L0 (UnityEngine.MonoBehaviour)+18]");
		int layer = ((GameObject)0).layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v42 @ S3_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		T result = default;
		return result;
	}

	public unsafe static T FindObject<T>(bool warnIfNotFound = true) where T : class
	{
		//IL_00d3: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected I, but got Unknown
		//IL_016d: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v25 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type type = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((UnityEngine.Object)(object)type).ToString();
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T result = default;
		return result;
	}

	public unsafe static T FindInThisOrParent<T>(Transform t, Func<T, bool> predicate) where T : Component
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got I4
		//IL_0091: Expected Obj, but got I
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		Transform transform = (Transform)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v11 (Il2CppClass<System.Type>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v24 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj3;
		nint num3 = (nint)(obj2 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num3);
		string msg = "The Super Mystery Box Event does not contain a value of the specified type: " + (string)(object)type;
		SDebug.LogFormat(msg, null);
		return (T)obj;
	}

	public static T FindInParents<T>(MonoBehaviour obj, Func<T, bool> predicate) where T : Component
	{
		//IL_01b8: Expected Obj, but got I4
		//IL_01c6: Expected Obj, but got I
		//IL_021b: Expected I, but got Obj
		//IL_0231: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00d7: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		object result = 0;
		nint num = default;
		object obj2 = num + 24;
		bool flag = predicate == null;
		MonoBehaviour monoBehaviour = obj;
		ComputeShader computeShader = default;
		object obj13 = default;
		while (true)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v49 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)monoBehaviour).FindKernel((string)null) == 0)
			{
				break;
			}
			object obj4 = obj2;
			object obj5 = obj4;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S2_v7 (should have been resolved before IL gen)");
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader.FindKernel(null) != 0)
			{
				if (!flag)
				{
					object obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v12+8]");
					object obj10 = 0;
					object obj11 = obj10 & 0x1FFF;
					object obj12 = obj11 + 22691;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v127 @ S3_v10 (should have been resolved before IL gen)");
					if (obj13 == null)
					{
						goto IL_0171;
					}
				}
				return (T)(object)computeShader;
			}
			goto IL_0171;
			IL_0171:
			Transform parentInternal = ((Transform)(object)monoBehaviour).parentInternal;
			monoBehaviour = (MonoBehaviour)(object)parentInternal;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (T)result;
	}

	public unsafe static T FindComponentInThisOrParents<T>(MonoBehaviour obj) where T : Component
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_012a: Expected Obj, but got I4
		//IL_0138: Expected Obj, but got I
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected I, but got Unknown
		//IL_01d7: Expected I, but got Obj
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = 0;
		nint num = default;
		object obj4 = num + 24;
		object obj5 = obj4;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<System.Type>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v48 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = obj5;
		nint num4 = (nint)(obj3 + 8);
		((IntPtr*)num4)->m_value = (void*)(nint)obj3;
		Type type = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		HideFlags hideFlags = ((UnityEngine.Object)(object)type).hideFlags;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj9 = default;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v31+C]");
			if ((nint)0 != 0)
			{
				return (T)(obj9 + 16);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (T)obj2;
	}

	public static T FindComponentInThisOrParents<T>(Transform t) where T : Component
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = t.gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v12 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S2_v5 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static string GetLongName(Transform transform)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = transform;
		return text;
	}

	public static string GetLongNameList(Component[] components)
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b4: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)components != null)
		{
			return "";
		}
		Transform parentInternal = ((Transform)(object)components).parentInternal;
		nint num3 = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v6 (Il2CppClass<Utils>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v15 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string longNameList = GetLongNameList((Component[])(object)parentInternal);
		UnityEngine.Object provider = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)components);
		return (string)((IConvertible)longNameList).ToType((Type)(object)"/", (IFormatProvider)provider);
	}

	public unsafe static void Bar(string text, float ratio, int offset, Color color)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_0194: Expected Obj, but got F4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0082: Expected I4, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00d6: Expected I4, but got Obj
		//IL_00d6: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = text;
		object obj3 = ((int*)offset)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [offset @ L2 (System.Int32)+8]");
		_ = 0;
		object obj4 = obj2 + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		obj3 = color.r;
		_ = color.b;
		object obj5 = obj2 + 28;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_ = 1;
		object obj6 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+20]");
			object obj7 = 0;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v26+C]");
			if ((nint)obj8 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+20]");
			object obj9 = (nint)0 + (nint)16;
			object obj10 = obj6 << 2;
			object obj11 = obj9 + obj10;
			((Renderer)obj11).shadowCastingMode = ShadowCastingMode.On;
			object obj12 = obj6 + 1;
			obj6 = obj12;
		}
		object obj13 = text - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+3C]");
		if (((Animator)0).GetInteger((int)obj13) == 0)
		{
			object obj14 = text - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [text @ L0 (System.String)+3C]");
			((Animator)0).SetInteger((int)obj14, 1);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj16 = default;
		object obj15 = obj16 + 16;
		obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11247");
		IEnumerator routine = default;
		Coroutine coroutine = ((MonoBehaviour)(object)text).StartCoroutine_Auto(routine);
	}

	public static DateTime StringToDateTime(string value, DateTime defaultValue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = value + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC95");
		DateTime result = default;
		return result;
	}

	private unsafe static int GetXorRandomValueForThisSession()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return ((OnlineSettings)(object)saveDataPath).TryGetValue("storage_logging_enabled", out *(string*)null) ? 1 : 0;
	}

	public static int EncryptDecryptXORValue(int value)
	{
		//IL_00ee: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		object obj = value + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = value + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			GameObject gameObject = ((Component)obj5).gameObject;
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppClass<Utils>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v31 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string longNameList = GetLongNameList((Component[])(object)gameObject);
			throw new ArrayTypeMismatchException();
		}
		string strB = default;
		return string.CompareOrdinalIgnoreCaseHelper(", ", strB);
	}

	private static string GetIntBinaryString(int n)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = stackTrace;
		return (string)(text ^ n);
	}

	public static void DebugStar(Vector3 position, float radius, Color color, float duration)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public static string GetContryCodeFromLocale(string deviceLocale)
	{
		//IL_00df: Expected Obj, but got I4
		//IL_00c7: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b4: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_007d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj = 31;
		object obj2 = default;
		object obj7 = default;
		object obj14 = default;
		while ((nint)obj2 <= 31)
		{
			object obj3 = obj2 & 0x1F;
			object obj4 = 1 << (int)obj3;
			object obj5 = obj4 & (object)deviceLocale;
			if (obj5 != null)
			{
				object obj6 = obj7 + 16;
				object obj8 = obj << 1;
				object obj9 = obj6 + obj8;
				obj9 = 49;
			}
			else
			{
				object obj10 = obj7 + 16;
				object obj11 = obj << 1;
				object obj12 = obj10 + obj11;
				obj12 = 48;
			}
			object obj13 = obj - 1;
			obj2 = obj14 + 1;
			obj = obj13;
		}
		return (string)((StringComparer)null).GetHashCode(obj7);
	}

	public static bool IsEnum(Type type)
	{
		//IL_015f: Expected I4, but got Obj
		//IL_0013: Invalid comparison between VT and I4
		//IL_005e: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_008d: Expected I4, but got Obj
		//IL_00b3: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_00fa: Expected I4, but got Obj
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011e: Expected I4, but got Obj
		bool flag = (object)type == null || type._impl == (RuntimeTypeHandle)(object)0;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		bool result = (byte)(int)string.Empty != 0;
		if (!flag3)
		{
			string text = string.Copy((string)(object)type);
			string text2 = text.ToLowerInvariant();
			string text3 = text2.Replace((string)45, (string)95);
			bool flag4 = text3.EndsWith("_");
			bool flag5 = !flag4;
			result = (byte)(int)string.Empty != 0;
			if (!flag5)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				int num = default;
				object obj = num + 16;
				obj = 95;
				string text4 = text3.Substring(num);
				bool flag6 = text4.m_firstChar == '\u0002';
				bool flag7 = !flag6;
				result = (byte)(int)string.Empty != 0;
				if (!flag7)
				{
					object obj2 = text4 + 20;
					result = (byte)(int)obj2 != 0;
				}
			}
		}
		return result;
	}

	public static Attribute GetCustomAttribute(Type type, Type attributeType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03c7: Expected I, but got Obj
		//IL_03dd: Expected Obj, but got I
		//IL_04dc: Expected I8, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0167: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_050e: Expected I, but got Obj
		//IL_0524: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_049f: Expected I, but got Obj
		//IL_04b5: Expected Obj, but got I
		//IL_02a7: Expected I, but got Obj
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_02f4: Expected I, but got Obj
		//IL_0341: Expected I, but got Obj
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v126 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		StorageSizeLogging._currentSize = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v110 (Il2CppClass<StorageSizeLogging>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(StorageSizeLogging);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v119 (Il2CppClass<StorageSizeLogging>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 53;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 53)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0500;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0500;
		IL_0500:
		nint num5 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v41 (Il2CppClass<StorageSizeLogging>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num6 = (nint)typeof(StorageSizeLogging);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v64 (Il2CppClass<StorageSizeLogging>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] bytes = BitConverter.GetBytes(StorageSizeLogging._currentSize);
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v50 (Il2CppClass<Flurry>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v60 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num9 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v28 (Il2CppClass<System.Convert>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num10 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v35 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DBF4");
		object obj20 = default;
		return (Attribute)(obj20 / 1000000);
	}

	public static bool IsInterface(Type type)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	public static Type BaseType(Type type)
	{
		//IL_000d: Expected Obj, but got I4
		return (Type)type.IsValueType;
	}

	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		GameObject gameObject = ((Component)(object)array).gameObject;
		Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<Utils>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v10 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		TOutput[] result = default;
		return result;
	}

	public static void ThreadSleep(TimeSpan timeSpan)
	{
		LocalDebugData localDebug = DataManager<>.localDebug;
	}

	public static float GetAspectRatio()
	{
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (RealTimeTracker.mInst != null)
		{
			SpawnedObjects.resetCounter();
		}
		RealTimeTracker mInst = RealTimeTracker.mInst;
		return mInst.mRealDelta;
	}

	static Utils()
	{
		//IL_00ce: Expected I8, but got I4
		//IL_00dc: Expected I, but got Obj
		//IL_00f2: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		StorageSizeLogging._currentSize = 0L;
		nint num = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj = (nint)0 + (nint)16;
		obj = "";
		nint num2 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v13 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj2 = (nint)0 + (nint)20;
		obj2 = "";
		nint num3 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj3 = (nint)0 + (nint)24;
		obj3 = "";
		nint num4 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v21 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj4 = (nint)0 + (nint)28;
		obj4 = "";
		nint num5 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v25 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj5 = (nint)0 + (nint)32;
		obj5 = "";
		StorageSizeLogging._dataSize = 0;
		StorageSizeLogging._cacheSize = 0;
		StorageSizeLogging._assetBundlesSize = 0;
		StorageSizeLogging._hasFlurryLoggedInSession = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<int> list = default;
		list._002Ector();
		list.Add(0);
		list.Add(1);
		list.Add(10);
		list.Add(25);
		list.Add(50);
		list.Add(100);
		list.Add(300);
		list.Add(500);
		list.Add(1000);
		list.Add(1500);
		nint num6 = (nint)typeof(StorageSizeLogging);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v54 (Il2CppClass<StorageSizeLogging>)+5C]");
		object obj6 = (nint)0 + (nint)52;
		obj6 = list;
	}
}
