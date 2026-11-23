using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Common.Visuals;

public class CombineableMesh : MonoBehaviour
{
	private sealed class _003CCombineMeshesAsync_003Ed__17(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public IList<CombineableMesh> combineableMeshes;

		public CombineableMesh _003C_003E4__this;

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

	public const int CombineableMeshVertexLimit = 4000;

	private bool _combineSubmeshesLowEndDevice;

	private bool _initialized;

	private Mesh _originalMesh;

	private MeshRenderer _meshRenderer;

	private MeshFilter _meshFilter;

	private MeshContainer _meshContainer;

	private bool _startedMeshCombining;

	public MeshRenderer MeshRenderer
	{
		get
		{
			InitializeCheck();
			return _meshRenderer;
		}
	}

	public MeshFilter MeshFilter
	{
		get
		{
			InitializeCheck();
			return _meshFilter;
		}
	}

	public ObjectModelInfo MeshInfo
	{
		get
		{
			InitializeCheck();
			ObjectModelInfo objectModelInfo = default;
			objectModelInfo.MeshRenderer = _meshRenderer;
			objectModelInfo.MeshFilter = _meshFilter;
			return objectModelInfo;
		}
	}

	private void Awake()
	{
		InitializeCheck();
	}

	private void InitializeCheck()
	{
		//IL_000e: Expected VT, but got Obj
		//IL_0018: Expected Obj, but got VT
		//IL_0059: Expected VT, but got Obj
		//IL_0225: Expected VT, but got Obj
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		_meshContainer = (MeshContainer)val;
		Renderer component = GetComponent<Renderer>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		MeshRenderer meshRenderer = default;
		_meshRenderer = meshRenderer;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(MeshFilter));
		Component component2 = GetComponent(typeFromHandle);
		bool flag = (object)component2 == null;
		Component meshFilter = null;
		if (!flag)
		{
			bool flag2 = (object)component2.GetType() == typeof(MeshFilter);
			meshFilter = component2;
			if (!flag2)
			{
				meshFilter = null;
			}
		}
		_meshFilter = (MeshFilter)meshFilter;
		if ((object)component2 != null)
		{
			return;
		}
		Mesh sharedMesh = _meshFilter.sharedMesh;
		_originalMesh = sharedMesh;
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(PerformanceLevelModelSwap));
		Component component3 = GetComponent(typeFromHandle2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		UnityEngine.Object obj = default;
		bool flag3 = obj != null;
		if (~(_combineSubmeshesLowEndDevice ? 1u : 0u) == 0)
		{
			DeviceInfo instance = DeviceInfo.Instance;
			if (instance.performanceLevel == DeviceInfo.PerformanceLevel.Low)
			{
				Mesh sharedMesh2 = _meshFilter.sharedMesh;
				if (sharedMesh2 != null)
				{
					Mesh sharedMesh3 = _meshFilter.sharedMesh;
					int vertexCount = sharedMesh3.vertexCount;
					if (vertexCount <= 3999)
					{
						MergeSubmeshes();
					}
				}
			}
		}
		_initialized = true;
	}

	private unsafe void MergeSubmeshes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Ref, but got Unknown
		//IL_0091: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!(_originalMesh != null))
		{
			return;
		}
		int subMeshCount = _originalMesh.subMeshCount;
		if (subMeshCount < 2)
		{
			return;
		}
		if (_meshContainer.TryGetMesh(_originalMesh, out *(ModelInfo*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			UpdateToCombinedMesh((ModelInfo)0);
			return;
		}
		if (_meshContainer.IsMeshCombineInProgress(_originalMesh))
		{
			throw new ArgumentException();
		}
		_meshContainer.NotifyMeshCombineInProgress(_originalMesh);
		_startedMeshCombining = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private IEnumerator CombineMeshesAsync(IList<CombineableMesh> combineableMeshes)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void UpdateToCombinedMesh(ModelInfo combinedMesh)
	{
		if (combinedMesh != null)
		{
			_meshFilter.mesh = combinedMesh.Mesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B24");
			if (~(_startedMeshCombining ? 1u : 0u) == 0)
			{
				string text = _originalMesh.name;
				string text2 = text + "_combined";
				combinedMesh.Mesh.name = text2;
				_meshContainer.AddMesh(_originalMesh, combinedMesh);
				_startedMeshCombining = false;
			}
		}
	}
}
