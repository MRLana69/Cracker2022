using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

[Serializable]
public class BackgroundLayer
{
	public string Name;

	public BackgroundObject[] SingleObjectPrefabs;

	public BackgroundObject[] SkylineFillObjectPrefabs;

	private float _speed;

	public int LayerIndex;

	private Vector3 _offsetFromLayerDefault;

	private DeviceInfo.PerformanceLevel _requiredPerformanceLevel;

	private bool _useCommonMaterial;

	private Color _commonMaterialTintColor;

	private readonly List<BackgroundObject> _backgroundObjects;

	private readonly List<BackgroundObject> _movingSingleObjects;

	private readonly List<BackgroundObject> _movingSkylineFillObjects;

	public float Speed
	{
		get
		{
			return _speed;
		}
		set
		{
			_speed = value;
		}
	}

	public unsafe Color CommonMaterialTintColor
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)_commonMaterialTintColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Level.BackgroundLayer)+38]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_commonMaterialTintColor = (Color)value.r;
			_ = value.b;
		}
	}

	public DeviceInfo.PerformanceLevel RequiredPerformanceLevel => _requiredPerformanceLevel;

	public bool UseCommonMaterial => _useCommonMaterial;

	public unsafe Vector3 OffsetFromLayerDefault
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_offsetFromLayerDefault;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Level.BackgroundLayer)+24]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public int NextSingleObjectSpawnIndex
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public Material MaterialInstance
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public List<BackgroundObject> BackgroundObjects => _backgroundObjects;

	public List<BackgroundObject> MovingSingleObjects => _movingSingleObjects;

	public List<BackgroundObject> MovingSkylineFillObjects => _movingSkylineFillObjects;

	public BackgroundLayer()
	{
		//IL_0061: Expected VT, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		BackgroundObject[] singleObjectPrefabs = default;
		SingleObjectPrefabs = singleObjectPrefabs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		BackgroundObject[] skylineFillObjectPrefabs = default;
		SkylineFillObjectPrefabs = skylineFillObjectPrefabs;
		List<BackgroundObject> list = default;
		list._002Ector();
		_backgroundObjects = list;
		List<BackgroundObject> list2 = default;
		list2._002Ector();
		_movingSingleObjects = list2;
		List<BackgroundObject> list3 = default;
		list3._002Ector();
		_movingSkylineFillObjects = list3;
		_ = 4575657222473777152L;
		_commonMaterialTintColor = (Color)4575657222473777152L;
		_speed = 1f;
	}

	public BackgroundLayer(BackgroundLayer layerToCopy)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		BackgroundObject[] singleObjectPrefabs = default;
		SingleObjectPrefabs = singleObjectPrefabs;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		BackgroundObject[] skylineFillObjectPrefabs = default;
		SkylineFillObjectPrefabs = skylineFillObjectPrefabs;
		List<BackgroundObject> list = default;
		list._002Ector();
		_backgroundObjects = list;
		List<BackgroundObject> list2 = default;
		list2._002Ector();
		_movingSingleObjects = list2;
		List<BackgroundObject> list3 = default;
		list3._002Ector();
		_movingSkylineFillObjects = list3;
		SingleObjectPrefabs = layerToCopy.SingleObjectPrefabs;
		SkylineFillObjectPrefabs = layerToCopy.SkylineFillObjectPrefabs;
		_speed = layerToCopy._speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layerToCopy @ L1 (SYBO.Subway.Level.BackgroundLayer)+38]");
		_ = 0;
		_commonMaterialTintColor = layerToCopy._commonMaterialTintColor;
		LayerIndex = layerToCopy.LayerIndex;
	}
}
