using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class BackgroundLayer
{
	public string Name;

	public BackgroundObject[] SingleObjectPrefabs;

	public BackgroundObject[] SkylineFillObjectPrefabs;

	private bool _dontRandomizeSingleObjectSpawnPosition;

	private float _speed;

	public int LayerIndex;

	private Vector3 _offsetFromLayerDefault;

	private DeviceInfo.PerformanceLevel _requiredPerformanceLevel;

	private bool _useCommonMaterial;

	private Color _commonMaterialTintColor;

	private readonly List<BackgroundObject> _backgroundObjects;

	private readonly List<BackgroundObject> _movingSingleObjects;

	private readonly List<BackgroundObject> _movingSkylineFillObjects;

	private int NextSingleObjectSpawnIndex__BackingField;

	private Material MaterialInstance__BackingField;

	public float Speed
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)SkylineFillObjectPrefabs;
		}
		set
		{
			//IL_000a: Invalid comparison between Obj and F4
			//IL_0036: Expected Obj, but got F4
			if (SkylineFillObjectPrefabs != (object)value)
			{
				SkylineFillObjectPrefabs = (BackgroundObject[])value;
				if (Application.platform != RuntimePlatform.OSXEditor)
				{
					((MovingTrain)this).OnDestroy();
					((MovingTrain)this).OnActivate();
				}
			}
		}
	}

	public Color CommonMaterialTintColor
	{
		get
		{
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Expected Obj, but got Unknown
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected Obj, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected Obj, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected Obj, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Expected Obj, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected Obj, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			Color color = default;
			object obj = color + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			obj = obj2;
			object obj3 = color + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj4 = default;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<BackgroundObject> list = default;
			list._002Ector();
			object obj5 = color + 68;
			obj5 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<BackgroundObject> list2 = default;
			list2._002Ector();
			object obj6 = color + 72;
			obj6 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<BackgroundObject> list3 = default;
			list3._002Ector();
			object obj7 = color + 76;
			obj7 = list3;
			object obj8 = color + 12;
			obj8 = SingleObjectPrefabs;
			object obj9 = color + 16;
			obj9 = SkylineFillObjectPrefabs;
			_ = _speed;
			object obj10 = this + 52;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v32+8]");
			_ = 0;
			object obj12 = obj11 + 16;
			obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj13 = color + 52;
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v35+8]");
			_ = 0;
			_ = LayerIndex;
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0028: Expected Obj, but got I
			object obj = value + 52;
			BackgroundLayer backgroundLayer = (BackgroundLayer)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			Name = (string)0;
		}
	}

	public DeviceInfo.PerformanceLevel RequiredPerformanceLevel
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
			object obj = default;
			if (obj != null && DebugSettings.UseQueuedEnvironmentKinds)
			{
				return (DeviceInfo.PerformanceLevel)45000;
			}
			return (DeviceInfo.PerformanceLevel)1000;
		}
	}

	public bool UseCommonMaterial => (byte)_requiredPerformanceLevel != 0;

	public bool DontRandomizeSingleObjectSpawnPosition => _useCommonMaterial;

	public unsafe Vector3 OffsetFromLayerDefault
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected VT, but got Unknown
			//IL_0027: Expected F4, but got Obj
			//IL_0022: Expected native int or pointer, but got VT
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			_ = Name;
			object obj = default;
			Vector3 vector = (Vector3)(obj + 52);
			((Vector3*)(nint)vector)->x = (float)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public int NextSingleObjectSpawnIndex
	{
		get
		{
			return _dontRandomizeSingleObjectSpawnPosition ? 1 : 0;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0028: Expected Obj, but got I
			object obj = value + 32;
			BackgroundLayer backgroundLayer = (BackgroundLayer)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			Name = (string)0;
		}
	}

	public Material MaterialInstance
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (Material)NextSingleObjectSpawnIndex__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			NextSingleObjectSpawnIndex__BackingField = (int)value;
		}
	}

	public List<BackgroundObject> BackgroundObjects => (List<BackgroundObject>)(object)MaterialInstance__BackingField;

	public List<BackgroundObject> MovingSingleObjects => _backgroundObjects;

	public List<BackgroundObject> MovingSkylineFillObjects => _movingSingleObjects;

	public BackgroundLayer()
	{
	}

	public BackgroundLayer(BackgroundLayer layerToCopy)
	{
		//IL_0014: Expected Obj, but got I4
		bool flag = ((HashSet<object>)LayerIndex).Remove(layerToCopy);
	}
}
