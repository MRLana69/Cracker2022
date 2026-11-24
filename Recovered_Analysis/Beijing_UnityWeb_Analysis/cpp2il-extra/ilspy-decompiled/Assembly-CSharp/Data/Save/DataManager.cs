using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save.Internal;
using SYBO.Subway.Pickups.Pickers;

namespace Data.Save;

public abstract class DataManager<T> where T : DataManager<T>, new()
{
	private static T _instance;

	protected unsafe static T instance
	{
		get
		{
			//IL_01e4: Expected Obj, but got I
			//IL_01fa: Expected I, but got Obj
			//IL_0210: Expected Obj, but got I
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Expected Obj, but got Unknown
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Expected I, but got Unknown
			//IL_037b: Expected I, but got Obj
			//IL_0396: Expected I, but got Obj
			//IL_03ac: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00c0: Expected Obj, but got I4
			//IL_0060: Expected I, but got Obj
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Expected Obj, but got Unknown
			//IL_0104: Expected I, but got Obj
			//IL_011a: Expected Obj, but got I
			//IL_0270: Expected I, but got Obj
			//IL_028b: Expected I, but got Obj
			//IL_02a1: Expected Obj, but got I
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected Obj, but got Unknown
			//IL_02db: Expected Obj, but got I4
			//IL_0145: Expected I, but got Obj
			//IL_0192: Expected I, but got Obj
			nint num = default;
			object obj = num + 24;
			object obj2 = obj;
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v72 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			object obj4 = obj5 + 4;
			obj4 = obj2;
			nint num4 = (nint)(obj5 + 8);
			((IntPtr*)num4)->m_value = (void*)(nint)obj4;
			Type enumType = Type.internal_from_handle((IntPtr)num4);
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v12 (Il2CppClass<System.Enum>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v45 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj9 = default;
			object obj8 = obj9 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj10 = 0;
			T val = default;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
			{
				object obj11 = obj9 + 16;
				object obj12 = obj10 << 2;
				object value = obj11 + obj12;
				object obj13 = obj;
				nint num7 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v44 (Il2CppClass<System.Type>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num8 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v68 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = obj13;
				((IntPtr*)num4)->m_value = (void*)(nint)obj5;
				Type provider = Type.internal_from_handle((IntPtr)num4);
				nint num9 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v53 (Il2CppClass<System.Convert>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num10 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v64 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj16 = val + 16;
				object obj17 = 0 << 2;
				object obj18 = obj16 + obj17;
				bool flag = Convert.ToBoolean(value, (IFormatProvider)provider);
				throw new NullReferenceException();
			}
			return val;
		}
	}

	protected static LocalData local
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_0047: Expected Obj, but got I
			//IL_0091: Expected Obj, but got I
			//IL_00a1: Expected Obj, but got I
			//IL_00c0: Expected Obj, but got I
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected Obj, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_0100: Expected Obj, but got I
			//IL_011f: Expected Obj, but got I
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v7+5C]");
			object obj3 = 0;
			bool flag = obj3 == null;
			bool flag2 = !flag;
			LocalData result = (LocalData)obj3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v15+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16+8]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v21+60]");
				object obj6 = 0;
				object obj7 = obj5 & 0xFFF;
				object obj8 = obj7 + 1797;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S1_v5 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v27+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v30+5C]");
				object obj10 = 0;
				LocalData localData = default;
				obj10 = localData;
				result = localData;
			}
			return result;
		}
	}

	protected static CloudData cloud
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_0038: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v5+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
			object obj4 = 0;
			object obj5 = obj3 & 0xFFF;
			object obj6 = obj5 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v7+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v13+60]");
			object obj9 = 0;
			object obj10 = obj8 & 0x3FFF;
			object obj11 = obj10 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S2_v5 (should have been resolved before IL gen)");
			SaveGame saveGame = default;
			return saveGame.cloud;
		}
	}

	protected static LocalDebugData localDebug
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0028: Expected Obj, but got I
			//IL_0038: Expected Obj, but got I
			//IL_0057: Expected Obj, but got I
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_0097: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Expected Obj, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v5+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v10+60]");
			object obj4 = 0;
			object obj5 = obj3 & 0xFFF;
			object obj6 = obj5 + 1797;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20 @ S1_v4 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v7+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v8+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v13+60]");
			object obj9 = 0;
			object obj10 = obj8 & 0x3FFF;
			object obj11 = obj10 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v38 @ S2_v5 (should have been resolved before IL gen)");
			SaveGame saveGame = default;
			return saveGame.localDebug;
		}
	}

	protected unsafe SaveGame save
	{
		get
		{
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected I, but got Unknown
			//IL_0108: Expected Obj, but got I
			//IL_016f: Expected Obj, but got I
			//IL_001a: Expected Obj, but got I
			//IL_0043: Expected I, but got Obj
			//IL_0059: Expected Obj, but got I
			//IL_012b: Expected I, but got Obj
			//IL_0084: Expected I, but got Obj
			//IL_00cc: Expected Obj, but got I4
			object obj = default;
			nint num = (nint)(obj + 4);
			nint num2 = default;
			object obj2 = num2 + 24;
			int num3 = 0;
			SaveGame result;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Data.Save.DataManager`1<T>)+C]");
				object obj3 = 0;
				int num4 = num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v3+C]");
				bool flag = (nint)num4 >= (nint)0;
				result = null;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Data.Save.DataManager`1<T>)+C]");
				IPicker picker = ((List<IPicker>)0).get_Item(num3);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				object obj4 = obj2;
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v15 (Il2CppClass<System.Type>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v24 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = obj4;
				((IntPtr*)num)->m_value = (void*)(nint)obj;
				Type type = Type.internal_from_handle((IntPtr)num);
				if (obj6 == type)
				{
					result = (SaveGame)1;
					break;
				}
				int num7 = num3 + 1;
				num3 = num7;
			}
			return result;
		}
		private set
		{
			field = value;
		}
	}

	public void SetSaveGame(SaveGame save)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = save;
	}

	private unsafe void OnSaveGameChanged()
	{
		//IL_00be: Expected I, but got Obj
		//IL_00d4: Expected Obj, but got I
		//IL_00ff: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_016f: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got I
		//IL_0062: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SaveManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.SaveManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SaveManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Data.Save.SaveManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = default;
		object obj2 = num3 + 12;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v6+14]");
		object obj5 = 0;
		object obj6 = obj5 & 0x3FFF;
		object obj7 = obj6 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S2_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v9+60]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10+18]");
		nint num4 = 0;
		Action action = default;
		((Delegate)action).method_ptr = (nint)((IntPtr*)num4)->m_value;
		((Delegate)action).method = num4;
		object obj10 = action + 16;
		obj10 = this;
		SaveManager.saveGameChanged -= action;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v19+60]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v22+5C]");
		object obj13 = 0;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			object[] args = default;
			string msg = $"Singleton instance of type '{args}' was already set, did you manually create a new instance?";
			SDebug.LogFormat(msg, null);
		}
	}
}
