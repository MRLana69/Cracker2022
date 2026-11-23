using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Common.Visuals;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders.PrefabProviders;
using UnityEngine;

namespace SYBO.Subway.Placeholders.Lifecycles;

public class ModelSelectionPlaceholderLifecycle : SelectionPlaceholderLifecycle
{
	private sealed class _003CCombineMeshesAsync_003Ed__12(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ModelSelectionPlaceholderLifecycle _003C_003E4__this;

		public IList<CombineableMesh> combineableMeshes;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				bool flag = _003C_003E1__state == 1;
				int num = -1;
				bool result = false;
				if (!flag)
				{
					result = false;
				}
				else
				{
					_003C_003E1__state = num;
				}
				return result;
			}
			_003C_003E1__state = -1;
			_ = 1;
			IList<ObjectModelInfo> meshInfos = MeshUtil.GetMeshInfos(combineableMeshes);
			GameObject gameObject = _003C_003E4__this.gameObject;
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
		//IL_00c5: Expected VT, but got Obj
		//IL_00cf: Expected Obj, but got VT
		//IL_002d: Expected VT, but got Obj
		//IL_0076: Expected VT, but got Obj
		base.Initialize();
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_meshContainer = (MeshContainer)val;
		if (Application.isPlaying)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshFilter));
			Component component = GameObjectUtil.AddComponentIfMissing(this, typeFromHandle);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			MeshFilter meshFilter = default;
			_meshFilter = meshFilter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshRenderer));
			Component component2 = GameObjectUtil.AddComponentIfMissing(this, typeFromHandle2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			MeshRenderer meshRenderer = default;
			_meshRenderer = meshRenderer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		}
	}

	protected unsafe override void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider, bool spawnInChildrenLifecycles = false, bool spawningOnceOnStart = false, bool locatedInIntro = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0039: Expected VT, but got Obj
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Ref, but got Unknown
		//IL_0146: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I
		//IL_02bc: Expected VT, but got Obj
		//IL_02cb: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		List<Transform> prefabsToSpawn = prefabProvider._prefabsToSpawn;
		if (prefabsToSpawn._size >= 2)
		{
			return;
		}
		Transform transform = prefabsToSpawn.get_Item(0);
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CombineableMeshGroup));
		Component component = transform.GetComponent(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		CombineableMeshGroup spawnedCombineableMeshGroup = default;
		_spawnedCombineableMeshGroup = spawnedCombineableMeshGroup;
		object obj3 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		if (_spawnedCombineableMeshGroup == null)
		{
			base.SpawnInstances(prefabProvider, spawnInChildrenLifecycles, spawningOnceOnStart, locatedInIntro);
			return;
		}
		if ((UnityEngine.Object)obj3 != null)
		{
			if (_meshContainer.TryGetGroupMesh(_spawnedCombineableMeshGroup, out *(ModelInfo*)(obj + 12)))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj4 = 0;
				MeshFilter meshFilter = _meshFilter;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v34+8]");
				meshFilter.mesh = (Mesh)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
				_meshRenderer.enabled = true;
				_usingCombinedMesh = true;
			}
			else
			{
				if (_meshContainer.IsMeshGroupCombineInProgress(_spawnedCombineableMeshGroup))
				{
					throw new ArgumentException();
				}
				base.SpawnInstances(prefabProvider, spawnInChildrenLifecycles: true, spawningOnceOnStart, locatedInIntro);
				CombineableMesh[] componentsInChildren = GetComponentsInChildren<CombineableMesh>(includeInactive: true);
				if (componentsInChildren.Length != 0)
				{
					if (spawningOnceOnStart || ~(_combineModelsInstantly ? 1u : 0u) == 0)
					{
						CombineMeshes(componentsInChildren);
					}
					else
					{
						_meshContainer.NotifyMeshGroupCombineInProgress(_spawnedCombineableMeshGroup);
						IEnumerator meshCombiningRoutine = CombineMeshesAsync(componentsInChildren);
						_meshCombiningRoutine = meshCombiningRoutine;
						_00210 val = (_00210)SingletonMonobehavior<>.Instance;
						((WorkLoadQueue)val).EnqueueWork(_meshCombiningRoutine);
					}
				}
			}
		}
		_spawnedOnceOnStart = spawningOnceOnStart;
	}

	private void CombineMeshes(IList<CombineableMesh> combineableMeshes)
	{
		IList<ObjectModelInfo> meshInfos = MeshUtil.GetMeshInfos(combineableMeshes);
		GameObject parentGO = gameObject;
		ModelInfo combinedMeshes = MeshUtil.CombineMeshes(parentGO, meshInfos);
		ReceiveCombinedMeshAndDespawn(combinedMeshes);
	}

	private IEnumerator CombineMeshesAsync(IList<CombineableMesh> combineableMeshes)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void UpdateToCombinedMesh(ModelInfo combinedMeshes)
	{
		if (combinedMeshes != null)
		{
			string text = name;
			string text2 = text + "_combined";
			combinedMeshes.Mesh.name = text2;
			_meshFilter.mesh = combinedMeshes.Mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
			_meshRenderer.enabled = true;
			_usingCombinedMesh = true;
		}
	}

	protected override void GetSpawnedObjects(List<Selector> selectors)
	{
	}

	private void ReceiveCombinedMeshAndDespawn(ModelInfo combinedMeshes)
	{
		//IL_0048: Expected Obj, but got I
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0093: Expected Obj, but got I
		//IL_00df: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		UpdateToCombinedMesh(combinedMeshes);
		if (combinedMeshes != null)
		{
			_meshContainer.AddGroup(_spawnedCombineableMeshGroup, combinedMeshes);
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S5_v4 (Il2CppClass<Il2CppMethodRgctx<SYBO.Common.Utilities.GameObjectUtil::GetComponentsInChildrenBFS>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v12+C]");
			object obj = 0;
			object obj5 = default;
			while (true)
			{
				object obj2 = obj - 1;
				if ((nint)obj2 <= -1)
				{
					break;
				}
				object obj3 = obj2 << 2;
				object obj4 = obj5 + obj3;
				object obj6 = obj2 << 2;
				object obj7 = obj5 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v23+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v24+14]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v20+10]");
					((TrackObject)0).Deactivate();
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v20+10]");
					Placeholder component = ((Component)0).GetComponent<Placeholder>();
					component.DespawnInstances();
				}
				obj = obj2;
			}
			base.DespawnInstances();
		}
		_isCombiningMeshes = false;
	}

	protected override void DespawnInstances()
	{
		//IL_0031: Expected VT, but got Obj
		//IL_0045: Expected Obj, but got VT
		if (~(_isCombiningMeshes ? 1u : 0u) == 0)
		{
			_meshContainer.NotifyMeshGroupCombineCanceled(_spawnedCombineableMeshGroup);
			_spawnedCombineableMeshGroup = null;
			_isCombiningMeshes = false;
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			((WorkLoadQueue)val).CancelWork(_meshCombiningRoutine);
		}
		if (~(_usingCombinedMesh ? 1u : 0u) == 0 && !_spawnedOnceOnStart)
		{
			_meshFilter.mesh = null;
			_meshRenderer.enabled = false;
			_usingCombinedMesh = false;
		}
		else
		{
			_placeholder.DespawnInstances();
		}
	}

	private unsafe void OnValidate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		//IL_01de: Expected I, but got Obj
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected I4, but got Unknown
		//IL_01c4: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		PlaceholderPrefabProviderBase component = GetComponent<PlaceholderPrefabProviderBase>();
		if (!(component == null))
		{
			object obj3 = 0;
			object obj5 = default;
			UnityEngine.Object obj7 = default;
			while (true)
			{
				nint num = (nint)component;
				object obj4 = component + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S1_v14 (Il2CppClass<SYBO.Subway.Placeholders.PrefabProviders.PlaceholderPrefabProviderBase>)+DC] (should have been resolved before IL gen)");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3))
				{
					break;
				}
				object obj6 = component - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S2_v10+BC] (should have been resolved before IL gen)");
				if (obj7 == null)
				{
					int num2 = obj + 12;
					string text = ((int*)num2)->ToString();
					Transform transform = ((Component)obj7).transform;
					string longName = Utils.GetLongName(transform);
					string text2 = "ModelSelectionPlaceholderLifecycle: NULL prefabs at index " + text + " in PlaceholderPrefabProvider at " + longName;
				}
				else
				{
					CombineableMeshGroup component2 = ((Component)obj7).GetComponent<CombineableMeshGroup>();
					if (component2 == null)
					{
						Transform transform2 = ((Component)obj7).transform;
						string longName2 = Utils.GetLongName(transform2);
						string text3 = "ModelSelectionPlaceholderLifecycle: Model prefab missing CombineableMeshGroup component " + longName2;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				object obj8 = (nint)0 + (nint)1;
				obj3 = obj8;
			}
		}
		else
		{
			Transform transform3 = base.transform;
			string longName3 = Utils.GetLongName(transform3);
			string text4 = "ModelSelectionPlaceholderLifecycle: Missing a PlaceholderPrefabProvider at " + longName3;
		}
	}
}
