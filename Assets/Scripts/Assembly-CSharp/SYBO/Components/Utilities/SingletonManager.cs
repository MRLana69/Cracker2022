using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class SingletonManager : ScriptableObject
{
	private static SingletonManager _instance;

	private List<Singleton> Singletons;

	public static SingletonManager Instance
	{
		get
		{
			//IL_000e: Expected VT, but got Obj
			//IL_001c: Expected Obj, but got VT
			//IL_0053: Expected VT, but got Obj
			//IL_005c: Expected Obj, but got VT
			//IL_007c: Expected Obj, but got I
			if (!IsInstantiated())
			{
				_0021_00210 val = (_0021_00210)UnityEngine.Object.FindObjectOfType<T>();
				_instance = (SingletonManager)val;
				if (!IsInstantiated())
				{
					_0021_00210 val2 = (_0021_00210)ScriptableObject.CreateInstance<T>();
					_instance = (SingletonManager)val2;
				}
				if (!IsInstantiated())
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+5C]");
					object arg = 0;
					string message = $"Instance.get({arg}) This cannot be null.";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Exception ex = default;
					ex._002Ector(message);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				}
			}
			return _instance;
		}
	}

	public static bool IsInstantiated()
	{
		return _instance != null;
	}

	public int GetSingletonCount<T>() where T : Singleton
	{
		//IL_003a: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Utilities.SingletonManager::GetSingletonCount>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v6 (Il2CppMethodRgctx<SYBO.Components.Utilities.SingletonManager::GetSingletonCount>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S2_v7+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetSingletonCount()
	{
		List<Singleton> singletons = Singletons;
		return singletons._size;
	}

	private void OnEnable()
	{
		CheckInstance();
	}

	protected void OnDisable()
	{
		CheckInstance();
	}

	private static void CheckInstance()
	{
		if (!IsInstantiated())
		{
			SingletonManager instance = Instance;
			_instance = instance;
		}
		_instance.RemoveAnyNullOrMissing();
	}

	private void RemoveAnyNullOrMissing()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		List<Singleton> singletons = Singletons;
		int num = singletons._size - 1;
		int num2 = num;
		while (num2 > -1)
		{
			Singleton singleton = Singletons.get_Item(num2);
			if (!(singleton == null))
			{
				GameObject gameObject = singleton.gameObject;
				if (!(gameObject == null))
				{
					int num3 = num2 - 1;
					num2 = num3;
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			throw new ArrayTypeMismatchException();
		}
	}

	internal Singleton FindSingleton(GameObject go)
	{
		RemoveAnyNullOrMissing();
		List<Singleton> singletons = Singletons;
		int num = singletons._size - 1;
		int num2 = num;
		Singleton result;
		while (true)
		{
			if (num2 > -1)
			{
				Singleton singleton = Singletons.get_Item(num2);
				GameObject gameObject = singleton.gameObject;
				bool flag = gameObject != go;
				result = singleton;
				if (!flag)
				{
					break;
				}
				int num3 = num2 - 1;
				num2 = num3;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	public void LogSingletons()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		//IL_03b0: Expected Obj, but got I4
		object obj = default;
		int num = obj - 48;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int singletonCount = GetSingletonCount();
		object obj2 = num + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	internal bool HasSingleton(GameObject go)
	{
		Singleton singleton = FindSingleton(go);
		return singleton != null;
	}

	internal T FindSingleton<T>() where T : Singleton
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_001c: Expected VT, but got I
		//IL_00b3: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		RemoveAnyNullOrMissing();
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		List<Singleton> singletons = Singletons;
		int num2 = singletons._size;
		object obj4 = default;
		T result = default;
		while (true)
		{
			int num3 = num2 - 1;
			if (num3 <= -1)
			{
				break;
			}
			Singleton singleton = Singletons.get_Item(num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
			bool flag = typeFromHandle != obj4;
			num2 = num3;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
				return result;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (T)0;
	}

	internal bool HasSingleton<T>() where T : Singleton
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Utilities.SingletonManager::HasSingleton>>)+4] (should have been resolved before IL gen)");
		UnityEngine.Object obj = default;
		return obj;
	}

	private bool IsSingletonUniqueByType(Singleton singleton)
	{
		List<Singleton> singletons = Singletons;
		int num = singletons._size - 1;
		int num2 = num;
		object obj = default;
		object obj2 = default;
		while (num2 > -1)
		{
			Singleton singleton2 = Singletons.get_Item(num2);
			if (singleton2 != singleton)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
				if (obj == obj2)
				{
					break;
				}
			}
			int num3 = num2 - 1;
			num2 = num3;
		}
		return (byte)(num2 >> 31) != 0;
	}

	public void RegisterSingleton(Singleton singleton)
	{
		//IL_003a: Expected Obj, but got I
		if (singleton != null)
		{
			RemoveAnyNullOrMissing();
			Singletons.Add(singleton);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v10+5C]");
		object arg = 0;
		string message = $"RegisterSingleton({arg}) This cannot be null.";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public void UnregisterSingleton(Singleton singleton)
	{
		bool flag = Singletons.Remove(singleton);
	}

	public void UnregisterAndDestroySingleton(Singleton singleton)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	internal void DestroySingleton(Singleton singletonToDestroy)
	{
		if (Application.isPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
	}

	public SingletonManager()
	{
		List<Singleton> list = default;
		list._002Ector();
		Singletons = list;
		base._002Ector();
	}
}
