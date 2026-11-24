using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Common.Visuals;

public class CombineableMesh : MonoBehaviour
{
	private sealed class _003CCombineMeshesAsync_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IList<CombineableMesh> combineableMeshes;

		public CombineableMesh _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0078: Unknown result type (might be due to invalid IL or missing references)
				//IL_007d: Expected Obj, but got Unknown
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0092: Expected Obj, but got Unknown
				//IL_00c8: Expected Obj, but got I4
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

		public _003CCombineMeshesAsync_003Ed__17(int _003C_003E1__state)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00a6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(EventArgs);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.EventArgs>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = this + 8;
			obj2 = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return (byte)_003C_003E1__state != 0;
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
			//IL_0038: Expected Obj, but got I4
			MeshRenderer meshRenderer = _meshRenderer;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (UnityEngine.MeshRenderer)+C]");
			if ((nint)0 != 0)
			{
				return null;
			}
			Mesh originalMesh = _originalMesh;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v14 (UnityEngine.Mesh)+C]");
			bool flag = (nint)0 == 0;
			return (MeshRenderer)flag;
		}
	}

	public MeshFilter MeshFilter
	{
		get
		{
			MergeSubmeshes();
			return (MeshFilter)(object)_meshRenderer;
		}
	}

	public ObjectModelInfo MeshInfo
	{
		get
		{
			MergeSubmeshes();
			return (ObjectModelInfo)(object)_meshFilter;
		}
	}

	private void Awake()
	{
		CancelInvoke();
	}

	private void InitializeCheck()
	{
		MergeSubmeshes();
	}

	private unsafe void MergeSubmeshes()
	{
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected I, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected VT, but got Obj
		//IL_0021: Expected Obj, but got VT
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_005b: Expected I, but got Obj
		//IL_0071: Expected Obj, but got I
		//IL_03ca: Expected I, but got Obj
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_009c: Expected I, but got Obj
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected Obj, but got Unknown
		//IL_04f7: Expected I, but got Obj
		//IL_0146: Expected I, but got Obj
		//IL_015c: Expected Obj, but got I
		//IL_0187: Expected I, but got Obj
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_023c: Expected I, but got Obj
		//IL_0298: Expected I, but got Obj
		//IL_02ae: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		object obj = default;
		nint num = (nint)(obj + 8);
		object obj2 = obj + 4;
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return;
		}
		object obj3 = this + 28;
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		obj3 = val;
		object obj4 = this + 20;
		Renderer component = GetComponent<Renderer>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj5 = default;
		obj4 = obj5;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v24 (Il2CppClass<System.Type>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v83 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = typeof(MeshFilter);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Type t = Type.internal_from_handle((IntPtr)num);
		Component componentInParent = GetComponentInParent(t);
		object obj7 = this + 24;
		Component component2;
		if ((object)componentInParent == null)
		{
			component2 = null;
		}
		else
		{
			component2 = (((object)componentInParent.GetType() != typeof(MeshFilter)) ? null : componentInParent);
		}
		obj7 = component2;
		object obj8 = this + 16;
		Mesh mesh = _meshFilter.mesh;
		obj8 = mesh;
		obj = typeof(PerformanceLevelModelSwap);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type t2 = Type.internal_from_handle((IntPtr)num);
		Component componentInParent2 = GetComponentInParent(t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v44 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			((PerformanceLevelModelSwap)(object)computeShader)._002Ector();
		}
		if (~(_combineSubmeshesLowEndDevice ? 1u : 0u) == 0)
		{
			nint num6 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v56 (Il2CppClass<DeviceInfo>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num7 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v74 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v61 (System.Int32)+8]");
			if ((nint)0 == 0)
			{
				Mesh mesh2 = _meshFilter.mesh;
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v52 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mesh2).FindKernel((string)null) != 0)
				{
					Mesh mesh3 = _meshFilter.mesh;
					int subMeshCount = mesh3.subMeshCount;
					if (subMeshCount <= 3999)
					{
						this._002Ector();
					}
				}
			}
		}
		_initialized = true;
	}

	private IEnumerator CombineMeshesAsync(IList<CombineableMesh> combineableMeshes)
	{
		return (IEnumerator)(object)((Animation)(object)_originalMesh).get_Item((string)(object)combineableMeshes);
	}

	private unsafe void UpdateToCombinedMesh(ModelInfo combinedMesh)
	{
		//IL_02e6: Expected I, but got Obj
		//IL_02fc: Expected Obj, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected I4, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0324: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		//IL_0104: Expected I4, but got Obj
		//IL_0120: Expected I4, but got Obj
		//IL_013c: Expected I4, but got Obj
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01bd: Expected I4, but got Obj
		//IL_01e1: Expected I, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_0355: Expected Obj, but got I4
		//IL_0375: Expected I4, but got Obj
		//IL_0222: Expected I, but got Obj
		//IL_038b: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v62 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		int num3 = obj2 + 32;
		object obj3 = obj2 + 24;
		SubMeshInfo subMeshInfo = (SubMeshInfo)(obj2 + 16);
		object obj4 = obj2 + 8;
		if (_meshRenderer != null)
		{
			return;
		}
		bool isPlaying = ((Animation)(object)_meshRenderer).isPlaying;
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)isPlaying != null)
		{
			return;
		}
		obj3 = combinedMesh;
		((int*)num3)->m_value = (int)obj3;
		subMeshInfo._002Ector((MeshFilter)(object)this, num3, null);
		((int*)num3)->m_value = (int)subMeshInfo;
		_combineSubmeshesLowEndDevice = (byte)((int*)num3)->m_value != 0;
		((int*)num3)->m_value = (int)combinedMesh;
		obj4 = combinedMesh;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v9 (System.Int32)+4]");
		object obj6 = 0 - obj4;
		obj2 = combinedMesh;
		float time = Time.time;
		float num6 = (float)obj6 * time;
		float num7 = (float)obj2 + num6;
		bool isPlaying2 = ((Animation)(object)_meshRenderer).isPlaying;
		UnityEngine.Object obj7 = UnityEngine.Object.Instantiate((UnityEngine.Object)isPlaying2);
		bool flag = ((Animation)(object)_meshRenderer).Play((PlayMode)obj7);
		float distance = (flag ? ((RaycastHit*)1) : ((RaycastHit*)null))->distance;
		nint num8 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v37 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v44 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string original = ((AnimationState)flag).name;
		UnityEngine.Object obj9 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		bool flag2 = ((Animation)(object)_meshRenderer).Play((PlayMode)obj9);
		float normalizedTime;
		if (num7 < 0f)
		{
			normalizedTime = 0f;
		}
		else
		{
			normalizedTime = ((!(num7 > distance)) ? num7 : distance);
		}
		((AnimationState)flag2).normalizedTime = normalizedTime;
	}

	public unsafe CombineableMesh()
	{
		//IL_01cc: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005d: Expected I4, but got Obj
		//IL_00c6: Expected I4, but got Obj
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected Obj, but got Unknown
		ref ModelInfo reference = ref *(ModelInfo*)null;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v53 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_originalMesh).FindKernel((string)null) == 0)
		{
			return;
		}
		int num3 = Mesh.DefaultDimensionForChannel((VertexAttribute)_originalMesh);
		if (num3 <= 1)
		{
			return;
		}
		if (_meshContainer.TryGetGroupMesh((CombineableMeshGroup)(object)_originalMesh, out reference))
		{
			((MeshCombiner)this).Combine((byte)(int)reference != 0);
			return;
		}
		if (_meshContainer.HasGroupMesh((CombineableMeshGroup)(object)_originalMesh))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num4 = 0;
			_ = 0;
			Action<ModelInfo> action = default;
			object obj2 = action + 16;
			obj2 = this;
			_meshContainer.RemoveMeshCombinedCallback(_originalMesh, action);
			return;
		}
		_meshContainer.NotifyMeshCombineFailed(_originalMesh);
		_startedMeshCombining = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
