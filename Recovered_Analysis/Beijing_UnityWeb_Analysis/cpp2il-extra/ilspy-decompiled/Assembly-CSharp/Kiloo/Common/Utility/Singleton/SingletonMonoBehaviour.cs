using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility.Singleton;

public class SingletonMonoBehaviour<TSubclass> : MonoBehaviour where TSubclass : SingletonMonoBehaviour<TSubclass>
{
	private static TSubclass _instance;

	public unsafe static TSubclass instance
	{
		get
		{
			//IL_02ca: Expected Obj, but got I
			//IL_02e4: Expected Obj, but got I
			//IL_02fe: Expected Obj, but got I
			//IL_030c: Expected I, but got Obj
			//IL_0322: Expected Obj, but got I
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Expected I, but got Unknown
			//IL_0298: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_02b7: Expected Obj, but got I
			//IL_006c: Expected Obj, but got I
			//IL_007a: Expected I, but got Obj
			//IL_0090: Expected Obj, but got I
			//IL_0384: Expected Obj, but got I
			//IL_0391: Expected I, but got Obj
			//IL_00bb: Expected I, but got Obj
			//IL_0126: Expected Obj, but got I
			//IL_0136: Expected Obj, but got I
			//IL_0150: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected Obj, but got Unknown
			//IL_0195: Expected Obj, but got I
			//IL_01af: Expected Obj, but got I
			//IL_01d6: Expected Obj, but got I
			//IL_01f0: Expected Obj, but got I
			//IL_01fe: Expected I, but got Obj
			//IL_0214: Expected Obj, but got I
			//IL_023f: Expected I, but got Obj
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v14+5C]");
			object obj3 = 0;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = default;
			nint num4 = (nint)(obj5 + 4);
			if ((UnityEngine.Object)obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v29+60]");
				object obj6 = 0;
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v33 (Il2CppClass<System.Type>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v67 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v30+8]");
				obj5 = 0;
				((IntPtr*)num4)->m_value = (void*)(nint)obj5;
				Type type = Type.internal_from_handle((IntPtr)num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				GameObject gameObject = default;
				int layer = default;
				gameObject.layer = layer;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v46+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v47+C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v23+60]");
				object obj10 = 0;
				object obj11 = obj9 & 0x3FFF;
				object obj12 = obj11 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v131 @ S2_v9 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v54+60]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v57+5C]");
				object obj14 = 0;
				object obj15 = default;
				obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v61+60]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v64+5C]");
				object obj17 = 0;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj18 = (nint)0 & (nint)0x200;
				if (obj18 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((UnityEngine.UnitySynchronizationContext)obj17).Exec();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v21+60]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v24+5C]");
			return (TSubclass)0;
		}
	}

	public static TSubclass instanceOptional
	{
		get
		{
			//IL_00d4: Expected Obj, but got I
			//IL_00ee: Expected Obj, but got I
			//IL_0108: Expected Obj, but got I
			//IL_0116: Expected I, but got Obj
			//IL_012c: Expected Obj, but got I
			//IL_018a: Expected Obj, but got I
			//IL_01a4: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006c: Expected Obj, but got I
			//IL_007c: Expected Obj, but got I
			//IL_009b: Expected Obj, but got I
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected Obj, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11+5C]");
			object obj3 = 0;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v26+60]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v12+60]");
				object obj7 = 0;
				object obj8 = obj6 & 0x3FFF;
				object obj9 = obj8 + 80504;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S2_v6 (should have been resolved before IL gen)");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v18+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v21+5C]");
			return (TSubclass)0;
		}
	}

	private static void UpdateInstance(bool optional)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	protected unsafe virtual void OnDestroy()
	{
		//IL_0335: Expected I, but got Obj
		//IL_034b: Expected Obj, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected I, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0421: Expected Obj, but got I
		//IL_043b: Expected Obj, but got I
		//IL_044b: Expected Obj, but got I
		//IL_0465: Expected Obj, but got I
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I
		//IL_0385: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 + 8);
		object obj3 = obj2 + 4;
		nint num4 = default;
		object obj4 = num4 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v26+60]");
		object obj7 = 0;
		object obj8 = obj6 & 0xFFF;
		object obj9 = obj8 + 1797;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S1_v9 (should have been resolved before IL gen)");
		object obj11 = default;
		object obj10 = obj11 + 12;
		if (obj10 != null)
		{
			if ((nint)obj10 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			object obj12 = obj11 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v63+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v66+5C]");
			object obj14 = 0;
			obj14 = obj12;
		}
		else
		{
			if ((object)this != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v39+60]");
			object obj15 = 0;
			nint num5 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v43 (Il2CppClass<System.Type>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num6 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v54 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v40+10]");
			obj3 = 0;
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type type = Type.internal_from_handle((IntPtr)num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Type type2 = default;
			object msg = ((IConvertible)"Requested singleton of type ").ToType(type2, (IFormatProvider)(object)" not found.");
			SDebug.LogFormat((string)msg, null);
		}
	}

	public SingletonMonoBehaviour()
	{
		//IL_0092: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I
		//IL_00c4: Expected Obj, but got I
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10+5C]");
		object obj4 = 0;
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)obj4 != this)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16+60]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		}
	}
}
