using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders.Lifecycles;

public class PlaceholderLifecycle : MonoBehaviour
{
	protected bool _initialized;

	protected PlaceholderPrefabProviderBase _prefabProvider;

	protected Placeholder _placeholder;

	public Placeholder Placeholder => _placeholder;

	protected void Awake()
	{
		((SpawnOnceOnStartPlaceholderLifecycle)this).Start();
	}

	protected virtual void InitializeCheck()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void Initialize()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			_initialized = true;
		}
	}

	public unsafe void SpawnInstancesEditor()
	{
		//IL_0102: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected I, but got Unknown
		//IL_016c: Expected I, but got Obj
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0075: Expected I, but got Obj
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v32 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		obj2 = typeof(PlaceholderPrefabProviderBase);
		nint num3 = (nint)(obj3 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		object obj4 = this + 16;
		Type t = Type.internal_from_handle((IntPtr)num3);
		Component componentInParent = GetComponentInParent(t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj5 = default;
		obj4 = obj5;
		obj3 = typeof(Placeholder);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		object obj6 = this + 20;
		Type t2 = Type.internal_from_handle((IntPtr)num3);
		Component componentInParent2 = GetComponentInParent(t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj7 = default;
		obj6 = obj7;
		List<Component> themedComponents = ((SynchronizedThemeAsset)(object)_placeholder).ThemedComponents;
		if (themedComponents != null)
		{
			_placeholder.Activate();
		}
	}

	public void DespawnInstancesEditor()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_00df: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		List<Component> themedComponents = ((SynchronizedThemeAsset)(object)_placeholder).ThemedComponents;
		if (themedComponents != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>(true);
		object obj = componentsInParent + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = componentsInParent + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (UnityEngine.Object)obj5 != this;
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	public void Spawn()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		_placeholder.Activate();
	}

	public void Despawn()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	protected virtual void DespawnInstances()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected void Activate()
	{
		List<Component> themedComponents = ((SynchronizedThemeAsset)(object)_placeholder).ThemedComponents;
		if (themedComponents != null)
		{
			_placeholder.Activate();
		}
	}

	protected void Deactivate()
	{
		_placeholder.Deactivate();
	}

	private void OnValidate()
	{
		_placeholder._002Ector();
	}

	public PlaceholderLifecycle()
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_010b: Expected I4, but got Obj
		//IL_010b: Expected I4, but got Obj
		//IL_010b: Expected I4, but got Obj
		//IL_0119: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AA3B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+C]");
		if ((nint)0 <= (nint)1)
		{
			return;
		}
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		GameObject components = gameObject;
		nint num = (nint)typeof(Utils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<Utils>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<Utils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string longNameList = Utils.GetLongNameList((Component[])(object)components);
		int num3 = "'".IndexOf((char)(int)obj, (int)"' has two PlaceholderLifecycle components at ", (int)longNameList);
		SDebug.LogFormat((string)num3, null);
	}
}
