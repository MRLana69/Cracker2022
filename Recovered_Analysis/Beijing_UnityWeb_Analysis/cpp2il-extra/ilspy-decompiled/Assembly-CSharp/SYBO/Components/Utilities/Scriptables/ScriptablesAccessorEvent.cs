using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;

namespace SYBO.Components.Utilities.Scriptables;

[Serializable]
public class ScriptablesAccessorEvent : UnityEvent<Type>
{
	public unsafe ScriptablesAccessorEvent()
	{
		//IL_02a9: Expected I, but got Obj
		//IL_02bf: Expected Obj, but got I
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected I, but got Unknown
		//IL_0305: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_008e: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_044a: Expected I, but got Obj
		//IL_0460: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_03ec: Expected Obj, but got I4
		//IL_03ec: Expected Obj, but got I
		//IL_0402: Expected Obj, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected Obj, but got Unknown
		//IL_01c4: Expected I, but got Obj
		//IL_01da: Expected Obj, but got I
		//IL_0252: Expected I, but got Obj
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected Obj, but got Unknown
		//IL_03a7: Expected I, but got Obj
		//IL_03bd: Expected Obj, but got I
		//IL_0205: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v55 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(TypeListAttribute);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type attributeType = Type.internal_from_handle((IntPtr)num3);
		Attribute customAttribute = Attribute.GetCustomAttribute((Assembly)(object)this, attributeType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj2 = default;
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22+8]");
		object obj3 = (nint)0 + (nint)12;
		object obj4 = 0;
		object obj6 = default;
		Predicate<_0021_00210> predicate = default;
		_0021_00210[] array = default;
		UnityEngine.Object obj13 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = obj6 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v22+8]");
			object obj7 = (nint)0 + (nint)16;
			object obj8 = obj4 << 2;
			object obj9 = obj7 + obj8;
			obj5 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			object obj10 = predicate + 16;
			obj10 = obj6;
			int num5 = Array.FindIndex<T>((T[])(object)array, (Predicate<T>)(object)predicate);
			nint num6 = (nint)typeof(ScriptablesAccessor._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v31 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor+<>c>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num7 = (nint)typeof(ScriptablesAccessor._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v80 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = ScriptablesAccessor._003C_003Ec._003C_003E9__2_1 == null;
			bool flag2 = !flag;
			UnityEngine.Object asset = (UnityEngine.Object)(object)ScriptablesAccessor._003C_003Ec._003C_003E9__2_1;
			if (!flag2)
			{
				nint num8 = (nint)typeof(ScriptablesAccessor._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v54 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor+<>c>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num9 = (nint)typeof(ScriptablesAccessor._003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v74 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint cachedPtr = 0;
				obj13.m_CachedPtr = cachedPtr;
				_ = 0;
				object obj14 = obj13 + 16;
				obj14 = ScriptablesAccessor._003C_003Ec._003C_003E9;
				nint num10 = (nint)typeof(ScriptablesAccessor._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ S1_v71 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor+<>c>)+5C]");
				object obj15 = (nint)0 + (nint)4;
				obj15 = obj13;
				asset = obj13;
			}
			nint num11 = (nint)typeof(ScriptablesAccessor);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v41 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num12 = (nint)typeof(ScriptablesAccessor);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v49 (Il2CppClass<SYBO.Components.Utilities.Scriptables.ScriptablesAccessor>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v34+8]");
			ScriptablesAccessor.PopulateFieldOfType((Type)0, (FieldInfo)num5, asset);
			ScriptablesAccessorEvent onUpdatedFields = ScriptablesAccessor.OnUpdatedFields;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v34+8]");
			((UnityAction<T0, T1>)(object)onUpdatedFields).EndInvoke((IAsyncResult)0);
			object obj17 = obj4 + 1;
			obj4 = obj17;
		}
	}
}
