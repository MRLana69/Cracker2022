using System;
using Cpp2ILInjected;
using UnityEngine;

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

	private float _loopDuration = 1f;

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
			return _animate;
		}
		set
		{
			_animate = value;
		}
	}

	public void Reset()
	{
		if (Application.isPlaying)
		{
			_animTime = 0f;
			SetMorph(0f);
		}
	}

	private void BuildMesh(int idx1, int idx2, float t)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_010e: Expected Obj, but got I
		//IL_0151: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		float num = System.Math.Min(t, 1f);
		bool flag = t < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		int num3 = idx1 << 2;
		Vector3[][] morphTargetsVertices;
		if (_morphTargetsVertices != null)
		{
			morphTargetsVertices = _morphTargetsVertices;
		}
		else
		{
			Initialize();
			morphTargetsVertices = _morphTargetsVertices;
		}
		object obj3 = num3 + morphTargetsVertices;
		int num4 = idx2 << 2;
		object obj4 = _morphTargetsVertices + num4;
		object obj5 = 0;
		Vector3[] vertices;
		while (true)
		{
			vertices = _vertices;
			if (vertices.Length <= (nint)obj5)
			{
				break;
			}
			object obj6 = obj5 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v7+10]");
			object obj7 = 0 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v15+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v15+10]");
			_ = 0;
			object obj8 = obj5 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v12+10]");
			object obj9 = 0 + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v20+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v20+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			object obj10 = num5 - 0;
			float num6 = (float)obj10 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			float num7 = 0f + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+24]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			object obj11 = num8 - 0;
			float num9 = (float)obj11 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
			float num10 = 0f + num9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			object obj12 = num11 - 0;
			float num12 = (float)obj12 * num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			float num13 = 0f + num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			object obj13 = obj5 * 12;
			object obj14 = (object)vertices + obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj15 = obj5 + 1;
			obj5 = obj15;
		}
		_mesh.vertices = vertices;
	}

	private void SetMorph(float t)
	{
		//IL_001b: Expected F8, but got I4
		//IL_0133: Invalid comparison between F8 and I4
		//IL_0142: Expected F8, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected I4, but got Unknown
		//IL_0129: Expected I4, but got F8
		Mesh[] morphTargets = _morphTargets;
		double num = (double)morphTargets.Length - 2.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		double num2 = System.Math.Abs((double)t);
		double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)t));
		if (!(num3 > num))
		{
			num = num3;
		}
		bool flag = num3 < 0.0;
		double num4 = 0.0;
		if (!flag)
		{
			num4 = num;
		}
		float num5 = t - (float)num4;
		int idx = (int)(num4 + 1);
		float num6 = System.Math.Min(num5, 1f);
		bool flag2 = num5 < 0f;
		float t2 = 0f;
		if (!flag2)
		{
			t2 = num6;
		}
		BuildMesh((int)num4, idx, t2);
	}

	private void Awake()
	{
		Initialize();
	}

	private void Initialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		//IL_0061: Expected Obj, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Mesh[] morphTargets = _morphTargets;
		if (_morphTargets == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[][] morphTargetsVertices = default;
		_morphTargetsVertices = morphTargetsVertices;
		object obj3 = 0;
		Mesh[] morphTargets2 = _morphTargets;
		if (morphTargets2.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)morphTargets2 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v51+10]");
			Vector3[] vertices = ((Mesh)0).vertices;
			throw new ArrayTypeMismatchException();
		}
		Vector3[][] morphTargetsVertices2 = _morphTargetsVertices;
		Vector3[] array = morphTargetsVertices2[0];
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[] vertices2 = default;
		_vertices = vertices2;
		object obj6 = 0;
		while (true)
		{
			Vector3[] vertices3 = _vertices;
			if (vertices3.Length <= (nint)obj6)
			{
				break;
			}
			Vector3[][] morphTargetsVertices3 = _morphTargetsVertices;
			object obj7 = obj6 * 12;
			object obj8 = (object)morphTargetsVertices3[0] + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v35+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v35+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			obj = 0;
			object obj9 = obj6 * 12;
			object obj10 = (object)vertices3 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj11 = obj6 + 1;
			obj6 = obj11;
		}
		Mesh mesh = default;
		mesh._002Ector();
		_mesh = mesh;
		_mesh.MarkDynamic();
		_mesh.vertices = _vertices;
		Mesh[] morphTargets3 = _morphTargets;
		Vector2[] uv = morphTargets3[0].uv;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @378");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		Vector2[] uv2 = default;
		_mesh.uv = uv2;
		Mesh[] morphTargets4 = _morphTargets;
		int[] triangles = morphTargets4[0].triangles;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @378");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
		int[] triangles2 = default;
		_mesh.triangles = triangles2;
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			UnityEngine.Object.Destroy(_mesh);
		}
		else
		{
			UnityEngine.Object.DestroyImmediate(_mesh);
		}
	}

	private void OnEnable()
	{
		if (_targetMeshFilter != null)
		{
			_targetMeshFilter.sharedMesh = _mesh;
			if (_wrapMode == WrapMode.Once)
			{
				_animTime = 0f;
			}
		}
	}

	private void OnDisable()
	{
		if (_targetMeshFilter != null)
		{
			_targetMeshFilter.sharedMesh = null;
		}
	}

	private void Update()
	{
		//IL_009c: Expected Obj, but got I4
		//IL_00e7: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I4
		if (_morphTargets == null)
		{
			return;
		}
		DeviceInfo instance = DeviceInfo.Instance;
		if (instance.performanceLevel < _minPerformanceLevel || ~(_animate ? 1u : 0u) != 0)
		{
			return;
		}
		float morph;
		if (_animationType == AnimationType.Auto)
		{
			float deltaTime = Time.deltaTime;
			Mesh[] morphTargets = _morphTargets;
			object obj = morphTargets.Length - 1;
			float num = deltaTime * (float)obj;
			float num2 = num / _loopDuration;
			float num3 = (_animTime += num2);
			object obj2 = _wrapMode - 1;
			if (_wrapMode != WrapMode.Once)
			{
				if ((nint)obj2 == 1 || (nint)obj2 == 2 || (nint)obj2 != 3)
				{
					Mesh[] morphTargets2 = _morphTargets;
					float num4 = (float)morphTargets2.Length - 1f;
					float num5 = num3 / num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
					float num6 = num5 * num4;
					float num7 = num3 - num6;
					if (!(num7 > num4))
					{
						num4 = num7;
					}
					bool flag = num7 < 0f;
					morph = 0f;
					if (!flag)
					{
						morph = num4;
					}
				}
				else
				{
					Mesh[] morphTargets3 = _morphTargets;
					object obj3 = morphTargets3.Length - 1;
					float num8 = (float)obj3 + (float)obj3;
					float num9 = num3 / num8;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
					float num10 = num9 * num8;
					float num11 = num3 - num10;
					bool flag2 = num11 > num8;
					float num12 = num8;
					if (!flag2)
					{
						num12 = num11;
					}
					bool flag3 = num11 < 0f;
					float num13 = 0f;
					if (!flag3)
					{
						num13 = num12;
					}
					float value = num13 - (float)obj3;
					float num14 = System.Math.Abs(value);
					morph = (float)obj3 - num14;
				}
			}
			else
			{
				Mesh[] morphTargets4 = _morphTargets;
				float num15 = (float)morphTargets4.Length - 1f;
				bool flag4 = num3 < 0f;
				morph = 0f;
				if (!flag4)
				{
					if (!(num3 > num15))
					{
						num15 = num3;
					}
					morph = num15;
				}
			}
		}
		else
		{
			morph = _animTime;
		}
		SetMorph(morph);
	}
}
