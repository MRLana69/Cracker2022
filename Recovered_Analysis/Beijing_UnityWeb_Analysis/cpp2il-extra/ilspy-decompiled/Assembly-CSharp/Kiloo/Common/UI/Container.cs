using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.UI;

public class Container
{
	public Action onRecycleContainer;

	public Action onPositionContainer;

	public long rowId;

	public GameObject model;

	public Vector2 coordinates;

	private readonly Transform _modelTransform;

	public Bounds bounds;

	public int dataIndex;

	public int modelType;

	public float height;

	public float width;

	public bool isMeasured;

	private bool _parentSet;

	private bool _scaleSet;

	public object tag;

	private bool hasTransientState__BackingField;

	public float top;

	public float bottom;

	public float right;

	public float left;

	public Transform modelTransform => null;

	public bool hasTransientState
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_modelTransform != 0;
		}
		set
		{
			if (onRecycleContainer != null)
			{
				onRecycleContainer(value ? 1 : 0);
			}
		}
	}

	public Container(GameObject model)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(model & 1) != 0;
		hasTransientState__BackingField = flag;
	}

	public virtual void Measure(bool includeInactive = true)
	{
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_017e: Expected VT, but got Obj
		//IL_018c: Expected I, but got Obj
		//IL_01a2: Expected Obj, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_011b: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I4
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v35 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		object obj3 = default;
		object obj2 = obj3 + 8;
		obj2 = obj3;
		coordinates = (Vector2)obj2;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 24;
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)includeInactive);
		obj5 = gameObject;
		if (((ComputeShader)(object)model).FindKernel((string)null) != 0)
		{
			object obj6 = this + 36;
			int layer = model.layer;
			obj6 = layer;
		}
	}

	public void SetPosition()
	{
	}

	public void SetParent(Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00d3: Expected F4, but got Obj
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		//IL_00ff: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 + 40;
		object obj3 = obj2 + 16;
		if (~(isMeasured ? 1u : 0u) != 0)
		{
			int layer = model.layer;
			Bounds bounds = NGUIMath.CalculateRelativeWidgetBounds((Transform)layer, parent);
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
			_ = 0;
			object obj4 = this + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+10]");
			_ = 0;
			object obj5 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			width = (float)obj;
			object obj6 = this + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			height = 0f;
			isMeasured = true;
		}
	}

	public void SetScale(Vector3 scale)
	{
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got VT
		//IL_0021: Expected Obj, but got I4
		//IL_0043: Expected I, but got Obj
		//IL_0059: Expected Obj, but got I
		//IL_0084: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 16);
		if (~(_parentSet ? 1u : 0u) == 0)
		{
			return;
		}
		int layer = model.layer;
		((Transform)layer).parentInternal = (Transform)scale;
		int layer2 = model.layer;
		nint num = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v9 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v18 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		_parentSet = true;
	}

	public unsafe void SetModelType(int mType)
	{
		//IL_004b: Expected Obj, but got I4
		//IL_006d: Expected Obj, but got I4
		if (~(_scaleSet ? 1u : 0u) != 0)
		{
			_scaleSet = true;
			int layer = model.layer;
			Transform transform = (Transform)((int*)mType)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [mType @ L1 (System.Int32)+8]");
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
			((Transform)layer).parent = transform;
		}
	}

	public override string ToString()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = hasTransientState__BackingField;
		return (string)flag;
	}
}
