using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Placeholders.PrefabProviders;

public abstract class PlaceholderPrefabProviderBase : MonoBehaviour
{
	protected bool _initialized;

	private ThemeManager _themeManager;

	protected List<Transform> _prefabsToSpawn;

	internal List<Transform> PrefabsToSpawn
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (List<Transform>)1;
		}
	}

	internal abstract int PrefabCount { get; }

	private void Awake()
	{
		((ModelSelectionPlaceholderLifecycle)this).Initialize();
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

	internal abstract void Evaluate();

	internal abstract Transform GetPrefab(int prefabIndex);

	internal Transform GetThemedPrefab(Transform prefabTransform)
	{
		//IL_000d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase)+18]");
		return (Transform)0;
	}

	protected PlaceholderPrefabProviderBase()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 16;
		GameStateMachine instance = GameStateMachine.Instance;
		obj2 = instance;
	}
}
