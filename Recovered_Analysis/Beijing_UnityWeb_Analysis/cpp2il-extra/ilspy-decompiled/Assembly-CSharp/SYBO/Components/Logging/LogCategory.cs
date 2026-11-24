using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.Notifications.Internal;
using SYBO.Components.Analytics;
using SYBO.Components.Base;
using SYBO.Components.Json;
using SYBO.Components.Json.Internal;
using SYBO.Components.Settings;
using SYBO.Components.Singletons;
using SYBO.Subway.Characters;
using SYBO.Subway.Info;
using UI;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;

namespace SYBO.Components.Logging;

public abstract class LogCategory : IWriteLog
{
	public readonly int CategoryId;

	public string CategoryText;

	public string MessagePrefix;

	public int Level;

	public int HideStackLevel;

	private static ILogPlatform LogEngine__BackingField;

	protected static readonly object[] _zeroArgs;

	protected static object[] _singleArgThreadStatic;

	protected static object[] _twoArgsThreadStatic;

	protected static object[] _threeArgsThreadStatic;

	public static ILogPlatform LogEngine
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00ab: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(BaseEnvironment);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Base.BaseEnvironment>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(BaseEnvironment);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Base.BaseEnvironment>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isRunningUnitTests = BaseEnvironment._isRunningUnitTests;
			return (ILogPlatform)isRunningUnitTests;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	protected static object[] _singleArg
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (object[])(object)LogEngine__BackingField;
		}
	}

	protected static object[] _twoArgs
	{
		get
		{
			//IL_01a7: Expected I, but got Obj
			//IL_01bd: Expected Obj, but got I
			//IL_01da: Expected I, but got Obj
			//IL_01f6: Expected I, but got Obj
			//IL_020c: Expected Obj, but got I
			//IL_0229: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0043: Expected I, but got Obj
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_00b9: Expected I, but got Obj
			//IL_013e: Expected I, but got Obj
			//IL_016e: Expected I, but got Obj
			//IL_0069: Expected I, but got Obj
			//IL_00d5: Expected I, but got Obj
			//IL_0105: Expected I, but got Obj
			//IL_0194: Expected I, but got Obj
			//IL_012b: Expected I, but got Obj
			nint num = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(LogCategory);
			if (!flag)
			{
				nint num3 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(LogCategory);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(LogCategory);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
			object obj2 = default;
			if (obj2 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num4 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v33 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				bool flag4 = obj3 == null;
				nint num5 = (nint)typeof(LogCategory);
				if (!flag4)
				{
					nint num6 = (nint)typeof(LogCategory);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v39 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
					bool flag5 = (nint)0 == 0;
					bool flag6 = !flag5;
					num5 = (nint)typeof(LogCategory);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num5 = (nint)typeof(LogCategory);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
				object obj5 = default;
				object obj4 = obj5;
			}
			nint num7 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			bool flag7 = obj6 == null;
			nint num8 = (nint)typeof(LogCategory);
			if (!flag7)
			{
				nint num9 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				bool flag8 = (nint)0 == 0;
				bool flag9 = !flag8;
				num8 = (nint)typeof(LogCategory);
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num8 = (nint)typeof(LogCategory);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
			object result = default;
			return (object[])result;
		}
	}

	protected static object[] _threeArgs
	{
		get
		{
			//IL_01a7: Expected I, but got Obj
			//IL_01bd: Expected Obj, but got I
			//IL_01da: Expected I, but got Obj
			//IL_01f6: Expected I, but got Obj
			//IL_020c: Expected Obj, but got I
			//IL_0229: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0043: Expected I, but got Obj
			//IL_02ad: Expected Obj, but got I
			//IL_0086: Expected I, but got Obj
			//IL_009c: Expected Obj, but got I
			//IL_00b9: Expected I, but got Obj
			//IL_013e: Expected I, but got Obj
			//IL_016e: Expected I, but got Obj
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Expected Obj, but got Unknown
			//IL_0069: Expected I, but got Obj
			//IL_00d5: Expected I, but got Obj
			//IL_0105: Expected I, but got Obj
			//IL_0194: Expected I, but got Obj
			//IL_012b: Expected I, but got Obj
			nint num = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			bool flag = obj == null;
			nint num2 = (nint)typeof(LogCategory);
			if (!flag)
			{
				nint num3 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num2 = (nint)typeof(LogCategory);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num2 = (nint)typeof(LogCategory);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+4]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num4 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v33 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag4 = obj2 == null;
				nint num5 = (nint)typeof(LogCategory);
				if (!flag4)
				{
					nint num6 = (nint)typeof(LogCategory);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v40 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
					bool flag5 = (nint)0 == 0;
					bool flag6 = !flag5;
					num5 = (nint)typeof(LogCategory);
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num5 = (nint)typeof(LogCategory);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
				object obj4 = default;
				object obj3 = obj4 + 4;
				object obj5 = default;
				obj3 = obj5;
			}
			nint num7 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v16 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			bool flag7 = obj6 == null;
			nint num8 = (nint)typeof(LogCategory);
			if (!flag7)
			{
				nint num9 = (nint)typeof(LogCategory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
				bool flag8 = (nint)0 == 0;
				bool flag9 = !flag8;
				num8 = (nint)typeof(LogCategory);
				if (!flag9)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num8 = (nint)typeof(LogCategory);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v21+4]");
			return (object[])0;
		}
	}

	public virtual string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public LogCategory(int categoryId)
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CategoryId = categoryId;
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj3 = (nint)0 + (nint)4;
		obj3 = this;
		object obj4 = this + 12;
		obj4 = "BuildSizeMonitor";
	}

	public bool ApplySetting(LogCategorySettings setting)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		bool result = default;
		return result;
	}

	public void LogFormat(string format)
	{
		//IL_000a: Expected I4, but got Obj
		CategoryId = (int)format;
	}

	public unsafe void LogFormat(string format, object arg1)
	{
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected Obj, but got Unknown
		//IL_03ba: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected I, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0470: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I
		//IL_0118: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I4
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_04b7: Expected I, but got Obj
		//IL_019e: Expected I, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_02b6: Expected Obj, but got I
		//IL_022d: Expected Obj, but got I
		//IL_0247: Expected Obj, but got I
		//IL_0257: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I
		//IL_0356: Expected Obj, but got I
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Expected Obj, but got Unknown
		//IL_02e1: Expected I, but got Obj
		//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		obj = this;
		nint num2 = (nint)typeof(CachingRootFileJsonSettingsParser._003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<SYBO.Components.Settings.CachingRootFileJsonSettingsParser+<>c>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(CachingRootFileJsonSettingsParser._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v111 (Il2CppClass<SYBO.Components.Settings.CachingRootFileJsonSettingsParser+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = CachingRootFileJsonSettingsParser._003C_003Ec._003C_003E9__5_0 == null;
		bool flag2 = !flag;
		JsonFileSerializer.WriteFileTextDelegate writeFileTextDelegate = CachingRootFileJsonSettingsParser._003C_003Ec._003C_003E9__5_0;
		if (!flag2)
		{
			nint num4 = (nint)typeof(CachingRootFileJsonSettingsParser._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v88 (Il2CppClass<SYBO.Components.Settings.CachingRootFileJsonSettingsParser+<>c>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(CachingRootFileJsonSettingsParser._003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v105 (Il2CppClass<SYBO.Components.Settings.CachingRootFileJsonSettingsParser+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			JsonFileSerializer.WriteFileTextDelegate writeFileTextDelegate2 = default;
			((Delegate)writeFileTextDelegate2).method_ptr = method_ptr;
			((Delegate)writeFileTextDelegate2).method = (nint)__ldftn(CachingRootFileJsonSettingsParser._003C_003Ec._003CLoadRootSettings_003Eb__5_0);
			object obj5 = writeFileTextDelegate2 + 16;
			obj5 = CachingRootFileJsonSettingsParser._003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(CachingRootFileJsonSettingsParser._003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v102 (Il2CppClass<SYBO.Components.Settings.CachingRootFileJsonSettingsParser+<>c>)+5C]");
			object obj6 = (nint)0 + (nint)4;
			obj6 = writeFileTextDelegate2;
			writeFileTextDelegate = writeFileTextDelegate2;
		}
		object obj7 = default;
		nint num7 = (nint)(obj7 + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonFileSerializer jsonFileSerializer = default;
		object obj8 = jsonFileSerializer + 8;
		obj8 = obj2;
		object obj9 = jsonFileSerializer + 12;
		obj9 = writeFileTextDelegate;
		object json = ((DefaultSettingsProvider)this).SYBO_002EComponents_002ESettings_002EISettingsProvider_002EReflectionGetSettings((Type)arg1);
		JsonList jsonList = JsonList.ParseString((string)json);
		if (jsonList == null)
		{
			return;
		}
		bool flag3 = SettingsHelper.ShouldSerializeField((FieldInfo)(object)format);
		object obj10 = (flag3 ? 1 : 0) + 12;
		object obj11 = 0;
		object obj15 = default;
		Type type2 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
		{
			object obj12 = (flag3 ? 1 : 0) + 16;
			object obj13 = obj11 << 2;
			object field = obj12 + obj13;
			nint num8 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v51 (Il2CppClass<System.Type>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num9 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v83 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj7 = typeof(SerializeFileAttribute);
			((IntPtr*)num7)->m_value = (void*)(nint)obj7;
			Type type = Type.internal_from_handle((IntPtr)num7);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8582");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v59+8]");
				object obj16 = jsonFileSerializer.DeserializeFromFile(type2, (string)0, (JsonContext)null);
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v15 (Il2CppMethodInfo)+C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S4_v16+60]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S4_v17+48]");
				object obj19 = 0;
				object obj20 = obj19 & 0x7FF;
				object obj21 = obj20 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v279 @ S5_v15 (should have been resolved before IL gen)");
			}
			else
			{
				nint num11 = (nint)typeof(JsonClassInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v71 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
				object obj22 = (nint)0 & (nint)0x200;
				if (obj22 != null)
				{
					nint num12 = (nint)typeof(JsonClassInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v77 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Type name = JsonClassInfo.LookupValueType((FieldInfo)field);
				JsonDict orCreateDict = ((JsonDict)(object)jsonList).GetOrCreateDict((string)(object)name);
				JsonDict jsonDict = JsonApi.ReflectionSerializeDomAsType(type2, orCreateDict);
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S4_v8 (Il2CppMethodInfo)+C]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v9+60]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v10+48]");
				object obj25 = 0;
				object obj26 = obj25 & 0x7FF;
				object obj27 = obj26 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v296 @ S5_v10 (should have been resolved before IL gen)");
			}
			object obj28 = obj11 + 1;
			obj11 = obj28;
		}
	}

	public void LogFormat(string format, object arg1, object arg2)
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 12;
		object obj7 = default;
		obj6 = obj7;
		object obj8 = this + 8;
		obj8 = format;
		LogFormat((string)arg1, arg2);
	}

	public void LogFormat(string format, object arg1, object arg2, object arg3)
	{
		object obj = JsonReflectionParser.RecursiveReadValue((Type)(object)format, arg1, (JsonContext)arg3);
		bool flag = obj == null;
		bool flag2 = !flag;
		JsonFieldInfo json = (JsonFieldInfo)obj;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonFieldInfo jsonFieldInfo = default;
			jsonFieldInfo._002Ector();
			json = jsonFieldInfo;
		}
		JsonDict jsonDict = JsonDict.Deserialize((string)(object)json);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
	}

	public void LogFormat(string format, object[] args)
	{
	}

	public void LogFormat(int level, string format)
	{
	}

	public void LogFormat(int level, string format, object arg1)
	{
	}

	public void LogFormat(int level, string format, object arg1, object arg2)
	{
	}

	public unsafe void LogFormat(int level, string format, object arg1, object arg2, object arg3)
	{
		//IL_02bb: Expected Obj, but got I4
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04f4: Expected Obj, but got I
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0518: Expected Obj, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0338: Expected Obj, but got I
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_0369: Expected Obj, but got VT
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected VT, but got Unknown
		//IL_039a: Expected F4, but got Obj
		//IL_0395: Expected native int or pointer, but got VT
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_03c2: Expected F4, but got Obj
		//IL_03bd: Expected native int or pointer, but got VT
		//IL_03d7: Expected F4, but got I
		//IL_03d2: Expected native int or pointer, but got VT
		//IL_03ec: Expected I4, but got VT
		//IL_03ec: Expected Obj, but got I
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_040e: Expected Obj, but got VT
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0431: Expected F4, but got Obj
		//IL_042c: Expected native int or pointer, but got VT
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0201: Expected F4, but got Obj
		//IL_01fc: Expected native int or pointer, but got VT
		//IL_0216: Expected F4, but got I
		//IL_0211: Expected native int or pointer, but got VT
		//IL_0223: Expected I4, but got VT
		//IL_0231: Expected I, but got Obj
		//IL_0247: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got VT
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_048b: Expected F4, but got Obj
		//IL_0486: Expected native int or pointer, but got VT
		//IL_04a5: Expected F4, but got Obj
		//IL_04a0: Expected native int or pointer, but got VT
		//IL_04ba: Expected F4, but got I
		//IL_04b5: Expected native int or pointer, but got VT
		//IL_04cf: Expected I4, but got VT
		//IL_04cf: Expected Obj, but got I
		//IL_0272: Expected I, but got Obj
		MessagePrefix = (string)level;
		CategoryText = format;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v45 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 20;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v8 (System.Boolean)+38]");
		obj2 = 0;
		object obj3 = this + 24;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v12 (System.Boolean)+24]");
		obj3 = 0;
		object obj4 = this + 32;
		GameObject gameObject = ((Component)this).gameObject;
		obj4 = gameObject;
		_ = 1;
		nint num3 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v41 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 36;
		CharacterRendering instance = CharacterRendering.Instance;
		Material cachedModelMaterial = instance._cachedModelMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S2_v4 (UnityEngine.Material)+C0]");
		UnityEngine.Object key = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		object obj7 = ((AndroidNotification)arg1).get_Item((string)(object)key);
		obj6 = obj7;
		object obj8 = this + 40;
		CharacterRendering instance2 = CharacterRendering.Instance;
		Material cachedModelMaterial2 = instance2._cachedModelMaterial;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v9 (UnityEngine.Material)+B4]");
		UnityEngine.Object key2 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		object obj9 = ((AndroidNotification)arg1).get_Item((string)(object)key2);
		obj8 = obj9;
		Characters.CharacterId? characterId = ((CharacterOverlayHelper)arg2).EventCharacter();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77EA");
		nint num5 = (nint)typeof(GlobalColorsGenerated);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v28 (Il2CppClass<GlobalColorsGenerated>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num6 = (nint)typeof(GlobalColorsGenerated);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v74 (Il2CppClass<GlobalColorsGenerated>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = default;
		object obj11 = obj12 + 68;
		obj11 = GlobalColorsGenerated.DISCOUNT_STICKER_COLOR;
		object obj13 = obj12 + 72;
		obj13 = obj11;
		Matrix4x4 matrix4x = (Matrix4x4)(obj12 + 80);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		object obj14 = obj12 + 48;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v39+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.LogCategory)+3C]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj15 = this - -64;
		object obj16 = obj12 + 44;
		obj16 = GlobalColorsGenerated.DISCOUNT_STICKER_LABEL_COLOR;
		object obj17 = obj12 - -64;
		obj17 = obj16;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
		object obj18 = obj12 + 24;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v50+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		((UIWidget)obj15).rawPivot = (UIWidget.Pivot)matrix4x;
		nint num7 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S1_v55 (Il2CppClass<GlobalColors>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num8 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v68 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj20 = obj12 + 16;
		obj20 = GlobalColors.FIRST_PURCHASE_BONUS_BREADCRUMP_BUBBLE_COLOR;
		object obj21 = obj12 + 40;
		obj21 = obj20;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj21;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.LogCategory)+4C]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
	}

	public void LogFormat(int level, string format, object[] args)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] twoArgs = _twoArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogFormat(Enum level, string format)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void LogFormat(Enum level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void LogFormat(Enum level, string format, object arg1, object arg2)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] threeArgs = _threeArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogFormat(Enum level, string format, object arg1, object arg2, object arg3)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIDDefault = BaseSessionEvent.GetDeviceIDDefault();
		throw new ArrayTypeMismatchException();
	}

	public void LogFormat(Enum level, string format, object[] args)
	{
	}

	public void LogLongString(int level, string data)
	{
	}

	public void LogLongString(Enum level, string data)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
	}

	public void LogWarningFormat(string format)
	{
	}

	public void LogWarningFormat(string format, object arg1)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_00e9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		nint num3 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<System.Convert>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v20 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = Convert.ToInt32((byte)(int)format != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
	}

	public void LogWarningFormat(string format, object arg1, object arg2)
	{
	}

	public void LogWarningFormat(string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogWarningFormat(string format, object[] args)
	{
	}

	public void LogWarningFormat(int level, string format)
	{
	}

	public void LogWarningFormat(int level, string format, object arg1)
	{
	}

	public void LogWarningFormat(int level, string format, object arg1, object arg2)
	{
	}

	public void LogWarningFormat(int level, string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogWarningFormat(int level, string format, object[] args)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] twoArgs = _twoArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogWarningFormat(Enum level, string format)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void LogWarningFormat(Enum level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void LogWarningFormat(Enum level, string format, object arg1, object arg2)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] threeArgs = _threeArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogWarningFormat(Enum level, string format, object arg1, object arg2, object arg3)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIDDefault = BaseSessionEvent.GetDeviceIDDefault();
		throw new ArrayTypeMismatchException();
	}

	public void LogWarningFormat(Enum level, string format, object[] args)
	{
	}

	public void LogErrorFormat(string format)
	{
	}

	public void LogErrorFormat(string format, object arg1)
	{
	}

	public void LogErrorFormat(string format, object arg1, object arg2)
	{
	}

	public void LogErrorFormat(string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogErrorFormat(string format, object[] args)
	{
		LogErrorFormat(0, format, args);
	}

	public void LogErrorFormat(int level, string format)
	{
		//IL_000f: Expected Obj, but got I4
		LogErrorFormat((Enum)null, (string)level, (object)format);
	}

	public void LogErrorFormat(int level, string format, object arg1)
	{
		//IL_0013: Expected Obj, but got I4
		LogErrorFormat((Enum)null, (string)level, (object)format, arg1);
	}

	public void LogErrorFormat(int level, string format, object arg1, object arg2)
	{
		//IL_0017: Expected Obj, but got I4
		LogErrorFormat((Enum)null, (string)level, (object)format, arg1, arg2);
	}

	public void LogErrorFormat(int level, string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogErrorFormat(int level, string format, object[] args)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] twoArgs = _twoArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogErrorFormat(Enum level, string format)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void LogErrorFormat(Enum level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
	}

	public void LogErrorFormat(Enum level, string format, object arg1, object arg2)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] threeArgs = _threeArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogErrorFormat(Enum level, string format, object arg1, object arg2, object arg3)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIDDefault = BaseSessionEvent.GetDeviceIDDefault();
		throw new ArrayTypeMismatchException();
	}

	public void LogErrorFormat(Enum level, string format, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int level2 = Convert.ToInt32((byte)(int)level != 0);
		LogErrorFormat(level2, format, args);
	}

	public void LogException(Exception exception)
	{
		LogErrorFormat((Enum)null, (string)(object)exception);
	}

	public void LogException(int level, Exception exception)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)level != 0);
		LogErrorFormat((Enum)num3, (string)(object)exception);
	}

	public void LogException(Enum level, Exception exception)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
	}

	public void LogFormat(UnityEngine.Object context, string format)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I
		//IL_00e9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		nint num3 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<System.Convert>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v20 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = Convert.ToInt32((byte)(int)context != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
	}

	public void LogFormat(UnityEngine.Object context, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00b2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)(int)context != 0);
		LogErrorFormat((Enum)num3, format, arg1);
	}

	public void LogFormat(UnityEngine.Object context, string format, object arg1, object arg2)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)(int)context != 0);
		LogErrorFormat((Enum)num3, format, arg1, arg2);
	}

	public void LogFormat(UnityEngine.Object context, string format, object arg1, object arg2, object arg3)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)(int)context != 0);
		LogErrorFormat((Enum)num3, format, arg1, arg2, arg3);
	}

	public void LogFormat(UnityEngine.Object context, string format, object[] args)
	{
	}

	public void LogFormat(UnityEngine.Object context, int level, string format)
	{
	}

	public void LogFormat(UnityEngine.Object context, int level, string format, object arg1)
	{
	}

	public void LogFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2)
	{
	}

	public unsafe void LogFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2, object arg3)
	{
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected I4, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03d5: Expected I, but got Obj
		//IL_03eb: Expected Obj, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Obj, but got Unknown
		//IL_04bb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0098: Expected Obj, but got I4
		//IL_00b3: Expected Obj, but got I4
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0102: Expected I, but got Obj
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_0465: Expected I4, but got Obj
		//IL_0202: Expected I, but got Obj
		//IL_0218: Expected Obj, but got I
		//IL_0190: Expected I, but got Obj
		//IL_0301: Expected I, but got Obj
		//IL_0281: Expected I, but got Obj
		object obj = arg3 & 1;
		int num = format ^ 1;
		int num2 = num & level;
		int num3 = num2 & 1;
		object obj2 = arg1 & 1;
		nint num4 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v9 (Il2CppClass<SocialManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v74 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(FacebookLoginButtonOnline.FacebookStateChanged);
		object obj4 = action + 16;
		obj4 = this;
		((SocialManager)facebookDialogsSupported).RemoveFacebookStateChangedHandler(action);
		bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = 0;
		_ = 0;
		Action<bool> action2 = default;
		object obj5 = action2 + 16;
		obj5 = this;
		((SocialManager)facebookDialogsSupported2).friendsConsolidatedHandler -= action2;
		((FacebookLoginButtonOnline)this).OnPress(false);
		((FacebookPromotionReconnect)this).Init((Action)1);
		nint num7 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v20 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v70 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SOCIAL_BUTTON_LOGIN");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.LogCategory)+3D]");
		object key;
		string text2;
		object obj9;
		if ((nint)0 != 0)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v61 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v66 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			key = "SOCIAL_BUTTON_FEEDBACK_LOGIN_2_AWARDS";
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.LogCategory)+3E]");
			if ((nint)0 == 0)
			{
				text2 = text;
				goto IL_0456;
			}
			nint num11 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v39 (Il2CppClass<Strings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			bool flag = obj8 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Logging.LogCategory)+3C]");
			if ((nint)0 != 0)
			{
				if (flag)
				{
					key = "FACEBOO_PROMOTION_TOPRUN_TITEL";
				}
				else
				{
					nint num12 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v54 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						obj9 = "FACEBOO_PROMOTION_TOPRUN_TITEL";
						goto IL_0449;
					}
					key = "FACEBOO_PROMOTION_TOPRUN_TITEL";
				}
			}
			else if (flag)
			{
				key = "FACEBOOK_BUTTON_CONNECT";
			}
			else
			{
				nint num13 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v47 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					obj9 = "FACEBOOK_BUTTON_CONNECT";
					goto IL_0449;
				}
				key = "FACEBOOK_BUTTON_CONNECT";
			}
		}
		goto IL_0359;
		IL_0359:
		string text3 = Strings.GetDefault((string)key);
		text2 = text3;
		goto IL_0456;
		IL_0456:
		((UILabel)(object)MessagePrefix).fontSize = (int)text2;
		return;
		IL_0449:
		key = obj9;
		goto IL_0359;
	}

	public void LogFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] twoArgs = _twoArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogFormat(UnityEngine.Object context, Enum level, string format)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
	}

	public void LogFormat(UnityEngine.Object context, Enum level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
	}

	public void LogFormat(UnityEngine.Object context, Enum level, string format, object arg1, object arg2)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] threeArgs = _threeArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogFormat(UnityEngine.Object context, Enum level, string format, object arg1, object arg2, object arg3)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIDDefault = BaseSessionEvent.GetDeviceIDDefault();
		throw new ArrayTypeMismatchException();
	}

	public void LogFormat(UnityEngine.Object context, Enum level, string format, object[] args)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, string format)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, string format, object arg1)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, string format, object arg1, object arg2)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, string format, object[] args)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, int level, string format)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, int level, string format, object arg1)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] twoArgs = _twoArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogWarningFormat(UnityEngine.Object context, Enum level, string format)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
	}

	public void LogWarningFormat(UnityEngine.Object context, Enum level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
	}

	public void LogWarningFormat(UnityEngine.Object context, Enum level, string format, object arg1, object arg2)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] threeArgs = _threeArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogWarningFormat(UnityEngine.Object context, Enum level, string format, object arg1, object arg2, object arg3)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIDDefault = BaseSessionEvent.GetDeviceIDDefault();
		throw new ArrayTypeMismatchException();
	}

	public void LogWarningFormat(UnityEngine.Object context, Enum level, string format, object[] args)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, string format)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, string format, object arg1)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, string format, object arg1, object arg2)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, string format, object[] args)
	{
		LogErrorFormat(context, 0, format, args);
	}

	public void LogErrorFormat(UnityEngine.Object context, int level, string format)
	{
		//IL_0013: Expected Obj, but got I4
		LogErrorFormat(context, null, (string)level, format);
	}

	public void LogErrorFormat(UnityEngine.Object context, int level, string format, object arg1)
	{
		//IL_0017: Expected Obj, but got I4
		LogErrorFormat(context, null, (string)level, format, arg1);
	}

	public void LogErrorFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2)
	{
		//IL_001b: Expected Obj, but got I4
		LogErrorFormat(context, null, (string)level, format, arg1, arg2);
	}

	public void LogErrorFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2, object arg3)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
		//IL_0079: Expected I, but got Obj
		//IL_008f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] twoArgs = _twoArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogErrorFormat(UnityEngine.Object context, Enum level, string format)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
	}

	public void LogErrorFormat(UnityEngine.Object context, Enum level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
	}

	public void LogErrorFormat(UnityEngine.Object context, Enum level, string format, object arg1, object arg2)
	{
		//IL_00a4: Expected I, but got Obj
		//IL_00ba: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object[] threeArgs = _threeArgs;
		throw new ArrayTypeMismatchException();
	}

	public void LogErrorFormat(UnityEngine.Object context, Enum level, string format, object arg1, object arg2, object arg3)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string deviceIDDefault = BaseSessionEvent.GetDeviceIDDefault();
		throw new ArrayTypeMismatchException();
	}

	public void LogErrorFormat(UnityEngine.Object context, Enum level, string format, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int level2 = Convert.ToInt32((byte)(int)level != 0);
		LogErrorFormat(context, level2, format, args);
	}

	void IWriteLog.LogFormat(int level, string format)
	{
		//IL_000f: Expected Obj, but got I4
		LogErrorFormat((UnityEngine.Object)level, null, format);
	}

	void IWriteLog.LogFormat(int level, string format, object arg1)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00b2: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)(int)format != 0);
		LogErrorFormat((UnityEngine.Object)level, (Enum)num3, (string)arg1);
	}

	void IWriteLog.LogFormat(int level, string format, object arg1, object arg2)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_00b6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)(int)format != 0);
		LogErrorFormat((UnityEngine.Object)level, (Enum)num3, (string)arg1, arg2);
	}

	void IWriteLog.LogFormat(int level, string format, object arg1, object arg2, object arg3)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
		//IL_00ba: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)(int)format != 0);
		LogErrorFormat((UnityEngine.Object)level, (Enum)num3, (string)arg1, arg2, arg3);
	}

	void IWriteLog.LogFormat(int level, string format, object[] args)
	{
	}

	void IWriteLog.LogLongString(int level, string data)
	{
	}

	void IWriteLog.LogWarningFormat(int level, string format)
	{
	}

	void IWriteLog.LogWarningFormat(int level, string format, object arg1)
	{
	}

	void IWriteLog.LogWarningFormat(int level, string format, object arg1, object arg2)
	{
	}

	void IWriteLog.LogWarningFormat(int level, string format, object arg1, object arg2, object arg3)
	{
	}

	void IWriteLog.LogWarningFormat(int level, string format, object[] args)
	{
	}

	void IWriteLog.LogFormat(UnityEngine.Object context, int level, string format)
	{
	}

	void IWriteLog.LogFormat(UnityEngine.Object context, int level, string format, object arg1)
	{
	}

	void IWriteLog.LogFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2)
	{
	}

	void IWriteLog.LogFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2, object arg3)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00be: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = Convert.ToInt32((byte)level != 0);
		LogErrorFormat(context, (Enum)num3, format, arg1, arg2, arg3);
	}

	void IWriteLog.LogFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
	}

	void IWriteLog.LogWarningFormat(UnityEngine.Object context, int level, string format)
	{
	}

	void IWriteLog.LogWarningFormat(UnityEngine.Object context, int level, string format, object arg1)
	{
	}

	void IWriteLog.LogWarningFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2)
	{
	}

	void IWriteLog.LogWarningFormat(UnityEngine.Object context, int level, string format, object arg1, object arg2, object arg3)
	{
	}

	void IWriteLog.LogWarningFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
	}

	static LogCategory()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Singleton<LogManager>);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Logging.LogManager>>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Singleton<LogManager>);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Logging.LogManager>>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogManager instance = Singleton<LogManager>.GetInstance();
	}
}
