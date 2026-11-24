using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using SYBO.Common.Benchmarking;
using SYBO.Common.Benchmarking.Utility;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Benchmarking;
using SYBO.Subway.Benchmarking.Processors;
using SYBO.Subway.Cameras;
using SYBO.Subway.Common;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.Routes;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Level;

public class EnvironmentBackground : MonoBehaviour
{
	private sealed class _003CStart_003Ed__11(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public EnvironmentBackground _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0042: Expected I, but got Obj
				//IL_0058: Expected Obj, but got I
				//IL_0225: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Expected Obj, but got Unknown
				//IL_023c: Expected Obj, but got I4
				//IL_0256: Expected I, but got Obj
				//IL_026c: Expected Obj, but got I
				//IL_0294: Unknown result type (might be due to invalid IL or missing references)
				//IL_0299: Expected Obj, but got Unknown
				//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d0: Expected Obj, but got Unknown
				//IL_0083: Expected I, but got Obj
				//IL_011a: Unknown result type (might be due to invalid IL or missing references)
				//IL_011f: Expected Obj, but got Unknown
				//IL_00d0: Expected I, but got Obj
				//IL_0189: Expected Obj, but got I
				//IL_019d: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a2: Expected Obj, but got Unknown
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01cb: Expected Obj, but got Unknown
				//IL_01ec: Expected Obj, but got I4
				EnvironmentBackground environmentBackground = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(CharacterCamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v27 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(CharacterCamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v49 (Il2CppClass<SYBO.Subway.Cameras.CharacterCamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj2 = _003C_003E4__this + 24;
					int selectedBenchmarkIndex = SubwayBenchmarkContainer.SelectedBenchmarkIndex;
					GameObject gameObject = ((Component)selectedBenchmarkIndex).gameObject;
					obj2 = gameObject;
					nint num3 = (nint)typeof(ThemeManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v34 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(ThemeManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v45 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = _003C_003E4__this + 32;
					GameStateMachine instance = GameStateMachine.Instance;
					obj4 = instance;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					Action<Theme> action = default;
					object obj5 = action + 16;
					obj5 = _003C_003E4__this;
					environmentBackground._themeManager.ThemeChanged -= action;
					object obj6 = _003C_003E4__this + 36;
					ThemeManager themeManager = environmentBackground._themeManager;
					obj6 = themeManager._theme;
					_003C_003E4__this.ExecuteOnEachBackgroundLayer((Action<BackgroundLayer>)(object)environmentBackground._theme);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				BackgroundLayer backgroundLayer = default;
				backgroundLayer.Name = (string)num6;
				backgroundLayer._dontRandomizeSingleObjectSpawnPosition = false;
				object obj7 = backgroundLayer + 16;
				obj7 = _003C_003E4__this;
				_003C_003E4__this.UpdateLayer(backgroundLayer);
				object obj8 = this + 12;
				obj8 = environmentBackground._waitForOneSecond;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private List<BackgroundLayer> _backgroundLayers;

	private List<BackgroundCulling> _backgroundCulling;

	private Material _cullingMaterial;

	private Transform _characterCameraTransform;

	private Transform _transform;

	private ThemeManager _themeManager;

	private Theme _theme;

	private WaitForSeconds _waitForOneSecond;

	private float _layerSpacing;

	private EnvironmentType _lastSpawnedEnvironmentType;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void OnDestroy()
	{
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_00f2: Expected I, but got Obj
		object obj = this + 28;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1f;
		object obj2 = this + 40;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr;
		obj4.method = (nint)__ldftn(EnvironmentBackground.RouteChunk_OnEnvironmentSegmentSpawned);
		object obj5 = obj4 + 16;
		obj5 = this;
		Delegate obj6 = ((Delegate)RouteChunk.OnEnvironmentSegmentSpawned).CombineImpl(obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		Action<EnvironmentKind, int, Route> onEnvironmentSegmentSpawned = default;
		RouteChunk.OnEnvironmentSegmentSpawned = onEnvironmentSegmentSpawned;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr2;
		((Delegate)action).method = (nint)__ldftn(EnvironmentBackground.Game_OnMenuScreenShown);
		object obj7 = action + 16;
		obj7 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v27 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v32 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnMenuScreenShown -= action;
	}

	private IEnumerator Start()
	{
		return (IEnumerator)_backgroundLayers;
	}

	private void ThemeManager_ThemeChanged(Theme theme)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = theme ^ -1;
		List<BackgroundLayer> backgroundLayers = (List<BackgroundLayer>)((object)_backgroundLayers & obj);
		_backgroundLayers = backgroundLayers;
	}

	private void ResetBackground(Theme theme)
	{
		ExecuteOnEachBackgroundLayer((Action<BackgroundLayer>)(object)theme);
	}

	private void LateUpdate()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_themeManager).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			bool flag = default;
			object obj2 = (flag ? 1 : 0) + 16;
			obj2 = this;
			_themeManager.DistortionYFlipped = flag;
		}
	}

	private unsafe void ExecuteOnEachBackgroundLayer(Action<BackgroundLayer> actionToExecute)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0527: Expected Obj, but got I4
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0559: Expected Obj, but got I
		//IL_056b: Expected F4, but got I
		//IL_0588: Expected Obj, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0612: Expected Obj, but got I
		//IL_0622: Expected Obj, but got I
		//IL_0177: Expected Obj, but got I4
		//IL_0661: Expected Obj, but got I
		//IL_0671: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_0047: Expected Obj, but got I
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected VT, but got Unknown
		//IL_018c: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_00b9: Expected I, but got Obj
		//IL_0330: Expected Obj, but got I4
		//IL_0347: Expected Obj, but got F4
		//IL_0231: Expected I, but got Obj
		//IL_0108: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I
		//IL_02e5: Expected F4, but got Obj
		//IL_02e0: Expected native int or pointer, but got VT
		//IL_02fa: Expected F4, but got I
		//IL_02f5: Expected native int or pointer, but got VT
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected Obj, but got Unknown
		//IL_03de: Expected Obj, but got I4
		//IL_072d: Expected Obj, but got I
		//IL_0741: Unknown result type (might be due to invalid IL or missing references)
		//IL_0746: Expected Obj, but got Unknown
		//IL_0466: Expected Obj, but got I
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11+14]");
		_layerSpacing = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		BackgroundLayer backgroundLayer = default;
		backgroundLayer.Name = (string)num;
		backgroundLayer._dontRandomizeSingleObjectSpawnPosition = false;
		object obj6 = backgroundLayer + 16;
		obj6 = this;
		UpdateLayer(backgroundLayer);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		object obj7 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v24+18]");
			object obj9 = 0;
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v25+C]");
			if ((nint)obj10 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v138+18]");
			object obj12 = (nint)0 + (nint)16;
			object obj13 = obj7 << 2;
			object obj14 = obj12 + obj13;
			object obj15 = obj14;
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v144 (Il2CppClass<DeviceInfo>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num3 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v157 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v149 (System.Int32)+8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v142+2C]");
			if (num4 >= 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v118+18]");
				object obj18 = (nint)0 + (nint)16;
				object obj19 = obj7 << 2;
				object obj20 = obj18 + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			}
			object obj21 = obj7 + 1;
			obj7 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		object obj22 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S1_v31+44]");
			object obj24 = 0;
			object obj25 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v32+C]");
			if ((nint)obj25 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v103+44]");
			object obj27 = (nint)0 + (nint)16;
			object obj28 = obj22 << 2;
			object obj29 = obj27 + obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			object obj30 = obj22 + 1;
			obj22 = obj30;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v98 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector4 vector = (Vector4)(obj2 + 40);
		if (_cullingMaterial != null)
		{
			int num7 = Shader.PropertyToID("Hidden/Background Culling");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Material material = default;
			material._002Ector((Material)num7);
			object obj32 = this + 20;
			obj32 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [actionToExecute @ L1 (System.Action`1<SYBO.Subway.Level.BackgroundLayer>)+C]");
			object obj33 = (nint)0 + (nint)72;
			obj2 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S2_v29+8]");
			_ = 0;
			((Vector4*)(nint)vector)->x = (float)obj2;
			Vector4 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Vector4*)(nint)vector2)->z = 0f;
			_cullingMaterial.SetVector("_Color", vector);
		}
		List<BackgroundLayer> backgroundLayers = _backgroundLayers;
		object obj34 = backgroundLayers._size + 1005;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = vector.x;
		_ = vector.z;
		object obj35 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj35 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj36 = obj4 + 4;
		object obj37 = obj36 + 1;
		obj36 = obj37;
		object obj38 = obj37 << 2;
		object obj39 = obj4 + obj38;
		obj39 = 291;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj40 = (nint)0 << 2;
			object obj41 = obj4 + obj40;
			if ((nint)obj41 == 291)
			{
				object obj42 = obj4 + 4;
				if ((nint)obj42 > -1)
				{
					object obj43 = obj42 + -1;
					obj42 = obj43;
				}
				goto IL_0710;
			}
		}
		object obj44 = default;
		if (obj44 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0710;
		IL_0710:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		BackgroundLayer backgroundLayer2 = default;
		backgroundLayer2.Name = (string)num8;
		backgroundLayer2._dontRandomizeSingleObjectSpawnPosition = false;
		object obj45 = backgroundLayer2 + 16;
		obj45 = this;
		UpdateLayer(backgroundLayer2);
	}

	private void UpdateLayer(BackgroundLayer layer)
	{
		int num = default;
		int num2 = default;
		while (true)
		{
			List<BackgroundLayer> backgroundLayers = _backgroundLayers;
			if (num < backgroundLayers._size)
			{
				BackgroundLayer backgroundLayer = _backgroundLayers.get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
				num = num2 + 1;
				continue;
			}
			break;
		}
	}

	private unsafe void ClearData(BackgroundLayer layer)
	{
		//IL_0040: Expected I4, but got Obj
		bool flag = ((TransitionConfig)(object)this).TryGetStartPrefab((EnvironmentKind)(object)layer._movingSingleObjects, (SyboRandom)(object)layer, out *(Transform*)layer.NextSingleObjectSpawnIndex__BackingField);
		layer.NextSingleObjectSpawnIndex__BackingField = (flag ? 1 : 0);
		SetObjectVisibility((BackgroundObject)(object)layer._movingSkylineFillObjects, (byte)(int)layer != 0);
	}

	private void PrepareLayer(BackgroundLayer layer)
	{
		//IL_003b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		//IL_007c: Expected I, but got Obj
		int num = 0;
		while (true)
		{
			List<BackgroundObject> backgroundObjects = layer._backgroundObjects;
			if (num >= backgroundObjects._size)
			{
				break;
			}
			BackgroundObject backgroundObject = layer._backgroundObjects.get_Item(num);
			string obj = backgroundObject.tag;
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj);
			int num4 = num + 1;
			num = num4;
		}
		throw new IndexOutOfRangeException();
	}

	private BackgroundObject InitializeBackgroundObject(BackgroundObject bgObject, BackgroundLayer layer)
	{
		//IL_001c: Expected I4, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		if (layer.SingleObjectPrefabs != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			BackgroundObject backgroundObject = default;
			stringBuilder.Length = (int)backgroundObject;
			StringBuilder stringBuilder2 = stringBuilder.AppendLine("?");
			int num = 0;
			while (num < (nint)layer.SingleObjectPrefabs)
			{
				GoogleSheetsProcessor.ParameterContainer parameterContainer = ((List<GoogleSheetsProcessor.ParameterContainer>)(object)layer).get_Item(num);
				StringBuilder stringBuilder3 = stringBuilder.AppendLine(parameterContainer.Key__BackingField);
				StringBuilder stringBuilder4 = stringBuilder.AppendLine("=");
				StringBuilder stringBuilder5 = stringBuilder.AppendLine(parameterContainer.Value__BackingField);
				object obj = layer.SingleObjectPrefabs - 1;
				if (num < (nint)obj)
				{
					StringBuilder stringBuilder6 = stringBuilder.AppendLine("&");
				}
				int num2 = num + 1;
				num = num2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		BackgroundObject result = default;
		return result;
	}

	private void PlaceMovingSingleObjects(List<BackgroundObject> singleObjects, BackgroundLayer layer)
	{
		//IL_0196: Expected Obj, but got I4
		//IL_0196: Expected Obj, but got I4
		IEnumerator enumerator = ((GoogleSheetsProcessor)3).UploadReportToGoogleSheets((IBenchmark)10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FirstMonobehaviour firstMonobehaviour = default;
		firstMonobehaviour.Awake();
		throw new ArrayTypeMismatchException();
	}

	private void PlaceSkylineFillObjects(BackgroundLayer layer)
	{
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_03ee: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01e2: Expected I, but got Obj
		//IL_01f8: Expected Obj, but got I
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected Obj, but got Unknown
		//IL_0223: Expected I, but got Obj
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_029e: Expected I4, but got Obj
		//IL_029e: Expected I4, but got Obj
		//IL_02f4: Expected VT, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)layer.MaterialInstance__BackingField).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(layer.MaterialInstance__BackingField);
			object obj3 = layer + 84;
			obj3 = 0;
		}
		Transform transform = default;
		Texture texture = (Texture)(transform + 16);
		if (~(layer._useCommonMaterial ? 1u : 0u) == 0)
		{
			ThemeManager themeManager = _themeManager;
			Theme theme = themeManager._theme;
			Background background = theme._background;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Material material = default;
			material._002Ector((Material)(object)background.LayerCommonMaterialShader);
			object obj4 = layer + 84;
			obj4 = material;
			object obj5 = layer + 52;
			transform = (Transform)obj5;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v27+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			texture = (Texture)(object)transform;
			((UnityEngine.Object)texture).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
			layer.MaterialInstance__BackingField.mainTexture = texture;
		}
		object obj6 = 0;
		while (true)
		{
			BackgroundObject[] singleObjectPrefabs = layer.SingleObjectPrefabs;
			if ((nint)obj6 >= singleObjectPrefabs.Length)
			{
				break;
			}
			object obj7 = layer.SingleObjectPrefabs + 16;
			object obj8 = obj6 << 2;
			object obj9 = obj7 + obj8;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj9 != null))
			{
				object obj11 = layer.SingleObjectPrefabs + 16;
				object obj12 = obj6 << 2;
				object obj13 = obj11 + obj12;
				Transform transform3 = ((LogicAssetsManager)this).SpawnEnvironmentSegmentLogic((EnvironmentType)obj13, (EnvironmentSequence)layer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v35 (UnityEngine.Transform)+D]");
				if ((nint)0 != 0)
				{
					MoveGameObject component = transform3.GetComponent<MoveGameObject>();
					GameObject gameObject = transform3.gameObject;
					transform.localPosition = (Vector3)gameObject;
					texture = (Texture)(object)transform;
					((UnityEngine.Object)texture).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
					((RandomizeOffset)(object)component).SetRandomOffsetsData((RandomizeOffset.RandomOffsetsData)(object)texture);
					layer._movingSingleObjects.Add((BackgroundObject)(object)transform3);
				}
			}
			object obj14 = obj6 + 1;
			obj6 = obj14;
		}
		UpdateSkylineFillMovement(layer._movingSingleObjects, layer);
		Vector3 trainModelPosition = ((MovingTrain)(object)layer).GetTrainModelPosition();
	}

	private float GetMaxBoundsSizeX(IEnumerable<MeshRenderer> meshRenderers)
	{
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_00e0: Expected VT, but got Obj
		//IL_00e0: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v17 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		GameObject gameObject = ((Component)meshRenderers).gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
		object obj2 = meshRenderers - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		return 0f + (float)obj2;
	}

	private int UpdateMovingSingleObjects(List<BackgroundObject> singleObjects, BackgroundLayer layer, int spawnElementIndex)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ad: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PoolManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PrefabPool prefabPool = PoolManager.GetPrefabPool((Transform)(object)singleObjects);
		return (int)((Component)(object)prefabPool).tag;
	}

	private unsafe void UpdateSkylineFillMovement(List<BackgroundObject> bgObjects, BackgroundLayer layer)
	{
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected VT, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected VT, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_00f7: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got F4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected Obj, but got Unknown
		//IL_0141: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00a3: Expected F4, but got Obj
		//IL_009e: Expected native int or pointer, but got VT
		//IL_00b8: Expected F4, but got I
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_02b4: Expected F4, but got Obj
		//IL_02af: Expected native int or pointer, but got VT
		//IL_02c9: Expected F4, but got I
		//IL_02c4: Expected native int or pointer, but got VT
		//IL_02d6: Expected F4, but got Obj
		//IL_02d1: Expected native int or pointer, but got VT
		//IL_02eb: Expected F4, but got I
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_0309: Expected F4, but got Obj
		//IL_0304: Expected native int or pointer, but got VT
		//IL_031e: Expected F4, but got I
		//IL_0319: Expected native int or pointer, but got VT
		//IL_0327: Expected Obj, but got VT
		//IL_01d0: Expected Obj, but got I4
		//IL_0182: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		if (bgObjects._size == 0)
		{
			return;
		}
		float time = Time.time;
		Theme theme = _theme;
		Background background = theme._background;
		Theme theme2 = _theme;
		Background background2 = theme2._background;
		float num = background.SkylineRightLimit - background2.SkylineLeftLimit;
		float num2 = time * num;
		bool flag = (byte)(~(layer._dontRandomizeSingleObjectSpawnPosition ? 1u : 0u)) != 0;
		float num3 = num2;
		if (!flag)
		{
			object obj4 = layer + 32;
			((Vector3*)(nint)vector)->x = (float)obj4;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v53+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			num3 = vector.x;
		}
		Theme theme3 = _theme;
		Background background3 = theme3._background;
		float num4 = num3 + background3.SkylineLeftLimit;
		int num5 = UnityEngine.Random.RandomRangeInt(0, bgObjects._size);
		layer.NextSingleObjectSpawnIndex__BackingField = num5;
		BackgroundObject backgroundObject = bgObjects.get_Item(layer.NextSingleObjectSpawnIndex__BackingField);
		GameObject gameObject = backgroundObject.gameObject;
		object obj5 = -layer.LayerIndex;
		float num6 = (float)obj5 * _layerSpacing;
		obj2 = 0;
		_ = 0;
		obj2 = num4;
		_ = 0f;
		object obj6 = layer + 32;
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S2_v23+8]");
		_ = 0;
		nint num7 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector).eulerAngles;
		BackgroundObject sender = bgObjects.get_Item(layer.NextSingleObjectSpawnIndex__BackingField);
		((CheckpointTrigger)null).Handler_OnCharacterEnter((object)sender, (EventArgs)1);
	}

	private float GetZ(int layerIndex)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected Obj, but got Unknown
		//IL_02fd: Expected Obj, but got I4
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0193: Expected Obj, but got I4
		//IL_03ec: Expected F4, but got Obj
		//IL_022e: Expected Obj, but got I
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_00ce: Expected I, but got Obj
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 48;
		obj4 = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 40;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v101 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v110 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
			}
		}
		object obj8 = obj5 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj5 + obj10;
		obj11 = 68;
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj5 + obj13;
			if ((nint)obj14 == 68)
			{
				object obj15 = obj5 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_03e7;
			}
		}
		object obj17 = default;
		if (obj17 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03e7;
		IL_03e7:
		return (float)obj2;
	}

	private unsafe void SetObjectVisibility(BackgroundObject bo, bool visibility)
	{
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected VT, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected Obj, but got Unknown
		//IL_0035: Expected VT, but got Obj
		//IL_0059: Invalid comparison between Obj and F4
		//IL_031e: Expected I4, but got Obj
		//IL_0341: Expected I4, but got Obj
		//IL_0125: Expected VT, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_0176: Expected Obj, but got I4
		//IL_0184: Expected Obj, but got F4
		//IL_019d: Expected Obj, but got I4
		//IL_01c0: Expected I, but got Obj
		//IL_01d6: Expected Obj, but got I
		//IL_0357: Expected F4, but got Obj
		//IL_0352: Expected native int or pointer, but got VT
		//IL_036c: Expected F4, but got I
		//IL_0367: Expected native int or pointer, but got VT
		//IL_0396: Expected VT, but got Obj
		//IL_0201: Expected I, but got Obj
		//IL_026c: Expected VT, but got Obj
		//IL_026c: Expected Obj, but got VT
		//IL_0279: Expected Obj, but got F4
		//IL_028b: Expected I, but got F4
		object obj = default;
		Transform transform = (Transform)(obj + 60);
		Vector3 vector = (Vector3)(obj + 48);
		Transform transform2 = (Transform)(obj + 36);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		int num = default;
		int num10 = default;
		while (num < (bo._alwaysVisible ? 1 : 0))
		{
			BackgroundObject backgroundObject = ((List<BackgroundObject>)(object)bo).get_Item(num);
			GameObject gameObject = backgroundObject.gameObject;
			transform.localPosition = (Vector3)gameObject;
			Theme theme = _theme;
			Background background = theme._background;
			if (System.Runtime.CompilerServices.Unsafe.As<Transform, UIntPtr>(ref transform) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)background.SkylineRightLimit))
			{
				int num2 = num + 1;
				int index;
				if (num2 < (bo._alwaysVisible ? 1 : 0))
				{
					index = num2;
				}
				else
				{
					index = 0;
					num2 = 0;
				}
				BackgroundObject backgroundObject2 = ((List<BackgroundObject>)(object)bo).get_Item(num2);
				float z = ((EnvironmentBackground)null).GetZ((int)backgroundObject2._meshRenderers);
				float num3 = z * 0.5f;
				float z2 = ((EnvironmentBackground)null).GetZ((int)backgroundObject._meshRenderers);
				float num4 = z2 * 0.5f;
				float num5 = num3 + num4;
				BackgroundObject backgroundObject3 = ((List<BackgroundObject>)(object)bo).get_Item(index);
				GameObject gameObject2 = backgroundObject3.gameObject;
				transform2.position = (Vector3)gameObject2;
				float num6 = (float)transform2 - num5;
				GameObject gameObject3 = backgroundObject.gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [visibility @ L2 (System.Boolean)+1C]");
				object obj4 = -0;
				float num7 = (float)obj4 * _layerSpacing;
				obj2 = 0;
				_ = 0;
				obj2 = num6;
				_ = 0f;
				object obj5 = (visibility ? 1 : 0) + 32;
				obj3 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S2_v29+8]");
				_ = 0;
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num9 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				transform = (Transform)obj3;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 vector3 = vector - (Vector3)transform;
				transform = (Transform)obj;
				Transform transform4 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				Vector3 eulerAngles = transform.eulerAngles;
				if (~(backgroundObject._movable ? 1u : 0u) == 0)
				{
					MoveGameObject component = backgroundObject.GetComponent<MoveGameObject>();
					GameObject gameObject4 = backgroundObject.gameObject;
					((Transform)vector).localPosition = (Vector3)gameObject4;
					transform = (Transform)vector.x;
					((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)vector.z;
					((RandomizeOffset)(object)component).SetRandomOffsetsData((RandomizeOffset.RandomOffsetsData)(object)transform);
				}
			}
			num = num10 + 1;
		}
	}

	private void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind kind, int gamePositionZ, Route route)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_013a: Expected I, but got Obj
		//IL_0150: Expected Obj, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e0: Expected Obj, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I4
		object obj = this + 8;
		obj = string.Empty;
		object obj2 = this + 12;
		obj2 = string.Empty;
		object obj3 = this + 16;
		obj3 = string.Empty;
		object obj4 = this + 20;
		obj4 = string.Empty;
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v42 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 16;
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		object obj7 = ((IConvertible)bundleIdentifier).ToType((Type)(object)"_", (IFormatProvider)kind);
		obj6 = obj7;
		object obj8 = this + 8;
		obj8 = gamePositionZ;
		object obj9 = this + 12;
		obj9 = route;
		bool flag = ((string)(object)kind).EndsWith("memory");
		object obj10 = this + 20;
		object obj11 = ((!flag) ? "template" : "template_memory");
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Stream stream = default;
		UnityEngine.ManagedStreamHelpers.ValidateLoadFromStream(stream);
		UnityEngine.Object.CheckNullArgument((object)stream, (string)61);
		object obj12 = this + 24;
		GoogleSheetsProcessor.GoogleSheetsProcessorUpdater googleSheetsProcessorUpdater = ((GameObject)(object)stream).AddComponent<GoogleSheetsProcessor.GoogleSheetsProcessorUpdater>();
		obj12 = googleSheetsProcessorUpdater;
		_transform = null;
		AssetTagThemeUsage themeUsage = ((AssetTag)this).ThemeUsage;
		Coroutine coroutine = ((MonoBehaviour)(object)_characterCameraTransform).StartCoroutine_Auto((IEnumerator)themeUsage);
	}

	private void Game_OnMenuScreenShown()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_028a: Expected VT, but got Obj
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02b0: Expected Obj, but got F4
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_0316: Expected I, but got Obj
		//IL_032c: Expected Obj, but got I
		//IL_0361: Expected VT, but got Obj
		//IL_0361: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 40;
		obj4 = obj;
		_ = -1;
		Transform transform = (Transform)(obj2 + 28);
		transform.position = (Vector3)_characterCameraTransform;
		object obj5 = obj2 + 16;
		obj5 = 0;
		_ = 0;
		obj5 = 0f;
		_ = 0f;
		float num = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr + 1000f;
		Transform transform2 = (Transform)(obj2 - -64);
		transform2 = (Transform)obj5;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v15+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localPosition = transform2.localPosition;
		nint num2 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v20 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v88 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)_transform);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23");
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 122;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 122)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				return;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public EnvironmentBackground()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 51)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
