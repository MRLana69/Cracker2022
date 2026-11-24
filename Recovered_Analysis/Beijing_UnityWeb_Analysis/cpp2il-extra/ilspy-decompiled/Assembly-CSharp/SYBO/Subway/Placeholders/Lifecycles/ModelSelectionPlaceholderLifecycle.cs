using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Components.Utilities;
using SYBO.Subway.Cameras;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Placeholders.PrefabProviders;
using SYBO.Subway.Routes.Builders.Worker;
using SYBO.Subway.Themes;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Placeholders.Lifecycles;

public class ModelSelectionPlaceholderLifecycle : SelectionPlaceholderLifecycle
{
	private sealed class _003CCombineMeshesAsync_003Ed__12(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ModelSelectionPlaceholderLifecycle _003C_003E4__this;

		public IList<CombineableMesh> combineableMeshes;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Expected Obj, but got Unknown
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_0098: Expected Obj, but got Unknown
				//IL_00ce: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				_ = 1;
				IList<ObjectModelInfo> meshInfos = MeshUtil.GetMeshInfos((IList<MeshRenderer>)combineableMeshes);
				string tag = _003C_003E4__this.tag;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num = 0;
				_ = 0;
				Action<ModelInfo[]> action = default;
				object obj = action + 16;
				obj = _003C_003E4__this;
				object obj2 = this + 12;
				IEnumerator enumerator = MeshUtil.CombineMeshesAsync((GameObject)(object)tag, meshInfos, action);
				obj2 = enumerator;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001e: Expected Obj, but got I4
			//IL_00c1: Expected Obj, but got I4
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected Obj, but got Unknown
			//IL_00ac: Expected Obj, but got I4
			if (((RouteBuilderWorker.WorkWrapper)this).Work())
			{
				return true;
			}
			IEnumerator enumerator = ((Stack<IEnumerator>)_003C_003E1__state).Peek();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
				object obj2 = default;
				if (obj2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
					IEnumerator item = default;
					((Stack<IEnumerator>)_003C_003E1__state).Push(item);
				}
			}
			else
			{
				IEnumerator enumerator2 = ((Stack<IEnumerator>)_003C_003E1__state).Pop();
			}
			IList<CombineableMesh> list = (IList<CombineableMesh>)(combineableMeshes + 1);
			combineableMeshes = list;
			int num = _003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v18 (System.Int32)+C]");
			return (nint)0 == 0;
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

	private bool _combineModelsInstantly;

	private MeshContainer _meshContainer;

	private MeshFilter _meshFilter;

	private MeshRenderer _meshRenderer;

	private bool _usingCombinedMesh;

	private CombineableMeshGroup _spawnedCombineableMeshGroup;

	private bool _isCombiningMeshes;

	private IEnumerator _meshCombiningRoutine;

	private bool _spawnedOnceOnStart;

	protected override void Initialize()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Transform> list = default;
		list._002Ector(1);
		object obj = this + 20;
		obj = list;
		CancelInvoke();
	}

	protected override void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false, bool spawningOnceOnStart = false, bool locatedInIntro = false)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		//IL_002b: Expected Obj, but got I4
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_00a8: Expected I, but got Obj
		//IL_00fd: Expected VT, but got I4
		//IL_00fd: Expected VT, but got I4
		//IL_00fd: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if (!spawnInChildrenLifecycles)
		{
			return;
		}
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>(true);
		object obj = componentsInParent + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = componentsInParent + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj5 != this))
			{
				((CharacterCamera)obj5).SetCameraDataForcefully((CameraData)1, (Vector3)spawningOnceOnStart, (Quaternion)locatedInIntro);
			}
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	private void CombineMeshes(IList<CombineableMesh> combineableMeshes)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 24;
		obj = combineableMeshes;
	}

	private unsafe IEnumerator CombineMeshesAsync(IList<CombineableMesh> combineableMeshes)
	{
		//IL_00f1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0120: Expected I4, but got Obj
		//IL_0133: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		ref GameObject reference = ref *(GameObject*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		PlaceholderPrefabProviderBase prefabProvider = _prefabProvider;
		string genericPrefab = ((Component)combineableMeshes).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase)+20]");
		bool flag = ((Theme)0).TryGetSynchronizedThemeAssetFromGeneric((GameObject)(object)genericPrefab, out reference);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)(object)reference).FindKernel((string)null);
		bool flag2 = num3 == 0;
		int num4 = (int)combineableMeshes;
		if (!flag2)
		{
			int layer = reference.layer;
			num4 = layer;
		}
		return (IEnumerator)num4;
	}

	private void UpdateToCombinedMesh(ModelInfo combinedMeshes)
	{
		//IL_0029: Expected I4, but got Obj
		IList<ObjectModelInfo> meshInfos = MeshUtil.GetMeshInfos((IList<MeshRenderer>)combinedMeshes);
		string parentGO = tag;
		ModelInfo other = MeshUtil.CombineMeshes((GameObject)(object)parentGO, (byte)(int)meshInfos != 0);
		((PickupData)(object)this)._002Ector((PickupData)(object)other);
	}

	protected override void GetSpawnedObjects(List<Selector> selectors)
	{
		//IL_001d: Expected I4, but got Obj
		//IL_0038: Expected I4, but got Obj
		if (selectors != null)
		{
			UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string text = string.ConcatArray((string[])(object)values, (int)"_combined");
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)selectors._items, (byte)(int)text != 0);
			((SkinnedMeshRenderer)(object)_meshFilter).sharedMesh = (Mesh)(object)selectors._items;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
			_meshRenderer.shadowCastingMode = ShadowCastingMode.On;
			_usingCombinedMesh = true;
		}
		else
		{
			SDebug.LogFormat("Did not receive a combined mesh. No child meshes to combine", (object[])(object)this);
		}
	}

	private void ReceiveCombinedMeshAndDespawn(ModelInfo combinedMeshes)
	{
	}

	protected unsafe override void DespawnInstances()
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected I, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Expected VT, but got Obj
		//IL_0153: Expected Obj, but got VT
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_017d: Expected I, but got Obj
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_00d3: Expected I, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_0071: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		Start();
		object obj3 = this + 48;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj3 = val;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			return;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v22 (Il2CppClass<System.Type>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v34 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(MeshFilter);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		object obj5 = this + 52;
		Type type = Type.internal_from_handle((IntPtr)num);
		Component component = SYBO.Common.Utilities.GameObjectUtil.AddComponentIfMissing((GameObject)(object)this, type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj5 = obj6;
		obj = typeof(MeshRenderer);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		object obj7 = this + 56;
		Type type2 = Type.internal_from_handle((IntPtr)num);
		Component component2 = SYBO.Common.Utilities.GameObjectUtil.AddComponentIfMissing((GameObject)(object)this, type2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		object obj8 = default;
		obj7 = obj8;
	}

	private void OnValidate()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_0047: Expected VT, but got Obj
		//IL_005b: Expected VT, but got Obj
		//IL_005b: Expected Obj, but got VT
		if (~(_isCombiningMeshes ? 1u : 0u) == 0)
		{
			object cmp = this - -64;
			SYBO.Common.Utilities.GameObjectUtil.SortTransformChildren((Transform)(object)_meshContainer, (Comparison<Transform>)cmp);
			_isCombiningMeshes = false;
			object obj = this - -64;
			obj = 0;
			_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
			((AnimationInitializer)val).InitializeAnimation((AnimationInitializer.Config)_meshCombiningRoutine);
		}
		if (~(_usingCombinedMesh ? 1u : 0u) == 0 && !_spawnedOnceOnStart)
		{
			((SkinnedMeshRenderer)(object)_meshFilter).sharedMesh = null;
			_meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			_usingCombinedMesh = false;
		}
		else
		{
			_placeholder.Activate();
		}
	}

	public ModelSelectionPlaceholderLifecycle()
	{
		//IL_0411: Expected I, but got Obj
		//IL_0427: Expected Obj, but got I
		//IL_044e: Expected Obj, but got VT
		//IL_00f8: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0486: Expected I4, but got Obj
		//IL_0115: Expected I, but got Obj
		//IL_012b: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0156: Expected I, but got Obj
		//IL_0521: Expected Obj, but got VT
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected Obj, but got Unknown
		//IL_031f: Expected I, but got Obj
		//IL_0379: Expected I, but got Obj
		//IL_038f: Expected Obj, but got I
		//IL_0559: Expected I4, but got Obj
		//IL_056a: Expected Obj, but got VT
		//IL_03ba: Expected I, but got Obj
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v82 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)componentInChildren != null)
		{
			GameObject components = gameObject;
			nint num3 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v68 (Il2CppClass<Utils>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v75 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string longNameList = Utils.GetLongNameList((Component[])(object)components);
			string msg = string.ConcatArray((string[])(object)"ModelSelectionPlaceholderLifecycle: Missing a PlaceholderPrefabProvider at ", (int)longNameList);
			SDebug.LogFormat(msg, (object[])(object)this);
			return;
		}
		object obj3 = 0;
		object obj4 = default;
		UnityEngine.Object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v72 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			_0021_00210 componentInChildren2 = (_0021_00210)((Component)obj6).GetComponentInChildren<T>();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((UnityEngine.Object)componentInChildren2 != null)
			{
				GameObject components2 = ((Component)obj6).gameObject;
				nint num9 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S1_v26 (Il2CppClass<Utils>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num10 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S1_v33 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string longNameList2 = Utils.GetLongNameList((Component[])(object)components2);
				string msg2 = string.ConcatArray((string[])(object)"ModelSelectionPlaceholderLifecycle: Model prefab missing CombineableMeshGroup component ", (int)longNameList2);
				SDebug.LogFormat(msg2, (object[])componentInChildren);
			}
			object obj9 = obj3 + 1;
			obj3 = obj9;
		}
	}
}
