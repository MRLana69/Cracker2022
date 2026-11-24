using System;
using System.Globalization;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace UnityUtilities;

public class PersistentSingletonMonoBehaviour<TSubclass> : MonoBehaviour where TSubclass : PersistentSingletonMonoBehaviour<TSubclass>
{
	private static TSubclass _instance;

	private bool _skipOnLevelWasLoaded;

	public unsafe static TSubclass instance
	{
		get
		{
			//IL_00f5: Expected Obj, but got I
			//IL_0103: Expected I, but got Obj
			//IL_0119: Expected Obj, but got I
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected I, but got Unknown
			//IL_015e: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_0078: Expected Obj, but got I4
			//IL_00b5: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L0 (Il2CppMethodInfo)+18]");
			object obj = 0;
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12 (Il2CppClass<System.Type>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v32 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = obj;
			nint num3 = (nint)(obj3 + 4);
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Type type = Type.internal_from_handle((IntPtr)num3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string text2 = default;
			string text = text2.ToLower((CultureInfo)(object)"UI");
			char[] trimChars;
			if (text != null)
			{
				trimChars = (char[])2;
			}
			else
			{
				string text3 = text2.ToLower((CultureInfo)(object)"UnityEngine.");
				if (text3 == null)
				{
					return (TSubclass)(object)text2;
				}
				trimChars = (char[])12;
			}
			return (TSubclass)(object)text2.Trim(trimChars);
		}
	}

	protected bool instanceExists
	{
		get
		{
			//IL_00ab: Expected Obj, but got I
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Expected Obj, but got Unknown
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected Obj, but got Unknown
			//IL_00ef: Expected I, but got Obj
			//IL_0105: Expected Obj, but got I
			//IL_0127: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected Obj, but got I
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 24;
			object obj2 = obj;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S2_v5 (should have been resolved before IL gen)");
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object obj7 = default;
			bool flag = obj7 != null;
			bool flag2 = !flag;
			UnityEngine.Object obj8 = obj7;
			if (!flag2)
			{
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10+8]");
				object obj10 = 0;
				object obj11 = obj10 & 0x3FFF;
				object obj12 = obj11 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S2_v11 (should have been resolved before IL gen)");
				UnityEngine.Object obj13 = default;
				obj8 = obj13;
			}
			return (byte)(int)obj8 != 0;
		}
	}

	private void Awake()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	protected virtual void OnDestroy()
	{
		//IL_0217: Expected Obj, but got I
		//IL_022f: Expected Obj, but got I
		//IL_023f: Expected Obj, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_00b5: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got I
		//IL_01dd: Expected Obj, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0166: Expected I, but got Obj
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v5+8]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = default;
		if (obj7 != null)
		{
			string obj8 = tag;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj8);
			return;
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v9+60]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v12+5C]");
		object obj12 = 0;
		object obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S2_v8+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		object obj15 = default;
		obj12 = obj15;
		string text = tag;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)text).Exec();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v21+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v22+14]");
		object obj19 = 0;
		UnityAction<Scene, LoadSceneMode> unityAction = default;
		object obj20 = unityAction + 16;
		obj20 = this;
		SceneManager.sceneLoaded -= unityAction;
	}

	protected virtual void Start()
	{
		//IL_00a1: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00d3: Expected Obj, but got I
		//IL_00e1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected virtual void OnPersistentSingletonAwake()
	{
		_ = 0;
	}

	protected virtual void OnPersistentSingletonDestroyed()
	{
	}

	protected virtual void OnSceneSwitched()
	{
	}

	protected virtual void OnAwakeOrSwitch()
	{
	}

	private unsafe void _003CAwake_003Eb__6_0(Scene scene, LoadSceneMode loadSceneMode)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got VT
		_ = ((LoadSceneMode*)(int)loadSceneMode)->value__;
		object obj = this + 16;
		obj = scene;
	}
}
