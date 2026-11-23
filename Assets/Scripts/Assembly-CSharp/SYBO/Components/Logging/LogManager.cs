using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Logging;

public class LogManager : Singleton<LogManager>
{
	public LogSettingsProvider SettingsProvider;

	private List<LogCategory> _categories;

	private LogCategorySettings[] _categorySettings;

	private LogSettings Settings__BackingField;

	public LogSettings Settings
	{
		get
		{
			return Settings__BackingField;
		}
		private set
		{
			Settings__BackingField = value;
		}
	}

	public IEnumerable<LogCategory> Categories => _categories;

	protected override void Awake()
	{
		base.Awake();
		Initialize();
	}

	public void Update()
	{
	}

	public void Dummy()
	{
	}

	public void Initialize()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		LogSettingsProvider settingsProvider = SettingsProvider;
		nint num = (nint)settingsProvider;
		object obj = settingsProvider + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<SYBO.Components.Logging.LogSettingsProvider>)+DC] (should have been resolved before IL gen)");
		LogSettings logSettings = default;
		Settings__BackingField = logSettings;
		ReflectionFindCategories();
	}

	public unsafe void ReflectionFindCategories()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_08c7: Expected VT, but got Obj
		//IL_001b: Expected I, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_0204: Expected Obj, but got I4
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected Obj, but got Unknown
		//IL_0070: Expected Obj, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0097: Expected VT, but got Obj
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Ref, but got Unknown
		//IL_00e5: Expected VT, but got Obj
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected Obj, but got Unknown
		//IL_066b: Expected Obj, but got I
		//IL_0482: Expected Obj, but got I
		//IL_02d7: Expected Obj, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0326: Expected Obj, but got I
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Ref, but got Unknown
		//IL_036b: Expected Obj, but got I
		//IL_03a3: Expected Obj, but got I
		//IL_09c3: Expected Obj, but got I
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected Obj, but got Unknown
		//IL_0a10: Expected Obj, but got I
		//IL_079f: Expected Obj, but got I
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		((List<T>)(object)_categories).Clear();
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(LogCategory));
		nint num = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S1_v11 (Il2CppClass<System.Type>)+194] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S1_v14+13C] (should have been resolved before IL gen)");
		object obj5 = 0;
		object obj8 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v20+C]");
			if (0 <= (nint)obj5)
			{
				break;
			}
			object obj6 = obj5 << 2;
			object obj7 = obj8 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v190+10]");
			Type type = (Type)0;
			object obj9 = type + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S1_v154+BC] (should have been resolved before IL gen)");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(LogCategory));
			if (typeFromHandle2 == obj10)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
				throw new ArrayTypeMismatchException();
			}
			object obj11 = obj5 + 1;
			obj5 = obj11;
		}
		List<LogCategory> categories = _categories;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		LogCategorySettings[] categorySettings = default;
		_categorySettings = categorySettings;
		List<LogCategory> categories2 = _categories;
		LogSettings logSettings = Settings__BackingField;
		Dictionary<string, LogCategorySettings> categories3 = logSettings.Categories;
		object obj12 = categories3._count - categories3._freeCount;
		bool flag = categories2._size != (nint)obj12;
		int num2 = 0;
		if (!flag)
		{
			List<LogCategory> categories4 = _categories;
			if (num2 >= categories4._size)
			{
				return;
			}
			LogSettings logSettings2 = Settings__BackingField;
			LogCategory logCategory = _categories.get_Item(num2);
			if (logSettings2.Categories.TryGetValue(logCategory.CategoryText, out *(LogCategorySettings*)(obj + 60)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj13 = 0;
				LogCategory logCategory2 = _categories.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				object obj15 = default;
				object obj14 = obj15 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ S2_v60+BC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj16 = 0;
				LogCategory logCategory3 = _categories.get_Item(num2);
				_ = logCategory3.CategoryText;
				LogCategory logCategory4 = _categories.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S1_v138+14]");
				logCategory4.Level = 0;
				LogCategory logCategory5 = _categories.get_Item(num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S1_v142+18]");
				logCategory5.HideStackLevel = 0;
				throw new ArrayTypeMismatchException();
			}
		}
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v259 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, SYBO.Components.Logging.LogCategorySettings>>>)+4] (should have been resolved before IL gen)");
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr2 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v310 @ S4_v10 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, SYBO.Components.Logging.LogCategorySettings>>>)+4] (should have been resolved before IL gen)");
		object obj19 = obj + 16;
		LogSettings logSettings3 = Settings__BackingField;
		Dictionary<string, LogCategorySettings>.ValueCollection values = logSettings3.Categories.Values;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj20 = obj + 40;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj22 = default;
		object obj24 = default;
		object obj25 = default;
		int num7;
		int num8 = default;
		int num9 = default;
		LogManager logManager = default;
		while (true)
		{
			_ = 0;
			object obj21 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj22 == null)
				{
					goto IL_05f6;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				object obj23 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj24 != obj25;
			num7 = num8;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_05f6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				num7 = num9;
			}
			_ = 0;
			object obj26 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			logManager = (LogManager)0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_05f6:
			object obj27 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A5BF");
			num7 = 0;
			break;
		}
		List<LogCategory> categories5 = logManager._categories;
		if (num7 < categories5._size)
		{
			LogCategory logCategory6 = logManager._categories.get_Item(num7);
			Dictionary<string, LogCategorySettings> dictionary = default;
			if (!dictionary.TryGetValue(logCategory6.CategoryText, out *(LogCategorySettings*)(obj + 36)))
			{
				LogCategory logCategory7 = logManager._categories.get_Item(num7);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				object obj29 = default;
				object obj28 = obj29 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v665 @ S2_v43+BC] (should have been resolved before IL gen)");
				string key = default;
				if (dictionary.TryGetValue(key, out *(LogCategorySettings*)(obj + 36)))
				{
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			object obj30 = 0;
			LogCategory logCategory8 = logManager._categories.get_Item(num7);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			object obj32 = default;
			object obj31 = obj32 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v676 @ S2_v33+BC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			object obj33 = 0;
			LogCategory logCategory9 = logManager._categories.get_Item(num7);
			_ = logCategory9.CategoryText;
			LogCategory logCategory10 = logManager._categories.get_Item(num7);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			object obj34 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S1_v71+14]");
			logCategory10.Level = 0;
			throw new ArrayTypeMismatchException();
		}
		LogSettings logSettings4 = logManager.Settings__BackingField;
		Dictionary<string, LogCategorySettings> categories6 = default;
		logSettings4.Categories = categories6;
		LogSettings logSettings5 = logManager.Settings__BackingField;
		logSettings5.Changed.Invoke();
	}

	public static void LogFormat(UnityEngine.Object context, LogCategory category, string format, object[] args)
	{
	}

	public static void LogFormat(UnityEngine.Object context, LogCategory category, int level, string format, object[] args)
	{
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+10]");
		if ((nint)0 >= (nint)level)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+14]");
			object obj = num - 0;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
				Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public static void LogFormat(LogCategory category, string format, object[] args)
	{
	}

	public static void LogFormat(LogCategory category, int level, string format, object[] args)
	{
		//IL_001c: Expected Obj, but got I4
		if (category.Level >= level)
		{
			object obj = category.Level - category.HideStackLevel;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
				Debug.LogFormat(format, args);
				Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public static void LogLongString(LogCategory category, int level, string data)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		if (category.Level < level)
		{
			return;
		}
		object obj = category.Level - category.HideStackLevel;
		if (level > (nint)obj)
		{
			Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
		}
		if (data._stringLength >= 769)
		{
			int num = 0;
			while (true)
			{
				int num2 = num + 768;
				if (num2 >= data._stringLength)
				{
					break;
				}
				int num3 = data.LastIndexOf('\n', num2);
				if (num3 < 0)
				{
					break;
				}
				int length = num3 - num;
				string message = data.Substring(num, length);
				Debug.Log(message);
				int num4 = num3 + 1;
				num = num4;
			}
		}
		object obj2 = category.Level - category.HideStackLevel;
		if (level > (nint)obj2)
		{
			Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.ScriptOnly);
		}
	}

	public static void LogWarningFormat(UnityEngine.Object context, LogCategory category, string format, object[] args)
	{
	}

	public static void LogWarningFormat(UnityEngine.Object context, LogCategory category, int level, string format, object[] args)
	{
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+10]");
		if ((nint)0 >= (nint)level)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+14]");
			object obj = num - 0;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
				Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public static void LogWarningFormat(LogCategory category, string format, object[] args)
	{
		Debug.LogWarningFormat(format, args);
	}

	public static void LogWarningFormat(LogCategory category, int level, string format, object[] args)
	{
		//IL_0038: Expected Obj, but got I4
		if (category.Level >= level)
		{
			object obj = category.Level - category.HideStackLevel;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
				Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public static void LogErrorFormat(UnityEngine.Object context, LogCategory category, string format, object[] args)
	{
	}

	public static void LogErrorFormat(UnityEngine.Object context, LogCategory category, int level, string format, object[] args)
	{
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+10]");
		if ((nint)0 >= (nint)level)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [category @ L1 (UnityEngine.Object)+14]");
			object obj = num - 0;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
				Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public static void LogErrorFormat(LogCategory category, string format, object[] args)
	{
	}

	public static void LogErrorFormat(LogCategory category, int level, string format, object[] args)
	{
		//IL_0038: Expected Obj, but got I4
		if (category.Level >= level)
		{
			object obj = category.Level - category.HideStackLevel;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
				Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public static void LogException(LogCategory category, Exception exception)
	{
	}

	public static void LogException(LogCategory category, int level, Exception exception)
	{
		//IL_0038: Expected Obj, but got I4
		if (category.Level >= level)
		{
			object obj = category.Level - category.HideStackLevel;
			if (level > (nint)obj)
			{
				Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
				Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.ScriptOnly);
			}
		}
	}

	public LogManager()
	{
		List<LogCategory> list = default;
		list._002Ector(20);
		_categories = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		LogCategorySettings[] categorySettings = default;
		_categorySettings = categorySettings;
		base._002Ector();
	}
}
