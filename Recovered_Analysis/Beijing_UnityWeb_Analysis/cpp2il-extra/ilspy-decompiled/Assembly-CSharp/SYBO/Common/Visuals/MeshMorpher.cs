using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using SYBO.Common.Managers;
using SYBO.Common.Utilities;
using SYBO.Components.Analytics.Integration;
using SYBO.Subway;
using SYBO.Subway.Level.Environments;
using SYBO.Subway.Placeholders;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.U2D;

namespace SYBO.Common.Visuals;

public class MeshMorpher : MonoBehaviour
{
	private enum AnimationType
	{
		Auto,
		Manual
	}

	private MeshFilter _targetMeshFilter;

	private Mesh[] _morphTargets;

	private float _loopDuration;

	private WrapMode _wrapMode;

	private bool _animate;

	private AnimationType _animationType;

	private float _animTime;

	private DeviceInfo.PerformanceLevel _minPerformanceLevel;

	private Mesh _mesh;

	private Vector3[] _vertices;

	private Vector3[][] _morphTargetsVertices;

	public bool Animate
	{
		get
		{
			//IL_0102: Expected Obj, but got F4
			//IL_0052: Expected Obj, but got F4
			//IL_0064: Expected Obj, but got I4
			//IL_0015: Expected Obj, but got I4
			//IL_0024: Expected Obj, but got F4
			//IL_0031: Expected Obj, but got I4
			//IL_00a9: Expected I4, but got Obj
			//IL_0042: Expected I4, but got Obj
			//IL_00ca: Expected Obj, but got F4
			//IL_00ca: Expected Obj, but got I4
			//IL_00d3: Expected Obj, but got I4
			//IL_00e1: Expected Obj, but got I4
			//IL_00ed: Expected I4, but got Obj
			int siblingIndex = ((Transform)_loopDuration).GetSiblingIndex();
			if (siblingIndex > (int)_wrapMode)
			{
				Sprite sprite = (Sprite)(_wrapMode - 1);
				bool flag = ((SpriteAtlas)_loopDuration).CanBindTo(sprite);
				string text = ((Component)flag).tag;
				return (byte)(int)text != 0;
			}
			int siblingIndex2 = ((Transform)_loopDuration).GetSiblingIndex();
			object obj = siblingIndex2 + 1;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text3 = default;
			string text2 = "combinedMeshes_" + text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)text2;
			int layer = gameObject.layer;
			((Transform)layer).parentInternal = (Transform)_loopDuration;
			GameObjectUtil.ResetLocalRotation((Transform)layer);
			string text4 = ((Component)layer).tag;
			return (byte)(int)text4 != 0;
		}
		set
		{
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Expected Obj, but got Unknown
			//IL_036a: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0449: Expected I, but got Obj
			//IL_045f: Expected Obj, but got I
			//IL_0126: Expected Obj, but got I4
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected I4, but got Unknown
			//IL_017f: Expected I, but got Obj
			//IL_0409: Expected Obj, but got I4
			//IL_0412: Expected Obj, but got I4
			//IL_041b: Expected Obj, but got I4
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected Obj, but got Unknown
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_023b: Expected Obj, but got Unknown
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected Obj, but got Unknown
			//IL_028f: Expected I4, but got Obj
			//IL_02a1: Expected Obj, but got I4
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Expected Obj, but got Unknown
			//IL_02cd: Expected Obj, but got I4
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Expected Obj, but got Unknown
			//IL_0302: Expected Obj, but got I4
			//IL_0334: Expected Obj, but got I4
			((MeshCombiner)this).CombineInactive();
			object obj = this + 16;
			CombineableMesh[] componentsInChildren = GetComponentsInChildren<CombineableMesh>(value);
			obj = componentsInChildren;
			object obj2 = 0;
			int num = 0;
			while (true)
			{
				Mesh[] morphTargets = _morphTargets;
				if ((nint)obj2 >= morphTargets.Length)
				{
					break;
				}
				object obj3 = _morphTargets + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				ObjectModelInfo meshInfo = ((CombineableMesh)obj5).MeshInfo;
				Mesh mesh = ((MeshFilter)(object)meshInfo).mesh;
				int subMeshCount = mesh.subMeshCount;
				int num2 = subMeshCount + num;
				object obj6 = obj2 + 1;
				obj2 = obj6;
				num = num2;
			}
			if (num >= 65535)
			{
				((MeshCombiner)this)._002Ector();
			}
			int num3 = num / 65534;
			object obj7 = num3 + 1;
			int num4;
			if (obj7 != null)
			{
				bool flag = num == int.MinValue;
				bool flag2 = (nint)obj7 == -1;
				object obj8 = flag & flag2;
				num4 = ((obj8 == null) ? (num / obj7) : 0);
			}
			else
			{
				num4 = 0;
			}
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v62 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			int capacity = ((num >= 65534) ? 65534 : num);
			List<ObjectModelInfo> list = default;
			list._002Ector(capacity);
			Mesh[] morphTargets2 = _morphTargets;
			object obj10 = morphTargets2.Length - 1;
			object obj11 = 0;
			object obj12 = 0;
			ObjectModelInfo objectModelInfo = default;
			while (true)
			{
				Mesh[] morphTargets3 = _morphTargets;
				if ((nint)obj11 < morphTargets3.Length)
				{
					object obj13 = _morphTargets + 16;
					object obj14 = obj11 << 2;
					object obj15 = obj13 + obj14;
					MeshFilter meshFilter = ((CombineableMesh)obj15).MeshFilter;
					ObjectModelInfo meshInfo2 = ((CombineableMesh)obj15).MeshInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj16 = objectModelInfo + 8;
					obj16 = meshFilter;
					object obj17 = objectModelInfo + 12;
					obj17 = meshInfo2;
					list.Add(objectModelInfo);
					bool flag3 = obj11 == obj10;
					ObjectModelInfo meshInfo3 = ((CombineableMesh)obj15).MeshInfo;
					bool flag4 = GraphicsFormatUtility.IsSRGBFormat((GraphicsFormat)meshInfo3);
					int subMeshCount2 = ((Mesh)flag4).subMeshCount;
					object obj18 = subMeshCount2 + obj12;
					bool flag5 = num4 < (nint)obj18;
					object obj19 = flag3 | flag5;
					if (obj19 != null)
					{
						bool animate = Animate;
						((AnimationPlaceholderInitializer)this).Initialize((Placeholder)animate, (Transform)(object)list);
						WrapMode wrapMode = _wrapMode + 1;
						_wrapMode = wrapMode;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
						obj12 = 0;
					}
					object obj20 = obj11 + 1;
					obj11 = obj20;
					continue;
				}
				break;
			}
		}
	}

	public void Reset()
	{
		CancelInvoke();
	}

	private unsafe void BuildMesh(int idx1, int idx2, float t)
	{
		//IL_009e: Expected I, but got Obj
		//IL_00b4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((UILabel)(object)_targetMeshFilter).fontSize = idx1;
		UIWidget.Pivot pivot = default;
		((UIWidget.Pivot*)(int)pivot)->value__ = ((int*)idx2)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [idx2 @ L2 (System.Int32)+8]");
		_ = 0;
		((UIWidget)(object)_targetMeshFilter).rawPivot = pivot;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v16 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = System.Math.Abs(t);
		float f = num3 * 2f;
		int height = NumberExtensions.CeilToInt(f);
		((UIWidget)(object)_morphTargets).height = height;
	}

	private unsafe void SetMorph(float t)
	{
		//IL_00f5: Expected VT, but got I4
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0048: Expected I, but got Obj
		//IL_005e: Expected Obj, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0089: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		float characterDeltaZ = t * 0.001f;
		DistantEnvironmentController distantEnvironmentController = default;
		distantEnvironmentController.UpdateDistantEnvironment(characterDeltaZ, (Vector3)10);
		object obj = this + 8;
		obj = distantEnvironmentController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(PerformanceTracker.Game_OnGameStarted);
		object obj2 = action + 16;
		obj2 = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v17 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v29 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(PerformanceTracker.Game_OnGameEnded);
		object obj4 = action2 + 16;
		obj4 = this;
		Game.OnGameEnded -= action2;
	}

	private void Awake()
	{
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			_animTime = 0f;
			((TimeScaleManager)this).TimeScale = 0f;
		}
	}

	private void Initialize()
	{
		OnDestroy();
	}

	private void OnDestroy()
	{
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		if (_morphTargets == null)
		{
			return;
		}
		object obj3 = this + 52;
		Mesh[] morphTargets = _morphTargets;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Mesh[] morphTargets2 = _morphTargets;
		object obj5 = default;
		if ((nint)obj5 < morphTargets2.Length)
		{
			object obj6 = _morphTargets + 16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			Vector3[] normals = ((Mesh)obj8).normals;
			throw new ArrayTypeMismatchException();
		}
		object obj9 = this + 48;
		object obj10 = _morphTargetsVertices + 16;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj12 = default;
		obj9 = obj12;
		object obj13 = 0;
		while (true)
		{
			Vector3[] vertices = _vertices;
			if ((nint)obj13 >= vertices.Length)
			{
				break;
			}
			object obj14 = _morphTargetsVertices + 16;
			object obj15 = obj14 + 16;
			object obj16 = obj13 * 12;
			object obj17 = obj15 + obj16;
			obj2 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S2_v27+8]");
			_ = 0;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj18 = _vertices + 16;
			object obj19 = obj13 * 12;
			object obj20 = obj18 + obj19;
			obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj21 = obj13 + 1;
			obj13 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Mesh mesh = default;
		Mesh.Internal_Create(mesh);
		object obj22 = this + 44;
		obj22 = mesh;
		((Texture)(object)_mesh)._002Ector();
		_mesh.normals = _vertices;
		object obj23 = _morphTargets + 16;
		Vector2[] uv = ((Mesh)obj23).uv2;
		OverflowException ex = new OverflowException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		Vector2[] uv2 = default;
		_mesh.uv2 = uv2;
		object obj24 = _morphTargets + 16;
		int dataWidth = ((Texture)obj24).GetDataWidth();
		OverflowException ex2 = new OverflowException();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		int width = default;
		((Texture)(object)_mesh).width = width;
	}

	private void OnEnable()
	{
		//IL_00ff: Expected I, but got Obj
		//IL_0115: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		RuntimePlatform platform = Application.platform;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		if (platform != RuntimePlatform.OSXEditor)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(_mesh);
			return;
		}
		if (!flag)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DontDestroyOnLoad(_mesh);
	}

	private void OnDisable()
	{
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_targetMeshFilter != null))
		{
			_targetMeshFilter.mesh = _mesh;
			if (_wrapMode == WrapMode.Once)
			{
				_animTime = 0f;
			}
		}
	}

	private void Update()
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_targetMeshFilter).FindKernel((string)null) != 0)
		{
			_targetMeshFilter.mesh = null;
		}
	}

	public MeshMorpher()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I4
		//IL_032b: Expected I, but got Obj
		//IL_0341: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_042f: Expected I, but got Obj
		//IL_02ca: Expected I, but got Obj
		//IL_03ac: Expected I, but got Obj
		if (_morphTargets == null)
		{
			return;
		}
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v14 (System.Int32)+8]");
		if ((nint)0 < (nint)_minPerformanceLevel || ~(_animate ? 1u : 0u) != 0)
		{
			return;
		}
		if (_animationType != AnimationType.Auto)
		{
			((TimeScaleManager)this).TimeScale = _animTime;
			return;
		}
		float unscaledTime = Time.unscaledTime;
		Mesh[] morphTargets = _morphTargets;
		object obj2 = morphTargets.Length - 1;
		float num3 = unscaledTime * (float)obj2;
		float num4 = num3 / _loopDuration;
		float animTime = _animTime + num4;
		_animTime = animTime;
		float num7;
		if (_wrapMode == WrapMode.Once)
		{
			Mesh[] morphTargets2 = _morphTargets;
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v22 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S2_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num7 = (float)morphTargets2.Length - 1f;
			if (_animTime < 0f)
			{
				num7 = 0f;
			}
			else if (!(_animTime > num7))
			{
				num7 = _animTime;
			}
		}
		else if (_wrapMode == WrapMode.PingPong)
		{
			Mesh[] morphTargets3 = _morphTargets;
			nint num8 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S3_v13 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S3_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float target = (float)morphTargets3.Length - 1f;
			num7 = Mathf.DeltaAngle(_animTime, target);
		}
		else
		{
			num7 = _animTime;
			Mesh[] morphTargets4 = _morphTargets;
			nint num10 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			bool flag = obj5 == null;
			if (_wrapMode == WrapMode.Once)
			{
				if (!flag)
				{
					nint num11 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S1_v45 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num12 = (float)morphTargets4.Length - 1f;
				if (!(num7 < num12))
				{
					num7 = num12;
				}
			}
			else
			{
				if (!flag)
				{
					nint num13 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S1_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float length = (float)morphTargets4.Length - 1f;
				num7 = Mathf.PingPong(num7, length);
			}
		}
		((TimeScaleManager)this).TimeScale = num7;
	}
}
