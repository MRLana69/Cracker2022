using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility.Internal;
using Kiloo.Common.Plugins.Notifications;
using SYBO.Common.Utilities;
using UnityEngine;

namespace Kiloo.Common.Performance;

public static class AndroidGPUCategorizer
{
	public delegate void UknownGPUHandler(string gpuName);

	private const string GPU_SCORES_PATH = "Kiloo/Performance/AndroidGPUScores";

	private static int gpuScore__BackingField;

	private static GPUCategory gpuCategory__BackingField;

	private static UknownGPUHandler m__unknownGPUHandler;

	private static Dictionary<string, int> _gpuScores;

	private static bool _isInitialized;

	public unsafe static int gpuScore
	{
		get
		{
			//IL_0158: Expected I, but got Obj
			//IL_016e: Expected Obj, but got I
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected I, but got Unknown
			//IL_01e3: Expected I, but got Obj
			//IL_01fe: Expected I, but got Obj
			//IL_0214: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_01ba: Expected I4, but got Obj
			//IL_00d8: Expected I4, but got Obj
			//IL_00eb: Expected Obj, but got I4
			//IL_0110: Expected VT, but got I4
			//IL_0110: Expected Obj, but got I4
			//IL_012b: Expected Obj, but got I4
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v36 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object typeFromHandle = typeof(DeviceUtilitySimulated);
			nint num3 = (nint)(typeFromHandle + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
			Type type = Type.internal_from_handle((IntPtr)num3);
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = ((UnityEngine.Object)(object)type).ToString();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
			UnityEngine.Object obj3 = default;
			bool flag = obj3 != null;
			bool flag2 = !flag;
			UnityEngine.Object obj4 = obj3;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				GameObject gameObject = default;
				gameObject.layer = (int)"DeviceUtility Receiver";
				UnityEngine.Object.CheckNullArgument((object)gameObject, (string)20);
				int layer = gameObject.layer;
				HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.DynamicManagers, (Vector3)0);
				int layer2 = gameObject.layer;
				((HierarchyUtility)layer2)._002Ector();
				DeviceUtilitySimulated deviceUtilitySimulated = gameObject.AddComponent<DeviceUtilitySimulated>();
				obj4 = deviceUtilitySimulated;
			}
			return (int)obj4;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	public static GPUCategory gpuCategory
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (GPUCategory)gpuScore__BackingField;
		}
		private set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gpuScore__BackingField = (int)value;
		}
	}

	public static string gpuInfo
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)gpuCategory__BackingField;
		}
	}

	private static event UknownGPUHandler _unknownGPUHandler
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gpuCategory__BackingField = (GPUCategory)value;
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = AndroidGPUCategorizer.m__unknownGPUHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(AndroidGPUCategorizer);
				if (!flag)
				{
					nint num5 = (nint)typeof(AndroidGPUCategorizer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(AndroidGPUCategorizer);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(AndroidGPUCategorizer);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static bool IsSupportedOnPlatform()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
		throw new ArrayTypeMismatchException();
	}

	public static void Initialize(CategoryThresholds thresholds, UknownGPUHandler unknownGPUHandler = null)
	{
	}

	public static void CalculateGpuCaterogy(CategoryThresholds thresholds)
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_0161: Expected Obj, but got VT
		//IL_017d: Expected I, but got Obj
		//IL_0193: Expected Obj, but got I
		//IL_01b0: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = AndroidGPUCategorizer.m__unknownGPUHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)thresholds);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(AndroidGPUCategorizer);
			if (!flag)
			{
				nint num5 = (nint)typeof(AndroidGPUCategorizer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(AndroidGPUCategorizer);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(AndroidGPUCategorizer);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+5C]");
			object obj5 = (nint)0 + (nint)8;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	private static Dictionary<string, int> LoadGPUScores()
	{
		//IL_001d: Expected Obj, but got I4
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath == 11;
		return (Dictionary<string, int>)flag;
	}

	private static GPUCategory GetCategory(Dictionary<string, int> gpuToScore, CategoryThresholds thresholds, UknownGPUHandler unknownGPUHandler)
	{
		//IL_0016: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got VT
		//IL_001a: Expected I4, but got Obj
		return (GPUCategory)((RegisterForRemoteNotificationsCompletedHandler)(object)gpuToScore).BeginInvoke((string)thresholds, (AsyncCallback)(object)unknownGPUHandler, (object)1);
	}

	private unsafe static string GetTrimmedGPUName()
	{
		//IL_032f: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_03ae: Expected I, but got Obj
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected I4, but got Unknown
		//IL_03e0: Expected Obj, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0085: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I4
		//IL_00bc: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_028f: Expected I, but got Obj
		//IL_02a5: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00fa: Expected Obj, but got I
		//IL_0107: Expected I4, but got Obj
		//IL_02d0: Expected I, but got Obj
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_01b4: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_0443: Expected Obj, but got I
		//IL_0453: Expected Obj, but got I
		//IL_0463: Expected Obj, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected Obj, but got Unknown
		//IL_0242: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S4_v6 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v12 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		nint num3 = (nint)typeof(AndroidGPUCategorizer);
		if (!flag)
		{
			nint num4 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v92 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num3 = (nint)typeof(AndroidGPUCategorizer);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num3 = (nint)typeof(AndroidGPUCategorizer);
			}
		}
		object obj7 = default;
		CallingConvention callingConvention = (CallingConvention)(obj7 + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ L0_v3 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+5C]");
		object obj8 = (nint)0 + (nint)12;
		object obj9 = default;
		obj8 = obj9;
		TextAsset textAsset = Resources.Load<TextAsset>("Kiloo/Performance/AndroidGPUScores");
		byte[] bytes = textAsset.bytes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string[] array = default;
		object obj10 = array + 16;
		obj10 = 10;
		string[] array2 = ((string)(object)bytes).Split(array, StringSplitOptions.RemoveEmptyEntries);
		object obj11 = array2 + 12;
		object obj12 = 113696;
		object obj13 = 0;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		int num5 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11))
		{
			object obj14 = array2 + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj7 = 0;
			((CallingConvention*)(int)callingConvention)->value__ = (int)obj7;
			unmanagedFunctionPointerAttribute._002Ector(callingConvention);
			string text = ((string)obj16).TrimStart((char[])(object)unmanagedFunctionPointerAttribute);
			if (text.m_stringLength != 0)
			{
				string[] array3 = text.Split(null);
				object obj17 = array3 & 0xFFFF;
				if ((nint)obj17 != 35)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj18 = num5 + 16;
					obj18 = 32;
					string text2 = ((string)obj16).Substring(num5);
					object obj19 = text2 + 16;
					object obj20 = text2 + 20;
					TypeCode typeCode = ((int*)obj20)->GetTypeCode();
					nint num6 = (nint)typeof(AndroidGPUCategorizer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v78 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num7 = (nint)typeof(AndroidGPUCategorizer);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v86 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S4_v8 (Il2CppMethodInfo)+C]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S4_v9+60]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S4_v10+48]");
					obj5 = 0;
					object obj24 = obj5 & 0x7FF;
					obj12 = obj24 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v98 @ S5_v4 (should have been resolved before IL gen)");
				}
			}
			object obj25 = obj13 + 1;
			obj13 = obj25;
		}
		nint num9 = (nint)typeof(AndroidGPUCategorizer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v32 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num10 = (nint)typeof(AndroidGPUCategorizer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v39 (Il2CppClass<Kiloo.Common.Performance.AndroidGPUCategorizer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)_gpuScores;
	}

	private static GPUCategory GetCategoryFromScore(int score, CategoryThresholds thresholds)
	{
		//IL_0009: Invalid comparison between VT and I4
		if (thresholds != (CategoryThresholds)(object)0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7CE4");
		}
		return GPUCategory.Unknown;
	}
}
