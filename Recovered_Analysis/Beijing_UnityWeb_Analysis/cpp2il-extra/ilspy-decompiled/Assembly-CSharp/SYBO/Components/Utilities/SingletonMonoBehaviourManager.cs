using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Scriptables;
using UnityEngine;

namespace SYBO.Components.Utilities;

[Serializable]
public class SingletonMonoBehaviourManager : ScriptableObject
{
	private static SingletonMonoBehaviourManager _instance;

	private List<SingletonMonoBehaviour> Singletons;

	public static SingletonMonoBehaviourManager Instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a2: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (SingletonMonoBehaviourManager)((ComputeShader)(object)_instance).FindKernel((string)null);
		}
	}

	public static bool IsInstantiated()
	{
		return false;
	}

	public int GetSingletonCount<T>() where T : SingletonMonoBehaviour
	{
		//IL_0012: Expected Obj, but got I4
		//IL_0017: Expected I4, but got Obj
		bool isDestroyed = ((SingletonMonoBehaviour)(object)this).IsDestroyed;
		object obj = isDestroyed;
		return (int)obj;
	}

	public int GetSingletonCount()
	{
		return (int)(nint)((UnityEngine.Object)this).m_CachedPtr;
	}

	private void OnEnable()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	protected void OnDisable()
	{
		ScriptablesAccessor._002Ecctor();
	}

	private static void CheckInstance()
	{
		SingletonMonoBehaviour.LogCategoryName = "Utilities";
	}

	private void RemoveAnyNullOrMissing()
	{
		ScriptablesAccessor._002Ecctor();
	}

	internal SingletonMonoBehaviour FindSingleton(GameObject go)
	{
		//IL_001c: Expected Obj, but got I4
		bool flag = (SerializableSystemType)(object)this != (SerializableSystemType)(object)go;
		return (SingletonMonoBehaviour)((flag ? 1 : 0) ^ 1);
	}

	public void LogSingletons()
	{
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_00d7: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I4
		//IL_0102: Expected I, but got Obj
		List<SingletonMonoBehaviour> singletons = Singletons;
		int num = singletons._size - 1;
		int num2 = num;
		while (num2 >= 0)
		{
			SingletonMonoBehaviour singletonMonoBehaviour = Singletons.get_Item(num2);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v55 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (singletonMonoBehaviour == null)
			{
				string tag = singletonMonoBehaviour.tag;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((UnityEngine.Object)(object)tag == null)
				{
					int num7 = num2 - 1;
					num2 = num7;
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			throw new ArrayTypeMismatchException();
		}
	}

	internal bool HasSingleton(GameObject go)
	{
		//IL_0042: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_0112: Expected I4, but got Obj
		//IL_0083: Expected I, but got Obj
		LogSingletons();
		List<SingletonMonoBehaviour> singletons = Singletons;
		int num = singletons._size - 1;
		int num2 = num;
		SingletonMonoBehaviour singletonMonoBehaviour;
		while (true)
		{
			if (num2 < 0)
			{
				singletonMonoBehaviour = null;
				break;
			}
			SingletonMonoBehaviour singletonMonoBehaviour2 = Singletons.get_Item(num2);
			string tag = singletonMonoBehaviour2.tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (UnityEngine.Object)(object)tag != go;
			bool flag2 = !flag;
			bool flag3 = !flag2;
			singletonMonoBehaviour = singletonMonoBehaviour2;
			if (flag3)
			{
				break;
			}
			int num5 = num2 - 1;
			num2 = num5;
		}
		return (byte)(int)singletonMonoBehaviour != 0;
	}

	internal T FindSingleton<T>() where T : SingletonMonoBehaviour
	{
		//IL_000e: Expected Obj, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		object obj3 = obj2;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S2_v5 (should have been resolved before IL gen)");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v6+4]");
		object obj7 = 0;
		object obj8 = obj7 & 0x3FFF;
		object obj9 = obj8 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S2_v9 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	internal unsafe bool HasSingleton<T>() where T : SingletonMonoBehaviour
	{
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_017a: Expected Obj, but got I
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected I, but got Unknown
		//IL_01e6: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0140: Expected I4, but got Obj
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_00c3: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		LogSingletons();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		nint num = default;
		object obj3 = num + 24;
		object obj4 = obj3;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<System.Type>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v46 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj4;
		nint num4 = (nint)(obj2 + 8);
		((IntPtr*)num4)->m_value = (void*)(nint)obj2;
		Type type = Type.internal_from_handle((IntPtr)num4);
		List<SingletonMonoBehaviour> singletons = Singletons;
		int num5 = singletons._size;
		object obj7 = default;
		bool flag2 = default;
		while (true)
		{
			int num6 = num5 - 1;
			if (num6 < 0)
			{
				break;
			}
			SingletonMonoBehaviour singletonMonoBehaviour = Singletons.get_Item(num6);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num7 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v20 (Il2CppClass<System.Type>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v27 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = obj7 != type;
			num5 = num6;
			if (!flag)
			{
				object obj8 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
				obj = flag2;
				return flag2;
			}
		}
		return (byte)(int)obj != 0;
	}

	private bool IsSingletonUniqueByType(SingletonMonoBehaviour singleton)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool flag = HasSingleton((GameObject)(object)singleton);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)((ComputeShader)flag).FindKernel(null) != 0;
	}

	public void RegisterSingleton(SingletonMonoBehaviour singleton)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = singleton;
	}

	public void UnregisterSingleton(SingletonMonoBehaviour singleton)
	{
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009b: Expected I4, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)singleton).FindKernel((string)null) != 0)
		{
			LogSingletons();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			return;
		}
		string text = $"RegisterSingleton({(object[])(object)_instance}) This cannot be null.";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Exception ex = default;
		ex.SetErrorCode((int)text);
		((SingletonMonoBehaviourManager)(object)ex).RegisterSingleton((SingletonMonoBehaviour)null);
	}

	public void UnregisterAndDestroySingleton(SingletonMonoBehaviour singleton)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
	}

	internal void DestroySingleton(SingletonMonoBehaviour singletonToDestroy)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public SingletonMonoBehaviourManager()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected Obj, but got Unknown
		//IL_0341: Expected Obj, but got I4
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected Obj, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj5 = obj2 + 16;
		string[] array = StringUtility.SplitStringOnNewlines((string)(object)this);
		obj5 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		throw new ArrayTypeMismatchException();
	}
}
