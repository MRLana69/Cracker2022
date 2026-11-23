using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Cameras;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Level;

public class EnvironmentBackground : MonoBehaviour
{
	private sealed class _003CStart_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EnvironmentBackground _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			EnvironmentBackground environmentBackground = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					throw new ArgumentException();
				}
				return true;
			}
			_003C_003E1__state = -1;
			CharacterCamera instance = CharacterCamera.Instance;
			Transform transform = instance.transform;
			environmentBackground._characterCameraTransform = transform;
			ThemeManager instance2 = ThemeManager.Instance;
			environmentBackground._themeManager = instance2;
			throw new ArgumentException();
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private List<BackgroundLayer> _backgroundLayers;

	private Transform _characterCameraTransform;

	private Transform _transform;

	private ThemeManager _themeManager;

	private Theme _theme;

	private WaitForSeconds _waitForOneSecond;

	private float _layerSpacing;

	private void Awake()
	{
		Transform transform = base.transform;
		_transform = transform;
		WaitForSeconds waitForSeconds = default;
		waitForSeconds.m_Seconds = 1f;
		_waitForOneSecond = waitForSeconds;
	}

	private void OnDestroy()
	{
		if (_themeManager != null)
		{
			throw new ArgumentException();
		}
	}

	private IEnumerator Start()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void ThemeManager_ThemeChanged(Theme theme)
	{
		ResetBackground(theme);
	}

	private void ResetBackground(Theme theme)
	{
		Background background = theme._background;
		_layerSpacing = background.LayerSpacing;
		throw new ArgumentException();
	}

	private unsafe void LateUpdate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004f: Expected F4, but got I
		//IL_004a: Expected native int or pointer, but got VT
		//IL_005e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Vector3 position = _characterCameraTransform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num = 0f + 1000f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 0;
		((Vector3*)(nint)vector)->x = 0f;
		_transform.position = vector;
	}

	private void ExecuteOnEachBackgroundLayer(Action<BackgroundLayer> actionToExecute)
	{
		int num = 0;
		while (true)
		{
			List<BackgroundLayer> backgroundLayers = _backgroundLayers;
			if (num < backgroundLayers._size)
			{
				BackgroundLayer backgroundLayer = _backgroundLayers.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C] (should have been resolved before IL gen)");
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	private void UpdateLayer(BackgroundLayer layer)
	{
		int num = UpdateMovingSingleObjects(layer._movingSingleObjects, layer, layer.NextSingleObjectSpawnIndex__BackingField);
		layer.NextSingleObjectSpawnIndex__BackingField = num;
		UpdateSkylineFillMovement(layer._movingSkylineFillObjects, layer);
	}

	private void ClearData(BackgroundLayer layer)
	{
		int num = 0;
		while (true)
		{
			List<BackgroundObject> backgroundObjects = layer._backgroundObjects;
			if (backgroundObjects._size <= num)
			{
				break;
			}
			BackgroundObject backgroundObject = layer._backgroundObjects.get_Item(num);
			GameObject obj = backgroundObject.gameObject;
			UnityEngine.Object.Destroy(obj);
			int num2 = num + 1;
			num = num2;
		}
		((List<T>)(object)layer._backgroundObjects).Clear();
		((List<T>)(object)layer._movingSingleObjects).Clear();
		((List<T>)(object)layer._movingSkylineFillObjects).Clear();
	}

	private unsafe void PrepareLayer(BackgroundLayer layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00c2: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected VT, but got Unknown
		//IL_00f4: Expected Obj, but got I
		//IL_0141: Expected Obj, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_01af: Expected F4, but got I
		//IL_01aa: Expected native int or pointer, but got VT
		//IL_01d1: Expected F4, but got I
		//IL_01cc: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		if (layer.MaterialInstance__BackingField != null)
		{
			UnityEngine.Object.Destroy(layer.MaterialInstance__BackingField);
			layer.MaterialInstance__BackingField = null;
		}
		if (~(layer._useCommonMaterial ? 1u : 0u) == 0)
		{
			ThemeManager themeManager = _themeManager;
			Theme theme = themeManager._theme;
			Background background = theme._background;
			Material material = default;
			material._002Ector(background.LayerCommonMaterialShader);
			layer.MaterialInstance__BackingField = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L1 (SYBO.Subway.Level.BackgroundLayer)+38]");
			_ = 0;
			_ = layer._commonMaterialTintColor;
			Color color = (Color)(vector + 16);
			layer.MaterialInstance__BackingField.color = color;
		}
		object obj2 = 0;
		while (true)
		{
			BackgroundObject[] singleObjectPrefabs = layer.SingleObjectPrefabs;
			if (singleObjectPrefabs.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)singleObjectPrefabs + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28+10]");
			if ((UnityEngine.Object)0 != null)
			{
				object obj5 = obj2 << 2;
				object obj6 = (object)layer.SingleObjectPrefabs + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v19+10]");
				BackgroundObject backgroundObject = InitializeBackgroundObject((BackgroundObject)0, layer);
				if (~(backgroundObject._movable ? 1u : 0u) == 0)
				{
					MoveGameObject component = backgroundObject.GetComponent<MoveGameObject>();
					Transform transform = backgroundObject.transform;
					Vector3 localPosition = transform.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
					((Vector3*)(nint)vector)->x = 0f;
					component.UpdatePosition(vector);
					layer._movingSingleObjects.Add(backgroundObject);
				}
			}
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
		PlaceMovingSingleObjects(layer._movingSingleObjects, layer);
		PlaceSkylineFillObjects(layer);
	}

	private unsafe BackgroundObject InitializeBackgroundObject(BackgroundObject bgObject, BackgroundLayer layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008e: Expected Obj, but got I4
		//IL_00d0: Expected F4, but got I
		//IL_00cb: Expected native int or pointer, but got VT
		//IL_00ef: Expected F4, but got I
		//IL_00ea: Expected native int or pointer, but got VT
		//IL_0037: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		BackgroundObject backgroundObject = UnityEngine.Object.Instantiate(bgObject);
		float num = (float)layer._offsetFromLayerDefault + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+20]");
		float num2 = 0f + 0f;
		object obj2 = -layer.LayerIndex;
		float num3 = (float)obj2 * _layerSpacing;
		float num4 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+24]");
		float num5 = num4 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		backgroundObject.Initialize(layer, _transform, vector);
		layer._backgroundObjects.Add(backgroundObject);
		((EnvironmentBackground)vector).SetObjectVisibility(backgroundObject, visibility: false);
		return backgroundObject;
	}

	private unsafe void PlaceMovingSingleObjects(List<BackgroundObject> singleObjects, BackgroundLayer layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_011e: Expected Obj, but got I4
		//IL_0160: Expected F4, but got I
		//IL_015b: Expected native int or pointer, but got VT
		//IL_017f: Expected F4, but got I
		//IL_017a: Expected native int or pointer, but got VT
		//IL_01b9: Expected Obj, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		if (singleObjects._size != 0)
		{
			float value = UnityEngine.Random.value;
			Theme theme = _theme;
			Background background = theme._background;
			Background background2 = theme._background;
			float num = background.SkylineRightLimit - background2.SkylineLeftLimit;
			float num2 = value * num;
			Theme theme2 = _theme;
			Background background3 = theme2._background;
			float num3 = num2 + background3.SkylineLeftLimit;
			BackgroundObject backgroundObject = singleObjects.get_Item(layer.NextSingleObjectSpawnIndex__BackingField = UnityEngine.Random.Range(0, singleObjects._size));
			Transform transform = backgroundObject.transform;
			float num4 = num3 + (float)layer._offsetFromLayerDefault;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+20]");
			float num5 = 0f + 0f;
			object obj2 = -layer.LayerIndex;
			float num6 = (float)obj2 * _layerSpacing;
			float num7 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+24]");
			float num8 = num7 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
			BackgroundObject bo = singleObjects.get_Item(layer.NextSingleObjectSpawnIndex__BackingField);
			((EnvironmentBackground)vector).SetObjectVisibility(bo, visibility: true);
		}
	}

	private void PlaceSkylineFillObjects(BackgroundLayer layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0132: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected VT, but got Unknown
		//IL_024b: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I
		//IL_0268: Expected VT, but got Obj
		object obj = default;
		EnvironmentBackground environmentBackground = (EnvironmentBackground)(obj - 80);
		BackgroundObject[] skylineFillObjectPrefabs = layer.SkylineFillObjectPrefabs;
		if (skylineFillObjectPrefabs.Length == 0)
		{
			return;
		}
		Theme theme = _theme;
		Background background = theme._background;
		float num = background.SkylineLeftLimit;
		Theme theme2 = theme;
		while (true)
		{
			Background background2 = theme2._background;
			if (num < background2.SkylineRightLimit)
			{
				BackgroundObject[] skylineFillObjectPrefabs2 = layer.SkylineFillObjectPrefabs;
				int num2 = UnityEngine.Random.Range(0, skylineFillObjectPrefabs2.Length);
				int num3 = num2 << 2;
				object obj2 = num3 + layer.SkylineFillObjectPrefabs;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v12+10]");
				BackgroundObject backgroundObject = InitializeBackgroundObject((BackgroundObject)0, layer);
				Transform transform = backgroundObject.transform;
				float num4 = num + (float)layer._offsetFromLayerDefault;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L1 (SYBO.Subway.Level.BackgroundLayer)+20]");
				float num5 = 0f + 0f;
				object obj3 = -layer.LayerIndex;
				float num6 = (float)obj3 * _layerSpacing;
				float num7 = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L1 (SYBO.Subway.Level.BackgroundLayer)+24]");
				float num8 = num7 + 0f;
				EnvironmentBackground environmentBackground2 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+48]");
				environmentBackground2._themeManager = (ThemeManager)0;
				EnvironmentBackground environmentBackground3 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+40]");
				environmentBackground3._characterCameraTransform = (Transform)0;
				Vector3 localPosition = (Vector3)(environmentBackground + 16);
				transform.localPosition = localPosition;
				float maxBoundsSizeX = environmentBackground.GetMaxBoundsSizeX(backgroundObject._meshRenderers);
				if (maxBoundsSizeX > float.Epsilon)
				{
					float num9 = num + maxBoundsSizeX;
					if (~(backgroundObject._movable ? 1u : 0u) == 0)
					{
						MoveGameObject component = backgroundObject.GetComponent<MoveGameObject>();
						Transform transform2 = backgroundObject.transform;
						Vector3 localPosition2 = transform2.localPosition;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+38]");
						_ = 0;
						EnvironmentBackground environmentBackground4 = environmentBackground;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+38]");
						((UnityEngine.Object)environmentBackground4).m_CachedPtr = (IntPtr)0;
						EnvironmentBackground environmentBackground5 = environmentBackground;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+30]");
						environmentBackground5._waitForOneSecond = (WaitForSeconds)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+30]");
						environmentBackground = (EnvironmentBackground)0;
						component.UpdatePosition((Vector3)environmentBackground);
						layer._movingSkylineFillObjects.Add(backgroundObject);
					}
					environmentBackground.SetObjectVisibility(backgroundObject, visibility: true);
					num = num9;
					theme2 = _theme;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				string text = backgroundObject.name;
				throw new ArrayTypeMismatchException();
			}
			break;
		}
	}

	private unsafe float GetMaxBoundsSizeX(IEnumerable<MeshRenderer> meshRenderers)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected Obj, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected Obj, but got Unknown
		//IL_02c9: Expected Obj, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected VT, but got Unknown
		//IL_00ea: Expected Ref, but got VT
		//IL_0121: Invalid comparison between F4 and Obj
		//IL_0145: Expected F4, but got Obj
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = obj + 60;
		obj = obj3;
		_ = 0;
		object obj4 = default;
		object obj5;
		float num = default;
		object obj6 = default;
		object obj7 = default;
		float num2 = default;
		float num3 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj4 == null;
				obj5 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						_ = 0;
						Bounds bounds = (Bounds)(obj + 32);
						Vector3 size = ((Bounds*)bounds)->size;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
							num = num;
							if (!flag2)
							{
								num = (float)obj;
							}
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
			bool flag3 = obj6 == obj7;
			bool flag4 = !flag3;
			float result = num2;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				obj5 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = num3;
			}
			_ = 0;
			object obj8 = obj + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj5 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
		}
		object obj9 = obj5 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return num;
	}

	private int UpdateMovingSingleObjects(List<BackgroundObject> singleObjects, BackgroundLayer layer, int spawnElementIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Invalid comparison between F4 and I
		//IL_011c: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected VT, but got Unknown
		//IL_01c8: Expected Obj, but got I4
		//IL_025d: Expected Obj, but got I4
		//IL_029f: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected VT, but got Unknown
		//IL_036d: Expected Obj, but got I
		//IL_037a: Expected VT, but got Obj
		object obj = default;
		EnvironmentBackground environmentBackground = (EnvironmentBackground)(obj - 112);
		bool flag = spawnElementIndex > 0;
		int num = spawnElementIndex;
		if (!flag)
		{
			num = 0;
		}
		bool flag2 = num >= singleObjects._size;
		int result = 0;
		if (!flag2)
		{
			BackgroundObject backgroundObject = singleObjects.get_Item(num);
			Transform transform = backgroundObject.transform;
			Vector3 localPosition = transform.localPosition;
			Theme theme = _theme;
			Background background = theme._background;
			float skylineRightLimit = background.SkylineRightLimit;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+60]");
			if (!(skylineRightLimit < 0f))
			{
				result = num;
			}
			else
			{
				Transform transform2 = backgroundObject.transform;
				Theme theme2 = _theme;
				Background background2 = theme2._background;
				float num2 = background2.SkylineLeftLimit + (float)layer._offsetFromLayerDefault;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+20]");
				float num3 = 0f + 0f;
				object obj2 = -layer.LayerIndex;
				float num4 = (float)obj2 * _layerSpacing;
				float num5 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+24]");
				float num6 = num5 + 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+58]");
				_ = 0;
				EnvironmentBackground environmentBackground2 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+50]");
				environmentBackground2._waitForOneSecond = (WaitForSeconds)0;
				Vector3 localPosition2 = (Vector3)(environmentBackground + 32);
				transform2.localPosition = localPosition2;
				environmentBackground.SetObjectVisibility(backgroundObject, visibility: false);
				int num7 = num + 1;
				object obj3 = singleObjects._size - 1;
				if (num == (nint)obj3)
				{
					num7 = 0;
				}
				BackgroundObject bo = singleObjects.get_Item(num7);
				environmentBackground.SetObjectVisibility(bo, visibility: true);
				BackgroundObject backgroundObject2 = singleObjects.get_Item(num7);
				Transform transform3 = backgroundObject2.transform;
				Theme theme3 = _theme;
				Background background3 = theme3._background;
				float num8 = background3.SkylineLeftLimit + (float)layer._offsetFromLayerDefault;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+20]");
				float num9 = 0f + 0f;
				object obj4 = -layer.LayerIndex;
				float num10 = (float)obj4 * _layerSpacing;
				float num11 = num10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+24]");
				float num12 = num11 + 0f;
				EnvironmentBackground environmentBackground3 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+48]");
				environmentBackground3._themeManager = (ThemeManager)0;
				EnvironmentBackground environmentBackground4 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+40]");
				environmentBackground4._characterCameraTransform = (Transform)0;
				Vector3 localPosition3 = (Vector3)(environmentBackground + 16);
				transform3.localPosition = localPosition3;
				bool flag3 = (byte)(~(backgroundObject._movable ? 1u : 0u)) != 0;
				result = num7;
				if (!flag3)
				{
					MoveGameObject component = backgroundObject.GetComponent<MoveGameObject>();
					Transform transform4 = backgroundObject.transform;
					Vector3 localPosition4 = transform4.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+68]");
					_ = 0;
					EnvironmentBackground environmentBackground5 = environmentBackground;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+68]");
					((UnityEngine.Object)environmentBackground5).m_CachedPtr = (IntPtr)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+60]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+60]");
					environmentBackground = (EnvironmentBackground)0;
					component.UpdatePosition((Vector3)environmentBackground);
					result = num7;
				}
			}
		}
		return result;
	}

	private void UpdateSkylineFillMovement(List<BackgroundObject> bgObjects, BackgroundLayer layer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006f: Invalid comparison between F4 and I
		//IL_0182: Expected Obj, but got I4
		//IL_01c4: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected VT, but got Unknown
		//IL_027d: Expected Obj, but got I
		//IL_028d: Expected Obj, but got I
		//IL_029a: Expected VT, but got Obj
		object obj = default;
		EnvironmentBackground environmentBackground = (EnvironmentBackground)(obj - 80);
		int num = default;
		int num12 = default;
		while (num < bgObjects._size)
		{
			BackgroundObject backgroundObject = bgObjects.get_Item(num);
			Transform transform = backgroundObject.transform;
			Vector3 localPosition = transform.localPosition;
			Theme theme = _theme;
			Background background = theme._background;
			float skylineRightLimit = background.SkylineRightLimit;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+40]");
			if (skylineRightLimit < 0f)
			{
				int num2 = num + 1;
				if (num2 >= bgObjects._size)
				{
					num2 = 0;
				}
				BackgroundObject backgroundObject2 = bgObjects.get_Item(num2);
				float maxBoundsSizeX = environmentBackground.GetMaxBoundsSizeX(backgroundObject2._meshRenderers);
				float num3 = maxBoundsSizeX * 0.5f;
				float maxBoundsSizeX2 = environmentBackground.GetMaxBoundsSizeX(backgroundObject._meshRenderers);
				float num4 = maxBoundsSizeX2 * 0.5f;
				float num5 = num3 + num4;
				BackgroundObject backgroundObject3 = bgObjects.get_Item(num2);
				Transform transform2 = backgroundObject3.transform;
				Vector3 position = transform2.position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+40]");
				float num6 = 0f - num5;
				Transform transform3 = backgroundObject.transform;
				float num7 = num6 + (float)layer._offsetFromLayerDefault;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+20]");
				float num8 = 0f + 0f;
				object obj2 = -layer.LayerIndex;
				float num9 = (float)obj2 * _layerSpacing;
				float num10 = num9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [layer @ L2 (SYBO.Subway.Level.BackgroundLayer)+24]");
				float num11 = num10 + 0f;
				EnvironmentBackground environmentBackground2 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+38]");
				environmentBackground2._themeManager = (ThemeManager)0;
				EnvironmentBackground environmentBackground3 = environmentBackground;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+30]");
				environmentBackground3._characterCameraTransform = (Transform)0;
				Vector3 localPosition2 = (Vector3)(environmentBackground + 16);
				transform3.localPosition = localPosition2;
				if (~(backgroundObject._movable ? 1u : 0u) == 0)
				{
					MoveGameObject component = backgroundObject.GetComponent<MoveGameObject>();
					Transform transform4 = backgroundObject.transform;
					Vector3 localPosition3 = transform4.localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+48]");
					_ = 0;
					EnvironmentBackground environmentBackground4 = environmentBackground;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+48]");
					((UnityEngine.Object)environmentBackground4).m_CachedPtr = (IntPtr)0;
					EnvironmentBackground environmentBackground5 = environmentBackground;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+40]");
					environmentBackground5._waitForOneSecond = (WaitForSeconds)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Level.EnvironmentBackground)+40]");
					environmentBackground = (EnvironmentBackground)0;
					component.UpdatePosition((Vector3)environmentBackground);
				}
			}
			num = num12 + 1;
		}
	}

	private float GetZ(int layerIndex)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = -layerIndex;
		return (float)obj * _layerSpacing;
	}

	private void SetObjectVisibility(BackgroundObject bo, bool visibility)
	{
		if (~(bo._alwaysVisible ? 1u : 0u) != 0)
		{
			GameObject gameObject = bo.gameObject;
			gameObject.SetActive(visibility);
		}
	}

	public EnvironmentBackground()
	{
		List<BackgroundLayer> list = default;
		list._002Ector();
		_backgroundLayers = list;
		base._002Ector();
	}
}
