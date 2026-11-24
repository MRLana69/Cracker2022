using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Subway.Utilities;

public static class DebugQueuedEnvironments
{
	private const float QueueShiftDistance = 1080f;

	private static Queue<EnvironmentKind> _environmentQueue;

	private static EnvironmentKind[] _currentEnvironmentKinds;

	private static float _nextQueueShiftPosZ;

	public static readonly List<string> AvailableEnvironments;

	public static bool IsQueueEnabled
	{
		get
		{
			//IL_0029: Expected VT, but got Obj
			//IL_0032: Expected Obj, but got VT
			//IL_000e: Expected VT, but got Obj
			UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((DebugSettings)val)._002Ector();
			_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (T)+20]");
			return false;
		}
	}

	public static Dictionary<string, string> GetSelected()
	{
		//IL_0039: Expected I, but got Obj
		//IL_004f: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_01d4: Expected Obj, but got I4
		//IL_0108: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
		object obj = default;
		if (obj != null)
		{
			EnvironmentKind[] queuedEnvironmentKinds = DebugSettings.QueuedEnvironmentKinds;
			if (queuedEnvironmentKinds != null)
			{
				nint num = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(DebugQueuedEnvironments);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v41 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				DebugQueuedEnvironments._002Ecctor();
				if (_currentEnvironmentKinds != null)
				{
					nint num3 = (nint)typeof(DebugQueuedEnvironments);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v26 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(DebugQueuedEnvironments);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v35 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					EnvironmentKind[] currentEnvironmentKinds = _currentEnvironmentKinds;
					bool flag = currentEnvironmentKinds.Length != 0;
					return (Dictionary<string, string>)flag;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public static EnvironmentKind GetEnvironmentKindAt(float posZ)
	{
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009e: Expected I4, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float width = posZ * 255f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(width);
		int num3 = (((nint)gUILayoutOption >= 0) ? (((nint)gUILayoutOption <= 255) ? ((int)gUILayoutOption) : 255) : 0);
		return (EnvironmentKind)(object)NGUIMath.DecimalToHex24(num3);
	}

	private static void UpdateQueuedEnvironmentKinds()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("Use of DebugSetting not allowed");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public static void SetQueuedEnvironments(Dictionary<string, string> multipleValues)
	{
		_ = 1;
		multipleValues.count = 1;
		_ = 1;
		_ = 1;
		((Validator<>)(object)multipleValues)._002Ector();
	}

	static DebugQueuedEnvironments()
	{
		//IL_04e6: Expected I, but got Obj
		//IL_04fc: Expected Obj, but got I
		//IL_0265: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0643: Expected I, but got Obj
		//IL_0659: Expected Obj, but got I
		//IL_0676: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_069a: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I4
		//IL_054e: Expected Obj, but got I4
		//IL_0573: Expected Obj, but got I4
		//IL_0797: Expected I, but got Obj
		//IL_07ad: Expected Obj, but got I
		//IL_0280: Expected I, but got Obj
		//IL_02b0: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0907: Expected I, but got Obj
		//IL_091d: Expected Obj, but got I
		//IL_02e9: Expected I, but got Obj
		//IL_02d6: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_03b5: Expected I, but got Obj
		//IL_06be: Expected Obj, but got I4
		//IL_06ef: Expected Obj, but got I4
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected Obj, but got Unknown
		//IL_05c2: Expected I, but got Obj
		//IL_05d8: Expected Obj, but got I
		//IL_034f: Expected I, but got Obj
		//IL_017f: Expected I, but got Obj
		//IL_01cc: Expected I, but got Obj
		//IL_0603: Expected Obj, but got I4
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		bool isQueueEnabled = IsQueueEnabled;
		nint num = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v189 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_currentEnvironmentKinds != null)
		{
			nint num3 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v126 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v183 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			EnvironmentKind[] currentEnvironmentKinds = _currentEnvironmentKinds;
			object obj3 = (isQueueEnabled ? 1 : 0) + 12;
			bool flag = currentEnvironmentKinds.Length == (nint)obj3;
			bool flag2 = !flag;
			object obj4 = currentEnvironmentKinds.Length;
			if (!flag2)
			{
				object obj5 = default;
				object obj17 = default;
				while (true)
				{
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
					{
						return;
					}
					object obj6 = (isQueueEnabled ? 1 : 0) + 16;
					object obj7 = obj5 << 2;
					object obj8 = obj6 + obj7;
					object obj9 = obj8;
					nint num5 = (nint)typeof(DebugQueuedEnvironments);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v144 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num6 = (nint)typeof(DebugQueuedEnvironments);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v177 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj11 = _currentEnvironmentKinds + 16;
					object obj12 = obj5 << 2;
					object obj13 = obj11 + obj12;
					object obj14 = obj13;
					nint num7 = (nint)typeof(EnvironmentKind);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v155 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num8 = (nint)typeof(EnvironmentKind);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v173 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v142+8]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v153+8]");
					bool flag3;
					if (num9 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v142+C]");
						nint num10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v153+C]");
						flag3 = num10 == 0;
					}
					else
					{
						flag3 = false;
					}
					object obj16 = (flag3 ? 1 : 0) ^ 1;
					if (obj16 != null)
					{
						break;
					}
					obj5 = obj17 + 1;
					obj4 = obj3;
				}
			}
			object obj18 = obj3;
		}
		else
		{
			object obj19 = (isQueueEnabled ? 1 : 0) + 12;
			object obj18 = obj19;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num11 = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v20 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		bool flag4 = obj20 == null;
		nint num12 = (nint)typeof(DebugQueuedEnvironments);
		if (!flag4)
		{
			nint num13 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v116 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
			bool flag5 = (nint)0 == 0;
			bool flag6 = !flag5;
			num12 = (nint)typeof(DebugQueuedEnvironments);
			if (!flag6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num12 = (nint)typeof(DebugQueuedEnvironments);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ L0_v5 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+5C]");
		object obj21 = (nint)0 + (nint)4;
		object obj22 = default;
		obj21 = obj22;
		object obj23 = 0;
		nint num14 = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v30 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num15 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v110 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		EnvironmentKind[] currentEnvironmentKinds2 = _currentEnvironmentKinds;
		bool flag7 = (nint)obj23 < currentEnvironmentKinds2.Length;
		nint num16 = (nint)typeof(DebugQueuedEnvironments);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v16 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		bool flag8 = obj25 != null;
		if (flag7)
		{
			if (flag8)
			{
				nint num17 = (nint)typeof(DebugQueuedEnvironments);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v104 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj26 = (isQueueEnabled ? 1 : 0) + 16;
			object obj27 = obj23 << 2;
			object obj28 = obj26 + obj27;
			object obj29 = obj28;
			object obj30 = (isQueueEnabled ? 1 : 0) + 16;
			object obj31 = obj23 << 2;
			object obj32 = obj30 + obj31;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v87+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v92+C]");
			_ = 0;
			throw new ArrayTypeMismatchException();
		}
		if (flag8)
		{
			nint num18 = (nint)typeof(DebugQueuedEnvironments);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S0_v73 (Il2CppClass<SYBO.Subway.Utilities.DebugQueuedEnvironments>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		throw new IndexOutOfRangeException();
	}
}
