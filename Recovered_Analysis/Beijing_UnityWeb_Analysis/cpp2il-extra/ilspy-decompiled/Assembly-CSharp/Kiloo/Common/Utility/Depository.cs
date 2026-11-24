using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class Depository
{
	[StructLayout((LayoutKind)0, Size = 8)]
	private struct Deposit
	{
		public object context;

		public object deposit;
	}

	private static int _nextTicket;

	private static readonly Dictionary<int, Deposit> _sharedStore;

	public unsafe static int GetNextTicket()
	{
		//IL_003f: Expected I, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_0448: Expected I, but got Obj
		//IL_045e: Expected Obj, but got I
		//IL_001d: Expected I4, but got Obj
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected I, but got Unknown
		//IL_0080: Expected I, but got Obj
		//IL_04a1: Expected I, but got Obj
		//IL_04b7: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_05d3: Expected I4, but got Obj
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_03ca: Expected I, but got Obj
		//IL_021c: Expected I, but got Obj
		//IL_0232: Expected Obj, but got I
		//IL_015b: Expected I, but got Obj
		//IL_04ef: Expected I, but got Obj
		//IL_01a8: Expected I, but got Obj
		//IL_01be: Expected Obj, but got I
		//IL_025d: Expected I, but got Obj
		//IL_02c9: Expected I, but got Obj
		//IL_02df: Expected Obj, but got I
		//IL_01e9: Expected I, but got Obj
		//IL_053a: Expected I, but got Obj
		//IL_0550: Expected Obj, but got I
		//IL_0592: Expected Obj, but got I4
		//IL_030a: Expected I, but got Obj
		//IL_03b7: Expected VT, but got I4
		//IL_0357: Expected I, but got Obj
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"Can only be used in play mode");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		nint num = (nint)typeof(ApplicationState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v13 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ApplicationState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v118 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		nint num5 = (nint)(obj3 + 4);
		if (ApplicationState._instance != null)
		{
			nint num6 = (nint)typeof(ApplicationState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v45 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(ApplicationState);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v108 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(ApplicationState._isQuitting ? 1u : 0u) == 0)
			{
				nint num8 = (nint)typeof(ApplicationState);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v101 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(ApplicationState);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v105 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			else
			{
				nint num10 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v55 (Il2CppClass<System.Type>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v96 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj3 = typeof(ApplicationState);
				((IntPtr*)num5)->m_value = (void*)(nint)obj3;
				Type type = Type.internal_from_handle((IntPtr)num5);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				GameObject gameObject = default;
				int layer = default;
				gameObject.layer = layer;
				ApplicationState instance = gameObject.AddComponent<ApplicationState>();
				nint num12 = (nint)typeof(ApplicationState);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v69 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num13 = (nint)typeof(ApplicationState);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v90 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ApplicationState._instance = instance;
				string tag = ApplicationState._instance.tag;
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((UnityEngine.UnitySynchronizationContext)(object)tag).Exec();
				string tag2 = ApplicationState._instance.tag;
				UnityEngine.Object.CheckNullArgument((object)tag2, (string)52);
				GameObject gameObject2 = ApplicationState._instance.gameObject;
				HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)gameObject2, HierarchyPathType.DynamicManagers, (Vector3)0);
			}
		}
		nint num16 = (nint)typeof(ApplicationState);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v31 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num17 = (nint)typeof(ApplicationState);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v38 (Il2CppClass<Kiloo.Common.Utility.ApplicationState>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (int)ApplicationState._instance;
	}

	public static int CheckIn(object deposit, object context)
	{
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0085: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_006b: Expected I4, but got Obj
		IEnumerator enumerator = CoroutineUtil.ExecuteActionNextFrame((Action)deposit);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)context).FindKernel((string)null) != 0)
		{
			Coroutine coroutine = ((MonoBehaviour)context).StartCoroutine_Auto(enumerator);
			return (int)coroutine;
		}
		Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)enumerator);
		return (int)coroutine2;
	}

	public static object CheckOut(int ticket)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = ticket;
		return obj2;
	}

	public static IDictionary<int, object> RemoveByContext(object context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_04dd: Expected Obj, but got I4
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		//IL_04f4: Expected Obj, but got I4
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_0618: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0536: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01be: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02df: Expected Obj, but got I4
		//IL_02e8: Expected Obj, but got I4
		//IL_0212: Expected I, but got Obj
		//IL_0395: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected Obj, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		if (context != null)
		{
			nint num = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v159 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num3 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v86 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v150 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			object obj8 = default;
			object obj18 = default;
			if (obj8 == null)
			{
				object obj9 = obj5 + 4;
				object obj10 = obj9 + 1;
				obj9 = obj10;
				object obj11 = obj10 << 2;
				object obj12 = obj5 + obj11;
				obj12 = 67;
			}
			else
			{
				nint num5 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v100 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(Depository);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v129 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				obj2 = obj4;
				object obj14 = obj5 + 4;
				object obj15 = obj14 + 1;
				obj14 = obj15;
				object obj16 = obj15 << 2;
				object obj17 = obj5 + obj16;
				obj17 = 69;
				obj18 = 0;
			}
			if (obj3 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj5 + obj19;
				if ((nint)obj20 == 69)
				{
					object obj21 = obj5 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					goto IL_060b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+4]");
				object obj23 = (nint)0 << 2;
				object obj24 = obj5 + obj23;
				if ((nint)obj24 == 67)
				{
					object obj25 = obj5 + 4;
					if ((nint)obj25 > -1)
					{
						object obj26 = obj25 + -1;
						obj25 = obj26;
					}
					goto IL_060b;
				}
			}
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_060b;
		IL_060b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		return (IDictionary<int, object>)0;
	}

	public static void RemoveAll()
	{
	}

	static Depository()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02da: Expected I, but got Obj
		//IL_02f0: Expected Obj, but got I
		//IL_0378: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_01fd: Expected Obj, but got I
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Depository);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v99 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(Depository);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v65 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v90 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 38;
		object obj10 = 0;
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 38)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
