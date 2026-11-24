using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Settings;
using SYBO.Components.Singletons;
using SYBO.Components.Utilities;
using UnityEngine.Events;

namespace SYBO.Components.Logging;

[Serializable]
public class LogManager : Singleton<LogManager>
{
	private object _lockObject;

	private List<LogCategory> _categories;

	private LogCategorySettings[] _categorySettings;

	private LogSettings _settings;

	private string UserData__BackingField;

	private string CurrentScene__BackingField;

	public LogSettings Settings
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			LogSettings result = default;
			return result;
		}
		set
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
	}

	public IEnumerable<LogCategory> Categories => (IEnumerable<LogCategory>)_settings;

	public string UserData
	{
		get
		{
			return (string)(object)_categories;
		}
		internal set
		{
		}
	}

	public string CurrentScene
	{
		get
		{
			return UserData__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 24;
			obj = value;
		}
	}

	private LogManager()
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		LogCategory.LogEngine__BackingField = (ILogPlatform)this;
	}

	public override void Initialize()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		object obj = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)20);
		object obj3 = this + 12;
		obj3 = list;
		object obj4 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = default;
		obj4 = obj5;
		nint num = (nint)typeof(Singleton<LogManager>);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v15 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Logging.LogManager>>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Singleton<LogManager>);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21 (Il2CppClass<SYBO.Components.Singletons.Singleton`1<SYBO.Components.Logging.LogManager>>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private unsafe void OnLogSettingsChanged()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_005f: Expected I, but got Obj
		//IL_012b: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_016c: Expected I, but got Obj
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		if (_settings != null)
		{
			UpdateCategorySettings();
		}
		else
		{
			nint num = (nint)typeof(StaticSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StaticSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v48 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NotifyEntry((LogEntry)(object)StaticSettings.Log);
			LogSettings settings = _settings;
			LogSettings settings2 = _settings;
			LogManager logManager;
			if (settings2.Changed != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				object obj3 = default;
				object obj2 = obj3 + 16;
				obj2 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5C0");
				logManager = this;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5BB");
				object obj4 = _settings + 24;
				object obj5 = default;
				obj4 = obj5;
				logManager = this;
			}
			LogSettings settings3 = _settings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			UnityAction unityAction = default;
			((Delegate)unityAction).method_ptr = method_ptr;
			((Delegate)unityAction).method = (nint)__ldftn(LogManager.OnLogSettingsChanged);
			object obj6 = unityAction + 16;
			obj6 = logManager;
			settings3.Changed.RemoveListener(unityAction);
		}
		nint num4 = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v9 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num5 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v20 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1A8");
		object obj8 = default;
		if (obj8 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num6 = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num7 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v11 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B294");
	}

	private void ReflectionFindCategories()
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((LogSettings)(object)this)._002Ector();
		nint num = (nint)typeof(SettingsEngine);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SettingsEngine);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SettingsEngine.Backup();
	}

	private unsafe void UpdateCategorySettings()
	{
		//IL_0281: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected Obj, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected I, but got Unknown
		//IL_02f9: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_033d: Expected I, but got Obj
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected Obj, but got Unknown
		//IL_00f0: Expected I, but got Obj
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_038c: Expected I, but got Obj
		//IL_0188: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v68 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		object obj4 = obj3 + 8;
		obj4 = typeof(LogCategory);
		nint num3 = (nint)(obj3 + 12);
		((IntPtr*)num3)->m_value = (void*)(nint)obj4;
		Type assembly = Type.internal_from_handle((IntPtr)num3);
		Type[] types = ReflectionWrapper.GetTypes((Assembly)(object)assembly);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8597");
		object obj6 = default;
		object obj5 = obj6 + 12;
		object obj7 = 0;
		object obj12 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				object obj8 = obj6 + 16;
				object obj9 = obj7 << 2;
				object obj10 = obj8 + obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @858E");
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v27 (Il2CppClass<System.Type>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num5 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v60 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = typeof(LogCategory);
				((IntPtr*)num3)->m_value = (void*)(nint)obj2;
				Type type = Type.internal_from_handle((IntPtr)num3);
				if (obj12 == type)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v49 (Il2CppClass<System.Type>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num7 = (nint)typeof(Type);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v64 (Il2CppClass<System.Type>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					break;
				}
				object obj14 = obj7 + 1;
				obj7 = obj14;
				continue;
			}
			((LogSettings)(object)this)._002Ector();
			return;
		}
		obj3 = typeof(int);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type type2 = Type.internal_from_handle((IntPtr)num3);
		throw new ArrayTypeMismatchException();
	}

	public void NotifyEntry(LogEntry entry)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I4
		//IL_029e: Expected Obj, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		object obj3 = obj2 + 8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj5 = default;
		object obj4 = obj5;
		object obj7 = default;
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj8 = default;
		if (obj6 == obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 123)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public string GetCategoryText(int _filterCategory)
	{
		//IL_00dd: Expected Obj, but got I
		//IL_00fd: Expected I4, but got Obj
		//IL_00fd: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0041: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_0195: Expected Obj, but got I
		//IL_005e: Expected Obj, but got I4
		//IL_0071: Expected Obj, but got I4
		//IL_008a: Expected Obj, but got I4
		//IL_009a: Expected I4, but got Obj
		//IL_00af: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [_filterCategory @ L1 (System.Int32)+C]");
		int num = default;
		string text;
		if (((string)0).get_Chars(num) != '\0')
		{
			object obj = _filterCategory + 12;
			obj = num;
			text = (string)1;
		}
		else
		{
			text = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [_filterCategory @ L1 (System.Int32)+8]");
		char c = ((string)0).get_Chars((int)_categories);
		bool flag = c == '\0';
		string result = text;
		if (!flag)
		{
			object obj2 = _filterCategory + 8;
			obj2 = _categories;
			result = (string)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [_filterCategory @ L1 (System.Int32)+20]");
		if ((nint)0 == 0)
		{
			_ = 1;
			object obj3 = _filterCategory + 28;
			string text2 = string.ConcatArray((string[])(object)_categories, (int)" - ");
			obj3 = text2;
			result = (string)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [_filterCategory @ L1 (System.Int32)+14]");
		_settings = (LogSettings)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [_filterCategory @ L1 (System.Int32)+18]");
		UserData__BackingField = (string)0;
		object obj4 = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [_filterCategory @ L1 (System.Int32)+1C]");
		obj4 = 0;
		return result;
	}

	public int GetCategoriesCount()
	{
		//IL_0007: Expected I4, but got Obj
		return (int)CurrentScene__BackingField;
	}

	public static void LogLongString(LogCategory category, int level, string data)
	{
	}
}
