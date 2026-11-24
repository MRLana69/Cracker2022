using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Picker.Pickers;
using UnityEngine;

namespace SYBO.Subway.Utilities;

public class DebugSettings : SingletonMonoBehaviour<DebugSettings>
{
	[NonSerialized]
	public bool _active;

	private bool _unlockedSceneCamera;

	private bool _characterInvincible;

	private bool _dontUseAssetBundlesInEditor;

	private bool _useManifestsForAssetBundlesInEditor;

	private bool _dontUseIdles;

	private bool _forceHighResCharacterTextures;

	private bool _editorDevicePerformanceLevelOverride;

	private DeviceInfo.PerformanceLevel _editorDevicePerformanceLevel;

	private bool _useDebugZDistanceTargetPosition;

	private bool _useQueuedEnvironmentKinds;

	private EnvironmentKind[] _queuedEnvironmentKinds;

	public static bool IsAllowed
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool result = default;
			return result;
		}
	}

	public static bool UnlockedSceneCamera
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return Globals.DEBUG_SETTINGS;
		}
	}

	public static bool CharacterInvincible
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+10]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_003e: Expected Obj, but got I4
			//IL_0055: Expected VT, but got I4
			//IL_0063: Expected Obj, but got I4
			Character instance = Character.Instance;
			if ((object)instance != null)
			{
				DontUseBaseBundleInEditor = true;
			}
			GameObject childTransform = ((Component)value).gameObject;
			HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.Manual, (Vector3)0);
			((DebugSettings)value)._002Ector();
		}
	}

	public static bool DontUseBaseBundleInEditor
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+11]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		}
	}

	public static bool UseManifestsForAssetBundlesInEditor
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+12]");
			return (nint)0 != 0;
		}
	}

	public static bool DontUseIdles
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+13]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		}
	}

	public static bool ForceHighResCharacterTextures
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+14]");
			return (nint)0 != 0;
		}
	}

	public static bool OverrideEditorDevicePerformanceLevel
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+15]");
			return (nint)0 != 0;
		}
	}

	public static DeviceInfo.PerformanceLevel EditorDevicePerformanceLevel
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+16]");
			return ((nint)0 != 0) ? DeviceInfo.PerformanceLevel.Medium : DeviceInfo.PerformanceLevel.Low;
		}
	}

	public static bool UseDebugZDistanceTargetPosition
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+18]");
			return false;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		}
	}

	public static bool UseQueuedEnvironmentKinds
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+1C]");
			return (nint)0 != 0;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		}
	}

	public static EnvironmentKind[] QueuedEnvironmentKinds
	{
		get
		{
			//IL_0013: Expected VT, but got Obj
			//IL_0032: Expected Obj, but got I4
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (T)+1D]");
			bool flag = (nint)0 != 0;
			return (EnvironmentKind[])flag;
		}
		set
		{
			//IL_0013: Expected VT, but got Obj
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			object obj = value & 1;
		}
	}

	protected override void SubclassInitialize()
	{
		((DefaultPicker)(object)this)._002Ector();
	}

	private static void CheckIsAllowed()
	{
		PickupManager.SpawnDistanceMinToCharacter = 112.5f;
	}

	private void ValidateEnvironmentKinds()
	{
		//IL_001d: Expected VT, but got Obj
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Expected VT, but got Obj
		//IL_000e: Expected Obj, but got VT
		DebugQueuedEnvironments.UpdateQueuedEnvironmentKinds();
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		object obj = val + 32;
		obj = this;
		_00210 val2 = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((DebugSettings)val2)._002Ector();
	}

	public DebugSettings()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_014b: Expected I, but got Obj
		//IL_0161: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_018c: Expected I, but got Obj
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		if (_queuedEnvironmentKinds == null)
		{
			return;
		}
		EnvironmentKind[] queuedEnvironmentKinds = _queuedEnvironmentKinds;
		object obj = default;
		if ((nint)obj >= queuedEnvironmentKinds.Length)
		{
			return;
		}
		object obj2 = _queuedEnvironmentKinds + 16;
		object obj3 = obj << 2;
		object obj4 = obj2 + obj3;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v15+8]");
		if ((nint)0 != int.MaxValue)
		{
			object obj6 = _queuedEnvironmentKinds + 16;
			object obj7 = obj << 2;
			object obj8 = obj6 + obj7;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v48+8]");
			if ((nint)0 != 0)
			{
				object obj10 = _queuedEnvironmentKinds + 16;
				object obj11 = obj << 2;
				object obj12 = obj10 + obj11;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v55+8]");
				if ((nint)0 != 64)
				{
					object obj14 = _queuedEnvironmentKinds + 16;
					object obj16 = default;
					object obj15 = obj16 << 2;
					object envKind = obj14 + obj15;
					bool flag = EnvironmentKind.IsValidDensity((EnvironmentKind)envKind);
					throw new ArrayTypeMismatchException();
				}
			}
		}
		nint num = (nint)typeof(EnvironmentKind);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v30 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num2 = (nint)typeof(EnvironmentKind);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v38 (Il2CppClass<SYBO.Subway.Level.EnvironmentKind>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		throw new ArrayTypeMismatchException();
	}
}
