using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.GameCenter;
using UnityEngine;

namespace Kiloo.Plugins;

public static class PluginUtil
{
	private struct Handler
	{
		public object context;

		public Delegate handler;
	}

	private static int _nextTicket;

	private static readonly Dictionary<int, Handler> _sharedHandlerStore;

	public static int GetNextTicket()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_01d1: Expected I, but got Obj
		//IL_01e7: Expected Obj, but got I
		//IL_0236: Expected I, but got Obj
		//IL_024c: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0153: Expected I, but got Obj
		//IL_0107: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v11 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v32 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((ComputeShader)(object)GameCenterPlugin._instance).FindKernel((string)null);
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v12 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 != null;
			if (num5 != 0)
			{
				if (flag)
				{
					nint num7 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v29 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
			}
			else
			{
				if (flag)
				{
					nint num8 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v23 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin.LogWarning("ArePhotosSupported was called before Init");
			}
		}
		return 0;
	}

	public static int CheckInHandler(Delegate handler, object context)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = handler;
		object obj2 = num + 20;
		obj2 = context;
		return num;
	}

	public static Delegate CheckOutHandler(int ticket)
	{
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [ticket @ L0 (System.Int32)+18]");
		bool flag = (nint)0 != 0;
		return (Delegate)flag;
	}

	public static IEnumerable<int> RemoveHandlers(object context)
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
			nint num = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v159 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num3 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v86 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v150 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
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
				nint num5 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v100 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(PluginUtil);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v129 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
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
		return (IEnumerable<int>)0;
	}

	public static void RemoveAllHandlers()
	{
	}

	public unsafe static T CreateBridgeObject<T>(string name = null, bool dontDestroyOnLoad = true) where T : MonoBehaviour
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013d: Expected Obj, but got I
		//IL_0173: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		bool value = default;
		((bool*)(dontDestroyOnLoad ? 1 : 0))->m_value = value;
		return (T)1;
	}

	static PluginUtil()
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
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v99 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v65 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v90 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
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
