using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using SYBO.Components.Settings;
using UnityEngine;

namespace SYBO.Components.Utilities;

public class ToStringObject
{
	private readonly string _objectTypeName;

	private Dictionary<string, string> _members;

	private bool _isOneLine;

	public ToStringObject(object obj, bool isOneLine = true)
	{
		//IL_013c: Expected I, but got Obj
		//IL_0152: Expected Obj, but got I
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(StaticSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(StaticSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(SingletonMonoBehaviour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = StaticSettings.Log.HasLogLevel(SingletonMonoBehaviour.LogCategoryName);
		if ((flag ? 1 : 0) < (nint)this)
		{
			return;
		}
		nint num5 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v17 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v22 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(obj, (UnityEngine.Object)isOneLine);
	}

	public void AddMember(string name, object value)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected I4, but got Unknown
		//IL_00d1: Expected Obj, but got I
		//IL_00e1: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		_isOneLine = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			object obj2 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj3 = default;
			obj2 = obj3;
		}
		else
		{
			object obj4 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj5 = default;
			obj4 = obj5;
		}
		bool isOneLine = (byte)(value & 1) != 0;
		_isOneLine = isOneLine;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S3_v4+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S4_v4 (should have been resolved before IL gen)");
		object obj11 = this + 12;
		object obj12 = default;
		obj11 = obj12;
	}

	public unsafe string GetValueAsString(object value)
	{
		//IL_0299: Expected I, but got Obj
		//IL_02af: Expected Obj, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected I, but got Unknown
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02e7: Expected I, but got Obj
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_0190: Expected I, but got Obj
		//IL_035b: Expected I, but got Obj
		//IL_0371: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I4
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v81 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 4);
		if (this == value)
		{
			return null;
		}
		nint num4 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v76 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(object);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num3);
		ToStringObject toStringObject = default;
		object obj6 = default;
		ToStringObject toStringObject2 = default;
		while (true)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v33 (Il2CppClass<System.Type>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v72 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (toStringObject == null)
			{
				return null;
			}
			nint num8 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v40 (Il2CppClass<System.Type>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v67 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((object)toStringObject == type)
			{
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			}
			else
			{
				toStringObject2 = toStringObject;
			}
			nint num10 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v50 (Il2CppClass<System.Type>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num11 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v59 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (value == toStringObject2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		return (string)1;
	}

	public override string ToString()
	{
		//IL_01c2: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string text2 = default;
		string text = text2.ToLower((CultureInfo)(object)"Mono.Cecil");
		if (text == null)
		{
			string text3 = text2.ToLower((CultureInfo)(object)"UnityScript");
			if (text3 == null)
			{
				string text4 = text2.ToLower((CultureInfo)(object)"Boo.Lan");
				if (text4 == null)
				{
					string text5 = text2.ToLower((CultureInfo)(object)"System");
					if (text5 == null)
					{
						string text6 = text2.ToLower((CultureInfo)(object)"I18N");
						if (text6 == null)
						{
							string text7 = text2.ToLower((CultureInfo)(object)"UnityEngine");
							if (text7 == null)
							{
								string text8 = text2.ToLower((CultureInfo)(object)"UnityEditor");
								if (text8 == null)
								{
									return text2.ToLower((CultureInfo)(object)"mscorlib");
								}
							}
						}
					}
				}
			}
		}
		return (string)1;
	}
}
